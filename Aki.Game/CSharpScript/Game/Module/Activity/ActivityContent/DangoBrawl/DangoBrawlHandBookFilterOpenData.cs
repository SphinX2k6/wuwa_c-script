using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005700 RID: 22272
	public class DangoBrawlHandBookFilterOpenData
	{
		// Token: 0x0401D0C0 RID: 118976
		[Nullable(1)]
		public List<int> SelectedOccupationIds = new List<int>();

		// Token: 0x0401D0C1 RID: 118977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<List<int>> OnConfirm;
	}
}
