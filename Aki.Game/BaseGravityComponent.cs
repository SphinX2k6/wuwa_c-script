using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02003028 RID: 12328
[NullableContext(1)]
[Nullable(0)]
public class BaseGravityComponent : EntityComponent
{
	// Token: 0x0601A1F2 RID: 106994 RVA: 0x006DB740 File Offset: 0x006D9940
	protected override bool OnStart()
	{
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		if (this.MoveComp == null)
		{
			Log.Instance.Error(ELogModule.Movement, ELogAuthor.YZ, "[BaseGravityComponent] BaseMoveComponent not found", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		this.InitGravityDirect();
		return true;
	}

	// Token: 0x0601A1F3 RID: 106995 RVA: 0x006DB788 File Offset: 0x006D9988
	protected override bool OnEnd()
	{
		this.GravitySlots.Clear();
		this.ActivePriority = null;
		return true;
	}

	// Token: 0x0601A1F4 RID: 106996 RVA: 0x006DB7A4 File Offset: 0x006D99A4
	protected void InitGravityDirect()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		Aki.Protocol.Vector initGravityDirection = component.GetInitGravityDirection();
		if (initGravityDirection != null)
		{
			this.SetDefaultGravityDirect(global::Vector.Create(initGravityDirection));
		}
	}

	// Token: 0x0601A1F5 RID: 106997 RVA: 0x006DB7D7 File Offset: 0x006D99D7
	public void SetDefaultGravityDirect(IVector v)
	{
		this.DefaultGravityDirect.Set(v.X, v.Y, v.Z);
		if (this.ActivePriority == null)
		{
			this.ApplyGravityToMoveComp(this.DefaultGravityDirect, true, -1f, true);
		}
	}

	// Token: 0x0601A1F6 RID: 106998 RVA: 0x006DB818 File Offset: 0x006D9A18
	public void SetGravityByPriority(int priority, IVector direction, bool clearGround = true, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		if (!this.GravitySlots.TryGetValue(priority, out gravitySlot))
		{
			gravitySlot = new BaseGravityComponent.GravitySlot();
			this.GravitySlots[priority] = gravitySlot;
		}
		gravitySlot.Direction.Set(direction.X, direction.Y, direction.Z);
		gravitySlot.Active = true;
		this.EvaluateAndApply(clearGround, overrideSmoothTime, withoutRotate);
	}

	// Token: 0x0601A1F7 RID: 106999 RVA: 0x006DB878 File Offset: 0x006D9A78
	public void StopGravityByPriority(int priority, bool clearGround = true, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		if (!this.GravitySlots.TryGetValue(priority, out gravitySlot) || !gravitySlot.Active)
		{
			return;
		}
		gravitySlot.Active = false;
		this.EvaluateAndApply(clearGround, overrideSmoothTime, withoutRotate);
	}

	// Token: 0x0601A1F8 RID: 107000 RVA: 0x006DB8AF File Offset: 0x006D9AAF
	public global::Vector GetDefaultGravityDirect()
	{
		return this.DefaultGravityDirect;
	}

	// Token: 0x0601A1F9 RID: 107001 RVA: 0x006DB8B8 File Offset: 0x006D9AB8
	public global::Vector GetActiveGravityDirect()
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		if (this.ActivePriority != null && this.GravitySlots.TryGetValue(this.ActivePriority.Value, out gravitySlot) && gravitySlot.Active)
		{
			return gravitySlot.Direction;
		}
		return this.DefaultGravityDirect;
	}

	// Token: 0x0601A1FA RID: 107002 RVA: 0x006DB901 File Offset: 0x006D9B01
	public int? GetActivePriority()
	{
		return this.ActivePriority;
	}

	// Token: 0x0601A1FB RID: 107003 RVA: 0x006DB90C File Offset: 0x006D9B0C
	public bool IsPriorityActive(int priority)
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		return this.GravitySlots.TryGetValue(priority, out gravitySlot) && gravitySlot.Active;
	}

	// Token: 0x0601A1FC RID: 107004 RVA: 0x006DB934 File Offset: 0x006D9B34
	private void EvaluateAndApply(bool clearGround, float overrideSmoothTime, bool withoutRotate)
	{
		int? num = null;
		foreach (KeyValuePair<int, BaseGravityComponent.GravitySlot> keyValuePair in this.GravitySlots)
		{
			int num2;
			BaseGravityComponent.GravitySlot gravitySlot;
			keyValuePair.Deconstruct(out num2, out gravitySlot);
			int num3 = num2;
			if (gravitySlot.Active)
			{
				if (num != null)
				{
					int num4 = num3;
					int? num5 = num;
					if (!(num4 > num5.GetValueOrDefault() & num5 != null))
					{
						continue;
					}
				}
				num = new int?(num3);
			}
		}
		this.ActivePriority = num;
		if (num != null)
		{
			BaseGravityComponent.GravitySlot gravitySlot2 = this.GravitySlots[num.Value];
			this.ApplyGravityToMoveComp(gravitySlot2.Direction, clearGround, overrideSmoothTime, withoutRotate);
			return;
		}
		this.ApplyGravityToMoveComp(this.DefaultGravityDirect, clearGround, overrideSmoothTime, withoutRotate);
	}

	// Token: 0x0601A1FD RID: 107005 RVA: 0x006DBA0C File Offset: 0x006D9C0C
	protected virtual void ApplyGravityToMoveComp(global::Vector direction, bool clearGround = true, float overrideSmoothTime = -1f, bool withoutRotate = false)
	{
		if (this.MoveComp == null)
		{
			return;
		}
		if (withoutRotate || this.HasForbidRotateTag())
		{
			this.MoveComp.SetGravityDirectWithoutRotateByNumber(direction.X, direction.Y, direction.Z);
			return;
		}
		this.MoveComp.SetGravityDirectByNumber(direction.X, direction.Y, direction.Z, clearGround, overrideSmoothTime);
	}

	// Token: 0x0601A1FE RID: 107006 RVA: 0x006DBA6C File Offset: 0x006D9C6C
	private bool HasForbidRotateTag()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return false;
		}
		foreach (int tagId in BaseGravityComponent.ForbidRotateTagIds)
		{
			if (component.HasTag(tagId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601A1FF RID: 107007 RVA: 0x006DBAB0 File Offset: 0x006D9CB0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseGravityComponent baseGravityComponent = (BaseGravityComponent)componentTemplate;
		if (base.CanResetComponentProperty("GravitySlots") && baseGravityComponent.GravitySlots != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, BaseGravityComponent.GravitySlot>>(this.GravitySlots), "GravitySlots"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DefaultGravityDirect") && baseGravityComponent.DefaultGravityDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.DefaultGravityDirect), "DefaultGravityDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ActivePriority"))
		{
			this.ActivePriority = baseGravityComponent.ActivePriority;
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (baseGravityComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400C62D RID: 50733
	[StaticVariableRuleIgnore]
	private static readonly int[] ForbidRotateTagIds = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托"]
	};

	// Token: 0x0400C62E RID: 50734
	private readonly Dictionary<int, BaseGravityComponent.GravitySlot> GravitySlots = new Dictionary<int, BaseGravityComponent.GravitySlot>();

	// Token: 0x0400C62F RID: 50735
	private readonly global::Vector DefaultGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400C630 RID: 50736
	private int? ActivePriority;

	// Token: 0x0400C631 RID: 50737
	[Nullable(2)]
	protected BaseMoveComponent MoveComp;

	// Token: 0x02009636 RID: 38454
	[NullableContext(0)]
	private class GravitySlot
	{
		// Token: 0x0403030C RID: 197388
		public bool Active;

		// Token: 0x0403030D RID: 197389
		[Nullable(1)]
		public readonly global::Vector Direction = global::Vector.Create();
	}
}
