using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003394 RID: 13204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class BP_SM_BindStatePalsy_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021810 RID: 137232 RVA: 0x0096266B File Offset: 0x0096086B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStatePalsy_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C");
			}
			return BP_SM_BindStatePalsy_C._ClassPtr;
		}

		// Token: 0x06021811 RID: 137233 RVA: 0x00962690 File Offset: 0x00960890
		public BP_SM_BindStatePalsy_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePalsy_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021812 RID: 137234 RVA: 0x009626B8 File Offset: 0x009608B8
		public BP_SM_BindStatePalsy_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStatePalsy_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044AD RID: 17581
		// (get) Token: 0x06021813 RID: 137235 RVA: 0x009626EB File Offset: 0x009608EB
		// (set) Token: 0x06021814 RID: 137236 RVA: 0x00962700 File Offset: 0x00960900
		public TSoftObjectPtr<CounterAttackEffectData> 弹反特效预设
		{
			get
			{
				return new TSoftObjectPtr<CounterAttackEffectData>(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_弹反特效预设, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_弹反特效预设, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170044AE RID: 17582
		// (get) Token: 0x06021815 RID: 137237 RVA: 0x00962725 File Offset: 0x00960925
		// (set) Token: 0x06021816 RID: 137238 RVA: 0x0096273A File Offset: 0x0096093A
		public TSoftObjectPtr<CounterAttackCameraData> 弹反摄像机预设
		{
			get
			{
				return new TSoftObjectPtr<CounterAttackCameraData>(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_弹反摄像机预设, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SM_BindStatePalsy_C.__PropertyOffset_弹反摄像机预设, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021817 RID: 137239 RVA: 0x0096275F File Offset: 0x0096095F
		protected BP_SM_BindStatePalsy_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012517 RID: 75031
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStatePalsy.BP_SM_BindStatePalsy_C";

		// Token: 0x04012518 RID: 75032
		private static IntPtr _ClassPtr;

		// Token: 0x04012519 RID: 75033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401251A RID: 75034
		internal static int __PropertyOffset_弹反特效预设;

		// Token: 0x0401251B RID: 75035
		internal static int __PropertyOffset_弹反摄像机预设;
	}
}
