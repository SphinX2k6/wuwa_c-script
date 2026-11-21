using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x020030CA RID: 12490
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_InteractFoliageActor_Base_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E0C2 RID: 123074 RVA: 0x009094E6 File Offset: 0x009076E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractFoliageActor_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C");
			}
			return BP_InteractFoliageActor_Base_C._ClassPtr;
		}

		// Token: 0x0601E0C3 RID: 123075 RVA: 0x0090950C File Offset: 0x0090770C
		public BP_InteractFoliageActor_Base_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0C4 RID: 123076 RVA: 0x00909534 File Offset: 0x00907734
		[NullableContext(1)]
		public BP_InteractFoliageActor_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0601E0C5 RID: 123077 RVA: 0x00909567 File Offset: 0x00907767
		// (set) Token: 0x0601E0C6 RID: 123078 RVA: 0x0090957B File Offset: 0x0090777B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_Base_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_Base_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x0601E0C7 RID: 123079 RVA: 0x00909590 File Offset: 0x00907790
		[SkipLocalsInit]
		public unsafe virtual void SetVisible(bool visible)
		{
			BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_Base_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visible = visible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_Base_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E0C8 RID: 123080 RVA: 0x009095D6 File Offset: 0x009077D6
		protected BP_InteractFoliageActor_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE15 RID: 65045
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C";

		// Token: 0x0400FE16 RID: 65046
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE17 RID: 65047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE18 RID: 65048
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FE19 RID: 65049
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x02008E00 RID: 36352
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x0402CA28 RID: 182824
			[FieldOffset(0)]
			public bool visible;
		}
	}
}
