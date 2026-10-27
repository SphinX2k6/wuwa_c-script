using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TreasureHunt;

// Token: 0x02001F3E RID: 7998
public class TreasureCompassHandle : HudUnitHandleBase
{
	// Token: 0x0600F713 RID: 63251 RVA: 0x003BB216 File Offset: 0x003B9416
	protected override void OnInitialize()
	{
		base.OnInitialize();
		this.IsEnableTick = TreasureHuntModel.Instance.IsCompassActive();
		this.TrackingEntityId = 0;
		this.LoadCompassView();
	}

	// Token: 0x0600F714 RID: 63252 RVA: 0x003BB23B File Offset: 0x003B943B
	protected override void OnDestroyed()
	{
		if (this.TreasureCompassUnit != null)
		{
			base.DestroyHudUnit(this.TreasureCompassUnit);
			this.TreasureCompassUnit = null;
		}
		TreasureHuntController.Instance.ClearNearbyTrack();
	}

	// Token: 0x0600F715 RID: 63253 RVA: 0x003BB262 File Offset: 0x003B9462
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnUpdateCompassActive, new Action<bool>(this.OnUpdateCompassActive));
	}

	// Token: 0x0600F716 RID: 63254 RVA: 0x003BB280 File Offset: 0x003B9480
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnUpdateCompassActive, new Action<bool>(this.OnUpdateCompassActive));
	}

	// Token: 0x0600F717 RID: 63255 RVA: 0x003BB29E File Offset: 0x003B949E
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

	// Token: 0x0600F718 RID: 63256 RVA: 0x003BB2BB File Offset: 0x003B94BB
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

	// Token: 0x0600F719 RID: 63257 RVA: 0x003BB2E8 File Offset: 0x003B94E8
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

	// Token: 0x04007261 RID: 29281
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat TickStatsObject = Stat.Create("TreasureCompassHandleTick", "", "");

	// Token: 0x04007262 RID: 29282
	[Nullable(2)]
	private TreasureCompassUnit TreasureCompassUnit;

	// Token: 0x04007263 RID: 29283
	private bool IsEnableTick;

	// Token: 0x04007264 RID: 29284
	private int TrackingEntityId;
}
