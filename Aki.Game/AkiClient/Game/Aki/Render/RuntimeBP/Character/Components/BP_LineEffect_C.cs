using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x02003E2B RID: 15915
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/BP_LineEffect.BP_LineEffect_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class BP_LineEffect_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E74 RID: 163444 RVA: 0x0099EC88 File Offset: 0x0099CE88
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LineEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/BP_LineEffect.BP_LineEffect_C");
			}
			return BP_LineEffect_C._ClassPtr;
		}

		// Token: 0x06027E75 RID: 163445 RVA: 0x0099ECAC File Offset: 0x0099CEAC
		public BP_LineEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_LineEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E76 RID: 163446 RVA: 0x0099ECD4 File Offset: 0x0099CED4
		[NullableContext(1)]
		public BP_LineEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LineEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x06027E77 RID: 163447 RVA: 0x0099ED07 File Offset: 0x0099CF07
		// (set) Token: 0x06027E78 RID: 163448 RVA: 0x0099ED1B File Offset: 0x0099CF1B
		public unsafe UProceduralMeshComponent ProceduralMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x06027E79 RID: 163449 RVA: 0x0099ED30 File Offset: 0x0099CF30
		// (set) Token: 0x06027E7A RID: 163450 RVA: 0x0099ED44 File Offset: 0x0099CF44
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x06027E7B RID: 163451 RVA: 0x0099ED59 File Offset: 0x0099CF59
		// (set) Token: 0x06027E7C RID: 163452 RVA: 0x0099ED6D File Offset: 0x0099CF6D
		public unsafe AActor CharacterA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005AA9 RID: 23209
		// (get) Token: 0x06027E7D RID: 163453 RVA: 0x0099ED82 File Offset: 0x0099CF82
		// (set) Token: 0x06027E7E RID: 163454 RVA: 0x0099ED96 File Offset: 0x0099CF96
		public unsafe AActor CharacterB
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005AAA RID: 23210
		// (get) Token: 0x06027E7F RID: 163455 RVA: 0x0099EDAB File Offset: 0x0099CFAB
		// (set) Token: 0x06027E80 RID: 163456 RVA: 0x0099EDBB File Offset: 0x0099CFBB
		public unsafe int XLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x06027E81 RID: 163457 RVA: 0x0099EDCC File Offset: 0x0099CFCC
		// (set) Token: 0x06027E82 RID: 163458 RVA: 0x0099EDDC File Offset: 0x0099CFDC
		public unsafe int YLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x06027E83 RID: 163459 RVA: 0x0099EDED File Offset: 0x0099CFED
		// (set) Token: 0x06027E84 RID: 163460 RVA: 0x0099EDFD File Offset: 0x0099CFFD
		public unsafe int X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x06027E85 RID: 163461 RVA: 0x0099EE0E File Offset: 0x0099D00E
		// (set) Token: 0x06027E86 RID: 163462 RVA: 0x0099EE1E File Offset: 0x0099D01E
		public unsafe int Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005AAE RID: 23214
		// (get) Token: 0x06027E87 RID: 163463 RVA: 0x0099EE30 File Offset: 0x0099D030
		// (set) Token: 0x06027E88 RID: 163464 RVA: 0x0099EE69 File Offset: 0x0099D069
		[Nullable(1)]
		public TArray<FVector> Vertex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertex) == null)
				{
					result = (this._Vertex = new TArray<FVector>(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vertex.CopyAssign(value);
			}
		}

		// Token: 0x17005AAF RID: 23215
		// (get) Token: 0x06027E89 RID: 163465 RVA: 0x0099EE78 File Offset: 0x0099D078
		// (set) Token: 0x06027E8A RID: 163466 RVA: 0x0099EEB1 File Offset: 0x0099D0B1
		[Nullable(1)]
		public TArray<FVector2D> UV
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UV) == null)
				{
					result = (this._UV = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UV.CopyAssign(value);
			}
		}

		// Token: 0x17005AB0 RID: 23216
		// (get) Token: 0x06027E8B RID: 163467 RVA: 0x0099EEC0 File Offset: 0x0099D0C0
		// (set) Token: 0x06027E8C RID: 163468 RVA: 0x0099EEF9 File Offset: 0x0099D0F9
		[Nullable(1)]
		public TArray<int> Triangle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Triangle) == null)
				{
					result = (this._Triangle = new TArray<int>(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Triangle.CopyAssign(value);
			}
		}

		// Token: 0x17005AB1 RID: 23217
		// (get) Token: 0x06027E8D RID: 163469 RVA: 0x0099EF08 File Offset: 0x0099D108
		// (set) Token: 0x06027E8E RID: 163470 RVA: 0x0099EF41 File Offset: 0x0099D141
		[Nullable(1)]
		public TArray<FVector> Normals
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Normals) == null)
				{
					result = (this._Normals = new TArray<FVector>(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Normals.CopyAssign(value);
			}
		}

		// Token: 0x17005AB2 RID: 23218
		// (get) Token: 0x06027E8F RID: 163471 RVA: 0x0099EF50 File Offset: 0x0099D150
		// (set) Token: 0x06027E90 RID: 163472 RVA: 0x0099EF89 File Offset: 0x0099D189
		[Nullable(1)]
		public TArray<FProcMeshTangent> Tangents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FProcMeshTangent> result;
				if ((result = this._Tangents) == null)
				{
					result = (this._Tangents = new TArray<FProcMeshTangent>(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Tangents.CopyAssign(value);
			}
		}

		// Token: 0x17005AB3 RID: 23219
		// (get) Token: 0x06027E91 RID: 163473 RVA: 0x0099EF97 File Offset: 0x0099D197
		// (set) Token: 0x06027E92 RID: 163474 RVA: 0x0099EFA7 File Offset: 0x0099D1A7
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005AB4 RID: 23220
		// (get) Token: 0x06027E93 RID: 163475 RVA: 0x0099EFB8 File Offset: 0x0099D1B8
		// (set) Token: 0x06027E94 RID: 163476 RVA: 0x0099EFC8 File Offset: 0x0099D1C8
		public unsafe float height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005AB5 RID: 23221
		// (get) Token: 0x06027E95 RID: 163477 RVA: 0x0099EFD9 File Offset: 0x0099D1D9
		// (set) Token: 0x06027E96 RID: 163478 RVA: 0x0099EFED File Offset: 0x0099D1ED
		public unsafe FVector CharacterALastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x06027E97 RID: 163479 RVA: 0x0099F002 File Offset: 0x0099D202
		// (set) Token: 0x06027E98 RID: 163480 RVA: 0x0099F016 File Offset: 0x0099D216
		public unsafe FVector CharacterBLastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x06027E99 RID: 163481 RVA: 0x0099F02B File Offset: 0x0099D22B
		// (set) Token: 0x06027E9A RID: 163482 RVA: 0x0099F03B File Offset: 0x0099D23B
		public unsafe float HeightGap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LineEffect_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x06027E9B RID: 163483 RVA: 0x0099F04C File Offset: 0x0099D24C
		// (set) Token: 0x06027E9C RID: 163484 RVA: 0x0099F060 File Offset: 0x0099D260
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LineEffect_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x06027E9D RID: 163485 RVA: 0x0099F078 File Offset: 0x0099D278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsDirty(ref bool IsDirty)
		{
			BP_LineEffect_C.__IsDirty_FunctionParams* ptr = stackalloc BP_LineEffect_C.__IsDirty_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_LineEffect_C.__IsDirty_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LineEffect_C.__IsDirty_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDirty = IsDirty;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__IsDirty_NativeFunctionPtr, (void*)ptr);
			IsDirty = ptr->IsDirty;
		}

		// Token: 0x06027E9E RID: 163486 RVA: 0x0099F0C7 File Offset: 0x0099D2C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__ClearData_NativeFunctionPtr, null);
		}

		// Token: 0x06027E9F RID: 163487 RVA: 0x0099F0DB File Offset: 0x0099D2DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Construct()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__Construct_NativeFunctionPtr, null);
		}

		// Token: 0x06027EA0 RID: 163488 RVA: 0x0099F0EF File Offset: 0x0099D2EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawQuad()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__DrawQuad_NativeFunctionPtr, null);
		}

		// Token: 0x06027EA1 RID: 163489 RVA: 0x0099F103 File Offset: 0x0099D303
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Connect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__Connect_NativeFunctionPtr, null);
		}

		// Token: 0x06027EA2 RID: 163490 RVA: 0x0099F118 File Offset: 0x0099D318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LineEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LineEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LineEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LineEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EA3 RID: 163491 RVA: 0x0099F160 File Offset: 0x0099D360
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LineEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LineEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LineEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LineEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LineEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027EA4 RID: 163492 RVA: 0x0099F1A8 File Offset: 0x0099D3A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LineEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LineEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LineEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LineEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LineEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027EA5 RID: 163493 RVA: 0x0099F1F0 File Offset: 0x0099D3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LineEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LineEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LineEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LineEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LineEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027EA6 RID: 163494 RVA: 0x0099F237 File Offset: 0x0099D437
		protected BP_LineEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040143F7 RID: 82935
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/BP_LineEffect.BP_LineEffect_C";

		// Token: 0x040143F8 RID: 82936
		private static IntPtr _ClassPtr;

		// Token: 0x040143F9 RID: 82937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040143FA RID: 82938
		internal static int __PropertyOffset_1;

		// Token: 0x040143FB RID: 82939
		internal static int __PropertyOffset_2;

		// Token: 0x040143FC RID: 82940
		internal static int __PropertyOffset_3;

		// Token: 0x040143FD RID: 82941
		internal static int __PropertyOffset_4;

		// Token: 0x040143FE RID: 82942
		internal static int __PropertyOffset_5;

		// Token: 0x040143FF RID: 82943
		internal static int __PropertyOffset_6;

		// Token: 0x04014400 RID: 82944
		internal static int __PropertyOffset_7;

		// Token: 0x04014401 RID: 82945
		internal static int __PropertyOffset_8;

		// Token: 0x04014402 RID: 82946
		internal static int __PropertyOffset_9;

		// Token: 0x04014403 RID: 82947
		private TArray<FVector> _Vertex;

		// Token: 0x04014404 RID: 82948
		internal static int __PropertyOffset_10;

		// Token: 0x04014405 RID: 82949
		private TArray<FVector2D> _UV;

		// Token: 0x04014406 RID: 82950
		internal static int __PropertyOffset_11;

		// Token: 0x04014407 RID: 82951
		private TArray<int> _Triangle;

		// Token: 0x04014408 RID: 82952
		internal static int __PropertyOffset_12;

		// Token: 0x04014409 RID: 82953
		private TArray<FVector> _Normals;

		// Token: 0x0401440A RID: 82954
		internal static int __PropertyOffset_13;

		// Token: 0x0401440B RID: 82955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProcMeshTangent> _Tangents;

		// Token: 0x0401440C RID: 82956
		internal static int __PropertyOffset_14;

		// Token: 0x0401440D RID: 82957
		internal static int __PropertyOffset_15;

		// Token: 0x0401440E RID: 82958
		internal static int __PropertyOffset_16;

		// Token: 0x0401440F RID: 82959
		internal static int __PropertyOffset_17;

		// Token: 0x04014410 RID: 82960
		internal static int __PropertyOffset_18;

		// Token: 0x04014411 RID: 82961
		internal static int __PropertyOffset_19;

		// Token: 0x04014412 RID: 82962
		private static IntPtr __IsDirty_NativeFunctionPtr;

		// Token: 0x04014413 RID: 82963
		private static IntPtr __ClearData_NativeFunctionPtr;

		// Token: 0x04014414 RID: 82964
		private static IntPtr __Construct_NativeFunctionPtr;

		// Token: 0x04014415 RID: 82965
		private static IntPtr __DrawQuad_NativeFunctionPtr;

		// Token: 0x04014416 RID: 82966
		private static IntPtr __Connect_NativeFunctionPtr;

		// Token: 0x04014417 RID: 82967
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04014418 RID: 82968
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A2A3 RID: 41635
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __IsDirty_FunctionParams
		{
			// Token: 0x04031FC7 RID: 204743
			[FieldOffset(0)]
			public bool IsDirty;
		}

		// Token: 0x0200A2A4 RID: 41636
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031FC8 RID: 204744
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A2A5 RID: 41637
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031FC9 RID: 204745
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
