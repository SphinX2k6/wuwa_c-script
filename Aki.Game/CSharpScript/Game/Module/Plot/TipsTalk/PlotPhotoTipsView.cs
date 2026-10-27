using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x0200500E RID: 20494
	public class PlotPhotoTipsView : PlotTipsViewBase
	{
		// Token: 0x06034712 RID: 214802 RVA: 0x00C59A7F File Offset: 0x00C57C7F
		public PlotPhotoTipsView()
		{
			this.ResourceId = "UiView_PhotoTips_Prefab";
		}

		// Token: 0x06034713 RID: 214803 RVA: 0x00C59A94 File Offset: 0x00C57C94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034714 RID: 214804 RVA: 0x00C59AFD File Offset: 0x00C57CFD
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(0);
			this.SubtitleItem = base.GetText(1);
		}

		// Token: 0x06034715 RID: 214805 RVA: 0x00C59B19 File Offset: 0x00C57D19
		[NullableContext(2)]
		protected override UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetLayerRootUiItem(ELayerType.BattleFloat);
		}

		// Token: 0x0200B141 RID: 45377
		private static class EChildCom
		{
			// Token: 0x04035C9E RID: 220318
			public const int Icon = 0;

			// Token: 0x04035C9F RID: 220319
			public const int Text = 1;
		}
	}
}
