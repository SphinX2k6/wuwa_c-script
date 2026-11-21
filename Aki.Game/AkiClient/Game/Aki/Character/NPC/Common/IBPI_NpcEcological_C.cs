using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Common
{
	// Token: 0x020032BB RID: 12987
	[UnrealObjectPath("/Game/Aki/Character/NPC/Common/BPI_NpcEcological.BPI_NpcEcological_C")]
	public interface IBPI_NpcEcological_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06020D8A RID: 134538 RVA: 0x00950947 File Offset: 0x0094EB47
		[SkipLocalsInit]
		void HandlePlayerAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020D8B RID: 134539 RVA: 0x0095095B File Offset: 0x0094EB5B
		[SkipLocalsInit]
		void HandlePlayerAttack()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerAttack_NativeFunctionPtr, null);
		}

		// Token: 0x06020D8C RID: 134540 RVA: 0x0095096F File Offset: 0x0094EB6F
		[SkipLocalsInit]
		void HandlePlayerImpactEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerImpactEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020D8D RID: 134541 RVA: 0x00950983 File Offset: 0x0094EB83
		[SkipLocalsInit]
		void HandlePlayerImpact()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerImpact_NativeFunctionPtr, null);
		}

		// Token: 0x06020D8E RID: 134542 RVA: 0x00950997 File Offset: 0x0094EB97
		[SkipLocalsInit]
		void HandlePlayerExit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerExit_NativeFunctionPtr, null);
		}

		// Token: 0x06020D8F RID: 134543 RVA: 0x009509AB File Offset: 0x0094EBAB
		[SkipLocalsInit]
		void HandlePlayerEnter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandlePlayerEnter_NativeFunctionPtr, null);
		}

		// Token: 0x06020D90 RID: 134544 RVA: 0x009509BF File Offset: 0x0094EBBF
		[SkipLocalsInit]
		void HandleQuestChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleQuestChanged_NativeFunctionPtr, null);
		}

		// Token: 0x06020D91 RID: 134545 RVA: 0x009509D3 File Offset: 0x0094EBD3
		[SkipLocalsInit]
		void HandleDayStateChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleDayStateChanged_NativeFunctionPtr, null);
		}

		// Token: 0x06020D92 RID: 134546 RVA: 0x009509E7 File Offset: 0x0094EBE7
		[SkipLocalsInit]
		void HandleWeatherChanged()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_NpcEcological_C_ReflectionImplementationFields.__HandleWeatherChanged_NativeFunctionPtr, null);
		}

		// Token: 0x04011C63 RID: 72803
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/Common/BPI_NpcEcological.BPI_NpcEcological_C";
	}
}
