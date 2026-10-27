using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200536D RID: 21357
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class GuqinQteItem : GridProxyAbstract<MusicalInstrumentQteItemData>
	{
		// Token: 0x06036920 RID: 223520 RVA: 0x00CEC410 File Offset: 0x00CEA610
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

		// Token: 0x06036921 RID: 223521 RVA: 0x00CEC49C File Offset: 0x00CEA69C
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

		// Token: 0x0401CD88 RID: 118152
		[Nullable(2)]
		public Func<int, int, GuqinKeyConfig> GetKeyConfigCallback;

		// Token: 0x0200B5E8 RID: 46568
		private enum EGuqinQteItemComponent
		{
			// Token: 0x040371A5 RID: 225701
			SprIcon,
			// Token: 0x040371A6 RID: 225702
			SprFinished,
			// Token: 0x040371A7 RID: 225703
			PnlKey
		}
	}
}
