using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030E5 RID: 12517
[NullableContext(1)]
[Nullable(0)]
public class SceneComponentPool<[Nullable(0)] T> where T : USceneComponent
{
	// Token: 0x0601ACDC RID: 109788 RVA: 0x0073B7D4 File Offset: 0x007399D4
	protected virtual void ActiveComponent(T component)
	{
	}

	// Token: 0x0601ACDD RID: 109789 RVA: 0x0073B7D6 File Offset: 0x007399D6
	protected virtual void CleanComponent(T component)
	{
	}

	// Token: 0x0601ACDE RID: 109790 RVA: 0x0073B7D8 File Offset: 0x007399D8
	[NullableContext(2)]
	protected virtual T CreateComponent()
	{
		return default(T);
	}

	// Token: 0x0601ACDF RID: 109791 RVA: 0x0073B7F0 File Offset: 0x007399F0
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

	// Token: 0x0601ACE0 RID: 109792 RVA: 0x0073B9C8 File Offset: 0x00739BC8
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

	// Token: 0x0601ACE1 RID: 109793 RVA: 0x0073BA4C File Offset: 0x00739C4C
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

	// Token: 0x0601ACE2 RID: 109794 RVA: 0x0073BAC3 File Offset: 0x00739CC3
	protected bool CheckPoolRange()
	{
		return this.BasePoolInternal.Count + this.UsedPoolInternal.Count < this.MaxPoolSize;
	}

	// Token: 0x0601ACE3 RID: 109795 RVA: 0x0073BAE4 File Offset: 0x00739CE4
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

	// Token: 0x0601ACE4 RID: 109796 RVA: 0x0073BB06 File Offset: 0x00739D06
	protected void BasePoolPush(T component, bool bResetComponent = true)
	{
		this.PoolPushInternal(component, this.BasePoolInternal, bResetComponent);
	}

	// Token: 0x0601ACE5 RID: 109797 RVA: 0x0073BB16 File Offset: 0x00739D16
	protected void UsedPoolPush(T component, bool bResetComponent = false)
	{
		this.PoolPushInternal(component, this.UsedPoolInternal, bResetComponent);
	}

	// Token: 0x0601ACE6 RID: 109798 RVA: 0x0073BB26 File Offset: 0x00739D26
	protected void PoolPushInternal(T component, List<T> pool, bool bResetComponent = true)
	{
		pool.Add(component);
		if (bResetComponent)
		{
			this.CleanComponent(component);
		}
	}

	// Token: 0x0601ACE7 RID: 109799 RVA: 0x0073BB3C File Offset: 0x00739D3C
	public void Shrink()
	{
		foreach (T t in this.BasePoolInternal)
		{
			t.K2_DestroyComponent(this.ActorInternal);
		}
		this.BasePoolInternal.Clear();
	}

	// Token: 0x0601ACE8 RID: 109800 RVA: 0x0073BBA4 File Offset: 0x00739DA4
	public int GetUsedLength()
	{
		return this.UsedPoolInternal.Count;
	}

	// Token: 0x0400CF10 RID: 53008
	private readonly List<T> BasePoolInternal = new List<T>();

	// Token: 0x0400CF11 RID: 53009
	private readonly List<T> UsedPoolInternal = new List<T>();

	// Token: 0x0400CF12 RID: 53010
	[Nullable(2)]
	protected USceneComponent AttachComponentInternal;

	// Token: 0x0400CF13 RID: 53011
	[Nullable(2)]
	protected AActor ActorInternal;

	// Token: 0x0400CF14 RID: 53012
	protected int MaxPoolSize;
}
