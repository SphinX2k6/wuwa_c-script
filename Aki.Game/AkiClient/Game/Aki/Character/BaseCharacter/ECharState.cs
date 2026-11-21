using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032FD RID: 13053
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECharState.ECharState")]
	public enum ECharState : byte
	{
		// Token: 0x0401200D RID: 73741
		其他,
		// Token: 0x0401200E RID: 73742
		站立,
		// Token: 0x0401200F RID: 73743
		行走,
		// Token: 0x04012010 RID: 73744
		行走停止,
		// Token: 0x04012011 RID: 73745
		跑步,
		// Token: 0x04012012 RID: 73746
		跑步停止,
		// Token: 0x04012013 RID: 73747
		冲刺,
		// Token: 0x04012014 RID: 73748
		冲刺停止,
		// Token: 0x04012015 RID: 73749
		闪避,
		// Token: 0x04012016 RID: 73750
		弹反,
		// Token: 0x04012017 RID: 73751
		落地翻滚,
		// Token: 0x04012018 RID: 73752
		击倒,
		// Token: 0x04012019 RID: 73753
		轻击,
		// Token: 0x0401201A RID: 73754
		重击,
		// Token: 0x0401201B RID: 73755
		正常攀爬,
		// Token: 0x0401201C RID: 73756
		快速攀爬,
		// Token: 0x0401201D RID: 73757
		滑翔,
		// Token: 0x0401201E RID: 73758
		击飞,
		// Token: 0x0401201F RID: 73759
		加速游泳,
		// Token: 0x04012020 RID: 73760
		正常游泳,
		// Token: 0x04012021 RID: 73761
		摇荡,
		// Token: 0x04012022 RID: 73762
		被抓取,
		// Token: 0x04012023 RID: 73763
		滑坡,
		// Token: 0x04012024 RID: 73764
		特殊飞行,
		// Token: 0x04012025 RID: 73765
		进入攀爬,
		// Token: 0x04012026 RID: 73766
		退出攀爬,
		// Token: 0x04012027 RID: 73767
		普通滑雪,
		// Token: 0x04012028 RID: 73768
		受击倒地起身,
		// Token: 0x04012029 RID: 73769
		翱翔,
		// Token: 0x0401202A RID: 73770
		ECharState_MAX
	}
}
