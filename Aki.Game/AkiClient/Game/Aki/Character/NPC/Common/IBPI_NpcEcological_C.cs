using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x0200419E RID: 16798
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/BPI_NpcEcological.BPI_NpcEcological_C")]
	public interface IBPI_NpcEcological_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602BAD9 RID: 178905 RVA: 0x00A0727D File Offset: 0x00A0547D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADA RID: 178906 RVA: 0x00A07291 File Offset: 0x00A05491
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerAttack()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerAttack_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADB RID: 178907 RVA: 0x00A072A5 File Offset: 0x00A054A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerImpactEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerImpactEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADC RID: 178908 RVA: 0x00A072B9 File Offset: 0x00A054B9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerImpact()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerImpact_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADD RID: 178909 RVA: 0x00A072CD File Offset: 0x00A054CD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerExit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerExit_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADE RID: 178910 RVA: 0x00A072E1 File Offset: 0x00A054E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandlePlayerEnter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerEnter_NativeFunctionPtr, null);
		}

		// Token: 0x0602BADF RID: 178911 RVA: 0x00A072F5 File Offset: 0x00A054F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandleQuestChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleQuestChanged_NativeFunctionPtr, null);
		}

		// Token: 0x0602BAE0 RID: 178912 RVA: 0x00A07309 File Offset: 0x00A05509
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandleDayStateChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleDayStateChanged_NativeFunctionPtr, null);
		}

		// Token: 0x0602BAE1 RID: 178913 RVA: 0x00A0731D File Offset: 0x00A0551D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void HandleWeatherChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleWeatherChanged_NativeFunctionPtr, null);
		}

		// Token: 0x04016BFE RID: 93182
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/Common/BPI_NpcEcological.BPI_NpcEcological_C";
	}
}
