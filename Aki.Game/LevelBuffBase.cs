using System;
using System.Runtime.CompilerServices;

// Token: 0x020024FA RID: 9466
[NullableContext(1)]
[Nullable(0)]
public class LevelBuffBase
{
	// Token: 0x06017703 RID: 96003 RVA: 0x006E9ED4 File Offset: 0x006E80D4
	public LevelBuffBase(Entity entity, long buffId, string[] @params, float param1, float param2)
	{
		this.Entity = entity;
		this.BuffId = buffId;
		this.Params = @params;
		this.Param1 = param1;
		this.Param2 = param2;
	}

	// Token: 0x06017704 RID: 96004 RVA: 0x006E9F01 File Offset: 0x006E8101
	public virtual void OnCreated()
	{
	}

	// Token: 0x06017705 RID: 96005 RVA: 0x006E9F03 File Offset: 0x006E8103
	public virtual void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06017706 RID: 96006 RVA: 0x006E9F05 File Offset: 0x006E8105
	public virtual void OnStackChanged(int newCount, int oldCount, bool bPremature)
	{
	}

	// Token: 0x0400C740 RID: 51008
	protected readonly Entity Entity;

	// Token: 0x0400C741 RID: 51009
	protected readonly long BuffId;

	// Token: 0x0400C742 RID: 51010
	protected readonly string[] Params;

	// Token: 0x0400C743 RID: 51011
	protected readonly float Param1;

	// Token: 0x0400C744 RID: 51012
	protected readonly float Param2;
}
