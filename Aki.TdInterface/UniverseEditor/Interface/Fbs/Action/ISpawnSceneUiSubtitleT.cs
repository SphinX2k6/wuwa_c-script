using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200793F RID: 31039
	public class ISpawnSceneUiSubtitleT
	{
		// Token: 0x1700E3B3 RID: 58291
		// (get) Token: 0x06036AB3 RID: 223923 RVA: 0x00750D11 File Offset: 0x0074EF11
		// (set) Token: 0x06036AB4 RID: 223924 RVA: 0x00750D19 File Offset: 0x0074EF19
		public ESceneUiSubtitleOperationType Type { get; set; }

		// Token: 0x1700E3B4 RID: 58292
		// (get) Token: 0x06036AB5 RID: 223925 RVA: 0x00750D22 File Offset: 0x0074EF22
		// (set) Token: 0x06036AB6 RID: 223926 RVA: 0x00750D2A File Offset: 0x0074EF2A
		public string Mark { get; set; }

		// Token: 0x1700E3B5 RID: 58293
		// (get) Token: 0x06036AB7 RID: 223927 RVA: 0x00750D33 File Offset: 0x0074EF33
		// (set) Token: 0x06036AB8 RID: 223928 RVA: 0x00750D3B File Offset: 0x0074EF3B
		public TSceneUiSubtitleStyleUnion Style { get; set; }

		// Token: 0x1700E3B6 RID: 58294
		// (get) Token: 0x06036AB9 RID: 223929 RVA: 0x00750D44 File Offset: 0x0074EF44
		// (set) Token: 0x06036ABA RID: 223930 RVA: 0x00750D4C File Offset: 0x0074EF4C
		public TSceneUiSubtitleTextUnion Text { get; set; }

		// Token: 0x1700E3B7 RID: 58295
		// (get) Token: 0x06036ABB RID: 223931 RVA: 0x00750D55 File Offset: 0x0074EF55
		// (set) Token: 0x06036ABC RID: 223932 RVA: 0x00750D5D File Offset: 0x0074EF5D
		public bool RemoveAfterPlay { get; set; }

		// Token: 0x1700E3B8 RID: 58296
		// (get) Token: 0x06036ABD RID: 223933 RVA: 0x00750D66 File Offset: 0x0074EF66
		// (set) Token: 0x06036ABE RID: 223934 RVA: 0x00750D6E File Offset: 0x0074EF6E
		public byte NullMask { get; set; }

		// Token: 0x06036ABF RID: 223935 RVA: 0x00750D77 File Offset: 0x0074EF77
		public ISpawnSceneUiSubtitleT()
		{
			this.Type = ESceneUiSubtitleOperationType.Spawn;
			this.Mark = null;
			this.Style = null;
			this.Text = null;
			this.RemoveAfterPlay = false;
			this.NullMask = 0;
		}
	}
}
