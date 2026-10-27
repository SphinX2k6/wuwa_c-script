using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200328C RID: 12940
[NullableContext(1)]
[Nullable(0)]
public class BaseOptimizationStrategy
{
	// Token: 0x0601C03A RID: 114746 RVA: 0x007C9BB8 File Offset: 0x007C7DB8
	public BaseOptimizationStrategy()
	{
		this.NeedEnableInternal = (base.GetType().GetMethod("OnEnable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).DeclaringType != typeof(BaseOptimizationStrategy));
		this.NeedTriggerMyPlayerInOut = (base.GetType().GetMethod("OnMyPlayerInOutRangeLocal", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).DeclaringType != typeof(BaseOptimizationStrategy));
		this.NeedTriggerEntityInOut = (base.GetType().GetMethod("OnEntityInOutRangeLocal", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).DeclaringType != typeof(BaseOptimizationStrategy));
		this.NeedDisableInternal = (base.GetType().GetMethod("OnDisable", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).DeclaringType != typeof(BaseOptimizationStrategy));
	}

	// Token: 0x170026B8 RID: 9912
	// (get) Token: 0x0601C03B RID: 114747 RVA: 0x007C9C7B File Offset: 0x007C7E7B
	public bool NeedEnable
	{
		get
		{
			return this.NeedEnableInternal;
		}
	}

	// Token: 0x170026B9 RID: 9913
	// (get) Token: 0x0601C03C RID: 114748 RVA: 0x007C9C83 File Offset: 0x007C7E83
	public bool NeedTriggerMyPlayerInOutRange
	{
		get
		{
			return this.NeedTriggerMyPlayerInOut;
		}
	}

	// Token: 0x170026BA RID: 9914
	// (get) Token: 0x0601C03D RID: 114749 RVA: 0x007C9C8B File Offset: 0x007C7E8B
	public bool NeedTriggerEntityInOutRange
	{
		get
		{
			return this.NeedTriggerEntityInOut;
		}
	}

	// Token: 0x170026BB RID: 9915
	// (get) Token: 0x0601C03E RID: 114750 RVA: 0x007C9C93 File Offset: 0x007C7E93
	public bool NeedDisable
	{
		get
		{
			return this.NeedDisableInternal;
		}
	}

	// Token: 0x0601C03F RID: 114751 RVA: 0x007C9C9B File Offset: 0x007C7E9B
	public void Enable()
	{
		if (!this.NeedEnableInternal)
		{
			return;
		}
		this.OnEnable();
	}

	// Token: 0x0601C040 RID: 114752 RVA: 0x007C9CAC File Offset: 0x007C7EAC
	public void MyPlayerEntityInOutRange(bool isEnter)
	{
		if (!this.NeedTriggerMyPlayerInOut)
		{
			return;
		}
		this.OnMyPlayerInOutRangeLocal(isEnter);
	}

	// Token: 0x0601C041 RID: 114753 RVA: 0x007C9CBE File Offset: 0x007C7EBE
	public void EntityInOutRange(bool isEnter, EntityHandle handle)
	{
		if (!this.NeedTriggerEntityInOut)
		{
			return;
		}
		this.OnEntityInOutRangeLocal(isEnter, handle);
	}

	// Token: 0x0601C042 RID: 114754 RVA: 0x007C9CD1 File Offset: 0x007C7ED1
	public void Disable()
	{
		if (!this.NeedDisableInternal)
		{
			return;
		}
		this.OnDisable();
	}

	// Token: 0x0601C043 RID: 114755 RVA: 0x007C9CE2 File Offset: 0x007C7EE2
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0601C044 RID: 114756 RVA: 0x007C9CE4 File Offset: 0x007C7EE4
	protected virtual void OnMyPlayerInOutRangeLocal(bool isEnter)
	{
	}

	// Token: 0x0601C045 RID: 114757 RVA: 0x007C9CE6 File Offset: 0x007C7EE6
	protected virtual void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
	{
	}

	// Token: 0x0601C046 RID: 114758 RVA: 0x007C9CE8 File Offset: 0x007C7EE8
	protected virtual void OnDisable()
	{
	}

	// Token: 0x0400DD80 RID: 56704
	private readonly bool NeedEnableInternal;

	// Token: 0x0400DD81 RID: 56705
	private readonly bool NeedTriggerMyPlayerInOut;

	// Token: 0x0400DD82 RID: 56706
	private readonly bool NeedTriggerEntityInOut;

	// Token: 0x0400DD83 RID: 56707
	private readonly bool NeedDisableInternal;

	// Token: 0x0400DD84 RID: 56708
	private const BindingFlags MethodBindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
}
