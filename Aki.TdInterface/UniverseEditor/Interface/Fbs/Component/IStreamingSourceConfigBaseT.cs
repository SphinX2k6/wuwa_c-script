using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D8 RID: 23000
	public class IStreamingSourceConfigBaseT
	{
		// Token: 0x1700ACD0 RID: 44240
		// (get) Token: 0x06027054 RID: 159828 RVA: 0x0055E896 File Offset: 0x0055CA96
		// (set) Token: 0x06027055 RID: 159829 RVA: 0x0055E89E File Offset: 0x0055CA9E
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x06027056 RID: 159830 RVA: 0x0055E8A7 File Offset: 0x0055CAA7
		public IStreamingSourceConfigBaseT()
		{
			this.Type = EStreamingSourceMode.Fixed;
		}
	}
}
