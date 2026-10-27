using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200438E RID: 17294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class BP_SM_TaskBeHitMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CCBC RID: 183484 RVA: 0x00A28D99 File Offset: 0x00A26F99
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskBeHitMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C");
			}
			return BP_SM_TaskBeHitMontage_C._ClassPtr;
		}

		// Token: 0x0602CCBD RID: 183485 RVA: 0x00A28DC0 File Offset: 0x00A26FC0
		public BP_SM_TaskBeHitMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskBeHitMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CCBE RID: 183486 RVA: 0x00A28DE8 File Offset: 0x00A26FE8
		public BP_SM_TaskBeHitMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskBeHitMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070D9 RID: 28889
		// (get) Token: 0x0602CCBF RID: 183487 RVA: 0x00A28E1B File Offset: 0x00A2701B
		// (set) Token: 0x0602CCC0 RID: 183488 RVA: 0x00A28E2F File Offset: 0x00A2702F
		public unsafe string DefaultAnim
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170070DA RID: 28890
		// (get) Token: 0x0602CCC1 RID: 183489 RVA: 0x00A28E44 File Offset: 0x00A27044
		// (set) Token: 0x0602CCC2 RID: 183490 RVA: 0x00A28E7D File Offset: 0x00A2707D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EHitAnim>, string> HitAnim
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EHitAnim>, string> result;
				if ((result = this._HitAnim) == null)
				{
					result = (this._HitAnim = new TMap<TEnumAsByte<EHitAnim>, string>(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_1, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.HitAnim.CopyAssign(value);
			}
		}

		// Token: 0x170070DB RID: 28891
		// (get) Token: 0x0602CCC3 RID: 183491 RVA: 0x00A28E8B File Offset: 0x00A2708B
		// (set) Token: 0x0602CCC4 RID: 183492 RVA: 0x00A28E9B File Offset: 0x00A2709B
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070DC RID: 28892
		// (get) Token: 0x0602CCC5 RID: 183493 RVA: 0x00A28EAC File Offset: 0x00A270AC
		// (set) Token: 0x0602CCC6 RID: 183494 RVA: 0x00A28EBC File Offset: 0x00A270BC
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602CCC7 RID: 183495 RVA: 0x00A28ECD File Offset: 0x00A270CD
		protected BP_SM_TaskBeHitMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A18 RID: 96792
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C";

		// Token: 0x04017A19 RID: 96793
		private static IntPtr _ClassPtr;

		// Token: 0x04017A1A RID: 96794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A1B RID: 96795
		internal static int __PropertyOffset_0;

		// Token: 0x04017A1C RID: 96796
		internal static int __PropertyOffset_1;

		// Token: 0x04017A1D RID: 96797
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EHitAnim>, string> _HitAnim;

		// Token: 0x04017A1E RID: 96798
		internal static int __PropertyOffset_2;

		// Token: 0x04017A1F RID: 96799
		internal static int __PropertyOffset_3;
	}
}
