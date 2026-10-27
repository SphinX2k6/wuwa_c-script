using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063FD RID: 25597
	public class MotorParkourTimerView : UiTickViewBase
	{
		// Token: 0x06040600 RID: 263680 RVA: 0x00F92AAA File Offset: 0x00F90CAA
		[NullableContext(1)]
		public MotorParkourTimerView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040601 RID: 263681 RVA: 0x00F92AB4 File Offset: 0x00F90CB4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040602 RID: 263682 RVA: 0x00F92AFC File Offset: 0x00F90CFC
		protected override void OnStart()
		{
			this.StartFlowTime = (long)this.OpenParam;
		}

		// Token: 0x06040603 RID: 263683 RVA: 0x00F92B10 File Offset: 0x00F90D10
		protected override void OnTick(float delta)
		{
			if (this.StartFlowTime == 0L)
			{
				return;
			}
			double num = (TimeUtil.Instance.GetServerStopTimeStamp() - (double)this.StartFlowTime) * TimeUtil.Instance.Millisecond;
			if (Time.Instance.FlowTimeDilation == 0f)
			{
				return;
			}
			int num2 = (int)Math.Floor(num % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num2 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			string value = defaultInterpolatedStringHandler.ToStringAndClear();
			int num3 = (int)Math.Floor(num % TimeUtil.Instance.Minute);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num3 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
			string value2 = defaultInterpolatedStringHandler.ToStringAndClear();
			int num4 = (int)Math.Floor((num - Math.Floor(num)) * 100.0);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num4 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
			string value3 = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x040217B4 RID: 137140
		private const int ONE_HUNDRED = 100;

		// Token: 0x040217B5 RID: 137141
		private long StartFlowTime;

		// Token: 0x0200C623 RID: 50723
		private class EComponent
		{
			// Token: 0x0403BD1F RID: 245023
			public const int TextTime = 0;
		}
	}
}
