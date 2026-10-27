using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006302 RID: 25346
	public class PinballAttributeItemData : IPinballAttributeItemData
	{
		// Token: 0x170092C1 RID: 37569
		// (get) Token: 0x0603FC71 RID: 261233 RVA: 0x00F6E527 File Offset: 0x00F6C727
		// (set) Token: 0x0603FC72 RID: 261234 RVA: 0x00F6E52F File Offset: 0x00F6C72F
		public bool IsBgShow { get; set; }

		// Token: 0x170092C2 RID: 37570
		// (get) Token: 0x0603FC73 RID: 261235 RVA: 0x00F6E538 File Offset: 0x00F6C738
		// (set) Token: 0x0603FC74 RID: 261236 RVA: 0x00F6E540 File Offset: 0x00F6C740
		public PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x170092C3 RID: 37571
		// (get) Token: 0x0603FC75 RID: 261237 RVA: 0x00F6E549 File Offset: 0x00F6C749
		// (set) Token: 0x0603FC76 RID: 261238 RVA: 0x00F6E551 File Offset: 0x00F6C751
		public int AttributeValue { get; set; }
	}
}
