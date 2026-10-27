using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006790 RID: 26512
	[NullableContext(2)]
	public interface ICombineLineOwner
	{
		// Token: 0x060421E2 RID: 270818
		int GetOwnerUid();

		// Token: 0x060421E3 RID: 270819
		int GetOwnerConfigId();

		// Token: 0x060421E4 RID: 270820
		UUIItem GetOwnerRootItem();

		// Token: 0x060421E5 RID: 270821
		void NotifyAsPartner(int requesterUid, bool show);

		// Token: 0x060421E6 RID: 270822
		void RefreshLineAngles();
	}
}
