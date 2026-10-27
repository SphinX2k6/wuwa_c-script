using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Letter
{
	// Token: 0x020056C9 RID: 22217
	public interface ILetterBackupDisplayViewOpenParam
	{
		// Token: 0x170087A4 RID: 34724
		// (get) Token: 0x0603882C RID: 231468
		// (set) Token: 0x0603882D RID: 231469
		int LetterId { get; set; }

		// Token: 0x170087A5 RID: 34725
		// (get) Token: 0x0603882E RID: 231470
		// (set) Token: 0x0603882F RID: 231471
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

		// Token: 0x170087A6 RID: 34726
		// (get) Token: 0x06038830 RID: 231472
		// (set) Token: 0x06038831 RID: 231473
		ELetterStyle? LetterStyle { get; set; }
	}
}
