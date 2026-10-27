using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x0200636E RID: 25454
	public class PinballFormationViewData : IPinballFormationViewData
	{
		// Token: 0x17009341 RID: 37697
		// (get) Token: 0x06040070 RID: 262256 RVA: 0x00F7D316 File Offset: 0x00F7B516
		// (set) Token: 0x06040071 RID: 262257 RVA: 0x00F7D31E File Offset: 0x00F7B51E
		public int LevelId { get; set; }

		// Token: 0x17009342 RID: 37698
		// (get) Token: 0x06040072 RID: 262258 RVA: 0x00F7D327 File Offset: 0x00F7B527
		// (set) Token: 0x06040073 RID: 262259 RVA: 0x00F7D32F File Offset: 0x00F7B52F
		public bool? IsRestart { get; set; }

		// Token: 0x17009343 RID: 37699
		// (get) Token: 0x06040074 RID: 262260 RVA: 0x00F7D338 File Offset: 0x00F7B538
		// (set) Token: 0x06040075 RID: 262261 RVA: 0x00F7D340 File Offset: 0x00F7B540
		public bool? IfReturnToPinballMainView { get; set; }
	}
}
