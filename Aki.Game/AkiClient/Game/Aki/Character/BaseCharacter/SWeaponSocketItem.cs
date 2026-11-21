using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003372 RID: 13170
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SWeaponSocketItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021720 RID: 136992 RVA: 0x00960B8C File Offset: 0x0095ED8C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponSocketItem._ScriptStructPtr != 0) ? SWeaponSocketItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem", ref SWeaponSocketItem._ScriptStructPtr);
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x06021721 RID: 136993 RVA: 0x00960BB0 File Offset: 0x0095EDB0
		// (set) Token: 0x06021722 RID: 136994 RVA: 0x00960BF3 File Offset: 0x0095EDF3
		public TArray<SWeaponMesh> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWeaponMesh> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<SWeaponMesh>(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_Meshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x06021723 RID: 136995 RVA: 0x00960C01 File Offset: 0x0095EE01
		// (set) Token: 0x06021724 RID: 136996 RVA: 0x00960C15 File Offset: 0x0095EE15
		public unsafe FName DropSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_DropSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_DropSocket) = value;
			}
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x06021725 RID: 136997 RVA: 0x00960C2A File Offset: 0x0095EE2A
		// (set) Token: 0x06021726 RID: 136998 RVA: 0x00960C3E File Offset: 0x0095EE3E
		public unsafe FVector DropVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_DropVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_DropVelocity) = value;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x06021727 RID: 136999 RVA: 0x00960C53 File Offset: 0x0095EE53
		// (set) Token: 0x06021728 RID: 137000 RVA: 0x00960C67 File Offset: 0x0095EE67
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x06021729 RID: 137001 RVA: 0x00960C7C File Offset: 0x0095EE7C
		// (set) Token: 0x0602172A RID: 137002 RVA: 0x00960CBF File Offset: 0x0095EEBF
		public FSoftObjectPath WeaponEffectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._WeaponEffectPath) == null)
				{
					result = (this._WeaponEffectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_WeaponEffectPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_WeaponEffectPath, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602172B RID: 137003 RVA: 0x00960CE0 File Offset: 0x0095EEE0
		public SWeaponSocketItem()
		{
		}

		// Token: 0x0602172C RID: 137004 RVA: 0x00960CE8 File Offset: 0x0095EEE8
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponSocketItem.StaticStruct();
		}

		// Token: 0x0602172D RID: 137005 RVA: 0x00960CF4 File Offset: 0x0095EEF4
		[NullableContext(2)]
		public SWeaponSocketItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602172E RID: 137006 RVA: 0x00960CFE File Offset: 0x0095EEFE
		public SWeaponSocketItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602172F RID: 137007 RVA: 0x00960D09 File Offset: 0x0095EF09
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponSocketItem(Pointer, false, true);
		}

		// Token: 0x06021730 RID: 137008 RVA: 0x00960D13 File Offset: 0x0095EF13
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponSocketItem(Pointer, MemoryOwner);
		}

		// Token: 0x04012473 RID: 74867
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem";

		// Token: 0x04012474 RID: 74868
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012475 RID: 74869
		internal static int __PropertyOffset_Meshes;

		// Token: 0x04012476 RID: 74870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWeaponMesh> _Meshes;

		// Token: 0x04012477 RID: 74871
		internal static int __PropertyOffset_DropSocket;

		// Token: 0x04012478 RID: 74872
		internal static int __PropertyOffset_DropVelocity;

		// Token: 0x04012479 RID: 74873
		internal static int __PropertyOffset_Tag;

		// Token: 0x0401247A RID: 74874
		internal static int __PropertyOffset_WeaponEffectPath;

		// Token: 0x0401247B RID: 74875
		[Nullable(2)]
		private FSoftObjectPath _WeaponEffectPath;
	}
}
