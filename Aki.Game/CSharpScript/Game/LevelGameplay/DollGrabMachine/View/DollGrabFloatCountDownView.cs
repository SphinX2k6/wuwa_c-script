using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006EE4 RID: 28388
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabFloatCountDownView : UiTickViewBase
	{
		// Token: 0x06045254 RID: 283220 RVA: 0x0111A0CE File Offset: 0x011182CE
		public DollGrabFloatCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045255 RID: 283221 RVA: 0x0111A0F8 File Offset: 0x011182F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06045256 RID: 283222 RVA: 0x0111A164 File Offset: 0x01118364
		protected override void OnBeforeShow()
		{
			this.CurrentTime = DollGrabMachineController.Instance.RemainingTime / 1000f;
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffsetY(this.RootItem.GetAnchorOffsetY() + 50f);
			}
			EventSystem.Instance.Add<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnRemainingTimeAdd));
			EventSystem.Instance.Add(EEventName.OnDollGrabMachinePause, new Action(this.OnDollGrabMachinePause));
			EventSystem.Instance.Add(EEventName.OnDollGrabMachineResume, new Action(this.OnDollGrabMachineResume));
		}

		// Token: 0x06045257 RID: 283223 RVA: 0x0111A200 File Offset: 0x01118400
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnRemainingTimeAdd));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachinePause, new Action(this.OnDollGrabMachinePause));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachineResume, new Action(this.OnDollGrabMachineResume));
		}

		// Token: 0x06045258 RID: 283224 RVA: 0x0111A264 File Offset: 0x01118464
		protected override void OnTick(float delta)
		{
			if (TickSystem.Instance.IsPaused || this.IsPaused)
			{
				return;
			}
			this.CurrentTime -= delta * Time.Instance.TimeDilation / 1000f;
			this.CurrentTime = Math.Max(this.CurrentTime, 0f);
			this.UpdateCountDown();
			this.SetExtraText(this.MinuteText, this.SecondText, this.Millisecond);
		}

		// Token: 0x06045259 RID: 283225 RVA: 0x0111A2DC File Offset: 0x011184DC
		private void UpdateCountDown()
		{
			float currentTime = this.CurrentTime;
			double num = Math.Floor((double)currentTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num);
			this.MinuteText = defaultInterpolatedStringHandler.ToStringAndClear();
			double num2 = Math.Floor((double)currentTime % TimeUtil.Instance.Minute);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num2 < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num2);
			this.SecondText = defaultInterpolatedStringHandler.ToStringAndClear();
			double num3 = Math.Floor(((double)currentTime - Math.Floor((double)currentTime)) * 100.0);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num3 < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3);
			this.Millisecond = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0604525A RID: 283226 RVA: 0x0111A3F4 File Offset: 0x011185F4
		protected void SetExtraText(string minute, string second, string millionSecond)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(minute);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(second);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(millionSecond);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0604525B RID: 283227 RVA: 0x0111A453 File Offset: 0x01118653
		private void OnRemainingTimeAdd(float num)
		{
			this.CurrentTime = DollGrabMachineController.Instance.RemainingTime / 1000f;
		}

		// Token: 0x0604525C RID: 283228 RVA: 0x0111A46B File Offset: 0x0111866B
		private void OnDollGrabMachinePause()
		{
			this.IsPaused = true;
		}

		// Token: 0x0604525D RID: 283229 RVA: 0x0111A474 File Offset: 0x01118674
		private void OnDollGrabMachineResume()
		{
			this.IsPaused = false;
		}

		// Token: 0x0402403D RID: 147517
		private float CurrentTime;

		// Token: 0x0402403E RID: 147518
		private string Millisecond = "";

		// Token: 0x0402403F RID: 147519
		private string MinuteText = "";

		// Token: 0x04024040 RID: 147520
		private string SecondText = "";

		// Token: 0x04024041 RID: 147521
		private bool IsPaused;
	}
}
