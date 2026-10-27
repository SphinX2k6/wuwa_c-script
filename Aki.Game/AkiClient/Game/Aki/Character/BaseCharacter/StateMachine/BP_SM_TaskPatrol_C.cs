using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004394 RID: 17300
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 54)]
	public class BP_SM_TaskPatrol_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCFA RID: 183546 RVA: 0x00A29382 File Offset: 0x00A27582
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C");
			}
			return BP_SM_TaskPatrol_C._ClassPtr;
		}

		// Token: 0x0602CCFB RID: 183547 RVA: 0x00A293A8 File Offset: 0x00A275A8
		public BP_SM_TaskPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCFC RID: 183548 RVA: 0x00A293D0 File Offset: 0x00A275D0
		[NullableContext(1)]
		public BP_SM_TaskPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070EC RID: 28908
		// (get) Token: 0x0602CCFD RID: 183549 RVA: 0x00A29403 File Offset: 0x00A27603
		// (set) Token: 0x0602CCFE RID: 183550 RVA: 0x00A29413 File Offset: 0x00A27613
		public unsafe int 移动方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070ED RID: 28909
		// (get) Token: 0x0602CCFF RID: 183551 RVA: 0x00A29424 File Offset: 0x00A27624
		// (set) Token: 0x0602CD00 RID: 183552 RVA: 0x00A29434 File Offset: 0x00A27634
		public unsafe bool 调试模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070EE RID: 28910
		// (get) Token: 0x0602CD01 RID: 183553 RVA: 0x00A29445 File Offset: 0x00A27645
		// (set) Token: 0x0602CD02 RID: 183554 RVA: 0x00A29455 File Offset: 0x00A27655
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CD03 RID: 183555 RVA: 0x00A29466 File Offset: 0x00A27666
		protected BP_SM_TaskPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A3E RID: 96830
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C";

		// Token: 0x04017A3F RID: 96831
		private static IntPtr _ClassPtr;

		// Token: 0x04017A40 RID: 96832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A41 RID: 96833
		internal static int __PropertyOffset_0;

		// Token: 0x04017A42 RID: 96834
		internal static int __PropertyOffset_1;

		// Token: 0x04017A43 RID: 96835
		internal static int __PropertyOffset_2;
	}
}
