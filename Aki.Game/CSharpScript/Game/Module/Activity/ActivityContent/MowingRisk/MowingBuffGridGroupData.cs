using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200533A RID: 21306
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffGridGroupData : IMowingBuffGridGroupData
	{
		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x0603507A RID: 217210 RVA: 0x00ED26CC File Offset: 0x00ED08CC
		// (set) Token: 0x0603507B RID: 217211 RVA: 0x00ED26D4 File Offset: 0x00ED08D4
		public string GroupNameTextId { get; set; }

		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x0603507C RID: 217212 RVA: 0x00ED26DD File Offset: 0x00ED08DD
		// (set) Token: 0x0603507D RID: 217213 RVA: 0x00ED26E5 File Offset: 0x00ED08E5
		public bool ShowUnlockText { get; set; }

		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x0603507E RID: 217214 RVA: 0x00ED26EE File Offset: 0x00ED08EE
		// (set) Token: 0x0603507F RID: 217215 RVA: 0x00ED26F6 File Offset: 0x00ED08F6
		public IMowingBuffGridItemData[] BuffItemList { get; set; }
	}
}
