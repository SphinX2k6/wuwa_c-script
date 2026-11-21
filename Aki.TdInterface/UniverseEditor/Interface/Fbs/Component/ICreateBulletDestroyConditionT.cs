using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A2 RID: 21922
	public class ICreateBulletDestroyConditionT
	{
		// Token: 0x17009CF9 RID: 40185
		// (get) Token: 0x06022DE7 RID: 142823 RVA: 0x004CD61A File Offset: 0x004CB81A
		// (set) Token: 0x06022DE8 RID: 142824 RVA: 0x004CD622 File Offset: 0x004CB822
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x06022DE9 RID: 142825 RVA: 0x004CD62B File Offset: 0x004CB82B
		public ICreateBulletDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
