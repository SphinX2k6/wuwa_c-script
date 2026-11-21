using System;
using System.Runtime.CompilerServices;

// Token: 0x020010A5 RID: 4261
[NullableContext(1)]
public interface IRoleSlotView
{
	// Token: 0x0600A8BE RID: 43198
	void Refresh(IRoleSlotDisplayData data);

	// Token: 0x0600A8BF RID: 43199
	void ResetRole();

	// Token: 0x0600A8C0 RID: 43200
	void BindOnSelectRole(Action<int> cb);

	// Token: 0x0600A8C1 RID: 43201
	int? GetPlayer();

	// Token: 0x0600A8C2 RID: 43202
	int? GetConfigId();

	// Token: 0x0600A8C3 RID: 43203
	int? GetOnlineIndex();
}
