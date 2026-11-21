using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707A RID: 28794
	public class IItemInspectionT
	{
		// Token: 0x1700D2E8 RID: 53992
		// (get) Token: 0x06031F0D RID: 204557 RVA: 0x006C272B File Offset: 0x006C092B
		// (set) Token: 0x06031F0E RID: 204558 RVA: 0x006C2733 File Offset: 0x006C0933
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700D2E9 RID: 53993
		// (get) Token: 0x06031F0F RID: 204559 RVA: 0x006C273C File Offset: 0x006C093C
		// (set) Token: 0x06031F10 RID: 204560 RVA: 0x006C2744 File Offset: 0x006C0944
		public string PrefabPath { get; set; }

		// Token: 0x1700D2EA RID: 53994
		// (get) Token: 0x06031F11 RID: 204561 RVA: 0x006C274D File Offset: 0x006C094D
		// (set) Token: 0x06031F12 RID: 204562 RVA: 0x006C2755 File Offset: 0x006C0955
		public float RotateSpeed { get; set; }

		// Token: 0x1700D2EB RID: 53995
		// (get) Token: 0x06031F13 RID: 204563 RVA: 0x006C275E File Offset: 0x006C095E
		// (set) Token: 0x06031F14 RID: 204564 RVA: 0x006C2766 File Offset: 0x006C0966
		public ISequenceUnlockPointsT InteractPointsConfig { get; set; }

		// Token: 0x1700D2EC RID: 53996
		// (get) Token: 0x06031F15 RID: 204565 RVA: 0x006C276F File Offset: 0x006C096F
		// (set) Token: 0x06031F16 RID: 204566 RVA: 0x006C2777 File Offset: 0x006C0977
		public IConeRangeCheckT RangeCheckConfig { get; set; }

		// Token: 0x1700D2ED RID: 53997
		// (get) Token: 0x06031F17 RID: 204567 RVA: 0x006C2780 File Offset: 0x006C0980
		// (set) Token: 0x06031F18 RID: 204568 RVA: 0x006C2788 File Offset: 0x006C0988
		public IAstrologyTextUiConfigT TextUiConfig { get; set; }

		// Token: 0x1700D2EE RID: 53998
		// (get) Token: 0x06031F19 RID: 204569 RVA: 0x006C2791 File Offset: 0x006C0991
		// (set) Token: 0x06031F1A RID: 204570 RVA: 0x006C2799 File Offset: 0x006C0999
		public bool CanExit { get; set; }

		// Token: 0x1700D2EF RID: 53999
		// (get) Token: 0x06031F1B RID: 204571 RVA: 0x006C27A2 File Offset: 0x006C09A2
		// (set) Token: 0x06031F1C RID: 204572 RVA: 0x006C27AA File Offset: 0x006C09AA
		public float ItemOffsetDistance { get; set; }

		// Token: 0x1700D2F0 RID: 54000
		// (get) Token: 0x06031F1D RID: 204573 RVA: 0x006C27B3 File Offset: 0x006C09B3
		// (set) Token: 0x06031F1E RID: 204574 RVA: 0x006C27BB File Offset: 0x006C09BB
		public IItemInspectFinishEffectT ItemInteractFinishEffect { get; set; }

		// Token: 0x1700D2F1 RID: 54001
		// (get) Token: 0x06031F1F RID: 204575 RVA: 0x006C27C4 File Offset: 0x006C09C4
		// (set) Token: 0x06031F20 RID: 204576 RVA: 0x006C27CC File Offset: 0x006C09CC
		public byte NullMask { get; set; }

		// Token: 0x06031F21 RID: 204577 RVA: 0x006C27D8 File Offset: 0x006C09D8
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
