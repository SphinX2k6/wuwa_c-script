using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AA9 RID: 15017
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDrawComponent.BP_TrailDrawComponent_C")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 632)]
	public class BP_TrailDrawComponent_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602026B RID: 131691 RVA: 0x008CB0A5 File Offset: 0x008C92A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDrawComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDrawComponent.BP_TrailDrawComponent_C");
			}
			return BP_TrailDrawComponent_C._ClassPtr;
		}

		// Token: 0x0602026C RID: 131692 RVA: 0x008CB0CC File Offset: 0x008C92CC
		public BP_TrailDrawComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602026D RID: 131693 RVA: 0x008CB0F4 File Offset: 0x008C92F4
		[NullableContext(1)]
		public BP_TrailDrawComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDrawComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0602026E RID: 131694 RVA: 0x008CB127 File Offset: 0x008C9327
		// (set) Token: 0x0602026F RID: 131695 RVA: 0x008CB13B File Offset: 0x008C933B
		public unsafe FVector2D Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x06020270 RID: 131696 RVA: 0x008CB150 File Offset: 0x008C9350
		// (set) Token: 0x06020271 RID: 131697 RVA: 0x008CB164 File Offset: 0x008C9364
		public unsafe UTexture Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x06020272 RID: 131698 RVA: 0x008CB179 File Offset: 0x008C9379
		// (set) Token: 0x06020273 RID: 131699 RVA: 0x008CB18D File Offset: 0x008C938D
		public unsafe FVector2D Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x06020274 RID: 131700 RVA: 0x008CB1A2 File Offset: 0x008C93A2
		// (set) Token: 0x06020275 RID: 131701 RVA: 0x008CB1B6 File Offset: 0x008C93B6
		public unsafe BP_TrailsManager_C Manager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_TrailsManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDrawComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x06020276 RID: 131702 RVA: 0x008CB1CB File Offset: 0x008C93CB
		// (set) Token: 0x06020277 RID: 131703 RVA: 0x008CB1DB File Offset: 0x008C93DB
		public unsafe float Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x06020278 RID: 131704 RVA: 0x008CB1EC File Offset: 0x008C93EC
		// (set) Token: 0x06020279 RID: 131705 RVA: 0x008CB1FC File Offset: 0x008C93FC
		public unsafe float Depth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TrailDrawComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602027A RID: 131706 RVA: 0x008CB210 File Offset: 0x008C9410
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetManager(ref BP_TrailsManager_C Ret)
		{
			BP_TrailDrawComponent_C.__GetManager_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_C.__GetManager_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_TrailDrawComponent_C.__GetManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_C.__GetManager_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_TrailDrawComponent_C.__GetManager_FunctionParams ptr2 = ref *ptr;
			BP_TrailsManager_C bp_TrailsManager_C = Ret;
			ptr2.Ret = ((bp_TrailsManager_C != null) ? bp_TrailsManager_C.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_C.__GetManager_NativeFunctionPtr, (void*)ptr);
			Ret = BuiltinUtils.GetOrCreateUObjectByNativePointer<BP_TrailsManager_C>(ptr->Ret);
		}

		// Token: 0x0602027B RID: 131707 RVA: 0x008CB278 File Offset: 0x008C9478
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetPlayerActor(ref AActor Ret)
		{
			BP_TrailDrawComponent_C.__GetPlayerActor_FunctionParams* ptr = stackalloc BP_TrailDrawComponent_C.__GetPlayerActor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_TrailDrawComponent_C.__GetPlayerActor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TrailDrawComponent_C.__GetPlayerActor_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_TrailDrawComponent_C.__GetPlayerActor_FunctionParams ptr2 = ref *ptr;
			AActor aactor = Ret;
			ptr2.Ret = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_C.__GetPlayerActor_NativeFunctionPtr, (void*)ptr);
			Ret = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->Ret);
		}

		// Token: 0x0602027C RID: 131708 RVA: 0x008CB2DC File Offset: 0x008C94DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NeedDrawing()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDrawComponent_C.__NeedDrawing_NativeFunctionPtr, null);
		}

		// Token: 0x0602027D RID: 131709 RVA: 0x008CB2F0 File Offset: 0x008C94F0
		protected BP_TrailDrawComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F88A RID: 63626
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDrawComponent.BP_TrailDrawComponent_C";

		// Token: 0x0400F88B RID: 63627
		private static IntPtr _ClassPtr;

		// Token: 0x0400F88C RID: 63628
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F88D RID: 63629
		internal static int __PropertyOffset_1;

		// Token: 0x0400F88E RID: 63630
		internal static int __PropertyOffset_2;

		// Token: 0x0400F88F RID: 63631
		internal static int __PropertyOffset_3;

		// Token: 0x0400F890 RID: 63632
		internal static int __PropertyOffset_4;

		// Token: 0x0400F891 RID: 63633
		internal static int __PropertyOffset_5;

		// Token: 0x0400F892 RID: 63634
		internal static int __PropertyOffset_6;

		// Token: 0x0400F893 RID: 63635
		private static IntPtr __GetManager_NativeFunctionPtr;

		// Token: 0x0400F894 RID: 63636
		private static IntPtr __GetPlayerActor_NativeFunctionPtr;

		// Token: 0x0400F895 RID: 63637
		private static IntPtr __NeedDrawing_NativeFunctionPtr;

		// Token: 0x02009B82 RID: 39810
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __GetManager_FunctionParams
		{
			// Token: 0x040311CE RID: 201166
			[FieldOffset(0)]
			public IntPtr Ret;
		}

		// Token: 0x02009B83 RID: 39811
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetPlayerActor_FunctionParams
		{
			// Token: 0x040311CF RID: 201167
			[FieldOffset(0)]
			public IntPtr Ret;
		}
	}
}
