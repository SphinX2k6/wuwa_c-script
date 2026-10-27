using System;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x02006F32 RID: 28466
	public class WaitAction : GameplayAction
	{
		// Token: 0x17009B1F RID: 39711
		// (get) Token: 0x0604540D RID: 283661 RVA: 0x01122936 File Offset: 0x01120B36
		protected override bool NeedTickInner
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0604540E RID: 283662 RVA: 0x01122939 File Offset: 0x01120B39
		public void Init(float waitMillisecond)
		{
			this.WaitMillisecond = waitMillisecond;
		}

		// Token: 0x0604540F RID: 283663 RVA: 0x01122942 File Offset: 0x01120B42
		protected override void OnExecuteAction()
		{
		}

		// Token: 0x06045410 RID: 283664 RVA: 0x01122944 File Offset: 0x01120B44
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x06045411 RID: 283665 RVA: 0x01122946 File Offset: 0x01120B46
		public override void TickAction(float delta)
		{
			this.WaitMillisecond -= delta;
			if (this.WaitMillisecond <= 0f)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x040241B5 RID: 147893
		private float WaitMillisecond;
	}
}
