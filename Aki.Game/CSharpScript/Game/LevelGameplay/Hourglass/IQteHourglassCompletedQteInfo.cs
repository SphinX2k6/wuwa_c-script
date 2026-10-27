using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Hourglass
{
	// Token: 0x02006DF9 RID: 28153
	[NullableContext(2)]
	public interface IQteHourglassCompletedQteInfo
	{
		// Token: 0x170099DB RID: 39387
		// (get) Token: 0x06044AD1 RID: 281297
		// (set) Token: 0x06044AD2 RID: 281298
		int HandleId { get; set; }

		// Token: 0x170099DC RID: 39388
		// (get) Token: 0x06044AD3 RID: 281299
		// (set) Token: 0x06044AD4 RID: 281300
		int QteId { get; set; }

		// Token: 0x170099DD RID: 39389
		// (get) Token: 0x06044AD5 RID: 281301
		// (set) Token: 0x06044AD6 RID: 281302
		bool IsSuccess { get; set; }

		// Token: 0x170099DE RID: 39390
		// (get) Token: 0x06044AD7 RID: 281303
		// (set) Token: 0x06044AD8 RID: 281304
		bool IsFail { get; set; }

		// Token: 0x170099DF RID: 39391
		// (get) Token: 0x06044AD9 RID: 281305
		// (set) Token: 0x06044ADA RID: 281306
		Vector StartPos { get; set; }
	}
}
