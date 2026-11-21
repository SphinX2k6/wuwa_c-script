using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CA RID: 24778
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockRingConfig : IBrokenRockRingConfig
	{
		// Token: 0x17007089 RID: 28809
		// (get) Token: 0x0603B68B RID: 243339 RVA: 0x010CFDE2 File Offset: 0x010CDFE2
		// (set) Token: 0x0603B68C RID: 243340 RVA: 0x010CFDEA File Offset: 0x010CDFEA
		public int Id { get; set; }

		// Token: 0x1700708A RID: 28810
		// (get) Token: 0x0603B68D RID: 243341 RVA: 0x010CFDF3 File Offset: 0x010CDFF3
		// (set) Token: 0x0603B68E RID: 243342 RVA: 0x010CFDFB File Offset: 0x010CDFFB
		public List<List<int>> InvalidBox { get; set; }

		// Token: 0x1700708B RID: 28811
		// (get) Token: 0x0603B68F RID: 243343 RVA: 0x010CFE04 File Offset: 0x010CE004
		// (set) Token: 0x0603B690 RID: 243344 RVA: 0x010CFE0C File Offset: 0x010CE00C
		public int[] RandomBox { get; set; }

		// Token: 0x1700708C RID: 28812
		// (get) Token: 0x0603B691 RID: 243345 RVA: 0x010CFE15 File Offset: 0x010CE015
		// (set) Token: 0x0603B692 RID: 243346 RVA: 0x010CFE1D File Offset: 0x010CE01D
		public int PerfectBox { get; set; }

		// Token: 0x1700708D RID: 28813
		// (get) Token: 0x0603B693 RID: 243347 RVA: 0x010CFE26 File Offset: 0x010CE026
		// (set) Token: 0x0603B694 RID: 243348 RVA: 0x010CFE2E File Offset: 0x010CE02E
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> BonusRate { get; set; }

		// Token: 0x1700708E RID: 28814
		// (get) Token: 0x0603B695 RID: 243349 RVA: 0x010CFE37 File Offset: 0x010CE037
		// (set) Token: 0x0603B696 RID: 243350 RVA: 0x010CFE3F File Offset: 0x010CE03F
		public int GoodScore { get; set; }

		// Token: 0x1700708F RID: 28815
		// (get) Token: 0x0603B697 RID: 243351 RVA: 0x010CFE48 File Offset: 0x010CE048
		// (set) Token: 0x0603B698 RID: 243352 RVA: 0x010CFE50 File Offset: 0x010CE050
		public int PerfectScore { get; set; }

		// Token: 0x17007090 RID: 28816
		// (get) Token: 0x0603B699 RID: 243353 RVA: 0x010CFE59 File Offset: 0x010CE059
		// (set) Token: 0x0603B69A RID: 243354 RVA: 0x010CFE61 File Offset: 0x010CE061
		public int BonusScore { get; set; }

		// Token: 0x17007091 RID: 28817
		// (get) Token: 0x0603B69B RID: 243355 RVA: 0x010CFE6A File Offset: 0x010CE06A
		// (set) Token: 0x0603B69C RID: 243356 RVA: 0x010CFE72 File Offset: 0x010CE072
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> Speed { get; set; }

		// Token: 0x17007092 RID: 28818
		// (get) Token: 0x0603B69D RID: 243357 RVA: 0x010CFE7B File Offset: 0x010CE07B
		// (set) Token: 0x0603B69E RID: 243358 RVA: 0x010CFE83 File Offset: 0x010CE083
		public int ColdTime { get; set; }

		// Token: 0x17007093 RID: 28819
		// (get) Token: 0x0603B69F RID: 243359 RVA: 0x010CFE8C File Offset: 0x010CE08C
		// (set) Token: 0x0603B6A0 RID: 243360 RVA: 0x010CFE94 File Offset: 0x010CE094
		public int MultiBoxGroup { get; set; }

		// Token: 0x17007094 RID: 28820
		// (get) Token: 0x0603B6A1 RID: 243361 RVA: 0x010CFE9D File Offset: 0x010CE09D
		// (set) Token: 0x0603B6A2 RID: 243362 RVA: 0x010CFEA5 File Offset: 0x010CE0A5
		public int[] Offset { get; set; }

		// Token: 0x17007095 RID: 28821
		// (get) Token: 0x0603B6A3 RID: 243363 RVA: 0x010CFEAE File Offset: 0x010CE0AE
		// (set) Token: 0x0603B6A4 RID: 243364 RVA: 0x010CFEB6 File Offset: 0x010CE0B6
		public bool IsAnticlockwise { get; set; }
	}
}
