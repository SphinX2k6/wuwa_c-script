using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Transport
{
	// Token: 0x02004AF2 RID: 19186
	[NullableContext(1)]
	public interface ITransportFindPathResult
	{
		// Token: 0x17007AEA RID: 31466
		// (get) Token: 0x06031B20 RID: 203552
		// (set) Token: 0x06031B21 RID: 203553
		FVectorDouble RoadStartPoint { get; set; }

		// Token: 0x17007AEB RID: 31467
		// (get) Token: 0x06031B22 RID: 203554
		// (set) Token: 0x06031B23 RID: 203555
		FVectorDouble RoadEndPoint { get; set; }

		// Token: 0x17007AEC RID: 31468
		// (get) Token: 0x06031B24 RID: 203556
		// (set) Token: 0x06031B25 RID: 203557
		TArray<UKuroRoadway> Roadways { get; set; }

		// Token: 0x17007AED RID: 31469
		// (get) Token: 0x06031B26 RID: 203558
		// (set) Token: 0x06031B27 RID: 203559
		[Nullable(2)]
		UAutopilotRoute AutopilotRoute { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007AEE RID: 31470
		// (get) Token: 0x06031B28 RID: 203560
		// (set) Token: 0x06031B29 RID: 203561
		double? RouteLength { get; set; }
	}
}
