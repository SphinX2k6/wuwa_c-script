using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004391 RID: 17297
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 57)]
	public class BP_SM_TaskLeaveFight_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCD0 RID: 183504 RVA: 0x00A28FE8 File Offset: 0x00A271E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskLeaveFight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C");
			}
			return BP_SM_TaskLeaveFight_C._ClassPtr;
		}

		// Token: 0x0602CCD1 RID: 183505 RVA: 0x00A2900C File Offset: 0x00A2720C
		public BP_SM_TaskLeaveFight_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskLeaveFight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCD2 RID: 183506 RVA: 0x00A29034 File Offset: 0x00A27234
		[NullableContext(1)]
		public BP_SM_TaskLeaveFight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskLeaveFight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070DD RID: 28893
		// (get) Token: 0x0602CCD3 RID: 183507 RVA: 0x00A29067 File Offset: 0x00A27267
		// (set) Token: 0x0602CCD4 RID: 183508 RVA: 0x00A29077 File Offset: 0x00A27277
		public unsafe int 最大停止时间超过时长直接传送
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070DE RID: 28894
		// (get) Token: 0x0602CCD5 RID: 183509 RVA: 0x00A29088 File Offset: 0x00A27288
		// (set) Token: 0x0602CCD6 RID: 183510 RVA: 0x00A29098 File Offset: 0x00A27298
		public unsafe int 脱战瞬移时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070DF RID: 28895
		// (get) Token: 0x0602CCD7 RID: 183511 RVA: 0x00A290A9 File Offset: 0x00A272A9
		// (set) Token: 0x0602CCD8 RID: 183512 RVA: 0x00A290B9 File Offset: 0x00A272B9
		public unsafe bool 是否使用最后一个巡逻点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskLeaveFight_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602CCD9 RID: 183513 RVA: 0x00A290CA File Offset: 0x00A272CA
		protected BP_SM_TaskLeaveFight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A26 RID: 96806
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskLeaveFight.BP_SM_TaskLeaveFight_C";

		// Token: 0x04017A27 RID: 96807
		private static IntPtr _ClassPtr;

		// Token: 0x04017A28 RID: 96808
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A29 RID: 96809
		internal static int __PropertyOffset_0;

		// Token: 0x04017A2A RID: 96810
		internal static int __PropertyOffset_1;

		// Token: 0x04017A2B RID: 96811
		internal static int __PropertyOffset_2;
	}
}
