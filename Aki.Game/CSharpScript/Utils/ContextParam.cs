using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x0200340D RID: 13325
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ContextParam
	{
		// Token: 0x06021E1A RID: 138778 RVA: 0x0096EB81 File Offset: 0x0096CD81
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ContextParam()
		{
		}

		// Token: 0x04012AF8 RID: 76536
		public long SkillId;

		// Token: 0x04012AF9 RID: 76537
		[RequiredMember]
		public Entity Owner;

		// Token: 0x04012AFA RID: 76538
		[RequiredMember]
		public CharacterBuffComponent BuffComp;

		// Token: 0x04012AFB RID: 76539
		[RequiredMember]
		public CharacterPassiveSkillComponent PassiveSkillComp;
	}
}
