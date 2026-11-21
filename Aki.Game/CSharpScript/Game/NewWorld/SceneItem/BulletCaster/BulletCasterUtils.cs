using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E6 RID: 25318
	public class BulletCasterUtils
	{
		// Token: 0x0603D3BC RID: 250812 RVA: 0x011ADF28 File Offset: 0x011AC128
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
