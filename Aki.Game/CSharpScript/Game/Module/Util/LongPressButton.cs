using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x02003843 RID: 14403
	[NullableContext(2)]
	[Nullable(0)]
	public class LongPressButton
	{
		// Token: 0x060256A6 RID: 153254 RVA: 0x00A8A9CC File Offset: 0x00A88BCC
		[NullableContext(1)]
		public LongPressButton(UUIButtonComponent button, Action<float> tickFn, int interval = 100)
		{
			button.OnPointDownCallBack.Bind(new Action(this.StartClick));
			button.OnPointUpCallBack.Bind(new Action(this.EndClick));
			button.OnPointExitCallBack.Bind(new Action(this.EndClick));
			this.Button = button;
			this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(tickFn.Invoke), (float)interval, 1f, null, null, true);
			TimerSystem.GameplayTimeInstance.Pause(this.TimerId, null);
		}

		// Token: 0x060256A7 RID: 153255 RVA: 0x00A8AA63 File Offset: 0x00A88C63
		private void StartClick()
		{
			TimerSystem.GameplayTimeInstance.Resume(this.TimerId);
		}

		// Token: 0x060256A8 RID: 153256 RVA: 0x00A8AA76 File Offset: 0x00A88C76
		private void EndClick()
		{
			if (TimerSystem.GameplayTimeInstance.IsPause(this.TimerId))
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Pause(this.TimerId, null);
		}

		// Token: 0x060256A9 RID: 153257 RVA: 0x00A8AA9D File Offset: 0x00A88C9D
		public void OnDestroy()
		{
			this.Button.OnPointDownCallBack.Unbind();
			this.Button.OnPointUpCallBack.Unbind();
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}

		// Token: 0x04014B2C RID: 84780
		private const int SECOND_0_1 = 100;

		// Token: 0x04014B2D RID: 84781
		private readonly TimerHandle TimerId;

		// Token: 0x04014B2E RID: 84782
		private readonly UUIButtonComponent Button;
	}
}
