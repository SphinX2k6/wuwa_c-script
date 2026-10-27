using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x0200500C RID: 20492
	public class PlotBattleTipsView : PlotTipsViewBase
	{
		// Token: 0x06034706 RID: 214790 RVA: 0x00C59692 File Offset: 0x00C57892
		public PlotBattleTipsView()
		{
			this.ResourceId = "UiView_BattleTips_Prefab";
			this.OverrideAudioEventName = "play_external_vo_subtitle_assist";
			this.OverrideAudioSrcName = "external_plot_voice_assist";
		}

		// Token: 0x06034707 RID: 214791 RVA: 0x00C596BC File Offset: 0x00C578BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034708 RID: 214792 RVA: 0x00C59767 File Offset: 0x00C57967
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(1);
			this.SubtitleItem = base.GetText(3);
			this.NameItem = base.GetText(2);
		}

		// Token: 0x06034709 RID: 214793 RVA: 0x00C59790 File Offset: 0x00C57990
		[NullableContext(2)]
		protected override UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetBattleViewUnit(3);
		}

		// Token: 0x0200B13F RID: 45375
		private static class EChildCom
		{
			// Token: 0x04035C96 RID: 220310
			public const int Prefab = 0;

			// Token: 0x04035C97 RID: 220311
			public const int Icon = 1;

			// Token: 0x04035C98 RID: 220312
			public const int Name = 2;

			// Token: 0x04035C99 RID: 220313
			public const int Text = 3;
		}
	}
}
