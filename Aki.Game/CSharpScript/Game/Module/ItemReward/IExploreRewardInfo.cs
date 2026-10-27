using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057BA RID: 22458
	[NullableContext(2)]
	public interface IExploreRewardInfo : IRewardInfo
	{
		// Token: 0x17008954 RID: 35156
		// (get) Token: 0x060391A9 RID: 233897
		// (set) Token: 0x060391AA RID: 233898
		ERewardInfoType Type { get; set; }

		// Token: 0x17008955 RID: 35157
		// (get) Token: 0x060391AB RID: 233899
		// (set) Token: 0x060391AC RID: 233900
		bool IsSuccess { get; set; }

		// Token: 0x17008956 RID: 35158
		// (get) Token: 0x060391AD RID: 233901
		// (set) Token: 0x060391AE RID: 233902
		string Title { get; set; }

		// Token: 0x17008957 RID: 35159
		// (get) Token: 0x060391AF RID: 233903
		// (set) Token: 0x060391B0 RID: 233904
		string TitleHexColor { get; set; }

		// Token: 0x17008958 RID: 35160
		// (get) Token: 0x060391B1 RID: 233905
		// (set) Token: 0x060391B2 RID: 233906
		string TitleIconPath { get; set; }

		// Token: 0x17008959 RID: 35161
		// (get) Token: 0x060391B3 RID: 233907
		// (set) Token: 0x060391B4 RID: 233908
		string TitleIconHexColor { get; set; }

		// Token: 0x1700895A RID: 35162
		// (get) Token: 0x060391B5 RID: 233909
		// (set) Token: 0x060391B6 RID: 233910
		bool IsRecordVisible { get; set; }

		// Token: 0x1700895B RID: 35163
		// (get) Token: 0x060391B7 RID: 233911
		// (set) Token: 0x060391B8 RID: 233912
		bool IsItemVisible { get; set; }

		// Token: 0x1700895C RID: 35164
		// (get) Token: 0x060391B9 RID: 233913
		// (set) Token: 0x060391BA RID: 233914
		bool IsExploreProgressVisible { get; set; }

		// Token: 0x1700895D RID: 35165
		// (get) Token: 0x060391BB RID: 233915
		// (set) Token: 0x060391BC RID: 233916
		string ExploreBarTipsTextId { get; set; }

		// Token: 0x1700895E RID: 35166
		// (get) Token: 0x060391BD RID: 233917
		// (set) Token: 0x060391BE RID: 233918
		bool IsDescription { get; set; }

		// Token: 0x1700895F RID: 35167
		// (get) Token: 0x060391BF RID: 233919
		// (set) Token: 0x060391C0 RID: 233920
		string Description { get; set; }

		// Token: 0x17008960 RID: 35168
		// (get) Token: 0x060391C1 RID: 233921
		// (set) Token: 0x060391C2 RID: 233922
		bool? IsShowOnlineChallengePlayer { get; set; }

		// Token: 0x17008961 RID: 35169
		// (get) Token: 0x060391C3 RID: 233923
		// (set) Token: 0x060391C4 RID: 233924
		string Tip { get; set; }

		// Token: 0x17008962 RID: 35170
		// (get) Token: 0x060391C5 RID: 233925
		// (set) Token: 0x060391C6 RID: 233926
		bool? IsRewardMultiLine { get; set; }

		// Token: 0x17008963 RID: 35171
		// (get) Token: 0x060391C7 RID: 233927
		// (set) Token: 0x060391C8 RID: 233928
		Action OnCloseCallback { get; set; }

		// Token: 0x17008964 RID: 35172
		// (get) Token: 0x060391C9 RID: 233929
		// (set) Token: 0x060391CA RID: 233930
		bool? IsBagFull { get; set; }
	}
}
