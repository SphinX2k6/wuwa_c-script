using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007580 RID: 30080
	public class IRandomPrefabConfigT
	{
		// Token: 0x1700DD41 RID: 56641
		// (get) Token: 0x06034C2F RID: 216111 RVA: 0x007181D8 File Offset: 0x007163D8
		// (set) Token: 0x06034C30 RID: 216112 RVA: 0x007181E0 File Offset: 0x007163E0
		public ECreatePrefabType Type { get; set; }

		// Token: 0x1700DD42 RID: 56642
		// (get) Token: 0x06034C31 RID: 216113 RVA: 0x007181E9 File Offset: 0x007163E9
		// (set) Token: 0x06034C32 RID: 216114 RVA: 0x007181F1 File Offset: 0x007163F1
		public int RandomPrefabId { get; set; }

		// Token: 0x06034C33 RID: 216115 RVA: 0x007181FA File Offset: 0x007163FA
		public IRandomPrefabConfigT()
		{
			this.Type = ECreatePrefabType.PrefabId;
			this.RandomPrefabId = 0;
		}
	}
}
