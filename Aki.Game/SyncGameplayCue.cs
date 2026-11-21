using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020024D5 RID: 9429
[NullableContext(1)]
[Nullable(0)]
public class SyncGameplayCue : BuffEffect
{
	// Token: 0x06017676 RID: 95862 RVA: 0x006E4C3B File Offset: 0x006E2E3B
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017677 RID: 95863 RVA: 0x006E4C40 File Offset: 0x006E2E40
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null)
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.SyncCueIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.SyncCueIds[i] = long.Parse(array[i]);
			}
		}
	}

	// Token: 0x06017678 RID: 95864 RVA: 0x006E4C90 File Offset: 0x006E2E90
	public override void OnCreated()
	{
		EntityHandle instigatorEntity = base.InstigatorEntity;
		if (instigatorEntity != null && instigatorEntity.Valid)
		{
			int instigatorEntityId = this.InstigatorEntityId;
			Entity ownerEntity = base.OwnerEntity;
			int? num = (ownerEntity != null) ? new int?(ownerEntity.Id) : null;
			if (!(instigatorEntityId == num.GetValueOrDefault() & num != null))
			{
				this.Instigator = base.InstigatorEntity;
				Entity ownerEntity2 = base.OwnerEntity;
				this.OwnerCueComp = ((ownerEntity2 != null) ? ownerEntity2.GetComponent<BaseGameplayCueComponent>() : null);
				EntityHandle instigator = this.Instigator;
				BaseGameplayCueComponent instigatorCueComp;
				if (instigator == null)
				{
					instigatorCueComp = null;
				}
				else
				{
					WorldEntity entity = instigator.Entity;
					instigatorCueComp = ((entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null);
				}
				this.InstigatorCueComp = instigatorCueComp;
				if (this.InstigatorCueComp != null && this.OwnerCueComp != null)
				{
					this.SyncCueOnCreated(this.InstigatorCueComp);
				}
				EventSystem.Instance.AddWithTarget<bool, long>(this.Instigator, EEventName.CharGameplayCueChanged, new Action<bool, long>(this.OnCharGameplayCueChanged));
				return;
			}
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity ownerEntity3 = base.OwnerEntity;
		string message = "SyncGameplayCue效果的双方不能是同一人";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Buff", this.BuffId);
		instance.Error(flag, ownerEntity3, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06017679 RID: 95865 RVA: 0x006E4DA5 File Offset: 0x006E2FA5
	public override void OnRemoved(bool bPremature)
	{
		if (this.Instigator == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<bool, long>(this.Instigator, EEventName.CharGameplayCueChanged, new Action<bool, long>(this.OnCharGameplayCueChanged));
	}

	// Token: 0x0601767A RID: 95866 RVA: 0x006E4DCF File Offset: 0x006E2FCF
	private void OnCharGameplayCueChanged(bool enable, long cueId)
	{
		if (!this.ShouldSyncCue(cueId))
		{
			return;
		}
		if (enable)
		{
			this.AddCue(cueId, true);
			return;
		}
		this.RemoveCue(cueId);
	}

	// Token: 0x0601767B RID: 95867 RVA: 0x006E4DF0 File Offset: 0x006E2FF0
	private void SyncCueOnCreated(BaseGameplayCueComponent instigatorCueComp)
	{
		BaseGameplayCueComponent ownerCueComp = this.OwnerCueComp;
		if (ownerCueComp == null)
		{
			return;
		}
		HashSet<long> hashSet = new HashSet<long>();
		foreach (GameplayCueBase gameplayCueBase in instigatorCueComp.GetAllCurrentCueRef())
		{
			hashSet.Add(gameplayCueBase.CueConfig.Id);
		}
		HashSet<long> hashSet2 = new HashSet<long>();
		foreach (GameplayCueBase gameplayCueBase2 in ownerCueComp.GetAllCurrentCueRef())
		{
			hashSet2.Add(gameplayCueBase2.CueConfig.Id);
		}
		foreach (long num in hashSet)
		{
			if (this.ShouldSyncCue(num))
			{
				if (!hashSet2.Contains(num))
				{
					this.AddCue(num, true);
				}
				else
				{
					this.SyncMagnitudeIfNeeded(num);
				}
			}
		}
		foreach (long num2 in hashSet2)
		{
			if (!hashSet.Contains(num2) || !this.ShouldSyncCue(num2))
			{
				this.RemoveCue(num2);
			}
		}
	}

	// Token: 0x0601767C RID: 95868 RVA: 0x006E4F60 File Offset: 0x006E3160
	private void AddCue(long cueId, bool bSyncMagnitude)
	{
		BaseGameplayCueComponent ownerCueComp = this.OwnerCueComp;
		if (ownerCueComp != null)
		{
			ownerCueComp.AddCue(cueId, null);
		}
		if (bSyncMagnitude)
		{
			this.SyncMagnitudeIfNeeded(cueId);
		}
	}

	// Token: 0x0601767D RID: 95869 RVA: 0x006E4F93 File Offset: 0x006E3193
	private void RemoveCue(long cueId)
	{
		BaseGameplayCueComponent ownerCueComp = this.OwnerCueComp;
		if (ownerCueComp == null)
		{
			return;
		}
		ownerCueComp.RemoveCue(cueId);
	}

	// Token: 0x0601767E RID: 95870 RVA: 0x006E4FA8 File Offset: 0x006E31A8
	private void SyncMagnitudeIfNeeded(long cueId)
	{
		if (this.OwnerCueComp == null || this.InstigatorCueComp == null)
		{
			return;
		}
		GameplayCueBase cueByCueId = this.OwnerCueComp.GetCueByCueId(cueId);
		GameplayCueBase cueByCueId2 = this.InstigatorCueComp.GetCueByCueId(cueId);
		GameplayCueMagnitude gameplayCueMagnitude = cueByCueId as GameplayCueMagnitude;
		if (gameplayCueMagnitude != null)
		{
			GameplayCueMagnitude gameplayCueMagnitude2 = cueByCueId2 as GameplayCueMagnitude;
			if (gameplayCueMagnitude2 != null)
			{
				gameplayCueMagnitude.SyncMagnitude(gameplayCueMagnitude2);
			}
		}
	}

	// Token: 0x0601767F RID: 95871 RVA: 0x006E4FFC File Offset: 0x006E31FC
	private bool ShouldSyncCue(long cueId)
	{
		if (this.SyncCueIds.Length == 0)
		{
			return false;
		}
		for (int i = 0; i < this.SyncCueIds.Length; i++)
		{
			if (this.SyncCueIds[i] == cueId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06017680 RID: 95872 RVA: 0x006E5035 File Offset: 0x006E3235
	public SyncGameplayCue(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0400C6C8 RID: 50888
	[Nullable(2)]
	private EntityHandle Instigator;

	// Token: 0x0400C6C9 RID: 50889
	[Nullable(2)]
	private BaseGameplayCueComponent OwnerCueComp;

	// Token: 0x0400C6CA RID: 50890
	[Nullable(2)]
	private BaseGameplayCueComponent InstigatorCueComp;

	// Token: 0x0400C6CB RID: 50891
	private long[] SyncCueIds = Array.Empty<long>();
}
