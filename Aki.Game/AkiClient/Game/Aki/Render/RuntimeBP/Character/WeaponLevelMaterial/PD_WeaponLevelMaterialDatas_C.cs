using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial
{
	// Token: 0x02003DF5 RID: 15861
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_WeaponLevelMaterialDatas_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060279C0 RID: 162240 RVA: 0x009960B4 File Offset: 0x009942B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_WeaponLevelMaterialDatas_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C");
			}
			return PD_WeaponLevelMaterialDatas_C._ClassPtr;
		}

		// Token: 0x060279C1 RID: 162241 RVA: 0x009960D8 File Offset: 0x009942D8
		public PD_WeaponLevelMaterialDatas_C() : this(BuiltinUtils.AllocNativeUObject(PD_WeaponLevelMaterialDatas_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060279C2 RID: 162242 RVA: 0x00996100 File Offset: 0x00994300
		public PD_WeaponLevelMaterialDatas_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_WeaponLevelMaterialDatas_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005902 RID: 22786
		// (get) Token: 0x060279C3 RID: 162243 RVA: 0x00996134 File Offset: 0x00994334
		// (set) Token: 0x060279C4 RID: 162244 RVA: 0x0099616D File Offset: 0x0099436D
		public TMap<int, SWeaponLevelMaterialData> LevelDatas
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, SWeaponLevelMaterialData> result;
				if ((result = this._LevelDatas) == null)
				{
					result = (this._LevelDatas = new TMap<int, SWeaponLevelMaterialData>(base.NativePtr + (IntPtr)PD_WeaponLevelMaterialDatas_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.LevelDatas.CopyAssign(value);
			}
		}

		// Token: 0x060279C5 RID: 162245 RVA: 0x0099617B File Offset: 0x0099437B
		protected PD_WeaponLevelMaterialDatas_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014083 RID: 82051
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C";

		// Token: 0x04014084 RID: 82052
		private static IntPtr _ClassPtr;

		// Token: 0x04014085 RID: 82053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014086 RID: 82054
		internal static int __PropertyOffset_0;

		// Token: 0x04014087 RID: 82055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, SWeaponLevelMaterialData> _LevelDatas;
	}
}
