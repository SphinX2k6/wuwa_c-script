using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020013F0 RID: 5104
[NullableContext(1)]
public interface IPinballChapterItem
{
	// Token: 0x0600902E RID: 36910
	void SetGray(bool isSetGray);

	// Token: 0x0600902F RID: 36911
	void Refresh(PinballChapterData data);

	// Token: 0x06009030 RID: 36912
	UniTask PlayUnlockTweenAsync();
}
