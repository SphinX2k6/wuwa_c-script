using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FD3 RID: 4051
public class FloroRanchEntityComponentBase
{
	// Token: 0x0600A1BD RID: 41405 RVA: 0x002F880F File Offset: 0x002F6A0F
	[NullableContext(1)]
	public void Create(FloroRanchEntityBase ownerEntity)
	{
		this.OwnerEntity = ownerEntity;
		this.OnCreate();
	}

	// Token: 0x0600A1BE RID: 41406 RVA: 0x002F881E File Offset: 0x002F6A1E
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x0600A1BF RID: 41407 RVA: 0x002F8826 File Offset: 0x002F6A26
	public void Tick(float deltaTime)
	{
		if (!this.NeedTick)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600A1C0 RID: 41408 RVA: 0x002F8838 File Offset: 0x002F6A38
	public void End()
	{
		this.OnEnd();
	}

	// Token: 0x0600A1C1 RID: 41409 RVA: 0x002F8840 File Offset: 0x002F6A40
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0600A1C2 RID: 41410 RVA: 0x002F8842 File Offset: 0x002F6A42
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600A1C3 RID: 41411 RVA: 0x002F8844 File Offset: 0x002F6A44
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600A1C4 RID: 41412 RVA: 0x002F8846 File Offset: 0x002F6A46
	protected virtual void OnEnd()
	{
	}

	// Token: 0x04005F1E RID: 24350
	[StaticVariableRuleIgnore]
	public static int Id;

	// Token: 0x04005F1F RID: 24351
	protected bool NeedTick;

	// Token: 0x04005F20 RID: 24352
	[Nullable(2)]
	protected FloroRanchEntityBase OwnerEntity;
}
