using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EAC RID: 3756
public class PinballBattlePlayerHpHandle
{
	// Token: 0x06005CC0 RID: 23744 RVA: 0x00111416 File Offset: 0x0010F616
	public void Init()
	{
		this.IsInit = true;
	}

	// Token: 0x06005CC1 RID: 23745 RVA: 0x0011141F File Offset: 0x0010F61F
	[NullableContext(1)]
	public void OnPlayerHpChange(KscHeadStateData kscPlayerHeadStateData)
	{
		bool isInit = this.IsInit;
	}

	// Token: 0x06005CC2 RID: 23746 RVA: 0x00111428 File Offset: 0x0010F628
	public void Clear()
	{
		this.IsInit = false;
	}

	// Token: 0x04002A53 RID: 10835
	private bool IsInit;
}
