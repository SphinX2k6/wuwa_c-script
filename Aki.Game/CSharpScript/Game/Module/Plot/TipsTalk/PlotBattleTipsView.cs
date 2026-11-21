using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x02003FD6 RID: 16342
	public class PlotBattleTipsView : PlotTipsViewBase
	{
		// Token: 0x060295A9 RID: 169385 RVA: 0x00BA4B92 File Offset: 0x00BA2D92
		public PlotBattleTipsView()
		{
			this.ResourceId = "UiView_BattleTips_Prefab";
			this.OverrideAudioEventName = "play_external_vo_subtitle_assist";
			this.OverrideAudioSrcName = "external_plot_voice_assist";
		}

		// Token: 0x060295AA RID: 169386 RVA: 0x00BA4BBC File Offset: 0x00BA2DBC
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

		// Token: 0x060295AB RID: 169387 RVA: 0x00BA4C67 File Offset: 0x00BA2E67
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(1);
			this.SubtitleItem = base.GetText(3);
			this.NameItem = base.GetText(2);
		}

		// Token: 0x060295AC RID: 169388 RVA: 0x00BA4C90 File Offset: 0x00BA2E90
		[NullableContext(2)]
		protected override UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetBattleViewUnit(3);
		}

		// Token: 0x02009B77 RID: 39799
		private static class EChildCom
		{
			// Token: 0x040306DE RID: 198366
			public const int Prefab = 0;

			// Token: 0x040306DF RID: 198367
			public const int Icon = 1;

			// Token: 0x040306E0 RID: 198368
			public const int Name = 2;

			// Token: 0x040306E1 RID: 198369
			public const int Text = 3;
		}
	}
}
