using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020023D4 RID: 9172
[NullableContext(2)]
public interface IBuffComponent
{
	// Token: 0x0601705A RID: 94298
	[NullableContext(1)]
	void AddBuff(long buffId, AddBuffParam buffParams);

	// Token: 0x0601705B RID: 94299
	[NullableContext(1)]
	int AddBuffLocal(long buffId, AddBuffParam buffParams);

	// Token: 0x0601705C RID: 94300
	bool HasBuff(long buffId, bool excludeRequestRemove = false);

	// Token: 0x0601705D RID: 94301
	void AddIterativeBuff(long buffId, IActiveBuff preBuff, int? stackCount, bool isIterable, [Nullable(1)] string reason, long? bulletMessageId = null, IBuffComponent instigator = null);

	// Token: 0x0601705E RID: 94302
	[NullableContext(1)]
	void RemoveBuff(long buffId, int stackCount, string reason, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null);

	// Token: 0x0601705F RID: 94303
	int RemoveBuffByHandle(int handle, int removeStackCount = -1, string reason = null, long? preMessageId = null, bool? isServerRequest = null, long? instigatorId = null);

	// Token: 0x06017060 RID: 94304
	[NullableContext(1)]
	void RemoveBuffWhenTimeout(ActiveBuffInternal buff);

	// Token: 0x06017061 RID: 94305
	int? GetBuffLevel(long buffId);

	// Token: 0x06017062 RID: 94306
	int GetBuffTotalStackById(long buffId, bool onlyActiveBuff = false);

	// Token: 0x06017063 RID: 94307
	[NullableContext(1)]
	string GetDebugName();

	// Token: 0x170023AA RID: 9130
	// (get) Token: 0x06017064 RID: 94308
	bool Valid { get; }

	// Token: 0x170023AB RID: 9131
	// (get) Token: 0x06017065 RID: 94309
	ExtraEffectManager BuffEffectManager { get; }

	// Token: 0x06017066 RID: 94310
	Entity GetEntity();

	// Token: 0x06017067 RID: 94311
	Entity GetExactEntity();

	// Token: 0x06017068 RID: 94312
	BaseAttributeComponent GetAttributeComponent();

	// Token: 0x06017069 RID: 94313
	BaseTagComponent GetTagComponent();

	// Token: 0x0601706A RID: 94314
	BaseSkillComponent GetSkillComponent();

	// Token: 0x0601706B RID: 94315
	CharacterPassiveSkillComponent GetPassiveSkillComponent();

	// Token: 0x0601706C RID: 94316
	BaseActorComponent GetActorComponent();

	// Token: 0x0601706D RID: 94317
	ActiveBuffInternal GetBuffById(long buffId);

	// Token: 0x0601706E RID: 94318
	IActiveBuff GetBuffByHandle(int handleId);

	// Token: 0x0601706F RID: 94319
	IActiveBuff GetPendingBuffByHandle(int handleId);

	// Token: 0x06017070 RID: 94320
	bool HasBuffAuthority();

	// Token: 0x06017071 RID: 94321
	void RemoveTrigger(int handleId, EBuffTriggerType extraEffectType);

	// Token: 0x06017072 RID: 94322
	void SetBuffEffectCd(long buffId, int index, float remainCd);

	// Token: 0x06017073 RID: 94323
	void SetBuffEffectCdForTarget(long buffId, int index, int targetEntityId, float remainCd);

	// Token: 0x06017074 RID: 94324
	double GetBuffEffectCd(long buffId, int index);

	// Token: 0x06017075 RID: 94325
	[NullableContext(1)]
	string GetTargetCdDebugStr(long buffId, int index);

	// Token: 0x06017076 RID: 94326
	double GetBuffEffectCdForTarget(long buffId, int index, int targetEntityId);

	// Token: 0x06017077 RID: 94327
	[NullableContext(1)]
	void ApplyPeriodExecution(ActiveBuffInternal buff);

	// Token: 0x06017078 RID: 94328
	void AddBuffStackModifier(long targetBuffId, int handle, int value, EBuffStackModifierType modifierType);

	// Token: 0x06017079 RID: 94329
	int? CalculateBuffStackMax(long buffId);

	// Token: 0x0601707A RID: 94330
	void RemoveBuffStackModifier(long targetBuffId, int handle);

	// Token: 0x0601707B RID: 94331
	void AddBuffRoutineExpirationLock(long buffId);

	// Token: 0x0601707C RID: 94332
	void RemoveBuffRoutineExpirationLock(long buffId);

	// Token: 0x0601707D RID: 94333
	void AddBuffTimeModifier(long targetBuffId, int handle, float period, float duration, bool asInstigator);

	// Token: 0x0601707E RID: 94334
	void RemoveBuffTimeModifier(long targetBuffId, int handle, bool asInstigator);

	// Token: 0x0601707F RID: 94335
	[NullableContext(1)]
	void ChangeBuffStack(long buffId, EBuffStackDurationOverride StackDurationRefreshPolicy, EBuffStackPeriodResetOverride StackPeriodResetPolicy, int stackChange, string reason, long? instigatorId = null);

	// Token: 0x06017080 RID: 94336
	[NullableContext(1)]
	HashSet<int> GetBuffHandleByEffectId(int effectId);

	// Token: 0x06017081 RID: 94337
	[NullableContext(1)]
	IEnumerable<ActiveBuffInternal> GetAllBuffById(long buffId);

	// Token: 0x06017082 RID: 94338
	float GetLogicTimeScale();

	// Token: 0x06017083 RID: 94339
	[NullableContext(1)]
	IActiveBuff[] GetAllBuffs();

	// Token: 0x06017084 RID: 94340
	[NullableContext(1)]
	bool AddReplaceBuff(long originBuffId, BuffReplace replaceBuffInfo);

	// Token: 0x06017085 RID: 94341
	bool RemoveReplaceBuff(long originBuffId);
}
