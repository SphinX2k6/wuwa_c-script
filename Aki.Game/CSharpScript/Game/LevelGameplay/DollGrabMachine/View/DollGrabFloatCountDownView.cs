using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006064 RID: 24676
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabFloatCountDownView : UiTickViewBase
	{
		// Token: 0x0603B3FD RID: 242685 RVA: 0x010C3E5E File Offset: 0x010C205E
		public DollGrabFloatCountDownView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B3FE RID: 242686 RVA: 0x010C3E88 File Offset: 0x010C2088
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

		// Token: 0x0603B3FF RID: 242687 RVA: 0x010C3EF4 File Offset: 0x010C20F4
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

		// Token: 0x0603B400 RID: 242688 RVA: 0x010C3F90 File Offset: 0x010C2190
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove<float>(EEventName.OnDollGrabMachineRemainingTimeAdd, new Action<float>(this.OnRemainingTimeAdd));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachinePause, new Action(this.OnDollGrabMachinePause));
			EventSystem.Instance.Remove(EEventName.OnDollGrabMachineResume, new Action(this.OnDollGrabMachineResume));
		}

		// Token: 0x0603B401 RID: 242689 RVA: 0x010C3FF4 File Offset: 0x010C21F4
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

		// Token: 0x0603B402 RID: 242690 RVA: 0x010C406C File Offset: 0x010C226C
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

		// Token: 0x0603B403 RID: 242691 RVA: 0x010C4184 File Offset: 0x010C2384
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

		// Token: 0x0603B404 RID: 242692 RVA: 0x010C41E3 File Offset: 0x010C23E3
		private void OnRemainingTimeAdd(float num)
		{
			this.CurrentTime = DollGrabMachineController.Instance.RemainingTime / 1000f;
		}

		// Token: 0x0603B405 RID: 242693 RVA: 0x010C41FB File Offset: 0x010C23FB
		private void OnDollGrabMachinePause()
		{
			this.IsPaused = true;
		}

		// Token: 0x0603B406 RID: 242694 RVA: 0x010C4204 File Offset: 0x010C2404
		private void OnDollGrabMachineResume()
		{
			this.IsPaused = false;
		}

		// Token: 0x0401F2F0 RID: 127728
		private float CurrentTime;

		// Token: 0x0401F2F1 RID: 127729
		private string Millisecond = "";

		// Token: 0x0401F2F2 RID: 127730
		private string MinuteText = "";

		// Token: 0x0401F2F3 RID: 127731
		private string SecondText = "";

		// Token: 0x0401F2F4 RID: 127732
		private bool IsPaused;
	}
}
