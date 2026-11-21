using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585D RID: 22621
	public class IFurnitureCameraT
	{
		// Token: 0x1700A3D5 RID: 41941
		// (get) Token: 0x06024A71 RID: 150129 RVA: 0x005090E0 File Offset: 0x005072E0
		// (set) Token: 0x06024A72 RID: 150130 RVA: 0x005090E8 File Offset: 0x005072E8
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700A3D6 RID: 41942
		// (get) Token: 0x06024A73 RID: 150131 RVA: 0x005090F1 File Offset: 0x005072F1
		// (set) Token: 0x06024A74 RID: 150132 RVA: 0x005090F9 File Offset: 0x005072F9
		public IVectorInfoT Rot { get; set; }

		// Token: 0x1700A3D7 RID: 41943
		// (get) Token: 0x06024A75 RID: 150133 RVA: 0x00509102 File Offset: 0x00507302
		// (set) Token: 0x06024A76 RID: 150134 RVA: 0x0050910A File Offset: 0x0050730A
		public int Fov { get; set; }

		// Token: 0x1700A3D8 RID: 41944
		// (get) Token: 0x06024A77 RID: 150135 RVA: 0x00509113 File Offset: 0x00507313
		// (set) Token: 0x06024A78 RID: 150136 RVA: 0x0050911B File Offset: 0x0050731B
		public IBlendFunctionT FadeInCurve { get; set; }

		// Token: 0x1700A3D9 RID: 41945
		// (get) Token: 0x06024A79 RID: 150137 RVA: 0x00509124 File Offset: 0x00507324
		// (set) Token: 0x06024A7A RID: 150138 RVA: 0x0050912C File Offset: 0x0050732C
		public float FadeInTime { get; set; }

		// Token: 0x1700A3DA RID: 41946
		// (get) Token: 0x06024A7B RID: 150139 RVA: 0x00509135 File Offset: 0x00507335
		// (set) Token: 0x06024A7C RID: 150140 RVA: 0x0050913D File Offset: 0x0050733D
		public byte NullMask { get; set; }

		// Token: 0x06024A7D RID: 150141 RVA: 0x00509146 File Offset: 0x00507346
		public IFurnitureCameraT()
		{
			this.Pos = null;
			this.Rot = null;
			this.Fov = 0;
			this.FadeInCurve = null;
			this.FadeInTime = 0f;
			this.NullMask = 0;
		}
	}
}
