using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A8 RID: 13736
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeDelay
	{
		// Token: 0x0602303B RID: 143419 RVA: 0x009F4E32 File Offset: 0x009F3032
		public InputDistributeDelay()
		{
			this.InputPressTimeStampQueue = new Queue<double>(4);
			this.InputReleaseTimeStampQueue = new Queue<double>(4);
		}

		// Token: 0x0602303C RID: 143420 RVA: 0x009F4E52 File Offset: 0x009F3052
		public void StartDelay(float delayTime, bool bPress)
		{
			if (bPress)
			{
				this.InputPressTimeStampQueue.Push(Time.Instance.Now + (double)delayTime);
				return;
			}
			this.InputReleaseTimeStampQueue.Push(Time.Instance.Now + (double)delayTime);
		}

		// Token: 0x0602303D RID: 143421 RVA: 0x009F4E88 File Offset: 0x009F3088
		public bool IsInputActive(bool bPress)
		{
			Queue<double> queue;
			if (bPress)
			{
				queue = this.InputPressTimeStampQueue;
			}
			else
			{
				queue = this.InputReleaseTimeStampQueue;
			}
			double now = Time.Instance.Now;
			while (queue.Size > 0)
			{
				if (now < queue.Front)
				{
					queue.Pop();
					return true;
				}
				queue.Pop();
			}
			return false;
		}

		// Token: 0x0602303E RID: 143422 RVA: 0x009F4EDA File Offset: 0x009F30DA
		public bool CheckCondition(string actionName, bool bPress)
		{
			return actionName == "通用交互" && !UiManager.Instance.IsViewCreating(EUiViewName.InteractionHintView) && !UiManager.Instance.IsViewDestroying(EUiViewName.InteractionHintView);
		}

		// Token: 0x04013BC6 RID: 80838
		[StaticVariableRuleIgnore]
		public static readonly string[] delayInput = new string[]
		{
			"通用交互"
		};

		// Token: 0x04013BC7 RID: 80839
		private readonly Queue<double> InputPressTimeStampQueue;

		// Token: 0x04013BC8 RID: 80840
		private readonly Queue<double> InputReleaseTimeStampQueue;
	}
}
