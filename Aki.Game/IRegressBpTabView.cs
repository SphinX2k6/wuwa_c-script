using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200147A RID: 5242
[NullableContext(1)]
public interface IRegressBpTabView
{
	// Token: 0x0600944B RID: 37963
	void RefreshView(bool playAnim = false);

	// Token: 0x0600944C RID: 37964
	void RefreshBtnClaimVisible(UUIItem uiItem);

	// Token: 0x0600944D RID: 37965
	void OnClickBtnClaimAll();
}
