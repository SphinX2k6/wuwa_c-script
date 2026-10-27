using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.TreasureHunt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F1C RID: 7964
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class HudUnitController : UiControllerBase
{
	// Token: 0x0600F557 RID: 62807 RVA: 0x003B2F63 File Offset: 0x003B1163
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600F558 RID: 62808 RVA: 0x003B2F66 File Offset: 0x003B1166
	protected override bool OnClear()
	{
		HudUnitManager.Instance.Clear();
		this.DelayCreateHudList.Clear();
		return true;
	}

	// Token: 0x0600F559 RID: 62809 RVA: 0x003B2F7E File Offset: 0x003B117E
	protected override bool OnLeaveLevel()
	{
		HudUnitManager.Instance.Clear();
		this.DelayCreateHudList.Clear();
		return true;
	}

	// Token: 0x0600F55A RID: 62810 RVA: 0x003B2F96 File Offset: 0x003B1196
	protected override void OnTick(float delta)
	{
		HudUnitManager.Instance.Tick(delta);
	}

	// Token: 0x0600F55B RID: 62811 RVA: 0x003B2FA3 File Offset: 0x003B11A3
	protected override void OnAfterTick(float delta)
	{
		HudUnitManager.Instance.AfterTick(delta);
	}

	// Token: 0x0600F55C RID: 62812 RVA: 0x003B2FB0 File Offset: 0x003B11B0
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600F55D RID: 62813 RVA: 0x003B3030 File Offset: 0x003B1230
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600F55E RID: 62814 RVA: 0x003B30B0 File Offset: 0x003B12B0
	private void OnBattleUiChildVisibleChanged()
	{
		UUIItem battleViewUnit = UiLayer.Instance.GetBattleViewUnit(1);
		UUIItem battleViewUnit2 = UiLayer.Instance.GetBattleViewUnit(3);
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
		battleViewUnit.SetUIActive(childVisible);
		battleViewUnit2.SetUIActive(childVisible);
		if (childVisible)
		{
			if (!GameModeModel.Instance.WorldDone)
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "WorldDone前不允许打开hud", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			HudUnitManager.Instance.ShowHud();
			if (this.DelayCreateHudList.Count > 0)
			{
				foreach (EHudUnitType key in this.DelayCreateHudList)
				{
					Type type;
					HudUnitManager.Instance.HudUnitHandleClassMap.TryGetValue(key, out type);
					if (type != null)
					{
						HudUnitManager.Instance.TryNew(type);
					}
				}
				this.DelayCreateHudList.Clear();
				return;
			}
		}
		else
		{
			HudUnitManager.Instance.HideHud();
		}
	}

	// Token: 0x0600F55F RID: 62815 RVA: 0x003B31BC File Offset: 0x003B13BC
	public void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		HudUnitManager.Instance.RefreshHudOnInputControllerChanged(last, now);
	}

	// Token: 0x0600F560 RID: 62816 RVA: 0x003B31CA File Offset: 0x003B13CA
	public void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.IsRolePassenger(true) && TreasureHuntModel.Instance.IsEnableCompassTrack(info.VehicleType))
		{
			this.TryCreateHud(EHudUnitType.TreasureCompass);
		}
	}

	// Token: 0x0600F561 RID: 62817 RVA: 0x003B31EE File Offset: 0x003B13EE
	public void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.IsRolePassenger(true) && TreasureHuntModel.Instance.IsEnableCompassTrack(info.VehicleType))
		{
			this.TryDestroyHud(EHudUnitType.TreasureCompass);
		}
	}

	// Token: 0x0600F562 RID: 62818 RVA: 0x003B3214 File Offset: 0x003B1414
	public void TryCreateHud(EHudUnitType type)
	{
		if (!GameModeModel.Instance.WorldDone)
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "WorldDone前不允许打开hud, 缓存起来", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.DelayCreateHudList.Add(type);
			return;
		}
		Type type2;
		HudUnitManager.Instance.HudUnitHandleClassMap.TryGetValue(type, out type2);
		if (type2 != null)
		{
			HudUnitManager.Instance.TryNew(type2);
		}
	}

	// Token: 0x0600F563 RID: 62819 RVA: 0x003B3280 File Offset: 0x003B1480
	public void TryDestroyHud(EHudUnitType type)
	{
		if (this.DelayCreateHudList.Remove(type))
		{
			return;
		}
		Type type2;
		HudUnitManager.Instance.HudUnitHandleClassMap.TryGetValue(type, out type2);
		if (type2 != null)
		{
			HudUnitManager.Instance.Destroy(type2);
		}
	}

	// Token: 0x0600F564 RID: 62820 RVA: 0x003B32C3 File Offset: 0x003B14C3
	public bool GetIsInitHud()
	{
		return HudUnitManager.Instance.GetIsInitHud();
	}

	// Token: 0x17001337 RID: 4919
	// (get) Token: 0x0600F565 RID: 62821 RVA: 0x003B32CF File Offset: 0x003B14CF
	public static HudUnitController Instance
	{
		get
		{
			return HudUnitController._Instance;
		}
	}

	// Token: 0x0600F566 RID: 62822 RVA: 0x003B32D6 File Offset: 0x003B14D6
	public static HudUnitController GetOrCreateInstance()
	{
		if (HudUnitController._Instance == null)
		{
			HudUnitController.CreateInstance();
		}
		return HudUnitController._Instance;
	}

	// Token: 0x0600F567 RID: 62823 RVA: 0x003B32EA File Offset: 0x003B14EA
	public static bool CreateInstance()
	{
		if (HudUnitController._Instance != null)
		{
			return true;
		}
		HudUnitController._Instance = new HudUnitController();
		return true;
	}

	// Token: 0x0600F568 RID: 62824 RVA: 0x003B3300 File Offset: 0x003B1500
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F569 RID: 62825 RVA: 0x003B3302 File Offset: 0x003B1502
	public static void ResetStaticDefaultValue()
	{
		HudUnitController._Instance = null;
	}

	// Token: 0x0600F56A RID: 62826 RVA: 0x003B330A File Offset: 0x003B150A
	static HudUnitController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitController.CreateStaticDefaultValue), new Action(HudUnitController.ResetStaticDefaultValue));
	}

	// Token: 0x0400716F RID: 29039
	private readonly HashSet<EHudUnitType> DelayCreateHudList = new HashSet<EHudUnitType>();

	// Token: 0x04007170 RID: 29040
	[Nullable(2)]
	private static HudUnitController _Instance;
}
