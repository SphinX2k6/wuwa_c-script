using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048B0 RID: 18608
	[RequiredMember]
	public class MoveCheckResultAndDistance : IMoveCheckResultAndDistance
	{
		// Token: 0x1700796A RID: 31082
		// (get) Token: 0x06030A2A RID: 199210 RVA: 0x00B4A757 File Offset: 0x00B48957
		// (set) Token: 0x06030A2B RID: 199211 RVA: 0x00B4A75F File Offset: 0x00B4895F
		[RequiredMember]
		public EMoveCheckResult Result { get; set; }

		// Token: 0x1700796B RID: 31083
		// (get) Token: 0x06030A2C RID: 199212 RVA: 0x00B4A768 File Offset: 0x00B48968
		// (set) Token: 0x06030A2D RID: 199213 RVA: 0x00B4A770 File Offset: 0x00B48970
		[RequiredMember]
		public float AfterAdjustDistance { get; set; }

		// Token: 0x06030A2E RID: 199214 RVA: 0x00B4A779 File Offset: 0x00B48979
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MoveCheckResultAndDistance()
		{
		}
	}
}
