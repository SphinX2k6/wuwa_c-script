using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02004950 RID: 18768
	[RequiredMember]
	public class GiantAttitudeRowData
	{
		// Token: 0x0602F144 RID: 192836 RVA: 0x00D21F71 File Offset: 0x00D20171
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantAttitudeRowData()
		{
		}

		// Token: 0x04018FE8 RID: 102376
		[Nullable(1)]
		[RequiredMember]
		public string Text;

		// Token: 0x04018FE9 RID: 102377
		[Nullable(2)]
		public string IconPath;
	}
}
