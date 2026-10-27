using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D30 RID: 27952
	public class IPlayMpcEffectT
	{
		// Token: 0x1700D043 RID: 53315
		// (get) Token: 0x0603151F RID: 202015 RVA: 0x006B08F5 File Offset: 0x006AEAF5
		// (set) Token: 0x06031520 RID: 202016 RVA: 0x006B08FD File Offset: 0x006AEAFD
		public EEffectType Type { get; set; }

		// Token: 0x1700D044 RID: 53316
		// (get) Token: 0x06031521 RID: 202017 RVA: 0x006B0906 File Offset: 0x006AEB06
		// (set) Token: 0x06031522 RID: 202018 RVA: 0x006B090E File Offset: 0x006AEB0E
		public string Path { get; set; }

		// Token: 0x1700D045 RID: 53317
		// (get) Token: 0x06031523 RID: 202019 RVA: 0x006B0917 File Offset: 0x006AEB17
		// (set) Token: 0x06031524 RID: 202020 RVA: 0x006B091F File Offset: 0x006AEB1F
		public TPos2Union Pos2 { get; set; }

		// Token: 0x1700D046 RID: 53318
		// (get) Token: 0x06031525 RID: 202021 RVA: 0x006B0928 File Offset: 0x006AEB28
		// (set) Token: 0x06031526 RID: 202022 RVA: 0x006B0930 File Offset: 0x006AEB30
		public List<IPostProcessVolumeCenterPositionT> Params { get; set; }

		// Token: 0x06031527 RID: 202023 RVA: 0x006B0939 File Offset: 0x006AEB39
		public IPlayMpcEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.Pos2 = null;
			this.Params = null;
		}
	}
}
