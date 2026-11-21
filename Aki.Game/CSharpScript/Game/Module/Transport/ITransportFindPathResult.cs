using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Transport
{
	// Token: 0x02003A9A RID: 15002
	[NullableContext(1)]
	public interface ITransportFindPathResult
	{
		// Token: 0x17004E97 RID: 20119
		// (get) Token: 0x060268B0 RID: 157872
		// (set) Token: 0x060268B1 RID: 157873
		FVectorDouble RoadStartPoint { get; set; }

		// Token: 0x17004E98 RID: 20120
		// (get) Token: 0x060268B2 RID: 157874
		// (set) Token: 0x060268B3 RID: 157875
		FVectorDouble RoadEndPoint { get; set; }

		// Token: 0x17004E99 RID: 20121
		// (get) Token: 0x060268B4 RID: 157876
		// (set) Token: 0x060268B5 RID: 157877
		TArray<UKuroRoadway> Roadways { get; set; }

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x060268B6 RID: 157878
		// (set) Token: 0x060268B7 RID: 157879
		[Nullable(2)]
		UAutopilotRoute AutopilotRoute { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004E9B RID: 20123
		// (get) Token: 0x060268B8 RID: 157880
		// (set) Token: 0x060268B9 RID: 157881
		double? RouteLength { get; set; }
	}
}
