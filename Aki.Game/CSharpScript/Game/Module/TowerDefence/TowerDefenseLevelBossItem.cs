using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B4E RID: 19278
	public class TowerDefenseLevelBossItem : GridProxyAbstract<int>
	{
		// Token: 0x06031EBD RID: 204477 RVA: 0x00B946B8 File Offset: 0x00B928B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031EBE RID: 204478 RVA: 0x00B94744 File Offset: 0x00B92944
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(data);
			base.SetTextureByPath(monsterIcon, base.GetTexture(1), null, null);
			int num = gridIndex + 1;
			UUIArtText artText = base.GetArtText(2);
			if (artText == null)
			{
				return;
			}
			string text;
			if (num >= 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			artText.SetText(text);
		}

		// Token: 0x0200ACCE RID: 44238
		private class ELevelDetailBossItemComponent
		{
			// Token: 0x0403480B RID: 215051
			public const int ItemBtn = 0;

			// Token: 0x0403480C RID: 215052
			public const int BossTex = 1;

			// Token: 0x0403480D RID: 215053
			public const int NumArtTxt = 2;
		}
	}
}
