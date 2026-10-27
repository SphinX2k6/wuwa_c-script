using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029FC RID: 10748
[NullableContext(1)]
[Nullable(0)]
public class MoonTogetherInviteView : UiViewBase
{
	// Token: 0x060164BC RID: 91324 RVA: 0x005A45E2 File Offset: 0x005A27E2
	public MoonTogetherInviteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060164BD RID: 91325 RVA: 0x005A45EC File Offset: 0x005A27EC
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

	// Token: 0x060164BE RID: 91326 RVA: 0x005A4705 File Offset: 0x005A2905
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x060164BF RID: 91327 RVA: 0x005A4723 File Offset: 0x005A2923
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
	}

	// Token: 0x060164C0 RID: 91328 RVA: 0x005A4741 File Offset: 0x005A2941
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiViewName.MoonTogetherInviteView)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.RefreshRoleItemLocation();
			}, null, null);
		}
	}

	// Token: 0x060164C1 RID: 91329 RVA: 0x005A4774 File Offset: 0x005A2974
	protected override UniTask OnBeforeStartAsync()
	{
		MoonTogetherInviteView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonTogetherInviteView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060164C2 RID: 91330 RVA: 0x005A47B8 File Offset: 0x005A29B8
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

	// Token: 0x060164C3 RID: 91331 RVA: 0x005A4874 File Offset: 0x005A2A74
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

	// Token: 0x060164C4 RID: 91332 RVA: 0x005A4974 File Offset: 0x005A2B74
	private MotorcycleTogetherRoleItem CreateLoopItem()
	{
		return new MotorcycleTogetherRoleItem
		{
			OnClickToggleCallBack = new Action<bool, int, int>(this.RoleItemToggleCallBack),
			IsToggleSelectOn = new Func<int, bool>(this.IsRoleSelectOn)
		};
	}

	// Token: 0x060164C5 RID: 91333 RVA: 0x005A49A0 File Offset: 0x005A2BA0
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

	// Token: 0x060164C6 RID: 91334 RVA: 0x005A4A00 File Offset: 0x005A2C00
	private bool IsRoleSelectOn(int roleId)
	{
		return this.CurrentSelectRoleId == roleId;
	}

	// Token: 0x060164C7 RID: 91335 RVA: 0x005A4A0B File Offset: 0x005A2C0B
	private void OnSwitchArea(int areaId)
	{
		this.RefreshRoleList(areaId);
	}

	// Token: 0x060164C8 RID: 91336 RVA: 0x005A4A14 File Offset: 0x005A2C14
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

	// Token: 0x060164C9 RID: 91337 RVA: 0x005A4B40 File Offset: 0x005A2D40
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

	// Token: 0x060164CA RID: 91338 RVA: 0x005A4B92 File Offset: 0x005A2D92
	private void OnClickExitBtn()
	{
		if (MoonTogetherModel.Instance.IsInMoonTogether || MoonTogetherModel.Instance.CurInviteRoleId > 0)
		{
			UiManager.Instance.CloseAndOpenView(EUiViewName.MoonTogetherInviteView, EUiViewName.MoonTogetherMainView, null, null, true);
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060164CB RID: 91339 RVA: 0x005A4BCC File Offset: 0x005A2DCC
	private void OnClickInviteBtn()
	{
		MoonTogetherModel.Instance.SendAndSave();
		UiManager.Instance.CloseAndOpenView(EUiViewName.MoonTogetherInviteView, EUiViewName.MoonTogetherMainView, null, null, true);
	}

	// Token: 0x0400A5DF RID: 42463
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A5E0 RID: 42464
	[Nullable(2)]
	private AreaSwitchGroupItem AreaSwitchGroupItem;

	// Token: 0x0400A5E1 RID: 42465
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTogetherRoleItem, RoleInstance> RoleScrollView;

	// Token: 0x0400A5E2 RID: 42466
	[Nullable(2)]
	private MoonTogetherRoleItem RoleItem;

	// Token: 0x0400A5E3 RID: 42467
	private int CurrentSelectRoleId;

	// Token: 0x02009032 RID: 36914
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402EB15 RID: 191253
		public const int CaptionItem = 0;

		// Token: 0x0402EB16 RID: 191254
		public const int AreaItem = 1;

		// Token: 0x0402EB17 RID: 191255
		public const int EmptyItem = 2;

		// Token: 0x0402EB18 RID: 191256
		public const int RoleLoopScrollView = 3;

		// Token: 0x0402EB19 RID: 191257
		public const int RoleItem = 4;

		// Token: 0x0402EB1A RID: 191258
		public const int ExitBtn = 5;

		// Token: 0x0402EB1B RID: 191259
		public const int InviteBtn = 6;

		// Token: 0x0402EB1C RID: 191260
		public const int InviteRoleItem = 7;

		// Token: 0x0402EB1D RID: 191261
		public const int ConfirmText = 8;
	}
}
