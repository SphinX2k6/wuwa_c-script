using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E3D RID: 28221
	public class GridItem : GridProxyAbstract<int>
	{
		// Token: 0x06044CD6 RID: 281814 RVA: 0x010FA4FC File Offset: 0x010F86FC
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

		// Token: 0x06044CD7 RID: 281815 RVA: 0x010FA568 File Offset: 0x010F8768
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

		// Token: 0x0200CCEF RID: 52463
		private class EItemComponents
		{
			// Token: 0x0403DCD0 RID: 253136
			public const int SpriteBg = 0;

			// Token: 0x0403DCD1 RID: 253137
			public const int SpriteBan = 1;
		}
	}
}
