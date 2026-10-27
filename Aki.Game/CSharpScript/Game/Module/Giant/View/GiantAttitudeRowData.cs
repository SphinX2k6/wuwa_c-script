using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005977 RID: 22903
	[RequiredMember]
	public class GiantAttitudeRowData
	{
		// Token: 0x0603A21E RID: 238110 RVA: 0x00DD2AE1 File Offset: 0x00DD0CE1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GiantAttitudeRowData()
		{
		}

		// Token: 0x0401E54A RID: 124234
		[Nullable(1)]
		[RequiredMember]
		public string Text;

		// Token: 0x0401E54B RID: 124235
		[Nullable(2)]
		public string IconPath;
	}
}
