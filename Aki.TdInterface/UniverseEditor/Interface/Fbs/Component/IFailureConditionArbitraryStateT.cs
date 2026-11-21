using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005788 RID: 22408
	public class IFailureConditionArbitraryStateT
	{
		// Token: 0x1700A1F8 RID: 41464
		// (get) Token: 0x06024251 RID: 148049 RVA: 0x004F84DF File Offset: 0x004F66DF
		// (set) Token: 0x06024252 RID: 148050 RVA: 0x004F84E7 File Offset: 0x004F66E7
		public ETargetGearGroupFailureCondition Type { get; set; }

		// Token: 0x1700A1F9 RID: 41465
		// (get) Token: 0x06024253 RID: 148051 RVA: 0x004F84F0 File Offset: 0x004F66F0
		// (set) Token: 0x06024254 RID: 148052 RVA: 0x004F84F8 File Offset: 0x004F66F8
		public string State { get; set; }

		// Token: 0x06024255 RID: 148053 RVA: 0x004F8501 File Offset: 0x004F6701
		public IFailureConditionArbitraryStateT()
		{
			this.Type = ETargetGearGroupFailureCondition.ArbitraryState;
			this.State = null;
		}
	}
}
