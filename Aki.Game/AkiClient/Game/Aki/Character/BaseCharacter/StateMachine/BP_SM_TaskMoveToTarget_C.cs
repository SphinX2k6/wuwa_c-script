using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B3 RID: 13235
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_TaskMoveToTarget_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021900 RID: 137472 RVA: 0x00963F8A File Offset: 0x0096218A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskMoveToTarget_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C");
			}
			return BP_SM_TaskMoveToTarget_C._ClassPtr;
		}

		// Token: 0x06021901 RID: 137473 RVA: 0x00963FB0 File Offset: 0x009621B0
		public BP_SM_TaskMoveToTarget_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMoveToTarget_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021902 RID: 137474 RVA: 0x00963FD8 File Offset: 0x009621D8
		[NullableContext(1)]
		public BP_SM_TaskMoveToTarget_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMoveToTarget_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044E7 RID: 17639
		// (get) Token: 0x06021903 RID: 137475 RVA: 0x0096400B File Offset: 0x0096220B
		// (set) Token: 0x06021904 RID: 137476 RVA: 0x0096401B File Offset: 0x0096221B
		public unsafe int 目标类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_目标类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_目标类型) = value;
			}
		}

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x06021905 RID: 137477 RVA: 0x0096402C File Offset: 0x0096222C
		// (set) Token: 0x06021906 RID: 137478 RVA: 0x0096403C File Offset: 0x0096223C
		public unsafe int 移动方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_移动方式);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_移动方式) = value;
			}
		}

		// Token: 0x170044E9 RID: 17641
		// (get) Token: 0x06021907 RID: 137479 RVA: 0x0096404D File Offset: 0x0096224D
		// (set) Token: 0x06021908 RID: 137480 RVA: 0x0096405D File Offset: 0x0096225D
		public unsafe int 停止距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_停止距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_停止距离) = value;
			}
		}

		// Token: 0x170044EA RID: 17642
		// (get) Token: 0x06021909 RID: 137481 RVA: 0x0096406E File Offset: 0x0096226E
		// (set) Token: 0x0602190A RID: 137482 RVA: 0x0096407E File Offset: 0x0096227E
		public unsafe int 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_转向速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_转向速度) = value;
			}
		}

		// Token: 0x170044EB RID: 17643
		// (get) Token: 0x0602190B RID: 137483 RVA: 0x0096408F File Offset: 0x0096228F
		// (set) Token: 0x0602190C RID: 137484 RVA: 0x0096409F File Offset: 0x0096229F
		public unsafe bool 结束时切换走路
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_结束时切换走路) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_结束时切换走路) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044EC RID: 17644
		// (get) Token: 0x0602190D RID: 137485 RVA: 0x009640B0 File Offset: 0x009622B0
		// (set) Token: 0x0602190E RID: 137486 RVA: 0x009640C0 File Offset: 0x009622C0
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602190F RID: 137487 RVA: 0x009640D1 File Offset: 0x009622D1
		protected BP_SM_TaskMoveToTarget_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125B0 RID: 75184
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C";

		// Token: 0x040125B1 RID: 75185
		private static IntPtr _ClassPtr;

		// Token: 0x040125B2 RID: 75186
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125B3 RID: 75187
		internal static int __PropertyOffset_目标类型;

		// Token: 0x040125B4 RID: 75188
		internal static int __PropertyOffset_移动方式;

		// Token: 0x040125B5 RID: 75189
		internal static int __PropertyOffset_停止距离;

		// Token: 0x040125B6 RID: 75190
		internal static int __PropertyOffset_转向速度;

		// Token: 0x040125B7 RID: 75191
		internal static int __PropertyOffset_结束时切换走路;

		// Token: 0x040125B8 RID: 75192
		internal static int __PropertyOffset_允许打断;
	}
}
