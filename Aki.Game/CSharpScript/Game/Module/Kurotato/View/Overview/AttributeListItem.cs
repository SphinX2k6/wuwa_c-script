using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x02004719 RID: 18201
	[NullableContext(2)]
	[Nullable(0)]
	public class AttributeListItem : KurotatoRoleSkillInfo, IAttributeListItem, IKurotatoRoleSkillInfo
	{
		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x0602DBA9 RID: 187305 RVA: 0x00CCA15E File Offset: 0x00CC835E
		// (set) Token: 0x0602DBAA RID: 187306 RVA: 0x00CCA166 File Offset: 0x00CC8366
		public bool? JustChanged { get; set; }

		// Token: 0x17005C37 RID: 23607
		// (get) Token: 0x0602DBAB RID: 187307 RVA: 0x00CCA16F File Offset: 0x00CC836F
		// (set) Token: 0x0602DBAC RID: 187308 RVA: 0x00CCA177 File Offset: 0x00CC8377
		public IKurotatoAttrPreviewDelta Preview { get; set; }
	}
}
