using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004275 RID: 17013
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BPI_CharacterAnimation.BPI_CharacterAnimation_C")]
	public interface IBPI_CharacterAnimation_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602C208 RID: 180744 RVA: 0x00A1702B File Offset: 0x00A1522B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void BPI_Jumped()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_CharacterAnimation_C_ReflectionImplementationFields.__BPI_Jumped_NativeFunctionPtr, null);
		}

		// Token: 0x04017164 RID: 94564
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BPI_CharacterAnimation.BPI_CharacterAnimation_C";
	}
}
