using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE6 RID: 7142
[NullableContext(1)]
public interface IRoleSlotView
{
	// Token: 0x0600D4AC RID: 54444
	void Refresh(IRoleSlotDisplayData data);

	// Token: 0x0600D4AD RID: 54445
	void ResetRole();

	// Token: 0x0600D4AE RID: 54446
	void BindOnSelectRole(Action<int> cb);

	// Token: 0x0600D4AF RID: 54447
	int? GetPlayer();

	// Token: 0x0600D4B0 RID: 54448
	int? GetConfigId();

	// Token: 0x0600D4B1 RID: 54449
	int? GetOnlineIndex();
}
