using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F1 RID: 24817
	public class RoverlikeDialogLogic
	{
		// Token: 0x0603EC1A RID: 257050 RVA: 0x00F28E3C File Offset: 0x00F2703C
		[NullableContext(1)]
		public void PlayAudio(string eventPath, [Nullable(2)] Action finishCallback = null)
		{
			RoverlikeDialogLogic.<>c__DisplayClass3_0 CS$<>8__locals1 = new RoverlikeDialogLogic.<>c__DisplayClass3_0();
			CS$<>8__locals1.<>4__this = this;
			this.Stop();
			string text = AudioSystem.Instance.parseAudioEventPath(eventPath);
			if (text == null)
			{
				if (finishCallback != null)
				{
					finishCallback();
				}
				return;
			}
			RoverlikeDialogLogic.<>c__DisplayClass3_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.PlayVersion + 1;
			this.PlayVersion = num;
			CS$<>8__locals2.currentVersion = num;
			this.FinishCallback = finishCallback;
			FTransformDouble? target = null;
			this.PlayEventResult = AudioSystem.Instance.PostEvent(text, target, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
				{
					if (callbackType == EAkCallbackType.EndOfEvent)
					{
						CS$<>8__locals1.<>4__this.OnFinish(CS$<>8__locals1.currentVersion);
					}
				}
			}));
		}

		// Token: 0x0603EC1B RID: 257051 RVA: 0x00F28EDC File Offset: 0x00F270DC
		public void Stop()
		{
			this.PlayVersion++;
			if (this.PlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs(new int?(0), null, null)));
				this.PlayEventResult = 0;
			}
			this.FinishCallback = null;
		}

		// Token: 0x0603EC1C RID: 257052 RVA: 0x00F28F38 File Offset: 0x00F27138
		private void OnFinish(int version)
		{
			if (version != this.PlayVersion)
			{
				return;
			}
			this.PlayEventResult = 0;
			Action finishCallback = this.FinishCallback;
			this.FinishCallback = null;
			if (finishCallback == null)
			{
				return;
			}
			finishCallback();
		}

		// Token: 0x04020CB9 RID: 134329
		private int PlayEventResult;

		// Token: 0x04020CBA RID: 134330
		[Nullable(2)]
		private Action FinishCallback;

		// Token: 0x04020CBB RID: 134331
		private int PlayVersion;
	}
}
