using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423C RID: 16956
	public class IEnterDungeonSubTypeConditionT
	{
		// Token: 0x17007399 RID: 29593
		// (get) Token: 0x06017974 RID: 96628 RVA: 0x0035D98C File Offset: 0x0035BB8C
		// (set) Token: 0x06017975 RID: 96629 RVA: 0x0035D994 File Offset: 0x0035BB94
		public EDungeonConditionType Type { get; set; }

		// Token: 0x1700739A RID: 29594
		// (get) Token: 0x06017976 RID: 96630 RVA: 0x0035D99D File Offset: 0x0035BB9D
		// (set) Token: 0x06017977 RID: 96631 RVA: 0x0035D9A5 File Offset: 0x0035BBA5
		public EDungeonSubType DungeonSubType { get; set; }

		// Token: 0x06017978 RID: 96632 RVA: 0x0035D9AE File Offset: 0x0035BBAE
		public IEnterDungeonSubTypeConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.DungeonSubType = EDungeonSubType.Test;
		}
	}
}
