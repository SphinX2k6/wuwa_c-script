using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF6 RID: 15094
	public class TowerDefenseLevelBossItem : GridProxyAbstract<int>
	{
		// Token: 0x06026C4D RID: 158797 RVA: 0x00AD8724 File Offset: 0x00AD6924
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

		// Token: 0x06026C4E RID: 158798 RVA: 0x00AD87B0 File Offset: 0x00AD69B0
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

		// Token: 0x020096EE RID: 38638
		private class ELevelDetailBossItemComponent
		{
			// Token: 0x0402F1BB RID: 192955
			public const int ItemBtn = 0;

			// Token: 0x0402F1BC RID: 192956
			public const int BossTex = 1;

			// Token: 0x0402F1BD RID: 192957
			public const int NumArtTxt = 2;
		}
	}
}
