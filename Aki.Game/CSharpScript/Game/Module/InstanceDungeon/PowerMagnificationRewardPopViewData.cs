using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004860 RID: 18528
	[NullableContext(2)]
	[Nullable(0)]
	public class PowerMagnificationRewardPopViewData
	{
		// Token: 0x17005E4A RID: 24138
		// (get) Token: 0x0602E9F5 RID: 190965 RVA: 0x00D045DF File Offset: 0x00D027DF
		// (set) Token: 0x0602E9F6 RID: 190966 RVA: 0x00D045E7 File Offset: 0x00D027E7
		public int SinglePowerCost { get; set; }

		// Token: 0x17005E4B RID: 24139
		// (get) Token: 0x0602E9F7 RID: 190967 RVA: 0x00D045F0 File Offset: 0x00D027F0
		// (set) Token: 0x0602E9F8 RID: 190968 RVA: 0x00D045F8 File Offset: 0x00D027F8
		[Nullable(1)]
		public Action<int> RewardCallBack { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x0602E9F9 RID: 190969 RVA: 0x00D04601 File Offset: 0x00D02801
		// (set) Token: 0x0602E9FA RID: 190970 RVA: 0x00D04609 File Offset: 0x00D02809
		public Action CloseCallBack { get; set; }

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x0602E9FB RID: 190971 RVA: 0x00D04612 File Offset: 0x00D02812
		// (set) Token: 0x0602E9FC RID: 190972 RVA: 0x00D0461A File Offset: 0x00D0281A
		public bool? NeedResetLevelPlayModelRewardFlag { get; set; }

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x0602E9FD RID: 190973 RVA: 0x00D04623 File Offset: 0x00D02823
		// (set) Token: 0x0602E9FE RID: 190974 RVA: 0x00D0462B File Offset: 0x00D0282B
		public string Tip { get; set; }
	}
}
