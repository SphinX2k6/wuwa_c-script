using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020023C8 RID: 9160
[NullableContext(1)]
[Nullable(0)]
public class BaseFrozenComponent : EntityComponent
{
	// Token: 0x06016F8C RID: 94092 RVA: 0x006B61C0 File Offset: 0x006B43C0
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.HitComponent = base.Entity.GetComponent<CharacterHitComponent>();
		this.TimeScaleComponent = base.Entity.CheckGetComponent<PawnTimeScaleComponent>();
		this.AddListenTasks();
		return true;
	}

	// Token: 0x06016F8D RID: 94093 RVA: 0x006B61FC File Offset: 0x006B43FC
	protected override bool OnEnd()
	{
		if (this.StunnedTagListenTask != null)
		{
			this.StunnedTagListenTask.EndTask();
			this.StunnedTagListenTask = null;
		}
		if (this.FrozenTagListenTask != null)
		{
			this.FrozenTagListenTask.EndTask();
			this.FrozenTagListenTask = null;
		}
		return true;
	}

	// Token: 0x06016F8E RID: 94094 RVA: 0x006B6233 File Offset: 0x006B4433
	protected override bool OnClear()
	{
		this.FrozenLockSet.Clear();
		return true;
	}

	// Token: 0x06016F8F RID: 94095 RVA: 0x006B6244 File Offset: 0x006B4444
	private void AddListenTasks()
	{
		BaseTagComponent baseTagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.StunnedTagListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["Damage.Stunned"]), new BaseTagComponent.TTagSwitchedCallback(this.StunnedTagListenTaskCallback), null);
	}

	// Token: 0x06016F90 RID: 94096 RVA: 0x006B628A File Offset: 0x006B448A
	private void StunnedTagListenTaskCallback(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.ActorComponent.Actor.StopAnimMontage(null);
		}
	}

	// Token: 0x06016F91 RID: 94097 RVA: 0x006B62A0 File Offset: 0x006B44A0
	[NullableContext(2)]
	public void AddTimeScaleByBuff(int handleId, int priority, double timeDilation, double? duration, UCurveFloat curve)
	{
		if (this.BuffTimeScaleMap.ContainsKey(handleId))
		{
			return;
		}
		if (this.HitComponent.IsImmuneTimeScaleEffect())
		{
			return;
		}
		int value = this.TimeScaleComponent.SetTimeScale(priority, (float)timeDilation, curve, (float)duration.GetValueOrDefault(10000000.0), ETimeScaleSourceType.Buff, false, false);
		this.BuffTimeScaleMap[handleId] = value;
	}

	// Token: 0x06016F92 RID: 94098 RVA: 0x006B62FC File Offset: 0x006B44FC
	public void RemoveTimeScaleByBuff(int handleId)
	{
		int id;
		if (this.BuffTimeScaleMap.TryGetValue(handleId, out id))
		{
			this.TimeScaleComponent.RemoveTimeScale(id);
		}
		this.BuffTimeScaleMap.Remove(handleId);
	}

	// Token: 0x06016F93 RID: 94099 RVA: 0x006B6334 File Offset: 0x006B4534
	public unsafe void SetForeverTimeScale(int handleId, int priority, float timeDilation)
	{
		this.RemoveForeverTimeScale(handleId);
		float num = timeDilation + this.BaseBuffForeverTimeScale;
		if (num < 0f)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = base.Entity;
			string message = "buff额外效果83设置时间碰撞系数小于0,强制设置为0";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffHandleId", handleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("timeDilation", timeDilation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BaseBuffForeverTimeScale", this.BaseBuffForeverTimeScale);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			num = 0f;
		}
		int value = this.TimeScaleComponent.SetForeverTimeScale(ETimeScaleSourceType.Buff, num, priority, false);
		this.ForeverTimeScaleMap[handleId] = value;
	}

	// Token: 0x06016F94 RID: 94100 RVA: 0x006B6404 File Offset: 0x006B4604
	public void RemoveForeverTimeScale(int handleId)
	{
		int id;
		if (this.ForeverTimeScaleMap.TryGetValue(handleId, out id))
		{
			this.TimeScaleComponent.RemoveForeverTimeScale(id, false);
			this.ForeverTimeScaleMap.Remove(handleId);
		}
	}

	// Token: 0x06016F95 RID: 94101 RVA: 0x006B643C File Offset: 0x006B463C
	public void SetBuffBaseForeverTimeScale(float baseBuffTimeScale)
	{
		if (MathUtils.Instance.IsNearlyEqual((double)this.BaseBuffForeverTimeScale, (double)baseBuffTimeScale, null))
		{
			return;
		}
		this.BaseBuffForeverTimeScale = baseBuffTimeScale;
		if (this.BaseBuffTimeScaleHandle != 0)
		{
			this.TimeScaleComponent.RemoveForeverTimeScale(this.BaseBuffTimeScaleHandle, false);
			this.BaseBuffTimeScaleHandle = 0;
		}
		if (baseBuffTimeScale > 0f)
		{
			this.BaseBuffTimeScaleHandle = this.TimeScaleComponent.SetForeverTimeScale(ETimeScaleSourceType.Buff, baseBuffTimeScale, 0, false);
		}
	}

	// Token: 0x06016F96 RID: 94102 RVA: 0x006B64AD File Offset: 0x006B46AD
	public virtual bool IsFrozen()
	{
		return false;
	}

	// Token: 0x06016F97 RID: 94103 RVA: 0x006B64B0 File Offset: 0x006B46B0
	protected virtual void SetFrozen(bool bFrozen)
	{
	}

	// Token: 0x06016F98 RID: 94104 RVA: 0x006B64B4 File Offset: 0x006B46B4
	protected virtual void RefreshFrozen()
	{
		bool flag = this.FrozenLockSet.Count > 0;
		this.SetFrozen(flag);
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.CharAfterFrozenChange, flag);
	}

	// Token: 0x06016F99 RID: 94105 RVA: 0x006B64EB File Offset: 0x006B46EB
	public void LockFrozen(string lockName)
	{
		if (this.FrozenLockSet.Contains(lockName))
		{
			return;
		}
		this.FrozenLockSet.Add(lockName);
		this.RefreshFrozen();
	}

	// Token: 0x06016F9A RID: 94106 RVA: 0x006B650F File Offset: 0x006B470F
	public void UnlockFrozen(string lockName)
	{
		if (!this.FrozenLockSet.Remove(lockName))
		{
			return;
		}
		this.RefreshFrozen();
	}

	// Token: 0x06016F9B RID: 94107 RVA: 0x006B6528 File Offset: 0x006B4728
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseFrozenComponent baseFrozenComponent = (BaseFrozenComponent)componentTemplate;
		if (baseFrozenComponent.ActorComponent == null)
		{
			this.ActorComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComponent), "ActorComponent"))
		{
			return false;
		}
		if (baseFrozenComponent.HitComponent == null)
		{
			this.HitComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComponent), "HitComponent"))
		{
			return false;
		}
		if (baseFrozenComponent.TimeScaleComponent == null)
		{
			this.TimeScaleComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComponent), "TimeScaleComponent"))
		{
			return false;
		}
		if (baseFrozenComponent.StunnedTagListenTask == null)
		{
			this.StunnedTagListenTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StunnedTagListenTask), "StunnedTagListenTask"))
		{
			return false;
		}
		if (baseFrozenComponent.FrozenTagListenTask == null)
		{
			this.FrozenTagListenTask = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FrozenTagListenTask), "FrozenTagListenTask"))
		{
			return false;
		}
		if (baseFrozenComponent.BuffTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffTimeScaleMap), "BuffTimeScaleMap"))
		{
			return false;
		}
		if (baseFrozenComponent.ForeverTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForeverTimeScaleMap), "ForeverTimeScaleMap"))
		{
			return false;
		}
		this.BaseBuffForeverTimeScale = baseFrozenComponent.BaseBuffForeverTimeScale;
		this.BaseBuffTimeScaleHandle = baseFrozenComponent.BaseBuffTimeScaleHandle;
		if (baseFrozenComponent.FrozenLockSet == null)
		{
			this.FrozenLockSet = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.FrozenLockSet), "FrozenLockSet"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002376 RID: 9078
	// (get) Token: 0x06016F9C RID: 94108 RVA: 0x006B66A6 File Offset: 0x006B48A6
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002377 RID: 9079
	// (get) Token: 0x06016F9D RID: 94109 RVA: 0x006B66A9 File Offset: 0x006B48A9
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002378 RID: 9080
	// (get) Token: 0x06016F9E RID: 94110 RVA: 0x006B66AC File Offset: 0x006B48AC
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C07B RID: 49275
	[Nullable(2)]
	protected CharacterActorComponent ActorComponent;

	// Token: 0x0400C07C RID: 49276
	[Nullable(2)]
	private CharacterHitComponent HitComponent;

	// Token: 0x0400C07D RID: 49277
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400C07E RID: 49278
	[Nullable(2)]
	private ITagTask StunnedTagListenTask;

	// Token: 0x0400C07F RID: 49279
	[Nullable(2)]
	private ITagTask FrozenTagListenTask;

	// Token: 0x0400C080 RID: 49280
	private readonly Dictionary<int, int> BuffTimeScaleMap = new Dictionary<int, int>();

	// Token: 0x0400C081 RID: 49281
	private readonly Dictionary<int, int> ForeverTimeScaleMap = new Dictionary<int, int>();

	// Token: 0x0400C082 RID: 49282
	private float BaseBuffForeverTimeScale;

	// Token: 0x0400C083 RID: 49283
	private int BaseBuffTimeScaleHandle;

	// Token: 0x0400C084 RID: 49284
	protected HashSet<string> FrozenLockSet = new HashSet<string>();
}
