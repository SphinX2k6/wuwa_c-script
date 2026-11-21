using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02004003 RID: 16387
	[NullableContext(1)]
	[Nullable(0)]
	public class CacheDialogueData
	{
		// Token: 0x060297C8 RID: 169928 RVA: 0x00BB56C4 File Offset: 0x00BB38C4
		public CacheDialogueData(bool show, string dialogueId, float guardTime, float audioDelay, float audioTransitionDuration, ELanguageAudio languageAudio, float autoPlayDelay, TArray<int> unisonIdList)
		{
			this.Show = show;
			this.DialogueId = dialogueId;
			this.GuardTime = guardTime;
			this.AudioDelay = audioDelay;
			this.AudioTransitionDuration = audioTransitionDuration;
			this.LanguageAudio = languageAudio;
			this.AutoPlayDelay = autoPlayDelay;
			this.UnisonIdList = unisonIdList;
		}

		// Token: 0x04016A24 RID: 92708
		public readonly bool Show;

		// Token: 0x04016A25 RID: 92709
		public readonly string DialogueId;

		// Token: 0x04016A26 RID: 92710
		public readonly float GuardTime;

		// Token: 0x04016A27 RID: 92711
		public readonly float AudioDelay;

		// Token: 0x04016A28 RID: 92712
		public readonly float AudioTransitionDuration;

		// Token: 0x04016A29 RID: 92713
		public readonly ELanguageAudio LanguageAudio;

		// Token: 0x04016A2A RID: 92714
		public readonly float AutoPlayDelay;

		// Token: 0x04016A2B RID: 92715
		public readonly TArray<int> UnisonIdList;
	}
}
