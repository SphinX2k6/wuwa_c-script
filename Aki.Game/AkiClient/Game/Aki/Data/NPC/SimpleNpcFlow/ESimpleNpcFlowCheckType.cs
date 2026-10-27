using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow
{
	// Token: 0x02003EED RID: 16109
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/NPC/SimpleNpcFlow/ESimpleNpcFlowCheckType.ESimpleNpcFlowCheckType")]
	public enum ESimpleNpcFlowCheckType : byte
	{
		// Token: 0x04014DA6 RID: 85414
		无,
		// Token: 0x04014DA7 RID: 85415
		下雨,
		// Token: 0x04014DA8 RID: 85416
		打雷,
		// Token: 0x04014DA9 RID: 85417
		清晨,
		// Token: 0x04014DAA RID: 85418
		上午,
		// Token: 0x04014DAB RID: 85419
		下午,
		// Token: 0x04014DAC RID: 85420
		晚上,
		// Token: 0x04014DAD RID: 85421
		任务进行中,
		// Token: 0x04014DAE RID: 85422
		任务完成,
		// Token: 0x04014DAF RID: 85423
		上线第一次靠近,
		// Token: 0x04014DB0 RID: 85424
		ESimpleNpcFlowCheckType_MAX
	}
}
