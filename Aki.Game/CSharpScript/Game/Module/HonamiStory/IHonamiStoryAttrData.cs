using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005948 RID: 22856
	[NullableContext(1)]
	public interface IHonamiStoryAttrData
	{
		// Token: 0x17008B08 RID: 35592
		// (get) Token: 0x0603A023 RID: 237603
		// (set) Token: 0x0603A024 RID: 237604
		string Name { get; set; }

		// Token: 0x17008B09 RID: 35593
		// (get) Token: 0x0603A025 RID: 237605
		// (set) Token: 0x0603A026 RID: 237606
		string IconPath { get; set; }

		// Token: 0x17008B0A RID: 35594
		// (get) Token: 0x0603A027 RID: 237607
		// (set) Token: 0x0603A028 RID: 237608
		int OldValue { get; set; }

		// Token: 0x17008B0B RID: 35595
		// (get) Token: 0x0603A029 RID: 237609
		// (set) Token: 0x0603A02A RID: 237610
		int NewValue { get; set; }

		// Token: 0x17008B0C RID: 35596
		// (get) Token: 0x0603A02B RID: 237611
		// (set) Token: 0x0603A02C RID: 237612
		bool IsPercent { get; set; }
	}
}
