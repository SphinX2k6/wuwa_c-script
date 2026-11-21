using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Qte
{
	// Token: 0x0200318F RID: 12687
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Qte/ECommonQteInputAction.ECommonQteInputAction")]
	public enum ECommonQteInputAction : byte
	{
		// Token: 0x04010C00 RID: 68608
		无,
		// Token: 0x04010C01 RID: 68609
		跳跃,
		// Token: 0x04010C02 RID: 68610
		攀爬,
		// Token: 0x04010C03 RID: 68611
		走跑切换,
		// Token: 0x04010C04 RID: 68612
		攻击,
		// Token: 0x04010C05 RID: 68613
		闪避,
		// Token: 0x04010C06 RID: 68614
		技能1,
		// Token: 0x04010C07 RID: 68615
		幻象1,
		// Token: 0x04010C08 RID: 68616
		大招,
		// Token: 0x04010C09 RID: 68617
		幻象2,
		// Token: 0x04010C0A RID: 68618
		切换角色1,
		// Token: 0x04010C0B RID: 68619
		切换角色2,
		// Token: 0x04010C0C RID: 68620
		切换角色3,
		// Token: 0x04010C0D RID: 68621
		锁定目标,
		// Token: 0x04010C0E RID: 68622
		瞄准,
		// Token: 0x04010C0F RID: 68623
		通用交互,
		// Token: 0x04010C10 RID: 68624
		向前移动,
		// Token: 0x04010C11 RID: 68625
		向后移动,
		// Token: 0x04010C12 RID: 68626
		向左移动,
		// Token: 0x04010C13 RID: 68627
		向右移动,
		// Token: 0x04010C14 RID: 68628
		QTE选项1,
		// Token: 0x04010C15 RID: 68629
		QTE选项2,
		// Token: 0x04010C16 RID: 68630
		QTE选项3,
		// Token: 0x04010C17 RID: 68631
		QTE选项4,
		// Token: 0x04010C18 RID: 68632
		QTE方向上,
		// Token: 0x04010C19 RID: 68633
		QTE方向下,
		// Token: 0x04010C1A RID: 68634
		QTE方向左,
		// Token: 0x04010C1B RID: 68635
		QTE方向右,
		// Token: 0x04010C1C RID: 68636
		QTE分体选项1_左,
		// Token: 0x04010C1D RID: 68637
		QTE分体选项2_右,
		// Token: 0x04010C1E RID: 68638
		QTE_R2攻击,
		// Token: 0x04010C1F RID: 68639
		交互动态漫_向上拖动,
		// Token: 0x04010C20 RID: 68640
		交互动态漫_转动,
		// Token: 0x04010C21 RID: 68641
		交互动态漫_点击,
		// Token: 0x04010C22 RID: 68642
		交互动态漫_长按,
		// Token: 0x04010C23 RID: 68643
		QTE_空格A,
		// Token: 0x04010C24 RID: 68644
		交互动态漫_向下拖动,
		// Token: 0x04010C25 RID: 68645
		载具漂移,
		// Token: 0x04010C26 RID: 68646
		载具子弹跳,
		// Token: 0x04010C27 RID: 68647
		载具退场技和下车,
		// Token: 0x04010C28 RID: 68648
		载具探索工具,
		// Token: 0x04010C29 RID: 68649
		载具氮气,
		// Token: 0x04010C2A RID: 68650
		ECommonQteInputAction_MAX
	}
}
