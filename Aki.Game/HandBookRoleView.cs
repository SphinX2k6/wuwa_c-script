using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.HandBook;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012EA RID: 4842
[NullableContext(1)]
[Nullable(0)]
public class HandBookRoleView : UiViewBase
{
	// Token: 0x0600BECF RID: 48847 RVA: 0x0038552A File Offset: 0x0038372A
	public HandBookRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BED0 RID: 48848 RVA: 0x00385540 File Offset: 0x00383740
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnDetailClick))
		};
	}

	// Token: 0x0600BED1 RID: 48849 RVA: 0x0038562B File Offset: 0x0038382B
	protected override void OnBeforeCreateImplementImplement()
	{
		this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
	}

	// Token: 0x0600BED2 RID: 48850 RVA: 0x00385640 File Offset: 0x00383840
	protected override void OnStart()
	{
		this.RoleScrollView = new LoopScrollView<HandBookRoleMediumItemGird, RoleDataBase>(base.GetLoopScrollViewComponent(2), base.GetItem(3).GetOwner() as AUIBaseActor, new Func<HandBookRoleMediumItemGird>(this.OnGridProxyCreate), false);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
		this.CaptionItem.SetTitleLocalText("HandBookRoleTitle");
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(base.GetItem(4), new TUpdateDataListFunction<RoleDataBase>(this.UpdateList));
		List<RoleDataBase> list = new List<RoleDataBase>();
		IReadOnlyList<RoleInfo> roleList = RoleConfig.Instance.GetRoleList();
		if (roleList == null)
		{
			return;
		}
		List<RoleInfo> list2 = new List<RoleInfo>();
		foreach (RoleInfo item in roleList)
		{
			if (item.RoleType == 1 && !RoleModel.Instance.IsMainRole(item.Id) && HandBookModel.Instance.GetRoleCanShowInHandBook(item.Id))
			{
				list2.Add(item);
			}
		}
		foreach (RoleInfo roleInfo in list2)
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleInfo.Id, true);
			if (roleDataById != null)
			{
				list.Add(roleDataById);
			}
			else
			{
				list.Add(new RoleRobotData(roleInfo.TrialRole));
			}
		}
		list.Add(RoleModel.Instance.GetCurSelectMainRoleInstance());
		this.FilterSortEntrance.UpdateData(EFilterSortGroupId.RoleHandBook, list, Array.Empty<object>());
		this.InitRole();
		this.RefreshCollectText();
	}

	// Token: 0x0600BED3 RID: 48851 RVA: 0x003857F8 File Offset: 0x003839F8
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Role);
		LguiUtil.Instance.SetLocalText(base.GetText(7), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BED4 RID: 48852 RVA: 0x00385849 File Offset: 0x00383A49
	protected override void OnHandleLoadScene()
	{
		this.InitRole();
	}

	// Token: 0x0600BED5 RID: 48853 RVA: 0x00385851 File Offset: 0x00383A51
	protected override void OnBeforeShowImplementImplement()
	{
		UiSceneUtils.SetSceneFloorReflection(true, false);
	}

	// Token: 0x0600BED6 RID: 48854 RVA: 0x0038585A File Offset: 0x00383A5A
	protected void InitRole()
	{
		UiModelBase model = UiSceneManager.Instance.GetRoleSystemRoleActor().Model;
		UiModelActorComponent uiModelActorComponent = (model != null) ? model.CheckGetComponent<UiModelActorComponent>() : null;
		if (uiModelActorComponent == null)
		{
			return;
		}
		uiModelActorComponent.SetTransformByTag("RoleCase");
	}

	// Token: 0x0600BED7 RID: 48855 RVA: 0x00385888 File Offset: 0x00383A88
	private void UpdateList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType OperationType)
	{
		List<RoleDataBase> list2 = new List<RoleDataBase>();
		foreach (RoleDataBase roleDataBase in list)
		{
			if (roleDataBase != null)
			{
				RoleDataBase item = roleDataBase;
				list2.Add(item);
			}
		}
		this.RoleDataList = list2;
		this.RefreshRoleItem(list2);
	}

	// Token: 0x0600BED8 RID: 48856 RVA: 0x003858F0 File Offset: 0x00383AF0
	private void RefreshRoleItem(List<RoleDataBase> roleList)
	{
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		this.RoleScrollView.RefreshByData(roleList, false, delegate
		{
			int num = 0;
			foreach (RoleDataBase roleDataBase in roleList)
			{
				int dataId = roleDataBase.GetDataId();
				int? curSelectRoleId = this.CurSelectRoleId;
				if (dataId == curSelectRoleId.GetValueOrDefault() & curSelectRoleId != null)
				{
					this.RoleScrollView.ScrollToGridIndex(num, true);
					this.RoleScrollView.SelectGridProxy(num, false);
					return;
				}
				num++;
			}
			if (this.RoleDataList.Count > 0)
			{
				this.SelectGridByRoleData(this.RoleDataList[0], true);
			}
		}, false);
	}

	// Token: 0x0600BED9 RID: 48857 RVA: 0x0038593C File Offset: 0x00383B3C
	private void SelectGridByRoleData(RoleDataBase roleInstance, bool needScroll = false)
	{
		int num = this.RoleDataList.IndexOf(roleInstance);
		if (num >= 0)
		{
			if (needScroll)
			{
				this.RoleScrollView.ScrollToGridIndex(num, true);
			}
			this.RoleScrollView.SelectGridProxy(num, false);
			this.ChangeRoleByRoleId(roleInstance);
		}
	}

	// Token: 0x0600BEDA RID: 48858 RVA: 0x00385980 File Offset: 0x00383B80
	private void ChangeRoleByRoleId(RoleDataBase roleInstance)
	{
		int dataId = roleInstance.GetDataId();
		int valueOrDefault = this.CurSelectRoleId.GetValueOrDefault();
		int? curSelectRoleId = this.CurSelectRoleId;
		int num = dataId;
		if (curSelectRoleId.GetValueOrDefault() == num & curSelectRoleId != null)
		{
			return;
		}
		this.CurSelectRoleId = new int?(dataId);
		this.SetNameText(roleInstance.GetName(null));
		UUIText text = base.GetText(6);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("HandBookRoleGetDate", null);
		if (dataId < 100000)
		{
			text.SetUIActive(true);
			text.SetText(localTextNew + TimeUtil.Instance.DateFormat4String((double)roleInstance.GetRoleCreateTime()), true);
		}
		else
		{
			text.SetUIActive(false);
		}
		RoleController.Instance.OnSelectedRoleChange(this.CurSelectRoleId.Value, roleInstance.GetRoleConfig().SkinId);
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, valueOrDefault > 0, false);
	}

	// Token: 0x0600BEDB RID: 48859 RVA: 0x00385A62 File Offset: 0x00383C62
	private void SetNameText(string nameText)
	{
		base.GetText(1).SetText(nameText, true);
	}

	// Token: 0x0600BEDC RID: 48860 RVA: 0x00385A72 File Offset: 0x00383C72
	private HandBookRoleMediumItemGird OnGridProxyCreate()
	{
		HandBookRoleMediumItemGird handBookRoleMediumItemGird = new HandBookRoleMediumItemGird();
		handBookRoleMediumItemGird.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		handBookRoleMediumItemGird.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return handBookRoleMediumItemGird;
	}

	// Token: 0x0600BEDD RID: 48861 RVA: 0x00385AA0 File Offset: 0x00383CA0
	private void ToggleFunction(MediumItemGridExtendCallback callbackParameter)
	{
		int state = (int)callbackParameter.State;
		RoleDataBase roleInstance = callbackParameter.Data as RoleDataBase;
		if (state == 1)
		{
			this.RoleScrollView.DeselectCurrentGridProxy(false);
			this.SelectGridByRoleData(roleInstance, false);
		}
	}

	// Token: 0x0600BEDE RID: 48862 RVA: 0x00385AD8 File Offset: 0x00383CD8
	[NullableContext(2)]
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (UiCameraModel.Instance.IsPlayingAnimation() && this.CurSelectRoleId != null && state == EToggleState.ETT_UnChecked)
		{
			return false;
		}
		RoleDataBase roleDataBase = data as RoleDataBase;
		if (state == EToggleState.ETT_Checked)
		{
			int? curSelectRoleId = this.CurSelectRoleId;
			int dataId = roleDataBase.GetDataId();
			return !(curSelectRoleId.GetValueOrDefault() == dataId & curSelectRoleId != null);
		}
		return true;
	}

	// Token: 0x0600BEDF RID: 48863 RVA: 0x00385B33 File Offset: 0x00383D33
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
		this.RoleScrollView = null;
	}

	// Token: 0x0600BEE0 RID: 48864 RVA: 0x00385B50 File Offset: 0x00383D50
	private void OnDetailClick()
	{
		RoleInfo? roleInfo;
		int? num = (RoleConfig.Instance.GetRoleConfig(this.CurSelectRoleId.Value) != null) ? new int?(roleInfo.GetValueOrDefault().TrialRole) : null;
		List<int> roleIdList = new List<int>
		{
			num.Value
		};
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, roleIdList, null, delegate(bool _, int _)
		{
		});
	}

	// Token: 0x04006DD8 RID: 28120
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<HandBookRoleMediumItemGird, RoleDataBase> RoleScrollView;

	// Token: 0x04006DD9 RID: 28121
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006DDA RID: 28122
	[Nullable(2)]
	private TsUiSceneRoleActor UiSceneRoleActor;

	// Token: 0x04006DDB RID: 28123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04006DDC RID: 28124
	private int? CurSelectRoleId;

	// Token: 0x04006DDD RID: 28125
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

	// Token: 0x0200755F RID: 30047
	[NullableContext(0)]
	private class EHandBookRoleViewDefine
	{
		// Token: 0x040261EC RID: 156140
		public const int TitleItem = 0;

		// Token: 0x040261ED RID: 156141
		public const int RoleName = 1;

		// Token: 0x040261EE RID: 156142
		public const int ScrollView = 2;

		// Token: 0x040261EF RID: 156143
		public const int ScrollViewItem = 3;

		// Token: 0x040261F0 RID: 156144
		public const int FilterSortItem = 4;

		// Token: 0x040261F1 RID: 156145
		public const int DetailBtn = 5;

		// Token: 0x040261F2 RID: 156146
		public const int DateText = 6;

		// Token: 0x040261F3 RID: 156147
		public const int CollectCountText = 7;
	}
}
