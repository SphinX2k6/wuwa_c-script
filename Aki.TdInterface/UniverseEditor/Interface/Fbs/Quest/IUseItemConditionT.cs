using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004242 RID: 16962
	public class IUseItemConditionT
	{
		// Token: 0x1700786F RID: 30831
		// (get) Token: 0x06019161 RID: 102753 RVA: 0x0039B9AB File Offset: 0x00399BAB
		// (set) Token: 0x06019162 RID: 102754 RVA: 0x0039B9B3 File Offset: 0x00399BB3
		public int ItemId { get; set; }

		// Token: 0x17007870 RID: 30832
		// (get) Token: 0x06019163 RID: 102755 RVA: 0x0039B9BC File Offset: 0x00399BBC
		// (set) Token: 0x06019164 RID: 102756 RVA: 0x0039B9C4 File Offset: 0x00399BC4
		public int Count { get; set; }

		// Token: 0x17007871 RID: 30833
		// (get) Token: 0x06019165 RID: 102757 RVA: 0x0039B9CD File Offset: 0x00399BCD
		// (set) Token: 0x06019166 RID: 102758 RVA: 0x0039B9D5 File Offset: 0x00399BD5
		public EChildQuest Type { get; set; }

		// Token: 0x17007872 RID: 30834
		// (get) Token: 0x06019167 RID: 102759 RVA: 0x0039B9DE File Offset: 0x00399BDE
		// (set) Token: 0x06019168 RID: 102760 RVA: 0x0039B9E6 File Offset: 0x00399BE6
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x06019169 RID: 102761 RVA: 0x0039B9EF File Offset: 0x00399BEF
		public IUseItemConditionT()
		{
			this.ItemId = 0;
			this.Count = 0;
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
