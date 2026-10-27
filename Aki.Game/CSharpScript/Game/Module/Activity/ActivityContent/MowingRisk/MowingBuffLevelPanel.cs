using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063D8 RID: 25560
	public class MowingBuffLevelPanel : UiPanelBase
	{
		// Token: 0x060404A3 RID: 263331 RVA: 0x00F8C78C File Offset: 0x00F8A98C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060404A4 RID: 263332 RVA: 0x00F8C879 File Offset: 0x00F8AA79
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(5);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x060404A5 RID: 263333 RVA: 0x00F8C8B4 File Offset: 0x00F8AAB4
		[NullableContext(2)]
		public void RefreshByLevelContent(string content)
		{
			UUIItem item = base.GetItem(1);
			if (content == null)
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(content, true);
		}

		// Token: 0x0200C5D8 RID: 50648
		private class ELevelComponent
		{
			// Token: 0x0403BBC2 RID: 244674
			public const int LockSprite = 0;

			// Token: 0x0403BBC3 RID: 244675
			public const int LevelItem = 1;

			// Token: 0x0403BBC4 RID: 244676
			public const int LevelText = 2;

			// Token: 0x0403BBC5 RID: 244677
			public const int VisionLevelItem = 3;

			// Token: 0x0403BBC6 RID: 244678
			public const int VisionLevelText = 4;

			// Token: 0x0403BBC7 RID: 244679
			public const int DeprecateSprite = 5;
		}
	}
}
