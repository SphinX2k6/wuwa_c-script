using System;
using Cysharp.Threading.Tasks;

// Token: 0x02002023 RID: 8227
public interface IItemTipsUiProxy
{
	// Token: 0x06010201 RID: 66049
	void SetActive(bool visibility);

	// Token: 0x06010202 RID: 66050
	UniTask PlayCloseSequence();
}
