using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020008A4 RID: 2212
[NullableContext(1)]
public interface IPinballChapterItem
{
	// Token: 0x060063C3 RID: 25539
	void SetGray(bool isSetGray);

	// Token: 0x060063C4 RID: 25540
	void Refresh(PinballChapterData data);

	// Token: 0x060063C5 RID: 25541
	UniTask PlayUnlockTweenAsync();
}
