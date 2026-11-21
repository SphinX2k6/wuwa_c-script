using System;
using System.Runtime.CompilerServices;

// Token: 0x02000361 RID: 865
public class PinballBattlePlayerHpHandle
{
	// Token: 0x06003057 RID: 12375 RVA: 0x001190B2 File Offset: 0x001172B2
	public void Init()
	{
		this.IsInit = true;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x001190BB File Offset: 0x001172BB
	[NullableContext(1)]
	public void OnPlayerHpChange(KscHeadStateData kscPlayerHeadStateData)
	{
		bool isInit = this.IsInit;
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x001190C4 File Offset: 0x001172C4
	public void Clear()
	{
		this.IsInit = false;
	}

	// Token: 0x04002AEE RID: 10990
	private bool IsInit;
}
