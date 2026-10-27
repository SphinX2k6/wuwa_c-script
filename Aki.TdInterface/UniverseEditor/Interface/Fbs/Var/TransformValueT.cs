using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B54 RID: 15188
	public class TransformValueT
	{
		// Token: 0x17006823 RID: 26659
		// (get) Token: 0x06014C49 RID: 85065 RVA: 0x0030493D File Offset: 0x00302B3D
		// (set) Token: 0x06014C4A RID: 85066 RVA: 0x00304945 File Offset: 0x00302B45
		public IPosAndRotT Value { get; set; }

		// Token: 0x06014C4B RID: 85067 RVA: 0x0030494E File Offset: 0x00302B4E
		public TransformValueT()
		{
			this.Value = null;
		}
	}
}
