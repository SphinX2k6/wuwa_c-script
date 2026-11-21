using System;
using System.Runtime.CompilerServices;

// Token: 0x02002526 RID: 9510
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueRtpc : GameplayCueMagnitude
{
	// Token: 0x06017855 RID: 96341 RVA: 0x006F117C File Offset: 0x006EF37C
	protected override void OnInit()
	{
		base.OnInit();
		this.RtpcKey = ((this.CueConfig.ParametersLength > 0) ? this.CueConfig.Parameters(0) : string.Empty);
		this.SendZeroOnDestroy = (this.CueConfig.ParametersLength > 1 && this.CueConfig.Parameters(1) == "1");
		WorldEntity entity = this.EntityHandle.Entity;
		CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
		int playerId = CreatureModel.Instance.GetPlayerId();
		int? num = (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPlayerId()) : null;
		this.DisableByTeammate = !(playerId == num.GetValueOrDefault() & num != null);
		if (this.DisableByTeammate)
		{
			return;
		}
		WorldEntity entity2 = this.EntityHandle.Entity;
		this.ActorComp = ((entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null);
	}

	// Token: 0x06017856 RID: 96342 RVA: 0x006F125F File Offset: 0x006EF45F
	protected override bool UseMagnitude()
	{
		return !this.DisableByTeammate && base.UseMagnitude();
	}

	// Token: 0x06017857 RID: 96343 RVA: 0x006F1271 File Offset: 0x006EF471
	protected override void OnDestroy()
	{
		if (this.SendZeroOnDestroy)
		{
			this.SetRtpcValue(0f);
		}
		this.ActorComp = null;
		base.OnDestroy();
	}

	// Token: 0x06017858 RID: 96344 RVA: 0x006F1293 File Offset: 0x006EF493
	protected override void OnSetMagnitude(float normalizedValue)
	{
		this.SetRtpcValue(normalizedValue);
	}

	// Token: 0x06017859 RID: 96345 RVA: 0x006F129C File Offset: 0x006EF49C
	protected override float Normalize()
	{
		return this.Value;
	}

	// Token: 0x0601785A RID: 96346 RVA: 0x006F12A4 File Offset: 0x006EF4A4
	private void SetRtpcValue(float value)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		AudioSystem.Instance.SetRtpcValue(this.RtpcKey, value, new SetRtpcValueArgs?(new SetRtpcValueArgs
		{
			Actor = this.ActorComp.Owner
		}));
	}

	// Token: 0x0400C820 RID: 51232
	private bool DisableByTeammate;

	// Token: 0x0400C821 RID: 51233
	private BaseActorComponent ActorComp;

	// Token: 0x0400C822 RID: 51234
	private string RtpcKey;

	// Token: 0x0400C823 RID: 51235
	private bool SendZeroOnDestroy;
}
