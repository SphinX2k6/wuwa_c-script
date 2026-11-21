using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C6 RID: 17862
	public class ITakePhoto2ConditionT
	{
		// Token: 0x17007CD9 RID: 31961
		// (get) Token: 0x0601A12F RID: 106799 RVA: 0x003B75CC File Offset: 0x003B57CC
		// (set) Token: 0x0601A130 RID: 106800 RVA: 0x003B75D4 File Offset: 0x003B57D4
		public EChildQuest Type { get; set; }

		// Token: 0x17007CDA RID: 31962
		// (get) Token: 0x0601A131 RID: 106801 RVA: 0x003B75DD File Offset: 0x003B57DD
		// (set) Token: 0x0601A132 RID: 106802 RVA: 0x003B75E5 File Offset: 0x003B57E5
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007CDB RID: 31963
		// (get) Token: 0x0601A133 RID: 106803 RVA: 0x003B75EE File Offset: 0x003B57EE
		// (set) Token: 0x0601A134 RID: 106804 RVA: 0x003B75F6 File Offset: 0x003B57F6
		public string TidConditionDescription { get; set; }

		// Token: 0x17007CDC RID: 31964
		// (get) Token: 0x0601A135 RID: 106805 RVA: 0x003B75FF File Offset: 0x003B57FF
		// (set) Token: 0x0601A136 RID: 106806 RVA: 0x003B7607 File Offset: 0x003B5807
		public string TargetPreviewImagePath { get; set; }

		// Token: 0x17007CDD RID: 31965
		// (get) Token: 0x0601A137 RID: 106807 RVA: 0x003B7610 File Offset: 0x003B5810
		// (set) Token: 0x0601A138 RID: 106808 RVA: 0x003B7618 File Offset: 0x003B5818
		public ITakePhoto2TimeConditionT TimeCondition { get; set; }

		// Token: 0x17007CDE RID: 31966
		// (get) Token: 0x0601A139 RID: 106809 RVA: 0x003B7621 File Offset: 0x003B5821
		// (set) Token: 0x0601A13A RID: 106810 RVA: 0x003B7629 File Offset: 0x003B5829
		public ITakePhoto2PosConditionT PosCondition { get; set; }

		// Token: 0x17007CDF RID: 31967
		// (get) Token: 0x0601A13B RID: 106811 RVA: 0x003B7632 File Offset: 0x003B5832
		// (set) Token: 0x0601A13C RID: 106812 RVA: 0x003B763A File Offset: 0x003B583A
		public ITakePhoto2CameraFovConditionT FovCondition { get; set; }

		// Token: 0x17007CE0 RID: 31968
		// (get) Token: 0x0601A13D RID: 106813 RVA: 0x003B7643 File Offset: 0x003B5843
		// (set) Token: 0x0601A13E RID: 106814 RVA: 0x003B764B File Offset: 0x003B584B
		public ITakePhoto2SequenceConditionT SequenceCondition { get; set; }

		// Token: 0x17007CE1 RID: 31969
		// (get) Token: 0x0601A13F RID: 106815 RVA: 0x003B7654 File Offset: 0x003B5854
		// (set) Token: 0x0601A140 RID: 106816 RVA: 0x003B765C File Offset: 0x003B585C
		public string BoundCameraSeqPath { get; set; }

		// Token: 0x17007CE2 RID: 31970
		// (get) Token: 0x0601A141 RID: 106817 RVA: 0x003B7665 File Offset: 0x003B5865
		// (set) Token: 0x0601A142 RID: 106818 RVA: 0x003B766D File Offset: 0x003B586D
		public string BackgroundImagePath { get; set; }

		// Token: 0x17007CE3 RID: 31971
		// (get) Token: 0x0601A143 RID: 106819 RVA: 0x003B7676 File Offset: 0x003B5876
		// (set) Token: 0x0601A144 RID: 106820 RVA: 0x003B767E File Offset: 0x003B587E
		public List<TTakePhoto2TargetConfigUnion> PhotoTargets { get; set; }

		// Token: 0x17007CE4 RID: 31972
		// (get) Token: 0x0601A145 RID: 106821 RVA: 0x003B7687 File Offset: 0x003B5887
		// (set) Token: 0x0601A146 RID: 106822 RVA: 0x003B768F File Offset: 0x003B588F
		public ITakePhoto2BeforeYourEyesModeT PhotoMode { get; set; }

		// Token: 0x17007CE5 RID: 31973
		// (get) Token: 0x0601A147 RID: 106823 RVA: 0x003B7698 File Offset: 0x003B5898
		// (set) Token: 0x0601A148 RID: 106824 RVA: 0x003B76A0 File Offset: 0x003B58A0
		public bool CanDetectWhenNotTracking { get; set; }

		// Token: 0x17007CE6 RID: 31974
		// (get) Token: 0x0601A149 RID: 106825 RVA: 0x003B76A9 File Offset: 0x003B58A9
		// (set) Token: 0x0601A14A RID: 106826 RVA: 0x003B76B1 File Offset: 0x003B58B1
		public byte NullMask { get; set; }

		// Token: 0x0601A14B RID: 106827 RVA: 0x003B76BC File Offset: 0x003B58BC
		public ITakePhoto2ConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TidConditionDescription = null;
			this.TargetPreviewImagePath = null;
			this.TimeCondition = null;
			this.PosCondition = null;
			this.FovCondition = null;
			this.SequenceCondition = null;
			this.BoundCameraSeqPath = null;
			this.BackgroundImagePath = null;
			this.PhotoTargets = null;
			this.PhotoMode = null;
			this.CanDetectWhenNotTracking = false;
			this.NullMask = 0;
		}
	}
}
