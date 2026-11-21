using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C57 RID: 27735
	public class IDisableMoveOperationT
	{
		// Token: 0x1700CB62 RID: 52066
		// (get) Token: 0x0602FC38 RID: 195640 RVA: 0x006818BC File Offset: 0x0067FABC
		// (set) Token: 0x0602FC39 RID: 195641 RVA: 0x006818C4 File Offset: 0x0067FAC4
		public EMoveOperationType Type { get; set; }

		// Token: 0x1700CB63 RID: 52067
		// (get) Token: 0x0602FC3A RID: 195642 RVA: 0x006818CD File Offset: 0x0067FACD
		// (set) Token: 0x0602FC3B RID: 195643 RVA: 0x006818D5 File Offset: 0x0067FAD5
		public bool Forward { get; set; }

		// Token: 0x1700CB64 RID: 52068
		// (get) Token: 0x0602FC3C RID: 195644 RVA: 0x006818DE File Offset: 0x0067FADE
		// (set) Token: 0x0602FC3D RID: 195645 RVA: 0x006818E6 File Offset: 0x0067FAE6
		public bool Back { get; set; }

		// Token: 0x1700CB65 RID: 52069
		// (get) Token: 0x0602FC3E RID: 195646 RVA: 0x006818EF File Offset: 0x0067FAEF
		// (set) Token: 0x0602FC3F RID: 195647 RVA: 0x006818F7 File Offset: 0x0067FAF7
		public bool Left { get; set; }

		// Token: 0x1700CB66 RID: 52070
		// (get) Token: 0x0602FC40 RID: 195648 RVA: 0x00681900 File Offset: 0x0067FB00
		// (set) Token: 0x0602FC41 RID: 195649 RVA: 0x00681908 File Offset: 0x0067FB08
		public bool Right { get; set; }

		// Token: 0x1700CB67 RID: 52071
		// (get) Token: 0x0602FC42 RID: 195650 RVA: 0x00681911 File Offset: 0x0067FB11
		// (set) Token: 0x0602FC43 RID: 195651 RVA: 0x00681919 File Offset: 0x0067FB19
		public bool ForceWalk { get; set; }

		// Token: 0x1700CB68 RID: 52072
		// (get) Token: 0x0602FC44 RID: 195652 RVA: 0x00681922 File Offset: 0x0067FB22
		// (set) Token: 0x0602FC45 RID: 195653 RVA: 0x0068192A File Offset: 0x0067FB2A
		public bool ForceJog { get; set; }

		// Token: 0x1700CB69 RID: 52073
		// (get) Token: 0x0602FC46 RID: 195654 RVA: 0x00681933 File Offset: 0x0067FB33
		// (set) Token: 0x0602FC47 RID: 195655 RVA: 0x0068193B File Offset: 0x0067FB3B
		public bool ForbidSprint { get; set; }

		// Token: 0x1700CB6A RID: 52074
		// (get) Token: 0x0602FC48 RID: 195656 RVA: 0x00681944 File Offset: 0x0067FB44
		// (set) Token: 0x0602FC49 RID: 195657 RVA: 0x0068194C File Offset: 0x0067FB4C
		public bool ForbidAndDisableSprint { get; set; }

		// Token: 0x1700CB6B RID: 52075
		// (get) Token: 0x0602FC4A RID: 195658 RVA: 0x00681955 File Offset: 0x0067FB55
		// (set) Token: 0x0602FC4B RID: 195659 RVA: 0x0068195D File Offset: 0x0067FB5D
		public bool ForbidAndDisableMotorcycleSprint { get; set; }

		// Token: 0x1700CB6C RID: 52076
		// (get) Token: 0x0602FC4C RID: 195660 RVA: 0x00681966 File Offset: 0x0067FB66
		// (set) Token: 0x0602FC4D RID: 195661 RVA: 0x0068196E File Offset: 0x0067FB6E
		public bool DisableClimbAndStep { get; set; }

		// Token: 0x1700CB6D RID: 52077
		// (get) Token: 0x0602FC4E RID: 195662 RVA: 0x00681977 File Offset: 0x0067FB77
		// (set) Token: 0x0602FC4F RID: 195663 RVA: 0x0068197F File Offset: 0x0067FB7F
		public byte NullMask { get; set; }

		// Token: 0x0602FC50 RID: 195664 RVA: 0x00681988 File Offset: 0x0067FB88
		public IDisableMoveOperationT()
		{
			this.Type = EMoveOperationType.Enable;
			this.Forward = false;
			this.Back = false;
			this.Left = false;
			this.Right = false;
			this.ForceWalk = false;
			this.ForceJog = false;
			this.ForbidSprint = false;
			this.ForbidAndDisableSprint = false;
			this.ForbidAndDisableMotorcycleSprint = false;
			this.DisableClimbAndStep = false;
			this.NullMask = 0;
		}
	}
}
