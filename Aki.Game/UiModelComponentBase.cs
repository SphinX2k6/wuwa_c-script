using System;
using System.Runtime.CompilerServices;

// Token: 0x02002CBB RID: 11451
[NullableContext(1)]
[Nullable(0)]
public abstract class UiModelComponentBase
{
	// Token: 0x17002040 RID: 8256
	// (get) Token: 0x06017EFF RID: 98047 RVA: 0x00616A69 File Offset: 0x00614C69
	public UiModelBase Owner
	{
		get
		{
			return this.OwnerInternal;
		}
	}

	// Token: 0x06017F00 RID: 98048 RVA: 0x00616A71 File Offset: 0x00614C71
	public void Create(UiModelBase owner)
	{
		this.OwnerInternal = owner;
		this.OnCreate();
	}

	// Token: 0x06017F01 RID: 98049 RVA: 0x00616A80 File Offset: 0x00614C80
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x06017F02 RID: 98050 RVA: 0x00616A88 File Offset: 0x00614C88
	public void Start()
	{
		this.OnStart();
	}

	// Token: 0x06017F03 RID: 98051 RVA: 0x00616A90 File Offset: 0x00614C90
	public virtual void Tick(float deltaTime)
	{
		this.OnTick(deltaTime);
	}

	// Token: 0x06017F04 RID: 98052 RVA: 0x00616A99 File Offset: 0x00614C99
	public void End()
	{
		this.OnEnd();
	}

	// Token: 0x06017F05 RID: 98053 RVA: 0x00616AA1 File Offset: 0x00614CA1
	public void Clear()
	{
		this.OnClear();
	}

	// Token: 0x06017F06 RID: 98054 RVA: 0x00616AA9 File Offset: 0x00614CA9
	protected virtual void OnCreate()
	{
	}

	// Token: 0x06017F07 RID: 98055 RVA: 0x00616AAB File Offset: 0x00614CAB
	protected virtual void OnInit()
	{
	}

	// Token: 0x06017F08 RID: 98056 RVA: 0x00616AAD File Offset: 0x00614CAD
	protected virtual void OnStart()
	{
	}

	// Token: 0x06017F09 RID: 98057 RVA: 0x00616AAF File Offset: 0x00614CAF
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x06017F0A RID: 98058 RVA: 0x00616AB1 File Offset: 0x00614CB1
	protected virtual void OnEnd()
	{
	}

	// Token: 0x06017F0B RID: 98059 RVA: 0x00616AB3 File Offset: 0x00614CB3
	protected virtual void OnClear()
	{
	}

	// Token: 0x0400B271 RID: 45681
	public bool NeedTick;

	// Token: 0x0400B272 RID: 45682
	private UiModelBase OwnerInternal;
}
