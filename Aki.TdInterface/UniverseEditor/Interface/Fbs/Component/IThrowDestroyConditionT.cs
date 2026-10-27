using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A62 RID: 23138
	public class IThrowDestroyConditionT
	{
		// Token: 0x1700AE1A RID: 44570
		// (get) Token: 0x060275E3 RID: 161251 RVA: 0x0056ADC8 File Offset: 0x00568FC8
		// (set) Token: 0x060275E4 RID: 161252 RVA: 0x0056ADD0 File Offset: 0x00568FD0
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x1700AE1B RID: 44571
		// (get) Token: 0x060275E5 RID: 161253 RVA: 0x0056ADD9 File Offset: 0x00568FD9
		// (set) Token: 0x060275E6 RID: 161254 RVA: 0x0056ADE1 File Offset: 0x00568FE1
		public float DelayTime { get; set; }

		// Token: 0x060275E7 RID: 161255 RVA: 0x0056ADEA File Offset: 0x00568FEA
		public IThrowDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
			this.DelayTime = 0f;
		}
	}
}
