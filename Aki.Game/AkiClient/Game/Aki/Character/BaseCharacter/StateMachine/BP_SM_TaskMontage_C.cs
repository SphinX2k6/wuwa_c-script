using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004392 RID: 17298
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_SM_TaskMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCDA RID: 183514 RVA: 0x00A290D3 File Offset: 0x00A272D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C");
			}
			return BP_SM_TaskMontage_C._ClassPtr;
		}

		// Token: 0x0602CCDB RID: 183515 RVA: 0x00A290F8 File Offset: 0x00A272F8
		public BP_SM_TaskMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCDC RID: 183516 RVA: 0x00A29120 File Offset: 0x00A27320
		public BP_SM_TaskMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070E0 RID: 28896
		// (get) Token: 0x0602CCDD RID: 183517 RVA: 0x00A29153 File Offset: 0x00A27353
		// (set) Token: 0x0602CCDE RID: 183518 RVA: 0x00A29167 File Offset: 0x00A27367
		public unsafe string MontageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070E1 RID: 28897
		// (get) Token: 0x0602CCDF RID: 183519 RVA: 0x00A2917C File Offset: 0x00A2737C
		// (set) Token: 0x0602CCE0 RID: 183520 RVA: 0x00A2918C File Offset: 0x00A2738C
		public unsafe bool 加载期间隐藏模型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070E2 RID: 28898
		// (get) Token: 0x0602CCE1 RID: 183521 RVA: 0x00A2919D File Offset: 0x00A2739D
		// (set) Token: 0x0602CCE2 RID: 183522 RVA: 0x00A291AD File Offset: 0x00A273AD
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070E3 RID: 28899
		// (get) Token: 0x0602CCE3 RID: 183523 RVA: 0x00A291BE File Offset: 0x00A273BE
		// (set) Token: 0x0602CCE4 RID: 183524 RVA: 0x00A291CE File Offset: 0x00A273CE
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170070E4 RID: 28900
		// (get) Token: 0x0602CCE5 RID: 183525 RVA: 0x00A291DF File Offset: 0x00A273DF
		// (set) Token: 0x0602CCE6 RID: 183526 RVA: 0x00A291EF File Offset: 0x00A273EF
		public unsafe bool 生态蒙太奇强制Push到服务器
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070E5 RID: 28901
		// (get) Token: 0x0602CCE7 RID: 183527 RVA: 0x00A29200 File Offset: 0x00A27400
		// (set) Token: 0x0602CCE8 RID: 183528 RVA: 0x00A29214 File Offset: 0x00A27414
		public unsafe FGameplayTag ConfigReplaceTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskMontage_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602CCE9 RID: 183529 RVA: 0x00A29229 File Offset: 0x00A27429
		protected BP_SM_TaskMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A2C RID: 96812
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskMontage.BP_SM_TaskMontage_C";

		// Token: 0x04017A2D RID: 96813
		private static IntPtr _ClassPtr;

		// Token: 0x04017A2E RID: 96814
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A2F RID: 96815
		internal static int __PropertyOffset_0;

		// Token: 0x04017A30 RID: 96816
		internal static int __PropertyOffset_1;

		// Token: 0x04017A31 RID: 96817
		internal static int __PropertyOffset_2;

		// Token: 0x04017A32 RID: 96818
		internal static int __PropertyOffset_3;

		// Token: 0x04017A33 RID: 96819
		internal static int __PropertyOffset_4;

		// Token: 0x04017A34 RID: 96820
		internal static int __PropertyOffset_5;
	}
}
