using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A2 RID: 17058
	public class IWordArtDefaultResourceTypeT
	{
		// Token: 0x17007919 RID: 31001
		// (get) Token: 0x0601946F RID: 103535 RVA: 0x003A149E File Offset: 0x0039F69E
		// (set) Token: 0x06019470 RID: 103536 RVA: 0x003A14A6 File Offset: 0x0039F6A6
		public EWordArtResourceType Type { get; set; }

		// Token: 0x1700791A RID: 31002
		// (get) Token: 0x06019471 RID: 103537 RVA: 0x003A14AF File Offset: 0x0039F6AF
		// (set) Token: 0x06019472 RID: 103538 RVA: 0x003A14B7 File Offset: 0x0039F6B7
		public float Scale { get; set; }

		// Token: 0x1700791B RID: 31003
		// (get) Token: 0x06019473 RID: 103539 RVA: 0x003A14C0 File Offset: 0x0039F6C0
		// (set) Token: 0x06019474 RID: 103540 RVA: 0x003A14C8 File Offset: 0x0039F6C8
		public byte NullMask { get; set; }

		// Token: 0x06019475 RID: 103541 RVA: 0x003A14D1 File Offset: 0x0039F6D1
		public IWordArtDefaultResourceTypeT()
		{
			this.Type = EWordArtResourceType.Default;
			this.Scale = 0f;
			this.NullMask = 0;
		}
	}
}
