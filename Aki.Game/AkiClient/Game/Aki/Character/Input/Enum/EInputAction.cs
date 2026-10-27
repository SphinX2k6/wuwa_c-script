using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x02004260 RID: 16992
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputAction.EInputAction")]
	public enum EInputAction : byte
	{
		// Token: 0x0401701E RID: 94238
		None,
		// Token: 0x0401701F RID: 94239
		跳跃,
		// Token: 0x04017020 RID: 94240
		攀爬,
		// Token: 0x04017021 RID: 94241
		走跑切换,
		// Token: 0x04017022 RID: 94242
		攻击,
		// Token: 0x04017023 RID: 94243
		闪避,
		// Token: 0x04017024 RID: 94244
		技能1,
		// Token: 0x04017025 RID: 94245
		幻象1,
		// Token: 0x04017026 RID: 94246
		大招,
		// Token: 0x04017027 RID: 94247
		幻象2,
		// Token: 0x04017028 RID: 94248
		切换角色1,
		// Token: 0x04017029 RID: 94249
		切换角色2,
		// Token: 0x0401702A RID: 94250
		切换角色3,
		// Token: 0x0401702B RID: 94251
		锁定目标,
		// Token: 0x0401702C RID: 94252
		瞄准,
		// Token: 0x0401702D RID: 94253
		通用交互,
		// Token: 0x0401702E RID: 94254
		下降,
		// Token: 0x0401702F RID: 94255
		移动输入按键事件,
		// Token: 0x04017030 RID: 94256
		EInputAction_MAX
	}
}
