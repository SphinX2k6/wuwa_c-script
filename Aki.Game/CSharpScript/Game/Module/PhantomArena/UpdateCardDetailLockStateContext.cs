using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02004105 RID: 16645
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class UpdateCardDetailLockStateContext
	{
		// Token: 0x0602A063 RID: 172131 RVA: 0x00BE167E File Offset: 0x00BDF87E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UpdateCardDetailLockStateContext()
		{
		}

		// Token: 0x04016EE7 RID: 93927
		[RequiredMember]
		public int CardId;

		// Token: 0x04016EE8 RID: 93928
		[RequiredMember]
		public bool IsUnLocked;

		// Token: 0x04016EE9 RID: 93929
		[RequiredMember]
		public UUIItem LockTipItem;

		// Token: 0x04016EEA RID: 93930
		[RequiredMember]
		public UUIText LockTipText;

		// Token: 0x04016EEB RID: 93931
		[RequiredMember]
		public UUIText TipText;

		// Token: 0x04016EEC RID: 93932
		[RequiredMember]
		public ButtonItem UnlockBtnItem;

		// Token: 0x04016EED RID: 93933
		[RequiredMember]
		public bool ShowUnlockRedDotWhenCanUnlock;
	}
}
