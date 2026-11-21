using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722F RID: 29231
	public class IMontageDataT
	{
		// Token: 0x1700D5FC RID: 54780
		// (get) Token: 0x06032DF2 RID: 208370 RVA: 0x006DE644 File Offset: 0x006DC844
		// (set) Token: 0x06032DF3 RID: 208371 RVA: 0x006DE64C File Offset: 0x006DC84C
		public int ActorIndex { get; set; }

		// Token: 0x1700D5FD RID: 54781
		// (get) Token: 0x06032DF4 RID: 208372 RVA: 0x006DE655 File Offset: 0x006DC855
		// (set) Token: 0x06032DF5 RID: 208373 RVA: 0x006DE65D File Offset: 0x006DC85D
		public int MontageId { get; set; }

		// Token: 0x1700D5FE RID: 54782
		// (get) Token: 0x06032DF6 RID: 208374 RVA: 0x006DE666 File Offset: 0x006DC866
		// (set) Token: 0x06032DF7 RID: 208375 RVA: 0x006DE66E File Offset: 0x006DC86E
		public bool IsAbpMontage { get; set; }

		// Token: 0x1700D5FF RID: 54783
		// (get) Token: 0x06032DF8 RID: 208376 RVA: 0x006DE677 File Offset: 0x006DC877
		// (set) Token: 0x06032DF9 RID: 208377 RVA: 0x006DE67F File Offset: 0x006DC87F
		public bool IsLoop { get; set; }

		// Token: 0x1700D600 RID: 54784
		// (get) Token: 0x06032DFA RID: 208378 RVA: 0x006DE688 File Offset: 0x006DC888
		// (set) Token: 0x06032DFB RID: 208379 RVA: 0x006DE690 File Offset: 0x006DC890
		public bool KeepPose { get; set; }

		// Token: 0x1700D601 RID: 54785
		// (get) Token: 0x06032DFC RID: 208380 RVA: 0x006DE699 File Offset: 0x006DC899
		// (set) Token: 0x06032DFD RID: 208381 RVA: 0x006DE6A1 File Offset: 0x006DC8A1
		public float DelayTime { get; set; }

		// Token: 0x1700D602 RID: 54786
		// (get) Token: 0x06032DFE RID: 208382 RVA: 0x006DE6AA File Offset: 0x006DC8AA
		// (set) Token: 0x06032DFF RID: 208383 RVA: 0x006DE6B2 File Offset: 0x006DC8B2
		public bool EndLoopingMontage { get; set; }

		// Token: 0x1700D603 RID: 54787
		// (get) Token: 0x06032E00 RID: 208384 RVA: 0x006DE6BB File Offset: 0x006DC8BB
		// (set) Token: 0x06032E01 RID: 208385 RVA: 0x006DE6C3 File Offset: 0x006DC8C3
		public bool EndMontageDirectly { get; set; }

		// Token: 0x1700D604 RID: 54788
		// (get) Token: 0x06032E02 RID: 208386 RVA: 0x006DE6CC File Offset: 0x006DC8CC
		// (set) Token: 0x06032E03 RID: 208387 RVA: 0x006DE6D4 File Offset: 0x006DC8D4
		public bool StartFromLoop { get; set; }

		// Token: 0x1700D605 RID: 54789
		// (get) Token: 0x06032E04 RID: 208388 RVA: 0x006DE6DD File Offset: 0x006DC8DD
		// (set) Token: 0x06032E05 RID: 208389 RVA: 0x006DE6E5 File Offset: 0x006DC8E5
		public IMontageParamT OverlayMontage { get; set; }

		// Token: 0x1700D606 RID: 54790
		// (get) Token: 0x06032E06 RID: 208390 RVA: 0x006DE6EE File Offset: 0x006DC8EE
		// (set) Token: 0x06032E07 RID: 208391 RVA: 0x006DE6F6 File Offset: 0x006DC8F6
		public int FaceExpressionId { get; set; }

		// Token: 0x1700D607 RID: 54791
		// (get) Token: 0x06032E08 RID: 208392 RVA: 0x006DE6FF File Offset: 0x006DC8FF
		// (set) Token: 0x06032E09 RID: 208393 RVA: 0x006DE707 File Offset: 0x006DC907
		public bool KeepFaceExpression { get; set; }

		// Token: 0x1700D608 RID: 54792
		// (get) Token: 0x06032E0A RID: 208394 RVA: 0x006DE710 File Offset: 0x006DC910
		// (set) Token: 0x06032E0B RID: 208395 RVA: 0x006DE718 File Offset: 0x006DC918
		public List<IActorFxEmotePlayT> FxEmote { get; set; }

		// Token: 0x1700D609 RID: 54793
		// (get) Token: 0x06032E0C RID: 208396 RVA: 0x006DE721 File Offset: 0x006DC921
		// (set) Token: 0x06032E0D RID: 208397 RVA: 0x006DE729 File Offset: 0x006DC929
		public ushort NullMask { get; set; }

		// Token: 0x06032E0E RID: 208398 RVA: 0x006DE734 File Offset: 0x006DC934
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
