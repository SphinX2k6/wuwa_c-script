using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005024 RID: 20516
	public class Spring25SharePanel : UiPanelBase
	{
		// Token: 0x0603357F RID: 210303 RVA: 0x00E64E80 File Offset: 0x00E63080
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033580 RID: 210304 RVA: 0x00E64F4C File Offset: 0x00E6314C
		protected override void OnStart()
		{
			Spring25ShareData spring25ShareData = this.OpenParam as Spring25ShareData;
			if (spring25ShareData == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetUIActive(false);
			}
			UUIText text3 = base.GetText(3);
			if (text3 != null)
			{
				text3.SetUIActive(false);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			base.SetTextureByPath(spring25ShareData.PhotoPath, base.GetTexture(0), null, null);
		}

		// Token: 0x0200ACF5 RID: 44277
		private static class EComponents
		{
			// Token: 0x040357C2 RID: 219074
			public const int Texture = 0;

			// Token: 0x040357C3 RID: 219075
			public const int Name = 1;

			// Token: 0x040357C4 RID: 219076
			public const int Time = 2;

			// Token: 0x040357C5 RID: 219077
			public const int Desc = 3;

			// Token: 0x040357C6 RID: 219078
			public const int LineItem = 4;
		}
	}
}
