using System;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop
{
	// Token: 0x02004D05 RID: 19717
	public class RoleDevProsSpecialGachaConfig : IRoleDevProsSpecialGachaConfig
	{
		// Token: 0x06032FBC RID: 208828 RVA: 0x00BE1A44 File Offset: 0x00BDFC44
		public RoleDevProsSpecialGachaConfig(int TypeId, int GachaId)
		{
		}

		// Token: 0x17007DDF RID: 32223
		// (get) Token: 0x06032FBD RID: 208829 RVA: 0x00BE1A5A File Offset: 0x00BDFC5A
		// (set) Token: 0x06032FBE RID: 208830 RVA: 0x00BE1A62 File Offset: 0x00BDFC62
		public int TypeId { get; set; } = TypeId;

		// Token: 0x17007DE0 RID: 32224
		// (get) Token: 0x06032FBF RID: 208831 RVA: 0x00BE1A6B File Offset: 0x00BDFC6B
		// (set) Token: 0x06032FC0 RID: 208832 RVA: 0x00BE1A73 File Offset: 0x00BDFC73
		public int GachaId { get; set; } = GachaId;
	}
}
