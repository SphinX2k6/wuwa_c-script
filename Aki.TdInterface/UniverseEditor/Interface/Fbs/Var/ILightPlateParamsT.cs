using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EA5 RID: 16037
	public class ILightPlateParamsT
	{
		// Token: 0x17006C7F RID: 27775
		// (get) Token: 0x06015AD6 RID: 88790 RVA: 0x0031F565 File Offset: 0x0031D765
		// (set) Token: 0x06015AD7 RID: 88791 RVA: 0x0031F56D File Offset: 0x0031D76D
		public EParamsPreset Type { get; set; }

		// Token: 0x17006C80 RID: 27776
		// (get) Token: 0x06015AD8 RID: 88792 RVA: 0x0031F576 File Offset: 0x0031D776
		// (set) Token: 0x06015AD9 RID: 88793 RVA: 0x0031F57E File Offset: 0x0031D77E
		public float RayCastingDetectDis { get; set; }

		// Token: 0x17006C81 RID: 27777
		// (get) Token: 0x06015ADA RID: 88794 RVA: 0x0031F587 File Offset: 0x0031D787
		// (set) Token: 0x06015ADB RID: 88795 RVA: 0x0031F58F File Offset: 0x0031D78F
		public float MaxDegreeAngle { get; set; }

		// Token: 0x17006C82 RID: 27778
		// (get) Token: 0x06015ADC RID: 88796 RVA: 0x0031F598 File Offset: 0x0031D798
		// (set) Token: 0x06015ADD RID: 88797 RVA: 0x0031F5A0 File Offset: 0x0031D7A0
		public float ReturnSpeedDegreePerSecond { get; set; }

		// Token: 0x17006C83 RID: 27779
		// (get) Token: 0x06015ADE RID: 88798 RVA: 0x0031F5A9 File Offset: 0x0031D7A9
		// (set) Token: 0x06015ADF RID: 88799 RVA: 0x0031F5B1 File Offset: 0x0031D7B1
		public float FollowSpeedDegreePerSecond { get; set; }

		// Token: 0x17006C84 RID: 27780
		// (get) Token: 0x06015AE0 RID: 88800 RVA: 0x0031F5BA File Offset: 0x0031D7BA
		// (set) Token: 0x06015AE1 RID: 88801 RVA: 0x0031F5C2 File Offset: 0x0031D7C2
		public float MinActiveRadius { get; set; }

		// Token: 0x17006C85 RID: 27781
		// (get) Token: 0x06015AE2 RID: 88802 RVA: 0x0031F5CB File Offset: 0x0031D7CB
		// (set) Token: 0x06015AE3 RID: 88803 RVA: 0x0031F5D3 File Offset: 0x0031D7D3
		public float MaxActiveRadius { get; set; }

		// Token: 0x17006C86 RID: 27782
		// (get) Token: 0x06015AE4 RID: 88804 RVA: 0x0031F5DC File Offset: 0x0031D7DC
		// (set) Token: 0x06015AE5 RID: 88805 RVA: 0x0031F5E4 File Offset: 0x0031D7E4
		public bool EnableLightPlate { get; set; }

		// Token: 0x17006C87 RID: 27783
		// (get) Token: 0x06015AE6 RID: 88806 RVA: 0x0031F5ED File Offset: 0x0031D7ED
		// (set) Token: 0x06015AE7 RID: 88807 RVA: 0x0031F5F5 File Offset: 0x0031D7F5
		public List<int> IgnoreEntities { get; set; }

		// Token: 0x17006C88 RID: 27784
		// (get) Token: 0x06015AE8 RID: 88808 RVA: 0x0031F5FE File Offset: 0x0031D7FE
		// (set) Token: 0x06015AE9 RID: 88809 RVA: 0x0031F606 File Offset: 0x0031D806
		public bool DoNotNeedRayCasting { get; set; }

		// Token: 0x17006C89 RID: 27785
		// (get) Token: 0x06015AEA RID: 88810 RVA: 0x0031F60F File Offset: 0x0031D80F
		// (set) Token: 0x06015AEB RID: 88811 RVA: 0x0031F617 File Offset: 0x0031D817
		public bool MultiPlateMode { get; set; }

		// Token: 0x17006C8A RID: 27786
		// (get) Token: 0x06015AEC RID: 88812 RVA: 0x0031F620 File Offset: 0x0031D820
		// (set) Token: 0x06015AED RID: 88813 RVA: 0x0031F628 File Offset: 0x0031D828
		public bool LockCollisionMode { get; set; }

		// Token: 0x17006C8B RID: 27787
		// (get) Token: 0x06015AEE RID: 88814 RVA: 0x0031F631 File Offset: 0x0031D831
		// (set) Token: 0x06015AEF RID: 88815 RVA: 0x0031F639 File Offset: 0x0031D839
		public byte NullMask { get; set; }

		// Token: 0x06015AF0 RID: 88816 RVA: 0x0031F644 File Offset: 0x0031D844
		public ILightPlateParamsT()
		{
			this.Type = EParamsPreset.Decal;
			this.RayCastingDetectDis = 0f;
			this.MaxDegreeAngle = 0f;
			this.ReturnSpeedDegreePerSecond = 0f;
			this.FollowSpeedDegreePerSecond = 0f;
			this.MinActiveRadius = 0f;
			this.MaxActiveRadius = 0f;
			this.EnableLightPlate = false;
			this.IgnoreEntities = null;
			this.DoNotNeedRayCasting = false;
			this.MultiPlateMode = false;
			this.LockCollisionMode = false;
			this.NullMask = 0;
		}
	}
}
