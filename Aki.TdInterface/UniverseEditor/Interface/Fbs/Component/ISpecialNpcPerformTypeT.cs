using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005972 RID: 22898
	public class ISpecialNpcPerformTypeT
	{
		// Token: 0x1700ABD6 RID: 43990
		// (get) Token: 0x06026C2F RID: 158767 RVA: 0x005560F6 File Offset: 0x005542F6
		// (set) Token: 0x06026C30 RID: 158768 RVA: 0x005560FE File Offset: 0x005542FE
		public ESpecialNpcType Type { get; set; }

		// Token: 0x06026C31 RID: 158769 RVA: 0x00556107 File Offset: 0x00554307
		public ISpecialNpcPerformTypeT()
		{
			this.Type = ESpecialNpcType.BaseRoleNpc;
		}
	}
}
