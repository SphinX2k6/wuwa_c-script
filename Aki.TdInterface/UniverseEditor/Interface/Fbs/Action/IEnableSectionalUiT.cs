using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006682 RID: 26242
	public class IEnableSectionalUiT
	{
		// Token: 0x1700C2FE RID: 49918
		// (get) Token: 0x0602D9A7 RID: 186791 RVA: 0x0063E369 File Offset: 0x0063C569
		// (set) Token: 0x0602D9A8 RID: 186792 RVA: 0x0063E371 File Offset: 0x0063C571
		public EUiOperationType Type { get; set; }

		// Token: 0x1700C2FF RID: 49919
		// (get) Token: 0x0602D9A9 RID: 186793 RVA: 0x0063E37A File Offset: 0x0063C57A
		// (set) Token: 0x0602D9AA RID: 186794 RVA: 0x0063E382 File Offset: 0x0063C582
		public bool ShowMiniMap { get; set; }

		// Token: 0x1700C300 RID: 49920
		// (get) Token: 0x0602D9AB RID: 186795 RVA: 0x0063E38B File Offset: 0x0063C58B
		// (set) Token: 0x0602D9AC RID: 186796 RVA: 0x0063E393 File Offset: 0x0063C593
		public bool ShowQuestTrack { get; set; }

		// Token: 0x1700C301 RID: 49921
		// (get) Token: 0x0602D9AD RID: 186797 RVA: 0x0063E39C File Offset: 0x0063C59C
		// (set) Token: 0x0602D9AE RID: 186798 RVA: 0x0063E3A4 File Offset: 0x0063C5A4
		public bool ShowEsc { get; set; }

		// Token: 0x1700C302 RID: 49922
		// (get) Token: 0x0602D9AF RID: 186799 RVA: 0x0063E3AD File Offset: 0x0063C5AD
		// (set) Token: 0x0602D9B0 RID: 186800 RVA: 0x0063E3B5 File Offset: 0x0063C5B5
		public bool ShowSystem { get; set; }

		// Token: 0x1700C303 RID: 49923
		// (get) Token: 0x0602D9B1 RID: 186801 RVA: 0x0063E3BE File Offset: 0x0063C5BE
		// (set) Token: 0x0602D9B2 RID: 186802 RVA: 0x0063E3C6 File Offset: 0x0063C5C6
		public bool ShowScreenEffect { get; set; }

		// Token: 0x1700C304 RID: 49924
		// (get) Token: 0x0602D9B3 RID: 186803 RVA: 0x0063E3CF File Offset: 0x0063C5CF
		// (set) Token: 0x0602D9B4 RID: 186804 RVA: 0x0063E3D7 File Offset: 0x0063C5D7
		public bool ShowRoleFormation { get; set; }

		// Token: 0x1700C305 RID: 49925
		// (get) Token: 0x0602D9B5 RID: 186805 RVA: 0x0063E3E0 File Offset: 0x0063C5E0
		// (set) Token: 0x0602D9B6 RID: 186806 RVA: 0x0063E3E8 File Offset: 0x0063C5E8
		public bool ShowRoleStatus { get; set; }

		// Token: 0x1700C306 RID: 49926
		// (get) Token: 0x0602D9B7 RID: 186807 RVA: 0x0063E3F1 File Offset: 0x0063C5F1
		// (set) Token: 0x0602D9B8 RID: 186808 RVA: 0x0063E3F9 File Offset: 0x0063C5F9
		public bool ShowBossStatus { get; set; }

		// Token: 0x1700C307 RID: 49927
		// (get) Token: 0x0602D9B9 RID: 186809 RVA: 0x0063E402 File Offset: 0x0063C602
		// (set) Token: 0x0602D9BA RID: 186810 RVA: 0x0063E40A File Offset: 0x0063C60A
		public bool ShowGuideLayer { get; set; }

		// Token: 0x1700C308 RID: 49928
		// (get) Token: 0x0602D9BB RID: 186811 RVA: 0x0063E413 File Offset: 0x0063C613
		// (set) Token: 0x0602D9BC RID: 186812 RVA: 0x0063E41B File Offset: 0x0063C61B
		public bool ShowMonsterHpBar { get; set; }

		// Token: 0x1700C309 RID: 49929
		// (get) Token: 0x0602D9BD RID: 186813 RVA: 0x0063E424 File Offset: 0x0063C624
		// (set) Token: 0x0602D9BE RID: 186814 RVA: 0x0063E42C File Offset: 0x0063C62C
		public bool ShowDamageText { get; set; }

		// Token: 0x1700C30A RID: 49930
		// (get) Token: 0x0602D9BF RID: 186815 RVA: 0x0063E435 File Offset: 0x0063C635
		// (set) Token: 0x0602D9C0 RID: 186816 RVA: 0x0063E43D File Offset: 0x0063C63D
		public bool ShowPing { get; set; }

		// Token: 0x1700C30B RID: 49931
		// (get) Token: 0x0602D9C1 RID: 186817 RVA: 0x0063E446 File Offset: 0x0063C646
		// (set) Token: 0x0602D9C2 RID: 186818 RVA: 0x0063E44E File Offset: 0x0063C64E
		public bool ShowOther { get; set; }

		// Token: 0x1700C30C RID: 49932
		// (get) Token: 0x0602D9C3 RID: 186819 RVA: 0x0063E457 File Offset: 0x0063C657
		// (set) Token: 0x0602D9C4 RID: 186820 RVA: 0x0063E45F File Offset: 0x0063C65F
		public List<EUiElement> AlwaysShowUiSections { get; set; }

		// Token: 0x1700C30D RID: 49933
		// (get) Token: 0x0602D9C5 RID: 186821 RVA: 0x0063E468 File Offset: 0x0063C668
		// (set) Token: 0x0602D9C6 RID: 186822 RVA: 0x0063E470 File Offset: 0x0063C670
		public bool ShowPositionOfficial { get; set; }

		// Token: 0x1700C30E RID: 49934
		// (get) Token: 0x0602D9C7 RID: 186823 RVA: 0x0063E479 File Offset: 0x0063C679
		// (set) Token: 0x0602D9C8 RID: 186824 RVA: 0x0063E481 File Offset: 0x0063C681
		public ushort NullMask { get; set; }

		// Token: 0x0602D9C9 RID: 186825 RVA: 0x0063E48C File Offset: 0x0063C68C
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
