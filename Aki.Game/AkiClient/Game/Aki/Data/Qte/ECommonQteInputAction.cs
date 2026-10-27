using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x02003ECA RID: 16074
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteInputAction.ECommonQteInputAction")]
	public enum ECommonQteInputAction : byte
	{
		// Token: 0x04014C1A RID: 85018
		无,
		// Token: 0x04014C1B RID: 85019
		跳跃,
		// Token: 0x04014C1C RID: 85020
		攀爬,
		// Token: 0x04014C1D RID: 85021
		走跑切换,
		// Token: 0x04014C1E RID: 85022
		攻击,
		// Token: 0x04014C1F RID: 85023
		闪避,
		// Token: 0x04014C20 RID: 85024
		技能1,
		// Token: 0x04014C21 RID: 85025
		幻象1,
		// Token: 0x04014C22 RID: 85026
		大招,
		// Token: 0x04014C23 RID: 85027
		幻象2,
		// Token: 0x04014C24 RID: 85028
		切换角色1,
		// Token: 0x04014C25 RID: 85029
		切换角色2,
		// Token: 0x04014C26 RID: 85030
		切换角色3,
		// Token: 0x04014C27 RID: 85031
		锁定目标,
		// Token: 0x04014C28 RID: 85032
		瞄准,
		// Token: 0x04014C29 RID: 85033
		通用交互,
		// Token: 0x04014C2A RID: 85034
		向前移动,
		// Token: 0x04014C2B RID: 85035
		向后移动,
		// Token: 0x04014C2C RID: 85036
		向左移动,
		// Token: 0x04014C2D RID: 85037
		向右移动,
		// Token: 0x04014C2E RID: 85038
		QTE选项1,
		// Token: 0x04014C2F RID: 85039
		QTE选项2,
		// Token: 0x04014C30 RID: 85040
		QTE选项3,
		// Token: 0x04014C31 RID: 85041
		QTE选项4,
		// Token: 0x04014C32 RID: 85042
		QTE方向上,
		// Token: 0x04014C33 RID: 85043
		QTE方向下,
		// Token: 0x04014C34 RID: 85044
		QTE方向左,
		// Token: 0x04014C35 RID: 85045
		QTE方向右,
		// Token: 0x04014C36 RID: 85046
		QTE分体选项1_左,
		// Token: 0x04014C37 RID: 85047
		QTE分体选项2_右,
		// Token: 0x04014C38 RID: 85048
		QTE_R2攻击,
		// Token: 0x04014C39 RID: 85049
		交互动态漫_向上拖动,
		// Token: 0x04014C3A RID: 85050
		交互动态漫_转动,
		// Token: 0x04014C3B RID: 85051
		交互动态漫_点击,
		// Token: 0x04014C3C RID: 85052
		交互动态漫_长按,
		// Token: 0x04014C3D RID: 85053
		QTE_空格A,
		// Token: 0x04014C3E RID: 85054
		交互动态漫_向下拖动,
		// Token: 0x04014C3F RID: 85055
		载具漂移,
		// Token: 0x04014C40 RID: 85056
		载具子弹跳,
		// Token: 0x04014C41 RID: 85057
		载具退场技和下车,
		// Token: 0x04014C42 RID: 85058
		载具探索工具,
		// Token: 0x04014C43 RID: 85059
		载具氮气,
		// Token: 0x04014C44 RID: 85060
		ECommonQteInputAction_MAX
	}
}
