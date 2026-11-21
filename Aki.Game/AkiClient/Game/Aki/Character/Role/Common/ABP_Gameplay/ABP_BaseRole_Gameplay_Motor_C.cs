using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x020032AB RID: 12971
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C")]
	[UnrealStructLayout(8112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 8105)]
	public class ABP_BaseRole_Gameplay_Motor_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209E7 RID: 133607 RVA: 0x0094B118 File Offset: 0x00949318
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Motor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C");
			}
			return ABP_BaseRole_Gameplay_Motor_C._ClassPtr;
		}

		// Token: 0x060209E8 RID: 133608 RVA: 0x0094B13C File Offset: 0x0094933C
		public ABP_BaseRole_Gameplay_Motor_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Motor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209E9 RID: 133609 RVA: 0x0094B164 File Offset: 0x00949364
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Motor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Motor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x060209EA RID: 133610 RVA: 0x0094B197 File Offset: 0x00949397
		// (set) Token: 0x060209EB RID: 133611 RVA: 0x0094B1A7 File Offset: 0x009493A7
		public unsafe int VehicleEntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_VehicleEntityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_VehicleEntityId) = value;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x060209EC RID: 133612 RVA: 0x0094B1B8 File Offset: 0x009493B8
		// (set) Token: 0x060209ED RID: 133613 RVA: 0x0094B1F1 File Offset: 0x009493F1
		[Nullable(1)]
		public TArray<float> 撞击混合
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._撞击混合) == null)
				{
					result = (this._撞击混合 = new TArray<float>(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_撞击混合, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.撞击混合.CopyAssign(value);
			}
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x060209EE RID: 133614 RVA: 0x0094B1FF File Offset: 0x009493FF
		// (set) Token: 0x060209EF RID: 133615 RVA: 0x0094B20F File Offset: 0x0094940F
		public unsafe float 撞击倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_撞击倒计时);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_撞击倒计时) = value;
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x060209F0 RID: 133616 RVA: 0x0094B220 File Offset: 0x00949420
		// (set) Token: 0x060209F1 RID: 133617 RVA: 0x0094B234 File Offset: 0x00949434
		[Nullable(2)]
		public unsafe AActor Vehicle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_Vehicle);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_Vehicle, value);
			}
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x060209F2 RID: 133618 RVA: 0x0094B249 File Offset: 0x00949449
		// (set) Token: 0x060209F3 RID: 133619 RVA: 0x0094B25D File Offset: 0x0094945D
		[Nullable(2)]
		public unsafe TsBaseCharacter 角色蓝图
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_角色蓝图);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_角色蓝图, value);
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x060209F4 RID: 133620 RVA: 0x0094B272 File Offset: 0x00949472
		// (set) Token: 0x060209F5 RID: 133621 RVA: 0x0094B282 File Offset: 0x00949482
		public unsafe bool 禁用碰撞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_禁用碰撞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Motor_C.__PropertyOffset_禁用碰撞) = (value ? 1 : 0);
			}
		}

		// Token: 0x060209F6 RID: 133622 RVA: 0x0094B294 File Offset: 0x00949494
		[SkipLocalsInit]
		public unsafe virtual void 去掉HitNormal的Down(FVector HitNormal, ref FVector Result)
		{
			ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams[(UIntPtr)99] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitNormal = HitNormal;
			ptr->Result = Result;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__去掉HitNormal的Down_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
		}

		// Token: 0x060209F7 RID: 133623 RVA: 0x0094B2F4 File Offset: 0x009494F4
		[SkipLocalsInit]
		public unsafe virtual void 计算碰撞反馈(float DeltaTime)
		{
			ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__计算碰撞反馈_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209F8 RID: 133624 RVA: 0x0094B340 File Offset: 0x00949540
		[SkipLocalsInit]
		public unsafe virtual void SetVehicle(int entityId)
		{
			ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->entityId = entityId;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__SetVehicle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209F9 RID: 133625 RVA: 0x0094B388 File Offset: 0x00949588
		[SkipLocalsInit]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209FA RID: 133626 RVA: 0x0094B3D0 File Offset: 0x009495D0
		[SkipLocalsInit]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060209FB RID: 133627 RVA: 0x0094B416 File Offset: 0x00949616
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060209FC RID: 133628 RVA: 0x0094B42A File Offset: 0x0094962A
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Motor_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x060209FD RID: 133629 RVA: 0x0094B43E File Offset: 0x0094963E
		protected ABP_BaseRole_Gameplay_Motor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A3D RID: 72253
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Motor.ABP_BaseRole_Gameplay_Motor_C";

		// Token: 0x04011A3E RID: 72254
		private static IntPtr _ClassPtr;

		// Token: 0x04011A3F RID: 72255
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A40 RID: 72256
		internal static int __PropertyOffset_VehicleEntityId;

		// Token: 0x04011A41 RID: 72257
		internal static int __PropertyOffset_撞击混合;

		// Token: 0x04011A42 RID: 72258
		[Nullable(2)]
		private TArray<float> _撞击混合;

		// Token: 0x04011A43 RID: 72259
		internal static int __PropertyOffset_撞击倒计时;

		// Token: 0x04011A44 RID: 72260
		internal static int __PropertyOffset_Vehicle;

		// Token: 0x04011A45 RID: 72261
		internal static int __PropertyOffset_角色蓝图;

		// Token: 0x04011A46 RID: 72262
		internal static int __PropertyOffset_禁用碰撞;

		// Token: 0x04011A47 RID: 72263
		private static IntPtr __去掉HitNormal的Down_NativeFunctionPtr;

		// Token: 0x04011A48 RID: 72264
		private static IntPtr __计算碰撞反馈_NativeFunctionPtr;

		// Token: 0x04011A49 RID: 72265
		private static IntPtr __SetVehicle_NativeFunctionPtr;

		// Token: 0x04011A4A RID: 72266
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x04011A4B RID: 72267
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x02008F96 RID: 36758
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 84)]
		protected ref struct __去掉HitNormal的Down_FunctionParams
		{
			// Token: 0x0402CD35 RID: 183605
			[FieldOffset(0)]
			public FVector HitNormal;

			// Token: 0x0402CD36 RID: 183606
			[FieldOffset(12)]
			public FVector Result;
		}

		// Token: 0x02008F97 RID: 36759
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __计算碰撞反馈_FunctionParams
		{
			// Token: 0x0402CD37 RID: 183607
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008F98 RID: 36760
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetVehicle_FunctionParams
		{
			// Token: 0x0402CD38 RID: 183608
			[FieldOffset(0)]
			public int entityId;
		}

		// Token: 0x02008F99 RID: 36761
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x0402CD39 RID: 183609
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
