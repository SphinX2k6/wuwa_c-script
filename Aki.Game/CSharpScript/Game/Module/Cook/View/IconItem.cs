using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B14 RID: 23316
	public class IconItem : UiPanelBase
	{
		// Token: 0x0603B06D RID: 241773 RVA: 0x00E12562 File Offset: 0x00E10762
		[NullableContext(1)]
		public IconItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B06E RID: 241774 RVA: 0x00E12578 File Offset: 0x00E10778
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B06F RID: 241775 RVA: 0x00E125E4 File Offset: 0x00E107E4
		public void SetIcon(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x0603B070 RID: 241776 RVA: 0x00E1260C File Offset: 0x00E1080C
		public void SetQuality(int itemId)
		{
			base.SetItemQualityIcon(base.GetSprite(4), itemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0200BD4F RID: 48463
		private enum EIconItemDefine
		{
			// Token: 0x0403918A RID: 233866
			IconTexture = 3,
			// Token: 0x0403918B RID: 233867
			QualitySprite
		}
	}
}
