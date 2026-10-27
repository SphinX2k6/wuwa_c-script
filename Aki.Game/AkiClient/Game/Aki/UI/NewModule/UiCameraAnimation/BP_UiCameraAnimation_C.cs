using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.NewModule.UiCameraAnimation
{
	// Token: 0x020039D3 RID: 14803
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_UiCameraAnimation_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF39 RID: 126777 RVA: 0x008A5AF2 File Offset: 0x008A3CF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UiCameraAnimation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C");
			}
			return BP_UiCameraAnimation_C._ClassPtr;
		}

		// Token: 0x0601EF3A RID: 126778 RVA: 0x008A5B18 File Offset: 0x008A3D18
		public BP_UiCameraAnimation_C() : this(BuiltinUtils.AllocNativeUObject(BP_UiCameraAnimation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF3B RID: 126779 RVA: 0x008A5B40 File Offset: 0x008A3D40
		[NullableContext(1)]
		public BP_UiCameraAnimation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UiCameraAnimation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0601EF3C RID: 126780 RVA: 0x008A5B73 File Offset: 0x008A3D73
		// (set) Token: 0x0601EF3D RID: 126781 RVA: 0x008A5B87 File Offset: 0x008A3D87
		public unsafe UCameraComponent Camera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0601EF3E RID: 126782 RVA: 0x008A5B9C File Offset: 0x008A3D9C
		// (set) Token: 0x0601EF3F RID: 126783 RVA: 0x008A5BB0 File Offset: 0x008A3DB0
		public unsafe USpringArmComponent SpringArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpringArmComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0601EF40 RID: 126784 RVA: 0x008A5BC5 File Offset: 0x008A3DC5
		// (set) Token: 0x0601EF41 RID: 126785 RVA: 0x008A5BD9 File Offset: 0x008A3DD9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x0601EF42 RID: 126786 RVA: 0x008A5BEE File Offset: 0x008A3DEE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiCameraAnimation_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF43 RID: 126787 RVA: 0x008A5C02 File Offset: 0x008A3E02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UiCameraAnimation_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601EF44 RID: 126788 RVA: 0x008A5C17 File Offset: 0x008A3E17
		protected BP_UiCameraAnimation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECF4 RID: 60660
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C";

		// Token: 0x0400ECF5 RID: 60661
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECF6 RID: 60662
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECF7 RID: 60663
		internal static int __PropertyOffset_0;

		// Token: 0x0400ECF8 RID: 60664
		internal static int __PropertyOffset_1;

		// Token: 0x0400ECF9 RID: 60665
		internal static int __PropertyOffset_2;

		// Token: 0x0400ECFA RID: 60666
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
