using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02004350 RID: 17232
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GuqinQteItem : GridProxyAbstract<MusicalInstrumentQteItemData>
	{
		// Token: 0x0602B866 RID: 178278 RVA: 0x00C3B29C File Offset: 0x00C3949C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602B867 RID: 178279 RVA: 0x00C3B328 File Offset: 0x00C39528
		[NullableContext(1)]
		public override void Refresh(MusicalInstrumentQteItemData data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(data.Finished);
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.Finished);
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(false);
		}

		// Token: 0x0401781E RID: 96286
		[Nullable(2)]
		public Func<int, int, GuqinKeyConfig> GetKeyConfigCallback;

		// Token: 0x0200A01F RID: 40991
		private enum EGuqinQteItemComponent
		{
			// Token: 0x04031BF8 RID: 203768
			SprIcon,
			// Token: 0x04031BF9 RID: 203769
			SprFinished,
			// Token: 0x04031BFA RID: 203770
			PnlKey
		}
	}
}
