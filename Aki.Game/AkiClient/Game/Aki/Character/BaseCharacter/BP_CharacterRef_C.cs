using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Fight.AssestStruct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427C RID: 17020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_CharacterRef.BP_CharacterRef_C")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class BP_CharacterRef_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C2B6 RID: 180918 RVA: 0x00A18DEC File Offset: 0x00A16FEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterRef_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_CharacterRef.BP_CharacterRef_C");
			}
			return BP_CharacterRef_C._ClassPtr;
		}

		// Token: 0x0602C2B7 RID: 180919 RVA: 0x00A18E10 File Offset: 0x00A17010
		public BP_CharacterRef_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRef_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C2B8 RID: 180920 RVA: 0x00A18E38 File Offset: 0x00A17038
		public BP_CharacterRef_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterRef_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DEE RID: 28142
		// (get) Token: 0x0602C2B9 RID: 180921 RVA: 0x00A18E6B File Offset: 0x00A1706B
		// (set) Token: 0x0602C2BA RID: 180922 RVA: 0x00A18E7F File Offset: 0x00A1707F
		public unsafe SClimbInfo NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006DEF RID: 28143
		// (get) Token: 0x0602C2BB RID: 180923 RVA: 0x00A18E94 File Offset: 0x00A17094
		// (set) Token: 0x0602C2BC RID: 180924 RVA: 0x00A18EA8 File Offset: 0x00A170A8
		public unsafe SClimbState NewVar_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006DF0 RID: 28144
		// (get) Token: 0x0602C2BD RID: 180925 RVA: 0x00A18EBD File Offset: 0x00A170BD
		// (set) Token: 0x0602C2BE RID: 180926 RVA: 0x00A18ED1 File Offset: 0x00A170D1
		[Nullable(2)]
		public unsafe BP_SplineMoveConfig_C NewVar_2
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SplineMoveConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterRef_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterRef_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006DF1 RID: 28145
		// (get) Token: 0x0602C2BF RID: 180927 RVA: 0x00A18EE8 File Offset: 0x00A170E8
		// (set) Token: 0x0602C2C0 RID: 180928 RVA: 0x00A18F21 File Offset: 0x00A17121
		public SCameraModifier_Condition NewVar_3
		{
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_Condition result;
				if ((result = this._NewVar_3) == null)
				{
					result = (this._NewVar_3 = new SCameraModifier_Condition(base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_Condition.StaticStruct(), base.NativePtr + (IntPtr)BP_CharacterRef_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602C2C1 RID: 180929 RVA: 0x00A18F42 File Offset: 0x00A17142
		protected BP_CharacterRef_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171CE RID: 94670
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_CharacterRef.BP_CharacterRef_C";

		// Token: 0x040171CF RID: 94671
		private static IntPtr _ClassPtr;

		// Token: 0x040171D0 RID: 94672
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171D1 RID: 94673
		internal static int __PropertyOffset_0;

		// Token: 0x040171D2 RID: 94674
		internal static int __PropertyOffset_1;

		// Token: 0x040171D3 RID: 94675
		internal static int __PropertyOffset_2;

		// Token: 0x040171D4 RID: 94676
		internal static int __PropertyOffset_3;

		// Token: 0x040171D5 RID: 94677
		[Nullable(2)]
		private SCameraModifier_Condition _NewVar_3;
	}
}
