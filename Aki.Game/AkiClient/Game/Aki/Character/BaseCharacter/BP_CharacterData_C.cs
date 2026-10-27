using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427B RID: 17019
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_CharacterData.BP_CharacterData_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_CharacterData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C2B0 RID: 180912 RVA: 0x00A18D1B File Offset: 0x00A16F1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_CharacterData.BP_CharacterData_C");
			}
			return BP_CharacterData_C._ClassPtr;
		}

		// Token: 0x0602C2B1 RID: 180913 RVA: 0x00A18D40 File Offset: 0x00A16F40
		public BP_CharacterData_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C2B2 RID: 180914 RVA: 0x00A18D68 File Offset: 0x00A16F68
		[NullableContext(1)]
		public BP_CharacterData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DED RID: 28141
		// (get) Token: 0x0602C2B3 RID: 180915 RVA: 0x00A18D9C File Offset: 0x00A16F9C
		// (set) Token: 0x0602C2B4 RID: 180916 RVA: 0x00A18DD5 File Offset: 0x00A16FD5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ECharacterState>, FGameplayTagContainer> CharacterStateTags
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
				TMap<TEnumAsByte<ECharacterState>, FGameplayTagContainer> result;
				if ((result = this._CharacterStateTags) == null)
				{
					result = (this._CharacterStateTags = new TMap<TEnumAsByte<ECharacterState>, FGameplayTagContainer>(base.NativePtr + (IntPtr)BP_CharacterData_C.__PropertyOffset_0, this));
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
				this.CharacterStateTags.CopyAssign(value);
			}
		}

		// Token: 0x0602C2B5 RID: 180917 RVA: 0x00A18DE3 File Offset: 0x00A16FE3
		protected BP_CharacterData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171C9 RID: 94665
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_CharacterData.BP_CharacterData_C";

		// Token: 0x040171CA RID: 94666
		private static IntPtr _ClassPtr;

		// Token: 0x040171CB RID: 94667
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171CC RID: 94668
		internal static int __PropertyOffset_0;

		// Token: 0x040171CD RID: 94669
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ECharacterState>, FGameplayTagContainer> _CharacterStateTags;
	}
}
