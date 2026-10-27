using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044C0 RID: 17600
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ChairSummonResult : IChairSummonResult
	{
		// Token: 0x17007394 RID: 29588
		// (get) Token: 0x0602D5EA RID: 185834 RVA: 0x00A3C257 File Offset: 0x00A3A457
		// (set) Token: 0x0602D5EB RID: 185835 RVA: 0x00A3C25F File Offset: 0x00A3A45F
		public bool Success { get; set; }

		// Token: 0x17007395 RID: 29589
		// (get) Token: 0x0602D5EC RID: 185836 RVA: 0x00A3C268 File Offset: 0x00A3A468
		// (set) Token: 0x0602D5ED RID: 185837 RVA: 0x00A3C270 File Offset: 0x00A3A470
		public string FailReason { get; set; } = "";

		// Token: 0x17007396 RID: 29590
		// (get) Token: 0x0602D5EE RID: 185838 RVA: 0x00A3C279 File Offset: 0x00A3A479
		// (set) Token: 0x0602D5EF RID: 185839 RVA: 0x00A3C281 File Offset: 0x00A3A481
		[RequiredMember]
		public Vector FinalLocation { get; set; }

		// Token: 0x17007397 RID: 29591
		// (get) Token: 0x0602D5F0 RID: 185840 RVA: 0x00A3C28A File Offset: 0x00A3A48A
		// (set) Token: 0x0602D5F1 RID: 185841 RVA: 0x00A3C292 File Offset: 0x00A3A492
		public float Yaw { get; set; }

		// Token: 0x17007398 RID: 29592
		// (get) Token: 0x0602D5F2 RID: 185842 RVA: 0x00A3C29B File Offset: 0x00A3A49B
		// (set) Token: 0x0602D5F3 RID: 185843 RVA: 0x00A3C2A3 File Offset: 0x00A3A4A3
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<Vector, Vector>> DownRayLines { [return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] set; } = new List<ValueTuple<Vector, Vector>>();

		// Token: 0x0602D5F4 RID: 185844 RVA: 0x00A3C2AC File Offset: 0x00A3A4AC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ChairSummonResult()
		{
		}
	}
}
