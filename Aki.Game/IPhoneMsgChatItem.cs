using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020019EB RID: 6635
[NullableContext(2)]
public interface IPhoneMsgChatItem
{
	// Token: 0x060105F2 RID: 67058
	UniTask PlayVoicePlayingAnimationAsync();

	// Token: 0x060105F3 RID: 67059
	UniTask ShowVoiceTextPanel(Action afterShow = null);

	// Token: 0x060105F4 RID: 67060
	void SkipVoicePlayingAnimation();

	// Token: 0x060105F5 RID: 67061
	void StopVoicePlayingAnimation();
}
