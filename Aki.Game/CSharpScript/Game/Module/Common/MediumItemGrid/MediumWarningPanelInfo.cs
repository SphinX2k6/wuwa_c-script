using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B6F RID: 23407
	[RequiredMember]
	public class MediumWarningPanelInfo
	{
		// Token: 0x0603B396 RID: 242582 RVA: 0x00E1ED8F File Offset: 0x00E1CF8F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumWarningPanelInfo()
		{
		}

		// Token: 0x0401EE33 RID: 126515
		[Nullable(1)]
		[RequiredMember]
		public string TipText;

		// Token: 0x0401EE34 RID: 126516
		[Nullable(2)]
		public string IconPath;
	}
}
