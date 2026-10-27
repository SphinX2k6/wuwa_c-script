using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x020044EB RID: 17643
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class ContextParam
	{
		// Token: 0x0602D74A RID: 186186 RVA: 0x00A42D71 File Offset: 0x00A40F71
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ContextParam()
		{
		}

		// Token: 0x040184D0 RID: 99536
		public long SkillId;

		// Token: 0x040184D1 RID: 99537
		[RequiredMember]
		public Entity Owner;

		// Token: 0x040184D2 RID: 99538
		[RequiredMember]
		public CharacterBuffComponent BuffComp;

		// Token: 0x040184D3 RID: 99539
		[RequiredMember]
		public CharacterPassiveSkillComponent PassiveSkillComp;
	}
}
