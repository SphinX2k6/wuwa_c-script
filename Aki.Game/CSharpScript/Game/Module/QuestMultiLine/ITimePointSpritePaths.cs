using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuestMultiLine
{
	// Token: 0x02003F6E RID: 16238
	[NullableContext(1)]
	public interface ITimePointSpritePaths
	{
		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x0602918A RID: 168330
		// (set) Token: 0x0602918B RID: 168331
		string Idle { get; set; }

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x0602918C RID: 168332
		// (set) Token: 0x0602918D RID: 168333
		string Hover { get; set; }

		// Token: 0x17005321 RID: 21281
		// (get) Token: 0x0602918E RID: 168334
		// (set) Token: 0x0602918F RID: 168335
		string Pressed { get; set; }

		// Token: 0x17005322 RID: 21282
		// (get) Token: 0x06029190 RID: 168336
		// (set) Token: 0x06029191 RID: 168337
		string Selected { get; set; }
	}
}
