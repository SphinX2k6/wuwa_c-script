using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004863 RID: 18531
	public class IEditorObjectCacheInfoT
	{
		// Token: 0x17008574 RID: 34164
		// (get) Token: 0x0601CC08 RID: 117768 RVA: 0x00410778 File Offset: 0x0040E978
		// (set) Token: 0x0601CC09 RID: 117769 RVA: 0x00410780 File Offset: 0x0040E980
		public bool UseCache { get; set; }

		// Token: 0x17008575 RID: 34165
		// (get) Token: 0x0601CC0A RID: 117770 RVA: 0x00410789 File Offset: 0x0040E989
		// (set) Token: 0x0601CC0B RID: 117771 RVA: 0x00410791 File Offset: 0x0040E991
		public int Timestamp { get; set; }

		// Token: 0x0601CC0C RID: 117772 RVA: 0x0041079A File Offset: 0x0040E99A
		public IEditorObjectCacheInfoT()
		{
			this.UseCache = false;
			this.Timestamp = 0;
		}
	}
}
