using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F9F RID: 20383
	public class ICheckMusicEventT
	{
		// Token: 0x170091C8 RID: 37320
		// (get) Token: 0x0601FC23 RID: 130083 RVA: 0x00469B5B File Offset: 0x00467D5B
		// (set) Token: 0x0601FC24 RID: 130084 RVA: 0x00469B63 File Offset: 0x00467D63
		public ECondition Type { get; set; }

		// Token: 0x170091C9 RID: 37321
		// (get) Token: 0x0601FC25 RID: 130085 RVA: 0x00469B6C File Offset: 0x00467D6C
		// (set) Token: 0x0601FC26 RID: 130086 RVA: 0x00469B74 File Offset: 0x00467D74
		public TMusicConditionUnion MusicEvent { get; set; }

		// Token: 0x0601FC27 RID: 130087 RVA: 0x00469B7D File Offset: 0x00467D7D
		public ICheckMusicEventT()
		{
			this.Type = ECondition.CompareVar;
			this.MusicEvent = null;
		}
	}
}
