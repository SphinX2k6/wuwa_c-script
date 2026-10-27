using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C82 RID: 27778
	public class IPerformerAiMoveToT
	{
		// Token: 0x1700CEDF RID: 52959
		// (get) Token: 0x06030F33 RID: 200499 RVA: 0x006A5831 File Offset: 0x006A3A31
		// (set) Token: 0x06030F34 RID: 200500 RVA: 0x006A5839 File Offset: 0x006A3A39
		public TPerformerAiMoveToConfigUnion Config { get; set; }

		// Token: 0x1700CEE0 RID: 52960
		// (get) Token: 0x06030F35 RID: 200501 RVA: 0x006A5842 File Offset: 0x006A3A42
		// (set) Token: 0x06030F36 RID: 200502 RVA: 0x006A584A File Offset: 0x006A3A4A
		public float StopDistance { get; set; }

		// Token: 0x1700CEE1 RID: 52961
		// (get) Token: 0x06030F37 RID: 200503 RVA: 0x006A5853 File Offset: 0x006A3A53
		// (set) Token: 0x06030F38 RID: 200504 RVA: 0x006A585B File Offset: 0x006A3A5B
		public byte NullMask { get; set; }

		// Token: 0x06030F39 RID: 200505 RVA: 0x006A5864 File Offset: 0x006A3A64
		public IPerformerAiMoveToT()
		{
			this.Config = null;
			this.StopDistance = 0f;
			this.NullMask = 0;
		}
	}
}
