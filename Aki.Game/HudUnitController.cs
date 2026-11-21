using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.TreasureHunt;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013DE RID: 5086
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class HudUnitController : UiControllerBase
{
	// Token: 0x0600C976 RID: 51574 RVA: 0x003BEA4F File Offset: 0x003BCC4F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600C977 RID: 51575 RVA: 0x003BEA52 File Offset: 0x003BCC52
	protected override bool OnClear()
	{
		HudUnitManager.Instance.Clear();
		this.DelayCreateHudList.Clear();
		return true;
	}

	// Token: 0x0600C978 RID: 51576 RVA: 0x003BEA6A File Offset: 0x003BCC6A
	protected override bool OnLeaveLevel()
	{
		HudUnitManager.Instance.Clear();
		this.DelayCreateHudList.Clear();
		return true;
	}

	// Token: 0x0600C979 RID: 51577 RVA: 0x003BEA82 File Offset: 0x003BCC82
	protected override void OnTick(float delta)
	{
		HudUnitManager.Instance.Tick(delta);
	}

	// Token: 0x0600C97A RID: 51578 RVA: 0x003BEA8F File Offset: 0x003BCC8F
	protected override void OnAfterTick(float delta)
	{
		HudUnitManager.Instance.AfterTick(delta);
	}

	// Token: 0x0600C97B RID: 51579 RVA: 0x003BEA9C File Offset: 0x003BCC9C
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Add<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600C97C RID: 51580 RVA: 0x003BEB1C File Offset: 0x003BCD1C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnEnterVehicle, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.Remove<VehiclePassengerInfo, bool>(EEventName.OnLeaveVehicle, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleUiChildVisibleChanged));
	}

	// Token: 0x0600C97D RID: 51581 RVA: 0x003BEB9C File Offset: 0x003BCD9C
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

	// Token: 0x0600C97E RID: 51582 RVA: 0x003BECA8 File Offset: 0x003BCEA8
	public void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		HudUnitManager.Instance.RefreshHudOnInputControllerChanged(last, now);
	}

	// Token: 0x0600C97F RID: 51583 RVA: 0x003BECB6 File Offset: 0x003BCEB6
	public void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.IsRolePassenger(true) && TreasureHuntModel.Instance.IsEnableCompassTrack(info.VehicleType))
		{
			this.TryCreateHud(EHudUnitType.TreasureCompass);
		}
	}

	// Token: 0x0600C980 RID: 51584 RVA: 0x003BECDA File Offset: 0x003BCEDA
	public void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.IsRolePassenger(true) && TreasureHuntModel.Instance.IsEnableCompassTrack(info.VehicleType))
		{
			this.TryDestroyHud(EHudUnitType.TreasureCompass);
		}
	}

	// Token: 0x0600C981 RID: 51585 RVA: 0x003BED00 File Offset: 0x003BCF00
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

	// Token: 0x0600C982 RID: 51586 RVA: 0x003BED6C File Offset: 0x003BCF6C
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

	// Token: 0x0600C983 RID: 51587 RVA: 0x003BEDAF File Offset: 0x003BCFAF
	public bool GetIsInitHud()
	{
		return HudUnitManager.Instance.GetIsInitHud();
	}

	// Token: 0x17001361 RID: 4961
	// (get) Token: 0x0600C984 RID: 51588 RVA: 0x003BEDBB File Offset: 0x003BCFBB
	public static HudUnitController Instance
	{
		get
		{
			return HudUnitController._Instance;
		}
	}

	// Token: 0x0600C985 RID: 51589 RVA: 0x003BEDC2 File Offset: 0x003BCFC2
	public static HudUnitController GetOrCreateInstance()
	{
		if (HudUnitController._Instance == null)
		{
			HudUnitController.CreateInstance();
		}
		return HudUnitController._Instance;
	}

	// Token: 0x0600C986 RID: 51590 RVA: 0x003BEDD6 File Offset: 0x003BCFD6
	public static bool CreateInstance()
	{
		if (HudUnitController._Instance != null)
		{
			return true;
		}
		HudUnitController._Instance = new HudUnitController();
		return true;
	}

	// Token: 0x0600C987 RID: 51591 RVA: 0x003BEDEC File Offset: 0x003BCFEC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C988 RID: 51592 RVA: 0x003BEDEE File Offset: 0x003BCFEE
	public static void ResetStaticDefaultValue()
	{
		HudUnitController._Instance = null;
	}

	// Token: 0x0600C989 RID: 51593 RVA: 0x003BEDF6 File Offset: 0x003BCFF6
	static HudUnitController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HudUnitController.CreateStaticDefaultValue), new Action(HudUnitController.ResetStaticDefaultValue));
	}

	// Token: 0x04007250 RID: 29264
	private readonly HashSet<EHudUnitType> DelayCreateHudList = new HashSet<EHudUnitType>();

	// Token: 0x04007251 RID: 29265
	[Nullable(2)]
	private static HudUnitController _Instance;
}
