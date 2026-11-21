using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E7C RID: 20092
	[NullableContext(2)]
	internal interface IGondolaPlotAudioHandle
	{
		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x06032927 RID: 207143
		// (set) Token: 0x06032928 RID: 207144
		int RoleId { get; set; }

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x06032929 RID: 207145
		// (set) Token: 0x0603292A RID: 207146
		int PassengerId { get; set; }

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x0603292B RID: 207147
		// (set) Token: 0x0603292C RID: 207148
		BaseActorComponent PassengerActor { get; set; }

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x0603292D RID: 207149
		// (set) Token: 0x0603292E RID: 207150
		AudioHandleInfo AudioHandle { get; set; }

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x0603292F RID: 207151
		// (set) Token: 0x06032930 RID: 207152
		PlotHandleInfo PlotHandle { get; set; }
	}
}
