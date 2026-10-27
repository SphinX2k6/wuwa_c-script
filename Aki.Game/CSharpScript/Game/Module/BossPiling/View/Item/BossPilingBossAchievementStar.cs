using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C1D RID: 23581
	public class BossPilingBossAchievementStar : GridProxyAbstract<bool>
	{
		// Token: 0x0603B958 RID: 244056 RVA: 0x00E36188 File Offset: 0x00E34388
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

		// Token: 0x0603B959 RID: 244057 RVA: 0x00E361F1 File Offset: 0x00E343F1
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(data);
		}

		// Token: 0x0200BE09 RID: 48649
		private enum EStar
		{
			// Token: 0x040394DA RID: 234714
			SpriteBg,
			// Token: 0x040394DB RID: 234715
			SpriteStar
		}
	}
}
