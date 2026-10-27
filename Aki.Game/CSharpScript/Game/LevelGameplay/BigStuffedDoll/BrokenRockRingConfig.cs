using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F49 RID: 28489
	[NullableContext(1)]
	[Nullable(0)]
	public class BrokenRockRingConfig : IBrokenRockRingConfig
	{
		// Token: 0x17009B4A RID: 39754
		// (get) Token: 0x060454DD RID: 283869 RVA: 0x01125E36 File Offset: 0x01124036
		// (set) Token: 0x060454DE RID: 283870 RVA: 0x01125E3E File Offset: 0x0112403E
		public int Id { get; set; }

		// Token: 0x17009B4B RID: 39755
		// (get) Token: 0x060454DF RID: 283871 RVA: 0x01125E47 File Offset: 0x01124047
		// (set) Token: 0x060454E0 RID: 283872 RVA: 0x01125E4F File Offset: 0x0112404F
		public List<List<int>> InvalidBox { get; set; }

		// Token: 0x17009B4C RID: 39756
		// (get) Token: 0x060454E1 RID: 283873 RVA: 0x01125E58 File Offset: 0x01124058
		// (set) Token: 0x060454E2 RID: 283874 RVA: 0x01125E60 File Offset: 0x01124060
		public int[] RandomBox { get; set; }

		// Token: 0x17009B4D RID: 39757
		// (get) Token: 0x060454E3 RID: 283875 RVA: 0x01125E69 File Offset: 0x01124069
		// (set) Token: 0x060454E4 RID: 283876 RVA: 0x01125E71 File Offset: 0x01124071
		public int PerfectBox { get; set; }

		// Token: 0x17009B4E RID: 39758
		// (get) Token: 0x060454E5 RID: 283877 RVA: 0x01125E7A File Offset: 0x0112407A
		// (set) Token: 0x060454E6 RID: 283878 RVA: 0x01125E82 File Offset: 0x01124082
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> BonusRate { get; set; }

		// Token: 0x17009B4F RID: 39759
		// (get) Token: 0x060454E7 RID: 283879 RVA: 0x01125E8B File Offset: 0x0112408B
		// (set) Token: 0x060454E8 RID: 283880 RVA: 0x01125E93 File Offset: 0x01124093
		public int GoodScore { get; set; }

		// Token: 0x17009B50 RID: 39760
		// (get) Token: 0x060454E9 RID: 283881 RVA: 0x01125E9C File Offset: 0x0112409C
		// (set) Token: 0x060454EA RID: 283882 RVA: 0x01125EA4 File Offset: 0x011240A4
		public int PerfectScore { get; set; }

		// Token: 0x17009B51 RID: 39761
		// (get) Token: 0x060454EB RID: 283883 RVA: 0x01125EAD File Offset: 0x011240AD
		// (set) Token: 0x060454EC RID: 283884 RVA: 0x01125EB5 File Offset: 0x011240B5
		public int BonusScore { get; set; }

		// Token: 0x17009B52 RID: 39762
		// (get) Token: 0x060454ED RID: 283885 RVA: 0x01125EBE File Offset: 0x011240BE
		// (set) Token: 0x060454EE RID: 283886 RVA: 0x01125EC6 File Offset: 0x011240C6
		[JsonConverter(typeof(IntMapStringConverter))]
		public Dictionary<int, int> Speed { get; set; }

		// Token: 0x17009B53 RID: 39763
		// (get) Token: 0x060454EF RID: 283887 RVA: 0x01125ECF File Offset: 0x011240CF
		// (set) Token: 0x060454F0 RID: 283888 RVA: 0x01125ED7 File Offset: 0x011240D7
		public int ColdTime { get; set; }

		// Token: 0x17009B54 RID: 39764
		// (get) Token: 0x060454F1 RID: 283889 RVA: 0x01125EE0 File Offset: 0x011240E0
		// (set) Token: 0x060454F2 RID: 283890 RVA: 0x01125EE8 File Offset: 0x011240E8
		public int MultiBoxGroup { get; set; }

		// Token: 0x17009B55 RID: 39765
		// (get) Token: 0x060454F3 RID: 283891 RVA: 0x01125EF1 File Offset: 0x011240F1
		// (set) Token: 0x060454F4 RID: 283892 RVA: 0x01125EF9 File Offset: 0x011240F9
		public int[] Offset { get; set; }

		// Token: 0x17009B56 RID: 39766
		// (get) Token: 0x060454F5 RID: 283893 RVA: 0x01125F02 File Offset: 0x01124102
		// (set) Token: 0x060454F6 RID: 283894 RVA: 0x01125F0A File Offset: 0x0112410A
		public bool IsAnticlockwise { get; set; }
	}
}
