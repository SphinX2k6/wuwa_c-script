using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007232 RID: 29234
	public class IMontageDataRenderT
	{
		// Token: 0x1700D616 RID: 54806
		// (get) Token: 0x06032E38 RID: 208440 RVA: 0x006DF097 File Offset: 0x006DD297
		// (set) Token: 0x06032E39 RID: 208441 RVA: 0x006DF09F File Offset: 0x006DD29F
		public int ActorIndex { get; set; }

		// Token: 0x1700D617 RID: 54807
		// (get) Token: 0x06032E3A RID: 208442 RVA: 0x006DF0A8 File Offset: 0x006DD2A8
		// (set) Token: 0x06032E3B RID: 208443 RVA: 0x006DF0B0 File Offset: 0x006DD2B0
		public IMontageParamT BaseMontage { get; set; }

		// Token: 0x1700D618 RID: 54808
		// (get) Token: 0x06032E3C RID: 208444 RVA: 0x006DF0B9 File Offset: 0x006DD2B9
		// (set) Token: 0x06032E3D RID: 208445 RVA: 0x006DF0C1 File Offset: 0x006DD2C1
		public bool EndLoopingMontage { get; set; }

		// Token: 0x1700D619 RID: 54809
		// (get) Token: 0x06032E3E RID: 208446 RVA: 0x006DF0CA File Offset: 0x006DD2CA
		// (set) Token: 0x06032E3F RID: 208447 RVA: 0x006DF0D2 File Offset: 0x006DD2D2
		public bool EndMontageDirectly { get; set; }

		// Token: 0x1700D61A RID: 54810
		// (get) Token: 0x06032E40 RID: 208448 RVA: 0x006DF0DB File Offset: 0x006DD2DB
		// (set) Token: 0x06032E41 RID: 208449 RVA: 0x006DF0E3 File Offset: 0x006DD2E3
		public bool StartFromLoop { get; set; }

		// Token: 0x1700D61B RID: 54811
		// (get) Token: 0x06032E42 RID: 208450 RVA: 0x006DF0EC File Offset: 0x006DD2EC
		// (set) Token: 0x06032E43 RID: 208451 RVA: 0x006DF0F4 File Offset: 0x006DD2F4
		public IMontageParamT OverlayMontage { get; set; }

		// Token: 0x1700D61C RID: 54812
		// (get) Token: 0x06032E44 RID: 208452 RVA: 0x006DF0FD File Offset: 0x006DD2FD
		// (set) Token: 0x06032E45 RID: 208453 RVA: 0x006DF105 File Offset: 0x006DD305
		public int FaceExpressionId { get; set; }

		// Token: 0x1700D61D RID: 54813
		// (get) Token: 0x06032E46 RID: 208454 RVA: 0x006DF10E File Offset: 0x006DD30E
		// (set) Token: 0x06032E47 RID: 208455 RVA: 0x006DF116 File Offset: 0x006DD316
		public bool KeepFaceExpression { get; set; }

		// Token: 0x1700D61E RID: 54814
		// (get) Token: 0x06032E48 RID: 208456 RVA: 0x006DF11F File Offset: 0x006DD31F
		// (set) Token: 0x06032E49 RID: 208457 RVA: 0x006DF127 File Offset: 0x006DD327
		public float DelayTime { get; set; }

		// Token: 0x1700D61F RID: 54815
		// (get) Token: 0x06032E4A RID: 208458 RVA: 0x006DF130 File Offset: 0x006DD330
		// (set) Token: 0x06032E4B RID: 208459 RVA: 0x006DF138 File Offset: 0x006DD338
		public List<IActorFxEmotePlayT> FxEmote { get; set; }

		// Token: 0x1700D620 RID: 54816
		// (get) Token: 0x06032E4C RID: 208460 RVA: 0x006DF141 File Offset: 0x006DD341
		// (set) Token: 0x06032E4D RID: 208461 RVA: 0x006DF149 File Offset: 0x006DD349
		public byte NullMask { get; set; }

		// Token: 0x06032E4E RID: 208462 RVA: 0x006DF154 File Offset: 0x006DD354
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
