using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD6 RID: 24534
	public interface IRoundConfig
	{
		// Token: 0x17009014 RID: 36884
		// (get) Token: 0x0603E29F RID: 254623
		// (set) Token: 0x0603E2A0 RID: 254624
		int Id { get; set; }

		// Token: 0x17009015 RID: 36885
		// (get) Token: 0x0603E2A1 RID: 254625
		// (set) Token: 0x0603E2A2 RID: 254626
		int LevelId { get; set; }

		// Token: 0x17009016 RID: 36886
		// (get) Token: 0x0603E2A3 RID: 254627
		// (set) Token: 0x0603E2A4 RID: 254628
		int Round { get; set; }

		// Token: 0x17009017 RID: 36887
		// (get) Token: 0x0603E2A5 RID: 254629
		// (set) Token: 0x0603E2A6 RID: 254630
		int ShapeId { get; set; }

		// Token: 0x17009018 RID: 36888
		// (get) Token: 0x0603E2A7 RID: 254631
		// (set) Token: 0x0603E2A8 RID: 254632
		int Color { get; set; }

		// Token: 0x17009019 RID: 36889
		// (get) Token: 0x0603E2A9 RID: 254633
		// (set) Token: 0x0603E2AA RID: 254634
		int Gem { get; set; }

		// Token: 0x1700901A RID: 36890
		// (get) Token: 0x0603E2AB RID: 254635
		// (set) Token: 0x0603E2AC RID: 254636
		int GemFill { get; set; }
	}
}
