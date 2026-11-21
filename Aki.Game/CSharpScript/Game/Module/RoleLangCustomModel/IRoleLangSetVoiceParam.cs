using System;

namespace CSharpScript.Game.Module.RoleLangCustomModel
{
	// Token: 0x02003D3F RID: 15679
	public interface IRoleLangSetVoiceParam
	{
		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x0602825B RID: 164443
		// (set) Token: 0x0602825C RID: 164444
		int RoleId { get; set; }

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x0602825D RID: 164445
		// (set) Token: 0x0602825E RID: 164446
		int Lang { get; set; }

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x0602825F RID: 164447
		// (set) Token: 0x06028260 RID: 164448
		bool NeedRequest { get; set; }

		// Token: 0x17005228 RID: 21032
		// (get) Token: 0x06028261 RID: 164449
		// (set) Token: 0x06028262 RID: 164450
		bool IsCustom { get; set; }

		// Token: 0x17005229 RID: 21033
		// (get) Token: 0x06028263 RID: 164451
		// (set) Token: 0x06028264 RID: 164452
		bool IsCover { get; set; }
	}
}
