using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x020031AE RID: 12718
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/ESimpleNpcFlowCheckType.ESimpleNpcFlowCheckType")]
	public enum ESimpleNpcFlowCheckType : byte
	{
		// Token: 0x04010D5F RID: 68959
		无,
		// Token: 0x04010D60 RID: 68960
		下雨,
		// Token: 0x04010D61 RID: 68961
		打雷,
		// Token: 0x04010D62 RID: 68962
		清晨,
		// Token: 0x04010D63 RID: 68963
		上午,
		// Token: 0x04010D64 RID: 68964
		下午,
		// Token: 0x04010D65 RID: 68965
		晚上,
		// Token: 0x04010D66 RID: 68966
		任务进行中,
		// Token: 0x04010D67 RID: 68967
		任务完成,
		// Token: 0x04010D68 RID: 68968
		上线第一次靠近,
		// Token: 0x04010D69 RID: 68969
		ESimpleNpcFlowCheckType_MAX
	}
}
