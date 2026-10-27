using System;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054C0 RID: 21696
	public class CreateMarkParam : ICreateMarkParam
	{
		// Token: 0x170084D8 RID: 34008
		// (get) Token: 0x0603765E RID: 226910 RVA: 0x00D27C54 File Offset: 0x00D25E54
		// (set) Token: 0x0603765F RID: 226911 RVA: 0x00D27C5C File Offset: 0x00D25E5C
		public int MarkId { get; set; }

		// Token: 0x170084D9 RID: 34009
		// (get) Token: 0x06037660 RID: 226912 RVA: 0x00D27C65 File Offset: 0x00D25E65
		// (set) Token: 0x06037661 RID: 226913 RVA: 0x00D27C6D File Offset: 0x00D25E6D
		public EMarkType MarkType { get; set; }

		// Token: 0x170084DA RID: 34010
		// (get) Token: 0x06037662 RID: 226914 RVA: 0x00D27C76 File Offset: 0x00D25E76
		// (set) Token: 0x06037663 RID: 226915 RVA: 0x00D27C7E File Offset: 0x00D25E7E
		public EMapGravityDirection Gravity { get; set; }

		// Token: 0x170084DB RID: 34011
		// (get) Token: 0x06037664 RID: 226916 RVA: 0x00D27C87 File Offset: 0x00D25E87
		// (set) Token: 0x06037665 RID: 226917 RVA: 0x00D27C8F File Offset: 0x00D25E8F
		public MapMark Config { get; set; }

		// Token: 0x170084DC RID: 34012
		// (get) Token: 0x06037666 RID: 226918 RVA: 0x00D27C98 File Offset: 0x00D25E98
		// (set) Token: 0x06037667 RID: 226919 RVA: 0x00D27CA0 File Offset: 0x00D25EA0
		public DynamicMapMark DynamicConfig { get; set; }

		// Token: 0x170084DD RID: 34013
		// (get) Token: 0x06037668 RID: 226920 RVA: 0x00D27CA9 File Offset: 0x00D25EA9
		// (set) Token: 0x06037669 RID: 226921 RVA: 0x00D27CB1 File Offset: 0x00D25EB1
		public int EntityId { get; set; }

		// Token: 0x170084DE RID: 34014
		// (get) Token: 0x0603766A RID: 226922 RVA: 0x00D27CBA File Offset: 0x00D25EBA
		// (set) Token: 0x0603766B RID: 226923 RVA: 0x00D27CC2 File Offset: 0x00D25EC2
		public int MapId { get; set; }
	}
}
