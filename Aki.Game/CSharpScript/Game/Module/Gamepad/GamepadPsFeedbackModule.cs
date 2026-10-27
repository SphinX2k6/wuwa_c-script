using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020059F4 RID: 23028
	public class GamepadPsFeedbackModule
	{
		// Token: 0x0603A5F3 RID: 239091 RVA: 0x00DE3DDD File Offset: 0x00DE1FDD
		private void CancelAsyncLoad()
		{
			if (this.CurrentResourceId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.CurrentResourceId);
			}
		}

		// Token: 0x0603A5F4 RID: 239092 RVA: 0x00DE3DF8 File Offset: 0x00DE1FF8
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

		// Token: 0x0603A5F5 RID: 239093 RVA: 0x00DE3E4B File Offset: 0x00DE204B
		public void StopFeedback()
		{
			this.CancelAsyncLoad();
			UTriggerEffectBPLibrary.TriggerEffectSetOffMode(Global.PlayerController, ETriggerEffectSide.Both, ETriggerEffectControllerType.DualSense);
		}

		// Token: 0x0603A5F6 RID: 239094 RVA: 0x00DE3E5F File Offset: 0x00DE205F
		public void Clear()
		{
			this.CancelAsyncLoad();
			UTriggerEffectBPLibrary.TriggerEffectSetOffMode(Global.PlayerController, ETriggerEffectSide.Both, ETriggerEffectControllerType.DualSense);
		}

		// Token: 0x0401E6D8 RID: 124632
		private int CurrentResourceId = -1;
	}
}
