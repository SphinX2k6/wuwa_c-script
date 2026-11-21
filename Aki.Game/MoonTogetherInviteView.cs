using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F77 RID: 8055
[NullableContext(1)]
[Nullable(0)]
public class MoonTogetherInviteView : UiViewBase
{
	// Token: 0x06013EC3 RID: 81603 RVA: 0x005CF5BA File Offset: 0x005CD7BA
	public MoonTogetherInviteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013EC4 RID: 81604 RVA: 0x005CF5C4 File Offset: 0x005CD7C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickExitBtn)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickInviteBtn))
		};
	}

	// Token: 0x06013EC5 RID: 81605 RVA: 0x005CF6DD File Offset: 0x005CD8DD
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06013EC6 RID: 81606 RVA: 0x005CF6FB File Offset: 0x005CD8FB
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x06013EC7 RID: 81607 RVA: 0x005CF719 File Offset: 0x005CD919
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiViewName.MoonTogetherInviteView)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.RefreshRoleItemLocation();
			}, null, null);
		}
	}

	// Token: 0x06013EC8 RID: 81608 RVA: 0x005CF74C File Offset: 0x005CD94C
	protected override UniTask OnBeforeStartAsync()
	{
		MoonTogetherInviteView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonTogetherInviteView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013EC9 RID: 81609 RVA: 0x005CF790 File Offset: 0x005CD990
	private void RefreshRoleItemLocation()
	{
		int num;
		if (this.OpenParam != null)
		{
			num = ((int[])this.OpenParam)[0];
			MoonTogetherModel.Instance.HandleEntityId = num;
		}
		else
		{
			num = MoonTogetherModel.Instance.HandleEntityId;
		}
		List<EntityHandle> list = new List<EntityHandle>();
		CreatureModel.Instance.GetEntitiesWithPbDataId(num, ref list);
		WorldEntity worldEntity;
		if (list.Count <= 0)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle entityHandle = list[0];
			worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null)
		{
			return;
		}
		FVectorDouble actorLocation = worldEntity2.GetComponent<BaseActorComponent>().ActorLocation;
		Vector2D vector2D = new Vector2D();
		if (HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, vector2D))
		{
			this.RoleItem.SetUiActive(true);
			this.RoleItem.GetRootItem().SetAnchorOffset(vector2D.ToUeVector2D(false));
		}
	}

	// Token: 0x06013ECA RID: 81610 RVA: 0x005CF84C File Offset: 0x005CDA4C
	private void InitAreaList()
	{
		List<MotorRoleCategory> list = new List<MotorRoleCategory>(MoonTogetherConfig.Instance.GetRoleAreaList() ?? Array.Empty<MotorRoleCategory>());
		list.Sort(delegate(MotorRoleCategory a, MotorRoleCategory b)
		{
			int num = (!MoonTogetherModel.Instance.IsLinkageRegion(a.Id)) ? 1 : 0;
			int num2 = (!MoonTogetherModel.Instance.IsLinkageRegion(b.Id)) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
			return a.SortId - b.SortId;
		});
		List<int> list2 = new List<int>();
		foreach (MotorRoleCategory motorRoleCategory in list)
		{
			list2.Add(motorRoleCategory.Id);
		}
		this.CurrentSelectRoleId = ShipTogetherModel.Instance.RiderSharingRoleId;
		MoonTogetherRoleItem roleItem = this.RoleItem;
		if (roleItem != null)
		{
			roleItem.RefreshRoleInfo(this.CurrentSelectRoleId);
		}
		int selectAreaId = 0;
		if (this.CurrentSelectRoleId != 0)
		{
			VehicleRidingRoles? vehicleRidingRolesById = MoonTogetherConfig.Instance.GetVehicleRidingRolesById(this.CurrentSelectRoleId);
			if (vehicleRidingRolesById != null)
			{
				selectAreaId = vehicleRidingRolesById.Value.RegionId;
			}
		}
		this.AreaSwitchGroupItem.RefreshAreaList(list2, selectAreaId);
	}

	// Token: 0x06013ECB RID: 81611 RVA: 0x005CF94C File Offset: 0x005CDB4C
	private MotorcycleTogetherRoleItem CreateLoopItem()
	{
		return new MotorcycleTogetherRoleItem
		{
			OnClickToggleCallBack = new Action<bool, int, int>(this.RoleItemToggleCallBack),
			IsToggleSelectOn = new Func<int, bool>(this.IsRoleSelectOn)
		};
	}

	// Token: 0x06013ECC RID: 81612 RVA: 0x005CF978 File Offset: 0x005CDB78
	private void RoleItemToggleCallBack(bool state, int roleId, int index)
	{
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		if (state)
		{
			this.CurrentSelectRoleId = roleId;
			this.RoleScrollView.SelectGridProxy(index, false);
			MoonTogetherModel.Instance.InviteRole(roleId);
		}
		else
		{
			this.CurrentSelectRoleId = 0;
			MoonTogetherModel.Instance.InviteRole(0);
		}
		this.RoleScrollView.RefreshAllGridProxies();
		this.RefreshViewState();
	}

	// Token: 0x06013ECD RID: 81613 RVA: 0x005CF9D8 File Offset: 0x005CDBD8
	private bool IsRoleSelectOn(int roleId)
	{
		return this.CurrentSelectRoleId == roleId;
	}

	// Token: 0x06013ECE RID: 81614 RVA: 0x005CF9E3 File Offset: 0x005CDBE3
	private void OnSwitchArea(int areaId)
	{
		this.RefreshRoleList(areaId);
	}

	// Token: 0x06013ECF RID: 81615 RVA: 0x005CF9EC File Offset: 0x005CDBEC
	private void RefreshRoleList(int areaId)
	{
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		List<RoleInstance> roleListAvailable = new List<RoleInstance>();
		foreach (RoleInstance roleInstance in roleList)
		{
			if (!RoleModel.Instance.IsMainRole(roleInstance.GetRoleId()))
			{
				VehicleRidingRoles? vehicleRidingRolesById = MoonTogetherConfig.Instance.GetVehicleRidingRolesById(roleInstance.GetRoleId());
				if (vehicleRidingRolesById != null && vehicleRidingRolesById.Value.RegionId == areaId)
				{
					roleListAvailable.Add(roleInstance);
				}
			}
		}
		roleListAvailable.Sort(delegate(RoleInstance a, RoleInstance b)
		{
			int favorLevel = a.GetFavorData().GetFavorLevel();
			int favorLevel2 = b.GetFavorData().GetFavorLevel();
			if (favorLevel != favorLevel2)
			{
				return favorLevel2 - favorLevel;
			}
			return a.GetRoleId() - b.GetRoleId();
		});
		bool flag = roleListAvailable.Count != 0;
		base.GetItem(2).SetUIActive(!flag);
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(3);
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			loopScrollViewComponent.StopMovement();
			Predicate<RoleInstance> <>9__2;
			this.RoleScrollView.RefreshByData(roleListAvailable, false, delegate
			{
				if (this.CurrentSelectRoleId <= 0)
				{
					this.RoleScrollView.ScrollToGridIndex(0, true);
					this.RoleItemToggleCallBack(false, 0, 0);
					return;
				}
				List<RoleInstance> roleListAvailable = roleListAvailable;
				Predicate<RoleInstance> match;
				if ((match = <>9__2) == null)
				{
					match = (<>9__2 = ((RoleInstance role) => role.GetRoleId() == this.CurrentSelectRoleId));
				}
				int num = roleListAvailable.FindIndex(match);
				if (num < 0)
				{
					this.RoleScrollView.ScrollToGridIndex(0, true);
					this.RoleItemToggleCallBack(false, 0, 0);
					return;
				}
				this.RoleScrollView.ScrollToGridIndexLate(num, true);
				this.RoleScrollView.DeselectCurrentGridProxy(false);
				this.RoleScrollView.SelectGridProxy(num, false);
				this.RoleItemToggleCallBack(true, this.CurrentSelectRoleId, num);
				if (Info.Instance.IsInGamepad())
				{
					MotorcycleTogetherRoleItem motorcycleTogetherRoleItem = this.RoleScrollView.UnsafeGetGridProxy(num, false);
					UUIItem uuiitem = (motorcycleTogetherRoleItem != null) ? motorcycleTogetherRoleItem.GetToggleRootItem() : null;
					if (uuiitem != null)
					{
						UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem, true, false, false);
					}
				}
			}, true);
		}
		this.RefreshViewState();
	}

	// Token: 0x06013ED0 RID: 81616 RVA: 0x005CFB18 File Offset: 0x005CDD18
	private void RefreshViewState()
	{
		bool flag = this.CurrentSelectRoleId != 0;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), flag ? "MoonTogether_Invite" : "MoonTogether_Solo", Array.Empty<object>());
		MoonTogetherRoleItem roleItem = this.RoleItem;
		if (roleItem == null)
		{
			return;
		}
		roleItem.RefreshRoleInfo(this.CurrentSelectRoleId);
	}

	// Token: 0x06013ED1 RID: 81617 RVA: 0x005CFB6A File Offset: 0x005CDD6A
	private void OnClickExitBtn()
	{
		if (MoonTogetherModel.Instance.IsInMoonTogether || MoonTogetherModel.Instance.CurInviteRoleId > 0)
		{
			UiManager.Instance.CloseAndOpenView(EUiViewName.MoonTogetherInviteView, EUiViewName.MoonTogetherMainView, null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06013ED2 RID: 81618 RVA: 0x005CFBA4 File Offset: 0x005CDDA4
	private void OnClickInviteBtn()
	{
		MoonTogetherModel.Instance.SendAndSave();
		UiManager.Instance.CloseAndOpenView(EUiViewName.MoonTogetherInviteView, EUiViewName.MoonTogetherMainView, null, null, true);
	}

	// Token: 0x0400A9C9 RID: 43465
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A9CA RID: 43466
	[Nullable(2)]
	private AreaSwitchGroupItem AreaSwitchGroupItem;

	// Token: 0x0400A9CB RID: 43467
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTogetherRoleItem, RoleInstance> RoleScrollView;

	// Token: 0x0400A9CC RID: 43468
	[Nullable(2)]
	private MoonTogetherRoleItem RoleItem;

	// Token: 0x0400A9CD RID: 43469
	private int CurrentSelectRoleId;

	// Token: 0x02008279 RID: 33401
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A20D RID: 172557
		public const int CaptionItem = 0;

		// Token: 0x0402A20E RID: 172558
		public const int AreaItem = 1;

		// Token: 0x0402A20F RID: 172559
		public const int EmptyItem = 2;

		// Token: 0x0402A210 RID: 172560
		public const int RoleLoopScrollView = 3;

		// Token: 0x0402A211 RID: 172561
		public const int RoleItem = 4;

		// Token: 0x0402A212 RID: 172562
		public const int ExitBtn = 5;

		// Token: 0x0402A213 RID: 172563
		public const int InviteBtn = 6;

		// Token: 0x0402A214 RID: 172564
		public const int InviteRoleItem = 7;

		// Token: 0x0402A215 RID: 172565
		public const int ConfirmText = 8;
	}
}
