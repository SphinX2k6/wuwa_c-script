using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417F RID: 16767
	public class ITakePhoto2EntityTargetT
	{
		// Token: 0x170076D2 RID: 30418
		// (get) Token: 0x06018A65 RID: 100965 RVA: 0x0038D189 File Offset: 0x0038B389
		// (set) Token: 0x06018A66 RID: 100966 RVA: 0x0038D191 File Offset: 0x0038B391
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x170076D3 RID: 30419
		// (get) Token: 0x06018A67 RID: 100967 RVA: 0x0038D19A File Offset: 0x0038B39A
		// (set) Token: 0x06018A68 RID: 100968 RVA: 0x0038D1A2 File Offset: 0x0038B3A2
		public bool IsOptionalTarget { get; set; }

		// Token: 0x170076D4 RID: 30420
		// (get) Token: 0x06018A69 RID: 100969 RVA: 0x0038D1AB File Offset: 0x0038B3AB
		// (set) Token: 0x06018A6A RID: 100970 RVA: 0x0038D1B3 File Offset: 0x0038B3B3
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x170076D5 RID: 30421
		// (get) Token: 0x06018A6B RID: 100971 RVA: 0x0038D1BC File Offset: 0x0038B3BC
		// (set) Token: 0x06018A6C RID: 100972 RVA: 0x0038D1C4 File Offset: 0x0038B3C4
		public int EntityId { get; set; }

		// Token: 0x170076D6 RID: 30422
		// (get) Token: 0x06018A6D RID: 100973 RVA: 0x0038D1CD File Offset: 0x0038B3CD
		// (set) Token: 0x06018A6E RID: 100974 RVA: 0x0038D1D5 File Offset: 0x0038B3D5
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x170076D7 RID: 30423
		// (get) Token: 0x06018A6F RID: 100975 RVA: 0x0038D1DE File Offset: 0x0038B3DE
		// (set) Token: 0x06018A70 RID: 100976 RVA: 0x0038D1E6 File Offset: 0x0038B3E6
		public ITakePhoto2TargetPlayMontageConditionT TargetPlayMontageCondition { get; set; }

		// Token: 0x170076D8 RID: 30424
		// (get) Token: 0x06018A71 RID: 100977 RVA: 0x0038D1EF File Offset: 0x0038B3EF
		// (set) Token: 0x06018A72 RID: 100978 RVA: 0x0038D1F7 File Offset: 0x0038B3F7
		public ITakePhoto2TargetAnsTagConditionT TargetAnsTagCondition { get; set; }

		// Token: 0x170076D9 RID: 30425
		// (get) Token: 0x06018A73 RID: 100979 RVA: 0x0038D200 File Offset: 0x0038B400
		// (set) Token: 0x06018A74 RID: 100980 RVA: 0x0038D208 File Offset: 0x0038B408
		public ITakePhoto2TargetPartConditionT TargetPartCondition { get; set; }

		// Token: 0x170076DA RID: 30426
		// (get) Token: 0x06018A75 RID: 100981 RVA: 0x0038D211 File Offset: 0x0038B411
		// (set) Token: 0x06018A76 RID: 100982 RVA: 0x0038D219 File Offset: 0x0038B419
		public byte NullMask { get; set; }

		// Token: 0x06018A77 RID: 100983 RVA: 0x0038D224 File Offset: 0x0038B424
		public ITakePhoto2EntityTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.EntityId = 0;
			this.TargetPosCondition = null;
			this.TargetPlayMontageCondition = null;
			this.TargetAnsTagCondition = null;
			this.TargetPartCondition = null;
			this.NullMask = 0;
		}
	}
}
