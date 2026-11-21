using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F7 RID: 23031
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class SolarSchoolRewardTipItemTypeState
	{
		// Token: 0x06038B90 RID: 232336 RVA: 0x00FDFF8A File Offset: 0x00FDE18A
		public SolarSchoolRewardTipItemTypeState(SolarSchoolRewardTipColumnState columnState, UUIItem template, Func<SolarSchoolRewardTipItemBase> createItem)
		{
			this.ColumnState = columnState;
			this.Template = template;
			this.CreateItem = createItem;
		}

		// Token: 0x0401DDD2 RID: 122322
		public readonly SolarSchoolRewardTipColumnState ColumnState;

		// Token: 0x0401DDD3 RID: 122323
		public readonly UUIItem Template;

		// Token: 0x0401DDD4 RID: 122324
		public readonly Func<SolarSchoolRewardTipItemBase> CreateItem;

		// Token: 0x0401DDD5 RID: 122325
		public readonly List<SolarSchoolRewardTipItemBase> ItemPool = new List<SolarSchoolRewardTipItemBase>();
	}
}
