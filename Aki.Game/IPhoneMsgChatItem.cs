using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002504 RID: 9476
[NullableContext(2)]
public interface IPhoneMsgChatItem
{
	// Token: 0x06013133 RID: 78131
	UniTask PlayVoicePlayingAnimationAsync();

	// Token: 0x06013134 RID: 78132
	UniTask ShowVoiceTextPanel(Action afterShow = null);

	// Token: 0x06013135 RID: 78133
	void SkipVoicePlayingAnimation();

	// Token: 0x06013136 RID: 78134
	void StopVoicePlayingAnimation();
}
