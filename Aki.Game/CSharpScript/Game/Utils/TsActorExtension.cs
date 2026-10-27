using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004557 RID: 17751
	[NullableContext(2)]
	[Nullable(0)]
	public static class TsActorExtension
	{
		// Token: 0x0602DDB2 RID: 187826 RVA: 0x00A8BF84 File Offset: 0x00A8A184
		public static Entity GetEntityNoBlueprint(this ABaseCharacter a)
		{
			TsBaseCharacter tsBaseCharacter = a as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				return tsBaseCharacter.GetEntityNoBlueprint();
			}
			TsBaseVehicle tsBaseVehicle = a as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				return tsBaseVehicle.GetEntityNoBlueprint();
			}
			return null;
		}

		// Token: 0x0602DDB3 RID: 187827 RVA: 0x00A8BFB4 File Offset: 0x00A8A1B4
		public static void SetDitherEffect(this ABaseCharacter a, float dither, ECharacterDitherType ditherType = ECharacterDitherType.Temporary)
		{
			TsBaseCharacter tsBaseCharacter = a as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				tsBaseCharacter.SetDitherEffect(dither, ditherType);
				return;
			}
			TsBaseVehicle tsBaseVehicle = a as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				tsBaseVehicle.SetDitherEffect(dither, ditherType);
			}
		}
	}
}
