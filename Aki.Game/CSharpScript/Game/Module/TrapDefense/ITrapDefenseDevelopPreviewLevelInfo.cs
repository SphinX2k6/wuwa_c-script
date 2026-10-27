using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A4F RID: 19023
	public interface ITrapDefenseDevelopPreviewLevelInfo
	{
		// Token: 0x17007A5E RID: 31326
		// (get) Token: 0x060315B6 RID: 202166
		// (set) Token: 0x060315B7 RID: 202167
		int Id { get; set; }

		// Token: 0x17007A5F RID: 31327
		// (get) Token: 0x060315B8 RID: 202168
		// (set) Token: 0x060315B9 RID: 202169
		bool IsCurLevel { get; set; }

		// Token: 0x17007A60 RID: 31328
		// (get) Token: 0x060315BA RID: 202170
		// (set) Token: 0x060315BB RID: 202171
		bool? NeedAlpha { get; set; }
	}
}
