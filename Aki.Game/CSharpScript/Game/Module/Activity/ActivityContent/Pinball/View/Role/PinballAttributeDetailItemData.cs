using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x020062FE RID: 25342
	public class PinballAttributeDetailItemData : IPinballAttributeDetailItemData
	{
		// Token: 0x170092BA RID: 37562
		// (get) Token: 0x0603FC58 RID: 261208 RVA: 0x00F6E0F1 File Offset: 0x00F6C2F1
		// (set) Token: 0x0603FC59 RID: 261209 RVA: 0x00F6E0F9 File Offset: 0x00F6C2F9
		public bool IsBgShow { get; set; }

		// Token: 0x170092BB RID: 37563
		// (get) Token: 0x0603FC5A RID: 261210 RVA: 0x00F6E102 File Offset: 0x00F6C302
		// (set) Token: 0x0603FC5B RID: 261211 RVA: 0x00F6E10A File Offset: 0x00F6C30A
		public PinballPropertyIndex AttributeConfig { get; set; }

		// Token: 0x170092BC RID: 37564
		// (get) Token: 0x0603FC5C RID: 261212 RVA: 0x00F6E113 File Offset: 0x00F6C313
		// (set) Token: 0x0603FC5D RID: 261213 RVA: 0x00F6E11B File Offset: 0x00F6C31B
		public int AttributeValue { get; set; }

		// Token: 0x170092BD RID: 37565
		// (get) Token: 0x0603FC5E RID: 261214 RVA: 0x00F6E124 File Offset: 0x00F6C324
		// (set) Token: 0x0603FC5F RID: 261215 RVA: 0x00F6E12C File Offset: 0x00F6C32C
		public bool IsExpanded { get; set; }
	}
}
