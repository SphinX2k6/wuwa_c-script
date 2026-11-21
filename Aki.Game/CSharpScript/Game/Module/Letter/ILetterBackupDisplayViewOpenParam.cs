using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020046A0 RID: 18080
	public interface ILetterBackupDisplayViewOpenParam
	{
		// Token: 0x17005B6C RID: 23404
		// (get) Token: 0x0602D73C RID: 186172
		// (set) Token: 0x0602D73D RID: 186173
		int LetterId { get; set; }

		// Token: 0x17005B6D RID: 23405
		// (get) Token: 0x0602D73E RID: 186174
		// (set) Token: 0x0602D73F RID: 186175
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IReadOnlyList<ITalkItem> Items { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17005B6E RID: 23406
		// (get) Token: 0x0602D740 RID: 186176
		// (set) Token: 0x0602D741 RID: 186177
		ELetterStyle? LetterStyle { get; set; }
	}
}
