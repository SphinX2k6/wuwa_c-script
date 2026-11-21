using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x020033AE RID: 13230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class BP_SM_TaskBeHitMontage_C : UASMTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218D2 RID: 137426 RVA: 0x00963AF4 File Offset: 0x00961CF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_TaskBeHitMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C");
			}
			return BP_SM_TaskBeHitMontage_C._ClassPtr;
		}

		// Token: 0x060218D3 RID: 137427 RVA: 0x00963B18 File Offset: 0x00961D18
		public BP_SM_TaskBeHitMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskBeHitMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218D4 RID: 137428 RVA: 0x00963B40 File Offset: 0x00961D40
		public BP_SM_TaskBeHitMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_TaskBeHitMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x060218D5 RID: 137429 RVA: 0x00963B73 File Offset: 0x00961D73
		// (set) Token: 0x060218D6 RID: 137430 RVA: 0x00963B87 File Offset: 0x00961D87
		public unsafe string DefaultAnim
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_DefaultAnim)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_DefaultAnim)), value);
			}
		}

		// Token: 0x170044DB RID: 17627
		// (get) Token: 0x060218D7 RID: 137431 RVA: 0x00963B9C File Offset: 0x00961D9C
		// (set) Token: 0x060218D8 RID: 137432 RVA: 0x00963BD5 File Offset: 0x00961DD5
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
					result = (this._HitAnim = new TMap<TEnumAsByte<EHitAnim>, string>(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_HitAnim, this));
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

		// Token: 0x170044DC RID: 17628
		// (get) Token: 0x060218D9 RID: 137433 RVA: 0x00963BE3 File Offset: 0x00961DE3
		// (set) Token: 0x060218DA RID: 137434 RVA: 0x00963BF3 File Offset: 0x00961DF3
		public unsafe bool 允许打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_允许打断) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_允许打断) = (value ? 1 : 0);
			}
		}

		// Token: 0x170044DD RID: 17629
		// (get) Token: 0x060218DB RID: 137435 RVA: 0x00963C04 File Offset: 0x00961E04
		// (set) Token: 0x060218DC RID: 137436 RVA: 0x00963C14 File Offset: 0x00961E14
		public unsafe int BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_TaskBeHitMontage_C.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x060218DD RID: 137437 RVA: 0x00963C25 File Offset: 0x00961E25
		protected BP_SM_TaskBeHitMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012593 RID: 75155
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_TaskBeHitMontage.BP_SM_TaskBeHitMontage_C";

		// Token: 0x04012594 RID: 75156
		private static IntPtr _ClassPtr;

		// Token: 0x04012595 RID: 75157
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012596 RID: 75158
		internal static int __PropertyOffset_DefaultAnim;

		// Token: 0x04012597 RID: 75159
		internal static int __PropertyOffset_HitAnim;

		// Token: 0x04012598 RID: 75160
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EHitAnim>, string> _HitAnim;

		// Token: 0x04012599 RID: 75161
		internal static int __PropertyOffset_允许打断;

		// Token: 0x0401259A RID: 75162
		internal static int __PropertyOffset_BlendInTime;
	}
}
