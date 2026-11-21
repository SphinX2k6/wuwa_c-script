using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B43 RID: 19267
	[RequiredMember]
	public class MediumItemGridExtendCallback
	{
		// Token: 0x060302D7 RID: 197335 RVA: 0x00D6F2A3 File Offset: 0x00D6D4A3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridExtendCallback()
		{
		}

		// Token: 0x040198C8 RID: 104648
		[Nullable(1)]
		[RequiredMember]
		public ItemGridBase MediumItemGrid;

		// Token: 0x040198C9 RID: 104649
		[RequiredMember]
		public EToggleState State;

		// Token: 0x040198CA RID: 104650
		[Nullable(2)]
		public object Data;
	}
}
