using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x02007231 RID: 29233
	public class BulletCasterUtils
	{
		// Token: 0x06047A5B RID: 293467 RVA: 0x01255390 File Offset: 0x01253590
		[NullableContext(1)]
		public static void SetTimerHandleTimeDilation(TimerHandle timerHandle, float timeDilation)
		{
			if (!timerHandle.Valid())
			{
				return;
			}
			if (timeDilation == 0f)
			{
				if (!timerHandle.IsPause())
				{
					timerHandle.Pause();
					return;
				}
			}
			else if (timeDilation > 0f)
			{
				if (timerHandle.IsPause())
				{
					timerHandle.Resume();
				}
				timerHandle.ChangeDilation(timeDilation);
			}
		}
	}
}
