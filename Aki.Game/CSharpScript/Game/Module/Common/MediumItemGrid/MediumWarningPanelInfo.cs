using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B4F RID: 19279
	[RequiredMember]
	public class MediumWarningPanelInfo
	{
		// Token: 0x060302E3 RID: 197347 RVA: 0x00D6F303 File Offset: 0x00D6D503
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MediumWarningPanelInfo()
		{
		}

		// Token: 0x040198E4 RID: 104676
		[Nullable(1)]
		[RequiredMember]
		public string TipText;

		// Token: 0x040198E5 RID: 104677
		[Nullable(2)]
		public string IconPath;
	}
}
