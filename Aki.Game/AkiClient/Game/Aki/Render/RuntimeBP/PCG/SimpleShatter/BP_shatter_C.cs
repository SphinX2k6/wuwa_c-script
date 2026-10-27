using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SimpleShatter
{
	// Token: 0x02003BFC RID: 15356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/BP_shatter.BP_shatter_C")]
	[UnrealStructLayout(1848, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1841)]
	public class BP_shatter_C : ASimpleShatterActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F05 RID: 143109 RVA: 0x009165C0 File Offset: 0x009147C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_shatter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/BP_shatter.BP_shatter_C");
			}
			return BP_shatter_C._ClassPtr;
		}

		// Token: 0x06022F06 RID: 143110 RVA: 0x009165E4 File Offset: 0x009147E4
		public BP_shatter_C() : this(BuiltinUtils.AllocNativeUObject(BP_shatter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F07 RID: 143111 RVA: 0x0091660C File Offset: 0x0091480C
		public BP_shatter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_shatter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x06022F08 RID: 143112 RVA: 0x0091663F File Offset: 0x0091483F
		// (set) Token: 0x06022F09 RID: 143113 RVA: 0x00916653 File Offset: 0x00914853
		[Nullable(2)]
		public unsafe UStaticMeshComponent Cube
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x06022F0A RID: 143114 RVA: 0x00916668 File Offset: 0x00914868
		// (set) Token: 0x06022F0B RID: 143115 RVA: 0x0091667C File Offset: 0x0091487C
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x06022F0C RID: 143116 RVA: 0x00916691 File Offset: 0x00914891
		// (set) Token: 0x06022F0D RID: 143117 RVA: 0x009166A1 File Offset: 0x009148A1
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x06022F0E RID: 143118 RVA: 0x009166B2 File Offset: 0x009148B2
		// (set) Token: 0x06022F0F RID: 143119 RVA: 0x009166C6 File Offset: 0x009148C6
		[Nullable(2)]
		public unsafe UChildActorComponent editorTicker
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x06022F10 RID: 143120 RVA: 0x009166DB File Offset: 0x009148DB
		// (set) Token: 0x06022F11 RID: 143121 RVA: 0x009166EF File Offset: 0x009148EF
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x06022F12 RID: 143122 RVA: 0x00916704 File Offset: 0x00914904
		// (set) Token: 0x06022F13 RID: 143123 RVA: 0x00916718 File Offset: 0x00914918
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x06022F14 RID: 143124 RVA: 0x0091672D File Offset: 0x0091492D
		// (set) Token: 0x06022F15 RID: 143125 RVA: 0x0091673D File Offset: 0x0091493D
		public unsafe int SelectInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x06022F16 RID: 143126 RVA: 0x0091674E File Offset: 0x0091494E
		// (set) Token: 0x06022F17 RID: 143127 RVA: 0x00916762 File Offset: 0x00914962
		[Nullable(2)]
		public unsafe PD_BakedShatterToDA_C inputDA
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_BakedShatterToDA_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_8);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_shatter_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x06022F18 RID: 143128 RVA: 0x00916778 File Offset: 0x00914978
		// (set) Token: 0x06022F19 RID: 143129 RVA: 0x009167B1 File Offset: 0x009149B1
		public TArray<FTransform> SMCompoentLocalTransformArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._SMCompoentLocalTransformArr) == null)
				{
					result = (this._SMCompoentLocalTransformArr = new TArray<FTransform>(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.SMCompoentLocalTransformArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x06022F1A RID: 143130 RVA: 0x009167C0 File Offset: 0x009149C0
		// (set) Token: 0x06022F1B RID: 143131 RVA: 0x009167F9 File Offset: 0x009149F9
		public TArray<AStaticMeshActor> SMActorArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SMActorArr) == null)
				{
					result = (this._SMActorArr = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.SMActorArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x06022F1C RID: 143132 RVA: 0x00916808 File Offset: 0x00914A08
		// (set) Token: 0x06022F1D RID: 143133 RVA: 0x00916841 File Offset: 0x00914A41
		public TArray<UStaticMeshComponent> SMComponentArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._SMComponentArr) == null)
				{
					result = (this._SMComponentArr = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.SMComponentArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x06022F1E RID: 143134 RVA: 0x00916850 File Offset: 0x00914A50
		// (set) Token: 0x06022F1F RID: 143135 RVA: 0x00916889 File Offset: 0x00914A89
		public TArray<UStaticMesh> SMArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._SMArr) == null)
				{
					result = (this._SMArr = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.SMArr.CopyAssign(value);
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x06022F20 RID: 143136 RVA: 0x00916897 File Offset: 0x00914A97
		// (set) Token: 0x06022F21 RID: 143137 RVA: 0x009168A7 File Offset: 0x00914AA7
		public unsafe bool finishBuild_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x06022F22 RID: 143138 RVA: 0x009168B8 File Offset: 0x00914AB8
		// (set) Token: 0x06022F23 RID: 143139 RVA: 0x009168C8 File Offset: 0x00914AC8
		public unsafe bool shatter_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x06022F24 RID: 143140 RVA: 0x009168D9 File Offset: 0x00914AD9
		// (set) Token: 0x06022F25 RID: 143141 RVA: 0x009168E9 File Offset: 0x00914AE9
		public unsafe bool debug_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x06022F26 RID: 143142 RVA: 0x009168FC File Offset: 0x00914AFC
		// (set) Token: 0x06022F27 RID: 143143 RVA: 0x00916935 File Offset: 0x00914B35
		public TArray<int> NodeArrInt
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NodeArrInt) == null)
				{
					result = (this._NodeArrInt = new TArray<int>(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.NodeArrInt.CopyAssign(value);
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x06022F28 RID: 143144 RVA: 0x00916943 File Offset: 0x00914B43
		// (set) Token: 0x06022F29 RID: 143145 RVA: 0x00916953 File Offset: 0x00914B53
		public unsafe bool readDA_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_shatter_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022F2A RID: 143146 RVA: 0x00916964 File Offset: 0x00914B64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LoadFromDA_pure()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__LoadFromDA_pure_NativeFunctionPtr, null);
		}

		// Token: 0x06022F2B RID: 143147 RVA: 0x00916978 File Offset: 0x00914B78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void setMaterialsToChild(UStaticMeshComponent FatherComponent, AStaticMeshActor ChildActor)
		{
			BP_shatter_C.__setMaterialsToChild_FunctionParams* ptr = stackalloc BP_shatter_C.__setMaterialsToChild_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_shatter_C.__setMaterialsToChild_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_shatter_C.__setMaterialsToChild_NativeFunctionPtr, (void*)ptr, 1);
			ptr->FatherComponent = ((FatherComponent != null) ? FatherComponent.NativePtr : IntPtr.Zero);
			ptr->ChildActor = ((ChildActor != null) ? ChildActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__setMaterialsToChild_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022F2C RID: 143148 RVA: 0x009169E8 File Offset: 0x00914BE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void LoadFromDA(int ID, ref bool __)
		{
			BP_shatter_C.__LoadFromDA_FunctionParams* ptr = stackalloc BP_shatter_C.__LoadFromDA_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_shatter_C.__LoadFromDA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_shatter_C.__LoadFromDA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ID = ID;
			ptr->__ = __;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__LoadFromDA_NativeFunctionPtr, (void*)ptr);
			__ = ptr->__;
		}

		// Token: 0x06022F2D RID: 143149 RVA: 0x00916A3E File Offset: 0x00914C3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SaveAsDA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__SaveAsDA_NativeFunctionPtr, null);
		}

		// Token: 0x06022F2E RID: 143150 RVA: 0x00916A52 File Offset: 0x00914C52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Insert_Components()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__Insert_Components_NativeFunctionPtr, null);
		}

		// Token: 0x06022F2F RID: 143151 RVA: 0x00916A66 File Offset: 0x00914C66
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022F30 RID: 143152 RVA: 0x00916A7A File Offset: 0x00914C7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_shatter_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F31 RID: 143153 RVA: 0x00916A8F File Offset: 0x00914C8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022F32 RID: 143154 RVA: 0x00916AA3 File Offset: 0x00914CA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_shatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F33 RID: 143155 RVA: 0x00916AB8 File Offset: 0x00914CB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_shatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_shatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_shatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_shatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022F34 RID: 143156 RVA: 0x00916B00 File Offset: 0x00914D00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_shatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_shatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_shatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_shatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_shatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022F35 RID: 143157 RVA: 0x00916B48 File Offset: 0x00914D48
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_shatter_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_shatter_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_shatter_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_shatter_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022F36 RID: 143158 RVA: 0x00916BAB File Offset: 0x00914DAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SelectIntEvent()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__SelectIntEvent_NativeFunctionPtr, null);
		}

		// Token: 0x06022F37 RID: 143159 RVA: 0x00916BBF File Offset: 0x00914DBF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MyCustom()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__MyCustom_NativeFunctionPtr, null);
		}

		// Token: 0x06022F38 RID: 143160 RVA: 0x00916BD3 File Offset: 0x00914DD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06022F39 RID: 143161 RVA: 0x00916BE7 File Offset: 0x00914DE7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SelectEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__SelectEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x06022F3A RID: 143162 RVA: 0x00916BFB File Offset: 0x00914DFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SelectEvent2()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__SelectEvent2_NativeFunctionPtr, null);
		}

		// Token: 0x06022F3B RID: 143163 RVA: 0x00916C0F File Offset: 0x00914E0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SelectEvent3()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__SelectEvent3_NativeFunctionPtr, null);
		}

		// Token: 0x06022F3C RID: 143164 RVA: 0x00916C23 File Offset: 0x00914E23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomStartShatter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__CustomStartShatter_NativeFunctionPtr, null);
		}

		// Token: 0x06022F3D RID: 143165 RVA: 0x00916C37 File Offset: 0x00914E37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06022F3E RID: 143166 RVA: 0x00916C4B File Offset: 0x00914E4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_shatter_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F3F RID: 143167 RVA: 0x00916C60 File Offset: 0x00914E60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_shatter_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06022F40 RID: 143168 RVA: 0x00916C74 File Offset: 0x00914E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_shatter_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022F41 RID: 143169 RVA: 0x00916C89 File Offset: 0x00914E89
		protected BP_shatter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011326 RID: 70438
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/BP_shatter.BP_shatter_C";

		// Token: 0x04011327 RID: 70439
		private static IntPtr _ClassPtr;

		// Token: 0x04011328 RID: 70440
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011329 RID: 70441
		internal static int __PropertyOffset_1;

		// Token: 0x0401132A RID: 70442
		internal static int __PropertyOffset_2;

		// Token: 0x0401132B RID: 70443
		internal static int __PropertyOffset_3;

		// Token: 0x0401132C RID: 70444
		internal static int __PropertyOffset_4;

		// Token: 0x0401132D RID: 70445
		internal static int __PropertyOffset_5;

		// Token: 0x0401132E RID: 70446
		internal static int __PropertyOffset_6;

		// Token: 0x0401132F RID: 70447
		internal static int __PropertyOffset_7;

		// Token: 0x04011330 RID: 70448
		internal static int __PropertyOffset_8;

		// Token: 0x04011331 RID: 70449
		internal static int __PropertyOffset_9;

		// Token: 0x04011332 RID: 70450
		[Nullable(2)]
		private TArray<FTransform> _SMCompoentLocalTransformArr;

		// Token: 0x04011333 RID: 70451
		internal static int __PropertyOffset_10;

		// Token: 0x04011334 RID: 70452
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SMActorArr;

		// Token: 0x04011335 RID: 70453
		internal static int __PropertyOffset_11;

		// Token: 0x04011336 RID: 70454
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _SMComponentArr;

		// Token: 0x04011337 RID: 70455
		internal static int __PropertyOffset_12;

		// Token: 0x04011338 RID: 70456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _SMArr;

		// Token: 0x04011339 RID: 70457
		internal static int __PropertyOffset_13;

		// Token: 0x0401133A RID: 70458
		internal static int __PropertyOffset_14;

		// Token: 0x0401133B RID: 70459
		internal static int __PropertyOffset_15;

		// Token: 0x0401133C RID: 70460
		internal static int __PropertyOffset_16;

		// Token: 0x0401133D RID: 70461
		[Nullable(2)]
		private TArray<int> _NodeArrInt;

		// Token: 0x0401133E RID: 70462
		internal static int __PropertyOffset_17;

		// Token: 0x0401133F RID: 70463
		private static IntPtr __LoadFromDA_pure_NativeFunctionPtr;

		// Token: 0x04011340 RID: 70464
		private static IntPtr __setMaterialsToChild_NativeFunctionPtr;

		// Token: 0x04011341 RID: 70465
		private static IntPtr __LoadFromDA_NativeFunctionPtr;

		// Token: 0x04011342 RID: 70466
		private static IntPtr __SaveAsDA_NativeFunctionPtr;

		// Token: 0x04011343 RID: 70467
		private static IntPtr __Insert_Components_NativeFunctionPtr;

		// Token: 0x04011344 RID: 70468
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011345 RID: 70469
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011346 RID: 70470
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011347 RID: 70471
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04011348 RID: 70472
		private static IntPtr __SelectIntEvent_NativeFunctionPtr;

		// Token: 0x04011349 RID: 70473
		private static IntPtr __MyCustom_NativeFunctionPtr;

		// Token: 0x0401134A RID: 70474
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401134B RID: 70475
		private static IntPtr __SelectEvent1_NativeFunctionPtr;

		// Token: 0x0401134C RID: 70476
		private static IntPtr __SelectEvent2_NativeFunctionPtr;

		// Token: 0x0401134D RID: 70477
		private static IntPtr __SelectEvent3_NativeFunctionPtr;

		// Token: 0x0401134E RID: 70478
		private static IntPtr __CustomStartShatter_NativeFunctionPtr;

		// Token: 0x0401134F RID: 70479
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011350 RID: 70480
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009DF5 RID: 40437
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __setMaterialsToChild_FunctionParams
		{
			// Token: 0x04031610 RID: 202256
			[FieldOffset(0)]
			public IntPtr FatherComponent;

			// Token: 0x04031611 RID: 202257
			[FieldOffset(8)]
			public IntPtr ChildActor;
		}

		// Token: 0x02009DF6 RID: 40438
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __LoadFromDA_FunctionParams
		{
			// Token: 0x04031612 RID: 202258
			[FieldOffset(0)]
			public int ID;

			// Token: 0x04031613 RID: 202259
			[FieldOffset(4)]
			public bool __;
		}

		// Token: 0x02009DF7 RID: 40439
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031614 RID: 202260
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DF8 RID: 40440
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031615 RID: 202261
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031616 RID: 202262
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031617 RID: 202263
			[FieldOffset(32)]
			public int Id;
		}
	}
}
