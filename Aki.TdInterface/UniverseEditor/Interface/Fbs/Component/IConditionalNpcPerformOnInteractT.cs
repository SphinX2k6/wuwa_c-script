using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005545 RID: 21829
	public class IConditionalNpcPerformOnInteractT
	{
		// Token: 0x17009C11 RID: 39953
		// (get) Token: 0x06022A1D RID: 141853 RVA: 0x004C527F File Offset: 0x004C347F
		// (set) Token: 0x06022A1E RID: 141854 RVA: 0x004C5287 File Offset: 0x004C3487
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009C12 RID: 39954
		// (get) Token: 0x06022A1F RID: 141855 RVA: 0x004C5290 File Offset: 0x004C3490
		// (set) Token: 0x06022A20 RID: 141856 RVA: 0x004C5298 File Offset: 0x004C3498
		public INpcPerformOnInteractT Perform { get; set; }

		// Token: 0x06022A21 RID: 141857 RVA: 0x004C52A1 File Offset: 0x004C34A1
		public IConditionalNpcPerformOnInteractT()
		{
			this.Condition = null;
			this.Perform = null;
		}
	}
}
