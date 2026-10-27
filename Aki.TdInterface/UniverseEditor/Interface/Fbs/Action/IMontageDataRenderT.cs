using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFB RID: 27387
	public class IMontageDataRenderT
	{
		// Token: 0x1700CB47 RID: 52039
		// (get) Token: 0x06030064 RID: 196708 RVA: 0x006879DF File Offset: 0x00685BDF
		// (set) Token: 0x06030065 RID: 196709 RVA: 0x006879E7 File Offset: 0x00685BE7
		public int ActorIndex { get; set; }

		// Token: 0x1700CB48 RID: 52040
		// (get) Token: 0x06030066 RID: 196710 RVA: 0x006879F0 File Offset: 0x00685BF0
		// (set) Token: 0x06030067 RID: 196711 RVA: 0x006879F8 File Offset: 0x00685BF8
		public IMontageParamT BaseMontage { get; set; }

		// Token: 0x1700CB49 RID: 52041
		// (get) Token: 0x06030068 RID: 196712 RVA: 0x00687A01 File Offset: 0x00685C01
		// (set) Token: 0x06030069 RID: 196713 RVA: 0x00687A09 File Offset: 0x00685C09
		public bool EndLoopingMontage { get; set; }

		// Token: 0x1700CB4A RID: 52042
		// (get) Token: 0x0603006A RID: 196714 RVA: 0x00687A12 File Offset: 0x00685C12
		// (set) Token: 0x0603006B RID: 196715 RVA: 0x00687A1A File Offset: 0x00685C1A
		public bool EndMontageDirectly { get; set; }

		// Token: 0x1700CB4B RID: 52043
		// (get) Token: 0x0603006C RID: 196716 RVA: 0x00687A23 File Offset: 0x00685C23
		// (set) Token: 0x0603006D RID: 196717 RVA: 0x00687A2B File Offset: 0x00685C2B
		public bool StartFromLoop { get; set; }

		// Token: 0x1700CB4C RID: 52044
		// (get) Token: 0x0603006E RID: 196718 RVA: 0x00687A34 File Offset: 0x00685C34
		// (set) Token: 0x0603006F RID: 196719 RVA: 0x00687A3C File Offset: 0x00685C3C
		public IMontageParamT OverlayMontage { get; set; }

		// Token: 0x1700CB4D RID: 52045
		// (get) Token: 0x06030070 RID: 196720 RVA: 0x00687A45 File Offset: 0x00685C45
		// (set) Token: 0x06030071 RID: 196721 RVA: 0x00687A4D File Offset: 0x00685C4D
		public int FaceExpressionId { get; set; }

		// Token: 0x1700CB4E RID: 52046
		// (get) Token: 0x06030072 RID: 196722 RVA: 0x00687A56 File Offset: 0x00685C56
		// (set) Token: 0x06030073 RID: 196723 RVA: 0x00687A5E File Offset: 0x00685C5E
		public bool KeepFaceExpression { get; set; }

		// Token: 0x1700CB4F RID: 52047
		// (get) Token: 0x06030074 RID: 196724 RVA: 0x00687A67 File Offset: 0x00685C67
		// (set) Token: 0x06030075 RID: 196725 RVA: 0x00687A6F File Offset: 0x00685C6F
		public float DelayTime { get; set; }

		// Token: 0x1700CB50 RID: 52048
		// (get) Token: 0x06030076 RID: 196726 RVA: 0x00687A78 File Offset: 0x00685C78
		// (set) Token: 0x06030077 RID: 196727 RVA: 0x00687A80 File Offset: 0x00685C80
		public List<IActorFxEmotePlayT> FxEmote { get; set; }

		// Token: 0x1700CB51 RID: 52049
		// (get) Token: 0x06030078 RID: 196728 RVA: 0x00687A89 File Offset: 0x00685C89
		// (set) Token: 0x06030079 RID: 196729 RVA: 0x00687A91 File Offset: 0x00685C91
		public byte NullMask { get; set; }

		// Token: 0x0603007A RID: 196730 RVA: 0x00687A9C File Offset: 0x00685C9C
		public IMontageDataRenderT()
		{
			this.ActorIndex = 0;
			this.BaseMontage = null;
			this.EndLoopingMontage = false;
			this.EndMontageDirectly = false;
			this.StartFromLoop = false;
			this.OverlayMontage = null;
			this.FaceExpressionId = 0;
			this.KeepFaceExpression = false;
			this.DelayTime = 0f;
			this.FxEmote = null;
			this.NullMask = 0;
		}
	}
}
