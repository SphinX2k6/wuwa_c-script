using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200092E RID: 2350
[NullableContext(1)]
public interface IRegressBpTabView
{
	// Token: 0x060067E0 RID: 26592
	void RefreshView(bool playAnim = false);

	// Token: 0x060067E1 RID: 26593
	void RefreshBtnClaimVisible(UUIItem uiItem);

	// Token: 0x060067E2 RID: 26594
	void OnClickBtnClaimAll();
}
