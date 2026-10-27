using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006986 RID: 27014
	[NullableContext(2)]
	public interface ICurveFloatRange
	{
		// Token: 0x1700983B RID: 38971
		// (get) Token: 0x060433C2 RID: 275394
		// (set) Token: 0x060433C3 RID: 275395
		UCurveFloat CurveFloat { get; set; }

		// Token: 0x1700983C RID: 38972
		// (get) Token: 0x060433C4 RID: 275396
		// (set) Token: 0x060433C5 RID: 275397
		EEasingType EasingType { get; set; }

		// Token: 0x1700983D RID: 38973
		// (get) Token: 0x060433C6 RID: 275398
		// (set) Token: 0x060433C7 RID: 275399
		ECurveSourceType SourceType { get; set; }

		// Token: 0x1700983E RID: 38974
		// (get) Token: 0x060433C8 RID: 275400
		// (set) Token: 0x060433C9 RID: 275401
		float FromMin { get; set; }

		// Token: 0x1700983F RID: 38975
		// (get) Token: 0x060433CA RID: 275402
		// (set) Token: 0x060433CB RID: 275403
		float FromMax { get; set; }

		// Token: 0x17009840 RID: 38976
		// (get) Token: 0x060433CC RID: 275404
		// (set) Token: 0x060433CD RID: 275405
		float ToMin { get; set; }

		// Token: 0x17009841 RID: 38977
		// (get) Token: 0x060433CE RID: 275406
		// (set) Token: 0x060433CF RID: 275407
		float ToMax { get; set; }
	}
}
