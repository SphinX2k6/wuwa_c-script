using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C67 RID: 27751
	public class IPathLineFacingCustomDirectionT
	{
		// Token: 0x1700CEAB RID: 52907
		// (get) Token: 0x06030E57 RID: 200279 RVA: 0x006A3FB4 File Offset: 0x006A21B4
		// (set) Token: 0x06030E58 RID: 200280 RVA: 0x006A3FBC File Offset: 0x006A21BC
		public EPathLineFacingType Type { get; set; }

		// Token: 0x1700CEAC RID: 52908
		// (get) Token: 0x06030E59 RID: 200281 RVA: 0x006A3FC5 File Offset: 0x006A21C5
		// (set) Token: 0x06030E5A RID: 200282 RVA: 0x006A3FCD File Offset: 0x006A21CD
		public float Yaw { get; set; }

		// Token: 0x06030E5B RID: 200283 RVA: 0x006A3FD6 File Offset: 0x006A21D6
		public IPathLineFacingCustomDirectionT()
		{
			this.Type = EPathLineFacingType.Current;
			this.Yaw = 0f;
		}
	}
}
