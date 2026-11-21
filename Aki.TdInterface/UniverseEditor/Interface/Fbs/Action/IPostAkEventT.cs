using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EA RID: 29930
	public class IPostAkEventT
	{
		// Token: 0x1700DC46 RID: 56390
		// (get) Token: 0x060347A8 RID: 214952 RVA: 0x00710D2D File Offset: 0x0070EF2D
		// (set) Token: 0x060347A9 RID: 214953 RVA: 0x00710D35 File Offset: 0x0070EF35
		public TPostAkEventUnion EventConfig { get; set; }

		// Token: 0x1700DC47 RID: 56391
		// (get) Token: 0x060347AA RID: 214954 RVA: 0x00710D3E File Offset: 0x0070EF3E
		// (set) Token: 0x060347AB RID: 214955 RVA: 0x00710D46 File Offset: 0x0070EF46
		public bool PersistWhenExitDungeon { get; set; }

		// Token: 0x1700DC48 RID: 56392
		// (get) Token: 0x060347AC RID: 214956 RVA: 0x00710D4F File Offset: 0x0070EF4F
		// (set) Token: 0x060347AD RID: 214957 RVA: 0x00710D57 File Offset: 0x0070EF57
		public EMusicEventType MusicEventType { get; set; }

		// Token: 0x1700DC49 RID: 56393
		// (get) Token: 0x060347AE RID: 214958 RVA: 0x00710D60 File Offset: 0x0070EF60
		// (set) Token: 0x060347AF RID: 214959 RVA: 0x00710D68 File Offset: 0x0070EF68
		public bool IsBanVehicleRadio { get; set; }

		// Token: 0x1700DC4A RID: 56394
		// (get) Token: 0x060347B0 RID: 214960 RVA: 0x00710D71 File Offset: 0x0070EF71
		// (set) Token: 0x060347B1 RID: 214961 RVA: 0x00710D79 File Offset: 0x0070EF79
		public float FadeOutTimeWhenFlowEnd { get; set; }

		// Token: 0x1700DC4B RID: 56395
		// (get) Token: 0x060347B2 RID: 214962 RVA: 0x00710D82 File Offset: 0x0070EF82
		// (set) Token: 0x060347B3 RID: 214963 RVA: 0x00710D8A File Offset: 0x0070EF8A
		public float DelayTime { get; set; }

		// Token: 0x1700DC4C RID: 56396
		// (get) Token: 0x060347B4 RID: 214964 RVA: 0x00710D93 File Offset: 0x0070EF93
		// (set) Token: 0x060347B5 RID: 214965 RVA: 0x00710D9B File Offset: 0x0070EF9B
		public byte NullMask { get; set; }

		// Token: 0x060347B6 RID: 214966 RVA: 0x00710DA4 File Offset: 0x0070EFA4
		public IPostAkEventT()
		{
			this.EventConfig = null;
			this.PersistWhenExitDungeon = false;
			this.MusicEventType = EMusicEventType.HcMusicBattle;
			this.IsBanVehicleRadio = false;
			this.FadeOutTimeWhenFlowEnd = 0f;
			this.DelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
