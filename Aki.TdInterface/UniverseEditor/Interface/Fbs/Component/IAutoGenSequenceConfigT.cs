using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005413 RID: 21523
	public class IAutoGenSequenceConfigT
	{
		// Token: 0x1700986A RID: 39018
		// (get) Token: 0x06021AA3 RID: 137891 RVA: 0x004A3D71 File Offset: 0x004A1F71
		// (set) Token: 0x06021AA4 RID: 137892 RVA: 0x004A3D79 File Offset: 0x004A1F79
		public string SequencePath { get; set; }

		// Token: 0x1700986B RID: 39019
		// (get) Token: 0x06021AA5 RID: 137893 RVA: 0x004A3D82 File Offset: 0x004A1F82
		// (set) Token: 0x06021AA6 RID: 137894 RVA: 0x004A3D8A File Offset: 0x004A1F8A
		public IPlayLevelSequenceT SequenceConfig { get; set; }

		// Token: 0x1700986C RID: 39020
		// (get) Token: 0x06021AA7 RID: 137895 RVA: 0x004A3D93 File Offset: 0x004A1F93
		// (set) Token: 0x06021AA8 RID: 137896 RVA: 0x004A3D9B File Offset: 0x004A1F9B
		public int Count { get; set; }

		// Token: 0x06021AA9 RID: 137897 RVA: 0x004A3DA4 File Offset: 0x004A1FA4
		public IAutoGenSequenceConfigT()
		{
			this.SequencePath = null;
			this.SequenceConfig = null;
			this.Count = 0;
		}
	}
}
