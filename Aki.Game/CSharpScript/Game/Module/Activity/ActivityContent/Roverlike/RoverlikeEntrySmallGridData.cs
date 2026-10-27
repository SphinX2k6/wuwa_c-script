using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006193 RID: 24979
	public class RoverlikeEntrySmallGridData : IRoverlikeEntrySmallGridData
	{
		// Token: 0x170091F6 RID: 37366
		// (get) Token: 0x0603F1D7 RID: 258519 RVA: 0x00F3F29C File Offset: 0x00F3D49C
		// (set) Token: 0x0603F1D8 RID: 258520 RVA: 0x00F3F2A4 File Offset: 0x00F3D4A4
		public int ConfigId { get; set; }

		// Token: 0x170091F7 RID: 37367
		// (get) Token: 0x0603F1D9 RID: 258521 RVA: 0x00F3F2AD File Offset: 0x00F3D4AD
		// (set) Token: 0x0603F1DA RID: 258522 RVA: 0x00F3F2B5 File Offset: 0x00F3D4B5
		public RoverRogueGainDataType Type { get; set; } = RoverRogueGainDataType.RoverRogueGainBless;
	}
}
