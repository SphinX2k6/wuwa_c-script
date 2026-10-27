using System;

// Token: 0x020000B4 RID: 180
public abstract class ObjectBase
{
	// Token: 0x060005B7 RID: 1463 RVA: 0x0001EA45 File Offset: 0x0001CC45
	protected ObjectBase(int Id, int Index)
	{
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001EA5B File Offset: 0x0001CC5B
	public bool Valid
	{
		get
		{
			return ObjectSystem.Instance.IsValid(this);
		}
	}

	// Token: 0x0400049D RID: 1181
	public int Id = Id;

	// Token: 0x0400049E RID: 1182
	public int Index = Index;
}
