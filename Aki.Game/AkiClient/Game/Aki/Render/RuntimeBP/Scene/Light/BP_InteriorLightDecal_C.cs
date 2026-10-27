using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B06 RID: 15110
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_InteriorLightDecal.BP_InteriorLightDecal_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1148)]
	public class BP_InteriorLightDecal_C : ADecalActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DC0 RID: 134592 RVA: 0x008DEF64 File Offset: 0x008DD164
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteriorLightDecal_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_InteriorLightDecal.BP_InteriorLightDecal_C");
			}
			return BP_InteriorLightDecal_C._ClassPtr;
		}

		// Token: 0x06020DC1 RID: 134593 RVA: 0x008DEF88 File Offset: 0x008DD188
		public BP_InteriorLightDecal_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteriorLightDecal_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DC2 RID: 134594 RVA: 0x008DEFB0 File Offset: 0x008DD1B0
		[NullableContext(1)]
		public BP_InteriorLightDecal_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteriorLightDecal_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x06020DC3 RID: 134595 RVA: 0x008DEFE3 File Offset: 0x008DD1E3
		// (set) Token: 0x06020DC4 RID: 134596 RVA: 0x008DEFF7 File Offset: 0x008DD1F7
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x06020DC5 RID: 134597 RVA: 0x008DF00C File Offset: 0x008DD20C
		// (set) Token: 0x06020DC6 RID: 134598 RVA: 0x008DF020 File Offset: 0x008DD220
		public unsafe UMaterialInstanceDynamic DYMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x06020DC7 RID: 134599 RVA: 0x008DF035 File Offset: 0x008DD235
		// (set) Token: 0x06020DC8 RID: 134600 RVA: 0x008DF049 File Offset: 0x008DD249
		public unsafe UTexture2D ShadowTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteriorLightDecal_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x06020DC9 RID: 134601 RVA: 0x008DF05E File Offset: 0x008DD25E
		// (set) Token: 0x06020DCA RID: 134602 RVA: 0x008DF06E File Offset: 0x008DD26E
		public unsafe float ShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x06020DCB RID: 134603 RVA: 0x008DF07F File Offset: 0x008DD27F
		// (set) Token: 0x06020DCC RID: 134604 RVA: 0x008DF08F File Offset: 0x008DD28F
		public unsafe float InvShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x06020DCD RID: 134605 RVA: 0x008DF0A0 File Offset: 0x008DD2A0
		// (set) Token: 0x06020DCE RID: 134606 RVA: 0x008DF0B0 File Offset: 0x008DD2B0
		public unsafe int DALayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x06020DCF RID: 134607 RVA: 0x008DF0C1 File Offset: 0x008DD2C1
		// (set) Token: 0x06020DD0 RID: 134608 RVA: 0x008DF0D5 File Offset: 0x008DD2D5
		public unsafe FName MPC_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x06020DD1 RID: 134609 RVA: 0x008DF0EA File Offset: 0x008DD2EA
		// (set) Token: 0x06020DD2 RID: 134610 RVA: 0x008DF0FA File Offset: 0x008DD2FA
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x06020DD3 RID: 134611 RVA: 0x008DF10B File Offset: 0x008DD30B
		// (set) Token: 0x06020DD4 RID: 134612 RVA: 0x008DF11B File Offset: 0x008DD31B
		public unsafe float RestoreVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x06020DD5 RID: 134613 RVA: 0x008DF12C File Offset: 0x008DD32C
		// (set) Token: 0x06020DD6 RID: 134614 RVA: 0x008DF13C File Offset: 0x008DD33C
		public unsafe float DeltaTimeTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteriorLightDecal_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x06020DD7 RID: 134615 RVA: 0x008DF14D File Offset: 0x008DD34D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FromDa()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteriorLightDecal_C.__FromDa_NativeFunctionPtr, null);
		}

		// Token: 0x06020DD8 RID: 134616 RVA: 0x008DF161 File Offset: 0x008DD361
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteriorLightDecal_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020DD9 RID: 134617 RVA: 0x008DF175 File Offset: 0x008DD375
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteriorLightDecal_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020DDA RID: 134618 RVA: 0x008DF18C File Offset: 0x008DD38C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteriorLightDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteriorLightDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020DDB RID: 134619 RVA: 0x008DF1D4 File Offset: 0x008DD3D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteriorLightDecal_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteriorLightDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteriorLightDecal_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020DDC RID: 134620 RVA: 0x008DF21B File Offset: 0x008DD41B
		protected BP_InteriorLightDecal_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF79 RID: 65401
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_InteriorLightDecal.BP_InteriorLightDecal_C";

		// Token: 0x0400FF7A RID: 65402
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF7B RID: 65403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF7C RID: 65404
		internal static int __PropertyOffset_1;

		// Token: 0x0400FF7D RID: 65405
		internal static int __PropertyOffset_2;

		// Token: 0x0400FF7E RID: 65406
		internal static int __PropertyOffset_3;

		// Token: 0x0400FF7F RID: 65407
		internal static int __PropertyOffset_4;

		// Token: 0x0400FF80 RID: 65408
		internal static int __PropertyOffset_5;

		// Token: 0x0400FF81 RID: 65409
		internal static int __PropertyOffset_6;

		// Token: 0x0400FF82 RID: 65410
		internal static int __PropertyOffset_7;

		// Token: 0x0400FF83 RID: 65411
		internal static int __PropertyOffset_8;

		// Token: 0x0400FF84 RID: 65412
		internal static int __PropertyOffset_9;

		// Token: 0x0400FF85 RID: 65413
		internal static int __PropertyOffset_10;

		// Token: 0x0400FF86 RID: 65414
		private static IntPtr __FromDa_NativeFunctionPtr;

		// Token: 0x0400FF87 RID: 65415
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF88 RID: 65416
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C47 RID: 40007
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040312FB RID: 201467
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
