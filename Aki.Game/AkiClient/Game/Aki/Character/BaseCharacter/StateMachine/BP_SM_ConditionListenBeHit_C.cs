using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004384 RID: 17284
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionListenBeHit_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC68 RID: 183400 RVA: 0x00A28520 File Offset: 0x00A26720
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionListenBeHit_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C");
			}
			return BP_SM_ConditionListenBeHit_C._ClassPtr;
		}

		// Token: 0x0602CC69 RID: 183401 RVA: 0x00A28544 File Offset: 0x00A26744
		public BP_SM_ConditionListenBeHit_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenBeHit_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC6A RID: 183402 RVA: 0x00A2856C File Offset: 0x00A2676C
		[NullableContext(1)]
		public BP_SM_ConditionListenBeHit_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionListenBeHit_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070C4 RID: 28868
		// (get) Token: 0x0602CC6B RID: 183403 RVA: 0x00A2859F File Offset: 0x00A2679F
		// (set) Token: 0x0602CC6C RID: 183404 RVA: 0x00A285AF File Offset: 0x00A267AF
		public unsafe bool 无受击动作
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070C5 RID: 28869
		// (get) Token: 0x0602CC6D RID: 183405 RVA: 0x00A285C0 File Offset: 0x00A267C0
		// (set) Token: 0x0602CC6E RID: 183406 RVA: 0x00A285D0 File Offset: 0x00A267D0
		public unsafe bool 轻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070C6 RID: 28870
		// (get) Token: 0x0602CC6F RID: 183407 RVA: 0x00A285E1 File Offset: 0x00A267E1
		// (set) Token: 0x0602CC70 RID: 183408 RVA: 0x00A285F1 File Offset: 0x00A267F1
		public unsafe bool 重击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070C7 RID: 28871
		// (get) Token: 0x0602CC71 RID: 183409 RVA: 0x00A28602 File Offset: 0x00A26802
		// (set) Token: 0x0602CC72 RID: 183410 RVA: 0x00A28612 File Offset: 0x00A26812
		public unsafe bool 击飞
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070C8 RID: 28872
		// (get) Token: 0x0602CC73 RID: 183411 RVA: 0x00A28623 File Offset: 0x00A26823
		// (set) Token: 0x0602CC74 RID: 183412 RVA: 0x00A28633 File Offset: 0x00A26833
		public unsafe bool 击倒
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070C9 RID: 28873
		// (get) Token: 0x0602CC75 RID: 183413 RVA: 0x00A28644 File Offset: 0x00A26844
		// (set) Token: 0x0602CC76 RID: 183414 RVA: 0x00A28654 File Offset: 0x00A26854
		public unsafe bool 被弹反
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070CA RID: 28874
		// (get) Token: 0x0602CC77 RID: 183415 RVA: 0x00A28665 File Offset: 0x00A26865
		// (set) Token: 0x0602CC78 RID: 183416 RVA: 0x00A28675 File Offset: 0x00A26875
		public unsafe bool 被破弱
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070CB RID: 28875
		// (get) Token: 0x0602CC79 RID: 183417 RVA: 0x00A28686 File Offset: 0x00A26886
		// (set) Token: 0x0602CC7A RID: 183418 RVA: 0x00A28696 File Offset: 0x00A26896
		public unsafe int 策略技Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionListenBeHit_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602CC7B RID: 183419 RVA: 0x00A286A7 File Offset: 0x00A268A7
		protected BP_SM_ConditionListenBeHit_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179E3 RID: 96739
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionListenBeHit.BP_SM_ConditionListenBeHit_C";

		// Token: 0x040179E4 RID: 96740
		private static IntPtr _ClassPtr;

		// Token: 0x040179E5 RID: 96741
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179E6 RID: 96742
		internal static int __PropertyOffset_0;

		// Token: 0x040179E7 RID: 96743
		internal static int __PropertyOffset_1;

		// Token: 0x040179E8 RID: 96744
		internal static int __PropertyOffset_2;

		// Token: 0x040179E9 RID: 96745
		internal static int __PropertyOffset_3;

		// Token: 0x040179EA RID: 96746
		internal static int __PropertyOffset_4;

		// Token: 0x040179EB RID: 96747
		internal static int __PropertyOffset_5;

		// Token: 0x040179EC RID: 96748
		internal static int __PropertyOffset_6;

		// Token: 0x040179ED RID: 96749
		internal static int __PropertyOffset_7;
	}
}
