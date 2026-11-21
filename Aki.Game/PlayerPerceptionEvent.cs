using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Perception;
using UnrealEngine;

// Token: 0x020027F8 RID: 10232
[NullableContext(2)]
[Nullable(0)]
public class PlayerPerceptionEvent
{
	// Token: 0x06019BE1 RID: 105441 RVA: 0x007EEA9B File Offset: 0x007ECC9B
	public bool IsValid()
	{
		return this.EventTokenInternal > 0U;
	}

	// Token: 0x1700295B RID: 10587
	// (get) Token: 0x06019BE2 RID: 105442 RVA: 0x007EEAA6 File Offset: 0x007ECCA6
	public uint EventToken
	{
		get
		{
			return this.EventTokenInternal;
		}
	}

	// Token: 0x06019BE3 RID: 105443 RVA: 0x007EEAB0 File Offset: 0x007ECCB0
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

	// Token: 0x06019BE4 RID: 105444 RVA: 0x007EEC1C File Offset: 0x007ECE1C
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

	// Token: 0x06019BE5 RID: 105445 RVA: 0x007EED20 File Offset: 0x007ECF20
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

	// Token: 0x06019BE6 RID: 105446 RVA: 0x007EED68 File Offset: 0x007ECF68
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

	// Token: 0x06019BE7 RID: 105447 RVA: 0x007EEDE8 File Offset: 0x007ECFE8
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

	// Token: 0x06019BE8 RID: 105448 RVA: 0x007EEE0E File Offset: 0x007ED00E
	public void ExecuteOnEnter()
	{
		if (this.OnEnter == null)
		{
			return;
		}
		this.OnEnter();
	}

	// Token: 0x06019BE9 RID: 105449 RVA: 0x007EEE24 File Offset: 0x007ED024
	public void ExecuteOnLeave()
	{
		if (this.OnLeave == null)
		{
			return;
		}
		this.OnLeave();
	}

	// Token: 0x06019BEA RID: 105450 RVA: 0x007EEE3A File Offset: 0x007ED03A
	public bool ExecuteEnterCondition()
	{
		return this.EnterCondition == null || this.EnterCondition();
	}

	// Token: 0x06019BEB RID: 105451 RVA: 0x007EEE51 File Offset: 0x007ED051
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

	// Token: 0x0400E1EB RID: 57835
	private Action OnEnter;

	// Token: 0x0400E1EC RID: 57836
	private Action OnLeave;

	// Token: 0x0400E1ED RID: 57837
	private Action OnDestroy;

	// Token: 0x0400E1EE RID: 57838
	private Func<bool> EnterCondition;

	// Token: 0x0400E1EF RID: 57839
	public uint EventTokenInternal;

	// Token: 0x0400E1F0 RID: 57840
	private float EnterDistance = -1f;

	// Token: 0x0400E1F1 RID: 57841
	private float LeaveDistance = -1f;

	// Token: 0x0400E1F2 RID: 57842
	private uint EntityToken;

	// Token: 0x0400E1F3 RID: 57843
	private Vector LocationOffset;

	// Token: 0x0400E1F4 RID: 57844
	private GCHandle EventGCHandle;
}
