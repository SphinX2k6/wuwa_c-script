using System;

// Token: 0x020000B6 RID: 182
public abstract class ObjectBase
{
	// Token: 0x060005F8 RID: 1528 RVA: 0x0001F0E9 File Offset: 0x0001D2E9
	protected ObjectBase(int Id, int Index)
	{
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001F0FF File Offset: 0x0001D2FF
	public bool Valid
	{
		get
		{
			return ObjectSystem.Instance.IsValid(this);
		}
	}

	// Token: 0x040004AB RID: 1195
	public int Id = Id;

	// Token: 0x040004AC RID: 1196
	public int Index = Index;
}
