using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004634 RID: 17972
	public class IAddAllRoleT
	{
		// Token: 0x17007F89 RID: 32649
		// (get) Token: 0x0601B383 RID: 111491 RVA: 0x003E002A File Offset: 0x003DE22A
		// (set) Token: 0x0601B384 RID: 111492 RVA: 0x003E0032 File Offset: 0x003DE232
		public EGmCommand Type { get; set; }

		// Token: 0x0601B385 RID: 111493 RVA: 0x003E003B File Offset: 0x003DE23B
		public IAddAllRoleT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
