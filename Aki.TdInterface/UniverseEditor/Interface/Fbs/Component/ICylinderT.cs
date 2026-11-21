using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CF RID: 21967
	public class ICylinderT
	{
		// Token: 0x17009D42 RID: 40258
		// (get) Token: 0x06022F37 RID: 143159 RVA: 0x004CF963 File Offset: 0x004CDB63
		// (set) Token: 0x06022F38 RID: 143160 RVA: 0x004CF96B File Offset: 0x004CDB6B
		public bool IsUse { get; set; }

		// Token: 0x17009D43 RID: 40259
		// (get) Token: 0x06022F39 RID: 143161 RVA: 0x004CF974 File Offset: 0x004CDB74
		// (set) Token: 0x06022F3A RID: 143162 RVA: 0x004CF97C File Offset: 0x004CDB7C
		public int Radius { get; set; }

		// Token: 0x17009D44 RID: 40260
		// (get) Token: 0x06022F3B RID: 143163 RVA: 0x004CF985 File Offset: 0x004CDB85
		// (set) Token: 0x06022F3C RID: 143164 RVA: 0x004CF98D File Offset: 0x004CDB8D
		public int Height { get; set; }

		// Token: 0x17009D45 RID: 40261
		// (get) Token: 0x06022F3D RID: 143165 RVA: 0x004CF996 File Offset: 0x004CDB96
		// (set) Token: 0x06022F3E RID: 143166 RVA: 0x004CF99E File Offset: 0x004CDB9E
		public IPosAT CylinderPos { get; set; }

		// Token: 0x06022F3F RID: 143167 RVA: 0x004CF9A7 File Offset: 0x004CDBA7
		public ICylinderT()
		{
			this.IsUse = false;
			this.Radius = 0;
			this.Height = 0;
			this.CylinderPos = null;
		}
	}
}
