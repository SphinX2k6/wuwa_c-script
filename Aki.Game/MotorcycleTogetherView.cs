using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002231 RID: 8753
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTogetherView : UiViewBase
{
	// Token: 0x06011143 RID: 69955 RVA: 0x00429DE0 File Offset: 0x00427FE0
	[NullableContext(1)]
	public MotorcycleTogetherView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011144 RID: 69956 RVA: 0x00429DEC File Offset: 0x00427FEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickExitBtn))
		};
	}

	// Token: 0x06011145 RID: 69957 RVA: 0x00429EC4 File Offset: 0x004280C4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTogetherView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTogetherView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011146 RID: 69958 RVA: 0x00429F08 File Offset: 0x00428108
	private void InitAreaList()
	{
		IReadOnlyList<MotorRoleCategory> readOnlyList = ConfigMotorRoleCategoryAll.GetConfigList(true);
		if (readOnlyList == null)
		{
			readOnlyList = new List<MotorRoleCategory>();
		}
		List<MotorRoleCategory> list = new List<MotorRoleCategory>(readOnlyList);
		list.Sort(delegate(MotorRoleCategory a, MotorRoleCategory b)
		{
			MotorRoleCategory motorRoleCategory2 = a;
			MotorRoleCategory motorRoleCategory3 = b;
			return motorRoleCategory2.SortId - motorRoleCategory3.SortId;
		});
		List<int> list2 = new List<int>();
		foreach (MotorRoleCategory motorRoleCategory in list)
		{
			list2.Add(motorRoleCategory.Id);
		}
		this.CurrentSelectRoleId = ShipTogetherModel.Instance.RiderSharingRoleId;
		int selectAreaId = 0;
		if (this.CurrentSelectRoleId != 0)
		{
			VehicleRidingRoles? config = ConfigVehicleRidingRolesById.GetConfig(this.CurrentSelectRoleId, true);
			if (config != null)
			{
				selectAreaId = config.Value.RegionId;
			}
		}
		this.AreaSwitchGroupItem.RefreshAreaList(list2, selectAreaId);
	}

	// Token: 0x06011147 RID: 69959 RVA: 0x00429FEC File Offset: 0x004281EC
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x06011148 RID: 69960 RVA: 0x00429FEE File Offset: 0x004281EE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
	}

	// Token: 0x06011149 RID: 69961 RVA: 0x0042A00C File Offset: 0x0042820C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
	}

	// Token: 0x0601114A RID: 69962 RVA: 0x0042A02A File Offset: 0x0042822A
	private void OnSwitchArea(int areaId)
	{
		this.RefreshRoleList(areaId);
	}

	// Token: 0x0601114B RID: 69963 RVA: 0x0042A034 File Offset: 0x00428234
	private void RefreshRoleList(int areaId)
	{
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		List<RoleInstance> roleListAvailable = new List<RoleInstance>();
		foreach (RoleInstance roleInstance in roleList)
		{
			if (!RoleModel.Instance.IsMainRole(roleInstance.GetRoleId()))
			{
				VehicleRidingRoles? config = ConfigVehicleRidingRolesById.GetConfig(roleInstance.GetRoleId(), true);
				if (config != null && config.Value.RegionId == areaId)
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
		base.GetItem(6).SetUIActive(!flag);
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(flag);
		if (flag)
		{
			loopScrollViewComponent.StopMovement();
			this.RoleScrollView.RefreshByData(roleListAvailable, false, delegate
			{
				if (this.CurrentSelectRoleId <= 0)
				{
					this.RoleScrollView.ScrollToGridIndex(0, true);
					return;
				}
				int num = -1;
				for (int j = 0; j < roleListAvailable.Count; j++)
				{
					if (roleListAvailable[j].GetRoleId() == this.CurrentSelectRoleId)
					{
						num = j;
						break;
					}
				}
				if (num < 0)
				{
					this.RoleScrollView.ScrollToGridIndex(0, true);
					return;
				}
				this.RoleScrollView.ScrollToGridIndex(num, true);
				this.RoleScrollView.DeselectCurrentGridProxy(false);
				this.RoleScrollView.SelectGridProxy(num, false);
			}, true);
		}
		this.RefreshViewState();
	}

	// Token: 0x0601114C RID: 69964 RVA: 0x0042A15C File Offset: 0x0042835C
	private void RefreshViewState()
	{
		bool flag = this.CurrentSelectRoleId != 0;
		this.ButtonConfirm.SetLocalTextNew(flag ? "MotorSharingRide_Button01" : "MotorSharingRide_Button02", Array.Empty<object>());
	}

	// Token: 0x0601114D RID: 69965 RVA: 0x0042A192 File Offset: 0x00428392
	[NullableContext(1)]
	private MotorcycleTogetherRoleItem CreateLoopItem()
	{
		return new MotorcycleTogetherRoleItem
		{
			OnClickToggleCallBack = new Action<bool, int, int>(this.RoleItemToggleCallBack),
			IsToggleSelectOn = new Func<int, bool>(this.IsRoleSelectOn)
		};
	}

	// Token: 0x0601114E RID: 69966 RVA: 0x0042A1BD File Offset: 0x004283BD
	private void RoleItemToggleCallBack(bool state, int roleId, int index)
	{
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		if (state)
		{
			this.CurrentSelectRoleId = roleId;
			this.RoleScrollView.SelectGridProxy(index, false);
		}
		else
		{
			this.CurrentSelectRoleId = 0;
		}
		this.RefreshViewState();
	}

	// Token: 0x0601114F RID: 69967 RVA: 0x0042A1F1 File Offset: 0x004283F1
	private bool IsRoleSelectOn(int roleId)
	{
		return this.CurrentSelectRoleId == roleId;
	}

	// Token: 0x06011150 RID: 69968 RVA: 0x0042A1FC File Offset: 0x004283FC
	private void OnClickConfirmBtn(int _)
	{
		if (!ShipTogetherModel.Instance.IsInMovieRideSharingMode)
		{
			return;
		}
		int riderSharingRoleId = ShipTogetherModel.Instance.RiderSharingRoleId;
		if (this.CurrentSelectRoleId != 0 && this.CurrentSelectRoleId != riderSharingRoleId)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnChangeRideSharingPassenger, this.CurrentSelectRoleId, 1);
		}
		else if (this.CurrentSelectRoleId == 0 && riderSharingRoleId != 0)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnRemoveRideSharingPassenger, -1, -1);
		}
		base.CloseMe(null);
	}

	// Token: 0x06011151 RID: 69969 RVA: 0x0042A26F File Offset: 0x0042846F
	private void OnClickExitBtn()
	{
		if (!ShipTogetherModel.Instance.RiderSharingState)
		{
			return;
		}
		if (ShipTogetherModel.Instance.IsInMovieRideSharingMode && this.ExitRideSharePromise == null)
		{
			this.ExitRideShareMode().Forget();
		}
	}

	// Token: 0x06011152 RID: 69970 RVA: 0x0042A2A0 File Offset: 0x004284A0
	private UniTask ExitRideShareMode()
	{
		MotorcycleTogetherView.<ExitRideShareMode>d__22 <ExitRideShareMode>d__;
		<ExitRideShareMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExitRideShareMode>d__.<>4__this = this;
		<ExitRideShareMode>d__.<>1__state = -1;
		<ExitRideShareMode>d__.<>t__builder.Start<MotorcycleTogetherView.<ExitRideShareMode>d__22>(ref <ExitRideShareMode>d__);
		return <ExitRideShareMode>d__.<>t__builder.Task;
	}

	// Token: 0x06011153 RID: 69971 RVA: 0x0042A2E3 File Offset: 0x004284E3
	private void OnMovieMotorRideSharingModeChangeResponse(bool enable, bool success)
	{
		CustomPromise exitRideSharePromise = this.ExitRideSharePromise;
		if (exitRideSharePromise != null)
		{
			exitRideSharePromise.SetResult();
		}
		this.ExitRideSharePromise = null;
		if (!enable)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0400821F RID: 33311
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008220 RID: 33312
	private AreaSwitchGroupItem AreaSwitchGroupItem;

	// Token: 0x04008221 RID: 33313
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTogetherRoleItem, RoleInstance> RoleScrollView;

	// Token: 0x04008222 RID: 33314
	private ButtonItem ButtonConfirm;

	// Token: 0x04008223 RID: 33315
	private int CurrentSelectRoleId;

	// Token: 0x04008224 RID: 33316
	private CustomPromise ExitRideSharePromise;

	// Token: 0x02008761 RID: 34657
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C016 RID: 180246
		public const int CaptionItem = 0;

		// Token: 0x0402C017 RID: 180247
		public const int SwitchGroupItem = 1;

		// Token: 0x0402C018 RID: 180248
		public const int RoleLoopScrollView = 2;

		// Token: 0x0402C019 RID: 180249
		public const int RoleItem = 3;

		// Token: 0x0402C01A RID: 180250
		public const int BtnConfirm = 4;

		// Token: 0x0402C01B RID: 180251
		public const int BtnExit = 5;

		// Token: 0x0402C01C RID: 180252
		public const int EmptyItem = 6;
	}
}
