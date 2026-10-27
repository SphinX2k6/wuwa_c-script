using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCF RID: 16335
	public class IQuestConditionT
	{
		// Token: 0x1700726F RID: 29295
		// (get) Token: 0x06017705 RID: 96005 RVA: 0x00361593 File Offset: 0x0035F793
		// (set) Token: 0x06017706 RID: 96006 RVA: 0x0036159B File Offset: 0x0035F79B
		public EChildQuest Type { get; set; }

		// Token: 0x17007270 RID: 29296
		// (get) Token: 0x06017707 RID: 96007 RVA: 0x003615A4 File Offset: 0x0035F7A4
		// (set) Token: 0x06017708 RID: 96008 RVA: 0x003615AC File Offset: 0x0035F7AC
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x06017709 RID: 96009 RVA: 0x003615B5 File Offset: 0x0035F7B5
		public IQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
		}
	}
}
