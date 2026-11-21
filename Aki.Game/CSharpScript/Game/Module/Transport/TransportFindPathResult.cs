using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Transport
{
	// Token: 0x02003A9B RID: 15003
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class TransportFindPathResult : ITransportFindPathResult
	{
		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x060268BA RID: 157882 RVA: 0x00ACE102 File Offset: 0x00ACC302
		// (set) Token: 0x060268BB RID: 157883 RVA: 0x00ACE10A File Offset: 0x00ACC30A
		[RequiredMember]
		public FVectorDouble RoadStartPoint { get; set; }

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x060268BC RID: 157884 RVA: 0x00ACE113 File Offset: 0x00ACC313
		// (set) Token: 0x060268BD RID: 157885 RVA: 0x00ACE11B File Offset: 0x00ACC31B
		[RequiredMember]
		public FVectorDouble RoadEndPoint { get; set; }

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x060268BE RID: 157886 RVA: 0x00ACE124 File Offset: 0x00ACC324
		// (set) Token: 0x060268BF RID: 157887 RVA: 0x00ACE12C File Offset: 0x00ACC32C
		[RequiredMember]
		public TArray<UKuroRoadway> Roadways { get; set; }

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x060268C0 RID: 157888 RVA: 0x00ACE135 File Offset: 0x00ACC335
		// (set) Token: 0x060268C1 RID: 157889 RVA: 0x00ACE13D File Offset: 0x00ACC33D
		[Nullable(2)]
		public UAutopilotRoute AutopilotRoute { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x060268C2 RID: 157890 RVA: 0x00ACE146 File Offset: 0x00ACC346
		// (set) Token: 0x060268C3 RID: 157891 RVA: 0x00ACE14E File Offset: 0x00ACC34E
		public double? RouteLength { get; set; }

		// Token: 0x060268C4 RID: 157892 RVA: 0x00ACE157 File Offset: 0x00ACC357
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public TransportFindPathResult()
		{
		}
	}
}
