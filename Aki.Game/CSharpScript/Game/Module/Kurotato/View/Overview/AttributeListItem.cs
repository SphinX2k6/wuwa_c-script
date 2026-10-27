using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02005742 RID: 22338
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeListItem : KurotatoRoleSkillInfo, IAttributeListItem, IKurotatoRoleSkillInfo
	{
		// Token: 0x1700886E RID: 34926
		// (get) Token: 0x06038C99 RID: 232601 RVA: 0x00D7BAAE File Offset: 0x00D79CAE
		// (set) Token: 0x06038C9A RID: 232602 RVA: 0x00D7BAB6 File Offset: 0x00D79CB6
		public bool? JustChanged { get; set; }

		// Token: 0x1700886F RID: 34927
		// (get) Token: 0x06038C9B RID: 232603 RVA: 0x00D7BABF File Offset: 0x00D79CBF
		// (set) Token: 0x06038C9C RID: 232604 RVA: 0x00D7BAC7 File Offset: 0x00D79CC7
		public IKurotatoAttrPreviewDelta Preview { get; set; }
	}
}
