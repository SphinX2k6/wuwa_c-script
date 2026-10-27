using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02005275 RID: 21109
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleFloatTips : UiTickViewBase
	{
		// Token: 0x06035FE1 RID: 221153 RVA: 0x00CC6FF8 File Offset: 0x00CC51F8
		public PhantomArenaBattleFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035FE2 RID: 221154 RVA: 0x00CC7022 File Offset: 0x00CC5222
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035FE3 RID: 221155 RVA: 0x00CC705C File Offset: 0x00CC525C
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

		// Token: 0x06035FE4 RID: 221156 RVA: 0x00CC70B4 File Offset: 0x00CC52B4
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

		// Token: 0x06035FE5 RID: 221157 RVA: 0x00CC717F File Offset: 0x00CC537F
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

		// Token: 0x0401C973 RID: 117107
		private float CurrentTime;

		// Token: 0x0401C974 RID: 117108
		private string Millisecond = "";

		// Token: 0x0401C975 RID: 117109
		private string MinuteText = "";

		// Token: 0x0401C976 RID: 117110
		private string SecondText = "";

		// Token: 0x0200B477 RID: 46199
		[NullableContext(0)]
		private class EDefine
		{
			// Token: 0x04036AD2 RID: 223954
			public const int MainTextItem = 0;

			// Token: 0x04036AD3 RID: 223955
			public const int ExtraTextItem = 1;
		}
	}
}
