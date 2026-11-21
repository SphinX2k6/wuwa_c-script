using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200724A RID: 29258
	public class IMotorCatapultParamT
	{
		// Token: 0x1700D669 RID: 54889
		// (get) Token: 0x06032F4A RID: 208714 RVA: 0x006E1107 File Offset: 0x006DF307
		// (set) Token: 0x06032F4B RID: 208715 RVA: 0x006E110F File Offset: 0x006DF30F
		public IVectorInfoT P1 { get; set; }

		// Token: 0x1700D66A RID: 54890
		// (get) Token: 0x06032F4C RID: 208716 RVA: 0x006E1118 File Offset: 0x006DF318
		// (set) Token: 0x06032F4D RID: 208717 RVA: 0x006E1120 File Offset: 0x006DF320
		public IVectorInfoT P2 { get; set; }

		// Token: 0x1700D66B RID: 54891
		// (get) Token: 0x06032F4E RID: 208718 RVA: 0x006E1129 File Offset: 0x006DF329
		// (set) Token: 0x06032F4F RID: 208719 RVA: 0x006E1131 File Offset: 0x006DF331
		public float Gravity { get; set; }

		// Token: 0x1700D66C RID: 54892
		// (get) Token: 0x06032F50 RID: 208720 RVA: 0x006E113A File Offset: 0x006DF33A
		// (set) Token: 0x06032F51 RID: 208721 RVA: 0x006E1142 File Offset: 0x006DF342
		public float Time { get; set; }

		// Token: 0x1700D66D RID: 54893
		// (get) Token: 0x06032F52 RID: 208722 RVA: 0x006E114B File Offset: 0x006DF34B
		// (set) Token: 0x06032F53 RID: 208723 RVA: 0x006E1153 File Offset: 0x006DF353
		public string MotionCurve { get; set; }

		// Token: 0x1700D66E RID: 54894
		// (get) Token: 0x06032F54 RID: 208724 RVA: 0x006E115C File Offset: 0x006DF35C
		// (set) Token: 0x06032F55 RID: 208725 RVA: 0x006E1164 File Offset: 0x006DF364
		public IVectorInfoT P2Rot { get; set; }

		// Token: 0x1700D66F RID: 54895
		// (get) Token: 0x06032F56 RID: 208726 RVA: 0x006E116D File Offset: 0x006DF36D
		// (set) Token: 0x06032F57 RID: 208727 RVA: 0x006E1175 File Offset: 0x006DF375
		public string P2RotCurve { get; set; }

		// Token: 0x1700D670 RID: 54896
		// (get) Token: 0x06032F58 RID: 208728 RVA: 0x006E117E File Offset: 0x006DF37E
		// (set) Token: 0x06032F59 RID: 208729 RVA: 0x006E1186 File Offset: 0x006DF386
		public byte NullMask { get; set; }

		// Token: 0x06032F5A RID: 208730 RVA: 0x006E1190 File Offset: 0x006DF390
		public IMotorCatapultParamT()
		{
			this.P1 = null;
			this.P2 = null;
			this.Gravity = 0f;
			this.Time = 0f;
			this.MotionCurve = null;
			this.P2Rot = null;
			this.P2RotCurve = null;
			this.NullMask = 0;
		}
	}
}
