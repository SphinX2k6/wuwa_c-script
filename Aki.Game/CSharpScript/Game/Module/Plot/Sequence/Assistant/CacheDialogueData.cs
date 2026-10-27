using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Assistant
{
	// Token: 0x02005036 RID: 20534
	[NullableContext(1)]
	[Nullable(0)]
	public class CacheDialogueData
	{
		// Token: 0x0603490A RID: 215306 RVA: 0x00C69234 File Offset: 0x00C67434
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

		// Token: 0x0401C019 RID: 114713
		public readonly bool Show;

		// Token: 0x0401C01A RID: 114714
		public readonly string DialogueId;

		// Token: 0x0401C01B RID: 114715
		public readonly float GuardTime;

		// Token: 0x0401C01C RID: 114716
		public readonly float AudioDelay;

		// Token: 0x0401C01D RID: 114717
		public readonly float AudioTransitionDuration;

		// Token: 0x0401C01E RID: 114718
		public readonly ELanguageAudio LanguageAudio;

		// Token: 0x0401C01F RID: 114719
		public readonly float AutoPlayDelay;

		// Token: 0x0401C020 RID: 114720
		public readonly TArray<int> UnisonIdList;
	}
}
