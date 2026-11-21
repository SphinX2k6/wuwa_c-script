using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball
{
	// Token: 0x02005249 RID: 21065
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainRootViewOpenParam : IPinballMainRootViewOpenParam
	{
		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x0603470B RID: 214795 RVA: 0x00EACA1D File Offset: 0x00EAAC1D
		// (set) Token: 0x0603470C RID: 214796 RVA: 0x00EACA25 File Offset: 0x00EAAC25
		public string ChildView { get; set; }

		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x0603470D RID: 214797 RVA: 0x00EACA2E File Offset: 0x00EAAC2E
		// (set) Token: 0x0603470E RID: 214798 RVA: 0x00EACA36 File Offset: 0x00EAAC36
		public int? LevelId { get; set; }

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x0603470F RID: 214799 RVA: 0x00EACA3F File Offset: 0x00EAAC3F
		// (set) Token: 0x06034710 RID: 214800 RVA: 0x00EACA47 File Offset: 0x00EAAC47
		public bool? IsFromInstanceDungeon { get; set; }
	}
}
