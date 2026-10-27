using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052DA RID: 21210
	public class IFurnitureCameraT
	{
		// Token: 0x17009BA4 RID: 39844
		// (get) Token: 0x060229D7 RID: 141783 RVA: 0x004CC5B4 File Offset: 0x004CA7B4
		// (set) Token: 0x060229D8 RID: 141784 RVA: 0x004CC5BC File Offset: 0x004CA7BC
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17009BA5 RID: 39845
		// (get) Token: 0x060229D9 RID: 141785 RVA: 0x004CC5C5 File Offset: 0x004CA7C5
		// (set) Token: 0x060229DA RID: 141786 RVA: 0x004CC5CD File Offset: 0x004CA7CD
		public IVectorInfoT Rot { get; set; }

		// Token: 0x17009BA6 RID: 39846
		// (get) Token: 0x060229DB RID: 141787 RVA: 0x004CC5D6 File Offset: 0x004CA7D6
		// (set) Token: 0x060229DC RID: 141788 RVA: 0x004CC5DE File Offset: 0x004CA7DE
		public int Fov { get; set; }

		// Token: 0x17009BA7 RID: 39847
		// (get) Token: 0x060229DD RID: 141789 RVA: 0x004CC5E7 File Offset: 0x004CA7E7
		// (set) Token: 0x060229DE RID: 141790 RVA: 0x004CC5EF File Offset: 0x004CA7EF
		public IBlendFunctionT FadeInCurve { get; set; }

		// Token: 0x17009BA8 RID: 39848
		// (get) Token: 0x060229DF RID: 141791 RVA: 0x004CC5F8 File Offset: 0x004CA7F8
		// (set) Token: 0x060229E0 RID: 141792 RVA: 0x004CC600 File Offset: 0x004CA800
		public float FadeInTime { get; set; }

		// Token: 0x17009BA9 RID: 39849
		// (get) Token: 0x060229E1 RID: 141793 RVA: 0x004CC609 File Offset: 0x004CA809
		// (set) Token: 0x060229E2 RID: 141794 RVA: 0x004CC611 File Offset: 0x004CA811
		public byte NullMask { get; set; }

		// Token: 0x060229E3 RID: 141795 RVA: 0x004CC61A File Offset: 0x004CA81A
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
