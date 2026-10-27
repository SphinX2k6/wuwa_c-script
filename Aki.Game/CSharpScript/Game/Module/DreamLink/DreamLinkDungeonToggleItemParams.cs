using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A9A RID: 23194
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkDungeonToggleItemParams : IDreamLinkDungeonToggleItemParams
	{
		// Token: 0x17008C09 RID: 35849
		// (get) Token: 0x0603AC1A RID: 240666 RVA: 0x00DFEEDB File Offset: 0x00DFD0DB
		// (set) Token: 0x0603AC1B RID: 240667 RVA: 0x00DFEEE3 File Offset: 0x00DFD0E3
		public string TextureBgPath { get; set; }

		// Token: 0x17008C0A RID: 35850
		// (get) Token: 0x0603AC1C RID: 240668 RVA: 0x00DFEEEC File Offset: 0x00DFD0EC
		// (set) Token: 0x0603AC1D RID: 240669 RVA: 0x00DFEEF4 File Offset: 0x00DFD0F4
		public string TextureLightPath { get; set; }

		// Token: 0x17008C0B RID: 35851
		// (get) Token: 0x0603AC1E RID: 240670 RVA: 0x00DFEEFD File Offset: 0x00DFD0FD
		// (set) Token: 0x0603AC1F RID: 240671 RVA: 0x00DFEF05 File Offset: 0x00DFD105
		public string EffectColor { get; set; }
	}
}
