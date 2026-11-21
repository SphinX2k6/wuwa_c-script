using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020019D5 RID: 6613
[NullableContext(1)]
[Nullable(0)]
public class VisionRecommendView : UiViewBase
{
	// Token: 0x060104F9 RID: 66809 RVA: 0x004C305A File Offset: 0x004C125A
	public VisionRecommendView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060104FA RID: 66810 RVA: 0x004C3064 File Offset: 0x004C1264
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

	// Token: 0x060104FB RID: 66811 RVA: 0x004C3150 File Offset: 0x004C1350
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

	// Token: 0x060104FC RID: 66812 RVA: 0x004C31F1 File Offset: 0x004C13F1
	private void InitBtnConfirmChange()
	{
		this.BtnConfirmChange = new ButtonItem(base.GetItem(7));
		this.BtnConfirmChange.SetLocalTextNew("RoleProject_PhantomRecommend_Tips01", Array.Empty<object>());
		this.BtnConfirmChange.SetFunction(new Action<int>(this.OnClickBtnConfirmChange));
	}

	// Token: 0x060104FD RID: 66813 RVA: 0x004C3231 File Offset: 0x004C1431
	private void InitBtnConfirmBox()
	{
		this.BtnConfirmBox = new ButtonItem(base.GetItem(6));
		this.BtnConfirmBox.SetLocalTextNew("PrefabTextItem_PhantomQuickEquip_Text", Array.Empty<object>());
		this.BtnConfirmBox.SetFunction(new Action<int>(this.OnClickConfirmBoxBtn));
	}

	// Token: 0x060104FE RID: 66814 RVA: 0x004C3274 File Offset: 0x004C1474
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

	// Token: 0x060104FF RID: 66815 RVA: 0x004C32C2 File Offset: 0x004C14C2
	private VisionFetterDescItem InitItem()
	{
		return new VisionFetterDescItem();
	}

	// Token: 0x06010500 RID: 66816 RVA: 0x004C32C9 File Offset: 0x004C14C9
	private FetterItemContent InitGridItem()
	{
		return new FetterItemContent();
	}

	// Token: 0x06010501 RID: 66817 RVA: 0x004C32D0 File Offset: 0x004C14D0
	private void OnClickConfirmBoxBtn(int _)
	{
		this.TryOneKeyEquip();
	}

	// Token: 0x06010502 RID: 66818 RVA: 0x004C32D8 File Offset: 0x004C14D8
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
				PhantomBattleController.Instance.SendPhantomAutoPutRequest(roleDataById.GetRoleId(), recommendEquipUniqueIdList, null);
				UiManager.Instance.CloseView(EUiViewName.VisionRecommendView, null);
				return;
			}
		}
		else
		{
			this.DoOpenSupplementConfirmBox();
		}
	}

	// Token: 0x06010503 RID: 66819 RVA: 0x004C3378 File Offset: 0x004C1578
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
				PhantomBattleController.Instance.SendPhantomAutoPutRequest(roleInstance.GetRoleId(), recommendEquipUniqueIdList, null);
			}
			UiManager.Instance.CloseView(EUiViewName.VisionRecommendView, null);
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06010504 RID: 66820 RVA: 0x004C3431 File Offset: 0x004C1631
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

	// Token: 0x06010505 RID: 66821 RVA: 0x004C3445 File Offset: 0x004C1645
	private void OnClickFetterGroupContentItem(FetterGroupContentData data)
	{
		this.CurrentSelectIndex = data.Index;
		this.RefreshFetterLayout();
		this.RefreshViewInfoByCurrentSelectIndex(this.CurrentSelectIndex);
		this.RefreshSelectGroupName();
		this.RefreshBtnConfirmChangeState();
	}

	// Token: 0x06010506 RID: 66822 RVA: 0x004C3471 File Offset: 0x004C1671
	protected override void OnBeforeShow()
	{
		this.CurrentSelectIndex = 0;
		this.RefreshFetterLayout();
		this.RefreshViewInfoByCurrentSelectIndex(this.CurrentSelectIndex);
		this.RefreshSelectGroupName();
		this.RefreshBtnConfirmChangeState();
		this.RefreshButtonVisibility();
	}

	// Token: 0x06010507 RID: 66823 RVA: 0x004C34A0 File Offset: 0x004C16A0
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

	// Token: 0x06010508 RID: 66824 RVA: 0x004C3560 File Offset: 0x004C1760
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

	// Token: 0x06010509 RID: 66825 RVA: 0x004C3590 File Offset: 0x004C1790
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

	// Token: 0x0601050A RID: 66826 RVA: 0x004C35CC File Offset: 0x004C17CC
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

	// Token: 0x0601050B RID: 66827 RVA: 0x004C3628 File Offset: 0x004C1828
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

	// Token: 0x0601050C RID: 66828 RVA: 0x004C36D0 File Offset: 0x004C18D0
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

	// Token: 0x0400905F RID: 36959
	[Nullable(2)]
	private ButtonItem BtnConfirmChange;

	// Token: 0x04009060 RID: 36960
	[Nullable(2)]
	private ButtonItem BtnConfirmBox;

	// Token: 0x04009061 RID: 36961
	private int CurrentSelectIndex;

	// Token: 0x04009062 RID: 36962
	private int CurrentSelectRoleId;

	// Token: 0x04009063 RID: 36963
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FetterItemContent, FetterGroupContentData> FetterItemLayout;

	// Token: 0x04009064 RID: 36964
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionFetterDescItem, VisionFetterDescData> Layout;

	// Token: 0x04009065 RID: 36965
	private bool IsFromRoleDev;

	// Token: 0x04009066 RID: 36966
	[Nullable(2)]
	private Action<int, int, int?> OnChangeFetterGroupSuccessCallBack;

	// Token: 0x04009067 RID: 36967
	[Nullable(2)]
	private Func<int, int> GetSelectedPlanIdCallBack;

	// Token: 0x02007C0A RID: 31754
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040282C1 RID: 164545
		FetterGroupVerticalLayout,
		// Token: 0x040282C2 RID: 164546
		FetterGroupItem,
		// Token: 0x040282C3 RID: 164547
		SelectFetterGroupName,
		// Token: 0x040282C4 RID: 164548
		GoFetterGroupDetailViewBtn,
		// Token: 0x040282C5 RID: 164549
		FetterGroupContentVerticalLayout,
		// Token: 0x040282C6 RID: 164550
		FetterGroupContentItem,
		// Token: 0x040282C7 RID: 164551
		ConfirmBoxBtn,
		// Token: 0x040282C8 RID: 164552
		BtnConfirmChange
	}
}
