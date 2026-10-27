using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x02003F02 RID: 16130
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_CharacterSwingConfig_C : BP_BaseSwingConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E3D RID: 167485 RVA: 0x009B6E28 File Offset: 0x009B5028
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C");
			}
			return BP_CharacterSwingConfig_C._ClassPtr;
		}

		// Token: 0x06028E3E RID: 167486 RVA: 0x009B6E4C File Offset: 0x009B504C
		public BP_CharacterSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E3F RID: 167487 RVA: 0x009B6E74 File Offset: 0x009B5074
		public BP_CharacterSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x06028E40 RID: 167488 RVA: 0x009B6EA7 File Offset: 0x009B50A7
		// (set) Token: 0x06028E41 RID: 167489 RVA: 0x009B6EBC File Offset: 0x009B50BC
		public TSoftObjectPtr<UAnimMontage> SwingAnimation
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_CharacterSwingConfig_C.__PropertyOffset_0, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_CharacterSwingConfig_C.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06028E42 RID: 167490 RVA: 0x009B6EE1 File Offset: 0x009B50E1
		protected BP_CharacterSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E97 RID: 85655
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C";

		// Token: 0x04014E98 RID: 85656
		private static IntPtr _ClassPtr;

		// Token: 0x04014E99 RID: 85657
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E9A RID: 85658
		internal new static int __PropertyOffset_0;
	}
}
