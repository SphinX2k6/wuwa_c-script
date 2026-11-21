using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033A9 RID: 13225
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 84)]
	public class BP_SM_ConditionPartLife_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218AC RID: 137388 RVA: 0x0096370D File Offset: 0x0096190D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionPartLife_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C");
			}
			return BP_SM_ConditionPartLife_C._ClassPtr;
		}

		// Token: 0x060218AD RID: 137389 RVA: 0x00963734 File Offset: 0x00961934
		public BP_SM_ConditionPartLife_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionPartLife_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218AE RID: 137390 RVA: 0x0096375C File Offset: 0x0096195C
		public BP_SM_ConditionPartLife_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionPartLife_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044D1 RID: 17617
		// (get) Token: 0x060218AF RID: 137391 RVA: 0x0096378F File Offset: 0x0096198F
		// (set) Token: 0x060218B0 RID: 137392 RVA: 0x009637A3 File Offset: 0x009619A3
		public unsafe string 部位名
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_部位名)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_部位名)), value);
			}
		}

		// Token: 0x170044D2 RID: 17618
		// (get) Token: 0x060218B1 RID: 137393 RVA: 0x009637B8 File Offset: 0x009619B8
		// (set) Token: 0x060218B2 RID: 137394 RVA: 0x009637C8 File Offset: 0x009619C8
		public unsafe bool 是否万分比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_是否万分比) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_是否万分比) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044D3 RID: 17619
		// (get) Token: 0x060218B3 RID: 137395 RVA: 0x009637D9 File Offset: 0x009619D9
		// (set) Token: 0x060218B4 RID: 137396 RVA: 0x009637E9 File Offset: 0x009619E9
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x170044D4 RID: 17620
		// (get) Token: 0x060218B5 RID: 137397 RVA: 0x009637FA File Offset: 0x009619FA
		// (set) Token: 0x060218B6 RID: 137398 RVA: 0x0096380A File Offset: 0x00961A0A
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionPartLife_C.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x060218B7 RID: 137399 RVA: 0x0096381B File Offset: 0x00961A1B
		protected BP_SM_ConditionPartLife_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401257B RID: 75131
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionPartLife.BP_SM_ConditionPartLife_C";

		// Token: 0x0401257C RID: 75132
		private static IntPtr _ClassPtr;

		// Token: 0x0401257D RID: 75133
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401257E RID: 75134
		internal static int __PropertyOffset_部位名;

		// Token: 0x0401257F RID: 75135
		internal static int __PropertyOffset_是否万分比;

		// Token: 0x04012580 RID: 75136
		internal static int __PropertyOffset_Min;

		// Token: 0x04012581 RID: 75137
		internal static int __PropertyOffset_Max;
	}
}
