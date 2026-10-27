using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E24 RID: 15908
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/PD_CharacterMaterialContainerData.PD_CharacterMaterialContainerData_C")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class PD_CharacterMaterialContainerData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027DE3 RID: 163299 RVA: 0x0099D5AA File Offset: 0x0099B7AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_CharacterMaterialContainerData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/PD_CharacterMaterialContainerData.PD_CharacterMaterialContainerData_C");
			}
			return PD_CharacterMaterialContainerData_C._ClassPtr;
		}

		// Token: 0x06027DE4 RID: 163300 RVA: 0x0099D5D0 File Offset: 0x0099B7D0
		public PD_CharacterMaterialContainerData_C() : this(BuiltinUtils.AllocNativeUObject(PD_CharacterMaterialContainerData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027DE5 RID: 163301 RVA: 0x0099D5F8 File Offset: 0x0099B7F8
		public PD_CharacterMaterialContainerData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_CharacterMaterialContainerData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x06027DE6 RID: 163302 RVA: 0x0099D62C File Offset: 0x0099B82C
		// (set) Token: 0x06027DE7 RID: 163303 RVA: 0x0099D665 File Offset: 0x0099B865
		public TArray<FName> BodyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BodyNames) == null)
				{
					result = (this._BodyNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.BodyNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x06027DE8 RID: 163304 RVA: 0x0099D674 File Offset: 0x0099B874
		// (set) Token: 0x06027DE9 RID: 163305 RVA: 0x0099D6AD File Offset: 0x0099B8AD
		public TArray<FName> WeaponNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._WeaponNames) == null)
				{
					result = (this._WeaponNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.WeaponNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x06027DEA RID: 163306 RVA: 0x0099D6BC File Offset: 0x0099B8BC
		// (set) Token: 0x06027DEB RID: 163307 RVA: 0x0099D6F5 File Offset: 0x0099B8F5
		public TArray<FName> HuluNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HuluNames) == null)
				{
					result = (this._HuluNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.HuluNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A85 RID: 23173
		// (get) Token: 0x06027DEC RID: 163308 RVA: 0x0099D704 File Offset: 0x0099B904
		// (set) Token: 0x06027DED RID: 163309 RVA: 0x0099D73D File Offset: 0x0099B93D
		public TArray<FName> OtherNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._OtherNames) == null)
				{
					result = (this._OtherNames = new TArray<FName>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.OtherNames.CopyAssign(value);
			}
		}

		// Token: 0x17005A86 RID: 23174
		// (get) Token: 0x06027DEE RID: 163310 RVA: 0x0099D74C File Offset: 0x0099B94C
		// (set) Token: 0x06027DEF RID: 163311 RVA: 0x0099D785 File Offset: 0x0099B985
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECharacterBodySpecifiedType>, SCharacterBodySpecifiedStruct> BodySpecifiedTypes
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
				TMap<TEnumAsByte<ECharacterBodySpecifiedType>, SCharacterBodySpecifiedStruct> result;
				if ((result = this._BodySpecifiedTypes) == null)
				{
					result = (this._BodySpecifiedTypes = new TMap<TEnumAsByte<ECharacterBodySpecifiedType>, SCharacterBodySpecifiedStruct>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_4, this));
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
				this.BodySpecifiedTypes.CopyAssign(value);
			}
		}

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x06027DF0 RID: 163312 RVA: 0x0099D794 File Offset: 0x0099B994
		// (set) Token: 0x06027DF1 RID: 163313 RVA: 0x0099D7CD File Offset: 0x0099B9CD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECharacterSlotSpecifiedType>, SCharacterSlotSpecifiedStruct> SlotSpecifiedTypes
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
				TMap<TEnumAsByte<ECharacterSlotSpecifiedType>, SCharacterSlotSpecifiedStruct> result;
				if ((result = this._SlotSpecifiedTypes) == null)
				{
					result = (this._SlotSpecifiedTypes = new TMap<TEnumAsByte<ECharacterSlotSpecifiedType>, SCharacterSlotSpecifiedStruct>(base.NativePtr + (IntPtr)PD_CharacterMaterialContainerData_C.__PropertyOffset_5, this));
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
				this.SlotSpecifiedTypes.CopyAssign(value);
			}
		}

		// Token: 0x06027DF2 RID: 163314 RVA: 0x0099D7DB File Offset: 0x0099B9DB
		protected PD_CharacterMaterialContainerData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401437F RID: 82815
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/PD_CharacterMaterialContainerData.PD_CharacterMaterialContainerData_C";

		// Token: 0x04014380 RID: 82816
		private static IntPtr _ClassPtr;

		// Token: 0x04014381 RID: 82817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014382 RID: 82818
		internal static int __PropertyOffset_0;

		// Token: 0x04014383 RID: 82819
		[Nullable(2)]
		private TArray<FName> _BodyNames;

		// Token: 0x04014384 RID: 82820
		internal static int __PropertyOffset_1;

		// Token: 0x04014385 RID: 82821
		[Nullable(2)]
		private TArray<FName> _WeaponNames;

		// Token: 0x04014386 RID: 82822
		internal static int __PropertyOffset_2;

		// Token: 0x04014387 RID: 82823
		[Nullable(2)]
		private TArray<FName> _HuluNames;

		// Token: 0x04014388 RID: 82824
		internal static int __PropertyOffset_3;

		// Token: 0x04014389 RID: 82825
		[Nullable(2)]
		private TArray<FName> _OtherNames;

		// Token: 0x0401438A RID: 82826
		internal static int __PropertyOffset_4;

		// Token: 0x0401438B RID: 82827
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECharacterBodySpecifiedType>, SCharacterBodySpecifiedStruct> _BodySpecifiedTypes;

		// Token: 0x0401438C RID: 82828
		internal static int __PropertyOffset_5;

		// Token: 0x0401438D RID: 82829
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECharacterSlotSpecifiedType>, SCharacterSlotSpecifiedStruct> _SlotSpecifiedTypes;
	}
}
