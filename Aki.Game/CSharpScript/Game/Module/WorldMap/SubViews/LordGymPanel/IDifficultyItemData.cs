using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200373E RID: 14142
	[NullableContext(1)]
	public interface IDifficultyItemData
	{
		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x06024C77 RID: 150647
		// (set) Token: 0x06024C78 RID: 150648
		string NameTextId { get; set; }

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x06024C79 RID: 150649
		// (set) Token: 0x06024C7A RID: 150650
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

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x06024C7B RID: 150651
		// (set) Token: 0x06024C7C RID: 150652
		List<ELordGymDifficultyState> StateList { get; set; }
	}
}
