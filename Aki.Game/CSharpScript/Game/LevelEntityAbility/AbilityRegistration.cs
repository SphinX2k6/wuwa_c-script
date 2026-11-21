using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006131 RID: 24881
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AbilityRegistration
	{
		// Token: 0x170070AF RID: 28847
		// (get) Token: 0x0603B978 RID: 244088 RVA: 0x010E6973 File Offset: 0x010E4B73
		// (set) Token: 0x0603B979 RID: 244089 RVA: 0x010E697B File Offset: 0x010E4B7B
		[RequiredMember]
		public Func<ELevelEntityAbilityType, EAbilityTickPhase, int, bool, LevelEntityAbilityBase> Creator { get; set; }

		// Token: 0x170070B0 RID: 28848
		// (get) Token: 0x0603B97A RID: 244090 RVA: 0x010E6984 File Offset: 0x010E4B84
		// (set) Token: 0x0603B97B RID: 244091 RVA: 0x010E698C File Offset: 0x010E4B8C
		[RequiredMember]
		public LevelAbilityConfig Config { get; set; }

		// Token: 0x0603B97C RID: 244092 RVA: 0x010E6995 File Offset: 0x010E4B95
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AbilityRegistration()
		{
		}
	}
}
