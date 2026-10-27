using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200433C RID: 17212
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SWeaponMesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA53 RID: 182867 RVA: 0x00A24C3D File Offset: 0x00A22E3D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponMesh._ScriptStructPtr != 0) ? SWeaponMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh", ref SWeaponMesh._ScriptStructPtr);
		}

		// Token: 0x17007057 RID: 28759
		// (get) Token: 0x0602CA54 RID: 182868 RVA: 0x00A24C61 File Offset: 0x00A22E61
		// (set) Token: 0x0602CA55 RID: 182869 RVA: 0x00A24C75 File Offset: 0x00A22E75
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007058 RID: 28760
		// (get) Token: 0x0602CA56 RID: 182870 RVA: 0x00A24C8A File Offset: 0x00A22E8A
		// (set) Token: 0x0602CA57 RID: 182871 RVA: 0x00A24CA9 File Offset: 0x00A22EA9
		public TSoftObjectPtr<USkeletalMesh> MeshSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17007059 RID: 28761
		// (get) Token: 0x0602CA58 RID: 182872 RVA: 0x00A24CCE File Offset: 0x00A22ECE
		// (set) Token: 0x0602CA59 RID: 182873 RVA: 0x00A24CED File Offset: 0x00A22EED
		public TSoftClassPtr<UAnimInstance> AnimInstanceSoftPtr
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602CA5A RID: 182874 RVA: 0x00A24D12 File Offset: 0x00A22F12
		public SWeaponMesh()
		{
		}

		// Token: 0x0602CA5B RID: 182875 RVA: 0x00A24D1A File Offset: 0x00A22F1A
		public SWeaponMesh(FName SocketName, TSoftObjectPtr<USkeletalMesh> MeshSoftPtr, TSoftClassPtr<UAnimInstance> AnimInstanceSoftPtr)
		{
			this.SocketName = SocketName;
			this.MeshSoftPtr = MeshSoftPtr;
			this.AnimInstanceSoftPtr = AnimInstanceSoftPtr;
		}

		// Token: 0x0602CA5C RID: 182876 RVA: 0x00A24D37 File Offset: 0x00A22F37
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponMesh.StaticStruct();
		}

		// Token: 0x0602CA5D RID: 182877 RVA: 0x00A24D43 File Offset: 0x00A22F43
		[NullableContext(2)]
		public SWeaponMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA5E RID: 182878 RVA: 0x00A24D4D File Offset: 0x00A22F4D
		public SWeaponMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA5F RID: 182879 RVA: 0x00A24D58 File Offset: 0x00A22F58
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponMesh(Pointer, false, true);
		}

		// Token: 0x0602CA60 RID: 182880 RVA: 0x00A24D62 File Offset: 0x00A22F62
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04017889 RID: 96393
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh";

		// Token: 0x0401788A RID: 96394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401788B RID: 96395
		internal static int __PropertyOffset_0;

		// Token: 0x0401788C RID: 96396
		internal static int __PropertyOffset_1;

		// Token: 0x0401788D RID: 96397
		internal static int __PropertyOffset_2;
	}
}
