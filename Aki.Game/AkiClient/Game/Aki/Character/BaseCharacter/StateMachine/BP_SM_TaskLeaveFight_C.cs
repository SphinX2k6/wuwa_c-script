using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B1 RID: 13233
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 57)]
	public class BP_SM_TaskLeaveFight_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218E6 RID: 137446 RVA: 0x00963D40 File Offset: 0x00961F40
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskLeaveFight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C");
			}
			return BP_SM_TaskLeaveFight_C._ClassPtr;
		}

		// Token: 0x060218E7 RID: 137447 RVA: 0x00963D64 File Offset: 0x00961F64
		public BP_SM_TaskLeaveFight_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskLeaveFight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218E8 RID: 137448 RVA: 0x00963D8C File Offset: 0x00961F8C
		[NullableContext(1)]
		public BP_SM_TaskLeaveFight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskLeaveFight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x060218E9 RID: 137449 RVA: 0x00963DBF File Offset: 0x00961FBF
		// (set) Token: 0x060218EA RID: 137450 RVA: 0x00963DCF File Offset: 0x00961FCF
		public unsafe int 最大停止时间超过时长直接传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_最大停止时间超过时长直接传送);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_最大停止时间超过时长直接传送) = value;
			}
		}

		// Token: 0x170044DF RID: 17631
		// (get) Token: 0x060218EB RID: 137451 RVA: 0x00963DE0 File Offset: 0x00961FE0
		// (set) Token: 0x060218EC RID: 137452 RVA: 0x00963DF0 File Offset: 0x00961FF0
		public unsafe int 脱战瞬移时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_脱战瞬移时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_脱战瞬移时间) = value;
			}
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x060218ED RID: 137453 RVA: 0x00963E01 File Offset: 0x00962001
		// (set) Token: 0x060218EE RID: 137454 RVA: 0x00963E11 File Offset: 0x00962011
		public unsafe bool 是否使用最后一个巡逻点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_是否使用最后一个巡逻点) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_是否使用最后一个巡逻点) = (value ? 1 : 0);
			}
		}

		// Token: 0x060218EF RID: 137455 RVA: 0x00963E22 File Offset: 0x00962022
		protected BP_SM_TaskLeaveFight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125A1 RID: 75169
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C";

		// Token: 0x040125A2 RID: 75170
		private static IntPtr _ClassPtr;

		// Token: 0x040125A3 RID: 75171
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125A4 RID: 75172
		internal static int __PropertyOffset_最大停止时间超过时长直接传送;

		// Token: 0x040125A5 RID: 75173
		internal static int __PropertyOffset_脱战瞬移时间;

		// Token: 0x040125A6 RID: 75174
		internal static int __PropertyOffset_是否使用最后一个巡逻点;
	}
}
