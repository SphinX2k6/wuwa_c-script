using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF8 RID: 27384
	public class IMontageDataT
	{
		// Token: 0x1700CB2D RID: 52013
		// (get) Token: 0x0603001E RID: 196638 RVA: 0x00686F8C File Offset: 0x0068518C
		// (set) Token: 0x0603001F RID: 196639 RVA: 0x00686F94 File Offset: 0x00685194
		public int ActorIndex { get; set; }

		// Token: 0x1700CB2E RID: 52014
		// (get) Token: 0x06030020 RID: 196640 RVA: 0x00686F9D File Offset: 0x0068519D
		// (set) Token: 0x06030021 RID: 196641 RVA: 0x00686FA5 File Offset: 0x006851A5
		public int MontageId { get; set; }

		// Token: 0x1700CB2F RID: 52015
		// (get) Token: 0x06030022 RID: 196642 RVA: 0x00686FAE File Offset: 0x006851AE
		// (set) Token: 0x06030023 RID: 196643 RVA: 0x00686FB6 File Offset: 0x006851B6
		public bool IsAbpMontage { get; set; }

		// Token: 0x1700CB30 RID: 52016
		// (get) Token: 0x06030024 RID: 196644 RVA: 0x00686FBF File Offset: 0x006851BF
		// (set) Token: 0x06030025 RID: 196645 RVA: 0x00686FC7 File Offset: 0x006851C7
		public bool IsLoop { get; set; }

		// Token: 0x1700CB31 RID: 52017
		// (get) Token: 0x06030026 RID: 196646 RVA: 0x00686FD0 File Offset: 0x006851D0
		// (set) Token: 0x06030027 RID: 196647 RVA: 0x00686FD8 File Offset: 0x006851D8
		public bool KeepPose { get; set; }

		// Token: 0x1700CB32 RID: 52018
		// (get) Token: 0x06030028 RID: 196648 RVA: 0x00686FE1 File Offset: 0x006851E1
		// (set) Token: 0x06030029 RID: 196649 RVA: 0x00686FE9 File Offset: 0x006851E9
		public float DelayTime { get; set; }

		// Token: 0x1700CB33 RID: 52019
		// (get) Token: 0x0603002A RID: 196650 RVA: 0x00686FF2 File Offset: 0x006851F2
		// (set) Token: 0x0603002B RID: 196651 RVA: 0x00686FFA File Offset: 0x006851FA
		public bool EndLoopingMontage { get; set; }

		// Token: 0x1700CB34 RID: 52020
		// (get) Token: 0x0603002C RID: 196652 RVA: 0x00687003 File Offset: 0x00685203
		// (set) Token: 0x0603002D RID: 196653 RVA: 0x0068700B File Offset: 0x0068520B
		public bool EndMontageDirectly { get; set; }

		// Token: 0x1700CB35 RID: 52021
		// (get) Token: 0x0603002E RID: 196654 RVA: 0x00687014 File Offset: 0x00685214
		// (set) Token: 0x0603002F RID: 196655 RVA: 0x0068701C File Offset: 0x0068521C
		public bool StartFromLoop { get; set; }

		// Token: 0x1700CB36 RID: 52022
		// (get) Token: 0x06030030 RID: 196656 RVA: 0x00687025 File Offset: 0x00685225
		// (set) Token: 0x06030031 RID: 196657 RVA: 0x0068702D File Offset: 0x0068522D
		public IMontageParamT OverlayMontage { get; set; }

		// Token: 0x1700CB37 RID: 52023
		// (get) Token: 0x06030032 RID: 196658 RVA: 0x00687036 File Offset: 0x00685236
		// (set) Token: 0x06030033 RID: 196659 RVA: 0x0068703E File Offset: 0x0068523E
		public int FaceExpressionId { get; set; }

		// Token: 0x1700CB38 RID: 52024
		// (get) Token: 0x06030034 RID: 196660 RVA: 0x00687047 File Offset: 0x00685247
		// (set) Token: 0x06030035 RID: 196661 RVA: 0x0068704F File Offset: 0x0068524F
		public bool KeepFaceExpression { get; set; }

		// Token: 0x1700CB39 RID: 52025
		// (get) Token: 0x06030036 RID: 196662 RVA: 0x00687058 File Offset: 0x00685258
		// (set) Token: 0x06030037 RID: 196663 RVA: 0x00687060 File Offset: 0x00685260
		public List<IActorFxEmotePlayT> FxEmote { get; set; }

		// Token: 0x1700CB3A RID: 52026
		// (get) Token: 0x06030038 RID: 196664 RVA: 0x00687069 File Offset: 0x00685269
		// (set) Token: 0x06030039 RID: 196665 RVA: 0x00687071 File Offset: 0x00685271
		public ushort NullMask { get; set; }

		// Token: 0x0603003A RID: 196666 RVA: 0x0068707C File Offset: 0x0068527C
		public IMontageDataT()
		{
			this.ActorIndex = 0;
			this.MontageId = 0;
			this.IsAbpMontage = false;
			this.IsLoop = false;
			this.KeepPose = false;
			this.DelayTime = 0f;
			this.EndLoopingMontage = false;
			this.EndMontageDirectly = false;
			this.StartFromLoop = false;
			this.OverlayMontage = null;
			this.FaceExpressionId = 0;
			this.KeepFaceExpression = false;
			this.FxEmote = null;
			this.NullMask = 0;
		}
	}
}
