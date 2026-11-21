using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004718 RID: 18200
	[NullableContext(2)]
	public interface IAttributeListItem : IKurotatoRoleSkillInfo
	{
		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x0602DBA5 RID: 187301
		// (set) Token: 0x0602DBA6 RID: 187302
		bool? JustChanged { get; set; }

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x0602DBA7 RID: 187303
		// (set) Token: 0x0602DBA8 RID: 187304
		IKurotatoAttrPreviewDelta Preview { get; set; }
	}
}
