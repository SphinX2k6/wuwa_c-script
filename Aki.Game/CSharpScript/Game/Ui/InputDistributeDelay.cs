using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004677 RID: 18039
	[NullableContext(1)]
	[Nullable(0)]
	public class InputDistributeDelay
	{
		// Token: 0x0602E8F1 RID: 190705 RVA: 0x00AC72D2 File Offset: 0x00AC54D2
		public InputDistributeDelay()
		{
			this.InputPressTimeStampQueue = new Queue<double>(4);
			this.InputReleaseTimeStampQueue = new Queue<double>(4);
		}

		// Token: 0x0602E8F2 RID: 190706 RVA: 0x00AC72F2 File Offset: 0x00AC54F2
		public void StartDelay(float delayTime, bool bPress)
		{
			if (bPress)
			{
				this.InputPressTimeStampQueue.Push(Time.Instance.Now + (double)delayTime);
				return;
			}
			this.InputReleaseTimeStampQueue.Push(Time.Instance.Now + (double)delayTime);
		}

		// Token: 0x0602E8F3 RID: 190707 RVA: 0x00AC7328 File Offset: 0x00AC5528
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

		// Token: 0x0602E8F4 RID: 190708 RVA: 0x00AC737A File Offset: 0x00AC557A
		public bool CheckCondition(string actionName, bool bPress)
		{
			return actionName == "通用交互" && !UiManager.Instance.IsViewCreating(EUiViewName.InteractionHintView) && !UiManager.Instance.IsViewDestroying(EUiViewName.InteractionHintView);
		}

		// Token: 0x0401951F RID: 103711
		[StaticVariableRuleIgnore]
		public static readonly string[] delayInput = new string[]
		{
			"通用交互"
		};

		// Token: 0x04019520 RID: 103712
		private readonly Queue<double> InputPressTimeStampQueue;

		// Token: 0x04019521 RID: 103713
		private readonly Queue<double> InputReleaseTimeStampQueue;
	}
}
