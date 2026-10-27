using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007575 RID: 30069
	public class IVisualNovelConfigT
	{
		// Token: 0x1700E40D RID: 58381
		// (get) Token: 0x06036B3E RID: 224062 RVA: 0x0076D905 File Offset: 0x0076BB05
		// (set) Token: 0x06036B3F RID: 224063 RVA: 0x0076D90D File Offset: 0x0076BB0D
		public EVisualNovelSubType VisualNovelSubType { get; set; }

		// Token: 0x1700E40E RID: 58382
		// (get) Token: 0x06036B40 RID: 224064 RVA: 0x0076D916 File Offset: 0x0076BB16
		// (set) Token: 0x06036B41 RID: 224065 RVA: 0x0076D91E File Offset: 0x0076BB1E
		public bool EnableReadRecord { get; set; }

		// Token: 0x1700E40F RID: 58383
		// (get) Token: 0x06036B42 RID: 224066 RVA: 0x0076D927 File Offset: 0x0076BB27
		// (set) Token: 0x06036B43 RID: 224067 RVA: 0x0076D92F File Offset: 0x0076BB2F
		public bool HideControlUi { get; set; }

		// Token: 0x1700E410 RID: 58384
		// (get) Token: 0x06036B44 RID: 224068 RVA: 0x0076D938 File Offset: 0x0076BB38
		// (set) Token: 0x06036B45 RID: 224069 RVA: 0x0076D940 File Offset: 0x0076BB40
		public int InitialBackgroundId { get; set; }

		// Token: 0x1700E411 RID: 58385
		// (get) Token: 0x06036B46 RID: 224070 RVA: 0x0076D949 File Offset: 0x0076BB49
		// (set) Token: 0x06036B47 RID: 224071 RVA: 0x0076D951 File Offset: 0x0076BB51
		public string InitialAudioEvent { get; set; }

		// Token: 0x1700E412 RID: 58386
		// (get) Token: 0x06036B48 RID: 224072 RVA: 0x0076D95A File Offset: 0x0076BB5A
		// (set) Token: 0x06036B49 RID: 224073 RVA: 0x0076D962 File Offset: 0x0076BB62
		public ISolarSchoolTimeT InitialTime { get; set; }

		// Token: 0x1700E413 RID: 58387
		// (get) Token: 0x06036B4A RID: 224074 RVA: 0x0076D96B File Offset: 0x0076BB6B
		// (set) Token: 0x06036B4B RID: 224075 RVA: 0x0076D973 File Offset: 0x0076BB73
		public byte NullMask { get; set; }

		// Token: 0x06036B4C RID: 224076 RVA: 0x0076D97C File Offset: 0x0076BB7C
		public IVisualNovelConfigT()
		{
			this.VisualNovelSubType = EVisualNovelSubType.SolarSchool;
			this.EnableReadRecord = false;
			this.HideControlUi = false;
			this.InitialBackgroundId = 0;
			this.InitialAudioEvent = null;
			this.InitialTime = null;
			this.NullMask = 0;
		}
	}
}
