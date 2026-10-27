using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B14 RID: 6932
public class FloroRanchEntityComponentBase
{
	// Token: 0x0600CDAC RID: 52652 RVA: 0x002ED723 File Offset: 0x002EB923
	[NullableContext(1)]
	public void Create(FloroRanchEntityBase ownerEntity)
	{
		this.OwnerEntity = ownerEntity;
		this.OnCreate();
	}

	// Token: 0x0600CDAD RID: 52653 RVA: 0x002ED732 File Offset: 0x002EB932
	public void Init()
	{
		this.OnInit();
	}

	// Token: 0x0600CDAE RID: 52654 RVA: 0x002ED73A File Offset: 0x002EB93A
	public void Tick(float deltaTime)
	{
		if (!this.NeedTick)
		{
			return;
		}
		this.OnTick(deltaTime);
	}

	// Token: 0x0600CDAF RID: 52655 RVA: 0x002ED74C File Offset: 0x002EB94C
	public void End()
	{
		this.OnEnd();
	}

	// Token: 0x0600CDB0 RID: 52656 RVA: 0x002ED754 File Offset: 0x002EB954
	protected virtual void OnCreate()
	{
	}

	// Token: 0x0600CDB1 RID: 52657 RVA: 0x002ED756 File Offset: 0x002EB956
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600CDB2 RID: 52658 RVA: 0x002ED758 File Offset: 0x002EB958
	protected virtual void OnTick(float deltaTime)
	{
	}

	// Token: 0x0600CDB3 RID: 52659 RVA: 0x002ED75A File Offset: 0x002EB95A
	protected virtual void OnEnd()
	{
	}

	// Token: 0x04005E4F RID: 24143
	[StaticVariableRuleIgnore]
	public static int Id;

	// Token: 0x04005E50 RID: 24144
	protected bool NeedTick;

	// Token: 0x04005E51 RID: 24145
	[Nullable(2)]
	protected FloroRanchEntityBase OwnerEntity;
}
