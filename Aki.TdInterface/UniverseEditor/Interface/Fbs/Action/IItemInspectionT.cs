using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CA RID: 27082
	public class IItemInspectionT
	{
		// Token: 0x1700C8E8 RID: 51432
		// (get) Token: 0x0602F54D RID: 193869 RVA: 0x006723D3 File Offset: 0x006705D3
		// (set) Token: 0x0602F54E RID: 193870 RVA: 0x006723DB File Offset: 0x006705DB
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C8E9 RID: 51433
		// (get) Token: 0x0602F54F RID: 193871 RVA: 0x006723E4 File Offset: 0x006705E4
		// (set) Token: 0x0602F550 RID: 193872 RVA: 0x006723EC File Offset: 0x006705EC
		public string PrefabPath { get; set; }

		// Token: 0x1700C8EA RID: 51434
		// (get) Token: 0x0602F551 RID: 193873 RVA: 0x006723F5 File Offset: 0x006705F5
		// (set) Token: 0x0602F552 RID: 193874 RVA: 0x006723FD File Offset: 0x006705FD
		public float RotateSpeed { get; set; }

		// Token: 0x1700C8EB RID: 51435
		// (get) Token: 0x0602F553 RID: 193875 RVA: 0x00672406 File Offset: 0x00670606
		// (set) Token: 0x0602F554 RID: 193876 RVA: 0x0067240E File Offset: 0x0067060E
		public ISequenceUnlockPointsT InteractPointsConfig { get; set; }

		// Token: 0x1700C8EC RID: 51436
		// (get) Token: 0x0602F555 RID: 193877 RVA: 0x00672417 File Offset: 0x00670617
		// (set) Token: 0x0602F556 RID: 193878 RVA: 0x0067241F File Offset: 0x0067061F
		public IConeRangeCheckT RangeCheckConfig { get; set; }

		// Token: 0x1700C8ED RID: 51437
		// (get) Token: 0x0602F557 RID: 193879 RVA: 0x00672428 File Offset: 0x00670628
		// (set) Token: 0x0602F558 RID: 193880 RVA: 0x00672430 File Offset: 0x00670630
		public IAstrologyTextUiConfigT TextUiConfig { get; set; }

		// Token: 0x1700C8EE RID: 51438
		// (get) Token: 0x0602F559 RID: 193881 RVA: 0x00672439 File Offset: 0x00670639
		// (set) Token: 0x0602F55A RID: 193882 RVA: 0x00672441 File Offset: 0x00670641
		public bool CanExit { get; set; }

		// Token: 0x1700C8EF RID: 51439
		// (get) Token: 0x0602F55B RID: 193883 RVA: 0x0067244A File Offset: 0x0067064A
		// (set) Token: 0x0602F55C RID: 193884 RVA: 0x00672452 File Offset: 0x00670652
		public float ItemOffsetDistance { get; set; }

		// Token: 0x1700C8F0 RID: 51440
		// (get) Token: 0x0602F55D RID: 193885 RVA: 0x0067245B File Offset: 0x0067065B
		// (set) Token: 0x0602F55E RID: 193886 RVA: 0x00672463 File Offset: 0x00670663
		public IItemInspectFinishEffectT ItemInteractFinishEffect { get; set; }

		// Token: 0x1700C8F1 RID: 51441
		// (get) Token: 0x0602F55F RID: 193887 RVA: 0x0067246C File Offset: 0x0067066C
		// (set) Token: 0x0602F560 RID: 193888 RVA: 0x00672474 File Offset: 0x00670674
		public byte NullMask { get; set; }

		// Token: 0x0602F561 RID: 193889 RVA: 0x00672480 File Offset: 0x00670680
		public IItemInspectionT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.PrefabPath = null;
			this.RotateSpeed = 0f;
			this.InteractPointsConfig = null;
			this.RangeCheckConfig = null;
			this.TextUiConfig = null;
			this.CanExit = false;
			this.ItemOffsetDistance = 0f;
			this.ItemInteractFinishEffect = null;
			this.NullMask = 0;
		}
	}
}
