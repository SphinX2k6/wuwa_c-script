using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006313 RID: 25363
	[RequiredMember]
	public class JumpProjectileParams : IJumpProjectileParams
	{
		// Token: 0x17007453 RID: 29779
		// (get) Token: 0x0603D61F RID: 251423 RVA: 0x011BF5CF File Offset: 0x011BD7CF
		// (set) Token: 0x0603D620 RID: 251424 RVA: 0x011BF5D7 File Offset: 0x011BD7D7
		[RequiredMember]
		public float Length { get; set; }

		// Token: 0x17007454 RID: 29780
		// (get) Token: 0x0603D621 RID: 251425 RVA: 0x011BF5E0 File Offset: 0x011BD7E0
		// (set) Token: 0x0603D622 RID: 251426 RVA: 0x011BF5E8 File Offset: 0x011BD7E8
		[RequiredMember]
		public float AllTime { get; set; }

		// Token: 0x17007455 RID: 29781
		// (get) Token: 0x0603D623 RID: 251427 RVA: 0x011BF5F1 File Offset: 0x011BD7F1
		// (set) Token: 0x0603D624 RID: 251428 RVA: 0x011BF5F9 File Offset: 0x011BD7F9
		[RequiredMember]
		public float Height0 { get; set; }

		// Token: 0x17007456 RID: 29782
		// (get) Token: 0x0603D625 RID: 251429 RVA: 0x011BF602 File Offset: 0x011BD802
		// (set) Token: 0x0603D626 RID: 251430 RVA: 0x011BF60A File Offset: 0x011BD80A
		[RequiredMember]
		public float ProjectileA { get; set; }

		// Token: 0x17007457 RID: 29783
		// (get) Token: 0x0603D627 RID: 251431 RVA: 0x011BF613 File Offset: 0x011BD813
		// (set) Token: 0x0603D628 RID: 251432 RVA: 0x011BF61B File Offset: 0x011BD81B
		[RequiredMember]
		public float ProjectileB { get; set; }

		// Token: 0x0603D629 RID: 251433 RVA: 0x011BF624 File Offset: 0x011BD824
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public JumpProjectileParams()
		{
		}
	}
}
