using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004245 RID: 16965
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleFloatTips : UiTickViewBase
	{
		// Token: 0x0602AEDC RID: 175836 RVA: 0x00C146F8 File Offset: 0x00C128F8
		public PhantomArenaBattleFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AEDD RID: 175837 RVA: 0x00C14722 File Offset: 0x00C12922
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AEDE RID: 175838 RVA: 0x00C1475C File Offset: 0x00C1295C
		protected override void OnTick(float delta)
		{
			if (TickSystem.Instance.IsPaused)
			{
				return;
			}
			this.CurrentTime += delta * Time.Instance.TimeDilation / 1000f;
			this.UpdateCountDown();
			this.SetExtraText(this.MinuteText, this.SecondText, this.Millisecond);
		}

		// Token: 0x0602AEDF RID: 175839 RVA: 0x00C147B4 File Offset: 0x00C129B4
		private void UpdateCountDown()
		{
			float currentTime = this.CurrentTime;
			int num = (int)Math.Floor((double)currentTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			this.MinuteText = ((num < 10) ? "0" : "") + num.ToString();
			int num2 = (int)Math.Floor((double)currentTime % TimeUtil.Instance.Minute);
			this.SecondText = ((num2 < 10) ? "0" : "") + num2.ToString();
			int num3 = (int)Math.Floor(((double)currentTime - Math.Floor((double)currentTime)) * 100.0);
			this.Millisecond = ((num3 < 10) ? "0" : "") + num3.ToString();
		}

		// Token: 0x0602AEE0 RID: 175840 RVA: 0x00C1487F File Offset: 0x00C12A7F
		protected void SetExtraText(string minute, string second, string millionSecond)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(string.Concat(new string[]
			{
				minute,
				":",
				second,
				":",
				millionSecond
			}), true);
		}

		// Token: 0x040173A8 RID: 95144
		private float CurrentTime;

		// Token: 0x040173A9 RID: 95145
		private string Millisecond = "";

		// Token: 0x040173AA RID: 95146
		private string MinuteText = "";

		// Token: 0x040173AB RID: 95147
		private string SecondText = "";

		// Token: 0x02009EAF RID: 40623
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x04031525 RID: 202021
			public const int MainTextItem = 0;

			// Token: 0x04031526 RID: 202022
			public const int ExtraTextItem = 1;
		}
	}
}
