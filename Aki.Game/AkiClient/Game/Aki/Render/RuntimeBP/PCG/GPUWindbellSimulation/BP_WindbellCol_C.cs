using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUWindbellSimulation
{
	// Token: 0x02003CA4 RID: 15524
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUWindbellSimulation/BP_WindbellCol.BP_WindbellCol_C")]
	[UnrealStructLayout(1784, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1784)]
	public class BP_WindbellCol_C : AKuroCSWindbell_set, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024722 RID: 149282 RVA: 0x0093EE68 File Offset: 0x0093D068
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WindbellCol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUWindbellSimulation/BP_WindbellCol.BP_WindbellCol_C");
			}
			return BP_WindbellCol_C._ClassPtr;
		}

		// Token: 0x06024723 RID: 149283 RVA: 0x0093EE8C File Offset: 0x0093D08C
		public BP_WindbellCol_C() : this(BuiltinUtils.AllocNativeUObject(BP_WindbellCol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024724 RID: 149284 RVA: 0x0093EEB4 File Offset: 0x0093D0B4
		[NullableContext(1)]
		public BP_WindbellCol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WindbellCol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x06024725 RID: 149285 RVA: 0x0093EEE7 File Offset: 0x0093D0E7
		// (set) Token: 0x06024726 RID: 149286 RVA: 0x0093EEFB File Offset: 0x0093D0FB
		public unsafe UChildActorComponent ChainEnd
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700471A RID: 18202
		// (get) Token: 0x06024727 RID: 149287 RVA: 0x0093EF10 File Offset: 0x0093D110
		// (set) Token: 0x06024728 RID: 149288 RVA: 0x0093EF24 File Offset: 0x0093D124
		public unsafe UChildActorComponent ChainStart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700471B RID: 18203
		// (get) Token: 0x06024729 RID: 149289 RVA: 0x0093EF39 File Offset: 0x0093D139
		// (set) Token: 0x0602472A RID: 149290 RVA: 0x0093EF4D File Offset: 0x0093D14D
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700471C RID: 18204
		// (get) Token: 0x0602472B RID: 149291 RVA: 0x0093EF62 File Offset: 0x0093D162
		// (set) Token: 0x0602472C RID: 149292 RVA: 0x0093EF76 File Offset: 0x0093D176
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x0602472D RID: 149293 RVA: 0x0093EF8B File Offset: 0x0093D18B
		// (set) Token: 0x0602472E RID: 149294 RVA: 0x0093EF9B File Offset: 0x0093D19B
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x0602472F RID: 149295 RVA: 0x0093EFAC File Offset: 0x0093D1AC
		// (set) Token: 0x06024730 RID: 149296 RVA: 0x0093EFC0 File Offset: 0x0093D1C0
		public unsafe FVector PosOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x06024731 RID: 149297 RVA: 0x0093EFD5 File Offset: 0x0093D1D5
		// (set) Token: 0x06024732 RID: 149298 RVA: 0x0093EFE5 File Offset: 0x0093D1E5
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x06024733 RID: 149299 RVA: 0x0093EFF6 File Offset: 0x0093D1F6
		// (set) Token: 0x06024734 RID: 149300 RVA: 0x0093F006 File Offset: 0x0093D206
		public unsafe bool bFadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x06024735 RID: 149301 RVA: 0x0093F018 File Offset: 0x0093D218
		// (set) Token: 0x06024736 RID: 149302 RVA: 0x0093F051 File Offset: 0x0093D251
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> Mats
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Mats) == null)
				{
					result = (this._Mats = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Mats.CopyAssign(value);
			}
		}

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x06024737 RID: 149303 RVA: 0x0093F05F File Offset: 0x0093D25F
		// (set) Token: 0x06024738 RID: 149304 RVA: 0x0093F06F File Offset: 0x0093D26F
		public unsafe bool bInit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x06024739 RID: 149305 RVA: 0x0093F080 File Offset: 0x0093D280
		// (set) Token: 0x0602473A RID: 149306 RVA: 0x0093F090 File Offset: 0x0093D290
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x0602473B RID: 149307 RVA: 0x0093F0A1 File Offset: 0x0093D2A1
		// (set) Token: 0x0602473C RID: 149308 RVA: 0x0093F0B5 File Offset: 0x0093D2B5
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x0602473D RID: 149309 RVA: 0x0093F0CA File Offset: 0x0093D2CA
		// (set) Token: 0x0602473E RID: 149310 RVA: 0x0093F0DE File Offset: 0x0093D2DE
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x0602473F RID: 149311 RVA: 0x0093F0F3 File Offset: 0x0093D2F3
		// (set) Token: 0x06024740 RID: 149312 RVA: 0x0093F107 File Offset: 0x0093D307
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x06024741 RID: 149313 RVA: 0x0093F11C File Offset: 0x0093D31C
		// (set) Token: 0x06024742 RID: 149314 RVA: 0x0093F12C File Offset: 0x0093D32C
		public unsafe bool bSaveAllData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x06024743 RID: 149315 RVA: 0x0093F13D File Offset: 0x0093D33D
		// (set) Token: 0x06024744 RID: 149316 RVA: 0x0093F14D File Offset: 0x0093D34D
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x06024745 RID: 149317 RVA: 0x0093F15E File Offset: 0x0093D35E
		// (set) Token: 0x06024746 RID: 149318 RVA: 0x0093F16E File Offset: 0x0093D36E
		public unsafe float FadeIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x06024747 RID: 149319 RVA: 0x0093F180 File Offset: 0x0093D380
		// (set) Token: 0x06024748 RID: 149320 RVA: 0x0093F1B9 File Offset: 0x0093D3B9
		[Nullable(1)]
		public TArray<AStaticMeshActor> SMarray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SMarray) == null)
				{
					result = (this._SMarray = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SMarray.CopyAssign(value);
			}
		}

		// Token: 0x1700472B RID: 18219
		// (get) Token: 0x06024749 RID: 149321 RVA: 0x0093F1C7 File Offset: 0x0093D3C7
		// (set) Token: 0x0602474A RID: 149322 RVA: 0x0093F1D7 File Offset: 0x0093D3D7
		public unsafe int GroupSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WindbellCol_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700472C RID: 18220
		// (get) Token: 0x0602474B RID: 149323 RVA: 0x0093F1E8 File Offset: 0x0093D3E8
		// (set) Token: 0x0602474C RID: 149324 RVA: 0x0093F1FC File Offset: 0x0093D3FC
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700472D RID: 18221
		// (get) Token: 0x0602474D RID: 149325 RVA: 0x0093F211 File Offset: 0x0093D411
		// (set) Token: 0x0602474E RID: 149326 RVA: 0x0093F225 File Offset: 0x0093D425
		public unsafe UMaterialInstance InputMat2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WindbellCol_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x0602474F RID: 149327 RVA: 0x0093F23C File Offset: 0x0093D43C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Re_Cal_Pos(int I_Index_, int G_Group_, int N_Particle_Count_, ref FVector NewPos)
		{
			BP_WindbellCol_C.__Re_Cal_Pos_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__Re_Cal_Pos_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_WindbellCol_C.__Re_Cal_Pos_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__Re_Cal_Pos_NativeFunctionPtr, (void*)ptr, 1);
			ptr->I_Index_ = I_Index_;
			ptr->G_Group_ = G_Group_;
			ptr->N_Particle_Count_ = N_Particle_Count_;
			ptr->NewPos = NewPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__Re_Cal_Pos_NativeFunctionPtr, (void*)ptr);
			NewPos = ptr->NewPos;
		}

		// Token: 0x06024750 RID: 149328 RVA: 0x0093F2B0 File Offset: 0x0093D4B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Is_Last(int i_index_, int G_group_, int N_particleCount_, ref int RightID)
		{
			BP_WindbellCol_C.__Is_Last_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__Is_Last_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WindbellCol_C.__Is_Last_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__Is_Last_NativeFunctionPtr, (void*)ptr, 1);
			ptr->i_index_ = i_index_;
			ptr->G_group_ = G_group_;
			ptr->N_particleCount_ = N_particleCount_;
			ptr->RightID = RightID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__Is_Last_NativeFunctionPtr, (void*)ptr);
			RightID = ptr->RightID;
		}

		// Token: 0x06024751 RID: 149329 RVA: 0x0093F318 File Offset: 0x0093D518
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Is_First(int i_index_, int G_group_, int N_particleCount_, ref int LeftID, ref int Pinned)
		{
			BP_WindbellCol_C.__Is_First_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__Is_First_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WindbellCol_C.__Is_First_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__Is_First_NativeFunctionPtr, (void*)ptr, 1);
			ptr->i_index_ = i_index_;
			ptr->G_group_ = G_group_;
			ptr->N_particleCount_ = N_particleCount_;
			ptr->LeftID = LeftID;
			ptr->Pinned = Pinned;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__Is_First_NativeFunctionPtr, (void*)ptr);
			LeftID = ptr->LeftID;
			Pinned = ptr->Pinned;
		}

		// Token: 0x06024752 RID: 149330 RVA: 0x0093F390 File Offset: 0x0093D590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitRT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__InitRT_NativeFunctionPtr, null);
		}

		// Token: 0x06024753 RID: 149331 RVA: 0x0093F3A4 File Offset: 0x0093D5A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024754 RID: 149332 RVA: 0x0093F3B8 File Offset: 0x0093D5B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x06024755 RID: 149333 RVA: 0x0093F3CC File Offset: 0x0093D5CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitMats()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__InitMats_NativeFunctionPtr, null);
		}

		// Token: 0x06024756 RID: 149334 RVA: 0x0093F3E0 File Offset: 0x0093D5E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024757 RID: 149335 RVA: 0x0093F3F4 File Offset: 0x0093D5F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindbellCol_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024758 RID: 149336 RVA: 0x0093F409 File Offset: 0x0093D609
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024759 RID: 149337 RVA: 0x0093F41D File Offset: 0x0093D61D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602475A RID: 149338 RVA: 0x0093F434 File Offset: 0x0093D634
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WindbellCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WindbellCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602475B RID: 149339 RVA: 0x0093F47C File Offset: 0x0093D67C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WindbellCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WindbellCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602475C RID: 149340 RVA: 0x0093F4C3 File Offset: 0x0093D6C3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602475D RID: 149341 RVA: 0x0093F4D8 File Offset: 0x0093D6D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602475E RID: 149342 RVA: 0x0093F594 File Offset: 0x0093D794
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602475F RID: 149343 RVA: 0x0093F620 File Offset: 0x0093D820
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024760 RID: 149344 RVA: 0x0093F66C File Offset: 0x0093D86C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WindbellCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WindbellCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WindbellCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024761 RID: 149345 RVA: 0x0093F6B8 File Offset: 0x0093D8B8
		protected BP_WindbellCol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012166 RID: 74086
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUWindbellSimulation/BP_WindbellCol.BP_WindbellCol_C";

		// Token: 0x04012167 RID: 74087
		private static IntPtr _ClassPtr;

		// Token: 0x04012168 RID: 74088
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012169 RID: 74089
		internal static int __PropertyOffset_1;

		// Token: 0x0401216A RID: 74090
		internal static int __PropertyOffset_2;

		// Token: 0x0401216B RID: 74091
		internal static int __PropertyOffset_3;

		// Token: 0x0401216C RID: 74092
		internal static int __PropertyOffset_4;

		// Token: 0x0401216D RID: 74093
		internal static int __PropertyOffset_5;

		// Token: 0x0401216E RID: 74094
		internal static int __PropertyOffset_6;

		// Token: 0x0401216F RID: 74095
		internal static int __PropertyOffset_7;

		// Token: 0x04012170 RID: 74096
		internal static int __PropertyOffset_8;

		// Token: 0x04012171 RID: 74097
		internal static int __PropertyOffset_9;

		// Token: 0x04012172 RID: 74098
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Mats;

		// Token: 0x04012173 RID: 74099
		internal static int __PropertyOffset_10;

		// Token: 0x04012174 RID: 74100
		internal static int __PropertyOffset_11;

		// Token: 0x04012175 RID: 74101
		internal static int __PropertyOffset_12;

		// Token: 0x04012176 RID: 74102
		internal static int __PropertyOffset_13;

		// Token: 0x04012177 RID: 74103
		internal static int __PropertyOffset_14;

		// Token: 0x04012178 RID: 74104
		internal static int __PropertyOffset_15;

		// Token: 0x04012179 RID: 74105
		internal static int __PropertyOffset_16;

		// Token: 0x0401217A RID: 74106
		internal static int __PropertyOffset_17;

		// Token: 0x0401217B RID: 74107
		internal static int __PropertyOffset_18;

		// Token: 0x0401217C RID: 74108
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SMarray;

		// Token: 0x0401217D RID: 74109
		internal static int __PropertyOffset_19;

		// Token: 0x0401217E RID: 74110
		internal static int __PropertyOffset_20;

		// Token: 0x0401217F RID: 74111
		internal static int __PropertyOffset_21;

		// Token: 0x04012180 RID: 74112
		private static IntPtr __Re_Cal_Pos_NativeFunctionPtr;

		// Token: 0x04012181 RID: 74113
		private static IntPtr __Is_Last_NativeFunctionPtr;

		// Token: 0x04012182 RID: 74114
		private static IntPtr __Is_First_NativeFunctionPtr;

		// Token: 0x04012183 RID: 74115
		private static IntPtr __InitRT_NativeFunctionPtr;

		// Token: 0x04012184 RID: 74116
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04012185 RID: 74117
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04012186 RID: 74118
		private static IntPtr __InitMats_NativeFunctionPtr;

		// Token: 0x04012187 RID: 74119
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012188 RID: 74120
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012189 RID: 74121
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401218A RID: 74122
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401218B RID: 74123
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401218C RID: 74124
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401218D RID: 74125
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009F21 RID: 40737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __Re_Cal_Pos_FunctionParams
		{
			// Token: 0x04031889 RID: 202889
			[FieldOffset(0)]
			public int I_Index_;

			// Token: 0x0403188A RID: 202890
			[FieldOffset(4)]
			public int G_Group_;

			// Token: 0x0403188B RID: 202891
			[FieldOffset(8)]
			public int N_Particle_Count_;

			// Token: 0x0403188C RID: 202892
			[FieldOffset(12)]
			public FVector NewPos;
		}

		// Token: 0x02009F22 RID: 40738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Is_Last_FunctionParams
		{
			// Token: 0x0403188D RID: 202893
			[FieldOffset(0)]
			public int i_index_;

			// Token: 0x0403188E RID: 202894
			[FieldOffset(4)]
			public int G_group_;

			// Token: 0x0403188F RID: 202895
			[FieldOffset(8)]
			public int N_particleCount_;

			// Token: 0x04031890 RID: 202896
			[FieldOffset(12)]
			public int RightID;
		}

		// Token: 0x02009F23 RID: 40739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Is_First_FunctionParams
		{
			// Token: 0x04031891 RID: 202897
			[FieldOffset(0)]
			public int i_index_;

			// Token: 0x04031892 RID: 202898
			[FieldOffset(4)]
			public int G_group_;

			// Token: 0x04031893 RID: 202899
			[FieldOffset(8)]
			public int N_particleCount_;

			// Token: 0x04031894 RID: 202900
			[FieldOffset(12)]
			public int LeftID;

			// Token: 0x04031895 RID: 202901
			[FieldOffset(16)]
			public int Pinned;
		}

		// Token: 0x02009F24 RID: 40740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031896 RID: 202902
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F25 RID: 40741
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031897 RID: 202903
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031898 RID: 202904
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031899 RID: 202905
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403189A RID: 202906
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403189B RID: 202907
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403189C RID: 202908
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F26 RID: 40742
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403189D RID: 202909
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403189E RID: 202910
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403189F RID: 202911
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318A0 RID: 202912
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F27 RID: 40743
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040318A1 RID: 202913
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
