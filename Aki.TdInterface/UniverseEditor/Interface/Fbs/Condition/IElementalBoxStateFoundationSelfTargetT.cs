using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BFF RID: 19455
	public class IElementalBoxStateFoundationSelfTargetT
	{
		// Token: 0x17008D53 RID: 36179
		// (get) Token: 0x0601ECED RID: 126189 RVA: 0x00450A13 File Offset: 0x0044EC13
		// (set) Token: 0x0601ECEE RID: 126190 RVA: 0x00450A1B File Offset: 0x0044EC1B
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17008D54 RID: 36180
		// (get) Token: 0x0601ECEF RID: 126191 RVA: 0x00450A24 File Offset: 0x0044EC24
		// (set) Token: 0x0601ECF0 RID: 126192 RVA: 0x00450A2C File Offset: 0x0044EC2C
		public string State { get; set; }

		// Token: 0x0601ECF1 RID: 126193 RVA: 0x00450A35 File Offset: 0x0044EC35
		public IElementalBoxStateFoundationSelfTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.State = null;
		}
	}
}
