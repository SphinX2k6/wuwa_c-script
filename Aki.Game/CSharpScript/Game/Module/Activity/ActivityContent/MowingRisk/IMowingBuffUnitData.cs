using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005331 RID: 21297
	[NullableContext(1)]
	public interface IMowingBuffUnitData
	{
		// Token: 0x170066D9 RID: 26329
		// (get) Token: 0x06035008 RID: 217096
		// (set) Token: 0x06035009 RID: 217097
		int Index { get; set; }

		// Token: 0x170066DA RID: 26330
		// (get) Token: 0x0603500A RID: 217098
		// (set) Token: 0x0603500B RID: 217099
		int BuffId { get; set; }

		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x0603500C RID: 217100
		// (set) Token: 0x0603500D RID: 217101
		bool IsActive { get; set; }

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x0603500E RID: 217102
		// (set) Token: 0x0603500F RID: 217103
		bool IsChosen { get; set; }

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x06035010 RID: 217104
		// (set) Token: 0x06035011 RID: 217105
		string IconPath { get; set; }

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x06035012 RID: 217106
		// (set) Token: 0x06035013 RID: 217107
		string NameTextId { get; set; }

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x06035014 RID: 217108
		// (set) Token: 0x06035015 RID: 217109
		int ThresholdCount { get; set; }
	}
}
