using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020012DA RID: 4826
[NullableContext(2)]
public interface IMapTravelSubViewInterface
{
	// Token: 0x17000B75 RID: 2933
	// (get) Token: 0x06008516 RID: 34070
	// (set) Token: 0x06008517 RID: 34071
	bool NeedDestroySelf { get; set; }

	// Token: 0x06008518 RID: 34072
	void SetActive(bool visibility);

	// Token: 0x06008519 RID: 34073
	void Destroy(Action callback = null);

	// Token: 0x0600851A RID: 34074
	UniTask PlayStartSequence();

	// Token: 0x0600851B RID: 34075
	UniTask PlayCloseSequence();
}
