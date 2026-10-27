using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058D7 RID: 22743
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceFlowBase
	{
		// Token: 0x17008AC3 RID: 35523
		// (get) Token: 0x06039CA2 RID: 236706 RVA: 0x00DBA60F File Offset: 0x00DB880F
		private bool IsFinish
		{
			get
			{
				return this.CurrentStep > 0 && this.CurrentStep >= this.StepArray.Count;
			}
		}

		// Token: 0x06039CA3 RID: 236707 RVA: 0x00DBA632 File Offset: 0x00DB8832
		public InstanceDungeonEntranceFlowBase()
		{
			this.OnCreate();
		}

		// Token: 0x06039CA4 RID: 236708 RVA: 0x00DBA654 File Offset: 0x00DB8854
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

		// Token: 0x06039CA5 RID: 236709 RVA: 0x00DBA6D3 File Offset: 0x00DB88D3
		public void Reset()
		{
			this.CurrentStep = -1;
		}

		// Token: 0x06039CA6 RID: 236710 RVA: 0x00DBA6DC File Offset: 0x00DB88DC
		public void ResetToBeforeLast()
		{
			this.CurrentStep = this.StepArray.Count - 2;
		}

		// Token: 0x06039CA7 RID: 236711 RVA: 0x00DBA6F1 File Offset: 0x00DB88F1
		public void Start()
		{
			this.Reset();
			this.DoNextStep();
		}

		// Token: 0x06039CA8 RID: 236712 RVA: 0x00DBA6FF File Offset: 0x00DB88FF
		public void Flow()
		{
			if (this.IsFinish)
			{
				return;
			}
			this.DoNextStep();
		}

		// Token: 0x06039CA9 RID: 236713 RVA: 0x00DBA710 File Offset: 0x00DB8910
		public void RevertStep()
		{
			if (this.IsFinish)
			{
				return;
			}
			this.CurrentStep--;
		}

		// Token: 0x06039CAA RID: 236714 RVA: 0x00DBA729 File Offset: 0x00DB8929
		public void OnEditBattleViewClose()
		{
			this.OnEditBattleViewCloseCall();
		}

		// Token: 0x06039CAB RID: 236715 RVA: 0x00DBA731 File Offset: 0x00DB8931
		protected void AddStep(Action step)
		{
			this.StepArray.Add(step);
		}

		// Token: 0x06039CAC RID: 236716 RVA: 0x00DBA73F File Offset: 0x00DB893F
		protected virtual void OnCreate()
		{
		}

		// Token: 0x06039CAD RID: 236717 RVA: 0x00DBA741 File Offset: 0x00DB8941
		protected virtual void OnEditBattleViewCloseCall()
		{
		}

		// Token: 0x0401E2C4 RID: 123588
		private readonly List<Action> StepArray = new List<Action>();

		// Token: 0x0401E2C5 RID: 123589
		private int CurrentStep = -1;
	}
}
