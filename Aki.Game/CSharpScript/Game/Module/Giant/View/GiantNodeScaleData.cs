using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200495C RID: 18780
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GiantNodeScaleData : IGiantNodeScaleData
	{
		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x0602F184 RID: 192900 RVA: 0x00D228C4 File Offset: 0x00D20AC4
		// (set) Token: 0x0602F185 RID: 192901 RVA: 0x00D228CC File Offset: 0x00D20ACC
		[RequiredMember]
		public int NodeIndex { get; set; }

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x0602F186 RID: 192902 RVA: 0x00D228D5 File Offset: 0x00D20AD5
		// (set) Token: 0x0602F187 RID: 192903 RVA: 0x00D228DD File Offset: 0x00D20ADD
		[RequiredMember]
		public int Value { get; set; }

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x0602F188 RID: 192904 RVA: 0x00D228E6 File Offset: 0x00D20AE6
		// (set) Token: 0x0602F189 RID: 192905 RVA: 0x00D228EE File Offset: 0x00D20AEE
		[RequiredMember]
		public EGiantNodeScaleState State { get; set; }

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x0602F18A RID: 192906 RVA: 0x00D228F7 File Offset: 0x00D20AF7
		// (set) Token: 0x0602F18B RID: 192907 RVA: 0x00D228FF File Offset: 0x00D20AFF
		[RequiredMember]
		public bool IsGot { get; set; }

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x0602F18C RID: 192908 RVA: 0x00D22908 File Offset: 0x00D20B08
		// (set) Token: 0x0602F18D RID: 192909 RVA: 0x00D22910 File Offset: 0x00D20B10
		[RequiredMember]
		public bool CanClaim { get; set; }

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x0602F18E RID: 192910 RVA: 0x00D22919 File Offset: 0x00D20B19
		// (set) Token: 0x0602F18F RID: 192911 RVA: 0x00D22921 File Offset: 0x00D20B21
		[RequiredMember]
		public bool ShowCurrentMark { get; set; }

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x0602F190 RID: 192912 RVA: 0x00D2292A File Offset: 0x00D20B2A
		// (set) Token: 0x0602F191 RID: 192913 RVA: 0x00D22932 File Offset: 0x00D20B32
		[RequiredMember]
		public Action<int, bool, UUIItem> OnClick { get; set; }

		// Token: 0x0602F192 RID: 192914 RVA: 0x00D2293B File Offset: 0x00D20B3B
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantNodeScaleData()
		{
		}
	}
}
