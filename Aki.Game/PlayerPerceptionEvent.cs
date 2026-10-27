using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Perception;
using UnrealEngine;

// Token: 0x02003287 RID: 12935
[NullableContext(2)]
[Nullable(0)]
public class PlayerPerceptionEvent
{
	// Token: 0x0601BFDD RID: 114653 RVA: 0x007C770B File Offset: 0x007C590B
	public bool IsValid()
	{
		return this.EventTokenInternal > 0U;
	}

	// Token: 0x170026A6 RID: 9894
	// (get) Token: 0x0601BFDE RID: 114654 RVA: 0x007C7716 File Offset: 0x007C5916
	public uint EventToken
	{
		get
		{
			return this.EventTokenInternal;
		}
	}

	// Token: 0x0601BFDF RID: 114655 RVA: 0x007C7720 File Offset: 0x007C5920
	public void Init(float enterDistance, uint entityToken, Action onEnter = null, Action onLeave = null, Action onDestroy = null, Func<bool> enterCondition = null, float leaveDistance = -1f, Vector locationOffset = null)
	{
		if (this.EventTokenInternal != 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "重复初始化主角感知事件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (onEnter == null && onLeave == null)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化的主角感知事件没有意义", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (entityToken == 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化的主角感知事件时传入的时间预算管理Token非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!this.EventGCHandle.IsAllocated)
		{
			this.EventGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		this.EnterDistance = enterDistance;
		this.LeaveDistance = leaveDistance;
		this.EntityToken = entityToken;
		this.LocationOffset = locationOffset;
		this.OnEnter = onEnter;
		this.OnLeave = onLeave;
		this.OnDestroy = onDestroy;
		this.EnterCondition = enterCondition;
		uint entityToken2 = this.EntityToken;
		FVectorDouble fvectorDouble;
		if (locationOffset == null || locationOffset.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
		{
			fvectorDouble = FVectorDouble.ZeroVector;
		}
		else
		{
			FVector fvector = locationOffset.ToUeVectorOld();
			fvectorDouble = fvector;
		}
		FVectorDouble fvectorDouble2 = fvectorDouble;
		this.EventTokenInternal = FKuroPerceptionCSharpInterface.RegisterPlayerPerceptionEvent(enterDistance, leaveDistance, entityToken2, fvectorDouble2, GCHandle.ToIntPtr(this.EventGCHandle), this.OnEnter != null, this.OnLeave != null, this.EnterCondition != null, true);
		if (this.EventTokenInternal == 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化感知事件失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601BFE0 RID: 114656 RVA: 0x007C788C File Offset: 0x007C5A8C
	public void Register(uint entityToken)
	{
		if (this.EventTokenInternal != 0U)
		{
			Log.Instance.Info(ELogModule.Perception, ELogAuthor.WLJ, "重新注册时，仍然还存在感知事件", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.EntityToken = entityToken;
		if (!this.EventGCHandle.IsAllocated)
		{
			this.EventGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		float enterDistance = this.EnterDistance;
		float leaveDistance = this.LeaveDistance;
		uint entityToken2 = this.EntityToken;
		FVectorDouble fvectorDouble;
		if (this.LocationOffset == null || this.LocationOffset.Equals(Vector.ZeroVectorProxy, 9.999999747378752E-05))
		{
			fvectorDouble = FVectorDouble.ZeroVector;
		}
		else
		{
			FVector fvector = this.LocationOffset.ToUeVectorOld();
			fvectorDouble = fvector;
		}
		FVectorDouble fvectorDouble2 = fvectorDouble;
		this.EventTokenInternal = FKuroPerceptionCSharpInterface.RegisterPlayerPerceptionEvent(enterDistance, leaveDistance, entityToken2, fvectorDouble2, GCHandle.ToIntPtr(this.EventGCHandle), this.OnEnter != null, this.OnLeave != null, this.EnterCondition != null, true);
		if (this.EventTokenInternal == 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "重新注册感知事件失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601BFE1 RID: 114657 RVA: 0x007C7990 File Offset: 0x007C5B90
	public void Unregister()
	{
		if (this.EventTokenInternal == 0U)
		{
			Log.Instance.Info(ELogModule.Perception, ELogAuthor.WLJ, "临时注销感知事件时，感知事件不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKuroPerceptionInterface.UnregisterPlayerPerceptionEvent(this.EventTokenInternal);
		this.EventTokenInternal = 0U;
	}

	// Token: 0x0601BFE2 RID: 114658 RVA: 0x007C79D8 File Offset: 0x007C5BD8
	public void Clear()
	{
		this.OnEnter = null;
		this.OnLeave = null;
		this.OnDestroy = null;
		this.EnterCondition = null;
		this.EnterDistance = -1f;
		this.LeaveDistance = -1f;
		this.EntityToken = 0U;
		this.LocationOffset = null;
		if (this.EventGCHandle.IsAllocated)
		{
			this.EventGCHandle.Free();
		}
		if (this.EventTokenInternal == 0U)
		{
			return;
		}
		UKuroPerceptionInterface.UnregisterPlayerPerceptionEvent(this.EventTokenInternal);
		this.EventTokenInternal = 0U;
	}

	// Token: 0x0601BFE3 RID: 114659 RVA: 0x007C7A58 File Offset: 0x007C5C58
	public void UpdateDistance(float enterDistance, float leaveDistance = -1f)
	{
		this.EnterDistance = enterDistance;
		this.LeaveDistance = leaveDistance;
		if (this.EventTokenInternal == 0U)
		{
			return;
		}
		UKuroPerceptionInterface.UpdatePerceptionEventDistance(this.EventTokenInternal, enterDistance, leaveDistance);
	}

	// Token: 0x0601BFE4 RID: 114660 RVA: 0x007C7A7E File Offset: 0x007C5C7E
	public void ExecuteOnEnter()
	{
		if (this.OnEnter == null)
		{
			return;
		}
		this.OnEnter();
	}

	// Token: 0x0601BFE5 RID: 114661 RVA: 0x007C7A94 File Offset: 0x007C5C94
	public void ExecuteOnLeave()
	{
		if (this.OnLeave == null)
		{
			return;
		}
		this.OnLeave();
	}

	// Token: 0x0601BFE6 RID: 114662 RVA: 0x007C7AAA File Offset: 0x007C5CAA
	public bool ExecuteEnterCondition()
	{
		return this.EnterCondition == null || this.EnterCondition();
	}

	// Token: 0x0601BFE7 RID: 114663 RVA: 0x007C7AC1 File Offset: 0x007C5CC1
	public void ExecuteOnDestroy()
	{
		this.EventTokenInternal = 0U;
		this.EntityToken = 0U;
		if (this.OnDestroy == null)
		{
			return;
		}
		this.OnDestroy();
		this.OnDestroy = null;
	}

	// Token: 0x0400DD45 RID: 56645
	private Action OnEnter;

	// Token: 0x0400DD46 RID: 56646
	private Action OnLeave;

	// Token: 0x0400DD47 RID: 56647
	private Action OnDestroy;

	// Token: 0x0400DD48 RID: 56648
	private Func<bool> EnterCondition;

	// Token: 0x0400DD49 RID: 56649
	public uint EventTokenInternal;

	// Token: 0x0400DD4A RID: 56650
	private float EnterDistance = -1f;

	// Token: 0x0400DD4B RID: 56651
	private float LeaveDistance = -1f;

	// Token: 0x0400DD4C RID: 56652
	private uint EntityToken;

	// Token: 0x0400DD4D RID: 56653
	private Vector LocationOffset;

	// Token: 0x0400DD4E RID: 56654
	private GCHandle EventGCHandle;
}
