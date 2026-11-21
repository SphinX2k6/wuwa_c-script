using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x0200078E RID: 1934
[NullableContext(2)]
public interface IMapTravelSubViewInterface
{
	// Token: 0x17000B95 RID: 2965
	// (get) Token: 0x060058B1 RID: 22705
	// (set) Token: 0x060058B2 RID: 22706
	bool NeedDestroySelf { get; set; }

	// Token: 0x060058B3 RID: 22707
	void SetActive(bool visibility);

	// Token: 0x060058B4 RID: 22708
	void Destroy(Action callback = null);

	// Token: 0x060058B5 RID: 22709
	UniTask PlayStartSequence();

	// Token: 0x060058B6 RID: 22710
	UniTask PlayCloseSequence();
}
