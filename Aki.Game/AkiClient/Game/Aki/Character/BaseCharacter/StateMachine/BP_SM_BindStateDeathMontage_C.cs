using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200436E RID: 17262
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class BP_SM_BindStateDeathMontage_C : UASMBindState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CBD0 RID: 183248 RVA: 0x00A2746C File Offset: 0x00A2566C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_BindStateDeathMontage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C");
			}
			return BP_SM_BindStateDeathMontage_C._ClassPtr;
		}

		// Token: 0x0602CBD1 RID: 183249 RVA: 0x00A27490 File Offset: 0x00A25690
		public BP_SM_BindStateDeathMontage_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CBD2 RID: 183250 RVA: 0x00A274B8 File Offset: 0x00A256B8
		[NullableContext(1)]
		public BP_SM_BindStateDeathMontage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_BindStateDeathMontage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070A4 RID: 28836
		// (get) Token: 0x0602CBD3 RID: 183251 RVA: 0x00A274EB File Offset: 0x00A256EB
		// (set) Token: 0x0602CBD4 RID: 183252 RVA: 0x00A274FF File Offset: 0x00A256FF
		public unsafe TEnumAsByte<EMonsterDeathType> 死亡种类
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070A5 RID: 28837
		// (get) Token: 0x0602CBD5 RID: 183253 RVA: 0x00A27514 File Offset: 0x00A25714
		// (set) Token: 0x0602CBD6 RID: 183254 RVA: 0x00A27528 File Offset: 0x00A25728
		[Nullable(1)]
		public unsafe string MontageName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_1)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SM_BindStateDeathMontage_C.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x0602CBD7 RID: 183255 RVA: 0x00A2753D File Offset: 0x00A2573D
		protected BP_SM_BindStateDeathMontage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017980 RID: 96640
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_BindStateDeathMontage.BP_SM_BindStateDeathMontage_C";

		// Token: 0x04017981 RID: 96641
		private static IntPtr _ClassPtr;

		// Token: 0x04017982 RID: 96642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017983 RID: 96643
		internal static int __PropertyOffset_0;

		// Token: 0x04017984 RID: 96644
		internal static int __PropertyOffset_1;
	}
}
