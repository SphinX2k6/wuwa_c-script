using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x0200438D RID: 17293
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleBuffAddTipsParams
	{
		// Token: 0x040178F2 RID: 96498
		public UUIItem ItemForLocation;

		// Token: 0x040178F3 RID: 96499
		public string TitleKey;

		// Token: 0x040178F4 RID: 96500
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMoraleBuffAddItemData> DataList;
	}
}
