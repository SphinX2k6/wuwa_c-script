using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Swing
{
	// Token: 0x020031BE RID: 12734
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_CharacterSwingConfig_C : BP_BaseSwingConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7D1 RID: 128977 RVA: 0x0092EE10 File Offset: 0x0092D010
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterSwingConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C");
			}
			return BP_CharacterSwingConfig_C._ClassPtr;
		}

		// Token: 0x0601F7D2 RID: 128978 RVA: 0x0092EE34 File Offset: 0x0092D034
		public BP_CharacterSwingConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterSwingConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7D3 RID: 128979 RVA: 0x0092EE5C File Offset: 0x0092D05C
		public BP_CharacterSwingConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterSwingConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0601F7D4 RID: 128980 RVA: 0x0092EE8F File Offset: 0x0092D08F
		// (set) Token: 0x0601F7D5 RID: 128981 RVA: 0x0092EEA4 File Offset: 0x0092D0A4
		public TSoftObjectPtr<UAnimMontage> SwingAnimation
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)BP_CharacterSwingConfig_C.__PropertyOffset_SwingAnimation, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_CharacterSwingConfig_C.__PropertyOffset_SwingAnimation, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601F7D6 RID: 128982 RVA: 0x0092EEC9 File Offset: 0x0092D0C9
		protected BP_CharacterSwingConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E37 RID: 69175
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Swing/BP_CharacterSwingConfig.BP_CharacterSwingConfig_C";

		// Token: 0x04010E38 RID: 69176
		private static IntPtr _ClassPtr;

		// Token: 0x04010E39 RID: 69177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E3A RID: 69178
		internal static int __PropertyOffset_SwingAnimation;
	}
}
