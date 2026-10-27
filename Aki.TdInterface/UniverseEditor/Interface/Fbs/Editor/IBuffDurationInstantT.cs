using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004830 RID: 18480
	public class IBuffDurationInstantT
	{
		// Token: 0x170084A1 RID: 33953
		// (get) Token: 0x0601C911 RID: 117009 RVA: 0x0040A1EE File Offset: 0x004083EE
		// (set) Token: 0x0601C912 RID: 117010 RVA: 0x0040A1F6 File Offset: 0x004083F6
		public EBuffDurationType Type { get; set; }

		// Token: 0x0601C913 RID: 117011 RVA: 0x0040A1FF File Offset: 0x004083FF
		public IBuffDurationInstantT()
		{
			this.Type = EBuffDurationType.Instant;
		}
	}
}
