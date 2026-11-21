using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005077 RID: 20599
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBlessingSuitData : IRoverlikeBlessingSuitData
	{
		// Token: 0x170064B9 RID: 25785
		// (get) Token: 0x0603392A RID: 211242 RVA: 0x00E70945 File Offset: 0x00E6EB45
		// (set) Token: 0x0603392B RID: 211243 RVA: 0x00E7094D File Offset: 0x00E6EB4D
		public int SuitId { get; set; }

		// Token: 0x170064BA RID: 25786
		// (get) Token: 0x0603392C RID: 211244 RVA: 0x00E70956 File Offset: 0x00E6EB56
		// (set) Token: 0x0603392D RID: 211245 RVA: 0x00E7095E File Offset: 0x00E6EB5E
		public List<int> BlessingIdList { get; set; } = new List<int>();
	}
}
