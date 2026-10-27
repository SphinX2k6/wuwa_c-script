using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.GamePlay.Portal;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004153 RID: 16723
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway_Motor.GA_Role_FixHook_Cableway_Motor_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1745)]
	public class GA_Role_FixHook_Cableway_Motor_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B24D RID: 176717 RVA: 0x009F7188 File Offset: 0x009F5388
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_FixHook_Cableway_Motor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway_Motor.GA_Role_FixHook_Cableway_Motor_C");
			}
			return GA_Role_FixHook_Cableway_Motor_C._ClassPtr;
		}

		// Token: 0x0602B24E RID: 176718 RVA: 0x009F71AC File Offset: 0x009F53AC
		public GA_Role_FixHook_Cableway_Motor_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Cableway_Motor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B24F RID: 176719 RVA: 0x009F71D4 File Offset: 0x009F53D4
		[NullableContext(1)]
		public GA_Role_FixHook_Cableway_Motor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Cableway_Motor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A47 RID: 27207
		// (get) Token: 0x0602B250 RID: 176720 RVA: 0x009F7207 File Offset: 0x009F5407
		// (set) Token: 0x0602B251 RID: 176721 RVA: 0x009F721B File Offset: 0x009F541B
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A48 RID: 27208
		// (get) Token: 0x0602B252 RID: 176722 RVA: 0x009F7230 File Offset: 0x009F5430
		// (set) Token: 0x0602B253 RID: 176723 RVA: 0x009F7244 File Offset: 0x009F5444
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A49 RID: 27209
		// (get) Token: 0x0602B254 RID: 176724 RVA: 0x009F7259 File Offset: 0x009F5459
		// (set) Token: 0x0602B255 RID: 176725 RVA: 0x009F726D File Offset: 0x009F546D
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A4A RID: 27210
		// (get) Token: 0x0602B256 RID: 176726 RVA: 0x009F7282 File Offset: 0x009F5482
		// (set) Token: 0x0602B257 RID: 176727 RVA: 0x009F7292 File Offset: 0x009F5492
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A4B RID: 27211
		// (get) Token: 0x0602B258 RID: 176728 RVA: 0x009F72A3 File Offset: 0x009F54A3
		// (set) Token: 0x0602B259 RID: 176729 RVA: 0x009F72B3 File Offset: 0x009F54B3
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A4C RID: 27212
		// (get) Token: 0x0602B25A RID: 176730 RVA: 0x009F72C4 File Offset: 0x009F54C4
		// (set) Token: 0x0602B25B RID: 176731 RVA: 0x009F72D8 File Offset: 0x009F54D8
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A4D RID: 27213
		// (get) Token: 0x0602B25C RID: 176732 RVA: 0x009F72F0 File Offset: 0x009F54F0
		// (set) Token: 0x0602B25D RID: 176733 RVA: 0x009F7329 File Offset: 0x009F5529
		[Nullable(1)]
		public TArray<FVectorDouble> FixHookPathways
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._FixHookPathways) == null)
				{
					result = (this._FixHookPathways = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FixHookPathways.CopyAssign(value);
			}
		}

		// Token: 0x17006A4E RID: 27214
		// (get) Token: 0x0602B25E RID: 176734 RVA: 0x009F7337 File Offset: 0x009F5537
		// (set) Token: 0x0602B25F RID: 176735 RVA: 0x009F734B File Offset: 0x009F554B
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006A4F RID: 27215
		// (get) Token: 0x0602B260 RID: 176736 RVA: 0x009F7360 File Offset: 0x009F5560
		// (set) Token: 0x0602B261 RID: 176737 RVA: 0x009F7374 File Offset: 0x009F5574
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006A50 RID: 27216
		// (get) Token: 0x0602B262 RID: 176738 RVA: 0x009F7389 File Offset: 0x009F5589
		// (set) Token: 0x0602B263 RID: 176739 RVA: 0x009F7399 File Offset: 0x009F5599
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A51 RID: 27217
		// (get) Token: 0x0602B264 RID: 176740 RVA: 0x009F73AA File Offset: 0x009F55AA
		// (set) Token: 0x0602B265 RID: 176741 RVA: 0x009F73BA File Offset: 0x009F55BA
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006A52 RID: 27218
		// (get) Token: 0x0602B266 RID: 176742 RVA: 0x009F73CB File Offset: 0x009F55CB
		// (set) Token: 0x0602B267 RID: 176743 RVA: 0x009F73DF File Offset: 0x009F55DF
		public unsafe UGameplayTask_WaitDelay Async_Task
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask_WaitDelay>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006A53 RID: 27219
		// (get) Token: 0x0602B268 RID: 176744 RVA: 0x009F73F4 File Offset: 0x009F55F4
		// (set) Token: 0x0602B269 RID: 176745 RVA: 0x009F7408 File Offset: 0x009F5608
		public unsafe UKuroBooleanEventBinder OnCableWayMoveEndEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBooleanEventBinder>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006A54 RID: 27220
		// (get) Token: 0x0602B26A RID: 176746 RVA: 0x009F741D File Offset: 0x009F561D
		// (set) Token: 0x0602B26B RID: 176747 RVA: 0x009F742D File Offset: 0x009F562D
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006A55 RID: 27221
		// (get) Token: 0x0602B26C RID: 176748 RVA: 0x009F743E File Offset: 0x009F563E
		// (set) Token: 0x0602B26D RID: 176749 RVA: 0x009F744E File Offset: 0x009F564E
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006A56 RID: 27222
		// (get) Token: 0x0602B26E RID: 176750 RVA: 0x009F745F File Offset: 0x009F565F
		// (set) Token: 0x0602B26F RID: 176751 RVA: 0x009F7473 File Offset: 0x009F5673
		public unsafe FVectorDouble Transform_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006A57 RID: 27223
		// (get) Token: 0x0602B270 RID: 176752 RVA: 0x009F7488 File Offset: 0x009F5688
		// (set) Token: 0x0602B271 RID: 176753 RVA: 0x009F7498 File Offset: 0x009F5698
		public unsafe bool 索道被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A58 RID: 27224
		// (get) Token: 0x0602B272 RID: 176754 RVA: 0x009F74AC File Offset: 0x009F56AC
		// (set) Token: 0x0602B273 RID: 176755 RVA: 0x009F74E5 File Offset: 0x009F56E5
		[Nullable(1)]
		public FTimerHandle TimerHandler
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._TimerHandler) == null)
				{
					result = (this._TimerHandler = new FTimerHandle(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_18, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A59 RID: 27225
		// (get) Token: 0x0602B274 RID: 176756 RVA: 0x009F7506 File Offset: 0x009F5706
		// (set) Token: 0x0602B275 RID: 176757 RVA: 0x009F751A File Offset: 0x009F571A
		public unsafe FVectorDouble PreviousLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006A5A RID: 27226
		// (get) Token: 0x0602B276 RID: 176758 RVA: 0x009F752F File Offset: 0x009F572F
		// (set) Token: 0x0602B277 RID: 176759 RVA: 0x009F753F File Offset: 0x009F573F
		public unsafe int 变身特效2Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17006A5B RID: 27227
		// (get) Token: 0x0602B278 RID: 176760 RVA: 0x009F7550 File Offset: 0x009F5750
		// (set) Token: 0x0602B279 RID: 176761 RVA: 0x009F7560 File Offset: 0x009F5760
		public unsafe int 摩托钩锁ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17006A5C RID: 27228
		// (get) Token: 0x0602B27A RID: 176762 RVA: 0x009F7571 File Offset: 0x009F5771
		// (set) Token: 0x0602B27B RID: 176763 RVA: 0x009F7581 File Offset: 0x009F5781
		public unsafe bool 是否有变身材质
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_Motor_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B27C RID: 176764 RVA: 0x009F7592 File Offset: 0x009F5792
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 新增是否忽略碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__新增是否忽略碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B27D RID: 176765 RVA: 0x009F75A6 File Offset: 0x009F57A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B27E RID: 176766 RVA: 0x009F75BA File Offset: 0x009F57BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B27F RID: 176767 RVA: 0x009F75CE File Offset: 0x009F57CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B280 RID: 176768 RVA: 0x009F75E4 File Offset: 0x009F57E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual AActor FindBestHookPoint()
		{
			GA_Role_FixHook_Cableway_Motor_C.__FindBestHookPoint_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__FindBestHookPoint_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__FindBestHookPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0602B281 RID: 176769 RVA: 0x009F762E File Offset: 0x009F582E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81E3B8DF47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnTick_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B282 RID: 176770 RVA: 0x009F7642 File Offset: 0x009F5842
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81E3B8DF47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCancelled_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B283 RID: 176771 RVA: 0x009F7656 File Offset: 0x009F5856
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81E3B8DF47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnInterrupted_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B284 RID: 176772 RVA: 0x009F766A File Offset: 0x009F586A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81E3B8DF47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnBlendOut_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B285 RID: 176773 RVA: 0x009F767E File Offset: 0x009F587E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81E3B8DF47()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCompleted_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr, null);
		}

		// Token: 0x0602B286 RID: 176774 RVA: 0x009F7692 File Offset: 0x009F5892
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_47768F5446E78377499424B2FD6562F9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnFinish_47768F5446E78377499424B2FD6562F9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B287 RID: 176775 RVA: 0x009F76A6 File Offset: 0x009F58A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_47768F5446E78377499424B2FD6562F9()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnTick_47768F5446E78377499424B2FD6562F9_NativeFunctionPtr, null);
		}

		// Token: 0x0602B288 RID: 176776 RVA: 0x009F76BC File Offset: 0x009F58BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88078A1EC4(FGameplayEventData Payload)
		{
			GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_FixHook_Cableway_Motor_C.__EventReceived_18B59F5945020DB23C42FD88078A1EC4_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B289 RID: 176777 RVA: 0x009F7731 File Offset: 0x009F5931
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8169A7E71C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnTick_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28A RID: 176778 RVA: 0x009F7745 File Offset: 0x009F5945
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8169A7E71C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCancelled_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28B RID: 176779 RVA: 0x009F7759 File Offset: 0x009F5959
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8169A7E71C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnInterrupted_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28C RID: 176780 RVA: 0x009F776D File Offset: 0x009F596D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8169A7E71C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnBlendOut_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28D RID: 176781 RVA: 0x009F7781 File Offset: 0x009F5981
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8169A7E71C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCompleted_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28E RID: 176782 RVA: 0x009F7795 File Offset: 0x009F5995
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B28F RID: 176783 RVA: 0x009F77A9 File Offset: 0x009F59A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B290 RID: 176784 RVA: 0x009F77C0 File Offset: 0x009F59C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_FixHook_Cableway_Motor_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B291 RID: 176785 RVA: 0x009F7828 File Offset: 0x009F5A28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RoleTeleport(FVector Velocity)
		{
			GA_Role_FixHook_Cableway_Motor_C.__RoleTeleport_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__RoleTeleport_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__RoleTeleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B292 RID: 176786 RVA: 0x009F7870 File Offset: 0x009F5A70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnCableWayMoveEnd(bool bContent)
		{
			GA_Role_FixHook_Cableway_Motor_C.__OnCableWayMoveEnd_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__OnCableWayMoveEnd_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__OnCableWayMoveEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__OnCableWayMoveEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCableWayMoveEnd_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B293 RID: 176787 RVA: 0x009F78B8 File Offset: 0x009F5AB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B294 RID: 176788 RVA: 0x009F7900 File Offset: 0x009F5B00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B295 RID: 176789 RVA: 0x009F7947 File Offset: 0x009F5B47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B296 RID: 176790 RVA: 0x009F795B File Offset: 0x009F5B5B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCableWayEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__OnCableWayEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B297 RID: 176791 RVA: 0x009F796F File Offset: 0x009F5B6F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CableWayStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__CableWayStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B298 RID: 176792 RVA: 0x009F7983 File Offset: 0x009F5B83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayCableWableEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__PlayCableWableEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B299 RID: 176793 RVA: 0x009F7997 File Offset: 0x009F5B97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TrySaveCableLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__TrySaveCableLocation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B29A RID: 176794 RVA: 0x009F79AB File Offset: 0x009F5BAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveCableTag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_Motor_C.__RemoveCableTag_NativeFunctionPtr, null);
		}

		// Token: 0x0602B29B RID: 176795 RVA: 0x009F79BF File Offset: 0x009F5BBF
		protected GA_Role_FixHook_Cableway_Motor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401666C RID: 91756
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway_Motor.GA_Role_FixHook_Cableway_Motor_C";

		// Token: 0x0401666D RID: 91757
		private static IntPtr _ClassPtr;

		// Token: 0x0401666E RID: 91758
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401666F RID: 91759
		internal new static int __PropertyOffset_1;

		// Token: 0x04016670 RID: 91760
		internal new static int __PropertyOffset_2;

		// Token: 0x04016671 RID: 91761
		internal new static int __PropertyOffset_3;

		// Token: 0x04016672 RID: 91762
		internal static int __PropertyOffset_4;

		// Token: 0x04016673 RID: 91763
		internal static int __PropertyOffset_5;

		// Token: 0x04016674 RID: 91764
		internal static int __PropertyOffset_6;

		// Token: 0x04016675 RID: 91765
		internal static int __PropertyOffset_7;

		// Token: 0x04016676 RID: 91766
		private TArray<FVectorDouble> _FixHookPathways;

		// Token: 0x04016677 RID: 91767
		internal static int __PropertyOffset_8;

		// Token: 0x04016678 RID: 91768
		internal static int __PropertyOffset_9;

		// Token: 0x04016679 RID: 91769
		internal static int __PropertyOffset_10;

		// Token: 0x0401667A RID: 91770
		internal static int __PropertyOffset_11;

		// Token: 0x0401667B RID: 91771
		internal static int __PropertyOffset_12;

		// Token: 0x0401667C RID: 91772
		internal static int __PropertyOffset_13;

		// Token: 0x0401667D RID: 91773
		internal static int __PropertyOffset_14;

		// Token: 0x0401667E RID: 91774
		internal static int __PropertyOffset_15;

		// Token: 0x0401667F RID: 91775
		internal static int __PropertyOffset_16;

		// Token: 0x04016680 RID: 91776
		internal static int __PropertyOffset_17;

		// Token: 0x04016681 RID: 91777
		internal static int __PropertyOffset_18;

		// Token: 0x04016682 RID: 91778
		private FTimerHandle _TimerHandler;

		// Token: 0x04016683 RID: 91779
		internal static int __PropertyOffset_19;

		// Token: 0x04016684 RID: 91780
		internal static int __PropertyOffset_20;

		// Token: 0x04016685 RID: 91781
		internal static int __PropertyOffset_21;

		// Token: 0x04016686 RID: 91782
		internal static int __PropertyOffset_22;

		// Token: 0x04016687 RID: 91783
		private static IntPtr __新增是否忽略碰撞_NativeFunctionPtr;

		// Token: 0x04016688 RID: 91784
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x04016689 RID: 91785
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x0401668A RID: 91786
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x0401668B RID: 91787
		private static IntPtr __FindBestHookPoint_NativeFunctionPtr;

		// Token: 0x0401668C RID: 91788
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr;

		// Token: 0x0401668D RID: 91789
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr;

		// Token: 0x0401668E RID: 91790
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr;

		// Token: 0x0401668F RID: 91791
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr;

		// Token: 0x04016690 RID: 91792
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81E3B8DF47_NativeFunctionPtr;

		// Token: 0x04016691 RID: 91793
		private static IntPtr __OnFinish_47768F5446E78377499424B2FD6562F9_NativeFunctionPtr;

		// Token: 0x04016692 RID: 91794
		private static IntPtr __OnTick_47768F5446E78377499424B2FD6562F9_NativeFunctionPtr;

		// Token: 0x04016693 RID: 91795
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88078A1EC4_NativeFunctionPtr;

		// Token: 0x04016694 RID: 91796
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr;

		// Token: 0x04016695 RID: 91797
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr;

		// Token: 0x04016696 RID: 91798
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr;

		// Token: 0x04016697 RID: 91799
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr;

		// Token: 0x04016698 RID: 91800
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8169A7E71C_NativeFunctionPtr;

		// Token: 0x04016699 RID: 91801
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401669A RID: 91802
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x0401669B RID: 91803
		private static IntPtr __RoleTeleport_NativeFunctionPtr;

		// Token: 0x0401669C RID: 91804
		private static IntPtr __OnCableWayMoveEnd_NativeFunctionPtr;

		// Token: 0x0401669D RID: 91805
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401669E RID: 91806
		private static IntPtr __OnHookEnd_NativeFunctionPtr;

		// Token: 0x0401669F RID: 91807
		private static IntPtr __OnCableWayEnd_NativeFunctionPtr;

		// Token: 0x040166A0 RID: 91808
		private static IntPtr __CableWayStart_NativeFunctionPtr;

		// Token: 0x040166A1 RID: 91809
		private static IntPtr __PlayCableWableEnd_NativeFunctionPtr;

		// Token: 0x040166A2 RID: 91810
		private static IntPtr __TrySaveCableLocation_NativeFunctionPtr;

		// Token: 0x040166A3 RID: 91811
		private static IntPtr __RemoveCableTag_NativeFunctionPtr;

		// Token: 0x0200A48C RID: 42124
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __FindBestHookPoint_FunctionParams
		{
			// Token: 0x040322E2 RID: 205538
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200A48D RID: 42125
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88078A1EC4_FunctionParams
		{
			// Token: 0x040322E3 RID: 205539
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A48E RID: 42126
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322E4 RID: 205540
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322E5 RID: 205541
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322E6 RID: 205542
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A48F RID: 42127
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RoleTeleport_FunctionParams
		{
			// Token: 0x040322E7 RID: 205543
			[FieldOffset(0)]
			public FVector Velocity;
		}

		// Token: 0x0200A490 RID: 42128
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCableWayMoveEnd_FunctionParams
		{
			// Token: 0x040322E8 RID: 205544
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A491 RID: 42129
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322E9 RID: 205545
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
