using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02004760 RID: 18272
	[RequiredMember]
	public class AttackSession : IAttackSession
	{
		// Token: 0x17007753 RID: 30547
		// (get) Token: 0x0602FC50 RID: 195664 RVA: 0x00B11027 File Offset: 0x00B0F227
		// (set) Token: 0x0602FC51 RID: 195665 RVA: 0x00B1102F File Offset: 0x00B0F22F
		[RequiredMember]
		public UniTask HitOrFinished { get; set; }

		// Token: 0x17007754 RID: 30548
		// (get) Token: 0x0602FC52 RID: 195666 RVA: 0x00B11038 File Offset: 0x00B0F238
		// (set) Token: 0x0602FC53 RID: 195667 RVA: 0x00B11040 File Offset: 0x00B0F240
		[RequiredMember]
		public UniTask Finished { get; set; }

		// Token: 0x0602FC54 RID: 195668 RVA: 0x00B11049 File Offset: 0x00B0F249
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AttackSession()
		{
		}
	}
}
