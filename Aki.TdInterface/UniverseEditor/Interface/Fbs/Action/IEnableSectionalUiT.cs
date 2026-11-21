using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CFC RID: 27900
	public class IEnableSectionalUiT
	{
		// Token: 0x1700CCAF RID: 52399
		// (get) Token: 0x060301C4 RID: 197060 RVA: 0x0068B61D File Offset: 0x0068981D
		// (set) Token: 0x060301C5 RID: 197061 RVA: 0x0068B625 File Offset: 0x00689825
		public EUiOperationType Type { get; set; }

		// Token: 0x1700CCB0 RID: 52400
		// (get) Token: 0x060301C6 RID: 197062 RVA: 0x0068B62E File Offset: 0x0068982E
		// (set) Token: 0x060301C7 RID: 197063 RVA: 0x0068B636 File Offset: 0x00689836
		public bool ShowMiniMap { get; set; }

		// Token: 0x1700CCB1 RID: 52401
		// (get) Token: 0x060301C8 RID: 197064 RVA: 0x0068B63F File Offset: 0x0068983F
		// (set) Token: 0x060301C9 RID: 197065 RVA: 0x0068B647 File Offset: 0x00689847
		public bool ShowQuestTrack { get; set; }

		// Token: 0x1700CCB2 RID: 52402
		// (get) Token: 0x060301CA RID: 197066 RVA: 0x0068B650 File Offset: 0x00689850
		// (set) Token: 0x060301CB RID: 197067 RVA: 0x0068B658 File Offset: 0x00689858
		public bool ShowEsc { get; set; }

		// Token: 0x1700CCB3 RID: 52403
		// (get) Token: 0x060301CC RID: 197068 RVA: 0x0068B661 File Offset: 0x00689861
		// (set) Token: 0x060301CD RID: 197069 RVA: 0x0068B669 File Offset: 0x00689869
		public bool ShowSystem { get; set; }

		// Token: 0x1700CCB4 RID: 52404
		// (get) Token: 0x060301CE RID: 197070 RVA: 0x0068B672 File Offset: 0x00689872
		// (set) Token: 0x060301CF RID: 197071 RVA: 0x0068B67A File Offset: 0x0068987A
		public bool ShowScreenEffect { get; set; }

		// Token: 0x1700CCB5 RID: 52405
		// (get) Token: 0x060301D0 RID: 197072 RVA: 0x0068B683 File Offset: 0x00689883
		// (set) Token: 0x060301D1 RID: 197073 RVA: 0x0068B68B File Offset: 0x0068988B
		public bool ShowRoleFormation { get; set; }

		// Token: 0x1700CCB6 RID: 52406
		// (get) Token: 0x060301D2 RID: 197074 RVA: 0x0068B694 File Offset: 0x00689894
		// (set) Token: 0x060301D3 RID: 197075 RVA: 0x0068B69C File Offset: 0x0068989C
		public bool ShowRoleStatus { get; set; }

		// Token: 0x1700CCB7 RID: 52407
		// (get) Token: 0x060301D4 RID: 197076 RVA: 0x0068B6A5 File Offset: 0x006898A5
		// (set) Token: 0x060301D5 RID: 197077 RVA: 0x0068B6AD File Offset: 0x006898AD
		public bool ShowBossStatus { get; set; }

		// Token: 0x1700CCB8 RID: 52408
		// (get) Token: 0x060301D6 RID: 197078 RVA: 0x0068B6B6 File Offset: 0x006898B6
		// (set) Token: 0x060301D7 RID: 197079 RVA: 0x0068B6BE File Offset: 0x006898BE
		public bool ShowGuideLayer { get; set; }

		// Token: 0x1700CCB9 RID: 52409
		// (get) Token: 0x060301D8 RID: 197080 RVA: 0x0068B6C7 File Offset: 0x006898C7
		// (set) Token: 0x060301D9 RID: 197081 RVA: 0x0068B6CF File Offset: 0x006898CF
		public bool ShowMonsterHpBar { get; set; }

		// Token: 0x1700CCBA RID: 52410
		// (get) Token: 0x060301DA RID: 197082 RVA: 0x0068B6D8 File Offset: 0x006898D8
		// (set) Token: 0x060301DB RID: 197083 RVA: 0x0068B6E0 File Offset: 0x006898E0
		public bool ShowDamageText { get; set; }

		// Token: 0x1700CCBB RID: 52411
		// (get) Token: 0x060301DC RID: 197084 RVA: 0x0068B6E9 File Offset: 0x006898E9
		// (set) Token: 0x060301DD RID: 197085 RVA: 0x0068B6F1 File Offset: 0x006898F1
		public bool ShowPing { get; set; }

		// Token: 0x1700CCBC RID: 52412
		// (get) Token: 0x060301DE RID: 197086 RVA: 0x0068B6FA File Offset: 0x006898FA
		// (set) Token: 0x060301DF RID: 197087 RVA: 0x0068B702 File Offset: 0x00689902
		public bool ShowOther { get; set; }

		// Token: 0x1700CCBD RID: 52413
		// (get) Token: 0x060301E0 RID: 197088 RVA: 0x0068B70B File Offset: 0x0068990B
		// (set) Token: 0x060301E1 RID: 197089 RVA: 0x0068B713 File Offset: 0x00689913
		public List<EUiElement> AlwaysShowUiSections { get; set; }

		// Token: 0x1700CCBE RID: 52414
		// (get) Token: 0x060301E2 RID: 197090 RVA: 0x0068B71C File Offset: 0x0068991C
		// (set) Token: 0x060301E3 RID: 197091 RVA: 0x0068B724 File Offset: 0x00689924
		public bool ShowPositionOfficial { get; set; }

		// Token: 0x1700CCBF RID: 52415
		// (get) Token: 0x060301E4 RID: 197092 RVA: 0x0068B72D File Offset: 0x0068992D
		// (set) Token: 0x060301E5 RID: 197093 RVA: 0x0068B735 File Offset: 0x00689935
		public ushort NullMask { get; set; }

		// Token: 0x060301E6 RID: 197094 RVA: 0x0068B740 File Offset: 0x00689940
		public IEnableSectionalUiT()
		{
			this.Type = EUiOperationType.Enable;
			this.ShowMiniMap = false;
			this.ShowQuestTrack = false;
			this.ShowEsc = false;
			this.ShowSystem = false;
			this.ShowScreenEffect = false;
			this.ShowRoleFormation = false;
			this.ShowRoleStatus = false;
			this.ShowBossStatus = false;
			this.ShowGuideLayer = false;
			this.ShowMonsterHpBar = false;
			this.ShowDamageText = false;
			this.ShowPing = false;
			this.ShowOther = false;
			this.AlwaysShowUiSections = null;
			this.ShowPositionOfficial = false;
			this.NullMask = 0;
		}
	}
}
