using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D24 RID: 27940
	public class IPlayLevelSequenceT
	{
		// Token: 0x1700D00F RID: 53263
		// (get) Token: 0x0603146C RID: 201836 RVA: 0x006AEFDD File Offset: 0x006AD1DD
		// (set) Token: 0x0603146D RID: 201837 RVA: 0x006AEFE5 File Offset: 0x006AD1E5
		public string LevelSequencePath { get; set; }

		// Token: 0x1700D010 RID: 53264
		// (get) Token: 0x0603146E RID: 201838 RVA: 0x006AEFEE File Offset: 0x006AD1EE
		// (set) Token: 0x0603146F RID: 201839 RVA: 0x006AEFF6 File Offset: 0x006AD1F6
		public bool IsEnableCenterOffset { get; set; }

		// Token: 0x1700D011 RID: 53265
		// (get) Token: 0x06031470 RID: 201840 RVA: 0x006AEFFF File Offset: 0x006AD1FF
		// (set) Token: 0x06031471 RID: 201841 RVA: 0x006AF007 File Offset: 0x006AD207
		public bool KeepUI { get; set; }

		// Token: 0x1700D012 RID: 53266
		// (get) Token: 0x06031472 RID: 201842 RVA: 0x006AF010 File Offset: 0x006AD210
		// (set) Token: 0x06031473 RID: 201843 RVA: 0x006AF018 File Offset: 0x006AD218
		public string Mark { get; set; }

		// Token: 0x1700D013 RID: 53267
		// (get) Token: 0x06031474 RID: 201844 RVA: 0x006AF021 File Offset: 0x006AD221
		// (set) Token: 0x06031475 RID: 201845 RVA: 0x006AF029 File Offset: 0x006AD229
		public TPlayMode PlayMode { get; set; }

		// Token: 0x1700D014 RID: 53268
		// (get) Token: 0x06031476 RID: 201846 RVA: 0x006AF032 File Offset: 0x006AD232
		// (set) Token: 0x06031477 RID: 201847 RVA: 0x006AF03A File Offset: 0x006AD23A
		public ILoopRangeT LoopRange { get; set; }

		// Token: 0x1700D015 RID: 53269
		// (get) Token: 0x06031478 RID: 201848 RVA: 0x006AF043 File Offset: 0x006AD243
		// (set) Token: 0x06031479 RID: 201849 RVA: 0x006AF04B File Offset: 0x006AD24B
		public TLevelSequenceTransitionUnion Intro { get; set; }

		// Token: 0x1700D016 RID: 53270
		// (get) Token: 0x0603147A RID: 201850 RVA: 0x006AF054 File Offset: 0x006AD254
		// (set) Token: 0x0603147B RID: 201851 RVA: 0x006AF05C File Offset: 0x006AD25C
		public TLevelSequenceTransitionUnion Outro { get; set; }

		// Token: 0x1700D017 RID: 53271
		// (get) Token: 0x0603147C RID: 201852 RVA: 0x006AF065 File Offset: 0x006AD265
		// (set) Token: 0x0603147D RID: 201853 RVA: 0x006AF06D File Offset: 0x006AD26D
		public float Rate { get; set; }

		// Token: 0x1700D018 RID: 53272
		// (get) Token: 0x0603147E RID: 201854 RVA: 0x006AF076 File Offset: 0x006AD276
		// (set) Token: 0x0603147F RID: 201855 RVA: 0x006AF07E File Offset: 0x006AD27E
		public IEaseDataT RateEase { get; set; }

		// Token: 0x1700D019 RID: 53273
		// (get) Token: 0x06031480 RID: 201856 RVA: 0x006AF087 File Offset: 0x006AD287
		// (set) Token: 0x06031481 RID: 201857 RVA: 0x006AF08F File Offset: 0x006AD28F
		public bool IsPlayOnTeleport { get; set; }

		// Token: 0x1700D01A RID: 53274
		// (get) Token: 0x06031482 RID: 201858 RVA: 0x006AF098 File Offset: 0x006AD298
		// (set) Token: 0x06031483 RID: 201859 RVA: 0x006AF0A0 File Offset: 0x006AD2A0
		public bool IsCarryCharacter { get; set; }

		// Token: 0x1700D01B RID: 53275
		// (get) Token: 0x06031484 RID: 201860 RVA: 0x006AF0A9 File Offset: 0x006AD2A9
		// (set) Token: 0x06031485 RID: 201861 RVA: 0x006AF0B1 File Offset: 0x006AD2B1
		public IFloatingSubtitleLanguageDiffT PreprocessOperation { get; set; }

		// Token: 0x1700D01C RID: 53276
		// (get) Token: 0x06031486 RID: 201862 RVA: 0x006AF0BA File Offset: 0x006AD2BA
		// (set) Token: 0x06031487 RID: 201863 RVA: 0x006AF0C2 File Offset: 0x006AD2C2
		public byte NullMask { get; set; }

		// Token: 0x06031488 RID: 201864 RVA: 0x006AF0CC File Offset: 0x006AD2CC
		public IPlayLevelSequenceT()
		{
			this.LevelSequencePath = null;
			this.IsEnableCenterOffset = false;
			this.KeepUI = false;
			this.Mark = null;
			this.PlayMode = TPlayMode.direct;
			this.LoopRange = null;
			this.Intro = null;
			this.Outro = null;
			this.Rate = 0f;
			this.RateEase = null;
			this.IsPlayOnTeleport = false;
			this.IsCarryCharacter = false;
			this.PreprocessOperation = null;
			this.NullMask = 0;
		}
	}
}
