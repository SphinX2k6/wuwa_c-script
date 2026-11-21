using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056E0 RID: 22240
	[NullableContext(2)]
	public interface ICombineLineOwner
	{
		// Token: 0x06036D38 RID: 224568
		int GetOwnerUid();

		// Token: 0x06036D39 RID: 224569
		int GetOwnerConfigId();

		// Token: 0x06036D3A RID: 224570
		UUIItem GetOwnerRootItem();

		// Token: 0x06036D3B RID: 224571
		void NotifyAsPartner(int requesterUid, bool show);

		// Token: 0x06036D3C RID: 224572
		void RefreshLineAngles();
	}
}
