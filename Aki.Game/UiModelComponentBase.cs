using System;
using System.Runtime.CompilerServices;

// Token: 0x02002214 RID: 8724
[NullableContext(1)]
[Nullable(0)]
public abstract class UiModelComponentBase
{
	// Token: 0x17002091 RID: 8337
	// (get) Token: 0x06015778 RID: 87928 RVA: 0x0063C729 File Offset: 0x0063A929
	public UiModelBase Owner
	{
		get
		{
			return this.OwnerInternal;
		}
	}

	// Token: 0x06015779 RID: 87929 RVA: 0x0063C731 File Offset: 0x0063A931
	public void Create(UiModelBase owner)
	{
		this.OwnerInternal = owner;
		this.OnCreate();
	}

	// Token: 0x0601577A RID: 87930 RVA: 0x0063C740 File Offset: 0x0063A940
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x0601577B RID: 87931 RVA: 0x0063C748 File Offset: 0x0063A948
	public void Start()
	{
		this.OnStart();
	}

	// Token: 0x0601577C RID: 87932 RVA: 0x0063C750 File Offset: 0x0063A950
	public virtual void Tick(float deltaTime)
	{
		this.OnTick(deltaTime);
	}

	// Token: 0x0601577D RID: 87933 RVA: 0x0063C759 File Offset: 0x0063A959
	public void End()
	{
		this.OnEnd();
	}

	// Token: 0x0601577E RID: 87934 RVA: 0x0063C761 File Offset: 0x0063A961
	public void Clear()
	{
		this.OnClear();
	}

	// Token: 0x0601577F RID: 87935 RVA: 0x0063C769 File Offset: 0x0063A969
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06015780 RID: 87936 RVA: 0x0063C76B File Offset: 0x0063A96B
	protected virtual void OnInit()
	{
	}

	// Token: 0x06015781 RID: 87937 RVA: 0x0063C76D File Offset: 0x0063A96D
	protected virtual void OnStart()
	{
	}

	// Token: 0x06015782 RID: 87938 RVA: 0x0063C76F File Offset: 0x0063A96F
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06015783 RID: 87939 RVA: 0x0063C771 File Offset: 0x0063A971
	protected virtual void OnEnd()
	{
	}

	// Token: 0x06015784 RID: 87940 RVA: 0x0063C773 File Offset: 0x0063A973
	protected virtual void OnClear()
	{
	}

	// Token: 0x0400B5DC RID: 46556
	public bool NeedTick;

	// Token: 0x0400B5DD RID: 46557
	private UiModelBase OwnerInternal;
}
