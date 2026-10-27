using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EBE RID: 3774
[NullableContext(2)]
[Nullable(0)]
public class ActivityPlayerHpHandle
{
	// Token: 0x06005D90 RID: 23952 RVA: 0x001146A8 File Offset: 0x001128A8
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

	// Token: 0x06005D91 RID: 23953 RVA: 0x0011474C File Offset: 0x0011294C
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

	// Token: 0x06005D92 RID: 23954 RVA: 0x001147C0 File Offset: 0x001129C0
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

	// Token: 0x06005D93 RID: 23955 RVA: 0x00114809 File Offset: 0x00112A09
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

	// Token: 0x06005D94 RID: 23956 RVA: 0x00114834 File Offset: 0x00112A34
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

	// Token: 0x06005D95 RID: 23957 RVA: 0x00114883 File Offset: 0x00112A83
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

	// Token: 0x06005D96 RID: 23958 RVA: 0x001148AE File Offset: 0x00112AAE
	private void AddTimer()
	{
		this.TimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimer), (float)this.Duration, null, null, true, 1f);
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x001148DB File Offset: 0x00112ADB
	private void RemoveTimer()
	{
		if (this.TimerId != null)
		{
			TimerSystem.Instance.Remove(this.TimerId);
			this.TimerId = null;
		}
	}

	// Token: 0x06005D98 RID: 23960 RVA: 0x001148FD File Offset: 0x00112AFD
	private void OnTimer(float time)
	{
		this.TimerId = null;
		this.RemoveHurtGameplayCue();
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x0011490C File Offset: 0x00112B0C
	public void Clear()
	{
		this.RemoveLowHpGameplayCue();
		this.RemoveHurtGameplayCue();
		this.RemoveTimer();
		this.IsInit = false;
	}

	// Token: 0x04002A9E RID: 10910
	private bool IsInit;

	// Token: 0x04002A9F RID: 10911
	private float LastHp;

	// Token: 0x04002AA0 RID: 10912
	private CharacterGameplayCueComponent CueComp;

	// Token: 0x04002AA1 RID: 10913
	private int LowHpCueHandleId;

	// Token: 0x04002AA2 RID: 10914
	private int HurtCueHandleId;

	// Token: 0x04002AA3 RID: 10915
	private TimerHandle TimerId;

	// Token: 0x04002AA4 RID: 10916
	private int Duration = 500;

	// Token: 0x04002AA5 RID: 10917
	public long LowHpCueId = (long)((ulong)-1584967294);

	// Token: 0x04002AA6 RID: 10918
	public long HurtCueId = (long)((ulong)-1584967295);

	// Token: 0x04002AA7 RID: 10919
	public float LowHpPercent = 0.3f;
}
