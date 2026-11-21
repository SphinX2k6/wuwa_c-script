using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F7F RID: 24447
	public class ISpecialNpcPerformTypeT
	{
		// Token: 0x1700B50A RID: 46346
		// (get) Token: 0x06029199 RID: 168345 RVA: 0x0059CD62 File Offset: 0x0059AF62
		// (set) Token: 0x0602919A RID: 168346 RVA: 0x0059CD6A File Offset: 0x0059AF6A
		public ESpecialNpcType Type { get; set; }

		// Token: 0x0602919B RID: 168347 RVA: 0x0059CD73 File Offset: 0x0059AF73
		public ISpecialNpcPerformTypeT()
		{
			this.Type = ESpecialNpcType.BaseRoleNpc;
		}
	}
}
