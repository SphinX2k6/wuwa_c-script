using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581B RID: 22555
	public class IRefreshConditionBaseT
	{
		// Token: 0x1700A87F RID: 43135
		// (get) Token: 0x06025EDC RID: 155356 RVA: 0x0053AE16 File Offset: 0x00539016
		// (set) Token: 0x06025EDD RID: 155357 RVA: 0x0053AE1E File Offset: 0x0053901E
		public ERewardDropType Type { get; set; }

		// Token: 0x06025EDE RID: 155358 RVA: 0x0053AE27 File Offset: 0x00539027
		public IRefreshConditionBaseT()
		{
			this.Type = ERewardDropType.Death;
		}
	}
}
