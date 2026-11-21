using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A5 RID: 13221
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionListenBeHit_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021886 RID: 137350 RVA: 0x00963374 File Offset: 0x00961574
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionListenBeHit_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C");
			}
			return BP_SM_ConditionListenBeHit_C._ClassPtr;
		}

		// Token: 0x06021887 RID: 137351 RVA: 0x00963398 File Offset: 0x00961598
		public BP_SM_ConditionListenBeHit_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenBeHit_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021888 RID: 137352 RVA: 0x009633C0 File Offset: 0x009615C0
		[NullableContext(1)]
		public BP_SM_ConditionListenBeHit_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenBeHit_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044C6 RID: 17606
		// (get) Token: 0x06021889 RID: 137353 RVA: 0x009633F3 File Offset: 0x009615F3
		// (set) Token: 0x0602188A RID: 137354 RVA: 0x00963403 File Offset: 0x00961603
		public unsafe bool 无受击动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_无受击动作) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_无受击动作) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x0602188B RID: 137355 RVA: 0x00963414 File Offset: 0x00961614
		// (set) Token: 0x0602188C RID: 137356 RVA: 0x00963424 File Offset: 0x00961624
		public unsafe bool 轻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_轻击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_轻击) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x0602188D RID: 137357 RVA: 0x00963435 File Offset: 0x00961635
		// (set) Token: 0x0602188E RID: 137358 RVA: 0x00963445 File Offset: 0x00961645
		public unsafe bool 重击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_重击) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_重击) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x0602188F RID: 137359 RVA: 0x00963456 File Offset: 0x00961656
		// (set) Token: 0x06021890 RID: 137360 RVA: 0x00963466 File Offset: 0x00961666
		public unsafe bool 击飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_击飞) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_击飞) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x06021891 RID: 137361 RVA: 0x00963477 File Offset: 0x00961677
		// (set) Token: 0x06021892 RID: 137362 RVA: 0x00963487 File Offset: 0x00961687
		public unsafe bool 击倒
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_击倒) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_击倒) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x06021893 RID: 137363 RVA: 0x00963498 File Offset: 0x00961698
		// (set) Token: 0x06021894 RID: 137364 RVA: 0x009634A8 File Offset: 0x009616A8
		public unsafe bool 被弹反
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_被弹反) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_被弹反) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x06021895 RID: 137365 RVA: 0x009634B9 File Offset: 0x009616B9
		// (set) Token: 0x06021896 RID: 137366 RVA: 0x009634C9 File Offset: 0x009616C9
		public unsafe bool 被破弱
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_被破弱) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_被破弱) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x06021897 RID: 137367 RVA: 0x009634DA File Offset: 0x009616DA
		// (set) Token: 0x06021898 RID: 137368 RVA: 0x009634EA File Offset: 0x009616EA
		public unsafe int 策略技Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_策略技Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_策略技Id) = value;
			}
		}

		// Token: 0x06021899 RID: 137369 RVA: 0x009634FB File Offset: 0x009616FB
		protected BP_SM_ConditionListenBeHit_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012564 RID: 75108
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C";

		// Token: 0x04012565 RID: 75109
		private static IntPtr _ClassPtr;

		// Token: 0x04012566 RID: 75110
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012567 RID: 75111
		internal static int __PropertyOffset_无受击动作;

		// Token: 0x04012568 RID: 75112
		internal static int __PropertyOffset_轻击;

		// Token: 0x04012569 RID: 75113
		internal static int __PropertyOffset_重击;

		// Token: 0x0401256A RID: 75114
		internal static int __PropertyOffset_击飞;

		// Token: 0x0401256B RID: 75115
		internal static int __PropertyOffset_击倒;

		// Token: 0x0401256C RID: 75116
		internal static int __PropertyOffset_被弹反;

		// Token: 0x0401256D RID: 75117
		internal static int __PropertyOffset_被破弱;

		// Token: 0x0401256E RID: 75118
		internal static int __PropertyOffset_策略技Id;
	}
}
