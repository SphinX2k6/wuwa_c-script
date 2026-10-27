using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002E82 RID: 11906
[NullableContext(2)]
public interface IBuffComponent
{
	// Token: 0x06019784 RID: 104324
	[NullableContext(1)]
	void AddBuff(long buffId, AddBuffParam buffParams);

	// Token: 0x06019785 RID: 104325
	[NullableContext(1)]
	int AddBuffLocal(long buffId, AddBuffParam buffParams);

	// Token: 0x06019786 RID: 104326
	bool HasBuff(long buffId, bool excludeRequestRemove = false);

	// Token: 0x06019787 RID: 104327
	void AddIterativeBuff(long buffId, IActiveBuff preBuff, int? stackCount, bool isIterable, [Nullable(1)] string reason, long? bulletMessageId = null, IBuffComponent instigator = null);

	// Token: 0x06019788 RID: 104328
	[NullableContext(1)]
	void RemoveBuff(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null);

	// Token: 0x06019789 RID: 104329
	int RemoveBuffByHandle(int handle, int removeStackCount = -1, string reason = null, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null);

	// Token: 0x0601978A RID: 104330
	[NullableContext(1)]
	void RemoveBuffWhenTimeout(ActiveBuffInternal buff);

	// Token: 0x0601978B RID: 104331
	int? GetBuffLevel(long buffId);

	// Token: 0x0601978C RID: 104332
	int GetBuffTotalStackById(long buffId, bool onlyActiveBuff = false);

	// Token: 0x0601978D RID: 104333
	[NullableContext(1)]
	string GetDebugName();

	// Token: 0x1700231F RID: 8991
	// (get) Token: 0x0601978E RID: 104334
	bool Valid { get; }

	// Token: 0x17002320 RID: 8992
	// (get) Token: 0x0601978F RID: 104335
	ExtraEffectManager BuffEffectManager { get; }

	// Token: 0x06019790 RID: 104336
	Entity GetEntity();

	// Token: 0x06019791 RID: 104337
	Entity GetExactEntity();

	// Token: 0x06019792 RID: 104338
	BaseAttributeComponent GetAttributeComponent();

	// Token: 0x06019793 RID: 104339
	BaseTagComponent GetTagComponent();

	// Token: 0x06019794 RID: 104340
	BaseSkillComponent GetSkillComponent();

	// Token: 0x06019795 RID: 104341
	CharacterPassiveSkillComponent GetPassiveSkillComponent();

	// Token: 0x06019796 RID: 104342
	BaseActorComponent GetActorComponent();

	// Token: 0x06019797 RID: 104343
	ActiveBuffInternal GetBuffById(long buffId);

	// Token: 0x06019798 RID: 104344
	IActiveBuff GetBuffByHandle(int handleId);

	// Token: 0x06019799 RID: 104345
	IActiveBuff GetPendingBuffByHandle(int handleId);

	// Token: 0x0601979A RID: 104346
	bool HasBuffAuthority();

	// Token: 0x0601979B RID: 104347
	void RemoveTrigger(int handleId, EBuffTriggerType extraEffectType);

	// Token: 0x0601979C RID: 104348
	void SetBuffEffectCd(long buffId, int index, float remainCd);

	// Token: 0x0601979D RID: 104349
	void SetBuffEffectCdForTarget(long buffId, int index, int targetEntityId, float remainCd);

	// Token: 0x0601979E RID: 104350
	double GetBuffEffectCd(long buffId, int index);

	// Token: 0x0601979F RID: 104351
	[NullableContext(1)]
	string GetTargetCdDebugStr(long buffId, int index);

	// Token: 0x060197A0 RID: 104352
	double GetBuffEffectCdForTarget(long buffId, int index, int targetEntityId);

	// Token: 0x060197A1 RID: 104353
	[NullableContext(1)]
	void ApplyPeriodExecution(ActiveBuffInternal buff);

	// Token: 0x060197A2 RID: 104354
	void AddBuffStackModifier(long targetBuffId, int handle, int value, EBuffStackModifierType modifierType);

	// Token: 0x060197A3 RID: 104355
	int? CalculateBuffStackMax(long buffId);

	// Token: 0x060197A4 RID: 104356
	void RemoveBuffStackModifier(long targetBuffId, int handle);

	// Token: 0x060197A5 RID: 104357
	void AddBuffRoutineExpirationLock(long buffId);

	// Token: 0x060197A6 RID: 104358
	void RemoveBuffRoutineExpirationLock(long buffId);

	// Token: 0x060197A7 RID: 104359
	void AddBuffTimeModifier(long targetBuffId, int handle, float period, float duration, bool asInstigator);

	// Token: 0x060197A8 RID: 104360
	void RemoveBuffTimeModifier(long targetBuffId, int handle, bool asInstigator);

	// Token: 0x060197A9 RID: 104361
	[NullableContext(1)]
	void ChangeBuffStack(long buffId, EBuffStackDurationOverride StackDurationRefreshPolicy, EBuffStackPeriodResetOverride StackPeriodResetPolicy, int stackChange, string reason, long? instigatorId = null);

	// Token: 0x060197AA RID: 104362
	[NullableContext(1)]
	HashSet<int> GetBuffHandleByEffectId(int effectId);

	// Token: 0x060197AB RID: 104363
	[NullableContext(1)]
	IEnumerable<ActiveBuffInternal> GetAllBuffById(long buffId);

	// Token: 0x060197AC RID: 104364
	float GetLogicTimeScale();

	// Token: 0x060197AD RID: 104365
	[NullableContext(1)]
	IActiveBuff[] GetAllBuffs();

	// Token: 0x060197AE RID: 104366
	[NullableContext(1)]
	bool AddReplaceBuff(long originBuffId, BuffReplace replaceBuffInfo);

	// Token: 0x060197AF RID: 104367
	bool RemoveReplaceBuff(long originBuffId);
}
