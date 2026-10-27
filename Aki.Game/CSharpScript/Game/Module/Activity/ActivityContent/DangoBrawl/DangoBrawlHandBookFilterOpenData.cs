using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067B0 RID: 26544
	public class DangoBrawlHandBookFilterOpenData
	{
		// Token: 0x04022863 RID: 141411
		[Nullable(1)]
		public List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x04022864 RID: 141412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<List<int>> OnConfirm;
	}
}
