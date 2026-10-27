using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher
{
	// Token: 0x0200004E RID: 78
	public class StorageAlertLog : HotPatchLogData
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000C558 File Offset: 0x0000A758
		[NullableContext(2)]
		public StorageAlertLog(int remainingSpace, string uniqueId = null, string playerId = null) : base("1711", uniqueId, playerId)
		{
			this.i_remaining_space = remainingSpace;
		}

		// Token: 0x0400013E RID: 318
		public int i_remaining_space;
	}
}
