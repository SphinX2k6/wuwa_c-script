using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FBE RID: 24510
	public class GridItem : GridProxyAbstract<int>
	{
		// Token: 0x0603AE63 RID: 241251 RVA: 0x010A4A7C File Offset: 0x010A2C7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE64 RID: 241252 RVA: 0x010A4AE8 File Offset: 0x010A2CE8
		public override void Refresh(int dataId, bool isSelected, int gridIndex)
		{
			bool flag = dataId == -1;
			bool flag2 = dataId > 0;
			UUISprite sprite = base.GetSprite(0);
			sprite.SetUIActive(!flag);
			base.GetSprite(1).SetUIActive(flag);
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag2;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x0200B8DF RID: 47327
		private class EItemComponents
		{
			// Token: 0x040390F2 RID: 233714
			public const int SpriteBg = 0;

			// Token: 0x040390F3 RID: 233715
			public const int SpriteBan = 1;
		}
	}
}
