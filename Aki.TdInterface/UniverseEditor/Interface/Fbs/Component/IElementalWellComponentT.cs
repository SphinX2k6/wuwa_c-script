using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200513F RID: 20799
	public class IElementalWellComponentT
	{
		// Token: 0x1700979A RID: 38810
		// (get) Token: 0x060218D2 RID: 137426 RVA: 0x004A8777 File Offset: 0x004A6977
		// (set) Token: 0x060218D3 RID: 137427 RVA: 0x004A877F File Offset: 0x004A697F
		public bool Disabled { get; set; }

		// Token: 0x1700979B RID: 38811
		// (get) Token: 0x060218D4 RID: 137428 RVA: 0x004A8788 File Offset: 0x004A6988
		// (set) Token: 0x060218D5 RID: 137429 RVA: 0x004A8790 File Offset: 0x004A6990
		public EElementalWellEntryType WellType { get; set; }

		// Token: 0x1700979C RID: 38812
		// (get) Token: 0x060218D6 RID: 137430 RVA: 0x004A8799 File Offset: 0x004A6999
		// (set) Token: 0x060218D7 RID: 137431 RVA: 0x004A87A1 File Offset: 0x004A69A1
		public IWellStreamingRenderConfigT StreamingRenderConfig { get; set; }

		// Token: 0x1700979D RID: 38813
		// (get) Token: 0x060218D8 RID: 137432 RVA: 0x004A87AA File Offset: 0x004A69AA
		// (set) Token: 0x060218D9 RID: 137433 RVA: 0x004A87B2 File Offset: 0x004A69B2
		public IStreamingWaitConfigT StreamWaitConfig { get; set; }

		// Token: 0x1700979E RID: 38814
		// (get) Token: 0x060218DA RID: 137434 RVA: 0x004A87BB File Offset: 0x004A69BB
		// (set) Token: 0x060218DB RID: 137435 RVA: 0x004A87C3 File Offset: 0x004A69C3
		public string StreamingFinishedToState { get; set; }

		// Token: 0x1700979F RID: 38815
		// (get) Token: 0x060218DC RID: 137436 RVA: 0x004A87CC File Offset: 0x004A69CC
		// (set) Token: 0x060218DD RID: 137437 RVA: 0x004A87D4 File Offset: 0x004A69D4
		public string LeaveRangeToState { get; set; }

		// Token: 0x170097A0 RID: 38816
		// (get) Token: 0x060218DE RID: 137438 RVA: 0x004A87DD File Offset: 0x004A69DD
		// (set) Token: 0x060218DF RID: 137439 RVA: 0x004A87E5 File Offset: 0x004A69E5
		public string PrefabBindPointKey { get; set; }

		// Token: 0x170097A1 RID: 38817
		// (get) Token: 0x060218E0 RID: 137440 RVA: 0x004A87EE File Offset: 0x004A69EE
		// (set) Token: 0x060218E1 RID: 137441 RVA: 0x004A87F6 File Offset: 0x004A69F6
		public byte NullMask { get; set; }

		// Token: 0x060218E2 RID: 137442 RVA: 0x004A87FF File Offset: 0x004A69FF
		public IElementalWellComponentT()
		{
			this.Disabled = false;
			this.WellType = EElementalWellEntryType.Entry;
			this.StreamingRenderConfig = null;
			this.StreamWaitConfig = null;
			this.StreamingFinishedToState = null;
			this.LeaveRangeToState = null;
			this.PrefabBindPointKey = null;
			this.NullMask = 0;
		}
	}
}
