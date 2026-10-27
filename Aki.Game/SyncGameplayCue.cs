using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F81 RID: 12161
[NullableContext(1)]
[Nullable(0)]
public class SyncGameplayCue : BuffEffect
{
	// Token: 0x06019D64 RID: 105828 RVA: 0x006BE343 File Offset: 0x006BC543
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019D65 RID: 105829 RVA: 0x006BE348 File Offset: 0x006BC548
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

	// Token: 0x06019D66 RID: 105830 RVA: 0x006BE398 File Offset: 0x006BC598
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

	// Token: 0x06019D67 RID: 105831 RVA: 0x006BE4AD File Offset: 0x006BC6AD
	public override void OnRemoved(bool bPremature)
	{
		if (this.Instigator == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<bool, long>(this.Instigator, EEventName.CharGameplayCueChanged, new Action<bool, long>(this.OnCharGameplayCueChanged));
	}

	// Token: 0x06019D68 RID: 105832 RVA: 0x006BE4D7 File Offset: 0x006BC6D7
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

	// Token: 0x06019D69 RID: 105833 RVA: 0x006BE4F8 File Offset: 0x006BC6F8
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

	// Token: 0x06019D6A RID: 105834 RVA: 0x006BE668 File Offset: 0x006BC868
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

	// Token: 0x06019D6B RID: 105835 RVA: 0x006BE69B File Offset: 0x006BC89B
	private void RemoveCue(long cueId)
	{
		BaseGameplayCueComponent ownerCueComp = this.OwnerCueComp;
		if (ownerCueComp == null)
		{
			return;
		}
		ownerCueComp.RemoveCue(cueId);
	}

	// Token: 0x06019D6C RID: 105836 RVA: 0x006BE6B0 File Offset: 0x006BC8B0
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

	// Token: 0x06019D6D RID: 105837 RVA: 0x006BE704 File Offset: 0x006BC904
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

	// Token: 0x06019D6E RID: 105838 RVA: 0x006BE73D File Offset: 0x006BC93D
	public SyncGameplayCue(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0400C31F RID: 49951
	[Nullable(2)]
	private EntityHandle Instigator;

	// Token: 0x0400C320 RID: 49952
	[Nullable(2)]
	private BaseGameplayCueComponent OwnerCueComp;

	// Token: 0x0400C321 RID: 49953
	[Nullable(2)]
	private BaseGameplayCueComponent InstigatorCueComp;

	// Token: 0x0400C322 RID: 49954
	private long[] SyncCueIds = Array.Empty<long>();
}
