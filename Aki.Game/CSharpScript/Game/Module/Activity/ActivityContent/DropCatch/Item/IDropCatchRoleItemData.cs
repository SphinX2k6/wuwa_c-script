using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item
{
	// Token: 0x0200563B RID: 22075
	public interface IDropCatchRoleItemData
	{
		// Token: 0x17006990 RID: 27024
		// (get) Token: 0x060368AA RID: 223402
		// (set) Token: 0x060368AB RID: 223403
		int RoleCfgId { get; set; }

		// Token: 0x17006991 RID: 27025
		// (get) Token: 0x060368AC RID: 223404
		// (set) Token: 0x060368AD RID: 223405
		int BookCfgId { get; set; }

		// Token: 0x17006992 RID: 27026
		// (get) Token: 0x060368AE RID: 223406
		// (set) Token: 0x060368AF RID: 223407
		bool IsUnlock { get; set; }
	}
}
