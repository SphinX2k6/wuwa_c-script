using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B54 RID: 15188
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_InteractFoliageActor_Base_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AA4 RID: 137892 RVA: 0x008F26BE File Offset: 0x008F08BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractFoliageActor_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C");
			}
			return BP_InteractFoliageActor_Base_C._ClassPtr;
		}

		// Token: 0x06021AA5 RID: 137893 RVA: 0x008F26E4 File Offset: 0x008F08E4
		public BP_InteractFoliageActor_Base_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021AA6 RID: 137894 RVA: 0x008F270C File Offset: 0x008F090C
		[NullableContext(1)]
		public BP_InteractFoliageActor_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractFoliageActor_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x06021AA7 RID: 137895 RVA: 0x008F273F File Offset: 0x008F093F
		// (set) Token: 0x06021AA8 RID: 137896 RVA: 0x008F2753 File Offset: 0x008F0953
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_Base_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractFoliageActor_Base_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021AA9 RID: 137897 RVA: 0x008F2768 File Offset: 0x008F0968
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVisible(bool visible)
		{
			BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams* ptr = stackalloc BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_InteractFoliageActor_Base_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractFoliageActor_Base_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->visible = visible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractFoliageActor_Base_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021AAA RID: 137898 RVA: 0x008F27AE File Offset: 0x008F09AE
		protected BP_InteractFoliageActor_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106B6 RID: 67254
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractFoliageActor_Base.BP_InteractFoliageActor_Base_C";

		// Token: 0x040106B7 RID: 67255
		private static IntPtr _ClassPtr;

		// Token: 0x040106B8 RID: 67256
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106B9 RID: 67257
		internal static int __PropertyOffset_0;

		// Token: 0x040106BA RID: 67258
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x02009CB7 RID: 40119
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x04031394 RID: 201620
			[FieldOffset(0)]
			public bool visible;
		}
	}
}
