using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon
{
	// Token: 0x0200443E RID: 17470
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/EInteractionItemType.EInteractionItemType")]
	public enum EInteractionItemType : byte
	{
		// Token: 0x040180DD RID: 98525
		主目标,
		// Token: 0x040180DE RID: 98526
		椅子,
		// Token: 0x040180DF RID: 98527
		信息板,
		// Token: 0x040180E0 RID: 98528
		桌子,
		// Token: 0x040180E1 RID: 98529
		垃圾桶,
		// Token: 0x040180E2 RID: 98530
		自动贩售机,
		// Token: 0x040180E3 RID: 98531
		坏掉的车,
		// Token: 0x040180E4 RID: 98532
		能交谈的人01,
		// Token: 0x040180E5 RID: 98533
		能交谈的人02,
		// Token: 0x040180E6 RID: 98534
		能交谈的人03,
		// Token: 0x040180E7 RID: 98535
		能交谈的人04,
		// Token: 0x040180E8 RID: 98536
		EInteractionItemType_MAX
	}
}
