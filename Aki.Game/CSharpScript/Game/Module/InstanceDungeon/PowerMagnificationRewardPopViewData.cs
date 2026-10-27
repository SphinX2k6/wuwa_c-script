using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005888 RID: 22664
	[NullableContext(2)]
	[Nullable(0)]
	public class PowerMagnificationRewardPopViewData
	{
		// Token: 0x17008A7E RID: 35454
		// (get) Token: 0x06039AD2 RID: 236242 RVA: 0x00DB56C7 File Offset: 0x00DB38C7
		// (set) Token: 0x06039AD3 RID: 236243 RVA: 0x00DB56CF File Offset: 0x00DB38CF
		public int SinglePowerCost { get; set; }

		// Token: 0x17008A7F RID: 35455
		// (get) Token: 0x06039AD4 RID: 236244 RVA: 0x00DB56D8 File Offset: 0x00DB38D8
		// (set) Token: 0x06039AD5 RID: 236245 RVA: 0x00DB56E0 File Offset: 0x00DB38E0
		[Nullable(1)]
		public Action<int> RewardCallBack { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008A80 RID: 35456
		// (get) Token: 0x06039AD6 RID: 236246 RVA: 0x00DB56E9 File Offset: 0x00DB38E9
		// (set) Token: 0x06039AD7 RID: 236247 RVA: 0x00DB56F1 File Offset: 0x00DB38F1
		public Action CloseCallBack { get; set; }

		// Token: 0x17008A81 RID: 35457
		// (get) Token: 0x06039AD8 RID: 236248 RVA: 0x00DB56FA File Offset: 0x00DB38FA
		// (set) Token: 0x06039AD9 RID: 236249 RVA: 0x00DB5702 File Offset: 0x00DB3902
		public bool? NeedResetLevelPlayModelRewardFlag { get; set; }

		// Token: 0x17008A82 RID: 35458
		// (get) Token: 0x06039ADA RID: 236250 RVA: 0x00DB570B File Offset: 0x00DB390B
		// (set) Token: 0x06039ADB RID: 236251 RVA: 0x00DB5713 File Offset: 0x00DB3913
		public string Tip { get; set; }
	}
}
