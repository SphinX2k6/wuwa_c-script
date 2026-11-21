using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200506F RID: 20591
	public class RoverlikeDialogLogic
	{
		// Token: 0x060338DC RID: 211164 RVA: 0x00E6FC50 File Offset: 0x00E6DE50
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

		// Token: 0x060338DD RID: 211165 RVA: 0x00E6FCF0 File Offset: 0x00E6DEF0
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

		// Token: 0x060338DE RID: 211166 RVA: 0x00E6FD4C File Offset: 0x00E6DF4C
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

		// Token: 0x0401B5E6 RID: 112102
		private int PlayEventResult;

		// Token: 0x0401B5E7 RID: 112103
		[Nullable(2)]
		private Action FinishCallback;

		// Token: 0x0401B5E8 RID: 112104
		private int PlayVersion;
	}
}
