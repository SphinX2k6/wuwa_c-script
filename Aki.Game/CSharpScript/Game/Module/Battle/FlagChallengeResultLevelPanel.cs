using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C41 RID: 23617
	public class FlagChallengeResultLevelPanel : UiPanelBase
	{
		// Token: 0x0603BA98 RID: 244376 RVA: 0x00E3D1A0 File Offset: 0x00E3B3A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BA99 RID: 244377 RVA: 0x00E3D24B File Offset: 0x00E3B44B
		[NullableContext(1)]
		public void SetLevelText(string level, string levelDiff, string boxLevel)
		{
			base.GetArtText(0).SetText(level);
			base.GetText(2).SetText(levelDiff, true);
			base.GetText(1).SetText(boxLevel, true);
		}

		// Token: 0x0200BE3C RID: 48700
		private enum EChildComponentType
		{
			// Token: 0x040395E3 RID: 234979
			LevelArtText,
			// Token: 0x040395E4 RID: 234980
			BoxLevelText,
			// Token: 0x040395E5 RID: 234981
			LevelDiffText,
			// Token: 0x040395E6 RID: 234982
			ArrowSprite
		}
	}
}
