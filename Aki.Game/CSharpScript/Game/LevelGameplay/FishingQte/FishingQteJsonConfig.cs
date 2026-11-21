using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FAE RID: 24494
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteJsonConfig : IFishingQteConfig
	{
		// Token: 0x17006F16 RID: 28438
		// (get) Token: 0x0603AD68 RID: 241000 RVA: 0x010A1B7D File Offset: 0x0109FD7D
		// (set) Token: 0x0603AD69 RID: 241001 RVA: 0x010A1B85 File Offset: 0x0109FD85
		public int Id { get; set; }

		// Token: 0x17006F17 RID: 28439
		// (get) Token: 0x0603AD6A RID: 241002 RVA: 0x010A1B8E File Offset: 0x0109FD8E
		// (set) Token: 0x0603AD6B RID: 241003 RVA: 0x010A1B96 File Offset: 0x0109FD96
		public List<int> RandomArea { get; set; }

		// Token: 0x17006F18 RID: 28440
		// (get) Token: 0x0603AD6C RID: 241004 RVA: 0x010A1B9F File Offset: 0x0109FD9F
		// (set) Token: 0x0603AD6D RID: 241005 RVA: 0x010A1BA7 File Offset: 0x0109FDA7
		public List<List<int>> InvalidArea { get; set; }

		// Token: 0x17006F19 RID: 28441
		// (get) Token: 0x0603AD6E RID: 241006 RVA: 0x010A1BB0 File Offset: 0x0109FDB0
		// (set) Token: 0x0603AD6F RID: 241007 RVA: 0x010A1BB8 File Offset: 0x0109FDB8
		public int MaxScore { get; set; }

		// Token: 0x17006F1A RID: 28442
		// (get) Token: 0x0603AD70 RID: 241008 RVA: 0x010A1BC1 File Offset: 0x0109FDC1
		// (set) Token: 0x0603AD71 RID: 241009 RVA: 0x010A1BC9 File Offset: 0x0109FDC9
		public int HitAreaScore { get; set; }

		// Token: 0x17006F1B RID: 28443
		// (get) Token: 0x0603AD72 RID: 241010 RVA: 0x010A1BD2 File Offset: 0x0109FDD2
		// (set) Token: 0x0603AD73 RID: 241011 RVA: 0x010A1BDA File Offset: 0x0109FDDA
		public int PerfectSize { get; set; }

		// Token: 0x17006F1C RID: 28444
		// (get) Token: 0x0603AD74 RID: 241012 RVA: 0x010A1BE3 File Offset: 0x0109FDE3
		// (set) Token: 0x0603AD75 RID: 241013 RVA: 0x010A1BEB File Offset: 0x0109FDEB
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> PerfectAppearRate { get; set; }

		// Token: 0x17006F1D RID: 28445
		// (get) Token: 0x0603AD76 RID: 241014 RVA: 0x010A1BF4 File Offset: 0x0109FDF4
		// (set) Token: 0x0603AD77 RID: 241015 RVA: 0x010A1BFC File Offset: 0x0109FDFC
		public int PerfectScore { get; set; }

		// Token: 0x17006F1E RID: 28446
		// (get) Token: 0x0603AD78 RID: 241016 RVA: 0x010A1C05 File Offset: 0x0109FE05
		// (set) Token: 0x0603AD79 RID: 241017 RVA: 0x010A1C0D File Offset: 0x0109FE0D
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> CursorSpeed { get; set; }

		// Token: 0x17006F1F RID: 28447
		// (get) Token: 0x0603AD7A RID: 241018 RVA: 0x010A1C16 File Offset: 0x0109FE16
		// (set) Token: 0x0603AD7B RID: 241019 RVA: 0x010A1C1E File Offset: 0x0109FE1E
		public int HitColdTime { get; set; }

		// Token: 0x17006F20 RID: 28448
		// (get) Token: 0x0603AD7C RID: 241020 RVA: 0x010A1C27 File Offset: 0x0109FE27
		// (set) Token: 0x0603AD7D RID: 241021 RVA: 0x010A1C2F File Offset: 0x0109FE2F
		public int ScoreUp { get; set; }

		// Token: 0x17006F21 RID: 28449
		// (get) Token: 0x0603AD7E RID: 241022 RVA: 0x010A1C38 File Offset: 0x0109FE38
		// (set) Token: 0x0603AD7F RID: 241023 RVA: 0x010A1C40 File Offset: 0x0109FE40
		public int MultiBoxGroup { get; set; }

		// Token: 0x17006F22 RID: 28450
		// (get) Token: 0x0603AD80 RID: 241024 RVA: 0x010A1C49 File Offset: 0x0109FE49
		// (set) Token: 0x0603AD81 RID: 241025 RVA: 0x010A1C51 File Offset: 0x0109FE51
		public List<float> HiddenInterval { get; set; }

		// Token: 0x17006F23 RID: 28451
		// (get) Token: 0x0603AD82 RID: 241026 RVA: 0x010A1C5A File Offset: 0x0109FE5A
		// (set) Token: 0x0603AD83 RID: 241027 RVA: 0x010A1C62 File Offset: 0x0109FE62
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> RouletteRotateSpeed { get; set; }

		// Token: 0x17006F24 RID: 28452
		// (get) Token: 0x0603AD84 RID: 241028 RVA: 0x010A1C6B File Offset: 0x0109FE6B
		// (set) Token: 0x0603AD85 RID: 241029 RVA: 0x010A1C73 File Offset: 0x0109FE73
		public int MistakeScore { get; set; }

		// Token: 0x17006F25 RID: 28453
		// (get) Token: 0x0603AD86 RID: 241030 RVA: 0x010A1C7C File Offset: 0x0109FE7C
		// (set) Token: 0x0603AD87 RID: 241031 RVA: 0x010A1C84 File Offset: 0x0109FE84
		public bool IsAnticlockwise { get; set; }

		// Token: 0x17006F26 RID: 28454
		// (get) Token: 0x0603AD88 RID: 241032 RVA: 0x010A1C8D File Offset: 0x0109FE8D
		// (set) Token: 0x0603AD89 RID: 241033 RVA: 0x010A1C95 File Offset: 0x0109FE95
		public string Comment { get; set; }

		// Token: 0x17006F27 RID: 28455
		// (get) Token: 0x0603AD8A RID: 241034 RVA: 0x010A1C9E File Offset: 0x0109FE9E
		// (set) Token: 0x0603AD8B RID: 241035 RVA: 0x010A1CA6 File Offset: 0x0109FEA6
		public int RefreshType { get; set; }
	}
}
