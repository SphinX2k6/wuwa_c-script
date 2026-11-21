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

// Token: 0x02001715 RID: 5909
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleTogetherView : UiViewBase
{
	// Token: 0x0600E5D9 RID: 58841 RVA: 0x00436984 File Offset: 0x00434B84
	[NullableContext(1)]
	public MotorcycleTogetherView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E5DA RID: 58842 RVA: 0x00436990 File Offset: 0x00434B90
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

	// Token: 0x0600E5DB RID: 58843 RVA: 0x00436A68 File Offset: 0x00434C68
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleTogetherView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleTogetherView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E5DC RID: 58844 RVA: 0x00436AAC File Offset: 0x00434CAC
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

	// Token: 0x0600E5DD RID: 58845 RVA: 0x00436B90 File Offset: 0x00434D90
	protected override void OnBeforeShow()
	{
	}

	// Token: 0x0600E5DE RID: 58846 RVA: 0x00436B92 File Offset: 0x00434D92
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
	}

	// Token: 0x0600E5DF RID: 58847 RVA: 0x00436BB0 File Offset: 0x00434DB0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
	}

	// Token: 0x0600E5E0 RID: 58848 RVA: 0x00436BCE File Offset: 0x00434DCE
	private void OnSwitchArea(int areaId)
	{
		this.RefreshRoleList(areaId);
	}

	// Token: 0x0600E5E1 RID: 58849 RVA: 0x00436BD8 File Offset: 0x00434DD8
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

	// Token: 0x0600E5E2 RID: 58850 RVA: 0x00436D00 File Offset: 0x00434F00
	private void RefreshViewState()
	{
		bool flag = this.CurrentSelectRoleId != 0;
		this.ButtonConfirm.SetLocalTextNew(flag ? "MotorSharingRide_Button01" : "MotorSharingRide_Button02", Array.Empty<object>());
	}

	// Token: 0x0600E5E3 RID: 58851 RVA: 0x00436D36 File Offset: 0x00434F36
	[NullableContext(1)]
	private MotorcycleTogetherRoleItem CreateLoopItem()
	{
		return new MotorcycleTogetherRoleItem
		{
			OnClickToggleCallBack = new Action<bool, int, int>(this.RoleItemToggleCallBack),
			IsToggleSelectOn = new Func<int, bool>(this.IsRoleSelectOn)
		};
	}

	// Token: 0x0600E5E4 RID: 58852 RVA: 0x00436D61 File Offset: 0x00434F61
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

	// Token: 0x0600E5E5 RID: 58853 RVA: 0x00436D95 File Offset: 0x00434F95
	private bool IsRoleSelectOn(int roleId)
	{
		return this.CurrentSelectRoleId == roleId;
	}

	// Token: 0x0600E5E6 RID: 58854 RVA: 0x00436DA0 File Offset: 0x00434FA0
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

	// Token: 0x0600E5E7 RID: 58855 RVA: 0x00436E13 File Offset: 0x00435013
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

	// Token: 0x0600E5E8 RID: 58856 RVA: 0x00436E44 File Offset: 0x00435044
	private UniTask ExitRideShareMode()
	{
		MotorcycleTogetherView.<ExitRideShareMode>d__22 <ExitRideShareMode>d__;
		<ExitRideShareMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExitRideShareMode>d__.<>4__this = this;
		<ExitRideShareMode>d__.<>1__state = -1;
		<ExitRideShareMode>d__.<>t__builder.Start<MotorcycleTogetherView.<ExitRideShareMode>d__22>(ref <ExitRideShareMode>d__);
		return <ExitRideShareMode>d__.<>t__builder.Task;
	}

	// Token: 0x0600E5E9 RID: 58857 RVA: 0x00436E87 File Offset: 0x00435087
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

	// Token: 0x0400835D RID: 33629
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400835E RID: 33630
	private AreaSwitchGroupItem AreaSwitchGroupItem;

	// Token: 0x0400835F RID: 33631
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleTogetherRoleItem, RoleInstance> RoleScrollView;

	// Token: 0x04008360 RID: 33632
	private ButtonItem ButtonConfirm;

	// Token: 0x04008361 RID: 33633
	private int CurrentSelectRoleId;

	// Token: 0x04008362 RID: 33634
	private CustomPromise ExitRideSharePromise;

	// Token: 0x020078EA RID: 30954
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402732E RID: 160558
		public const int CaptionItem = 0;

		// Token: 0x0402732F RID: 160559
		public const int SwitchGroupItem = 1;

		// Token: 0x04027330 RID: 160560
		public const int RoleLoopScrollView = 2;

		// Token: 0x04027331 RID: 160561
		public const int RoleItem = 3;

		// Token: 0x04027332 RID: 160562
		public const int BtnConfirm = 4;

		// Token: 0x04027333 RID: 160563
		public const int BtnExit = 5;

		// Token: 0x04027334 RID: 160564
		public const int EmptyItem = 6;
	}
}
