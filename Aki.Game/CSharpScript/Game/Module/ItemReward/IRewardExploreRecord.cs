using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A7 RID: 18343
	[NullableContext(1)]
	public interface IRewardExploreRecord
	{
		// Token: 0x17005D7C RID: 23932
		// (get) Token: 0x0602E184 RID: 188804
		// (set) Token: 0x0602E185 RID: 188805
		string TitleTextId { get; set; }

		// Token: 0x17005D7D RID: 23933
		// (get) Token: 0x0602E186 RID: 188806
		// (set) Token: 0x0602E187 RID: 188807
		string Record { get; set; }

		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x0602E188 RID: 188808
		// (set) Token: 0x0602E189 RID: 188809
		int? RecordRollingTo { get; set; }

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x0602E18A RID: 188810
		// (set) Token: 0x0602E18B RID: 188811
		bool IsNewRecord { get; set; }
	}
}
