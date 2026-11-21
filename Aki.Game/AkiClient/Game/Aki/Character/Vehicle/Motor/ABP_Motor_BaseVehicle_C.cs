using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x0200328B RID: 12939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C")]
	[UnrealStructLayout(16336, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 16324)]
	public class ABP_Motor_BaseVehicle_C : UKuroAnimInstanceVehicle, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205F1 RID: 132593 RVA: 0x00944A87 File Offset: 0x00942C87
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_Motor_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C");
			}
			return ABP_Motor_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x060205F2 RID: 132594 RVA: 0x00944AAC File Offset: 0x00942CAC
		public ABP_Motor_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205F3 RID: 132595 RVA: 0x00944AD4 File Offset: 0x00942CD4
		public ABP_Motor_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_Motor_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x060205F4 RID: 132596 RVA: 0x00944B07 File Offset: 0x00942D07
		// (set) Token: 0x060205F5 RID: 132597 RVA: 0x00944B1B File Offset: 0x00942D1B
		[Nullable(2)]
		public unsafe UKuroVehicleMovementComponent VehicleMove
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_VehicleMove);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_VehicleMove, value);
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x060205F6 RID: 132598 RVA: 0x00944B30 File Offset: 0x00942D30
		// (set) Token: 0x060205F7 RID: 132599 RVA: 0x00944B44 File Offset: 0x00942D44
		public unsafe FVector2D 移动混合
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_移动混合);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_移动混合) = value;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x060205F8 RID: 132600 RVA: 0x00944B59 File Offset: 0x00942D59
		// (set) Token: 0x060205F9 RID: 132601 RVA: 0x00944B69 File Offset: 0x00942D69
		public unsafe float 左右混合缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右混合缓冲);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右混合缓冲) = value;
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x060205FA RID: 132602 RVA: 0x00944B7A File Offset: 0x00942D7A
		// (set) Token: 0x060205FB RID: 132603 RVA: 0x00944B8A File Offset: 0x00942D8A
		public unsafe float 左右Mix一段缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右Mix一段缓冲);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右Mix一段缓冲) = value;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x060205FC RID: 132604 RVA: 0x00944B9B File Offset: 0x00942D9B
		// (set) Token: 0x060205FD RID: 132605 RVA: 0x00944BAB File Offset: 0x00942DAB
		public unsafe float 左右Mix二段缓冲
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右Mix二段缓冲);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_左右Mix二段缓冲) = value;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x060205FE RID: 132606 RVA: 0x00944BBC File Offset: 0x00942DBC
		// (set) Token: 0x060205FF RID: 132607 RVA: 0x00944BCC File Offset: 0x00942DCC
		public unsafe bool 技能状态_定点钩索
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_技能状态_定点钩索) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_技能状态_定点钩索) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x06020600 RID: 132608 RVA: 0x00944BE0 File Offset: 0x00942DE0
		// (set) Token: 0x06020601 RID: 132609 RVA: 0x00944C19 File Offset: 0x00942E19
		public TMap<int, FVector> Target_Locations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FVector> result;
				if ((result = this._Target_Locations) == null)
				{
					result = (this._Target_Locations = new TMap<int, FVector>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_Target_Locations, this));
				}
				return result;
			}
			set
			{
				this.Target_Locations.CopyAssign(value);
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x06020602 RID: 132610 RVA: 0x00944C28 File Offset: 0x00942E28
		// (set) Token: 0x06020603 RID: 132611 RVA: 0x00944C61 File Offset: 0x00942E61
		public TMap<int, float> Wheel_Speeds
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._Wheel_Speeds) == null)
				{
					result = (this._Wheel_Speeds = new TMap<int, float>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_Wheel_Speeds, this));
				}
				return result;
			}
			set
			{
				this.Wheel_Speeds.CopyAssign(value);
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x06020604 RID: 132612 RVA: 0x00944C70 File Offset: 0x00942E70
		// (set) Token: 0x06020605 RID: 132613 RVA: 0x00944CA9 File Offset: 0x00942EA9
		public TMap<int, float> Wheel_Accels
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._Wheel_Accels) == null)
				{
					result = (this._Wheel_Accels = new TMap<int, float>(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_Wheel_Accels, this));
				}
				return result;
			}
			set
			{
				this.Wheel_Accels.CopyAssign(value);
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x06020606 RID: 132614 RVA: 0x00944CB7 File Offset: 0x00942EB7
		// (set) Token: 0x06020607 RID: 132615 RVA: 0x00944CC7 File Offset: 0x00942EC7
		public unsafe EMotorSubState 摩托运动状态
		{
			get
			{
				return (EMotorSubState)(*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_摩托运动状态));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_摩托运动状态) = (byte)value;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x06020608 RID: 132616 RVA: 0x00944CD8 File Offset: 0x00942ED8
		// (set) Token: 0x06020609 RID: 132617 RVA: 0x00944CE8 File Offset: 0x00942EE8
		public unsafe bool 状态_冲刺
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_冲刺) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_冲刺) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0602060A RID: 132618 RVA: 0x00944CF9 File Offset: 0x00942EF9
		// (set) Token: 0x0602060B RID: 132619 RVA: 0x00944D09 File Offset: 0x00942F09
		public unsafe bool 滑轨状态_滑轨移动中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨状态_滑轨移动中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨状态_滑轨移动中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0602060C RID: 132620 RVA: 0x00944D1A File Offset: 0x00942F1A
		// (set) Token: 0x0602060D RID: 132621 RVA: 0x00944D2A File Offset: 0x00942F2A
		public unsafe bool 滑轨动作状态_子弹跳
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_子弹跳) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_子弹跳) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0602060E RID: 132622 RVA: 0x00944D3B File Offset: 0x00942F3B
		// (set) Token: 0x0602060F RID: 132623 RVA: 0x00944D4B File Offset: 0x00942F4B
		public unsafe bool 滑轨动作状态_滑行
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_滑行) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_滑行) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x06020610 RID: 132624 RVA: 0x00944D5C File Offset: 0x00942F5C
		// (set) Token: 0x06020611 RID: 132625 RVA: 0x00944D6C File Offset: 0x00942F6C
		public unsafe bool 滑轨动作状态_翘车头
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_翘车头) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_滑轨动作状态_翘车头) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x06020612 RID: 132626 RVA: 0x00944D7D File Offset: 0x00942F7D
		// (set) Token: 0x06020613 RID: 132627 RVA: 0x00944D8D File Offset: 0x00942F8D
		public unsafe bool 状态_地面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_地面) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_地面) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x06020614 RID: 132628 RVA: 0x00944D9E File Offset: 0x00942F9E
		// (set) Token: 0x06020615 RID: 132629 RVA: 0x00944DAE File Offset: 0x00942FAE
		public unsafe bool 状态_漂移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_漂移) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_漂移) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06020616 RID: 132630 RVA: 0x00944DBF File Offset: 0x00942FBF
		// (set) Token: 0x06020617 RID: 132631 RVA: 0x00944DCF File Offset: 0x00942FCF
		public unsafe float 下落速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_下落速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_下落速度) = value;
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06020618 RID: 132632 RVA: 0x00944DE0 File Offset: 0x00942FE0
		// (set) Token: 0x06020619 RID: 132633 RVA: 0x00944DF4 File Offset: 0x00942FF4
		[Nullable(2)]
		public unsafe UCurveFloat 前进速度混合映射
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_前进速度混合映射);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_Motor_BaseVehicle_C.__PropertyOffset_前进速度混合映射, value);
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0602061A RID: 132634 RVA: 0x00944E09 File Offset: 0x00943009
		// (set) Token: 0x0602061B RID: 132635 RVA: 0x00944E19 File Offset: 0x00943019
		public unsafe bool 第一人称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_第一人称) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_第一人称) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0602061C RID: 132636 RVA: 0x00944E2A File Offset: 0x0094302A
		// (set) Token: 0x0602061D RID: 132637 RVA: 0x00944E3A File Offset: 0x0094303A
		public unsafe bool NeedSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_NeedSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_NeedSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x0602061E RID: 132638 RVA: 0x00944E4B File Offset: 0x0094304B
		// (set) Token: 0x0602061F RID: 132639 RVA: 0x00944E5B File Offset: 0x0094305B
		public unsafe bool 状态_技能下落
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_技能下落) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_技能下落) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06020620 RID: 132640 RVA: 0x00944E6C File Offset: 0x0094306C
		// (set) Token: 0x06020621 RID: 132641 RVA: 0x00944E7C File Offset: 0x0094307C
		public unsafe bool 状态_滑翔
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_滑翔) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_Motor_BaseVehicle_C.__PropertyOffset_状态_滑翔) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020622 RID: 132642 RVA: 0x00944E8D File Offset: 0x0094308D
		[SkipLocalsInit]
		public virtual void 更新移动占比()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__更新移动占比_NativeFunctionPtr, null);
		}

		// Token: 0x06020623 RID: 132643 RVA: 0x00944EA1 File Offset: 0x009430A1
		[SkipLocalsInit]
		public virtual void 初始化Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__初始化Tag_NativeFunctionPtr, null);
		}

		// Token: 0x06020624 RID: 132644 RVA: 0x00944EB8 File Offset: 0x009430B8
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020625 RID: 132645 RVA: 0x00944F00 File Offset: 0x00943100
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020626 RID: 132646 RVA: 0x00944F46 File Offset: 0x00943146
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020627 RID: 132647 RVA: 0x00944F5A File Offset: 0x0094315A
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020628 RID: 132648 RVA: 0x00944F6E File Offset: 0x0094316E
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020629 RID: 132649 RVA: 0x00944F82 File Offset: 0x00943182
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_Motor_BaseVehicle_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602062A RID: 132650 RVA: 0x00944F96 File Offset: 0x00943196
		protected ABP_Motor_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117B6 RID: 71606
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/ABP_Motor_BaseVehicle.ABP_Motor_BaseVehicle_C";

		// Token: 0x040117B7 RID: 71607
		private static IntPtr _ClassPtr;

		// Token: 0x040117B8 RID: 71608
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117B9 RID: 71609
		internal static int __PropertyOffset_VehicleMove;

		// Token: 0x040117BA RID: 71610
		internal static int __PropertyOffset_移动混合;

		// Token: 0x040117BB RID: 71611
		internal static int __PropertyOffset_左右混合缓冲;

		// Token: 0x040117BC RID: 71612
		internal static int __PropertyOffset_左右Mix一段缓冲;

		// Token: 0x040117BD RID: 71613
		internal static int __PropertyOffset_左右Mix二段缓冲;

		// Token: 0x040117BE RID: 71614
		internal static int __PropertyOffset_技能状态_定点钩索;

		// Token: 0x040117BF RID: 71615
		internal static int __PropertyOffset_Target_Locations;

		// Token: 0x040117C0 RID: 71616
		[Nullable(2)]
		private TMap<int, FVector> _Target_Locations;

		// Token: 0x040117C1 RID: 71617
		internal static int __PropertyOffset_Wheel_Speeds;

		// Token: 0x040117C2 RID: 71618
		[Nullable(2)]
		private TMap<int, float> _Wheel_Speeds;

		// Token: 0x040117C3 RID: 71619
		internal static int __PropertyOffset_Wheel_Accels;

		// Token: 0x040117C4 RID: 71620
		[Nullable(2)]
		private TMap<int, float> _Wheel_Accels;

		// Token: 0x040117C5 RID: 71621
		internal static int __PropertyOffset_摩托运动状态;

		// Token: 0x040117C6 RID: 71622
		internal static int __PropertyOffset_状态_冲刺;

		// Token: 0x040117C7 RID: 71623
		internal static int __PropertyOffset_滑轨状态_滑轨移动中;

		// Token: 0x040117C8 RID: 71624
		internal static int __PropertyOffset_滑轨动作状态_子弹跳;

		// Token: 0x040117C9 RID: 71625
		internal static int __PropertyOffset_滑轨动作状态_滑行;

		// Token: 0x040117CA RID: 71626
		internal static int __PropertyOffset_滑轨动作状态_翘车头;

		// Token: 0x040117CB RID: 71627
		internal static int __PropertyOffset_状态_地面;

		// Token: 0x040117CC RID: 71628
		internal static int __PropertyOffset_状态_漂移;

		// Token: 0x040117CD RID: 71629
		internal static int __PropertyOffset_下落速度;

		// Token: 0x040117CE RID: 71630
		internal static int __PropertyOffset_前进速度混合映射;

		// Token: 0x040117CF RID: 71631
		internal static int __PropertyOffset_第一人称;

		// Token: 0x040117D0 RID: 71632
		internal static int __PropertyOffset_NeedSimulate;

		// Token: 0x040117D1 RID: 71633
		internal static int __PropertyOffset_状态_技能下落;

		// Token: 0x040117D2 RID: 71634
		internal static int __PropertyOffset_状态_滑翔;

		// Token: 0x040117D3 RID: 71635
		private static IntPtr __更新移动占比_NativeFunctionPtr;

		// Token: 0x040117D4 RID: 71636
		private static IntPtr __初始化Tag_NativeFunctionPtr;

		// Token: 0x040117D5 RID: 71637
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x040117D6 RID: 71638
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x040117D7 RID: 71639
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x02008F59 RID: 36697
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CCCD RID: 183501
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
