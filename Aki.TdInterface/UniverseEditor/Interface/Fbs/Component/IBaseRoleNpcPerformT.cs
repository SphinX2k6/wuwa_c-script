using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200541F RID: 21535
	public class IBaseRoleNpcPerformT
	{
		// Token: 0x170098D0 RID: 39120
		// (get) Token: 0x06021BC9 RID: 138185 RVA: 0x004A6982 File Offset: 0x004A4B82
		// (set) Token: 0x06021BCA RID: 138186 RVA: 0x004A698A File Offset: 0x004A4B8A
		public ESpecialNpcType Type { get; set; }

		// Token: 0x06021BCB RID: 138187 RVA: 0x004A6993 File Offset: 0x004A4B93
		public IBaseRoleNpcPerformT()
		{
			this.Type = ESpecialNpcType.BaseRoleNpc;
		}
	}
}
