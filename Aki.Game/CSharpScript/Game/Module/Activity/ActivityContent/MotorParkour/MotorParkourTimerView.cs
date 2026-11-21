using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x0200537B RID: 21371
	public class MotorParkourTimerView : UiTickViewBase
	{
		// Token: 0x060352C1 RID: 217793 RVA: 0x00ED9A8B File Offset: 0x00ED7C8B
		[NullableContext(1)]
		public MotorParkourTimerView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060352C2 RID: 217794 RVA: 0x00ED9A94 File Offset: 0x00ED7C94
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

		// Token: 0x060352C3 RID: 217795 RVA: 0x00ED9ADC File Offset: 0x00ED7CDC
		protected override void OnStart()
		{
			this.StartFlowTime = (long)this.OpenParam;
		}

		// Token: 0x060352C4 RID: 217796 RVA: 0x00ED9AF0 File Offset: 0x00ED7CF0
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

		// Token: 0x0401C0E3 RID: 114915
		private const int ONE_HUNDRED = 100;

		// Token: 0x0401C0E4 RID: 114916
		private long StartFlowTime;

		// Token: 0x0200B00A RID: 45066
		private class EComponent
		{
			// Token: 0x0403667E RID: 222846
			public const int TextTime = 0;
		}
	}
}
