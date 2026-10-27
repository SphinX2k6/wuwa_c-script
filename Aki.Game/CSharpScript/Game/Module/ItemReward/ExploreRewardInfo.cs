using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BB RID: 22459
	[NullableContext(2)]
	[Nullable(0)]
	public class ExploreRewardInfo : RewardInfo, IExploreRewardInfo, IRewardInfo
	{
		// Token: 0x17008965 RID: 35173
		// (get) Token: 0x060391CB RID: 233931 RVA: 0x00D8FDD7 File Offset: 0x00D8DFD7
		// (set) Token: 0x060391CC RID: 233932 RVA: 0x00D8FDDF File Offset: 0x00D8DFDF
		public new ERewardInfoType Type { get; set; } = ERewardInfoType.Explore;

		// Token: 0x17008966 RID: 35174
		// (get) Token: 0x060391CD RID: 233933 RVA: 0x00D8FDE8 File Offset: 0x00D8DFE8
		// (set) Token: 0x060391CE RID: 233934 RVA: 0x00D8FDF0 File Offset: 0x00D8DFF0
		public bool IsSuccess { get; set; }

		// Token: 0x17008967 RID: 35175
		// (get) Token: 0x060391CF RID: 233935 RVA: 0x00D8FDF9 File Offset: 0x00D8DFF9
		// (set) Token: 0x060391D0 RID: 233936 RVA: 0x00D8FE01 File Offset: 0x00D8E001
		public string Title { get; set; }

		// Token: 0x17008968 RID: 35176
		// (get) Token: 0x060391D1 RID: 233937 RVA: 0x00D8FE0A File Offset: 0x00D8E00A
		// (set) Token: 0x060391D2 RID: 233938 RVA: 0x00D8FE12 File Offset: 0x00D8E012
		public string TitleHexColor { get; set; }

		// Token: 0x17008969 RID: 35177
		// (get) Token: 0x060391D3 RID: 233939 RVA: 0x00D8FE1B File Offset: 0x00D8E01B
		// (set) Token: 0x060391D4 RID: 233940 RVA: 0x00D8FE23 File Offset: 0x00D8E023
		public string TitleIconPath { get; set; }

		// Token: 0x1700896A RID: 35178
		// (get) Token: 0x060391D5 RID: 233941 RVA: 0x00D8FE2C File Offset: 0x00D8E02C
		// (set) Token: 0x060391D6 RID: 233942 RVA: 0x00D8FE34 File Offset: 0x00D8E034
		public string TitleIconHexColor { get; set; }

		// Token: 0x1700896B RID: 35179
		// (get) Token: 0x060391D7 RID: 233943 RVA: 0x00D8FE3D File Offset: 0x00D8E03D
		// (set) Token: 0x060391D8 RID: 233944 RVA: 0x00D8FE45 File Offset: 0x00D8E045
		public bool IsRecordVisible { get; set; }

		// Token: 0x1700896C RID: 35180
		// (get) Token: 0x060391D9 RID: 233945 RVA: 0x00D8FE4E File Offset: 0x00D8E04E
		// (set) Token: 0x060391DA RID: 233946 RVA: 0x00D8FE56 File Offset: 0x00D8E056
		public bool IsItemVisible { get; set; }

		// Token: 0x1700896D RID: 35181
		// (get) Token: 0x060391DB RID: 233947 RVA: 0x00D8FE5F File Offset: 0x00D8E05F
		// (set) Token: 0x060391DC RID: 233948 RVA: 0x00D8FE67 File Offset: 0x00D8E067
		public bool IsExploreProgressVisible { get; set; }

		// Token: 0x1700896E RID: 35182
		// (get) Token: 0x060391DD RID: 233949 RVA: 0x00D8FE70 File Offset: 0x00D8E070
		// (set) Token: 0x060391DE RID: 233950 RVA: 0x00D8FE78 File Offset: 0x00D8E078
		public string ExploreBarTipsTextId { get; set; }

		// Token: 0x1700896F RID: 35183
		// (get) Token: 0x060391DF RID: 233951 RVA: 0x00D8FE81 File Offset: 0x00D8E081
		// (set) Token: 0x060391E0 RID: 233952 RVA: 0x00D8FE89 File Offset: 0x00D8E089
		public bool IsDescription { get; set; }

		// Token: 0x17008970 RID: 35184
		// (get) Token: 0x060391E1 RID: 233953 RVA: 0x00D8FE92 File Offset: 0x00D8E092
		// (set) Token: 0x060391E2 RID: 233954 RVA: 0x00D8FE9A File Offset: 0x00D8E09A
		public string Description { get; set; }

		// Token: 0x17008971 RID: 35185
		// (get) Token: 0x060391E3 RID: 233955 RVA: 0x00D8FEA3 File Offset: 0x00D8E0A3
		// (set) Token: 0x060391E4 RID: 233956 RVA: 0x00D8FEAB File Offset: 0x00D8E0AB
		public bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17008972 RID: 35186
		// (get) Token: 0x060391E5 RID: 233957 RVA: 0x00D8FEB4 File Offset: 0x00D8E0B4
		// (set) Token: 0x060391E6 RID: 233958 RVA: 0x00D8FEBC File Offset: 0x00D8E0BC
		public string Tip { get; set; }

		// Token: 0x17008973 RID: 35187
		// (get) Token: 0x060391E7 RID: 233959 RVA: 0x00D8FEC5 File Offset: 0x00D8E0C5
		// (set) Token: 0x060391E8 RID: 233960 RVA: 0x00D8FECD File Offset: 0x00D8E0CD
		public bool? IsRewardMultiLine { get; set; }

		// Token: 0x17008974 RID: 35188
		// (get) Token: 0x060391E9 RID: 233961 RVA: 0x00D8FED6 File Offset: 0x00D8E0D6
		// (set) Token: 0x060391EA RID: 233962 RVA: 0x00D8FEDE File Offset: 0x00D8E0DE
		public Action OnCloseCallback { get; set; }

		// Token: 0x17008975 RID: 35189
		// (get) Token: 0x060391EB RID: 233963 RVA: 0x00D8FEE7 File Offset: 0x00D8E0E7
		// (set) Token: 0x060391EC RID: 233964 RVA: 0x00D8FEEF File Offset: 0x00D8E0EF
		public bool? IsBagFull { get; set; }
	}
}
