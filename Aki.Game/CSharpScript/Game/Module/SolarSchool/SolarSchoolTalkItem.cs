using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AC RID: 22956
	public class SolarSchoolTalkItem : UiPanelBase
	{
		// Token: 0x0603897D RID: 231805 RVA: 0x00FD5820 File Offset: 0x00FD3A20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603897E RID: 231806 RVA: 0x00FD58AA File Offset: 0x00FD3AAA
		[NullableContext(1)]
		public void Refresh(string content)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(content, true);
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0200B556 RID: 46422
		private class EComponents
		{
			// Token: 0x0403810C RID: 229644
			public const int TxtScroll = 0;

			// Token: 0x0403810D RID: 229645
			public const int TxtContent = 1;

			// Token: 0x0403810E RID: 229646
			public const int SprNext = 2;
		}
	}
}
