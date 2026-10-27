using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005135 RID: 20789
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UpdateCardDetailLockStateContext
	{
		// Token: 0x0603516A RID: 217450 RVA: 0x00C9426A File Offset: 0x00C9246A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UpdateCardDetailLockStateContext()
		{
		}

		// Token: 0x0401C4B2 RID: 115890
		[RequiredMember]
		public int CardId;

		// Token: 0x0401C4B3 RID: 115891
		[RequiredMember]
		public bool IsUnLocked;

		// Token: 0x0401C4B4 RID: 115892
		[RequiredMember]
		public UUIItem LockTipItem;

		// Token: 0x0401C4B5 RID: 115893
		[RequiredMember]
		public UUIText LockTipText;

		// Token: 0x0401C4B6 RID: 115894
		[RequiredMember]
		public UUIText TipText;

		// Token: 0x0401C4B7 RID: 115895
		[RequiredMember]
		public ButtonItem UnlockBtnItem;

		// Token: 0x0401C4B8 RID: 115896
		[RequiredMember]
		public bool ShowUnlockRedDotWhenCanUnlock;
	}
}
