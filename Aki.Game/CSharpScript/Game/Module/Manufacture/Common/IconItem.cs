using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200569B RID: 22171
	public class IconItem : UiPanelBase
	{
		// Token: 0x060386B4 RID: 231092 RVA: 0x00D64ECF File Offset: 0x00D630CF
		[NullableContext(1)]
		public IconItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060386B5 RID: 231093 RVA: 0x00D64EE4 File Offset: 0x00D630E4
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

		// Token: 0x060386B6 RID: 231094 RVA: 0x00D64F50 File Offset: 0x00D63150
		public void SetIcon(int itemId)
		{
			base.SetItemIcon(base.GetTexture(3), itemId, null, null);
		}

		// Token: 0x060386B7 RID: 231095 RVA: 0x00D64F78 File Offset: 0x00D63178
		public void SetQuality(int itemId)
		{
			base.SetItemQualityIcon(base.GetSprite(4), itemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x0200B85F RID: 47199
		private class EIconItemDefine
		{
			// Token: 0x04037CE0 RID: 228576
			public const int IconTexture = 3;

			// Token: 0x04037CE1 RID: 228577
			public const int QualitySprite = 4;
		}
	}
}
