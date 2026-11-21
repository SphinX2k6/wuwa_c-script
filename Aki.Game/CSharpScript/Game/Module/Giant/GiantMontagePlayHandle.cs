using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02004931 RID: 18737
	[RequiredMember]
	public class GiantMontagePlayHandle
	{
		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x0602EF97 RID: 192407 RVA: 0x00D1A426 File Offset: 0x00D18626
		// (set) Token: 0x0602EF98 RID: 192408 RVA: 0x00D1A42E File Offset: 0x00D1862E
		[RequiredMember]
		public bool IsHoldAtEnd { get; set; }

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x0602EF99 RID: 192409 RVA: 0x00D1A437 File Offset: 0x00D18637
		// (set) Token: 0x0602EF9A RID: 192410 RVA: 0x00D1A43F File Offset: 0x00D1863F
		[RequiredMember]
		public UniTask BlendOut { get; set; }

		// Token: 0x0602EF9B RID: 192411 RVA: 0x00D1A448 File Offset: 0x00D18648
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantMontagePlayHandle()
		{
		}
	}
}
