using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003691 RID: 13969
	[RequiredMember]
	public class AttackSession : IAttackSession
	{
		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x0602441A RID: 148506 RVA: 0x00A40FE7 File Offset: 0x00A3F1E7
		// (set) Token: 0x0602441B RID: 148507 RVA: 0x00A40FEF File Offset: 0x00A3F1EF
		[RequiredMember]
		public UniTask HitOrFinished { get; set; }

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x0602441C RID: 148508 RVA: 0x00A40FF8 File Offset: 0x00A3F1F8
		// (set) Token: 0x0602441D RID: 148509 RVA: 0x00A41000 File Offset: 0x00A3F200
		[RequiredMember]
		public UniTask Finished { get; set; }

		// Token: 0x0602441E RID: 148510 RVA: 0x00A41009 File Offset: 0x00A3F209
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AttackSession()
		{
		}
	}
}
