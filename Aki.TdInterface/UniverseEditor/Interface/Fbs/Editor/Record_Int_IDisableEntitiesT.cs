using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048CF RID: 18639
	public class Record_Int_IDisableEntitiesT
	{
		// Token: 0x17008753 RID: 34643
		// (get) Token: 0x0601D260 RID: 119392 RVA: 0x0041D767 File Offset: 0x0041B967
		// (set) Token: 0x0601D261 RID: 119393 RVA: 0x0041D76F File Offset: 0x0041B96F
		public int Key { get; set; }

		// Token: 0x17008754 RID: 34644
		// (get) Token: 0x0601D262 RID: 119394 RVA: 0x0041D778 File Offset: 0x0041B978
		// (set) Token: 0x0601D263 RID: 119395 RVA: 0x0041D780 File Offset: 0x0041B980
		public IDisableEntitiesT Value { get; set; }

		// Token: 0x0601D264 RID: 119396 RVA: 0x0041D789 File Offset: 0x0041B989
		public Record_Int_IDisableEntitiesT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
