using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B4 RID: 13236
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 54)]
	public class BP_SM_TaskPatrol_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021910 RID: 137488 RVA: 0x009640DA File Offset: 0x009622DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskPatrol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C");
			}
			return BP_SM_TaskPatrol_C._ClassPtr;
		}

		// Token: 0x06021911 RID: 137489 RVA: 0x00964100 File Offset: 0x00962300
		public BP_SM_TaskPatrol_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskPatrol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021912 RID: 137490 RVA: 0x00964128 File Offset: 0x00962328
		[NullableContext(1)]
		public BP_SM_TaskPatrol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskPatrol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044ED RID: 17645
		// (get) Token: 0x06021913 RID: 137491 RVA: 0x0096415B File Offset: 0x0096235B
		// (set) Token: 0x06021914 RID: 137492 RVA: 0x0096416B File Offset: 0x0096236B
		public unsafe int 移动方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_移动方式);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_移动方式) = value;
			}
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x06021915 RID: 137493 RVA: 0x0096417C File Offset: 0x0096237C
		// (set) Token: 0x06021916 RID: 137494 RVA: 0x0096418C File Offset: 0x0096238C
		public unsafe bool 调试模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_调试模式) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_调试模式) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x06021917 RID: 137495 RVA: 0x0096419D File Offset: 0x0096239D
		// (set) Token: 0x06021918 RID: 137496 RVA: 0x009641AD File Offset: 0x009623AD
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskPatrol_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021919 RID: 137497 RVA: 0x009641BE File Offset: 0x009623BE
		protected BP_SM_TaskPatrol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125B9 RID: 75193
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskPatrol.BP_SM_TaskPatrol_C";

		// Token: 0x040125BA RID: 75194
		private static IntPtr _ClassPtr;

		// Token: 0x040125BB RID: 75195
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125BC RID: 75196
		internal static int __PropertyOffset_移动方式;

		// Token: 0x040125BD RID: 75197
		internal static int __PropertyOffset_调试模式;

		// Token: 0x040125BE RID: 75198
		internal static int __PropertyOffset_允许打断;
	}
}
