using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB6 RID: 19638
	public class IRoleLevelTypeT
	{
		// Token: 0x17008E99 RID: 36505
		// (get) Token: 0x0601F299 RID: 127641 RVA: 0x0045A16E File Offset: 0x0045836E
		// (set) Token: 0x0601F29A RID: 127642 RVA: 0x0045A176 File Offset: 0x00458376
		public ERoleLevelType Type { get; set; }

		// Token: 0x0601F29B RID: 127643 RVA: 0x0045A17F File Offset: 0x0045837F
		public IRoleLevelTypeT()
		{
			this.Type = ERoleLevelType.SpecifyRole;
		}
	}
}
