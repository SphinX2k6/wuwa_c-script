using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TreasureHunt;

// Token: 0x02001400 RID: 5120
public class TreasureCompassHandle : HudUnitHandleBase
{
	// Token: 0x0600CB32 RID: 52018 RVA: 0x003C6D02 File Offset: 0x003C4F02
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.IsEnableTick = TreasureHuntModel.Instance.IsCompassActive();
		this.TrackingEntityId = 0;
		this.LoadCompassView();
	}

	// Token: 0x0600CB33 RID: 52019 RVA: 0x003C6D27 File Offset: 0x003C4F27
	protected override void OnDestroyed()
	{
		if (this.TreasureCompassUnit != null)
		{
			base.DestroyHudUnit(this.TreasureCompassUnit);
			this.TreasureCompassUnit = null;
		}
		TreasureHuntController.Instance.ClearNearbyTrack();
	}

	// Token: 0x0600CB34 RID: 52020 RVA: 0x003C6D4E File Offset: 0x003C4F4E
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnUpdateCompassActive, new Action<bool>(this.OnUpdateCompassActive));
	}

	// Token: 0x0600CB35 RID: 52021 RVA: 0x003C6D6C File Offset: 0x003C4F6C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnUpdateCompassActive, new Action<bool>(this.OnUpdateCompassActive));
	}

	// Token: 0x0600CB36 RID: 52022 RVA: 0x003C6D8A File Offset: 0x003C4F8A
	private void OnUpdateCompassActive(bool isActive)
	{
		this.IsEnableTick = isActive;
		if (!isActive)
		{
			TreasureCompassUnit treasureCompassUnit = this.TreasureCompassUnit;
			if (treasureCompassUnit == null)
			{
				return;
			}
			treasureCompassUnit.SetActive(false);
		}
	}

	// Token: 0x0600CB37 RID: 52023 RVA: 0x003C6DA7 File Offset: 0x003C4FA7
	private void LoadCompassView()
	{
		base.NewHudUnitWithReturn<TreasureCompassUnit>(typeof(TreasureCompassUnit), "UiItem_ShipRing", out this.TreasureCompassUnit, false, delegate(TreasureCompassUnit _)
		{
			TreasureCompassUnit treasureCompassUnit = this.TreasureCompassUnit;
			if (treasureCompassUnit == null)
			{
				return;
			}
			treasureCompassUnit.InitHide();
		}, true);
	}

	// Token: 0x0600CB38 RID: 52024 RVA: 0x003C6DD4 File Offset: 0x003C4FD4
	protected override void OnTick(float delta)
	{
		if (!this.IsEnableTick)
		{
			return;
		}
		List<ITreasureData> treasureList = TreasureHuntModel.Instance.GetTreasureList(true);
		if (treasureList == null || treasureList.Count == 0)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
		}
		Vector vector2 = vector;
		if (vector2 == null)
		{
			return;
		}
		ITreasureData treasureData = null;
		foreach (ITreasureData treasureData2 in treasureList)
		{
			if (treasureData2.IsEnableCompassTracking.GetValueOrDefault())
			{
				treasureData = treasureData2;
				break;
			}
		}
		if (treasureData == null)
		{
			this.TrackingEntityId = 0;
			TreasureHuntController.Instance.ClearNearbyTrack();
		}
		else if (treasureData.IsNearbyTracking.GetValueOrDefault())
		{
			double? num = treasureData.DistSquared;
			double? num2 = treasureData.NearbyTrackHideRangeSquared;
			if (num.GetValueOrDefault() > num2.GetValueOrDefault() & (num != null & num2 != null))
			{
				this.TrackingEntityId = 0;
				TreasureHuntController.Instance.ClearNearbyTrack();
			}
		}
		else
		{
			double? num2 = treasureData.DistSquared;
			double? num = treasureData.NearbyTrackShowRangeSquared;
			if ((num2.GetValueOrDefault() < num.GetValueOrDefault() & (num2 != null & num != null)) && treasureData.EntityId != this.TrackingEntityId)
			{
				this.TrackingEntityId = treasureData.EntityId;
				TreasureHuntController.Instance.SetNearbyTrack(treasureData.EntityId);
			}
		}
		TreasureCompassUnit treasureCompassUnit = this.TreasureCompassUnit;
		if (treasureCompassUnit == null)
		{
			return;
		}
		treasureCompassUnit.RefreshCompass(treasureList, vector2);
	}

	// Token: 0x04007342 RID: 29506
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat TickStatsObject = Stat.Create("TreasureCompassHandleTick", "", "");

	// Token: 0x04007343 RID: 29507
	[Nullable(2)]
	private TreasureCompassUnit TreasureCompassUnit;

	// Token: 0x04007344 RID: 29508
	private bool IsEnableTick;

	// Token: 0x04007345 RID: 29509
	private int TrackingEntityId;
}
