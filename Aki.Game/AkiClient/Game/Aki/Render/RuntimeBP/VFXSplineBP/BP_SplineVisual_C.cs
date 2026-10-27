using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.VFXSplineBP
{
	// Token: 0x02003A8F RID: 14991
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_SplineVisual.BP_SplineVisual_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class BP_SplineVisual_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE5F RID: 130655 RVA: 0x008C5701 File Offset: 0x008C3901
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineVisual_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_SplineVisual.BP_SplineVisual_C");
			}
			return BP_SplineVisual_C._ClassPtr;
		}

		// Token: 0x0601FE60 RID: 130656 RVA: 0x008C5728 File Offset: 0x008C3928
		public BP_SplineVisual_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineVisual_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE61 RID: 130657 RVA: 0x008C5750 File Offset: 0x008C3950
		[NullableContext(1)]
		public BP_SplineVisual_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineVisual_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0601FE62 RID: 130658 RVA: 0x008C5783 File Offset: 0x008C3983
		// (set) Token: 0x0601FE63 RID: 130659 RVA: 0x008C5797 File Offset: 0x008C3997
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0601FE64 RID: 130660 RVA: 0x008C57AC File Offset: 0x008C39AC
		// (set) Token: 0x0601FE65 RID: 130661 RVA: 0x008C57C0 File Offset: 0x008C39C0
		public unsafe URopeVerletComponent RopeVerlet
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0601FE66 RID: 130662 RVA: 0x008C57D5 File Offset: 0x008C39D5
		// (set) Token: 0x0601FE67 RID: 130663 RVA: 0x008C57E9 File Offset: 0x008C39E9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0601FE68 RID: 130664 RVA: 0x008C57FE File Offset: 0x008C39FE
		// (set) Token: 0x0601FE69 RID: 130665 RVA: 0x008C5812 File Offset: 0x008C3A12
		public unsafe FVector StartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineVisual_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineVisual_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0601FE6A RID: 130666 RVA: 0x008C5827 File Offset: 0x008C3A27
		// (set) Token: 0x0601FE6B RID: 130667 RVA: 0x008C583B File Offset: 0x008C3A3B
		public unsafe FVector EndPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineVisual_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineVisual_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0601FE6C RID: 130668 RVA: 0x008C5850 File Offset: 0x008C3A50
		// (set) Token: 0x0601FE6D RID: 130669 RVA: 0x008C5864 File Offset: 0x008C3A64
		public unsafe URopeVerletDataAsset RopeStaticDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0601FE6E RID: 130670 RVA: 0x008C5879 File Offset: 0x008C3A79
		// (set) Token: 0x0601FE6F RID: 130671 RVA: 0x008C588D File Offset: 0x008C3A8D
		public unsafe URopeVerletDataAsset RopeDynamicDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0601FE70 RID: 130672 RVA: 0x008C58A2 File Offset: 0x008C3AA2
		// (set) Token: 0x0601FE71 RID: 130673 RVA: 0x008C58B6 File Offset: 0x008C3AB6
		public unsafe URopeVerletDataAsset LocalRopeDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URopeVerletDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0601FE72 RID: 130674 RVA: 0x008C58CB File Offset: 0x008C3ACB
		// (set) Token: 0x0601FE73 RID: 130675 RVA: 0x008C58DF File Offset: 0x008C3ADF
		public unsafe UEffectModelNiagara NiagaraDA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelNiagara>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineVisual_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x0601FE74 RID: 130676 RVA: 0x008C58F4 File Offset: 0x008C3AF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置特效DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__设置特效DA_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE75 RID: 130677 RVA: 0x008C5908 File Offset: 0x008C3B08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置空放DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__设置空放DA_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE76 RID: 130678 RVA: 0x008C591C File Offset: 0x008C3B1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置战斗DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__设置战斗DA_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE77 RID: 130679 RVA: 0x008C5930 File Offset: 0x008C3B30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRope()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__InitRope_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE78 RID: 130680 RVA: 0x008C5944 File Offset: 0x008C3B44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FE79 RID: 130681 RVA: 0x008C5958 File Offset: 0x008C3B58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineVisual_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FE7A RID: 130682 RVA: 0x008C5970 File Offset: 0x008C3B70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplineVisual_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineVisual_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineVisual_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineVisual_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineVisual_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FE7B RID: 130683 RVA: 0x008C59B8 File Offset: 0x008C3BB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplineVisual_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineVisual_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineVisual_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineVisual_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineVisual_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FE7C RID: 130684 RVA: 0x008C59FF File Offset: 0x008C3BFF
		protected BP_SplineVisual_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F61E RID: 63006
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/VFXSplineBP/BP_SplineVisual.BP_SplineVisual_C";

		// Token: 0x0400F61F RID: 63007
		private static IntPtr _ClassPtr;

		// Token: 0x0400F620 RID: 63008
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F621 RID: 63009
		internal static int __PropertyOffset_1;

		// Token: 0x0400F622 RID: 63010
		internal static int __PropertyOffset_2;

		// Token: 0x0400F623 RID: 63011
		internal static int __PropertyOffset_3;

		// Token: 0x0400F624 RID: 63012
		internal static int __PropertyOffset_4;

		// Token: 0x0400F625 RID: 63013
		internal static int __PropertyOffset_5;

		// Token: 0x0400F626 RID: 63014
		internal static int __PropertyOffset_6;

		// Token: 0x0400F627 RID: 63015
		internal static int __PropertyOffset_7;

		// Token: 0x0400F628 RID: 63016
		internal static int __PropertyOffset_8;

		// Token: 0x0400F629 RID: 63017
		internal static int __PropertyOffset_9;

		// Token: 0x0400F62A RID: 63018
		private static IntPtr __设置特效DA_NativeFunctionPtr;

		// Token: 0x0400F62B RID: 63019
		private static IntPtr __设置空放DA_NativeFunctionPtr;

		// Token: 0x0400F62C RID: 63020
		private static IntPtr __设置战斗DA_NativeFunctionPtr;

		// Token: 0x0400F62D RID: 63021
		private static IntPtr __InitRope_NativeFunctionPtr;

		// Token: 0x0400F62E RID: 63022
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F62F RID: 63023
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009B62 RID: 39778
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031199 RID: 201113
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
