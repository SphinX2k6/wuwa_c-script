using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x02003FD8 RID: 16344
	public class PlotPhotoTipsView : PlotTipsViewBase
	{
		// Token: 0x060295B5 RID: 169397 RVA: 0x00BA4F7F File Offset: 0x00BA317F
		public PlotPhotoTipsView()
		{
			this.ResourceId = "UiView_PhotoTips_Prefab";
		}

		// Token: 0x060295B6 RID: 169398 RVA: 0x00BA4F94 File Offset: 0x00BA3194
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

		// Token: 0x060295B7 RID: 169399 RVA: 0x00BA4FFD File Offset: 0x00BA31FD
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(0);
			this.SubtitleItem = base.GetText(1);
		}

		// Token: 0x060295B8 RID: 169400 RVA: 0x00BA5019 File Offset: 0x00BA3219
		[NullableContext(2)]
		protected override UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetLayerRootUiItem(ELayerType.BattleFloat);
		}

		// Token: 0x02009B79 RID: 39801
		private static class EChildCom
		{
			// Token: 0x040306E6 RID: 198374
			public const int Icon = 0;

			// Token: 0x040306E7 RID: 198375
			public const int Text = 1;
		}
	}
}
