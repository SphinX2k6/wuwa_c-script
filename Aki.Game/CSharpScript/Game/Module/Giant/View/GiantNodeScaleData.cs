using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005983 RID: 22915
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class GiantNodeScaleData : IGiantNodeScaleData
	{
		// Token: 0x17008B4B RID: 35659
		// (get) Token: 0x0603A25E RID: 238174 RVA: 0x00DD3434 File Offset: 0x00DD1634
		// (set) Token: 0x0603A25F RID: 238175 RVA: 0x00DD343C File Offset: 0x00DD163C
		[RequiredMember]
		public int NodeIndex { get; set; }

		// Token: 0x17008B4C RID: 35660
		// (get) Token: 0x0603A260 RID: 238176 RVA: 0x00DD3445 File Offset: 0x00DD1645
		// (set) Token: 0x0603A261 RID: 238177 RVA: 0x00DD344D File Offset: 0x00DD164D
		[RequiredMember]
		public int Value { get; set; }

		// Token: 0x17008B4D RID: 35661
		// (get) Token: 0x0603A262 RID: 238178 RVA: 0x00DD3456 File Offset: 0x00DD1656
		// (set) Token: 0x0603A263 RID: 238179 RVA: 0x00DD345E File Offset: 0x00DD165E
		[RequiredMember]
		public EGiantNodeScaleState State { get; set; }

		// Token: 0x17008B4E RID: 35662
		// (get) Token: 0x0603A264 RID: 238180 RVA: 0x00DD3467 File Offset: 0x00DD1667
		// (set) Token: 0x0603A265 RID: 238181 RVA: 0x00DD346F File Offset: 0x00DD166F
		[RequiredMember]
		public bool IsGot { get; set; }

		// Token: 0x17008B4F RID: 35663
		// (get) Token: 0x0603A266 RID: 238182 RVA: 0x00DD3478 File Offset: 0x00DD1678
		// (set) Token: 0x0603A267 RID: 238183 RVA: 0x00DD3480 File Offset: 0x00DD1680
		[RequiredMember]
		public bool CanClaim { get; set; }

		// Token: 0x17008B50 RID: 35664
		// (get) Token: 0x0603A268 RID: 238184 RVA: 0x00DD3489 File Offset: 0x00DD1689
		// (set) Token: 0x0603A269 RID: 238185 RVA: 0x00DD3491 File Offset: 0x00DD1691
		[RequiredMember]
		public bool ShowCurrentMark { get; set; }

		// Token: 0x17008B51 RID: 35665
		// (get) Token: 0x0603A26A RID: 238186 RVA: 0x00DD349A File Offset: 0x00DD169A
		// (set) Token: 0x0603A26B RID: 238187 RVA: 0x00DD34A2 File Offset: 0x00DD16A2
		[RequiredMember]
		public Action<int, bool, UUIItem> OnClick { get; set; }

		// Token: 0x0603A26C RID: 238188 RVA: 0x00DD34AB File Offset: 0x00DD16AB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantNodeScaleData()
		{
		}
	}
}
