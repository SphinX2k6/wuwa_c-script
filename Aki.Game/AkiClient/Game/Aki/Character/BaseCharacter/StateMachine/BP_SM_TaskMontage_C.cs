using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033B2 RID: 13234
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_SM_TaskMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218F0 RID: 137456 RVA: 0x00963E2B File Offset: 0x0096202B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C");
			}
			return BP_SM_TaskMontage_C._ClassPtr;
		}

		// Token: 0x060218F1 RID: 137457 RVA: 0x00963E50 File Offset: 0x00962050
		public BP_SM_TaskMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218F2 RID: 137458 RVA: 0x00963E78 File Offset: 0x00962078
		public BP_SM_TaskMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x060218F3 RID: 137459 RVA: 0x00963EAB File Offset: 0x009620AB
		// (set) Token: 0x060218F4 RID: 137460 RVA: 0x00963EBF File Offset: 0x009620BF
		public unsafe string MontageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_MontageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_MontageName)), value);
			}
		}

		// Token: 0x170044E2 RID: 17634
		// (get) Token: 0x060218F5 RID: 137461 RVA: 0x00963ED4 File Offset: 0x009620D4
		// (set) Token: 0x060218F6 RID: 137462 RVA: 0x00963EE4 File Offset: 0x009620E4
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_加载期间隐藏模型) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_加载期间隐藏模型) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E3 RID: 17635
		// (get) Token: 0x060218F7 RID: 137463 RVA: 0x00963EF5 File Offset: 0x009620F5
		// (set) Token: 0x060218F8 RID: 137464 RVA: 0x00963F05 File Offset: 0x00962105
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x060218F9 RID: 137465 RVA: 0x00963F16 File Offset: 0x00962116
		// (set) Token: 0x060218FA RID: 137466 RVA: 0x00963F26 File Offset: 0x00962126
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x170044E5 RID: 17637
		// (get) Token: 0x060218FB RID: 137467 RVA: 0x00963F37 File Offset: 0x00962137
		// (set) Token: 0x060218FC RID: 137468 RVA: 0x00963F47 File Offset: 0x00962147
		public unsafe bool 生态蒙太奇强制Push到服务器
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_生态蒙太奇强制Push到服务器) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_生态蒙太奇强制Push到服务器) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044E6 RID: 17638
		// (get) Token: 0x060218FD RID: 137469 RVA: 0x00963F58 File Offset: 0x00962158
		// (set) Token: 0x060218FE RID: 137470 RVA: 0x00963F6C File Offset: 0x0096216C
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_ConfigReplaceTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_ConfigReplaceTag) = value;
			}
		}

		// Token: 0x060218FF RID: 137471 RVA: 0x00963F81 File Offset: 0x00962181
		protected BP_SM_TaskMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125A7 RID: 75175
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C";

		// Token: 0x040125A8 RID: 75176
		private static IntPtr _ClassPtr;

		// Token: 0x040125A9 RID: 75177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125AA RID: 75178
		internal static int __PropertyOffset_MontageName;

		// Token: 0x040125AB RID: 75179
		internal static int __PropertyOffset_加载期间隐藏模型;

		// Token: 0x040125AC RID: 75180
		internal static int __PropertyOffset_允许打断;

		// Token: 0x040125AD RID: 75181
		internal static int __PropertyOffset_BlendInTime;

		// Token: 0x040125AE RID: 75182
		internal static int __PropertyOffset_生态蒙太奇强制Push到服务器;

		// Token: 0x040125AF RID: 75183
		internal static int __PropertyOffset_ConfigReplaceTag;
	}
}
