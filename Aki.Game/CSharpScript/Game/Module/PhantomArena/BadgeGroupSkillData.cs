using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x0200512C RID: 20780
	[RequiredMember]
	public class BadgeGroupSkillData
	{
		// Token: 0x06035161 RID: 217441 RVA: 0x00C94222 File Offset: 0x00C92422
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public BadgeGroupSkillData()
		{
		}

		// Token: 0x0401C49B RID: 115867
		[RequiredMember]
		public int GroupId;

		// Token: 0x0401C49C RID: 115868
		[RequiredMember]
		public int SkillId;
	}
}
