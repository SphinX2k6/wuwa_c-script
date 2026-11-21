using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020032C0 RID: 12992
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/BPI_AnimalEcological.BPI_AnimalEcological_C")]
	public interface IBPI_AnimalEcological_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06020E80 RID: 134784 RVA: 0x00952263 File Offset: 0x00950463
		[SkipLocalsInit]
		void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E81 RID: 134785 RVA: 0x00952277 File Offset: 0x00950477
		[SkipLocalsInit]
		void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E82 RID: 134786 RVA: 0x0095228C File Offset: 0x0095048C
		[SkipLocalsInit]
		unsafe void FeedStart(FGameplayTag GameplayTag)
		{
			IBPI_AnimalEcological_C.__FeedStart_FunctionParams* ptr = stackalloc IBPI_AnimalEcological_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_AnimalEcological_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_AnimalEcological_C_ReflectionImplementationFields.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020E83 RID: 134787 RVA: 0x009522D4 File Offset: 0x009504D4
		[SkipLocalsInit]
		unsafe void GetCurrentActionTime(ref float ActionTime)
		{
			IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_AnimalEcological_C_ReflectionImplementationFields.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x06020E84 RID: 134788 RVA: 0x00952323 File Offset: 0x00950523
		[SkipLocalsInit]
		void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E85 RID: 134789 RVA: 0x00952337 File Offset: 0x00950537
		[SkipLocalsInit]
		void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E86 RID: 134790 RVA: 0x0095234B File Offset: 0x0095054B
		[SkipLocalsInit]
		void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x06020E87 RID: 134791 RVA: 0x0095235F File Offset: 0x0095055F
		[SkipLocalsInit]
		void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E88 RID: 134792 RVA: 0x00952373 File Offset: 0x00950573
		[SkipLocalsInit]
		void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E89 RID: 134793 RVA: 0x00952387 File Offset: 0x00950587
		[SkipLocalsInit]
		void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8A RID: 134794 RVA: 0x0095239B File Offset: 0x0095059B
		[SkipLocalsInit]
		void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8B RID: 134795 RVA: 0x009523AF File Offset: 0x009505AF
		[SkipLocalsInit]
		void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8C RID: 134796 RVA: 0x009523C3 File Offset: 0x009505C3
		[SkipLocalsInit]
		void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8D RID: 134797 RVA: 0x009523D7 File Offset: 0x009505D7
		[SkipLocalsInit]
		void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8E RID: 134798 RVA: 0x009523EB File Offset: 0x009505EB
		[SkipLocalsInit]
		void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020E8F RID: 134799 RVA: 0x009523FF File Offset: 0x009505FF
		[SkipLocalsInit]
		void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x06020E90 RID: 134800 RVA: 0x00952413 File Offset: 0x00950613
		[SkipLocalsInit]
		void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x04011D14 RID: 72980
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/BPI_AnimalEcological.BPI_AnimalEcological_C";

		// Token: 0x02008FE7 RID: 36839
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x0402CD96 RID: 183702
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x02008FE8 RID: 36840
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x0402CD97 RID: 183703
			[FieldOffset(0)]
			public float ActionTime;
		}
	}
}
