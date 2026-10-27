using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C64 RID: 27748
	public class IPathLineFacingCurrentDirectionT
	{
		// Token: 0x1700CEA5 RID: 52901
		// (get) Token: 0x06030E3F RID: 200255 RVA: 0x006A3D72 File Offset: 0x006A1F72
		// (set) Token: 0x06030E40 RID: 200256 RVA: 0x006A3D7A File Offset: 0x006A1F7A
		public EPathLineFacingType Type { get; set; }

		// Token: 0x1700CEA6 RID: 52902
		// (get) Token: 0x06030E41 RID: 200257 RVA: 0x006A3D83 File Offset: 0x006A1F83
		// (set) Token: 0x06030E42 RID: 200258 RVA: 0x006A3D8B File Offset: 0x006A1F8B
		public float YawOffset { get; set; }

		// Token: 0x1700CEA7 RID: 52903
		// (get) Token: 0x06030E43 RID: 200259 RVA: 0x006A3D94 File Offset: 0x006A1F94
		// (set) Token: 0x06030E44 RID: 200260 RVA: 0x006A3D9C File Offset: 0x006A1F9C
		public byte NullMask { get; set; }

		// Token: 0x06030E45 RID: 200261 RVA: 0x006A3DA5 File Offset: 0x006A1FA5
		public IPathLineFacingCurrentDirectionT()
		{
			this.Type = EPathLineFacingType.Current;
			this.YawOffset = 0f;
			this.NullMask = 0;
		}
	}
}
