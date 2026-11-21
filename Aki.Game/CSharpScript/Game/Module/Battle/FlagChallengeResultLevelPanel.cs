using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C21 RID: 19489
	public class FlagChallengeResultLevelPanel : UiPanelBase
	{
		// Token: 0x060309E3 RID: 199139 RVA: 0x00D8D510 File Offset: 0x00D8B710
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

		// Token: 0x060309E4 RID: 199140 RVA: 0x00D8D5BB File Offset: 0x00D8B7BB
		[NullableContext(1)]
		public void SetLevelText(string level, string levelDiff, string boxLevel)
		{
			base.GetArtText(0).SetText(level);
			base.GetText(2).SetText(levelDiff, true);
			base.GetText(1).SetText(boxLevel, true);
		}

		// Token: 0x0200A844 RID: 43076
		private enum EChildComponentType
		{
			// Token: 0x04033FA6 RID: 212902
			LevelArtText,
			// Token: 0x04033FA7 RID: 212903
			BoxLevelText,
			// Token: 0x04033FA8 RID: 212904
			LevelDiffText,
			// Token: 0x04033FA9 RID: 212905
			ArrowSprite
		}
	}
}
