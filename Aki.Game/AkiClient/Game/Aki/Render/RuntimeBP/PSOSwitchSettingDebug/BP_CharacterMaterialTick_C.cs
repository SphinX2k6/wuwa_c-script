using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.TickMaster;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PSOSwitchSettingDebug
{
	// Token: 0x02003BCB RID: 15307
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/BP_CharacterMaterialTick.BP_CharacterMaterialTick_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1089)]
	public class BP_CharacterMaterialTick_C : AActor, IUnrealUObject, IUnrealObject, IBPI_EditorTickMaster_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602252A RID: 140586 RVA: 0x00905BF7 File Offset: 0x00903DF7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterMaterialTick_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/BP_CharacterMaterialTick.BP_CharacterMaterialTick_C");
			}
			return BP_CharacterMaterialTick_C._ClassPtr;
		}

		// Token: 0x0602252B RID: 140587 RVA: 0x00905C1C File Offset: 0x00903E1C
		public BP_CharacterMaterialTick_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterMaterialTick_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602252C RID: 140588 RVA: 0x00905C44 File Offset: 0x00903E44
		[NullableContext(1)]
		public BP_CharacterMaterialTick_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterMaterialTick_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0602252D RID: 140589 RVA: 0x00905C77 File Offset: 0x00903E77
		// (set) Token: 0x0602252E RID: 140590 RVA: 0x00905C8B File Offset: 0x00903E8B
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0602252F RID: 140591 RVA: 0x00905CA0 File Offset: 0x00903EA0
		// (set) Token: 0x06022530 RID: 140592 RVA: 0x00905CB4 File Offset: 0x00903EB4
		public unsafe USkeletalMeshComponent SkeletalMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x06022531 RID: 140593 RVA: 0x00905CC9 File Offset: 0x00903EC9
		// (set) Token: 0x06022532 RID: 140594 RVA: 0x00905CDD File Offset: 0x00903EDD
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterMaterialTick_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x06022533 RID: 140595 RVA: 0x00905CF2 File Offset: 0x00903EF2
		// (set) Token: 0x06022534 RID: 140596 RVA: 0x00905D02 File Offset: 0x00903F02
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x06022535 RID: 140597 RVA: 0x00905D13 File Offset: 0x00903F13
		// (set) Token: 0x06022536 RID: 140598 RVA: 0x00905D23 File Offset: 0x00903F23
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x06022537 RID: 140599 RVA: 0x00905D34 File Offset: 0x00903F34
		// (set) Token: 0x06022538 RID: 140600 RVA: 0x00905D44 File Offset: 0x00903F44
		public unsafe bool UseWithSkeletalMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterMaterialTick_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022539 RID: 140601 RVA: 0x00905D58 File Offset: 0x00903F58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterMaterialTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterMaterialTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602253A RID: 140602 RVA: 0x00905DA0 File Offset: 0x00903FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterMaterialTick_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterMaterialTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterMaterialTick_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602253B RID: 140603 RVA: 0x00905DE8 File Offset: 0x00903FE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EditorTickMaster(float DeltaTime)
		{
			BP_CharacterMaterialTick_C.__EditorTickMaster_FunctionParams* ptr = stackalloc BP_CharacterMaterialTick_C.__EditorTickMaster_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CharacterMaterialTick_C.__EditorTickMaster_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterMaterialTick_C.__EditorTickMaster_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterMaterialTick_C.__EditorTickMaster_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602253C RID: 140604 RVA: 0x00905E2E File Offset: 0x0090402E
		protected BP_CharacterMaterialTick_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D64 RID: 68964
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/BP_CharacterMaterialTick.BP_CharacterMaterialTick_C";

		// Token: 0x04010D65 RID: 68965
		private static IntPtr _ClassPtr;

		// Token: 0x04010D66 RID: 68966
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D67 RID: 68967
		internal static int __PropertyOffset_1;

		// Token: 0x04010D68 RID: 68968
		internal static int __PropertyOffset_2;

		// Token: 0x04010D69 RID: 68969
		internal static int __PropertyOffset_3;

		// Token: 0x04010D6A RID: 68970
		internal static int __PropertyOffset_4;

		// Token: 0x04010D6B RID: 68971
		internal static int __PropertyOffset_5;

		// Token: 0x04010D6C RID: 68972
		internal static int __PropertyOffset_6;

		// Token: 0x04010D6D RID: 68973
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010D6E RID: 68974
		private static IntPtr __EditorTickMaster_NativeFunctionPtr;

		// Token: 0x02009D63 RID: 40291
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314E0 RID: 201952
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D64 RID: 40292
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTickMaster_FunctionParams
		{
			// Token: 0x040314E1 RID: 201953
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
