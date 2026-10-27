using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.HandBook;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E28 RID: 7720
[NullableContext(1)]
[Nullable(0)]
public class HandBookRoleView : UiViewBase
{
	// Token: 0x0600EAB0 RID: 60080 RVA: 0x0037989E File Offset: 0x00377A9E
	public HandBookRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EAB1 RID: 60081 RVA: 0x003798B4 File Offset: 0x00377AB4
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

	// Token: 0x0600EAB2 RID: 60082 RVA: 0x0037999F File Offset: 0x00377B9F
	protected override void OnBeforeCreateImplementImplement()
	{
		this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
	}

	// Token: 0x0600EAB3 RID: 60083 RVA: 0x003799B4 File Offset: 0x00377BB4
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

	// Token: 0x0600EAB4 RID: 60084 RVA: 0x00379B6C File Offset: 0x00377D6C
	protected void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Role);
		LguiUtil.Instance.SetLocalText(base.GetText(7), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600EAB5 RID: 60085 RVA: 0x00379BBD File Offset: 0x00377DBD
	protected override void OnHandleLoadScene()
	{
		this.InitRole();
	}

	// Token: 0x0600EAB6 RID: 60086 RVA: 0x00379BC5 File Offset: 0x00377DC5
	protected override void OnBeforeShowImplementImplement()
	{
		UiSceneUtils.SetSceneFloorReflection(true, false);
	}

	// Token: 0x0600EAB7 RID: 60087 RVA: 0x00379BCE File Offset: 0x00377DCE
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

	// Token: 0x0600EAB8 RID: 60088 RVA: 0x00379BFC File Offset: 0x00377DFC
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

	// Token: 0x0600EAB9 RID: 60089 RVA: 0x00379C64 File Offset: 0x00377E64
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

	// Token: 0x0600EABA RID: 60090 RVA: 0x00379CB0 File Offset: 0x00377EB0
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

	// Token: 0x0600EABB RID: 60091 RVA: 0x00379CF4 File Offset: 0x00377EF4
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

	// Token: 0x0600EABC RID: 60092 RVA: 0x00379DD6 File Offset: 0x00377FD6
	private void SetNameText(string nameText)
	{
		base.GetText(1).SetText(nameText, true);
	}

	// Token: 0x0600EABD RID: 60093 RVA: 0x00379DE6 File Offset: 0x00377FE6
	private HandBookRoleMediumItemGird OnGridProxyCreate()
	{
		HandBookRoleMediumItemGird handBookRoleMediumItemGird = new HandBookRoleMediumItemGird();
		handBookRoleMediumItemGird.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		handBookRoleMediumItemGird.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return handBookRoleMediumItemGird;
	}

	// Token: 0x0600EABE RID: 60094 RVA: 0x00379E14 File Offset: 0x00378014
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

	// Token: 0x0600EABF RID: 60095 RVA: 0x00379E4C File Offset: 0x0037804C
	[NullableContext(2)]
	private bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		if (UiCameraAnimationManager.Instance.IsPlayingAnimation() && this.CurSelectRoleId != null && state == EToggleState.ETT_UnChecked)
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

	// Token: 0x0600EAC0 RID: 60096 RVA: 0x00379EA7 File Offset: 0x003780A7
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
		this.RoleScrollView = null;
	}

	// Token: 0x0600EAC1 RID: 60097 RVA: 0x00379EC4 File Offset: 0x003780C4
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

	// Token: 0x04006CF7 RID: 27895
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<HandBookRoleMediumItemGird, RoleDataBase> RoleScrollView;

	// Token: 0x04006CF8 RID: 27896
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006CF9 RID: 27897
	[Nullable(2)]
	private TsUiSceneRoleActor UiSceneRoleActor;

	// Token: 0x04006CFA RID: 27898
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04006CFB RID: 27899
	private int? CurSelectRoleId;

	// Token: 0x04006CFC RID: 27900
	private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

	// Token: 0x020083DA RID: 33754
	[NullableContext(0)]
	private class EHandBookRoleViewDefine
	{
		// Token: 0x0402AEC9 RID: 175817
		public const int TitleItem = 0;

		// Token: 0x0402AECA RID: 175818
		public const int RoleName = 1;

		// Token: 0x0402AECB RID: 175819
		public const int ScrollView = 2;

		// Token: 0x0402AECC RID: 175820
		public const int ScrollViewItem = 3;

		// Token: 0x0402AECD RID: 175821
		public const int FilterSortItem = 4;

		// Token: 0x0402AECE RID: 175822
		public const int DetailBtn = 5;

		// Token: 0x0402AECF RID: 175823
		public const int DateText = 6;

		// Token: 0x0402AED0 RID: 175824
		public const int CollectCountText = 7;
	}
}
