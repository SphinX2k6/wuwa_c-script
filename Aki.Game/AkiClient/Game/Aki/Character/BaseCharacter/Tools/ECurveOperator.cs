using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004344 RID: 17220
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/ECurveOperator.ECurveOperator")]
	public enum ECurveOperator : byte
	{
		// Token: 0x040178AD RID: 96429
		ShowPosIn3Curves,
		// Token: 0x040178AE RID: 96430
		Remove3Curves,
		// Token: 0x040178AF RID: 96431
		RemoveAll,
		// Token: 0x040178B0 RID: 96432
		ECurveOperator_MAX
	}
}
