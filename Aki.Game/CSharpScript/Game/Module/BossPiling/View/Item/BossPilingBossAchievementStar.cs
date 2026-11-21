using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02004BFD RID: 19453
	public class BossPilingBossAchievementStar : GridProxyAbstract<bool>
	{
		// Token: 0x060308A3 RID: 198819 RVA: 0x00D864E4 File Offset: 0x00D846E4
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

		// Token: 0x060308A4 RID: 198820 RVA: 0x00D8654D File Offset: 0x00D8474D
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x0200A811 RID: 43025
		private enum EStar
		{
			// Token: 0x04033E9D RID: 212637
			SpriteBg,
			// Token: 0x04033E9E RID: 212638
			SpriteStar
		}
	}
}
