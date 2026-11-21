using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005079 RID: 20601
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBlessingSuitSelectParam : IRoverlikeBlessingSuitSelectParam
	{
		// Token: 0x170064BD RID: 25789
		// (get) Token: 0x06033933 RID: 211251 RVA: 0x00E7097A File Offset: 0x00E6EB7A
		// (set) Token: 0x06033934 RID: 211252 RVA: 0x00E70982 File Offset: 0x00E6EB82
		public List<IRoverlikeBlessingSuitData> SuitDataList { get; set; } = new List<IRoverlikeBlessingSuitData>();

		// Token: 0x170064BE RID: 25790
		// (get) Token: 0x06033935 RID: 211253 RVA: 0x00E7098B File Offset: 0x00E6EB8B
		// (set) Token: 0x06033936 RID: 211254 RVA: 0x00E70993 File Offset: 0x00E6EB93
		public int SelectedIndex { get; set; }
	}
}
