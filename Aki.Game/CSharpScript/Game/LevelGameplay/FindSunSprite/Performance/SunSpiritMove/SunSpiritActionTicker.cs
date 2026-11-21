using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common.GameplayAction;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02005FDA RID: 24538
	public class SunSpiritActionTicker : GameplayActionTicker
	{
		// Token: 0x0603AF25 RID: 241445 RVA: 0x010A86D0 File Offset: 0x010A68D0
		[NullableContext(1)]
		public override void PushAction(GameplayAction action)
		{
			base.PushAction(action);
			if (this.ActionList.Count > 0 && this.MoveTimer == null)
			{
				this.MoveTimer = TimerSystem.Instance.Forever(new TTimerAction(this.TickAction), 20f, 1f, null, null, true);
			}
		}

		// Token: 0x0603AF26 RID: 241446 RVA: 0x010A8724 File Offset: 0x010A6924
		public override void TickAction(float delta)
		{
			base.TickAction(delta);
			if (this.ActionList.Count <= 0)
			{
				TimerHandle moveTimer = this.MoveTimer;
				if (moveTimer != null)
				{
					moveTimer.Remove();
				}
				this.MoveTimer = null;
			}
		}

		// Token: 0x0603AF27 RID: 241447 RVA: 0x010A8754 File Offset: 0x010A6954
		public override void Clear()
		{
			base.Clear();
			TimerHandle moveTimer = this.MoveTimer;
			if (moveTimer != null)
			{
				moveTimer.Remove();
			}
			this.MoveTimer = null;
		}

		// Token: 0x0401EFE3 RID: 126947
		[Nullable(2)]
		private TimerHandle MoveTimer;
	}
}
