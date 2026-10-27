using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005043 RID: 20547
	public class ICreateBulletDestroyConditionT
	{
		// Token: 0x17009518 RID: 38168
		// (get) Token: 0x06020EC7 RID: 134855 RVA: 0x00493BCA File Offset: 0x00491DCA
		// (set) Token: 0x06020EC8 RID: 134856 RVA: 0x00493BD2 File Offset: 0x00491DD2
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x06020EC9 RID: 134857 RVA: 0x00493BDB File Offset: 0x00491DDB
		public ICreateBulletDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
