using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020049D0 RID: 18896
	public class GamepadPsFeedbackModule
	{
		// Token: 0x0602F53C RID: 193852 RVA: 0x00D3432D File Offset: 0x00D3252D
		private void CancelAsyncLoad()
		{
			if (this.CurrentResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.CurrentResourceId);
			}
		}

		// Token: 0x0602F53D RID: 193853 RVA: 0x00D34348 File Offset: 0x00D32548
		[NullableContext(1)]
		public UniTask PlayFeedback(ETriggerEffectSide mode, string path)
		{
			GamepadPsFeedbackModule.<PlayFeedback>d__2 <PlayFeedback>d__;
			<PlayFeedback>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayFeedback>d__.<>4__this = this;
			<PlayFeedback>d__.mode = mode;
			<PlayFeedback>d__.path = path;
			<PlayFeedback>d__.<>1__state = -1;
			<PlayFeedback>d__.<>t__builder.Start<GamepadPsFeedbackModule.<PlayFeedback>d__2>(ref <PlayFeedback>d__);
			return <PlayFeedback>d__.<>t__builder.Task;
		}

		// Token: 0x0602F53E RID: 193854 RVA: 0x00D3439B File Offset: 0x00D3259B
		public void StopFeedback()
		{
			this.CancelAsyncLoad();
			UTriggerEffectBPLibrary.TriggerEffectSetOffMode(Global.PlayerController, ETriggerEffectSide.Both, ETriggerEffectControllerType.DualSense);
		}

		// Token: 0x0602F53F RID: 193855 RVA: 0x00D343AF File Offset: 0x00D325AF
		public void Clear()
		{
			this.CancelAsyncLoad();
			UTriggerEffectBPLibrary.TriggerEffectSetOffMode(Global.PlayerController, ETriggerEffectSide.Both, ETriggerEffectControllerType.DualSense);
		}

		// Token: 0x0401917F RID: 102783
		private int CurrentResourceId = -1;
	}
}
