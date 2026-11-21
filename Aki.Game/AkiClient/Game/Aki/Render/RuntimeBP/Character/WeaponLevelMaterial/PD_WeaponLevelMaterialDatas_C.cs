using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.WeaponLevelMaterial
{
	// Token: 0x02003119 RID: 12569
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_WeaponLevelMaterialDatas_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ECA8 RID: 126120 RVA: 0x0091D61F File Offset: 0x0091B81F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_WeaponLevelMaterialDatas_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C");
			}
			return PD_WeaponLevelMaterialDatas_C._ClassPtr;
		}

		// Token: 0x0601ECA9 RID: 126121 RVA: 0x0091D644 File Offset: 0x0091B844
		public PD_WeaponLevelMaterialDatas_C() : this(BuiltinUtils.AllocNativeUObject(PD_WeaponLevelMaterialDatas_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ECAA RID: 126122 RVA: 0x0091D66C File Offset: 0x0091B86C
		[NullableContext(1)]
		public PD_WeaponLevelMaterialDatas_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_WeaponLevelMaterialDatas_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601ECAB RID: 126123 RVA: 0x0091D69F File Offset: 0x0091B89F
		protected PD_WeaponLevelMaterialDatas_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040105BE RID: 67006
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/WeaponLevelMaterial/PD_WeaponLevelMaterialDatas.PD_WeaponLevelMaterialDatas_C";

		// Token: 0x040105BF RID: 67007
		private static IntPtr _ClassPtr;

		// Token: 0x040105C0 RID: 67008
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
