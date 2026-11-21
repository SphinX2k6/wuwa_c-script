using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB1 RID: 19121
	public class IExitDungeonInGmT
	{
		// Token: 0x170085E9 RID: 34281
		// (get) Token: 0x0601CBF2 RID: 117746 RVA: 0x0040D19E File Offset: 0x0040B39E
		// (set) Token: 0x0601CBF3 RID: 117747 RVA: 0x0040D1A6 File Offset: 0x0040B3A6
		public EGmCommand Type { get; set; }

		// Token: 0x0601CBF4 RID: 117748 RVA: 0x0040D1AF File Offset: 0x0040B3AF
		public IExitDungeonInGmT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
