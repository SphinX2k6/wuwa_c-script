using System;
using Cysharp.Threading.Tasks;

// Token: 0x020014F6 RID: 5366
public interface IItemTipsUiProxy
{
	// Token: 0x0600D669 RID: 54889
	void SetActive(bool visibility);

	// Token: 0x0600D66A RID: 54890
	UniTask PlayCloseSequence();
}
