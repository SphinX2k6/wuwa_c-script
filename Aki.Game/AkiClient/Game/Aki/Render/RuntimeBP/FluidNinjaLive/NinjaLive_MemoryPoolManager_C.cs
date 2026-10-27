using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8F RID: 15759
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_MemoryPoolManager.NinjaLive_MemoryPoolManager_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1186)]
	public class NinjaLive_MemoryPoolManager_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F77 RID: 159607 RVA: 0x00982D20 File Offset: 0x00980F20
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_MemoryPoolManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_MemoryPoolManager.NinjaLive_MemoryPoolManager_C");
			}
			return NinjaLive_MemoryPoolManager_C._ClassPtr;
		}

		// Token: 0x06026F78 RID: 159608 RVA: 0x00982D44 File Offset: 0x00980F44
		public NinjaLive_MemoryPoolManager_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_MemoryPoolManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F79 RID: 159609 RVA: 0x00982D6C File Offset: 0x00980F6C
		public NinjaLive_MemoryPoolManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_MemoryPoolManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x06026F7A RID: 159610 RVA: 0x00982D9F File Offset: 0x00980F9F
		// (set) Token: 0x06026F7B RID: 159611 RVA: 0x00982DB3 File Offset: 0x00980FB3
		[Nullable(2)]
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_MemoryPoolManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_MemoryPoolManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700558E RID: 21902
		// (get) Token: 0x06026F7C RID: 159612 RVA: 0x00982DC8 File Offset: 0x00980FC8
		// (set) Token: 0x06026F7D RID: 159613 RVA: 0x00982DDC File Offset: 0x00980FDC
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_MemoryPoolManager_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_MemoryPoolManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700558F RID: 21903
		// (get) Token: 0x06026F7E RID: 159614 RVA: 0x00982DF1 File Offset: 0x00980FF1
		// (set) Token: 0x06026F7F RID: 159615 RVA: 0x00982E01 File Offset: 0x00981001
		public unsafe bool DisableMemoryManager
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x06026F80 RID: 159616 RVA: 0x00982E12 File Offset: 0x00981012
		// (set) Token: 0x06026F81 RID: 159617 RVA: 0x00982E22 File Offset: 0x00981022
		public unsafe int AmountOfRenderTargetSetsToGenerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x06026F82 RID: 159618 RVA: 0x00982E33 File Offset: 0x00981033
		// (set) Token: 0x06026F83 RID: 159619 RVA: 0x00982E47 File Offset: 0x00981047
		[Nullable(0)]
		public unsafe TEnumAsByte<SimPrecision_Enum> Precision
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x06026F84 RID: 159620 RVA: 0x00982E5C File Offset: 0x0098105C
		// (set) Token: 0x06026F85 RID: 159621 RVA: 0x00982E6C File Offset: 0x0098106C
		public unsafe int PrecisionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005593 RID: 21907
		// (get) Token: 0x06026F86 RID: 159622 RVA: 0x00982E7D File Offset: 0x0098107D
		// (set) Token: 0x06026F87 RID: 159623 RVA: 0x00982E8D File Offset: 0x0098108D
		public unsafe int ResolutionX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005594 RID: 21908
		// (get) Token: 0x06026F88 RID: 159624 RVA: 0x00982E9E File Offset: 0x0098109E
		// (set) Token: 0x06026F89 RID: 159625 RVA: 0x00982EAE File Offset: 0x009810AE
		public unsafe int ResolutionY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005595 RID: 21909
		// (get) Token: 0x06026F8A RID: 159626 RVA: 0x00982EC0 File Offset: 0x009810C0
		// (set) Token: 0x06026F8B RID: 159627 RVA: 0x00982EF9 File Offset: 0x009810F9
		public TArray<RenderTargetListItem> R_RenderTargetsList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<RenderTargetListItem> result;
				if ((result = this._R_RenderTargetsList) == null)
				{
					result = (this._R_RenderTargetsList = new TArray<RenderTargetListItem>(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.R_RenderTargetsList.CopyAssign(value);
			}
		}

		// Token: 0x17005596 RID: 21910
		// (get) Token: 0x06026F8C RID: 159628 RVA: 0x00982F08 File Offset: 0x00981108
		// (set) Token: 0x06026F8D RID: 159629 RVA: 0x00982F41 File Offset: 0x00981141
		public TArray<RenderTargetListItem> RG_RenderTargetsList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<RenderTargetListItem> result;
				if ((result = this._RG_RenderTargetsList) == null)
				{
					result = (this._RG_RenderTargetsList = new TArray<RenderTargetListItem>(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_10, this));
				}
				return result;
			}
			set
			{
				this.RG_RenderTargetsList.CopyAssign(value);
			}
		}

		// Token: 0x17005597 RID: 21911
		// (get) Token: 0x06026F8E RID: 159630 RVA: 0x00982F50 File Offset: 0x00981150
		// (set) Token: 0x06026F8F RID: 159631 RVA: 0x00982F89 File Offset: 0x00981189
		public TArray<RenderTargetListItem> RGBA_RenderTargetsList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<RenderTargetListItem> result;
				if ((result = this._RGBA_RenderTargetsList) == null)
				{
					result = (this._RGBA_RenderTargetsList = new TArray<RenderTargetListItem>(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				this.RGBA_RenderTargetsList.CopyAssign(value);
			}
		}

		// Token: 0x17005598 RID: 21912
		// (get) Token: 0x06026F90 RID: 159632 RVA: 0x00982F97 File Offset: 0x00981197
		// (set) Token: 0x06026F91 RID: 159633 RVA: 0x00982FA7 File Offset: 0x009811A7
		public unsafe bool MMInitFinished
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005599 RID: 21913
		// (get) Token: 0x06026F92 RID: 159634 RVA: 0x00982FB8 File Offset: 0x009811B8
		// (set) Token: 0x06026F93 RID: 159635 RVA: 0x00982FC8 File Offset: 0x009811C8
		public unsafe bool PrintInitDebugMessages
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700559A RID: 21914
		// (get) Token: 0x06026F94 RID: 159636 RVA: 0x00982FD9 File Offset: 0x009811D9
		// (set) Token: 0x06026F95 RID: 159637 RVA: 0x00982FE9 File Offset: 0x009811E9
		public unsafe bool PrintRuntimeDebugMsg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700559B RID: 21915
		// (get) Token: 0x06026F96 RID: 159638 RVA: 0x00982FFA File Offset: 0x009811FA
		// (set) Token: 0x06026F97 RID: 159639 RVA: 0x0098300A File Offset: 0x0098120A
		public unsafe bool PrintRuntimeDebugMsgVerbose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700559C RID: 21916
		// (get) Token: 0x06026F98 RID: 159640 RVA: 0x0098301B File Offset: 0x0098121B
		// (set) Token: 0x06026F99 RID: 159641 RVA: 0x0098302B File Offset: 0x0098122B
		public unsafe float DebugTextLifetime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700559D RID: 21917
		// (get) Token: 0x06026F9A RID: 159642 RVA: 0x0098303C File Offset: 0x0098123C
		// (set) Token: 0x06026F9B RID: 159643 RVA: 0x0098304C File Offset: 0x0098124C
		public unsafe int ExtraRenderTargetsForDensityInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700559E RID: 21918
		// (get) Token: 0x06026F9C RID: 159644 RVA: 0x0098305D File Offset: 0x0098125D
		// (set) Token: 0x06026F9D RID: 159645 RVA: 0x0098306D File Offset: 0x0098126D
		public unsafe float MemConsumptionTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700559F RID: 21919
		// (get) Token: 0x06026F9E RID: 159646 RVA: 0x0098307E File Offset: 0x0098127E
		// (set) Token: 0x06026F9F RID: 159647 RVA: 0x0098308E File Offset: 0x0098128E
		public unsafe bool SaveDebugTextToDefaultLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A0 RID: 21920
		// (get) Token: 0x06026FA0 RID: 159648 RVA: 0x0098309F File Offset: 0x0098129F
		// (set) Token: 0x06026FA1 RID: 159649 RVA: 0x009830B3 File Offset: 0x009812B3
		public unsafe string MemAvailableMax
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_20)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_20)), value);
			}
		}

		// Token: 0x170055A1 RID: 21921
		// (get) Token: 0x06026FA2 RID: 159650 RVA: 0x009830C8 File Offset: 0x009812C8
		// (set) Token: 0x06026FA3 RID: 159651 RVA: 0x009830D8 File Offset: 0x009812D8
		public unsafe bool HalfResPressureAndDivergenceBuffers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055A2 RID: 21922
		// (get) Token: 0x06026FA4 RID: 159652 RVA: 0x009830E9 File Offset: 0x009812E9
		// (set) Token: 0x06026FA5 RID: 159653 RVA: 0x009830F9 File Offset: 0x009812F9
		public unsafe bool SimAreaClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_MemoryPoolManager_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026FA6 RID: 159654 RVA: 0x0098310C File Offset: 0x0098130C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MemCount(int NumberOfChannels, int ResolutionX, int ResolutionY)
		{
			NinjaLive_MemoryPoolManager_C.__MemCount_FunctionParams* ptr = stackalloc NinjaLive_MemoryPoolManager_C.__MemCount_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(NinjaLive_MemoryPoolManager_C.__MemCount_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_MemoryPoolManager_C.__MemCount_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NumberOfChannels = NumberOfChannels;
			ptr->ResolutionX = ResolutionX;
			ptr->ResolutionY = ResolutionY;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__MemCount_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026FA7 RID: 159655 RVA: 0x00983160 File Offset: 0x00981360
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetRenderTargetAttribs(UTextureRenderTarget2D InputPin, bool Clamping, ref UTextureRenderTarget2D RT)
		{
			NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_FunctionParams* ptr = stackalloc NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputPin = ((InputPin != null) ? InputPin.NativePtr : IntPtr.Zero);
			ptr->Clamping = Clamping;
			ref NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_FunctionParams ptr2 = ref *ptr;
			UTextureRenderTarget2D utextureRenderTarget2D = RT;
			ptr2.RT = ((utextureRenderTarget2D != null) ? utextureRenderTarget2D.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__SetRenderTargetAttribs_NativeFunctionPtr, (void*)ptr);
			RT = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ptr->RT);
		}

		// Token: 0x06026FA8 RID: 159656 RVA: 0x009831E1 File Offset: 0x009813E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026FA9 RID: 159657 RVA: 0x009831F5 File Offset: 0x009813F5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026FAA RID: 159658 RVA: 0x0098320A File Offset: 0x0098140A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026FAB RID: 159659 RVA: 0x0098321E File Offset: 0x0098141E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026FAC RID: 159660 RVA: 0x00983234 File Offset: 0x00981434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_MemoryPoolManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026FAD RID: 159661 RVA: 0x0098327C File Offset: 0x0098147C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(NinjaLive_MemoryPoolManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_MemoryPoolManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026FAE RID: 159662 RVA: 0x009832C4 File Offset: 0x009814C4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PrintMemStatus(UObject Consumer, float MemConsumption, bool TakenOrReturned)
		{
			NinjaLive_MemoryPoolManager_C.__PrintMemStatus_FunctionParams* ptr = stackalloc NinjaLive_MemoryPoolManager_C.__PrintMemStatus_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(NinjaLive_MemoryPoolManager_C.__PrintMemStatus_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_MemoryPoolManager_C.__PrintMemStatus_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Consumer = ((Consumer != null) ? Consumer.NativePtr : IntPtr.Zero);
			ptr->MemConsumption = MemConsumption;
			ptr->TakenOrReturned = TakenOrReturned;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_MemoryPoolManager_C.__PrintMemStatus_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026FAF RID: 159663 RVA: 0x00983327 File Offset: 0x00981527
		protected NinjaLive_MemoryPoolManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040139EC RID: 80364
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_MemoryPoolManager.NinjaLive_MemoryPoolManager_C";

		// Token: 0x040139ED RID: 80365
		private static IntPtr _ClassPtr;

		// Token: 0x040139EE RID: 80366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040139EF RID: 80367
		internal static int __PropertyOffset_1;

		// Token: 0x040139F0 RID: 80368
		internal static int __PropertyOffset_2;

		// Token: 0x040139F1 RID: 80369
		internal static int __PropertyOffset_3;

		// Token: 0x040139F2 RID: 80370
		internal static int __PropertyOffset_4;

		// Token: 0x040139F3 RID: 80371
		internal static int __PropertyOffset_5;

		// Token: 0x040139F4 RID: 80372
		internal static int __PropertyOffset_6;

		// Token: 0x040139F5 RID: 80373
		internal static int __PropertyOffset_7;

		// Token: 0x040139F6 RID: 80374
		internal static int __PropertyOffset_8;

		// Token: 0x040139F7 RID: 80375
		internal static int __PropertyOffset_9;

		// Token: 0x040139F8 RID: 80376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<RenderTargetListItem> _R_RenderTargetsList;

		// Token: 0x040139F9 RID: 80377
		internal static int __PropertyOffset_10;

		// Token: 0x040139FA RID: 80378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<RenderTargetListItem> _RG_RenderTargetsList;

		// Token: 0x040139FB RID: 80379
		internal static int __PropertyOffset_11;

		// Token: 0x040139FC RID: 80380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<RenderTargetListItem> _RGBA_RenderTargetsList;

		// Token: 0x040139FD RID: 80381
		internal static int __PropertyOffset_12;

		// Token: 0x040139FE RID: 80382
		internal static int __PropertyOffset_13;

		// Token: 0x040139FF RID: 80383
		internal static int __PropertyOffset_14;

		// Token: 0x04013A00 RID: 80384
		internal static int __PropertyOffset_15;

		// Token: 0x04013A01 RID: 80385
		internal static int __PropertyOffset_16;

		// Token: 0x04013A02 RID: 80386
		internal static int __PropertyOffset_17;

		// Token: 0x04013A03 RID: 80387
		internal static int __PropertyOffset_18;

		// Token: 0x04013A04 RID: 80388
		internal static int __PropertyOffset_19;

		// Token: 0x04013A05 RID: 80389
		internal static int __PropertyOffset_20;

		// Token: 0x04013A06 RID: 80390
		internal static int __PropertyOffset_21;

		// Token: 0x04013A07 RID: 80391
		internal static int __PropertyOffset_22;

		// Token: 0x04013A08 RID: 80392
		private static IntPtr __MemCount_NativeFunctionPtr;

		// Token: 0x04013A09 RID: 80393
		private static IntPtr __SetRenderTargetAttribs_NativeFunctionPtr;

		// Token: 0x04013A0A RID: 80394
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013A0B RID: 80395
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013A0C RID: 80396
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013A0D RID: 80397
		private static IntPtr __PrintMemStatus_NativeFunctionPtr;

		// Token: 0x0200A16A RID: 41322
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __MemCount_FunctionParams
		{
			// Token: 0x04031D28 RID: 204072
			[FieldOffset(0)]
			public int NumberOfChannels;

			// Token: 0x04031D29 RID: 204073
			[FieldOffset(4)]
			public int ResolutionX;

			// Token: 0x04031D2A RID: 204074
			[FieldOffset(8)]
			public int ResolutionY;
		}

		// Token: 0x0200A16B RID: 41323
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetRenderTargetAttribs_FunctionParams
		{
			// Token: 0x04031D2B RID: 204075
			[FieldOffset(0)]
			public IntPtr InputPin;

			// Token: 0x04031D2C RID: 204076
			[FieldOffset(8)]
			public bool Clamping;

			// Token: 0x04031D2D RID: 204077
			[FieldOffset(16)]
			public IntPtr RT;
		}

		// Token: 0x0200A16C RID: 41324
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D2E RID: 204078
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A16D RID: 41325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __PrintMemStatus_FunctionParams
		{
			// Token: 0x04031D2F RID: 204079
			[FieldOffset(0)]
			public IntPtr Consumer;

			// Token: 0x04031D30 RID: 204080
			[FieldOffset(8)]
			public float MemConsumption;

			// Token: 0x04031D31 RID: 204081
			[FieldOffset(12)]
			public bool TakenOrReturned;
		}
	}
}
