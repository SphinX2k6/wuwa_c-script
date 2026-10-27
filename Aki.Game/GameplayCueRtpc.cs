using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FD2 RID: 12242
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueRtpc : GameplayCueMagnitude
{
	// Token: 0x06019F43 RID: 106307 RVA: 0x006CA888 File Offset: 0x006C8A88
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

	// Token: 0x06019F44 RID: 106308 RVA: 0x006CA96B File Offset: 0x006C8B6B
	protected override bool UseMagnitude()
	{
		return !this.DisableByTeammate && base.UseMagnitude();
	}

	// Token: 0x06019F45 RID: 106309 RVA: 0x006CA97D File Offset: 0x006C8B7D
	protected override void OnDestroy()
	{
		if (this.SendZeroOnDestroy)
		{
			this.SetRtpcValue(0f);
		}
		this.ActorComp = null;
		base.OnDestroy();
	}

	// Token: 0x06019F46 RID: 106310 RVA: 0x006CA99F File Offset: 0x006C8B9F
	protected override void OnSetMagnitude(float normalizedValue)
	{
		this.SetRtpcValue(normalizedValue);
	}

	// Token: 0x06019F47 RID: 106311 RVA: 0x006CA9A8 File Offset: 0x006C8BA8
	protected override float Normalize()
	{
		return this.Value;
	}

	// Token: 0x06019F48 RID: 106312 RVA: 0x006CA9B0 File Offset: 0x006C8BB0
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

	// Token: 0x0400C477 RID: 50295
	private bool DisableByTeammate;

	// Token: 0x0400C478 RID: 50296
	private BaseActorComponent ActorComp;

	// Token: 0x0400C479 RID: 50297
	private string RtpcKey;

	// Token: 0x0400C47A RID: 50298
	private bool SendZeroOnDestroy;
}
