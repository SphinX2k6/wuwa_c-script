using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B64 RID: 23396
	[RequiredMember]
	public class MediumItemGridExtendCallback
	{
		// Token: 0x0603B38B RID: 242571 RVA: 0x00E1ED37 File Offset: 0x00E1CF37
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumItemGridExtendCallback()
		{
		}

		// Token: 0x0401EE19 RID: 126489
		[Nullable(1)]
		[RequiredMember]
		public ItemGridBase MediumItemGrid;

		// Token: 0x0401EE1A RID: 126490
		[RequiredMember]
		public EToggleState State;

		// Token: 0x0401EE1B RID: 126491
		[Nullable(2)]
		public object Data;
	}
}
