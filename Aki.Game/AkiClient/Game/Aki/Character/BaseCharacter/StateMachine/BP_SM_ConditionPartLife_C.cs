using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004388 RID: 17288
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 84)]
	public class BP_SM_ConditionPartLife_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC8E RID: 183438 RVA: 0x00A288B9 File Offset: 0x00A26AB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionPartLife_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C");
			}
			return BP_SM_ConditionPartLife_C._ClassPtr;
		}

		// Token: 0x0602CC8F RID: 183439 RVA: 0x00A288E0 File Offset: 0x00A26AE0
		public BP_SM_ConditionPartLife_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionPartLife_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC90 RID: 183440 RVA: 0x00A28908 File Offset: 0x00A26B08
		public BP_SM_ConditionPartLife_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionPartLife_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070CF RID: 28879
		// (get) Token: 0x0602CC91 RID: 183441 RVA: 0x00A2893B File Offset: 0x00A26B3B
		// (set) Token: 0x0602CC92 RID: 183442 RVA: 0x00A2894F File Offset: 0x00A26B4F
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070D0 RID: 28880
		// (get) Token: 0x0602CC93 RID: 183443 RVA: 0x00A28964 File Offset: 0x00A26B64
		// (set) Token: 0x0602CC94 RID: 183444 RVA: 0x00A28974 File Offset: 0x00A26B74
		public unsafe bool 是否万分比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070D1 RID: 28881
		// (get) Token: 0x0602CC95 RID: 183445 RVA: 0x00A28985 File Offset: 0x00A26B85
		// (set) Token: 0x0602CC96 RID: 183446 RVA: 0x00A28995 File Offset: 0x00A26B95
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170070D2 RID: 28882
		// (get) Token: 0x0602CC97 RID: 183447 RVA: 0x00A289A6 File Offset: 0x00A26BA6
		// (set) Token: 0x0602CC98 RID: 183448 RVA: 0x00A289B6 File Offset: 0x00A26BB6
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602CC99 RID: 183449 RVA: 0x00A289C7 File Offset: 0x00A26BC7
		protected BP_SM_ConditionPartLife_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179FA RID: 96762
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C";

		// Token: 0x040179FB RID: 96763
		private static IntPtr _ClassPtr;

		// Token: 0x040179FC RID: 96764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179FD RID: 96765
		internal static int __PropertyOffset_0;

		// Token: 0x040179FE RID: 96766
		internal static int __PropertyOffset_1;

		// Token: 0x040179FF RID: 96767
		internal static int __PropertyOffset_2;

		// Token: 0x04017A00 RID: 96768
		internal static int __PropertyOffset_3;
	}
}
