using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D4A RID: 15690
	public class ICheckConditionGroupQuestConditionT
	{
		// Token: 0x17006BAA RID: 27562
		// (get) Token: 0x06015B13 RID: 88851 RVA: 0x003213A8 File Offset: 0x0031F5A8
		// (set) Token: 0x06015B14 RID: 88852 RVA: 0x003213B0 File Offset: 0x0031F5B0
		public EChildQuest Type { get; set; }

		// Token: 0x17006BAB RID: 27563
		// (get) Token: 0x06015B15 RID: 88853 RVA: 0x003213B9 File Offset: 0x0031F5B9
		// (set) Token: 0x06015B16 RID: 88854 RVA: 0x003213C1 File Offset: 0x0031F5C1
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17006BAC RID: 27564
		// (get) Token: 0x06015B17 RID: 88855 RVA: 0x003213CA File Offset: 0x0031F5CA
		// (set) Token: 0x06015B18 RID: 88856 RVA: 0x003213D2 File Offset: 0x0031F5D2
		public IConditionGroupT Condition { get; set; }

		// Token: 0x06015B19 RID: 88857 RVA: 0x003213DB File Offset: 0x0031F5DB
		public ICheckConditionGroupQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Condition = null;
		}
	}
}
