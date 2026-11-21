using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Input.Enum
{
	// Token: 0x020032D2 RID: 13010
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Input/Enum/EInputAction.EInputAction")]
	public enum EInputAction : byte
	{
		// Token: 0x04011DBC RID: 73148
		None,
		// Token: 0x04011DBD RID: 73149
		跳跃,
		// Token: 0x04011DBE RID: 73150
		攀爬,
		// Token: 0x04011DBF RID: 73151
		走跑切换,
		// Token: 0x04011DC0 RID: 73152
		攻击,
		// Token: 0x04011DC1 RID: 73153
		闪避,
		// Token: 0x04011DC2 RID: 73154
		技能1,
		// Token: 0x04011DC3 RID: 73155
		幻象1,
		// Token: 0x04011DC4 RID: 73156
		大招,
		// Token: 0x04011DC5 RID: 73157
		幻象2,
		// Token: 0x04011DC6 RID: 73158
		切换角色1,
		// Token: 0x04011DC7 RID: 73159
		切换角色2,
		// Token: 0x04011DC8 RID: 73160
		切换角色3,
		// Token: 0x04011DC9 RID: 73161
		锁定目标,
		// Token: 0x04011DCA RID: 73162
		瞄准,
		// Token: 0x04011DCB RID: 73163
		通用交互,
		// Token: 0x04011DCC RID: 73164
		下降,
		// Token: 0x04011DCD RID: 73165
		移动输入按键事件,
		// Token: 0x04011DCE RID: 73166
		EInputAction_MAX
	}
}
