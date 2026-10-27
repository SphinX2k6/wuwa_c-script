using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Util
{
	// Token: 0x020048CC RID: 18636
	[NullableContext(2)]
	[Nullable(0)]
	public class LongPressButton
	{
		// Token: 0x06030B7A RID: 199546 RVA: 0x00B4FBC4 File Offset: 0x00B4DDC4
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

		// Token: 0x06030B7B RID: 199547 RVA: 0x00B4FC5B File Offset: 0x00B4DE5B
		private void StartClick()
		{
			TimerSystem.GameplayTimeInstance.Resume(this.TimerId);
		}

		// Token: 0x06030B7C RID: 199548 RVA: 0x00B4FC6E File Offset: 0x00B4DE6E
		private void EndClick()
		{
			if (TimerSystem.GameplayTimeInstance.IsPause(this.TimerId))
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Pause(this.TimerId, null);
		}

		// Token: 0x06030B7D RID: 199549 RVA: 0x00B4FC95 File Offset: 0x00B4DE95
		public void OnDestroy()
		{
			this.Button.OnPointDownCallBack.Unbind();
			this.Button.OnPointUpCallBack.Unbind();
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
		}

		// Token: 0x0401A2B9 RID: 107193
		private const int SECOND_0_1 = 100;

		// Token: 0x0401A2BA RID: 107194
		private readonly TimerHandle TimerId;

		// Token: 0x0401A2BB RID: 107195
		private readonly UUIButtonComponent Button;
	}
}
