using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E7D RID: 20093
	[NullableContext(2)]
	[Nullable(0)]
	internal class GondolaPlotAudioHandle : IGondolaPlotAudioHandle
	{
		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x06032931 RID: 207153 RVA: 0x00E3071A File Offset: 0x00E2E91A
		// (set) Token: 0x06032932 RID: 207154 RVA: 0x00E30722 File Offset: 0x00E2E922
		public int RoleId { get; set; }

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x06032933 RID: 207155 RVA: 0x00E3072B File Offset: 0x00E2E92B
		// (set) Token: 0x06032934 RID: 207156 RVA: 0x00E30733 File Offset: 0x00E2E933
		public int PassengerId { get; set; }

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x06032935 RID: 207157 RVA: 0x00E3073C File Offset: 0x00E2E93C
		// (set) Token: 0x06032936 RID: 207158 RVA: 0x00E30744 File Offset: 0x00E2E944
		public BaseActorComponent PassengerActor { get; set; }

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x06032937 RID: 207159 RVA: 0x00E3074D File Offset: 0x00E2E94D
		// (set) Token: 0x06032938 RID: 207160 RVA: 0x00E30755 File Offset: 0x00E2E955
		public AudioHandleInfo AudioHandle { get; set; }

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x06032939 RID: 207161 RVA: 0x00E3075E File Offset: 0x00E2E95E
		// (set) Token: 0x0603293A RID: 207162 RVA: 0x00E30766 File Offset: 0x00E2E966
		public PlotHandleInfo PlotHandle { get; set; }
	}
}
