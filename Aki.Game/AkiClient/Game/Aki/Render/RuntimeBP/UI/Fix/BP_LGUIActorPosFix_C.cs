using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI.Fix
{
	// Token: 0x02003AA2 RID: 15010
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/Fix/BP_LGUIActorPosFix.BP_LGUIActorPosFix_C")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class BP_LGUIActorPosFix_C : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201DC RID: 131548 RVA: 0x008CA085 File Offset: 0x008C8285
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LGUIActorPosFix_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/Fix/BP_LGUIActorPosFix.BP_LGUIActorPosFix_C");
			}
			return BP_LGUIActorPosFix_C._ClassPtr;
		}

		// Token: 0x060201DD RID: 131549 RVA: 0x008CA0AC File Offset: 0x008C82AC
		public BP_LGUIActorPosFix_C() : this(BuiltinUtils.AllocNativeUObject(BP_LGUIActorPosFix_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201DE RID: 131550 RVA: 0x008CA0D4 File Offset: 0x008C82D4
		[NullableContext(1)]
		public BP_LGUIActorPosFix_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LGUIActorPosFix_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x060201DF RID: 131551 RVA: 0x008CA107 File Offset: 0x008C8307
		// (set) Token: 0x060201E0 RID: 131552 RVA: 0x008CA11B File Offset: 0x008C831B
		public unsafe AActor Actor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LGUIActorPosFix_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LGUIActorPosFix_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x060201E1 RID: 131553 RVA: 0x008CA130 File Offset: 0x008C8330
		// (set) Token: 0x060201E2 RID: 131554 RVA: 0x008CA144 File Offset: 0x008C8344
		public unsafe UUITexture UITexture_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LGUIActorPosFix_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LGUIActorPosFix_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x060201E3 RID: 131555 RVA: 0x008CA15C File Offset: 0x008C835C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LGUIActorPosFix_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LGUIActorPosFix_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060201E4 RID: 131556 RVA: 0x008CA1A4 File Offset: 0x008C83A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LGUIActorPosFix_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LGUIActorPosFix_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LGUIActorPosFix_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060201E5 RID: 131557 RVA: 0x008CA1EB File Offset: 0x008C83EB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LGUIActorPosFix_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060201E6 RID: 131558 RVA: 0x008CA1FF File Offset: 0x008C83FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LGUIActorPosFix_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060201E7 RID: 131559 RVA: 0x008CA214 File Offset: 0x008C8414
		protected BP_LGUIActorPosFix_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F837 RID: 63543
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/Fix/BP_LGUIActorPosFix.BP_LGUIActorPosFix_C";

		// Token: 0x0400F838 RID: 63544
		private static IntPtr _ClassPtr;

		// Token: 0x0400F839 RID: 63545
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F83A RID: 63546
		internal static int __PropertyOffset_1;

		// Token: 0x0400F83B RID: 63547
		internal static int __PropertyOffset_2;

		// Token: 0x0400F83C RID: 63548
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F83D RID: 63549
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B77 RID: 39799
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311BB RID: 201147
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
