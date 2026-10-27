using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A16 RID: 14870
	public class IBlackBoardFloatT
	{
		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x0601419B RID: 82331 RVA: 0x002F1135 File Offset: 0x002EF335
		// (set) Token: 0x0601419C RID: 82332 RVA: 0x002F113D File Offset: 0x002EF33D
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x0601419D RID: 82333 RVA: 0x002F1146 File Offset: 0x002EF346
		// (set) Token: 0x0601419E RID: 82334 RVA: 0x002F114E File Offset: 0x002EF34E
		public string Key { get; set; }

		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x0601419F RID: 82335 RVA: 0x002F1157 File Offset: 0x002EF357
		// (set) Token: 0x060141A0 RID: 82336 RVA: 0x002F115F File Offset: 0x002EF35F
		public float Value { get; set; }

		// Token: 0x060141A1 RID: 82337 RVA: 0x002F1168 File Offset: 0x002EF368
		public IBlackBoardFloatT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.Value = 0f;
		}
	}
}
