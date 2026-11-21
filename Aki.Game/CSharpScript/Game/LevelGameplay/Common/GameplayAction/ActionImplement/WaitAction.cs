using System;

namespace CSharpScript.Game.LevelGamePlay.Common.GameplayAction.ActionImplement
{
	// Token: 0x020060B3 RID: 24755
	public class WaitAction : GameplayAction
	{
		// Token: 0x1700705E RID: 28766
		// (get) Token: 0x0603B5BB RID: 243131 RVA: 0x010CC8E2 File Offset: 0x010CAAE2
		protected override bool NeedTickInner
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603B5BC RID: 243132 RVA: 0x010CC8E5 File Offset: 0x010CAAE5
		public void Init(float waitMillisecond)
		{
			this.WaitMillisecond = waitMillisecond;
		}

		// Token: 0x0603B5BD RID: 243133 RVA: 0x010CC8EE File Offset: 0x010CAAEE
		protected override void OnExecuteAction()
		{
		}

		// Token: 0x0603B5BE RID: 243134 RVA: 0x010CC8F0 File Offset: 0x010CAAF0
		protected override void OnInterruptAction()
		{
		}

		// Token: 0x0603B5BF RID: 243135 RVA: 0x010CC8F2 File Offset: 0x010CAAF2
		public override void TickAction(float delta)
		{
			this.WaitMillisecond -= delta;
			if (this.WaitMillisecond <= 0f)
			{
				base.FinishExecute();
			}
		}

		// Token: 0x0401F46A RID: 128106
		private float WaitMillisecond;
	}
}
