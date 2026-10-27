using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.GamePlay.StaticSceneInteraction
{
	// Token: 0x02003E54 RID: 15956
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/StaticSceneInteraction/BP_GlobalGameplayPostProcess.BP_GlobalGameplayPostProcess_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_GlobalGameplayPostProcess_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060281A4 RID: 164260 RVA: 0x009A40AB File Offset: 0x009A22AB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GlobalGameplayPostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/GamePlay/StaticSceneInteraction/BP_GlobalGameplayPostProcess.BP_GlobalGameplayPostProcess_C");
			}
			return BP_GlobalGameplayPostProcess_C._ClassPtr;
		}

		// Token: 0x060281A5 RID: 164261 RVA: 0x009A40D0 File Offset: 0x009A22D0
		public BP_GlobalGameplayPostProcess_C() : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGameplayPostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060281A6 RID: 164262 RVA: 0x009A40F8 File Offset: 0x009A22F8
		[NullableContext(1)]
		public BP_GlobalGameplayPostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GlobalGameplayPostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BC1 RID: 23489
		// (get) Token: 0x060281A7 RID: 164263 RVA: 0x009A412B File Offset: 0x009A232B
		// (set) Token: 0x060281A8 RID: 164264 RVA: 0x009A413F File Offset: 0x009A233F
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGameplayPostProcess_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGameplayPostProcess_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17005BC2 RID: 23490
		// (get) Token: 0x060281A9 RID: 164265 RVA: 0x009A4154 File Offset: 0x009A2354
		// (set) Token: 0x060281AA RID: 164266 RVA: 0x009A4168 File Offset: 0x009A2368
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGameplayPostProcess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GlobalGameplayPostProcess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060281AB RID: 164267 RVA: 0x009A4180 File Offset: 0x009A2380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateVignette(float Vignette_Intensity)
		{
			BP_GlobalGameplayPostProcess_C.__UpdateVignette_FunctionParams* ptr = stackalloc BP_GlobalGameplayPostProcess_C.__UpdateVignette_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GlobalGameplayPostProcess_C.__UpdateVignette_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GlobalGameplayPostProcess_C.__UpdateVignette_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Vignette_Intensity = Vignette_Intensity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GlobalGameplayPostProcess_C.__UpdateVignette_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060281AC RID: 164268 RVA: 0x009A41C6 File Offset: 0x009A23C6
		protected BP_GlobalGameplayPostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014691 RID: 83601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/GamePlay/StaticSceneInteraction/BP_GlobalGameplayPostProcess.BP_GlobalGameplayPostProcess_C";

		// Token: 0x04014692 RID: 83602
		private static IntPtr _ClassPtr;

		// Token: 0x04014693 RID: 83603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014694 RID: 83604
		internal static int __PropertyOffset_0;

		// Token: 0x04014695 RID: 83605
		internal static int __PropertyOffset_1;

		// Token: 0x04014696 RID: 83606
		private static IntPtr __UpdateVignette_NativeFunctionPtr;

		// Token: 0x0200A2C2 RID: 41666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateVignette_FunctionParams
		{
			// Token: 0x04032001 RID: 204801
			[FieldOffset(0)]
			public float Vignette_Intensity;
		}
	}
}
