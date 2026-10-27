using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DFB RID: 15867
	public class IEnterDungeonConditionT
	{
		// Token: 0x17006DA8 RID: 28072
		// (get) Token: 0x06016319 RID: 90905 RVA: 0x00334921 File Offset: 0x00332B21
		// (set) Token: 0x0601631A RID: 90906 RVA: 0x00334929 File Offset: 0x00332B29
		public EChildQuest Type { get; set; }

		// Token: 0x17006DA9 RID: 28073
		// (get) Token: 0x0601631B RID: 90907 RVA: 0x00334932 File Offset: 0x00332B32
		// (set) Token: 0x0601631C RID: 90908 RVA: 0x0033493A File Offset: 0x00332B3A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006DAA RID: 28074
		// (get) Token: 0x0601631D RID: 90909 RVA: 0x00334943 File Offset: 0x00332B43
		// (set) Token: 0x0601631E RID: 90910 RVA: 0x0033494B File Offset: 0x00332B4B
		public TEnterDungeonUnion EnterType { get; set; }

		// Token: 0x0601631F RID: 90911 RVA: 0x00334954 File Offset: 0x00332B54
		public IEnterDungeonConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.EnterType = null;
		}
	}
}
