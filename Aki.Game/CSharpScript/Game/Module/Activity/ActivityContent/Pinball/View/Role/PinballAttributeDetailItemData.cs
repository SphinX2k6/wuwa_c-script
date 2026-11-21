using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200527C RID: 21116
	public class PinballAttributeDetailItemData : IPinballAttributeDetailItemData
	{
		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x06034919 RID: 215321 RVA: 0x00EB504D File Offset: 0x00EB324D
		// (set) Token: 0x0603491A RID: 215322 RVA: 0x00EB5055 File Offset: 0x00EB3255
		public bool IsBgShow { get; set; }

		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x0603491B RID: 215323 RVA: 0x00EB505E File Offset: 0x00EB325E
		// (set) Token: 0x0603491C RID: 215324 RVA: 0x00EB5066 File Offset: 0x00EB3266
		public PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x1700661E RID: 26142
		// (get) Token: 0x0603491D RID: 215325 RVA: 0x00EB506F File Offset: 0x00EB326F
		// (set) Token: 0x0603491E RID: 215326 RVA: 0x00EB5077 File Offset: 0x00EB3277
		public int AttributeValue { get; set; }

		// Token: 0x1700661F RID: 26143
		// (get) Token: 0x0603491F RID: 215327 RVA: 0x00EB5080 File Offset: 0x00EB3280
		// (set) Token: 0x06034920 RID: 215328 RVA: 0x00EB5088 File Offset: 0x00EB3288
		public bool IsExpanded { get; set; }
	}
}
