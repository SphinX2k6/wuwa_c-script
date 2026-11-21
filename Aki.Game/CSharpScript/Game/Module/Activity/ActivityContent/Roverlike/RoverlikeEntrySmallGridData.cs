using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005111 RID: 20753
	public class RoverlikeEntrySmallGridData : IRoverlikeEntrySmallGridData
	{
		// Token: 0x17006558 RID: 25944
		// (get) Token: 0x06033E97 RID: 212631 RVA: 0x00E86164 File Offset: 0x00E84364
		// (set) Token: 0x06033E98 RID: 212632 RVA: 0x00E8616C File Offset: 0x00E8436C
		public int ConfigId { get; set; }

		// Token: 0x17006559 RID: 25945
		// (get) Token: 0x06033E99 RID: 212633 RVA: 0x00E86175 File Offset: 0x00E84375
		// (set) Token: 0x06033E9A RID: 212634 RVA: 0x00E8617D File Offset: 0x00E8437D
		public RoverRogueGainDataType Type { get; set; } = RoverRogueGainDataType.RoverRogueGainBless;
	}
}
