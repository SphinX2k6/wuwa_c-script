using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433E RID: 17214
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SWeaponSocketItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA6B RID: 182891 RVA: 0x00A24E3F File Offset: 0x00A2303F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponSocketItem._ScriptStructPtr != 0) ? SWeaponSocketItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem", ref SWeaponSocketItem._ScriptStructPtr);
		}

		// Token: 0x1700705B RID: 28763
		// (get) Token: 0x0602CA6C RID: 182892 RVA: 0x00A24E64 File Offset: 0x00A23064
		// (set) Token: 0x0602CA6D RID: 182893 RVA: 0x00A24EA7 File Offset: 0x00A230A7
		public TArray<SWeaponMesh> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SWeaponMesh> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<SWeaponMesh>(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x1700705C RID: 28764
		// (get) Token: 0x0602CA6E RID: 182894 RVA: 0x00A24EB5 File Offset: 0x00A230B5
		// (set) Token: 0x0602CA6F RID: 182895 RVA: 0x00A24EC9 File Offset: 0x00A230C9
		public unsafe FName DropSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700705D RID: 28765
		// (get) Token: 0x0602CA70 RID: 182896 RVA: 0x00A24EDE File Offset: 0x00A230DE
		// (set) Token: 0x0602CA71 RID: 182897 RVA: 0x00A24EF2 File Offset: 0x00A230F2
		public unsafe FVector DropVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700705E RID: 28766
		// (get) Token: 0x0602CA72 RID: 182898 RVA: 0x00A24F07 File Offset: 0x00A23107
		// (set) Token: 0x0602CA73 RID: 182899 RVA: 0x00A24F1B File Offset: 0x00A2311B
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700705F RID: 28767
		// (get) Token: 0x0602CA74 RID: 182900 RVA: 0x00A24F30 File Offset: 0x00A23130
		// (set) Token: 0x0602CA75 RID: 182901 RVA: 0x00A24F73 File Offset: 0x00A23173
		public FSoftObjectPath WeaponEffectPath
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._WeaponEffectPath) == null)
				{
					result = (this._WeaponEffectPath = new FSoftObjectPath(base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SWeaponSocketItem.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CA76 RID: 182902 RVA: 0x00A24F94 File Offset: 0x00A23194
		public SWeaponSocketItem()
		{
		}

		// Token: 0x0602CA77 RID: 182903 RVA: 0x00A24F9C File Offset: 0x00A2319C
		public SWeaponSocketItem(TArray<SWeaponMesh> Meshes, FName DropSocket, FVector DropVelocity, FGameplayTag Tag, FSoftObjectPath WeaponEffectPath)
		{
			this.Meshes = Meshes;
			this.DropSocket = DropSocket;
			this.DropVelocity = DropVelocity;
			this.Tag = Tag;
			this.WeaponEffectPath = WeaponEffectPath;
		}

		// Token: 0x0602CA78 RID: 182904 RVA: 0x00A24FC9 File Offset: 0x00A231C9
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponSocketItem.StaticStruct();
		}

		// Token: 0x0602CA79 RID: 182905 RVA: 0x00A24FD5 File Offset: 0x00A231D5
		[NullableContext(2)]
		public SWeaponSocketItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA7A RID: 182906 RVA: 0x00A24FDF File Offset: 0x00A231DF
		public SWeaponSocketItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA7B RID: 182907 RVA: 0x00A24FEA File Offset: 0x00A231EA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponSocketItem(Pointer, false, true);
		}

		// Token: 0x0602CA7C RID: 182908 RVA: 0x00A24FF4 File Offset: 0x00A231F4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponSocketItem(Pointer, MemoryOwner);
		}

		// Token: 0x04017892 RID: 96402
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponSocketItem.SWeaponSocketItem";

		// Token: 0x04017893 RID: 96403
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017894 RID: 96404
		internal static int __PropertyOffset_0;

		// Token: 0x04017895 RID: 96405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SWeaponMesh> _Meshes;

		// Token: 0x04017896 RID: 96406
		internal static int __PropertyOffset_1;

		// Token: 0x04017897 RID: 96407
		internal static int __PropertyOffset_2;

		// Token: 0x04017898 RID: 96408
		internal static int __PropertyOffset_3;

		// Token: 0x04017899 RID: 96409
		internal static int __PropertyOffset_4;

		// Token: 0x0401789A RID: 96410
		[Nullable(2)]
		private FSoftObjectPath _WeaponEffectPath;
	}
}
