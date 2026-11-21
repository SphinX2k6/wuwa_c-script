using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050F5 RID: 20725
	public class IElementalBoxStateSpecifiedTargetT
	{
		// Token: 0x17009489 RID: 38025
		// (get) Token: 0x06020921 RID: 133409 RVA: 0x004847F9 File Offset: 0x004829F9
		// (set) Token: 0x06020922 RID: 133410 RVA: 0x00484801 File Offset: 0x00482A01
		public EElementalBoxStateTargetType Type { get; set; }

		// Token: 0x1700948A RID: 38026
		// (get) Token: 0x06020923 RID: 133411 RVA: 0x0048480A File Offset: 0x00482A0A
		// (set) Token: 0x06020924 RID: 133412 RVA: 0x00484812 File Offset: 0x00482A12
		public int ElementalBoxId { get; set; }

		// Token: 0x1700948B RID: 38027
		// (get) Token: 0x06020925 RID: 133413 RVA: 0x0048481B File Offset: 0x00482A1B
		// (set) Token: 0x06020926 RID: 133414 RVA: 0x00484823 File Offset: 0x00482A23
		public string State { get; set; }

		// Token: 0x06020927 RID: 133415 RVA: 0x0048482C File Offset: 0x00482A2C
		public IElementalBoxStateSpecifiedTargetT()
		{
			this.Type = EElementalBoxStateTargetType.Player;
			this.ElementalBoxId = 0;
			this.State = null;
		}
	}
}
