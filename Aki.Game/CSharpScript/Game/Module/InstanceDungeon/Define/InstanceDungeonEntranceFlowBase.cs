using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048AF RID: 18607
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceFlowBase
	{
		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x0602EBC5 RID: 191429 RVA: 0x00D09527 File Offset: 0x00D07727
		private bool IsFinish
		{
			get
			{
				return this.CurrentStep > 0 && this.CurrentStep >= this.StepArray.Count;
			}
		}

		// Token: 0x0602EBC6 RID: 191430 RVA: 0x00D0954A File Offset: 0x00D0774A
		public InstanceDungeonEntranceFlowBase()
		{
			this.OnCreate();
		}

		// Token: 0x0602EBC7 RID: 191431 RVA: 0x00D0956C File Offset: 0x00D0776C
		private void DoNextStep()
		{
			this.CurrentStep++;
			if (this.CurrentStep < 0 || this.CurrentStep >= this.StepArray.Count)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InstanceDungeon;
				ELogAuthor author = ELogAuthor.TL;
				string message = "副本进入流程执行失败，当前步数与总步数不匹配！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentStep", this.CurrentStep);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.StepArray[this.CurrentStep]();
		}

		// Token: 0x0602EBC8 RID: 191432 RVA: 0x00D095EB File Offset: 0x00D077EB
		public void Reset()
		{
			this.CurrentStep = -1;
		}

		// Token: 0x0602EBC9 RID: 191433 RVA: 0x00D095F4 File Offset: 0x00D077F4
		public void ResetToBeforeLast()
		{
			this.CurrentStep = this.StepArray.Count - 2;
		}

		// Token: 0x0602EBCA RID: 191434 RVA: 0x00D09609 File Offset: 0x00D07809
		public void Start()
		{
			this.Reset();
			this.DoNextStep();
		}

		// Token: 0x0602EBCB RID: 191435 RVA: 0x00D09617 File Offset: 0x00D07817
		public void Flow()
		{
			if (this.IsFinish)
			{
				return;
			}
			this.DoNextStep();
		}

		// Token: 0x0602EBCC RID: 191436 RVA: 0x00D09628 File Offset: 0x00D07828
		public void RevertStep()
		{
			if (this.IsFinish)
			{
				return;
			}
			this.CurrentStep--;
		}

		// Token: 0x0602EBCD RID: 191437 RVA: 0x00D09641 File Offset: 0x00D07841
		public void OnEditBattleViewClose()
		{
			this.OnEditBattleViewCloseCall();
		}

		// Token: 0x0602EBCE RID: 191438 RVA: 0x00D09649 File Offset: 0x00D07849
		protected void AddStep(Action step)
		{
			this.StepArray.Add(step);
		}

		// Token: 0x0602EBCF RID: 191439 RVA: 0x00D09657 File Offset: 0x00D07857
		protected virtual void OnCreate()
		{
		}

		// Token: 0x0602EBD0 RID: 191440 RVA: 0x00D09659 File Offset: 0x00D07859
		protected virtual void OnEditBattleViewCloseCall()
		{
		}

		// Token: 0x04018D61 RID: 101729
		private readonly List<Action> StepArray = new List<Action>();

		// Token: 0x04018D62 RID: 101730
		private int CurrentStep = -1;
	}
}
