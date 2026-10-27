using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ACD RID: 19149
	public class ICheckMusicEventT
	{
		// Token: 0x17008AD6 RID: 35542
		// (get) Token: 0x0601E124 RID: 123172 RVA: 0x004380AF File Offset: 0x004362AF
		// (set) Token: 0x0601E125 RID: 123173 RVA: 0x004380B7 File Offset: 0x004362B7
		public ECondition Type { get; set; }

		// Token: 0x17008AD7 RID: 35543
		// (get) Token: 0x0601E126 RID: 123174 RVA: 0x004380C0 File Offset: 0x004362C0
		// (set) Token: 0x0601E127 RID: 123175 RVA: 0x004380C8 File Offset: 0x004362C8
		public TMusicConditionUnion MusicEvent { get; set; }

		// Token: 0x0601E128 RID: 123176 RVA: 0x004380D1 File Offset: 0x004362D1
		public ICheckMusicEventT()
		{
			this.Type = ECondition.CompareVar;
			this.MusicEvent = null;
		}
	}
}
