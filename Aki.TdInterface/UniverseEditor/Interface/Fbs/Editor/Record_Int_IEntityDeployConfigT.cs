using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D2 RID: 18642
	public class Record_Int_IEntityDeployConfigT
	{
		// Token: 0x17008758 RID: 34648
		// (get) Token: 0x0601D276 RID: 119414 RVA: 0x0041D9F3 File Offset: 0x0041BBF3
		// (set) Token: 0x0601D277 RID: 119415 RVA: 0x0041D9FB File Offset: 0x0041BBFB
		public int Key { get; set; }

		// Token: 0x17008759 RID: 34649
		// (get) Token: 0x0601D278 RID: 119416 RVA: 0x0041DA04 File Offset: 0x0041BC04
		// (set) Token: 0x0601D279 RID: 119417 RVA: 0x0041DA0C File Offset: 0x0041BC0C
		public IEntityDeployConfigT Value { get; set; }

		// Token: 0x0601D27A RID: 119418 RVA: 0x0041DA15 File Offset: 0x0041BC15
		public Record_Int_IEntityDeployConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
