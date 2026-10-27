using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020024EE RID: 9454
[NullableContext(1)]
[Nullable(0)]
public class VisionRecommendView : UiViewBase
{
	// Token: 0x0601303A RID: 77882 RVA: 0x004B53AE File Offset: 0x004B35AE
	public VisionRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601303B RID: 77883 RVA: 0x004B53B8 File Offset: 0x004B35B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickGoFetterGroupDetailViewBtn))
		};
	}

	// Token: 0x0601303C RID: 77884 RVA: 0x004B54A4 File Offset: 0x004B36A4
	protected override void OnStart()
	{
		IVisionRecommendViewOpenParam visionRecommendViewOpenParam = this.OpenParam as IVisionRecommendViewOpenParam;
		if (visionRecommendViewOpenParam == null)
		{
			return;
		}
		this.CurrentSelectRoleId = visionRecommendViewOpenParam.RoleId;
		this.IsFromRoleDev = visionRecommendViewOpenParam.IsFromRoleDev;
		this.OnChangeFetterGroupSuccessCallBack = visionRecommendViewOpenParam.SuccessCallBack;
		this.GetSelectedPlanIdCallBack = visionRecommendViewOpenParam.GetSelectedPlanIdCallBack;
		this.FetterItemLayout = new GenericLayout<FetterItemContent, FetterGroupContentData>(base.GetVerticalLayout(0), new Func<FetterItemContent>(this.InitGridItem), null, false, true);
		this.Layout = new GenericLayout<VisionFetterDescItem, VisionFetterDescData>(base.GetVerticalLayout(4), new Func<VisionFetterDescItem>(this.InitItem), null, false, true);
		this.InitBtnConfirmChange();
		this.InitBtnConfirmBox();
		this.RefreshButtonVisibility();
	}

	// Token: 0x0601303D RID: 77885 RVA: 0x004B5545 File Offset: 0x004B3745
	private void InitBtnConfirmChange()
	{
		this.BtnConfirmChange = new ButtonItem(base.GetItem(7));
		this.BtnConfirmChange.SetLocalTextNew("RoleProject_PhantomRecommend_Tips01", Array.Empty<object>());
		this.BtnConfirmChange.SetFunction(new Action<int>(this.OnClickBtnConfirmChange));
	}

	// Token: 0x0601303E RID: 77886 RVA: 0x004B5585 File Offset: 0x004B3785
	private void InitBtnConfirmBox()
	{
		this.BtnConfirmBox = new ButtonItem(base.GetItem(6));
		this.BtnConfirmBox.SetLocalTextNew("PrefabTextItem_PhantomQuickEquip_Text", Array.Empty<object>());
		this.BtnConfirmBox.SetFunction(new Action<int>(this.OnClickConfirmBoxBtn));
	}

	// Token: 0x0601303F RID: 77887 RVA: 0x004B55C8 File Offset: 0x004B37C8
	private void RefreshButtonVisibility()
	{
		UUIItem item = base.GetItem(6);
		UUIItem item2 = base.GetItem(7);
		if (this.IsFromRoleDev)
		{
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (item2 != null)
			{
				item2.SetUIActive(true);
				return;
			}
		}
		else
		{
			if (item != null)
			{
				item.SetUIActive(true);
			}
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
	}

	// Token: 0x06013040 RID: 77888 RVA: 0x004B5616 File Offset: 0x004B3816
	private VisionFetterDescItem InitItem()
	{
		return new VisionFetterDescItem();
	}

	// Token: 0x06013041 RID: 77889 RVA: 0x004B561D File Offset: 0x004B381D
	private FetterItemContent InitGridItem()
	{
		return new FetterItemContent();
	}

	// Token: 0x06013042 RID: 77890 RVA: 0x004B5624 File Offset: 0x004B3824
	private void OnClickConfirmBoxBtn(int _)
	{
		this.TryOneKeyEquip();
	}

	// Token: 0x06013043 RID: 77891 RVA: 0x004B562C File Offset: 0x004B382C
	private void TryOneKeyEquip()
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo recommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.CurrentSelectRoleId, true);
		if (roleDataById == null)
		{
			return;
		}
		if (!PhantomBattleModel.Instance.GetRoleIfEquipVision(roleDataById.GetRoleId()))
		{
			int[] recommendEquipUniqueIdList = VisionRecommendModel.Instance.GetRecommendEquipUniqueIdList(roleDataById.GetRoleId(), recommendInfo);
			if (recommendEquipUniqueIdList != null)
			{
				PhantomBattleController.Instance.SendPhantomAutoPutRequest(roleDataById.GetRoleId(), recommendEquipUniqueIdList.ToList<int>(), null);
				UiManager.Instance.CloseView(EUiViewName.VisionRecommendView, null);
				return;
			}
		}
		else
		{
			this.DoOpenSupplementConfirmBox();
		}
	}

	// Token: 0x06013044 RID: 77892 RVA: 0x004B56D0 File Offset: 0x004B38D0
	private void DoOpenSupplementConfirmBox()
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo currentSelectRecommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
		RoleDataBase roleInstance = RoleModel.Instance.GetRoleDataById(this.CurrentSelectRoleId, true);
		if (roleInstance == null)
		{
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomSupplementTips);
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			ConfirmBoxController.Instance.CloseConfirmBoxView();
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			int[] recommendEquipUniqueIdList = VisionRecommendModel.Instance.GetRecommendEquipUniqueIdList(roleInstance.GetRoleId(), currentSelectRecommendInfo);
			ConfirmBoxController.Instance.CloseConfirmBoxView();
			if (recommendEquipUniqueIdList != null)
			{
				PhantomBattleController.Instance.SendPhantomAutoPutRequest(roleInstance.GetRoleId(), recommendEquipUniqueIdList.ToList<int>(), null);
			}
			UiManager.Instance.CloseView(EUiViewName.VisionRecommendView, null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06013045 RID: 77893 RVA: 0x004B5789 File Offset: 0x004B3989
	private void OnClickGoFetterGroupDetailViewBtn()
	{
		base.CloseMe(delegate(bool _)
		{
			List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
			if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
			{
				return;
			}
			bool showFastFilter = RoleModel.Instance.IsRoleOwned(this.CurrentSelectRoleId);
			VisionFetterRecommendInfo visionFetterRecommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
			PhantomBattleController.Instance.OpenPhantomBattleFetterView(visionFetterRecommendInfo.GetRecommendFetterGroupId(), this.CurrentSelectRoleId, showFastFilter, visionFetterRecommendInfo.BuildFetterList()).Forget();
			EventSystem.Instance.Emit(EEventName.HideVisionTabRole);
		});
	}

	// Token: 0x06013046 RID: 77894 RVA: 0x004B579D File Offset: 0x004B399D
	private void OnClickFetterGroupContentItem(FetterGroupContentData data)
	{
		this.CurrentSelectIndex = data.Index;
		this.RefreshFetterLayout();
		this.RefreshViewInfoByCurrentSelectIndex(this.CurrentSelectIndex);
		this.RefreshSelectGroupName();
		this.RefreshBtnConfirmChangeState();
	}

	// Token: 0x06013047 RID: 77895 RVA: 0x004B57C9 File Offset: 0x004B39C9
	protected override void OnBeforeShow()
	{
		this.CurrentSelectIndex = 0;
		this.RefreshFetterLayout();
		this.RefreshViewInfoByCurrentSelectIndex(this.CurrentSelectIndex);
		this.RefreshSelectGroupName();
		this.RefreshBtnConfirmChangeState();
		this.RefreshButtonVisibility();
	}

	// Token: 0x06013048 RID: 77896 RVA: 0x004B57F8 File Offset: 0x004B39F8
	private void RefreshFetterLayout()
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo != null)
		{
			roleFetterRecommendInfo.Sort((VisionFetterRecommendInfo a, VisionFetterRecommendInfo b) => b.GetUsage() - a.GetUsage());
		}
		List<FetterGroupContentData> list = new List<FetterGroupContentData>();
		int num = (roleFetterRecommendInfo != null) ? roleFetterRecommendInfo.Count : 0;
		for (int i = 0; i < num; i++)
		{
			list.Add(new FetterGroupContentData
			{
				Index = i,
				CurrentSelectIndex = this.CurrentSelectIndex,
				VisionFetterRecommendInfo = roleFetterRecommendInfo[i],
				ClickCallBack = new Action<FetterGroupContentData>(this.OnClickFetterGroupContentItem)
			});
		}
		GenericLayout<FetterItemContent, FetterGroupContentData> fetterItemLayout = this.FetterItemLayout;
		if (fetterItemLayout == null)
		{
			return;
		}
		fetterItemLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06013049 RID: 77897 RVA: 0x004B58B8 File Offset: 0x004B3AB8
	private void RefreshFetterInfoLayout(VisionFetterRecommendInfo data)
	{
		List<VisionFetterDescData> fetterDescByRecommendInfo = VisionRecommendModel.Instance.GetFetterDescByRecommendInfo(data);
		if (fetterDescByRecommendInfo != null)
		{
			GenericLayout<VisionFetterDescItem, VisionFetterDescData> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.RefreshByData(fetterDescByRecommendInfo, null, false);
		}
	}

	// Token: 0x0601304A RID: 77898 RVA: 0x004B58E8 File Offset: 0x004B3AE8
	private void RefreshViewInfoByCurrentSelectIndex(int selectIndex)
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo data = roleFetterRecommendInfo[selectIndex];
		this.RefreshFetterInfoLayout(data);
	}

	// Token: 0x0601304B RID: 77899 RVA: 0x004B5924 File Offset: 0x004B3B24
	private void RefreshSelectGroupName()
	{
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo visionFetterRecommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(visionFetterRecommendInfo.GetRecommendFetterGroupId());
		base.GetText(2).ShowTextNew(fetterGroupById.FetterGroupName);
	}

	// Token: 0x0601304C RID: 77900 RVA: 0x004B5980 File Offset: 0x004B3B80
	private void RefreshBtnConfirmChangeState()
	{
		if (!this.IsFromRoleDev || this.GetSelectedPlanIdCallBack == null)
		{
			return;
		}
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo visionFetterRecommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
		if (this.GetSelectedPlanIdCallBack(this.CurrentSelectRoleId) == visionFetterRecommendInfo.GetPlanId())
		{
			this.BtnConfirmChange.SetLocalTextNew("RoleProject_PhantomRecommend_Tips01", Array.Empty<object>());
			this.BtnConfirmChange.SetEnableClick(false);
			return;
		}
		this.BtnConfirmChange.SetLocalTextNew("RoleProject_PhantomRecommend_Button01", Array.Empty<object>());
		this.BtnConfirmChange.SetEnableClick(true);
	}

	// Token: 0x0601304D RID: 77901 RVA: 0x004B5A28 File Offset: 0x004B3C28
	private void OnClickBtnConfirmChange(int _)
	{
		if (!this.IsFromRoleDev)
		{
			return;
		}
		List<VisionFetterRecommendInfo> roleFetterRecommendInfo = VisionRecommendModel.Instance.GetRoleFetterRecommendInfo(this.CurrentSelectRoleId);
		if (roleFetterRecommendInfo == null || roleFetterRecommendInfo.Count == 0)
		{
			return;
		}
		VisionFetterRecommendInfo visionFetterRecommendInfo = roleFetterRecommendInfo[this.CurrentSelectIndex];
		Action<int, int, int?> onChangeFetterGroupSuccessCallBack = this.OnChangeFetterGroupSuccessCallBack;
		if (onChangeFetterGroupSuccessCallBack != null)
		{
			onChangeFetterGroupSuccessCallBack(this.CurrentSelectRoleId, visionFetterRecommendInfo.GetPlanId(), null);
		}
		base.CloseMe(null);
	}

	// Token: 0x04008F15 RID: 36629
	[Nullable(2)]
	private ButtonItem BtnConfirmChange;

	// Token: 0x04008F16 RID: 36630
	[Nullable(2)]
	private ButtonItem BtnConfirmBox;

	// Token: 0x04008F17 RID: 36631
	private int CurrentSelectIndex;

	// Token: 0x04008F18 RID: 36632
	private int CurrentSelectRoleId;

	// Token: 0x04008F19 RID: 36633
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterItemContent, FetterGroupContentData> FetterItemLayout;

	// Token: 0x04008F1A RID: 36634
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterDescItem, VisionFetterDescData> Layout;

	// Token: 0x04008F1B RID: 36635
	private bool IsFromRoleDev;

	// Token: 0x04008F1C RID: 36636
	[Nullable(2)]
	private Action<int, int, int?> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x04008F1D RID: 36637
	[Nullable(2)]
	private Func<int, int> GetSelectedPlanIdCallBack;

	// Token: 0x02008A82 RID: 35458
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CFA9 RID: 184233
		FetterGroupVerticalLayout,
		// Token: 0x0402CFAA RID: 184234
		FetterGroupItem,
		// Token: 0x0402CFAB RID: 184235
		SelectFetterGroupName,
		// Token: 0x0402CFAC RID: 184236
		GoFetterGroupDetailViewBtn,
		// Token: 0x0402CFAD RID: 184237
		FetterGroupContentVerticalLayout,
		// Token: 0x0402CFAE RID: 184238
		FetterGroupContentItem,
		// Token: 0x0402CFAF RID: 184239
		ConfirmBoxBtn,
		// Token: 0x0402CFB0 RID: 184240
		BtnConfirmChange
	}
}
