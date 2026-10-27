using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS.PlantAnim
{
	// Token: 0x02003C88 RID: 15496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/BP_KuroCSPlantAnim.BP_KuroCSPlantAnim_C")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class BP_KuroCSPlantAnim_C : AKuroCSPlantAnim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060242DA RID: 148186 RVA: 0x009370CE File Offset: 0x009352CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSPlantAnim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/BP_KuroCSPlantAnim.BP_KuroCSPlantAnim_C");
			}
			return BP_KuroCSPlantAnim_C._ClassPtr;
		}

		// Token: 0x060242DB RID: 148187 RVA: 0x009370F4 File Offset: 0x009352F4
		public BP_KuroCSPlantAnim_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSPlantAnim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060242DC RID: 148188 RVA: 0x0093711C File Offset: 0x0093531C
		[NullableContext(1)]
		public BP_KuroCSPlantAnim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSPlantAnim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045AD RID: 17837
		// (get) Token: 0x060242DD RID: 148189 RVA: 0x0093714F File Offset: 0x0093534F
		// (set) Token: 0x060242DE RID: 148190 RVA: 0x00937163 File Offset: 0x00935363
		public unsafe UStaticMeshComponent Leaf
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170045AE RID: 17838
		// (get) Token: 0x060242DF RID: 148191 RVA: 0x00937178 File Offset: 0x00935378
		// (set) Token: 0x060242E0 RID: 148192 RVA: 0x0093718C File Offset: 0x0093538C
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x060242E1 RID: 148193 RVA: 0x009371A1 File Offset: 0x009353A1
		// (set) Token: 0x060242E2 RID: 148194 RVA: 0x009371B5 File Offset: 0x009353B5
		public unsafe UStaticMeshComponent SM_VAT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x060242E3 RID: 148195 RVA: 0x009371CA File Offset: 0x009353CA
		// (set) Token: 0x060242E4 RID: 148196 RVA: 0x009371DE File Offset: 0x009353DE
		public unsafe UStaticMeshComponent FoliageRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x060242E5 RID: 148197 RVA: 0x009371F3 File Offset: 0x009353F3
		// (set) Token: 0x060242E6 RID: 148198 RVA: 0x00937207 File Offset: 0x00935407
		public unsafe UMaterialInterface Dynamic_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x060242E7 RID: 148199 RVA: 0x0093721C File Offset: 0x0093541C
		// (set) Token: 0x060242E8 RID: 148200 RVA: 0x00937230 File Offset: 0x00935430
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlantAnim_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x060242E9 RID: 148201 RVA: 0x00937245 File Offset: 0x00935445
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugDraw()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__DebugDraw_NativeFunctionPtr, null);
		}

		// Token: 0x060242EA RID: 148202 RVA: 0x00937259 File Offset: 0x00935459
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060242EB RID: 148203 RVA: 0x0093726D File Offset: 0x0093546D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060242EC RID: 148204 RVA: 0x00937282 File Offset: 0x00935482
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060242ED RID: 148205 RVA: 0x00937296 File Offset: 0x00935496
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060242EE RID: 148206 RVA: 0x009372AC File Offset: 0x009354AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlantAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242EF RID: 148207 RVA: 0x009372F4 File Offset: 0x009354F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSPlantAnim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlantAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlantAnim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060242F0 RID: 148208 RVA: 0x0093733B File Offset: 0x0093553B
		protected BP_KuroCSPlantAnim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011EB2 RID: 73394
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/PlantAnim/BP_KuroCSPlantAnim.BP_KuroCSPlantAnim_C";

		// Token: 0x04011EB3 RID: 73395
		private static IntPtr _ClassPtr;

		// Token: 0x04011EB4 RID: 73396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011EB5 RID: 73397
		internal static int __PropertyOffset_1;

		// Token: 0x04011EB6 RID: 73398
		internal static int __PropertyOffset_2;

		// Token: 0x04011EB7 RID: 73399
		internal static int __PropertyOffset_3;

		// Token: 0x04011EB8 RID: 73400
		internal static int __PropertyOffset_4;

		// Token: 0x04011EB9 RID: 73401
		internal static int __PropertyOffset_5;

		// Token: 0x04011EBA RID: 73402
		internal static int __PropertyOffset_6;

		// Token: 0x04011EBB RID: 73403
		private static IntPtr __DebugDraw_NativeFunctionPtr;

		// Token: 0x04011EBC RID: 73404
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011EBD RID: 73405
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011EBE RID: 73406
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009EE1 RID: 40673
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317DF RID: 202719
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
