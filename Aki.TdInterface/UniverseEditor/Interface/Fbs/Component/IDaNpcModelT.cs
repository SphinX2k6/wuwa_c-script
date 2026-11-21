using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D5 RID: 21973
	public class IDaNpcModelT
	{
		// Token: 0x17009D50 RID: 40272
		// (get) Token: 0x06022F6D RID: 143213 RVA: 0x004CFE9F File Offset: 0x004CE09F
		// (set) Token: 0x06022F6E RID: 143214 RVA: 0x004CFEA7 File Offset: 0x004CE0A7
		public ENpcModelType Type { get; set; }

		// Token: 0x17009D51 RID: 40273
		// (get) Token: 0x06022F6F RID: 143215 RVA: 0x004CFEB0 File Offset: 0x004CE0B0
		// (set) Token: 0x06022F70 RID: 143216 RVA: 0x004CFEB8 File Offset: 0x004CE0B8
		public string Da { get; set; }

		// Token: 0x06022F71 RID: 143217 RVA: 0x004CFEC1 File Offset: 0x004CE0C1
		public IDaNpcModelT()
		{
			this.Type = ENpcModelType.Mesh;
			this.Da = null;
		}
	}
}
