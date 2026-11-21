using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x020040FC RID: 16636
	[RequiredMember]
	public class BadgeGroupSkillData
	{
		// Token: 0x0602A05A RID: 172122 RVA: 0x00BE1636 File Offset: 0x00BDF836
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BadgeGroupSkillData()
		{
		}

		// Token: 0x04016ED0 RID: 93904
		[RequiredMember]
		public int GroupId;

		// Token: 0x04016ED1 RID: 93905
		[RequiredMember]
		public int SkillId;
	}
}
