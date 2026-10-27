using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053AA RID: 21418
	[NullableContext(2)]
	[Nullable(0)]
	public class MoraleBuffAddTipsParams
	{
		// Token: 0x0401CE5A RID: 118362
		public UUIItem ItemForLocation;

		// Token: 0x0401CE5B RID: 118363
		public string TitleKey;

		// Token: 0x0401CE5C RID: 118364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IMoraleBuffAddItemData> DataList;
	}
}
