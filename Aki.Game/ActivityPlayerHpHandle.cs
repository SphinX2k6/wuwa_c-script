using System;
using System.Runtime.CompilerServices;

// Token: 0x02000373 RID: 883
[NullableContext(2)]
[Nullable(0)]
public class ActivityPlayerHpHandle
{
	// Token: 0x06003127 RID: 12583 RVA: 0x0011C388 File Offset: 0x0011A588
	public void Init(long? lowHpCueId = null, float? lowHpPercent = null, long? hurtCueId = null, int? duration = null)
	{
		this.IsInit = true;
		if (lowHpCueId != null)
		{
			this.LowHpCueId = lowHpCueId.Value;
		}
		if (hurtCueId != null)
		{
			this.HurtCueId = hurtCueId.Value;
		}
		if (lowHpPercent != null)
		{
			this.LowHpPercent = lowHpPercent.Value;
		}
		if (duration != null)
		{
			this.Duration = duration.Value;
		}
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetCurrentEntity : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return;
		}
		this.CueComp = entityHandle.Entity.GetComponent<CharacterGameplayCueComponent>();
	}

	// Token: 0x06003128 RID: 12584 RVA: 0x0011C42C File Offset: 0x0011A62C
	[NullableContext(1)]
	public void OnPlayerHpChange(KscHeadStateData kscPlayerHeadStateData)
	{
		if (!this.IsInit)
		{
			return;
		}
		if (kscPlayerHeadStateData.MaxHp <= 0)
		{
			return;
		}
		if ((float)kscPlayerHeadStateData.Hp < this.LastHp && kscPlayerHeadStateData.Hp < kscPlayerHeadStateData.MaxHp)
		{
			this.AddHurtGameplayCue();
		}
		this.LastHp = (float)kscPlayerHeadStateData.Hp;
		if ((float)kscPlayerHeadStateData.Hp / (float)kscPlayerHeadStateData.MaxHp <= this.LowHpPercent)
		{
			this.AddLowHpGameplayCue();
			return;
		}
		this.RemoveLowHpGameplayCue();
	}

	// Token: 0x06003129 RID: 12585 RVA: 0x0011C4A0 File Offset: 0x0011A6A0
	private void AddLowHpGameplayCue()
	{
		if (this.LowHpCueHandleId > 0)
		{
			return;
		}
		if (this.CueComp != null && this.LowHpCueId > 0L)
		{
			this.LowHpCueHandleId = this.CueComp.AddCue(this.LowHpCueId, null);
		}
	}

	// Token: 0x0600312A RID: 12586 RVA: 0x0011C4E9 File Offset: 0x0011A6E9
	private void RemoveLowHpGameplayCue()
	{
		if (this.LowHpCueHandleId <= 0)
		{
			return;
		}
		CharacterGameplayCueComponent cueComp = this.CueComp;
		if (cueComp != null)
		{
			cueComp.RemoveCueByHandle((long)this.LowHpCueHandleId);
		}
		this.LowHpCueHandleId = 0;
	}

	// Token: 0x0600312B RID: 12587 RVA: 0x0011C514 File Offset: 0x0011A714
	private void AddHurtGameplayCue()
	{
		if (this.HurtCueHandleId > 0)
		{
			return;
		}
		if (this.CueComp != null && this.HurtCueId > 0L)
		{
			this.HurtCueHandleId = this.CueComp.AddCue(this.HurtCueId, null);
			this.AddTimer();
		}
	}

	// Token: 0x0600312C RID: 12588 RVA: 0x0011C563 File Offset: 0x0011A763
	private void RemoveHurtGameplayCue()
	{
		if (this.HurtCueHandleId <= 0)
		{
			return;
		}
		CharacterGameplayCueComponent cueComp = this.CueComp;
		if (cueComp != null)
		{
			cueComp.RemoveCueByHandle((long)this.HurtCueHandleId);
		}
		this.HurtCueHandleId = 0;
	}

	// Token: 0x0600312D RID: 12589 RVA: 0x0011C58E File Offset: 0x0011A78E
	private void AddTimer()
	{
		this.TimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimer), (float)this.Duration, null, null, true, 1f);
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x0011C5BB File Offset: 0x0011A7BB
	private void RemoveTimer()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x0011C5DD File Offset: 0x0011A7DD
	private void OnTimer(float time)
	{
		this.TimerId = null;
		this.RemoveHurtGameplayCue();
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x0011C5EC File Offset: 0x0011A7EC
	public void Clear()
	{
		this.RemoveLowHpGameplayCue();
		this.RemoveHurtGameplayCue();
		this.RemoveTimer();
		this.IsInit = false;
	}

	// Token: 0x04002B39 RID: 11065
	private bool IsInit;

	// Token: 0x04002B3A RID: 11066
	private float LastHp;

	// Token: 0x04002B3B RID: 11067
	private CharacterGameplayCueComponent CueComp;

	// Token: 0x04002B3C RID: 11068
	private int LowHpCueHandleId;

	// Token: 0x04002B3D RID: 11069
	private int HurtCueHandleId;

	// Token: 0x04002B3E RID: 11070
	private TimerHandle TimerId;

	// Token: 0x04002B3F RID: 11071
	private int Duration = 500;

	// Token: 0x04002B40 RID: 11072
	public long LowHpCueId = (long)((ulong)-1584967294);

	// Token: 0x04002B41 RID: 11073
	public long HurtCueId = (long)((ulong)-1584967295);

	// Token: 0x04002B42 RID: 11074
	public float LowHpPercent = 0.3f;
}
