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
	// Token: 0x02004152 RID: 16722
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway.GA_Role_FixHook_Cableway_C")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1740)]
	public class GA_Role_FixHook_Cableway_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B1FD RID: 176637 RVA: 0x009F6927 File Offset: 0x009F4B27
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_FixHook_Cableway_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway.GA_Role_FixHook_Cableway_C");
			}
			return GA_Role_FixHook_Cableway_C._ClassPtr;
		}

		// Token: 0x0602B1FE RID: 176638 RVA: 0x009F694C File Offset: 0x009F4B4C
		public GA_Role_FixHook_Cableway_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Cableway_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B1FF RID: 176639 RVA: 0x009F6974 File Offset: 0x009F4B74
		[NullableContext(1)]
		public GA_Role_FixHook_Cableway_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Cableway_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A33 RID: 27187
		// (get) Token: 0x0602B200 RID: 176640 RVA: 0x009F69A7 File Offset: 0x009F4BA7
		// (set) Token: 0x0602B201 RID: 176641 RVA: 0x009F69BB File Offset: 0x009F4BBB
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A34 RID: 27188
		// (get) Token: 0x0602B202 RID: 176642 RVA: 0x009F69D0 File Offset: 0x009F4BD0
		// (set) Token: 0x0602B203 RID: 176643 RVA: 0x009F69E4 File Offset: 0x009F4BE4
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A35 RID: 27189
		// (get) Token: 0x0602B204 RID: 176644 RVA: 0x009F69F9 File Offset: 0x009F4BF9
		// (set) Token: 0x0602B205 RID: 176645 RVA: 0x009F6A0D File Offset: 0x009F4C0D
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A36 RID: 27190
		// (get) Token: 0x0602B206 RID: 176646 RVA: 0x009F6A22 File Offset: 0x009F4C22
		// (set) Token: 0x0602B207 RID: 176647 RVA: 0x009F6A32 File Offset: 0x009F4C32
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A37 RID: 27191
		// (get) Token: 0x0602B208 RID: 176648 RVA: 0x009F6A43 File Offset: 0x009F4C43
		// (set) Token: 0x0602B209 RID: 176649 RVA: 0x009F6A53 File Offset: 0x009F4C53
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A38 RID: 27192
		// (get) Token: 0x0602B20A RID: 176650 RVA: 0x009F6A64 File Offset: 0x009F4C64
		// (set) Token: 0x0602B20B RID: 176651 RVA: 0x009F6A78 File Offset: 0x009F4C78
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A39 RID: 27193
		// (get) Token: 0x0602B20C RID: 176652 RVA: 0x009F6A90 File Offset: 0x009F4C90
		// (set) Token: 0x0602B20D RID: 176653 RVA: 0x009F6AC9 File Offset: 0x009F4CC9
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
					result = (this._FixHookPathways = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FixHookPathways.CopyAssign(value);
			}
		}

		// Token: 0x17006A3A RID: 27194
		// (get) Token: 0x0602B20E RID: 176654 RVA: 0x009F6AD7 File Offset: 0x009F4CD7
		// (set) Token: 0x0602B20F RID: 176655 RVA: 0x009F6AEB File Offset: 0x009F4CEB
		public unsafe BP_KuroPortalCapture_C FixHookEnterPortalCapture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroPortalCapture_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006A3B RID: 27195
		// (get) Token: 0x0602B210 RID: 176656 RVA: 0x009F6B00 File Offset: 0x009F4D00
		// (set) Token: 0x0602B211 RID: 176657 RVA: 0x009F6B14 File Offset: 0x009F4D14
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006A3C RID: 27196
		// (get) Token: 0x0602B212 RID: 176658 RVA: 0x009F6B29 File Offset: 0x009F4D29
		// (set) Token: 0x0602B213 RID: 176659 RVA: 0x009F6B39 File Offset: 0x009F4D39
		public unsafe bool 是否忽略碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A3D RID: 27197
		// (get) Token: 0x0602B214 RID: 176660 RVA: 0x009F6B4A File Offset: 0x009F4D4A
		// (set) Token: 0x0602B215 RID: 176661 RVA: 0x009F6B5A File Offset: 0x009F4D5A
		public unsafe int 当前角色穿透值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006A3E RID: 27198
		// (get) Token: 0x0602B216 RID: 176662 RVA: 0x009F6B6B File Offset: 0x009F4D6B
		// (set) Token: 0x0602B217 RID: 176663 RVA: 0x009F6B7F File Offset: 0x009F4D7F
		public unsafe UGameplayTask_WaitDelay Async_Task
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayTask_WaitDelay>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006A3F RID: 27199
		// (get) Token: 0x0602B218 RID: 176664 RVA: 0x009F6B94 File Offset: 0x009F4D94
		// (set) Token: 0x0602B219 RID: 176665 RVA: 0x009F6BA8 File Offset: 0x009F4DA8
		public unsafe UKuroBooleanEventBinder OnCableWayMoveEndEvent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBooleanEventBinder>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Cableway_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006A40 RID: 27200
		// (get) Token: 0x0602B21A RID: 176666 RVA: 0x009F6BBD File Offset: 0x009F4DBD
		// (set) Token: 0x0602B21B RID: 176667 RVA: 0x009F6BCD File Offset: 0x009F4DCD
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006A41 RID: 27201
		// (get) Token: 0x0602B21C RID: 176668 RVA: 0x009F6BDE File Offset: 0x009F4DDE
		// (set) Token: 0x0602B21D RID: 176669 RVA: 0x009F6BEE File Offset: 0x009F4DEE
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006A42 RID: 27202
		// (get) Token: 0x0602B21E RID: 176670 RVA: 0x009F6BFF File Offset: 0x009F4DFF
		// (set) Token: 0x0602B21F RID: 176671 RVA: 0x009F6C13 File Offset: 0x009F4E13
		public unsafe FVectorDouble Transform_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17006A43 RID: 27203
		// (get) Token: 0x0602B220 RID: 176672 RVA: 0x009F6C28 File Offset: 0x009F4E28
		// (set) Token: 0x0602B221 RID: 176673 RVA: 0x009F6C38 File Offset: 0x009F4E38
		public unsafe bool 索道被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A44 RID: 27204
		// (get) Token: 0x0602B222 RID: 176674 RVA: 0x009F6C4C File Offset: 0x009F4E4C
		// (set) Token: 0x0602B223 RID: 176675 RVA: 0x009F6C85 File Offset: 0x009F4E85
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
					result = (this._TimerHandler = new FTimerHandle(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_18, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A45 RID: 27205
		// (get) Token: 0x0602B224 RID: 176676 RVA: 0x009F6CA6 File Offset: 0x009F4EA6
		// (set) Token: 0x0602B225 RID: 176677 RVA: 0x009F6CBA File Offset: 0x009F4EBA
		public unsafe FVectorDouble PreviousLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006A46 RID: 27206
		// (get) Token: 0x0602B226 RID: 176678 RVA: 0x009F6CCF File Offset: 0x009F4ECF
		// (set) Token: 0x0602B227 RID: 176679 RVA: 0x009F6CDF File Offset: 0x009F4EDF
		public unsafe int 变身特效2Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Cableway_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602B228 RID: 176680 RVA: 0x009F6CF0 File Offset: 0x009F4EF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 新增是否忽略碰撞()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__新增是否忽略碰撞_NativeFunctionPtr, null);
		}

		// Token: 0x0602B229 RID: 176681 RVA: 0x009F6D04 File Offset: 0x009F4F04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B22A RID: 176682 RVA: 0x009F6D18 File Offset: 0x009F4F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B22B RID: 176683 RVA: 0x009F6D2C File Offset: 0x009F4F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B22C RID: 176684 RVA: 0x009F6D40 File Offset: 0x009F4F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual AActor FindBestHookPoint()
		{
			GA_Role_FixHook_Cableway_C.__FindBestHookPoint_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__FindBestHookPoint_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__FindBestHookPoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__FindBestHookPoint_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		}

		// Token: 0x0602B22D RID: 176685 RVA: 0x009F6D8C File Offset: 0x009F4F8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD886716202D(FGameplayEventData Payload)
		{
			GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Role_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD886716202D_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B22E RID: 176686 RVA: 0x009F6E01 File Offset: 0x009F5001
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E813F8A2B70()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnTick_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr, null);
		}

		// Token: 0x0602B22F RID: 176687 RVA: 0x009F6E15 File Offset: 0x009F5015
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E813F8A2B70()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCancelled_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr, null);
		}

		// Token: 0x0602B230 RID: 176688 RVA: 0x009F6E29 File Offset: 0x009F5029
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E813F8A2B70()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnInterrupted_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr, null);
		}

		// Token: 0x0602B231 RID: 176689 RVA: 0x009F6E3D File Offset: 0x009F503D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E813F8A2B70()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnBlendOut_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr, null);
		}

		// Token: 0x0602B232 RID: 176690 RVA: 0x009F6E51 File Offset: 0x009F5051
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E813F8A2B70()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCompleted_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr, null);
		}

		// Token: 0x0602B233 RID: 176691 RVA: 0x009F6E65 File Offset: 0x009F5065
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81B34355A7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnTick_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B234 RID: 176692 RVA: 0x009F6E79 File Offset: 0x009F5079
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81B34355A7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCancelled_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B235 RID: 176693 RVA: 0x009F6E8D File Offset: 0x009F508D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81B34355A7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnInterrupted_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B236 RID: 176694 RVA: 0x009F6EA1 File Offset: 0x009F50A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81B34355A7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnBlendOut_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B237 RID: 176695 RVA: 0x009F6EB5 File Offset: 0x009F50B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81B34355A7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCompleted_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B238 RID: 176696 RVA: 0x009F6EC9 File Offset: 0x009F50C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E818D471EB1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnTick_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B239 RID: 176697 RVA: 0x009F6EDD File Offset: 0x009F50DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E818D471EB1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCancelled_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23A RID: 176698 RVA: 0x009F6EF1 File Offset: 0x009F50F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E818D471EB1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnInterrupted_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23B RID: 176699 RVA: 0x009F6F05 File Offset: 0x009F5105
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E818D471EB1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnBlendOut_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23C RID: 176700 RVA: 0x009F6F19 File Offset: 0x009F5119
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E818D471EB1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCompleted_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23D RID: 176701 RVA: 0x009F6F2D File Offset: 0x009F512D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_22CE86984FEF14E805594B9A14FA8757()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnFinish_22CE86984FEF14E805594B9A14FA8757_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23E RID: 176702 RVA: 0x009F6F41 File Offset: 0x009F5141
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_22CE86984FEF14E805594B9A14FA8757()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnTick_22CE86984FEF14E805594B9A14FA8757_NativeFunctionPtr, null);
		}

		// Token: 0x0602B23F RID: 176703 RVA: 0x009F6F55 File Offset: 0x009F5155
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B240 RID: 176704 RVA: 0x009F6F69 File Offset: 0x009F5169
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B241 RID: 176705 RVA: 0x009F6F80 File Offset: 0x009F5180
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_FixHook_Cableway_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B242 RID: 176706 RVA: 0x009F6FE8 File Offset: 0x009F51E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RoleTeleport(FVector Velocity)
		{
			GA_Role_FixHook_Cableway_C.__RoleTeleport_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__RoleTeleport_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__RoleTeleport_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__RoleTeleport_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B243 RID: 176707 RVA: 0x009F7030 File Offset: 0x009F5230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnCableWayMoveEnd(bool bContent)
		{
			GA_Role_FixHook_Cableway_C.__OnCableWayMoveEnd_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__OnCableWayMoveEnd_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__OnCableWayMoveEnd_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__OnCableWayMoveEnd_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCableWayMoveEnd_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B244 RID: 176708 RVA: 0x009F7078 File Offset: 0x009F5278
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B245 RID: 176709 RVA: 0x009F70C0 File Offset: 0x009F52C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B246 RID: 176710 RVA: 0x009F7107 File Offset: 0x009F5307
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B247 RID: 176711 RVA: 0x009F711B File Offset: 0x009F531B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCableWayEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__OnCableWayEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B248 RID: 176712 RVA: 0x009F712F File Offset: 0x009F532F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CableWayStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__CableWayStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B249 RID: 176713 RVA: 0x009F7143 File Offset: 0x009F5343
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayCableWableEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__PlayCableWableEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602B24A RID: 176714 RVA: 0x009F7157 File Offset: 0x009F5357
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TrySaveCableLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__TrySaveCableLocation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B24B RID: 176715 RVA: 0x009F716B File Offset: 0x009F536B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveCableTag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Cableway_C.__RemoveCableTag_NativeFunctionPtr, null);
		}

		// Token: 0x0602B24C RID: 176716 RVA: 0x009F717F File Offset: 0x009F537F
		protected GA_Role_FixHook_Cableway_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016631 RID: 91697
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Cableway.GA_Role_FixHook_Cableway_C";

		// Token: 0x04016632 RID: 91698
		private static IntPtr _ClassPtr;

		// Token: 0x04016633 RID: 91699
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016634 RID: 91700
		internal new static int __PropertyOffset_1;

		// Token: 0x04016635 RID: 91701
		internal new static int __PropertyOffset_2;

		// Token: 0x04016636 RID: 91702
		internal new static int __PropertyOffset_3;

		// Token: 0x04016637 RID: 91703
		internal static int __PropertyOffset_4;

		// Token: 0x04016638 RID: 91704
		internal static int __PropertyOffset_5;

		// Token: 0x04016639 RID: 91705
		internal static int __PropertyOffset_6;

		// Token: 0x0401663A RID: 91706
		internal static int __PropertyOffset_7;

		// Token: 0x0401663B RID: 91707
		private TArray<FVectorDouble> _FixHookPathways;

		// Token: 0x0401663C RID: 91708
		internal static int __PropertyOffset_8;

		// Token: 0x0401663D RID: 91709
		internal static int __PropertyOffset_9;

		// Token: 0x0401663E RID: 91710
		internal static int __PropertyOffset_10;

		// Token: 0x0401663F RID: 91711
		internal static int __PropertyOffset_11;

		// Token: 0x04016640 RID: 91712
		internal static int __PropertyOffset_12;

		// Token: 0x04016641 RID: 91713
		internal static int __PropertyOffset_13;

		// Token: 0x04016642 RID: 91714
		internal static int __PropertyOffset_14;

		// Token: 0x04016643 RID: 91715
		internal static int __PropertyOffset_15;

		// Token: 0x04016644 RID: 91716
		internal static int __PropertyOffset_16;

		// Token: 0x04016645 RID: 91717
		internal static int __PropertyOffset_17;

		// Token: 0x04016646 RID: 91718
		internal static int __PropertyOffset_18;

		// Token: 0x04016647 RID: 91719
		private FTimerHandle _TimerHandler;

		// Token: 0x04016648 RID: 91720
		internal static int __PropertyOffset_19;

		// Token: 0x04016649 RID: 91721
		internal static int __PropertyOffset_20;

		// Token: 0x0401664A RID: 91722
		private static IntPtr __新增是否忽略碰撞_NativeFunctionPtr;

		// Token: 0x0401664B RID: 91723
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x0401664C RID: 91724
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x0401664D RID: 91725
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x0401664E RID: 91726
		private static IntPtr __FindBestHookPoint_NativeFunctionPtr;

		// Token: 0x0401664F RID: 91727
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD886716202D_NativeFunctionPtr;

		// Token: 0x04016650 RID: 91728
		private static IntPtr __OnTick_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr;

		// Token: 0x04016651 RID: 91729
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr;

		// Token: 0x04016652 RID: 91730
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr;

		// Token: 0x04016653 RID: 91731
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr;

		// Token: 0x04016654 RID: 91732
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E813F8A2B70_NativeFunctionPtr;

		// Token: 0x04016655 RID: 91733
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr;

		// Token: 0x04016656 RID: 91734
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr;

		// Token: 0x04016657 RID: 91735
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr;

		// Token: 0x04016658 RID: 91736
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr;

		// Token: 0x04016659 RID: 91737
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81B34355A7_NativeFunctionPtr;

		// Token: 0x0401665A RID: 91738
		private static IntPtr __OnTick_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr;

		// Token: 0x0401665B RID: 91739
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr;

		// Token: 0x0401665C RID: 91740
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr;

		// Token: 0x0401665D RID: 91741
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr;

		// Token: 0x0401665E RID: 91742
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E818D471EB1_NativeFunctionPtr;

		// Token: 0x0401665F RID: 91743
		private static IntPtr __OnFinish_22CE86984FEF14E805594B9A14FA8757_NativeFunctionPtr;

		// Token: 0x04016660 RID: 91744
		private static IntPtr __OnTick_22CE86984FEF14E805594B9A14FA8757_NativeFunctionPtr;

		// Token: 0x04016661 RID: 91745
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016662 RID: 91746
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x04016663 RID: 91747
		private static IntPtr __RoleTeleport_NativeFunctionPtr;

		// Token: 0x04016664 RID: 91748
		private static IntPtr __OnCableWayMoveEnd_NativeFunctionPtr;

		// Token: 0x04016665 RID: 91749
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016666 RID: 91750
		private static IntPtr __OnHookEnd_NativeFunctionPtr;

		// Token: 0x04016667 RID: 91751
		private static IntPtr __OnCableWayEnd_NativeFunctionPtr;

		// Token: 0x04016668 RID: 91752
		private static IntPtr __CableWayStart_NativeFunctionPtr;

		// Token: 0x04016669 RID: 91753
		private static IntPtr __PlayCableWableEnd_NativeFunctionPtr;

		// Token: 0x0401666A RID: 91754
		private static IntPtr __TrySaveCableLocation_NativeFunctionPtr;

		// Token: 0x0401666B RID: 91755
		private static IntPtr __RemoveCableTag_NativeFunctionPtr;

		// Token: 0x0200A486 RID: 42118
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __FindBestHookPoint_FunctionParams
		{
			// Token: 0x040322DA RID: 205530
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x0200A487 RID: 42119
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD886716202D_FunctionParams
		{
			// Token: 0x040322DB RID: 205531
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A488 RID: 42120
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322DC RID: 205532
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322DD RID: 205533
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322DE RID: 205534
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A489 RID: 42121
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __RoleTeleport_FunctionParams
		{
			// Token: 0x040322DF RID: 205535
			[FieldOffset(0)]
			public FVector Velocity;
		}

		// Token: 0x0200A48A RID: 42122
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnCableWayMoveEnd_FunctionParams
		{
			// Token: 0x040322E0 RID: 205536
			[FieldOffset(0)]
			public bool bContent;
		}

		// Token: 0x0200A48B RID: 42123
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322E1 RID: 205537
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
