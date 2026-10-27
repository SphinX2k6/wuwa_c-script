using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004373 RID: 17267
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_SM_BindStatePalsy_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBF2 RID: 183282 RVA: 0x00A27817 File Offset: 0x00A25A17
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStatePalsy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C");
			}
			return BP_SM_BindStatePalsy_C._ClassPtr;
		}

		// Token: 0x0602CBF3 RID: 183283 RVA: 0x00A2783C File Offset: 0x00A25A3C
		public BP_SM_BindStatePalsy_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePalsy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBF4 RID: 183284 RVA: 0x00A27864 File Offset: 0x00A25A64
		public BP_SM_BindStatePalsy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePalsy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070AB RID: 28843
		// (get) Token: 0x0602CBF5 RID: 183285 RVA: 0x00A27897 File Offset: 0x00A25A97
		// (set) Token: 0x0602CBF6 RID: 183286 RVA: 0x00A278AC File Offset: 0x00A25AAC
		public TSoftObjectPtr<CounterAttackEffectData> 弹反特效预设
		{
			get
			{
				return new TSoftObjectPtr<CounterAttackEffectData>(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170070AC RID: 28844
		// (get) Token: 0x0602CBF7 RID: 183287 RVA: 0x00A278D1 File Offset: 0x00A25AD1
		// (set) Token: 0x0602CBF8 RID: 183288 RVA: 0x00A278E6 File Offset: 0x00A25AE6
		public TSoftObjectPtr<CounterAttackCameraData> 弹反摄像机预设
		{
			get
			{
				return new TSoftObjectPtr<CounterAttackCameraData>(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_1, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602CBF9 RID: 183289 RVA: 0x00A2790B File Offset: 0x00A25B0B
		protected BP_SM_BindStatePalsy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017996 RID: 96662
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C";

		// Token: 0x04017997 RID: 96663
		private static IntPtr _ClassPtr;

		// Token: 0x04017998 RID: 96664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017999 RID: 96665
		internal static int __PropertyOffset_0;

		// Token: 0x0401799A RID: 96666
		internal static int __PropertyOffset_1;
	}
}
