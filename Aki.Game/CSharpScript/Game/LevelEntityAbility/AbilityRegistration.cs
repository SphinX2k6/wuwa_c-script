using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FB0 RID: 28592
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AbilityRegistration
	{
		// Token: 0x17009B6F RID: 39791
		// (get) Token: 0x060457C8 RID: 284616 RVA: 0x0113CB47 File Offset: 0x0113AD47
		// (set) Token: 0x060457C9 RID: 284617 RVA: 0x0113CB4F File Offset: 0x0113AD4F
		[RequiredMember]
		public Func<ELevelEntityAbilityType, EAbilityTickPhase, int, bool, LevelEntityAbilityBase> Creator { get; set; }

		// Token: 0x17009B70 RID: 39792
		// (get) Token: 0x060457CA RID: 284618 RVA: 0x0113CB58 File Offset: 0x0113AD58
		// (set) Token: 0x060457CB RID: 284619 RVA: 0x0113CB60 File Offset: 0x0113AD60
		[RequiredMember]
		public LevelAbilityConfig Config { get; set; }

		// Token: 0x060457CC RID: 284620 RVA: 0x0113CB69 File Offset: 0x0113AD69
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AbilityRegistration()
		{
		}
	}
}
