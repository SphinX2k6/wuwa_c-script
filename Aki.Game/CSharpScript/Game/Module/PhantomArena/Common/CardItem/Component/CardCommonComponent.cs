using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B3 RID: 16819
	[NullableContext(1)]
	[Nullable(0)]
	public class CardCommonComponent : CardComponentBase
	{
		// Token: 0x0602A929 RID: 174377 RVA: 0x00C022F1 File Offset: 0x00C004F1
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602A92A RID: 174378 RVA: 0x00C0231B File Offset: 0x00C0051B
		protected override void OnDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602A92B RID: 174379 RVA: 0x00C02328 File Offset: 0x00C00528
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close".ToString())
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602A92C RID: 174380 RVA: 0x00C02343 File Offset: 0x00C00543
		public void SetComponentActive(bool isActive)
		{
			this.Sequence.StopPrevSequence(false, true);
			if (isActive)
			{
				this.SetActive(true);
				this.Sequence.PlaySequencePurely("Start", false, false);
				return;
			}
			this.Sequence.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x0602A92D RID: 174381 RVA: 0x00C02381 File Offset: 0x00C00581
		public void SetComponentDisActiveWithoutSequence()
		{
			this.SetActive(false);
		}

		// Token: 0x0602A92E RID: 174382 RVA: 0x00C0238A File Offset: 0x00C0058A
		public override void Refresh(object data)
		{
		}

		// Token: 0x0401719D RID: 94621
		protected UiSequencePlayer Sequence;
	}
}
