using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741F RID: 29727
	public class IToolEditorActionContextT
	{
		// Token: 0x1700E1B7 RID: 57783
		// (get) Token: 0x06036003 RID: 221187 RVA: 0x00758971 File Offset: 0x00756B71
		// (set) Token: 0x06036004 RID: 221188 RVA: 0x00758979 File Offset: 0x00756B79
		public string Type { get; set; }

		// Token: 0x06036005 RID: 221189 RVA: 0x00758982 File Offset: 0x00756B82
		public IToolEditorActionContextT()
		{
			this.Type = null;
		}
	}
}
