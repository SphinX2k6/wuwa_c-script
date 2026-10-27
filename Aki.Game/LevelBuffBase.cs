using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FA6 RID: 12198
[NullableContext(1)]
[Nullable(0)]
public class LevelBuffBase
{
	// Token: 0x06019DF1 RID: 105969 RVA: 0x006C3638 File Offset: 0x006C1838
	public LevelBuffBase(Entity entity, long buffId, string[] @params, float param1, float param2)
	{
		this.Entity = entity;
		this.BuffId = buffId;
		this.Params = @params;
		this.Param1 = param1;
		this.Param2 = param2;
	}

	// Token: 0x06019DF2 RID: 105970 RVA: 0x006C3665 File Offset: 0x006C1865
	public virtual void OnCreated()
	{
	}

	// Token: 0x06019DF3 RID: 105971 RVA: 0x006C3667 File Offset: 0x006C1867
	public virtual void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06019DF4 RID: 105972 RVA: 0x006C3669 File Offset: 0x006C1869
	public virtual void OnStackChanged(int newCount, int oldCount, bool bPremature)
	{
	}

	// Token: 0x0400C397 RID: 50071
	protected readonly Entity Entity;

	// Token: 0x0400C398 RID: 50072
	protected readonly long BuffId;

	// Token: 0x0400C399 RID: 50073
	protected readonly string[] Params;

	// Token: 0x0400C39A RID: 50074
	protected readonly float Param1;

	// Token: 0x0400C39B RID: 50075
	protected readonly float Param2;
}
