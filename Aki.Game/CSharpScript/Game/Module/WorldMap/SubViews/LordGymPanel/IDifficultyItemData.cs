using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200480D RID: 18445
	[NullableContext(1)]
	public interface IDifficultyItemData
	{
		// Token: 0x170078E0 RID: 30944
		// (get) Token: 0x060304A7 RID: 197799
		// (set) Token: 0x060304A8 RID: 197800
		string NameTextId { get; set; }

		// Token: 0x170078E1 RID: 30945
		// (get) Token: 0x060304A9 RID: 197801
		// (set) Token: 0x060304AA RID: 197802
		[Nullable(new byte[]
		{
			2,
			1
		})]
		object[] NameTextArg { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x170078E2 RID: 30946
		// (get) Token: 0x060304AB RID: 197803
		// (set) Token: 0x060304AC RID: 197804
		List<ELordGymDifficultyState> StateList { get; set; }
	}
}
