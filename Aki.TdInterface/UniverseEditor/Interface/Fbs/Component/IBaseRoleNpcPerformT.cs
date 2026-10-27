using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EED RID: 20205
	public class IBaseRoleNpcPerformT
	{
		// Token: 0x1700914E RID: 37198
		// (get) Token: 0x0601FE59 RID: 130649 RVA: 0x004705EE File Offset: 0x0046E7EE
		// (set) Token: 0x0601FE5A RID: 130650 RVA: 0x004705F6 File Offset: 0x0046E7F6
		public ESpecialNpcType Type { get; set; }

		// Token: 0x0601FE5B RID: 130651 RVA: 0x004705FF File Offset: 0x0046E7FF
		public IBaseRoleNpcPerformT()
		{
			this.Type = ESpecialNpcType.BaseRoleNpc;
		}
	}
}
