using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Perception;
using UnrealEngine;

// Token: 0x020027F7 RID: 10231
[NullableContext(1)]
[Nullable(0)]
public class PerceptionRange
{
	// Token: 0x06019BD8 RID: 105432 RVA: 0x007EE688 File Offset: 0x007EC888
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

	// Token: 0x06019BD9 RID: 105433 RVA: 0x007EE790 File Offset: 0x007EC990
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

	// Token: 0x06019BDA RID: 105434 RVA: 0x007EE8E0 File Offset: 0x007ECAE0
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

	// Token: 0x06019BDB RID: 105435 RVA: 0x007EE950 File Offset: 0x007ECB50
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

	// Token: 0x06019BDC RID: 105436 RVA: 0x007EE99C File Offset: 0x007ECB9C
	private bool EnterConditionInternal(object element)
	{
		if (this.EnterCondition == null)
		{
			return false;
		}
		Entity arg = element as Entity;
		return this.EnterCondition(arg);
	}

	// Token: 0x06019BDD RID: 105437 RVA: 0x007EE9C8 File Offset: 0x007ECBC8
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

	// Token: 0x06019BDE RID: 105438 RVA: 0x007EEA0C File Offset: 0x007ECC0C
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

	// Token: 0x06019BDF RID: 105439 RVA: 0x007EEA4F File Offset: 0x007ECC4F
	private FVectorDouble GetLocationProxyInternal()
	{
		if (this.GetLocationProxy == null)
		{
			return this.LocationCache.ToUeVector(false);
		}
		this.LocationCache.DeepCopy(this.GetLocationProxy());
		return this.LocationCache.ToUeVector(false);
	}

	// Token: 0x0400E1E3 RID: 57827
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<Entity, bool> EnterCondition;

	// Token: 0x0400E1E4 RID: 57828
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<Entity> OnEnter;

	// Token: 0x0400E1E5 RID: 57829
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<Entity> OnLeave;

	// Token: 0x0400E1E6 RID: 57830
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<Vector> GetLocationProxy;

	// Token: 0x0400E1E7 RID: 57831
	private readonly Vector LocationCache = Vector.Create();

	// Token: 0x0400E1E8 RID: 57832
	private uint RangeToken;

	// Token: 0x0400E1E9 RID: 57833
	[Nullable(2)]
	private HashSet<int> InsideEntity;

	// Token: 0x0400E1EA RID: 57834
	private GCHandle PerceptionRangeGCHandle;
}
