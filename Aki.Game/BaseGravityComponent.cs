using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x0200257E RID: 9598
[NullableContext(1)]
[Nullable(0)]
public class BaseGravityComponent : EntityComponent
{
	// Token: 0x06017B4D RID: 97101 RVA: 0x007035EC File Offset: 0x007017EC
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

	// Token: 0x06017B4E RID: 97102 RVA: 0x00703634 File Offset: 0x00701834
	protected override bool OnEnd()
	{
		this.GravitySlots.Clear();
		this.ActivePriority = null;
		return true;
	}

	// Token: 0x06017B4F RID: 97103 RVA: 0x00703650 File Offset: 0x00701850
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

	// Token: 0x06017B50 RID: 97104 RVA: 0x00703683 File Offset: 0x00701883
	public void SetDefaultGravityDirect(IVector v)
	{
		this.DefaultGravityDirect.Set(v.X, v.Y, v.Z);
		if (this.ActivePriority == null)
		{
			this.ApplyGravityToMoveComp(this.DefaultGravityDirect, true, -1f, true);
		}
	}

	// Token: 0x06017B51 RID: 97105 RVA: 0x007036C4 File Offset: 0x007018C4
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

	// Token: 0x06017B52 RID: 97106 RVA: 0x00703724 File Offset: 0x00701924
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

	// Token: 0x06017B53 RID: 97107 RVA: 0x0070375B File Offset: 0x0070195B
	public global::Vector GetDefaultGravityDirect()
	{
		return this.DefaultGravityDirect;
	}

	// Token: 0x06017B54 RID: 97108 RVA: 0x00703764 File Offset: 0x00701964
	public global::Vector GetActiveGravityDirect()
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		if (this.ActivePriority != null && this.GravitySlots.TryGetValue(this.ActivePriority.Value, out gravitySlot) && gravitySlot.Active)
		{
			return gravitySlot.Direction;
		}
		return this.DefaultGravityDirect;
	}

	// Token: 0x06017B55 RID: 97109 RVA: 0x007037AD File Offset: 0x007019AD
	public int? GetActivePriority()
	{
		return this.ActivePriority;
	}

	// Token: 0x06017B56 RID: 97110 RVA: 0x007037B8 File Offset: 0x007019B8
	public bool IsPriorityActive(int priority)
	{
		BaseGravityComponent.GravitySlot gravitySlot;
		return this.GravitySlots.TryGetValue(priority, out gravitySlot) && gravitySlot.Active;
	}

	// Token: 0x06017B57 RID: 97111 RVA: 0x007037E0 File Offset: 0x007019E0
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

	// Token: 0x06017B58 RID: 97112 RVA: 0x007038B8 File Offset: 0x00701AB8
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

	// Token: 0x06017B59 RID: 97113 RVA: 0x00703918 File Offset: 0x00701B18
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

	// Token: 0x06017B5A RID: 97114 RVA: 0x0070395C File Offset: 0x00701B5C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseGravityComponent baseGravityComponent = (BaseGravityComponent)componentTemplate;
		if (baseGravityComponent.GravitySlots != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravitySlots), "GravitySlots"))
		{
			return false;
		}
		if (baseGravityComponent.DefaultGravityDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultGravityDirect), "DefaultGravityDirect"))
		{
			return false;
		}
		this.ActivePriority = baseGravityComponent.ActivePriority;
		if (baseGravityComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170024D6 RID: 9430
	// (get) Token: 0x06017B5B RID: 97115 RVA: 0x007039F7 File Offset: 0x00701BF7
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024D7 RID: 9431
	// (get) Token: 0x06017B5C RID: 97116 RVA: 0x007039FA File Offset: 0x00701BFA
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C9FC RID: 51708
	[StaticVariableRuleIgnore]
	private static readonly int[] ForbidRotateTagIds = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托"]
	};

	// Token: 0x0400C9FD RID: 51709
	private readonly Dictionary<int, BaseGravityComponent.GravitySlot> GravitySlots = new Dictionary<int, BaseGravityComponent.GravitySlot>();

	// Token: 0x0400C9FE RID: 51710
	private readonly global::Vector DefaultGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400C9FF RID: 51711
	private int? ActivePriority;

	// Token: 0x0400CA00 RID: 51712
	[Nullable(2)]
	protected BaseMoveComponent MoveComp;

	// Token: 0x02008857 RID: 34903
	[NullableContext(0)]
	private class GravitySlot
	{
		// Token: 0x0402B999 RID: 178585
		public bool Active;

		// Token: 0x0402B99A RID: 178586
		[Nullable(1)]
		public readonly global::Vector Direction = global::Vector.Create();
	}
}
