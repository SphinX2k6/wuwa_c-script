using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6F RID: 28015
	public class IPostAkEventT
	{
		// Token: 0x1700D0FE RID: 53502
		// (get) Token: 0x060317AC RID: 202668 RVA: 0x006B5645 File Offset: 0x006B3845
		// (set) Token: 0x060317AD RID: 202669 RVA: 0x006B564D File Offset: 0x006B384D
		public TPostAkEventUnion EventConfig { get; set; }

		// Token: 0x1700D0FF RID: 53503
		// (get) Token: 0x060317AE RID: 202670 RVA: 0x006B5656 File Offset: 0x006B3856
		// (set) Token: 0x060317AF RID: 202671 RVA: 0x006B565E File Offset: 0x006B385E
		public bool PersistWhenExitDungeon { get; set; }

		// Token: 0x1700D100 RID: 53504
		// (get) Token: 0x060317B0 RID: 202672 RVA: 0x006B5667 File Offset: 0x006B3867
		// (set) Token: 0x060317B1 RID: 202673 RVA: 0x006B566F File Offset: 0x006B386F
		public EMusicEventType MusicEventType { get; set; }

		// Token: 0x1700D101 RID: 53505
		// (get) Token: 0x060317B2 RID: 202674 RVA: 0x006B5678 File Offset: 0x006B3878
		// (set) Token: 0x060317B3 RID: 202675 RVA: 0x006B5680 File Offset: 0x006B3880
		public bool IsBanVehicleRadio { get; set; }

		// Token: 0x1700D102 RID: 53506
		// (get) Token: 0x060317B4 RID: 202676 RVA: 0x006B5689 File Offset: 0x006B3889
		// (set) Token: 0x060317B5 RID: 202677 RVA: 0x006B5691 File Offset: 0x006B3891
		public float FadeOutTimeWhenFlowEnd { get; set; }

		// Token: 0x1700D103 RID: 53507
		// (get) Token: 0x060317B6 RID: 202678 RVA: 0x006B569A File Offset: 0x006B389A
		// (set) Token: 0x060317B7 RID: 202679 RVA: 0x006B56A2 File Offset: 0x006B38A2
		public float DelayTime { get; set; }

		// Token: 0x1700D104 RID: 53508
		// (get) Token: 0x060317B8 RID: 202680 RVA: 0x006B56AB File Offset: 0x006B38AB
		// (set) Token: 0x060317B9 RID: 202681 RVA: 0x006B56B3 File Offset: 0x006B38B3
		public byte NullMask { get; set; }

		// Token: 0x060317BA RID: 202682 RVA: 0x006B56BC File Offset: 0x006B38BC
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
