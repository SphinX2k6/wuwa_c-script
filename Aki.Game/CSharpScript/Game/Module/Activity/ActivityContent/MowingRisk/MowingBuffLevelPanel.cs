using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005356 RID: 21334
	public class MowingBuffLevelPanel : UiPanelBase
	{
		// Token: 0x06035164 RID: 217444 RVA: 0x00ED3724 File Offset: 0x00ED1924
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

		// Token: 0x06035165 RID: 217445 RVA: 0x00ED3811 File Offset: 0x00ED1A11
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

		// Token: 0x06035166 RID: 217446 RVA: 0x00ED384C File Offset: 0x00ED1A4C
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

		// Token: 0x0200AFBF RID: 44991
		private class ELevelComponent
		{
			// Token: 0x04036521 RID: 222497
			public const int LockSprite = 0;

			// Token: 0x04036522 RID: 222498
			public const int LevelItem = 1;

			// Token: 0x04036523 RID: 222499
			public const int LevelText = 2;

			// Token: 0x04036524 RID: 222500
			public const int VisionLevelItem = 3;

			// Token: 0x04036525 RID: 222501
			public const int VisionLevelText = 4;

			// Token: 0x04036526 RID: 222502
			public const int DeprecateSprite = 5;
		}
	}
}
