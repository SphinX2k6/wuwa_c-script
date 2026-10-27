using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D13 RID: 15635
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_FallingStarrySky.BP_FallingStarrySky_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_FallingStarrySky_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257AA RID: 153514 RVA: 0x0095AD11 File Offset: 0x00958F11
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FallingStarrySky_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_FallingStarrySky.BP_FallingStarrySky_C");
			}
			return BP_FallingStarrySky_C._ClassPtr;
		}

		// Token: 0x060257AB RID: 153515 RVA: 0x0095AD38 File Offset: 0x00958F38
		public BP_FallingStarrySky_C() : this(BuiltinUtils.AllocNativeUObject(BP_FallingStarrySky_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257AC RID: 153516 RVA: 0x0095AD60 File Offset: 0x00958F60
		[NullableContext(1)]
		public BP_FallingStarrySky_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FallingStarrySky_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x060257AD RID: 153517 RVA: 0x0095AD93 File Offset: 0x00958F93
		// (set) Token: 0x060257AE RID: 153518 RVA: 0x0095ADA7 File Offset: 0x00958FA7
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x060257AF RID: 153519 RVA: 0x0095ADBC File Offset: 0x00958FBC
		// (set) Token: 0x060257B0 RID: 153520 RVA: 0x0095ADD0 File Offset: 0x00958FD0
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x060257B1 RID: 153521 RVA: 0x0095ADE5 File Offset: 0x00958FE5
		// (set) Token: 0x060257B2 RID: 153522 RVA: 0x0095ADF9 File Offset: 0x00958FF9
		public unsafe FName PositionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FallingStarrySky_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FallingStarrySky_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x060257B3 RID: 153523 RVA: 0x0095AE0E File Offset: 0x0095900E
		// (set) Token: 0x060257B4 RID: 153524 RVA: 0x0095AE22 File Offset: 0x00959022
		public unsafe UMaterialInstance DecalMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FallingStarrySky_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x060257B5 RID: 153525 RVA: 0x0095AE37 File Offset: 0x00959037
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FallingStarrySky_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060257B6 RID: 153526 RVA: 0x0095AE4B File Offset: 0x0095904B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FallingStarrySky_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257B7 RID: 153527 RVA: 0x0095AE60 File Offset: 0x00959060
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FallingStarrySky_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060257B8 RID: 153528 RVA: 0x0095AE74 File Offset: 0x00959074
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FallingStarrySky_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060257B9 RID: 153529 RVA: 0x0095AE89 File Offset: 0x00959089
		protected BP_FallingStarrySky_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B3B RID: 76603
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_FallingStarrySky.BP_FallingStarrySky_C";

		// Token: 0x04012B3C RID: 76604
		private static IntPtr _ClassPtr;

		// Token: 0x04012B3D RID: 76605
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B3E RID: 76606
		internal static int __PropertyOffset_1;

		// Token: 0x04012B3F RID: 76607
		internal static int __PropertyOffset_2;

		// Token: 0x04012B40 RID: 76608
		internal static int __PropertyOffset_3;

		// Token: 0x04012B41 RID: 76609
		internal static int __PropertyOffset_4;

		// Token: 0x04012B42 RID: 76610
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B43 RID: 76611
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
