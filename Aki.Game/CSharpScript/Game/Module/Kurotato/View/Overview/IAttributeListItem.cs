using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005741 RID: 22337
	[NullableContext(2)]
	public interface IAttributeListItem : IKurotatoRoleSkillInfo
	{
		// Token: 0x1700886C RID: 34924
		// (get) Token: 0x06038C95 RID: 232597
		// (set) Token: 0x06038C96 RID: 232598
		bool? JustChanged { get; set; }

		// Token: 0x1700886D RID: 34925
		// (get) Token: 0x06038C97 RID: 232599
		// (set) Token: 0x06038C98 RID: 232600
		IKurotatoAttrPreviewDelta Preview { get; set; }
	}
}
