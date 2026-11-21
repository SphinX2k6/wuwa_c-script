using System;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005937 RID: 22839
	public class SolarSchoolScratchTicketCellData
	{
		// Token: 0x17006BD7 RID: 27607
		// (get) Token: 0x0603847D RID: 230525 RVA: 0x00FBC8A0 File Offset: 0x00FBAAA0
		// (set) Token: 0x0603847E RID: 230526 RVA: 0x00FBC8A8 File Offset: 0x00FBAAA8
		public SolarSchoolReward? PlacedReward { get; private set; }

		// Token: 0x17006BD8 RID: 27608
		// (get) Token: 0x0603847F RID: 230527 RVA: 0x00FBC8B1 File Offset: 0x00FBAAB1
		// (set) Token: 0x06038480 RID: 230528 RVA: 0x00FBC8B9 File Offset: 0x00FBAAB9
		public bool IsRevealed { get; private set; }

		// Token: 0x06038481 RID: 230529 RVA: 0x00FBC8C2 File Offset: 0x00FBAAC2
		public SolarSchoolScratchTicketCellData(int index)
		{
			this.Index = index;
		}

		// Token: 0x06038482 RID: 230530 RVA: 0x00FBC8D1 File Offset: 0x00FBAAD1
		public void SetReward(SolarSchoolReward reward)
		{
			this.PlacedReward = new SolarSchoolReward?(reward);
		}

		// Token: 0x06038483 RID: 230531 RVA: 0x00FBC8DF File Offset: 0x00FBAADF
		public void Reveal()
		{
			this.IsRevealed = true;
		}

		// Token: 0x06038484 RID: 230532 RVA: 0x00FBC8E8 File Offset: 0x00FBAAE8
		public bool IsLock()
		{
			return !this.IsRevealed;
		}

		// Token: 0x0401DA38 RID: 121400
		public readonly int Index;
	}
}
