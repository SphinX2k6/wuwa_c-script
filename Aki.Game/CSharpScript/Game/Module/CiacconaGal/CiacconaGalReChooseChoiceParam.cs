using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BDC RID: 23516
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalReChooseChoiceParam : ICiacconaGalReChooseChoiceParam
	{
		// Token: 0x17008D5F RID: 36191
		// (get) Token: 0x0603B727 RID: 243495 RVA: 0x00E2CD4E File Offset: 0x00E2AF4E
		// (set) Token: 0x0603B728 RID: 243496 RVA: 0x00E2CD56 File Offset: 0x00E2AF56
		public string Text { get; set; }

		// Token: 0x17008D60 RID: 36192
		// (get) Token: 0x0603B729 RID: 243497 RVA: 0x00E2CD5F File Offset: 0x00E2AF5F
		// (set) Token: 0x0603B72A RID: 243498 RVA: 0x00E2CD67 File Offset: 0x00E2AF67
		public EToggleState TogState { get; set; }

		// Token: 0x17008D61 RID: 36193
		// (get) Token: 0x0603B72B RID: 243499 RVA: 0x00E2CD70 File Offset: 0x00E2AF70
		// (set) Token: 0x0603B72C RID: 243500 RVA: 0x00E2CD78 File Offset: 0x00E2AF78
		public string IconResId { get; set; }

		// Token: 0x17008D62 RID: 36194
		// (get) Token: 0x0603B72D RID: 243501 RVA: 0x00E2CD81 File Offset: 0x00E2AF81
		// (set) Token: 0x0603B72E RID: 243502 RVA: 0x00E2CD89 File Offset: 0x00E2AF89
		public Action OnClick { get; set; }
	}
}
