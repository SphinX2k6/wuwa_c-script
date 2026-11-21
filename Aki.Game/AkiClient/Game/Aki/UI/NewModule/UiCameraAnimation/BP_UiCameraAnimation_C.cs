using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.NewModule.UiCameraAnimation
{
	// Token: 0x02003035 RID: 12341
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_UiCameraAnimation_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D43D RID: 119869 RVA: 0x008EF637 File Offset: 0x008ED837
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UiCameraAnimation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C");
			}
			return BP_UiCameraAnimation_C._ClassPtr;
		}

		// Token: 0x0601D43E RID: 119870 RVA: 0x008EF65C File Offset: 0x008ED85C
		public BP_UiCameraAnimation_C() : this(BuiltinUtils.AllocNativeUObject(BP_UiCameraAnimation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D43F RID: 119871 RVA: 0x008EF684 File Offset: 0x008ED884
		[NullableContext(1)]
		public BP_UiCameraAnimation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UiCameraAnimation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0601D440 RID: 119872 RVA: 0x008EF6B7 File Offset: 0x008ED8B7
		// (set) Token: 0x0601D441 RID: 119873 RVA: 0x008EF6CB File Offset: 0x008ED8CB
		public unsafe UCameraComponent Camera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_Camera);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_Camera, value);
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0601D442 RID: 119874 RVA: 0x008EF6E0 File Offset: 0x008ED8E0
		// (set) Token: 0x0601D443 RID: 119875 RVA: 0x008EF6F4 File Offset: 0x008ED8F4
		public unsafe USpringArmComponent SpringArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpringArmComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_SpringArm);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_SpringArm, value);
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0601D444 RID: 119876 RVA: 0x008EF709 File Offset: 0x008ED909
		// (set) Token: 0x0601D445 RID: 119877 RVA: 0x008EF71D File Offset: 0x008ED91D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UiCameraAnimation_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601D446 RID: 119878 RVA: 0x008EF732 File Offset: 0x008ED932
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UiCameraAnimation_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D447 RID: 119879 RVA: 0x008EF746 File Offset: 0x008ED946
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UiCameraAnimation_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D448 RID: 119880 RVA: 0x008EF75A File Offset: 0x008ED95A
		protected BP_UiCameraAnimation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F684 RID: 63108
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/NewModule/UiCameraAnimation/BP_UiCameraAnimation.BP_UiCameraAnimation_C";

		// Token: 0x0400F685 RID: 63109
		private static IntPtr _ClassPtr;

		// Token: 0x0400F686 RID: 63110
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F687 RID: 63111
		internal static int __PropertyOffset_Camera;

		// Token: 0x0400F688 RID: 63112
		internal static int __PropertyOffset_SpringArm;

		// Token: 0x0400F689 RID: 63113
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F68A RID: 63114
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
