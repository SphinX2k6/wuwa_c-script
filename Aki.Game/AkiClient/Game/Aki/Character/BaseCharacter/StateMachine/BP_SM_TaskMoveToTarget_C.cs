using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004393 RID: 17299
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 66)]
	public class BP_SM_TaskMoveToTarget_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCEA RID: 183530 RVA: 0x00A29232 File Offset: 0x00A27432
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskMoveToTarget_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C");
			}
			return BP_SM_TaskMoveToTarget_C._ClassPtr;
		}

		// Token: 0x0602CCEB RID: 183531 RVA: 0x00A29258 File Offset: 0x00A27458
		public BP_SM_TaskMoveToTarget_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMoveToTarget_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCEC RID: 183532 RVA: 0x00A29280 File Offset: 0x00A27480
		[NullableContext(1)]
		public BP_SM_TaskMoveToTarget_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMoveToTarget_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070E6 RID: 28902
		// (get) Token: 0x0602CCED RID: 183533 RVA: 0x00A292B3 File Offset: 0x00A274B3
		// (set) Token: 0x0602CCEE RID: 183534 RVA: 0x00A292C3 File Offset: 0x00A274C3
		public unsafe int 目标类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070E7 RID: 28903
		// (get) Token: 0x0602CCEF RID: 183535 RVA: 0x00A292D4 File Offset: 0x00A274D4
		// (set) Token: 0x0602CCF0 RID: 183536 RVA: 0x00A292E4 File Offset: 0x00A274E4
		public unsafe int 移动方式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070E8 RID: 28904
		// (get) Token: 0x0602CCF1 RID: 183537 RVA: 0x00A292F5 File Offset: 0x00A274F5
		// (set) Token: 0x0602CCF2 RID: 183538 RVA: 0x00A29305 File Offset: 0x00A27505
		public unsafe int 停止距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170070E9 RID: 28905
		// (get) Token: 0x0602CCF3 RID: 183539 RVA: 0x00A29316 File Offset: 0x00A27516
		// (set) Token: 0x0602CCF4 RID: 183540 RVA: 0x00A29326 File Offset: 0x00A27526
		public unsafe int 转向速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170070EA RID: 28906
		// (get) Token: 0x0602CCF5 RID: 183541 RVA: 0x00A29337 File Offset: 0x00A27537
		// (set) Token: 0x0602CCF6 RID: 183542 RVA: 0x00A29347 File Offset: 0x00A27547
		public unsafe bool 结束时切换走路
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070EB RID: 28907
		// (get) Token: 0x0602CCF7 RID: 183543 RVA: 0x00A29358 File Offset: 0x00A27558
		// (set) Token: 0x0602CCF8 RID: 183544 RVA: 0x00A29368 File Offset: 0x00A27568
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMoveToTarget_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CCF9 RID: 183545 RVA: 0x00A29379 File Offset: 0x00A27579
		protected BP_SM_TaskMoveToTarget_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A35 RID: 96821
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMoveToTarget.BP_SM_TaskMoveToTarget_C";

		// Token: 0x04017A36 RID: 96822
		private static IntPtr _ClassPtr;

		// Token: 0x04017A37 RID: 96823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A38 RID: 96824
		internal static int __PropertyOffset_0;

		// Token: 0x04017A39 RID: 96825
		internal static int __PropertyOffset_1;

		// Token: 0x04017A3A RID: 96826
		internal static int __PropertyOffset_2;

		// Token: 0x04017A3B RID: 96827
		internal static int __PropertyOffset_3;

		// Token: 0x04017A3C RID: 96828
		internal static int __PropertyOffset_4;

		// Token: 0x04017A3D RID: 96829
		internal static int __PropertyOffset_5;
	}
}
