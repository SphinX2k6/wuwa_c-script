using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AD9 RID: 15065
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_ForbidVolumetricFog.BP_ForbidVolumetricFog_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1068)]
	public class BP_ForbidVolumetricFog_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020879 RID: 133241 RVA: 0x008D542D File Offset: 0x008D362D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ForbidVolumetricFog_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_ForbidVolumetricFog.BP_ForbidVolumetricFog_C");
			}
			return BP_ForbidVolumetricFog_C._ClassPtr;
		}

		// Token: 0x0602087A RID: 133242 RVA: 0x008D5454 File Offset: 0x008D3654
		public BP_ForbidVolumetricFog_C() : this(BuiltinUtils.AllocNativeUObject(BP_ForbidVolumetricFog_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602087B RID: 133243 RVA: 0x008D547C File Offset: 0x008D367C
		[NullableContext(1)]
		public BP_ForbidVolumetricFog_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ForbidVolumetricFog_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003139 RID: 12601
		// (get) Token: 0x0602087C RID: 133244 RVA: 0x008D54AF File Offset: 0x008D36AF
		// (set) Token: 0x0602087D RID: 133245 RVA: 0x008D54C3 File Offset: 0x008D36C3
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ForbidVolumetricFog_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ForbidVolumetricFog_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700313A RID: 12602
		// (get) Token: 0x0602087E RID: 133246 RVA: 0x008D54D8 File Offset: 0x008D36D8
		// (set) Token: 0x0602087F RID: 133247 RVA: 0x008D54E8 File Offset: 0x008D36E8
		public unsafe int NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ForbidVolumetricFog_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ForbidVolumetricFog_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06020880 RID: 133248 RVA: 0x008D54F9 File Offset: 0x008D36F9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ForbidVolumetricFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020881 RID: 133249 RVA: 0x008D550D File Offset: 0x008D370D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ForbidVolumetricFog_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020882 RID: 133250 RVA: 0x008D5524 File Offset: 0x008D3724
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ForbidVolumetricFog_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ForbidVolumetricFog_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020883 RID: 133251 RVA: 0x008D5570 File Offset: 0x008D3770
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_ForbidVolumetricFog_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ForbidVolumetricFog_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ForbidVolumetricFog_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020884 RID: 133252 RVA: 0x008D55BC File Offset: 0x008D37BC
		protected BP_ForbidVolumetricFog_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC32 RID: 64562
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_ForbidVolumetricFog.BP_ForbidVolumetricFog_C";

		// Token: 0x0400FC33 RID: 64563
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC34 RID: 64564
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC35 RID: 64565
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC36 RID: 64566
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC37 RID: 64567
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC38 RID: 64568
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009BD2 RID: 39890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031264 RID: 201316
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
