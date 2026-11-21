using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200263D RID: 9789
[NullableContext(1)]
[Nullable(0)]
public class SceneComponentPool<[Nullable(0)] T> where T : USceneComponent
{
	// Token: 0x060186F8 RID: 100088 RVA: 0x00761210 File Offset: 0x0075F410
	protected virtual void ActiveComponent(T component)
	{
	}

	// Token: 0x060186F9 RID: 100089 RVA: 0x00761212 File Offset: 0x0075F412
	protected virtual void CleanComponent(T component)
	{
	}

	// Token: 0x060186FA RID: 100090 RVA: 0x00761214 File Offset: 0x0075F414
	[NullableContext(2)]
	protected virtual T CreateComponent()
	{
		return default(T);
	}

	// Token: 0x060186FB RID: 100091 RVA: 0x0076122C File Offset: 0x0075F42C
	public List<T> GetComponents(int num, bool bIncludeUsed = true, bool bCleanUsed = false)
	{
		int num2 = (num > this.MaxPoolSize) ? this.MaxPoolSize : num;
		int num3 = bIncludeUsed ? 0 : num2;
		List<T> list = new List<T>();
		if (bIncludeUsed)
		{
			int num4 = num2;
			int count = this.UsedPoolInternal.Count;
			if (num2 > count)
			{
				num4 = count;
				num3 = num2 - count;
			}
			else
			{
				int num5 = count - num2;
				for (int i = 0; i < num5; i++)
				{
					T component = this.UsedPoolInternal[this.UsedPoolInternal.Count - 1];
					this.UsedPoolInternal.RemoveAt(this.UsedPoolInternal.Count - 1);
					this.BasePoolPush(component, true);
				}
			}
			for (int j = 0; j < num4; j++)
			{
				this.PoolPushInternal(this.UsedPoolInternal[j], list, false);
				if (bCleanUsed)
				{
					this.CleanComponent(this.UsedPoolInternal[j]);
				}
			}
		}
		if (num3 > 0)
		{
			int num6 = 0;
			int count2 = this.BasePoolInternal.Count;
			if (num3 > count2)
			{
				num6 = num3 - count2;
				num3 = count2;
			}
			for (int k = 0; k < num3; k++)
			{
				T component2 = this.BasePoolInternal[this.BasePoolInternal.Count - 1];
				this.BasePoolInternal.RemoveAt(this.BasePoolInternal.Count - 1);
				this.PoolPushInternal(component2, list, false);
				this.UsedPoolPush(component2, false);
			}
			for (int l = 0; l < num6; l++)
			{
				T t = this.CreateComponent();
				if (t != null)
				{
					this.PoolPushInternal(t, list, false);
					this.UsedPoolPush(t, false);
				}
			}
		}
		foreach (T component3 in list)
		{
			this.ActiveComponent(component3);
		}
		return list;
	}

	// Token: 0x060186FC RID: 100092 RVA: 0x00761404 File Offset: 0x0075F604
	public bool BackComponent(List<T> components)
	{
		bool result = true;
		foreach (T item in components)
		{
			if (this.UsedPoolInternal.Contains(item))
			{
				int index = this.UsedPoolInternal.IndexOf(item);
				this.BasePoolInternal.Add(item);
				this.UsedPoolInternal.RemoveAt(index);
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x060186FD RID: 100093 RVA: 0x00761488 File Offset: 0x0075F688
	public void Init(int maxSize, USceneComponent attachComponent, AActor actor, List<T> components, bool bInUsed = false, bool bResetComponent = false)
	{
		if (attachComponent == null || actor == null || maxSize <= 0)
		{
			return;
		}
		this.ActorInternal = actor;
		this.MaxPoolSize = maxSize;
		this.AttachComponentInternal = attachComponent;
		int count = components.Count;
		int num = (maxSize < count) ? maxSize : count;
		for (int i = 0; i < num; i++)
		{
			T t = components[i];
			MeshComponentUtils.RelativeAttachComponentOnSafe(t, this.AttachComponentInternal, "");
			if (!this.PoolPush(t, bInUsed, bResetComponent))
			{
				break;
			}
		}
	}

	// Token: 0x060186FE RID: 100094 RVA: 0x007614FF File Offset: 0x0075F6FF
	protected bool CheckPoolRange()
	{
		return this.BasePoolInternal.Count + this.UsedPoolInternal.Count < this.MaxPoolSize;
	}

	// Token: 0x060186FF RID: 100095 RVA: 0x00761520 File Offset: 0x0075F720
	protected bool PoolPush(T component, bool bInUsed = false, bool bResetComponent = true)
	{
		if (!this.CheckPoolRange())
		{
			return false;
		}
		if (bInUsed)
		{
			this.BasePoolPush(component, bResetComponent);
		}
		else
		{
			this.UsedPoolPush(component, bResetComponent);
		}
		return true;
	}

	// Token: 0x06018700 RID: 100096 RVA: 0x00761542 File Offset: 0x0075F742
	protected void BasePoolPush(T component, bool bResetComponent = true)
	{
		this.PoolPushInternal(component, this.BasePoolInternal, bResetComponent);
	}

	// Token: 0x06018701 RID: 100097 RVA: 0x00761552 File Offset: 0x0075F752
	protected void UsedPoolPush(T component, bool bResetComponent = false)
	{
		this.PoolPushInternal(component, this.UsedPoolInternal, bResetComponent);
	}

	// Token: 0x06018702 RID: 100098 RVA: 0x00761562 File Offset: 0x0075F762
	protected void PoolPushInternal(T component, List<T> pool, bool bResetComponent = true)
	{
		pool.Add(component);
		if (bResetComponent)
		{
			this.CleanComponent(component);
		}
	}

	// Token: 0x06018703 RID: 100099 RVA: 0x00761578 File Offset: 0x0075F778
	public void Shrink()
	{
		foreach (T t in this.BasePoolInternal)
		{
			t.K2_DestroyComponent(this.ActorInternal);
		}
		this.BasePoolInternal.Clear();
	}

	// Token: 0x06018704 RID: 100100 RVA: 0x007615E0 File Offset: 0x0075F7E0
	public int GetUsedLength()
	{
		return this.UsedPoolInternal.Count;
	}

	// Token: 0x0400D300 RID: 54016
	private readonly List<T> BasePoolInternal = new List<T>();

	// Token: 0x0400D301 RID: 54017
	private readonly List<T> UsedPoolInternal = new List<T>();

	// Token: 0x0400D302 RID: 54018
	[Nullable(2)]
	protected USceneComponent AttachComponentInternal;

	// Token: 0x0400D303 RID: 54019
	[Nullable(2)]
	protected AActor ActorInternal;

	// Token: 0x0400D304 RID: 54020
	protected int MaxPoolSize;
}
