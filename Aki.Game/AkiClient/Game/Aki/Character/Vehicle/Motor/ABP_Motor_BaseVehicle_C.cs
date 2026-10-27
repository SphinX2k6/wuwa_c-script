using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004032 RID: 16434
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C")]
	[UnrealStructLayout(16320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16308)]
	public class ABP_Motor_BaseVehicle_C : UKuroAnimInstanceVehicle, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A281 RID: 172673 RVA: 0x009D7AC4 File Offset: 0x009D5CC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Motor_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C");
			}
			return ABP_Motor_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x0602A282 RID: 172674 RVA: 0x009D7AE8 File Offset: 0x009D5CE8
		public ABP_Motor_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A283 RID: 172675 RVA: 0x009D7B10 File Offset: 0x009D5D10
		[NullableContext(1)]
		public ABP_Motor_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066F3 RID: 26355
		// (get) Token: 0x0602A284 RID: 172676 RVA: 0x009D7B43 File Offset: 0x009D5D43
		// (set) Token: 0x0602A285 RID: 172677 RVA: 0x009D7B57 File Offset: 0x009D5D57
		public unsafe UKuroVehicleMovementComponent VehicleMove
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_100);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_100, value);
			}
		}

		// Token: 0x170066F4 RID: 26356
		// (get) Token: 0x0602A286 RID: 172678 RVA: 0x009D7B6C File Offset: 0x009D5D6C
		// (set) Token: 0x0602A287 RID: 172679 RVA: 0x009D7B80 File Offset: 0x009D5D80
		public unsafe FVector2D 移动混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x170066F5 RID: 26357
		// (get) Token: 0x0602A288 RID: 172680 RVA: 0x009D7B95 File Offset: 0x009D5D95
		// (set) Token: 0x0602A289 RID: 172681 RVA: 0x009D7BA5 File Offset: 0x009D5DA5
		public unsafe float 左右混合缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_102);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x170066F6 RID: 26358
		// (get) Token: 0x0602A28A RID: 172682 RVA: 0x009D7BB6 File Offset: 0x009D5DB6
		// (set) Token: 0x0602A28B RID: 172683 RVA: 0x009D7BC6 File Offset: 0x009D5DC6
		public unsafe float 左右Mix一段缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_103);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x170066F7 RID: 26359
		// (get) Token: 0x0602A28C RID: 172684 RVA: 0x009D7BD7 File Offset: 0x009D5DD7
		// (set) Token: 0x0602A28D RID: 172685 RVA: 0x009D7BE7 File Offset: 0x009D5DE7
		public unsafe float 左右Mix二段缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x170066F8 RID: 26360
		// (get) Token: 0x0602A28E RID: 172686 RVA: 0x009D7BF8 File Offset: 0x009D5DF8
		// (set) Token: 0x0602A28F RID: 172687 RVA: 0x009D7C08 File Offset: 0x009D5E08
		public unsafe bool 技能状态_定点钩索
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_105) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_105) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066F9 RID: 26361
		// (get) Token: 0x0602A290 RID: 172688 RVA: 0x009D7C1C File Offset: 0x009D5E1C
		// (set) Token: 0x0602A291 RID: 172689 RVA: 0x009D7C55 File Offset: 0x009D5E55
		[Nullable(1)]
		public TMap<int, FVector> Target_Locations
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector> result;
				if ((result = this._Target_Locations) == null)
				{
					result = (this._Target_Locations = new TMap<int, FVector>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_106, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Target_Locations.CopyAssign(value);
			}
		}

		// Token: 0x170066FA RID: 26362
		// (get) Token: 0x0602A292 RID: 172690 RVA: 0x009D7C64 File Offset: 0x009D5E64
		// (set) Token: 0x0602A293 RID: 172691 RVA: 0x009D7C9D File Offset: 0x009D5E9D
		[Nullable(1)]
		public TMap<int, float> Wheel_Speeds
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._Wheel_Speeds) == null)
				{
					result = (this._Wheel_Speeds = new TMap<int, float>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_107, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Wheel_Speeds.CopyAssign(value);
			}
		}

		// Token: 0x170066FB RID: 26363
		// (get) Token: 0x0602A294 RID: 172692 RVA: 0x009D7CAC File Offset: 0x009D5EAC
		// (set) Token: 0x0602A295 RID: 172693 RVA: 0x009D7CE5 File Offset: 0x009D5EE5
		[Nullable(1)]
		public TMap<int, float> Wheel_Accels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._Wheel_Accels) == null)
				{
					result = (this._Wheel_Accels = new TMap<int, float>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_108, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Wheel_Accels.CopyAssign(value);
			}
		}

		// Token: 0x170066FC RID: 26364
		// (get) Token: 0x0602A296 RID: 172694 RVA: 0x009D7CF3 File Offset: 0x009D5EF3
		// (set) Token: 0x0602A297 RID: 172695 RVA: 0x009D7D03 File Offset: 0x009D5F03
		public unsafe EMotorSubState 摩托运动状态
		{
			get
			{
				return (EMotorSubState)(*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_109));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_109) = (byte)value;
			}
		}

		// Token: 0x170066FD RID: 26365
		// (get) Token: 0x0602A298 RID: 172696 RVA: 0x009D7D14 File Offset: 0x009D5F14
		// (set) Token: 0x0602A299 RID: 172697 RVA: 0x009D7D24 File Offset: 0x009D5F24
		public unsafe bool 状态_冲刺
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_110) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_110) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066FE RID: 26366
		// (get) Token: 0x0602A29A RID: 172698 RVA: 0x009D7D35 File Offset: 0x009D5F35
		// (set) Token: 0x0602A29B RID: 172699 RVA: 0x009D7D45 File Offset: 0x009D5F45
		public unsafe bool 滑轨状态_滑轨移动中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_111) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_111) = (value ? 1 : 0);
			}
		}

		// Token: 0x170066FF RID: 26367
		// (get) Token: 0x0602A29C RID: 172700 RVA: 0x009D7D56 File Offset: 0x009D5F56
		// (set) Token: 0x0602A29D RID: 172701 RVA: 0x009D7D66 File Offset: 0x009D5F66
		public unsafe bool 滑轨动作状态_子弹跳
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_112) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_112) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006700 RID: 26368
		// (get) Token: 0x0602A29E RID: 172702 RVA: 0x009D7D77 File Offset: 0x009D5F77
		// (set) Token: 0x0602A29F RID: 172703 RVA: 0x009D7D87 File Offset: 0x009D5F87
		public unsafe bool 滑轨动作状态_滑行
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_113) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_113) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006701 RID: 26369
		// (get) Token: 0x0602A2A0 RID: 172704 RVA: 0x009D7D98 File Offset: 0x009D5F98
		// (set) Token: 0x0602A2A1 RID: 172705 RVA: 0x009D7DA8 File Offset: 0x009D5FA8
		public unsafe bool 滑轨动作状态_翘车头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_114) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_114) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006702 RID: 26370
		// (get) Token: 0x0602A2A2 RID: 172706 RVA: 0x009D7DB9 File Offset: 0x009D5FB9
		// (set) Token: 0x0602A2A3 RID: 172707 RVA: 0x009D7DC9 File Offset: 0x009D5FC9
		public unsafe bool 状态_地面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_115) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_115) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006703 RID: 26371
		// (get) Token: 0x0602A2A4 RID: 172708 RVA: 0x009D7DDA File Offset: 0x009D5FDA
		// (set) Token: 0x0602A2A5 RID: 172709 RVA: 0x009D7DEA File Offset: 0x009D5FEA
		public unsafe bool 状态_漂移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_116) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_116) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006704 RID: 26372
		// (get) Token: 0x0602A2A6 RID: 172710 RVA: 0x009D7DFB File Offset: 0x009D5FFB
		// (set) Token: 0x0602A2A7 RID: 172711 RVA: 0x009D7E0B File Offset: 0x009D600B
		public unsafe float 下落速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x17006705 RID: 26373
		// (get) Token: 0x0602A2A8 RID: 172712 RVA: 0x009D7E1C File Offset: 0x009D601C
		// (set) Token: 0x0602A2A9 RID: 172713 RVA: 0x009D7E30 File Offset: 0x009D6030
		public unsafe UCurveFloat 前进速度混合映射
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_118);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_118, value);
			}
		}

		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x0602A2AA RID: 172714 RVA: 0x009D7E45 File Offset: 0x009D6045
		// (set) Token: 0x0602A2AB RID: 172715 RVA: 0x009D7E55 File Offset: 0x009D6055
		public unsafe bool 第一人称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_119) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_119) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x0602A2AC RID: 172716 RVA: 0x009D7E66 File Offset: 0x009D6066
		// (set) Token: 0x0602A2AD RID: 172717 RVA: 0x009D7E76 File Offset: 0x009D6076
		public unsafe bool NeedSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_120) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_120) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x0602A2AE RID: 172718 RVA: 0x009D7E87 File Offset: 0x009D6087
		// (set) Token: 0x0602A2AF RID: 172719 RVA: 0x009D7E97 File Offset: 0x009D6097
		public unsafe bool 状态_技能下落
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_121) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_121) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006709 RID: 26377
		// (get) Token: 0x0602A2B0 RID: 172720 RVA: 0x009D7EA8 File Offset: 0x009D60A8
		// (set) Token: 0x0602A2B1 RID: 172721 RVA: 0x009D7EB8 File Offset: 0x009D60B8
		public unsafe bool 状态_滑翔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_122) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_122) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602A2B2 RID: 172722 RVA: 0x009D7ECC File Offset: 0x009D60CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 后处理层(FPoseLink InPose, ref FPoseLink 后处理层)
		{
			ABP_Motor_BaseVehicle_C.__后处理层_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__后处理层_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__后处理层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__后处理层_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->后处理层, 后处理层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__后处理层_NativeFunctionPtr, (void*)ptr);
			if (后处理层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 后处理层.NativePtr, &ptr->后处理层, 1, false);
			}
		}

		// Token: 0x0602A2B3 RID: 172723 RVA: 0x009D7F78 File Offset: 0x009D6178
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 主动作层(ref FPoseLink 主动作层)
		{
			ABP_Motor_BaseVehicle_C.__主动作层_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__主动作层_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__主动作层_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__主动作层_NativeFunctionPtr, (void*)ptr, 1);
			if (主动作层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->主动作层, 主动作层.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__主动作层_NativeFunctionPtr, (void*)ptr);
			if (主动作层 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), 主动作层.NativePtr, &ptr->主动作层, 1, false);
			}
		}

		// Token: 0x0602A2B4 RID: 172724 RVA: 0x009D8000 File Offset: 0x009D6200
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_Motor_BaseVehicle_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602A2B5 RID: 172725 RVA: 0x009D8087 File Offset: 0x009D6287
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 更新移动占比()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__更新移动占比_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2B6 RID: 172726 RVA: 0x009D809B File Offset: 0x009D629B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2B7 RID: 172727 RVA: 0x009D80B0 File Offset: 0x009D62B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A2B8 RID: 172728 RVA: 0x009D80F8 File Offset: 0x009D62F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A2B9 RID: 172729 RVA: 0x009D813F File Offset: 0x009D633F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2BA RID: 172730 RVA: 0x009D8153 File Offset: 0x009D6353
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A2BB RID: 172731 RVA: 0x009D8168 File Offset: 0x009D6368
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2BC RID: 172732 RVA: 0x009D817C File Offset: 0x009D637C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A2BD RID: 172733 RVA: 0x009D8191 File Offset: 0x009D6391
		protected ABP_Motor_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BAA RID: 89002
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C";

		// Token: 0x04015BAB RID: 89003
		private static IntPtr _ClassPtr;

		// Token: 0x04015BAC RID: 89004
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BAD RID: 89005
		internal static int __PropertyOffset_100;

		// Token: 0x04015BAE RID: 89006
		internal static int __PropertyOffset_101;

		// Token: 0x04015BAF RID: 89007
		internal static int __PropertyOffset_102;

		// Token: 0x04015BB0 RID: 89008
		internal static int __PropertyOffset_103;

		// Token: 0x04015BB1 RID: 89009
		internal static int __PropertyOffset_104;

		// Token: 0x04015BB2 RID: 89010
		internal static int __PropertyOffset_105;

		// Token: 0x04015BB3 RID: 89011
		internal static int __PropertyOffset_106;

		// Token: 0x04015BB4 RID: 89012
		private TMap<int, FVector> _Target_Locations;

		// Token: 0x04015BB5 RID: 89013
		internal static int __PropertyOffset_107;

		// Token: 0x04015BB6 RID: 89014
		private TMap<int, float> _Wheel_Speeds;

		// Token: 0x04015BB7 RID: 89015
		internal static int __PropertyOffset_108;

		// Token: 0x04015BB8 RID: 89016
		private TMap<int, float> _Wheel_Accels;

		// Token: 0x04015BB9 RID: 89017
		internal static int __PropertyOffset_109;

		// Token: 0x04015BBA RID: 89018
		internal static int __PropertyOffset_110;

		// Token: 0x04015BBB RID: 89019
		internal static int __PropertyOffset_111;

		// Token: 0x04015BBC RID: 89020
		internal static int __PropertyOffset_112;

		// Token: 0x04015BBD RID: 89021
		internal static int __PropertyOffset_113;

		// Token: 0x04015BBE RID: 89022
		internal static int __PropertyOffset_114;

		// Token: 0x04015BBF RID: 89023
		internal static int __PropertyOffset_115;

		// Token: 0x04015BC0 RID: 89024
		internal static int __PropertyOffset_116;

		// Token: 0x04015BC1 RID: 89025
		internal static int __PropertyOffset_117;

		// Token: 0x04015BC2 RID: 89026
		internal static int __PropertyOffset_118;

		// Token: 0x04015BC3 RID: 89027
		internal static int __PropertyOffset_119;

		// Token: 0x04015BC4 RID: 89028
		internal static int __PropertyOffset_120;

		// Token: 0x04015BC5 RID: 89029
		internal static int __PropertyOffset_121;

		// Token: 0x04015BC6 RID: 89030
		internal static int __PropertyOffset_122;

		// Token: 0x04015BC7 RID: 89031
		private static IntPtr __后处理层_NativeFunctionPtr;

		// Token: 0x04015BC8 RID: 89032
		private static IntPtr __主动作层_NativeFunctionPtr;

		// Token: 0x04015BC9 RID: 89033
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04015BCA RID: 89034
		private static IntPtr __更新移动占比_NativeFunctionPtr;

		// Token: 0x04015BCB RID: 89035
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x04015BCC RID: 89036
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04015BCD RID: 89037
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04015BCE RID: 89038
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x0200A341 RID: 41793
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __后处理层_FunctionParams
		{
			// Token: 0x04032104 RID: 205060
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x04032105 RID: 205061
			[FieldOffset(24)]
			public byte 后处理层;
		}

		// Token: 0x0200A342 RID: 41794
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __主动作层_FunctionParams
		{
			// Token: 0x04032106 RID: 205062
			[FieldOffset(0)]
			public byte 主动作层;
		}

		// Token: 0x0200A343 RID: 41795
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x04032107 RID: 205063
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A344 RID: 41796
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032108 RID: 205064
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
