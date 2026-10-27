using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002E76 RID: 11894
[NullableContext(1)]
[Nullable(0)]
public class BaseFrozenComponent : EntityComponent
{
	// Token: 0x060196BF RID: 104127 RVA: 0x0068FD51 File Offset: 0x0068DF51
	protected override bool OnStart()
	{
		this.ActorComponent = base.Entity.GetComponent<CharacterActorComponent>();
		this.HitComponent = base.Entity.GetComponent<CharacterHitComponent>();
		this.TimeScaleComponent = base.Entity.CheckGetComponent<PawnTimeScaleComponent>();
		this.AddListenTasks();
		return true;
	}

	// Token: 0x060196C0 RID: 104128 RVA: 0x0068FD8D File Offset: 0x0068DF8D
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

	// Token: 0x060196C1 RID: 104129 RVA: 0x0068FDC4 File Offset: 0x0068DFC4
	protected override bool OnClear()
	{
		this.FrozenLockSet.Clear();
		return true;
	}

	// Token: 0x060196C2 RID: 104130 RVA: 0x0068FDD4 File Offset: 0x0068DFD4
	private void AddListenTasks()
	{
		BaseTagComponent baseTagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
		this.StunnedTagListenTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["Damage.Stunned"]), new BaseTagComponent.TTagSwitchedCallback(this.StunnedTagListenTaskCallback), null);
	}

	// Token: 0x060196C3 RID: 104131 RVA: 0x0068FE1A File Offset: 0x0068E01A
	private void StunnedTagListenTaskCallback(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.ActorComponent.Actor.StopAnimMontage(null);
		}
	}

	// Token: 0x060196C4 RID: 104132 RVA: 0x0068FE30 File Offset: 0x0068E030
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

	// Token: 0x060196C5 RID: 104133 RVA: 0x0068FE8C File Offset: 0x0068E08C
	public void RemoveTimeScaleByBuff(int handleId)
	{
		int id;
		if (this.BuffTimeScaleMap.TryGetValue(handleId, out id))
		{
			this.TimeScaleComponent.RemoveTimeScale(id);
		}
		this.BuffTimeScaleMap.Remove(handleId);
	}

	// Token: 0x060196C6 RID: 104134 RVA: 0x0068FEC4 File Offset: 0x0068E0C4
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

	// Token: 0x060196C7 RID: 104135 RVA: 0x0068FF94 File Offset: 0x0068E194
	public void RemoveForeverTimeScale(int handleId)
	{
		int id;
		if (this.ForeverTimeScaleMap.TryGetValue(handleId, out id))
		{
			this.TimeScaleComponent.RemoveForeverTimeScale(id, false);
			this.ForeverTimeScaleMap.Remove(handleId);
		}
	}

	// Token: 0x060196C8 RID: 104136 RVA: 0x0068FFCC File Offset: 0x0068E1CC
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

	// Token: 0x060196C9 RID: 104137 RVA: 0x0069003D File Offset: 0x0068E23D
	public virtual bool IsFrozen()
	{
		return false;
	}

	// Token: 0x060196CA RID: 104138 RVA: 0x00690040 File Offset: 0x0068E240
	protected virtual void SetFrozen(bool bFrozen)
	{
	}

	// Token: 0x060196CB RID: 104139 RVA: 0x00690044 File Offset: 0x0068E244
	protected virtual void RefreshFrozen()
	{
		bool flag = this.FrozenLockSet.Count > 0;
		this.SetFrozen(flag);
		EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.CharAfterFrozenChange, flag);
	}

	// Token: 0x060196CC RID: 104140 RVA: 0x0069007B File Offset: 0x0068E27B
	public void LockFrozen(string lockName)
	{
		if (this.FrozenLockSet.Contains(lockName))
		{
			return;
		}
		this.FrozenLockSet.Add(lockName);
		this.RefreshFrozen();
	}

	// Token: 0x060196CD RID: 104141 RVA: 0x0069009F File Offset: 0x0068E29F
	public void UnlockFrozen(string lockName)
	{
		if (!this.FrozenLockSet.Remove(lockName))
		{
			return;
		}
		this.RefreshFrozen();
	}

	// Token: 0x060196CE RID: 104142 RVA: 0x006900B8 File Offset: 0x0068E2B8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseFrozenComponent baseFrozenComponent = (BaseFrozenComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComponent"))
		{
			if (baseFrozenComponent.ActorComponent == null)
			{
				this.ActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComponent), "ActorComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HitComponent"))
		{
			if (baseFrozenComponent.HitComponent == null)
			{
				this.HitComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterHitComponent>(this.HitComponent), "HitComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TimeScaleComponent"))
		{
			if (baseFrozenComponent.TimeScaleComponent == null)
			{
				this.TimeScaleComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComponent), "TimeScaleComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("StunnedTagListenTask"))
		{
			if (baseFrozenComponent.StunnedTagListenTask == null)
			{
				this.StunnedTagListenTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.StunnedTagListenTask), "StunnedTagListenTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FrozenTagListenTask"))
		{
			if (baseFrozenComponent.FrozenTagListenTask == null)
			{
				this.FrozenTagListenTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.FrozenTagListenTask), "FrozenTagListenTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BuffTimeScaleMap") && baseFrozenComponent.BuffTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.BuffTimeScaleMap), "BuffTimeScaleMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ForeverTimeScaleMap") && baseFrozenComponent.ForeverTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.ForeverTimeScaleMap), "ForeverTimeScaleMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("BaseBuffForeverTimeScale"))
		{
			this.BaseBuffForeverTimeScale = baseFrozenComponent.BaseBuffForeverTimeScale;
		}
		if (base.CanResetComponentProperty("BaseBuffTimeScaleHandle"))
		{
			this.BaseBuffTimeScaleHandle = baseFrozenComponent.BaseBuffTimeScaleHandle;
		}
		if (base.CanResetComponentProperty("FrozenLockSet"))
		{
			if (baseFrozenComponent.FrozenLockSet == null)
			{
				this.FrozenLockSet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.FrozenLockSet), "FrozenLockSet"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400BCE5 RID: 48357
	[Nullable(2)]
	protected CharacterActorComponent ActorComponent;

	// Token: 0x0400BCE6 RID: 48358
	[Nullable(2)]
	private CharacterHitComponent HitComponent;

	// Token: 0x0400BCE7 RID: 48359
	[Nullable(2)]
	private PawnTimeScaleComponent TimeScaleComponent;

	// Token: 0x0400BCE8 RID: 48360
	[Nullable(2)]
	private ITagTask StunnedTagListenTask;

	// Token: 0x0400BCE9 RID: 48361
	[Nullable(2)]
	private ITagTask FrozenTagListenTask;

	// Token: 0x0400BCEA RID: 48362
	private readonly Dictionary<int, int> BuffTimeScaleMap = new Dictionary<int, int>();

	// Token: 0x0400BCEB RID: 48363
	private readonly Dictionary<int, int> ForeverTimeScaleMap = new Dictionary<int, int>();

	// Token: 0x0400BCEC RID: 48364
	private float BaseBuffForeverTimeScale;

	// Token: 0x0400BCED RID: 48365
	private int BaseBuffTimeScaleHandle;

	// Token: 0x0400BCEE RID: 48366
	protected HashSet<string> FrozenLockSet = new HashSet<string>();
}
