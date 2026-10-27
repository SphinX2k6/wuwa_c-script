using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.Common.GameplayAction;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02006E59 RID: 28249
	public class SunSpiritActionTicker : GameplayActionTicker
	{
		// Token: 0x06044D98 RID: 282008 RVA: 0x010FE170 File Offset: 0x010FC370
		[NullableContext(1)]
		public override void PushAction(GameplayAction action)
		{
			base.PushAction(action);
			if (this.ActionList.Count > 0 && this.MoveTimer == null)
			{
				this.MoveTimer = TimerSystem.Instance.Forever(new TTimerAction(this.TickAction), 20f, 1f, null, null, true);
			}
		}

		// Token: 0x06044D99 RID: 282009 RVA: 0x010FE1C4 File Offset: 0x010FC3C4
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

		// Token: 0x06044D9A RID: 282010 RVA: 0x010FE1F4 File Offset: 0x010FC3F4
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

		// Token: 0x04023D2E RID: 146734
		[Nullable(2)]
		private TimerHandle MoveTimer;
	}
}
