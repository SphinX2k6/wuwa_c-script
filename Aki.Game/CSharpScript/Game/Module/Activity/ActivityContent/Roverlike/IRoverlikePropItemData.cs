using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006188 RID: 24968
	public interface IRoverlikePropItemData
	{
		// Token: 0x170091D4 RID: 37332
		// (get) Token: 0x0603F18E RID: 258446
		// (set) Token: 0x0603F18F RID: 258447
		int ConfigId { get; set; }

		// Token: 0x170091D5 RID: 37333
		// (get) Token: 0x0603F190 RID: 258448
		// (set) Token: 0x0603F191 RID: 258449
		bool IsInGame { get; set; }

		// Token: 0x170091D6 RID: 37334
		// (get) Token: 0x0603F192 RID: 258450
		// (set) Token: 0x0603F193 RID: 258451
		int? IncId { get; set; }
	}
}
