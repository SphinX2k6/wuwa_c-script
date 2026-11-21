using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003371 RID: 13169
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SWeaponSocket : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021717 RID: 136983 RVA: 0x00960AC5 File Offset: 0x0095ECC5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponSocket._ScriptStructPtr != 0) ? SWeaponSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket", ref SWeaponSocket._ScriptStructPtr);
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x06021718 RID: 136984 RVA: 0x00960AEC File Offset: 0x0095ECEC
		// (set) Token: 0x06021719 RID: 136985 RVA: 0x00960B2F File Offset: 0x0095ED2F
		public SWeaponSocketItem Weapon
		{
			get
			{
				base.FastCheckIsValid();
				SWeaponSocketItem result;
				if ((result = this._Weapon) == null)
				{
					result = (this._Weapon = new SWeaponSocketItem(base.NativePtr + (IntPtr)SWeaponSocket.__PropertyOffset_Weapon, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponSocketItem.StaticStruct(), base.NativePtr + (IntPtr)SWeaponSocket.__PropertyOffset_Weapon, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602171A RID: 136986 RVA: 0x00960B50 File Offset: 0x0095ED50
		public SWeaponSocket()
		{
		}

		// Token: 0x0602171B RID: 136987 RVA: 0x00960B58 File Offset: 0x0095ED58
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponSocket.StaticStruct();
		}

		// Token: 0x0602171C RID: 136988 RVA: 0x00960B64 File Offset: 0x0095ED64
		[NullableContext(2)]
		public SWeaponSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602171D RID: 136989 RVA: 0x00960B6E File Offset: 0x0095ED6E
		public SWeaponSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602171E RID: 136990 RVA: 0x00960B79 File Offset: 0x0095ED79
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponSocket(Pointer, false, true);
		}

		// Token: 0x0602171F RID: 136991 RVA: 0x00960B83 File Offset: 0x0095ED83
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponSocket(Pointer, MemoryOwner);
		}

		// Token: 0x0401246F RID: 74863
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket";

		// Token: 0x04012470 RID: 74864
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012471 RID: 74865
		internal static int __PropertyOffset_Weapon;

		// Token: 0x04012472 RID: 74866
		[Nullable(2)]
		private SWeaponSocketItem _Weapon;
	}
}
