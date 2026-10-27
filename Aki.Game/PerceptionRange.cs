using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Perception;
using UnrealEngine;

// Token: 0x02003286 RID: 12934
[NullableContext(1)]
[Nullable(0)]
public class PerceptionRange
{
	// Token: 0x0601BFD4 RID: 114644 RVA: 0x007C72F8 File Offset: 0x007C54F8
	public void InitStatic(Vector center, float range, byte group, bool needRecord = false, [Nullable(new byte[]
	{
		2,
		1
	})] Func<Entity, bool> enterCondition = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<Entity> onEnter = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<Entity> onLeave = null)
	{
		if (this.RangeToken != 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "重复初始化静态感知范围", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!needRecord && onEnter == null && onLeave == null)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化的静态感知范围没有意义", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (needRecord)
		{
			this.InsideEntity = new HashSet<int>();
		}
		this.EnterCondition = enterCondition;
		this.OnEnter = onEnter;
		this.OnLeave = onLeave;
		if (!this.PerceptionRangeGCHandle.IsAllocated)
		{
			this.PerceptionRangeGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		FVectorDouble fvectorDouble = center.ToUeVector(false);
		this.RangeToken = FKuroPerceptionCSharpInterface.AddStaticPerceptionRange(fvectorDouble, range, (uint)group, GCHandle.ToIntPtr(this.PerceptionRangeGCHandle), this.EnterCondition != null, this.OnEnter != null, this.OnLeave != null);
		if (this.RangeToken == 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化静态感知范围失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601BFD5 RID: 114645 RVA: 0x007C7400 File Offset: 0x007C5600
	public void InitDynamic(uint? entityToken, float range, byte group, [Nullable(new byte[]
	{
		2,
		1
	})] Action<Entity> onEnter = null, [Nullable(new byte[]
	{
		2,
		1
	})] Action<Entity> onLeave = null, [Nullable(new byte[]
	{
		2,
		1
	})] Func<Entity, bool> enterCondition = null, [Nullable(new byte[]
	{
		2,
		1
	})] Func<Vector> getLocationProxy = null, bool needRecord = false)
	{
		if (entityToken == null)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化动态感知范围绑定的实体Token非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (range <= 0f)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化动态感知范围时，感知范围大小非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.RangeToken != 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "重复初始化动态感知范围", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!needRecord && onEnter == null && onLeave == null)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化的动态感知范围没有意义", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.GetLocationProxy = getLocationProxy;
		this.EnterCondition = enterCondition;
		this.OnEnter = onEnter;
		this.OnLeave = onLeave;
		if (!this.PerceptionRangeGCHandle.IsAllocated)
		{
			this.PerceptionRangeGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		this.RangeToken = FKuroPerceptionCSharpInterface.AddDynamicPerceptionRange(entityToken.Value, range, (uint)group, GCHandle.ToIntPtr(this.PerceptionRangeGCHandle), true, this.EnterCondition != null, this.OnEnter != null, this.OnLeave != null);
		if (this.RangeToken == 0U)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "初始化动态感知范围失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0601BFD6 RID: 114646 RVA: 0x007C7550 File Offset: 0x007C5750
	public void Clear()
	{
		this.EnterCondition = null;
		this.OnEnter = null;
		this.OnLeave = null;
		this.GetLocationProxy = null;
		this.LocationCache.Reset();
		this.InsideEntity = null;
		if (this.RangeToken != 0U)
		{
			UKuroPerceptionInterface.RemovePerceptionRange(this.RangeToken);
			this.RangeToken = 0U;
		}
		if (this.PerceptionRangeGCHandle.IsAllocated)
		{
			this.PerceptionRangeGCHandle.Free();
		}
	}

	// Token: 0x0601BFD7 RID: 114647 RVA: 0x007C75C0 File Offset: 0x007C57C0
	public void UpdateRange(float range)
	{
		if (this.RangeToken == 0U)
		{
			return;
		}
		if (range <= 0f)
		{
			Log.Instance.Error(ELogModule.Perception, ELogAuthor.WLJ, "更新动态感知范围大小时，感知范围大小非法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKuroPerceptionInterface.UpdatePerceptionRange(this.RangeToken, range);
	}

	// Token: 0x0601BFD8 RID: 114648 RVA: 0x007C760C File Offset: 0x007C580C
	private bool EnterConditionInternal(object element)
	{
		if (this.EnterCondition == null)
		{
			return false;
		}
		Entity arg = element as Entity;
		return this.EnterCondition(arg);
	}

	// Token: 0x0601BFD9 RID: 114649 RVA: 0x007C7638 File Offset: 0x007C5838
	private void voidOnEnterInternal(object element)
	{
		Entity entity = element as Entity;
		if (this.InsideEntity != null)
		{
			this.InsideEntity.Add(entity.Id);
		}
		if (this.OnEnter == null)
		{
			return;
		}
		this.OnEnter(entity);
	}

	// Token: 0x0601BFDA RID: 114650 RVA: 0x007C767C File Offset: 0x007C587C
	private void OnLeaveInternal(object element)
	{
		Entity entity = element as Entity;
		if (this.InsideEntity != null)
		{
			this.InsideEntity.Remove(entity.Id);
		}
		if (this.OnLeave == null)
		{
			return;
		}
		this.OnLeave(entity);
	}

	// Token: 0x0601BFDB RID: 114651 RVA: 0x007C76BF File Offset: 0x007C58BF
	private FVectorDouble GetLocationProxyInternal()
	{
		if (this.GetLocationProxy == null)
		{
			return this.LocationCache.ToUeVector(false);
		}
		this.LocationCache.DeepCopy(this.GetLocationProxy());
		return this.LocationCache.ToUeVector(false);
	}

	// Token: 0x0400DD3D RID: 56637
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<Entity, bool> EnterCondition;

	// Token: 0x0400DD3E RID: 56638
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<Entity> OnEnter;

	// Token: 0x0400DD3F RID: 56639
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<Entity> OnLeave;

	// Token: 0x0400DD40 RID: 56640
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<Vector> GetLocationProxy;

	// Token: 0x0400DD41 RID: 56641
	private readonly Vector LocationCache = Vector.Create();

	// Token: 0x0400DD42 RID: 56642
	private uint RangeToken;

	// Token: 0x0400DD43 RID: 56643
	[Nullable(2)]
	private HashSet<int> InsideEntity;

	// Token: 0x0400DD44 RID: 56644
	private GCHandle PerceptionRangeGCHandle;
}
