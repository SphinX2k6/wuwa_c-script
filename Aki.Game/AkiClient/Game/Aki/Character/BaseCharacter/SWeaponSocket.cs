using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433D RID: 17213
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SWeaponSocket : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA61 RID: 182881 RVA: 0x00A24D6B File Offset: 0x00A22F6B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponSocket._ScriptStructPtr != 0) ? SWeaponSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket", ref SWeaponSocket._ScriptStructPtr);
		}

		// Token: 0x1700705A RID: 28762
		// (get) Token: 0x0602CA62 RID: 182882 RVA: 0x00A24D90 File Offset: 0x00A22F90
		// (set) Token: 0x0602CA63 RID: 182883 RVA: 0x00A24DD3 File Offset: 0x00A22FD3
		public SWeaponSocketItem Weapon
		{
			get
			{
				base.FastCheckIsValid();
				SWeaponSocketItem result;
				if ((result = this._Weapon) == null)
				{
					result = (this._Weapon = new SWeaponSocketItem(base.NativePtr + (IntPtr)SWeaponSocket.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SWeaponSocketItem.StaticStruct(), base.NativePtr + (IntPtr)SWeaponSocket.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CA64 RID: 182884 RVA: 0x00A24DF4 File Offset: 0x00A22FF4
		public SWeaponSocket()
		{
		}

		// Token: 0x0602CA65 RID: 182885 RVA: 0x00A24DFC File Offset: 0x00A22FFC
		public SWeaponSocket(SWeaponSocketItem Weapon)
		{
			this.Weapon = Weapon;
		}

		// Token: 0x0602CA66 RID: 182886 RVA: 0x00A24E0B File Offset: 0x00A2300B
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponSocket.StaticStruct();
		}

		// Token: 0x0602CA67 RID: 182887 RVA: 0x00A24E17 File Offset: 0x00A23017
		[NullableContext(2)]
		public SWeaponSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA68 RID: 182888 RVA: 0x00A24E21 File Offset: 0x00A23021
		public SWeaponSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA69 RID: 182889 RVA: 0x00A24E2C File Offset: 0x00A2302C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponSocket(Pointer, false, true);
		}

		// Token: 0x0602CA6A RID: 182890 RVA: 0x00A24E36 File Offset: 0x00A23036
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponSocket(Pointer, MemoryOwner);
		}

		// Token: 0x0401788E RID: 96398
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponSocket.SWeaponSocket";

		// Token: 0x0401788F RID: 96399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017890 RID: 96400
		internal static int __PropertyOffset_0;

		// Token: 0x04017891 RID: 96401
		[Nullable(2)]
		private SWeaponSocketItem _Weapon;
	}
}
