using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C05 RID: 19461
	public class IElementalBoxStatePlayerTargetT
	{
		// Token: 0x17008D5F RID: 36191
		// (get) Token: 0x0601ED21 RID: 126241 RVA: 0x00450EFF File Offset: 0x0044F0FF
		// (set) Token: 0x0601ED22 RID: 126242 RVA: 0x00450F07 File Offset: 0x0044F107
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x17008D60 RID: 36192
		// (get) Token: 0x0601ED23 RID: 126243 RVA: 0x00450F10 File Offset: 0x0044F110
		// (set) Token: 0x0601ED24 RID: 126244 RVA: 0x00450F18 File Offset: 0x0044F118
		public string State { get; set; }

		// Token: 0x0601ED25 RID: 126245 RVA: 0x00450F21 File Offset: 0x0044F121
		public IElementalBoxStatePlayerTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.State = null;
		}
	}
}
