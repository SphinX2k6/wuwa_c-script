using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200463C RID: 17980
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewInfoForTimeDilation : IUiViewInfoForTimeDilation
	{
		// Token: 0x170075ED RID: 30189
		// (get) Token: 0x0602E5CB RID: 189899 RVA: 0x00AB68BC File Offset: 0x00AB4ABC
		// (set) Token: 0x0602E5CC RID: 189900 RVA: 0x00AB68C4 File Offset: 0x00AB4AC4
		public float TimeDilation { get; set; }

		// Token: 0x170075EE RID: 30190
		// (get) Token: 0x0602E5CD RID: 189901 RVA: 0x00AB68CD File Offset: 0x00AB4ACD
		// (set) Token: 0x0602E5CE RID: 189902 RVA: 0x00AB68D5 File Offset: 0x00AB4AD5
		public int ViewId { get; set; }

		// Token: 0x170075EF RID: 30191
		// (get) Token: 0x0602E5CF RID: 189903 RVA: 0x00AB68DE File Offset: 0x00AB4ADE
		// (set) Token: 0x0602E5D0 RID: 189904 RVA: 0x00AB68E6 File Offset: 0x00AB4AE6
		public EUiViewName? DebugName { get; set; }

		// Token: 0x170075F0 RID: 30192
		// (get) Token: 0x0602E5D1 RID: 189905 RVA: 0x00AB68EF File Offset: 0x00AB4AEF
		// (set) Token: 0x0602E5D2 RID: 189906 RVA: 0x00AB68F7 File Offset: 0x00AB4AF7
		public string Reason { get; set; }
	}
}
