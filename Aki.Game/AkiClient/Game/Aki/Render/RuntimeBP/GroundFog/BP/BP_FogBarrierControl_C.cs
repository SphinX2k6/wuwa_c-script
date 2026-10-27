using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GroundFog.BP
{
	// Token: 0x02003D27 RID: 15655
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_FogBarrierControl.BP_FogBarrierControl_C")]
	[UnrealStructLayout(1480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1476)]
	public class BP_FogBarrierControl_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A6E RID: 154222 RVA: 0x0095F756 File Offset: 0x0095D956
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FogBarrierControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_FogBarrierControl.BP_FogBarrierControl_C");
			}
			return BP_FogBarrierControl_C._ClassPtr;
		}

		// Token: 0x06025A6F RID: 154223 RVA: 0x0095F77C File Offset: 0x0095D97C
		public BP_FogBarrierControl_C() : this(BuiltinUtils.AllocNativeUObject(BP_FogBarrierControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A70 RID: 154224 RVA: 0x0095F7A4 File Offset: 0x0095D9A4
		[NullableContext(1)]
		public BP_FogBarrierControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FogBarrierControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DDF RID: 19935
		// (get) Token: 0x06025A71 RID: 154225 RVA: 0x0095F7D7 File Offset: 0x0095D9D7
		// (set) Token: 0x06025A72 RID: 154226 RVA: 0x0095F7EB File Offset: 0x0095D9EB
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FogBarrierControl_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FogBarrierControl_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004DE0 RID: 19936
		// (get) Token: 0x06025A73 RID: 154227 RVA: 0x0095F800 File Offset: 0x0095DA00
		// (set) Token: 0x06025A74 RID: 154228 RVA: 0x0095F814 File Offset: 0x0095DA14
		public unsafe FVector WidthHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FogBarrierControl_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FogBarrierControl_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x06025A75 RID: 154229 RVA: 0x0095F829 File Offset: 0x0095DA29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FogBarrierControl_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025A76 RID: 154230 RVA: 0x0095F83D File Offset: 0x0095DA3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FogBarrierControl_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025A77 RID: 154231 RVA: 0x0095F854 File Offset: 0x0095DA54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FogBarrierControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FogBarrierControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FogBarrierControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FogBarrierControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FogBarrierControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025A78 RID: 154232 RVA: 0x0095F89C File Offset: 0x0095DA9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FogBarrierControl_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FogBarrierControl_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FogBarrierControl_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FogBarrierControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FogBarrierControl_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025A79 RID: 154233 RVA: 0x0095F8E3 File Offset: 0x0095DAE3
		protected BP_FogBarrierControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CE0 RID: 77024
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GroundFog/BP/BP_FogBarrierControl.BP_FogBarrierControl_C";

		// Token: 0x04012CE1 RID: 77025
		private static IntPtr _ClassPtr;

		// Token: 0x04012CE2 RID: 77026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CE3 RID: 77027
		internal static int __PropertyOffset_1;

		// Token: 0x04012CE4 RID: 77028
		internal static int __PropertyOffset_2;

		// Token: 0x04012CE5 RID: 77029
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012CE6 RID: 77030
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A01E RID: 40990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AC7 RID: 203463
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
