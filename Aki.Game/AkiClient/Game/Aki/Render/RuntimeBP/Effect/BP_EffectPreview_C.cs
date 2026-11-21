using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect
{
	// Token: 0x02003101 RID: 12545
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_EffectPreview_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB3C RID: 125756 RVA: 0x0091ADFF File Offset: 0x00918FFF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectPreview_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C");
			}
			return BP_EffectPreview_C._ClassPtr;
		}

		// Token: 0x0601EB3D RID: 125757 RVA: 0x0091AE24 File Offset: 0x00919024
		public BP_EffectPreview_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectPreview_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB3E RID: 125758 RVA: 0x0091AE4C File Offset: 0x0091904C
		[NullableContext(1)]
		public BP_EffectPreview_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectPreview_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0601EB3F RID: 125759 RVA: 0x0091AE7F File Offset: 0x0091907F
		// (set) Token: 0x0601EB40 RID: 125760 RVA: 0x0091AE93 File Offset: 0x00919093
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPreview_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectPreview_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0601EB41 RID: 125761 RVA: 0x0091AEA8 File Offset: 0x009190A8
		// (set) Token: 0x0601EB42 RID: 125762 RVA: 0x0091AEB8 File Offset: 0x009190B8
		public unsafe int EffectView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_EffectView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_EffectView) = value;
			}
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0601EB43 RID: 125763 RVA: 0x0091AEC9 File Offset: 0x009190C9
		// (set) Token: 0x0601EB44 RID: 125764 RVA: 0x0091AED9 File Offset: 0x009190D9
		public unsafe int Transient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_Transient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_EffectPreview_C.__PropertyOffset_Transient) = value;
			}
		}

		// Token: 0x0601EB45 RID: 125765 RVA: 0x0091AEEA File Offset: 0x009190EA
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPreview_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB46 RID: 125766 RVA: 0x0091AEFE File Offset: 0x009190FE
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectPreview_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601EB47 RID: 125767 RVA: 0x0091AF14 File Offset: 0x00919114
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_EffectPreview_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectPreview_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectPreview_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB48 RID: 125768 RVA: 0x0091AF5C File Offset: 0x0091915C
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_EffectPreview_C.__EditorTick_FunctionParams* ptr = stackalloc BP_EffectPreview_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_EffectPreview_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_EffectPreview_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EB49 RID: 125769 RVA: 0x0091AFA2 File Offset: 0x009191A2
		protected BP_EffectPreview_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040104B4 RID: 66740
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/BP_EffectPreview.BP_EffectPreview_C";

		// Token: 0x040104B5 RID: 66741
		private static IntPtr _ClassPtr;

		// Token: 0x040104B6 RID: 66742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040104B7 RID: 66743
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x040104B8 RID: 66744
		internal static int __PropertyOffset_EffectView;

		// Token: 0x040104B9 RID: 66745
		internal static int __PropertyOffset_Transient;

		// Token: 0x040104BA RID: 66746
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040104BB RID: 66747
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008EC1 RID: 36545
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CB60 RID: 183136
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
