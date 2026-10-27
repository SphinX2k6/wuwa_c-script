using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D2 RID: 20946
	public class IExhibitEffectT
	{
		// Token: 0x1700994F RID: 39247
		// (get) Token: 0x06021F7C RID: 139132 RVA: 0x004B65C5 File Offset: 0x004B47C5
		// (set) Token: 0x06021F7D RID: 139133 RVA: 0x004B65CD File Offset: 0x004B47CD
		public string Path { get; set; }

		// Token: 0x17009950 RID: 39248
		// (get) Token: 0x06021F7E RID: 139134 RVA: 0x004B65D6 File Offset: 0x004B47D6
		// (set) Token: 0x06021F7F RID: 139135 RVA: 0x004B65DE File Offset: 0x004B47DE
		public float Scale { get; set; }

		// Token: 0x17009951 RID: 39249
		// (get) Token: 0x06021F80 RID: 139136 RVA: 0x004B65E7 File Offset: 0x004B47E7
		// (set) Token: 0x06021F81 RID: 139137 RVA: 0x004B65EF File Offset: 0x004B47EF
		public IVectorInfoT Offset { get; set; }

		// Token: 0x06021F82 RID: 139138 RVA: 0x004B65F8 File Offset: 0x004B47F8
		public IExhibitEffectT()
		{
			this.Path = null;
			this.Scale = 0f;
			this.Offset = null;
		}
	}
}
