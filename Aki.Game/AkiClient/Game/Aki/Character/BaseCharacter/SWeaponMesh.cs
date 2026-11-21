using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003370 RID: 13168
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SWeaponMesh : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602170A RID: 136970 RVA: 0x009609B4 File Offset: 0x0095EBB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SWeaponMesh._ScriptStructPtr != 0) ? SWeaponMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh", ref SWeaponMesh._ScriptStructPtr);
		}

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x0602170B RID: 136971 RVA: 0x009609D8 File Offset: 0x0095EBD8
		// (set) Token: 0x0602170C RID: 136972 RVA: 0x009609EC File Offset: 0x0095EBEC
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x0602170D RID: 136973 RVA: 0x00960A01 File Offset: 0x0095EC01
		// (set) Token: 0x0602170E RID: 136974 RVA: 0x00960A20 File Offset: 0x0095EC20
		public TSoftObjectPtr<USkeletalMesh> MeshSoftPtr
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_MeshSoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_MeshSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x0602170F RID: 136975 RVA: 0x00960A45 File Offset: 0x0095EC45
		// (set) Token: 0x06021710 RID: 136976 RVA: 0x00960A64 File Offset: 0x0095EC64
		public TSoftClassPtr<UAnimInstance> AnimInstanceSoftPtr
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_AnimInstanceSoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SWeaponMesh.__PropertyOffset_AnimInstanceSoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021711 RID: 136977 RVA: 0x00960A89 File Offset: 0x0095EC89
		public SWeaponMesh()
		{
		}

		// Token: 0x06021712 RID: 136978 RVA: 0x00960A91 File Offset: 0x0095EC91
		protected override IntPtr GetUStructPtr()
		{
			return SWeaponMesh.StaticStruct();
		}

		// Token: 0x06021713 RID: 136979 RVA: 0x00960A9D File Offset: 0x0095EC9D
		[NullableContext(2)]
		public SWeaponMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021714 RID: 136980 RVA: 0x00960AA7 File Offset: 0x0095ECA7
		public SWeaponMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021715 RID: 136981 RVA: 0x00960AB2 File Offset: 0x0095ECB2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SWeaponMesh(Pointer, false, true);
		}

		// Token: 0x06021716 RID: 136982 RVA: 0x00960ABC File Offset: 0x0095ECBC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SWeaponMesh(Pointer, MemoryOwner);
		}

		// Token: 0x0401246A RID: 74858
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SWeaponMesh.SWeaponMesh";

		// Token: 0x0401246B RID: 74859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401246C RID: 74860
		internal static int __PropertyOffset_SocketName;

		// Token: 0x0401246D RID: 74861
		internal static int __PropertyOffset_MeshSoftPtr;

		// Token: 0x0401246E RID: 74862
		internal static int __PropertyOffset_AnimInstanceSoftPtr;
	}
}
