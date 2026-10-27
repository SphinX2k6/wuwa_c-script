using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003EA2 RID: 16034
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleSubSkeletalInfo.SRoleSubSkeletalInfo")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class SRoleSubSkeletalInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060288F8 RID: 166136 RVA: 0x009AF312 File Offset: 0x009AD512
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSubSkeletalInfo._ScriptStructPtr != 0) ? SRoleSubSkeletalInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleSubSkeletalInfo.SRoleSubSkeletalInfo", ref SRoleSubSkeletalInfo._ScriptStructPtr);
		}

		// Token: 0x17005E7D RID: 24189
		// (get) Token: 0x060288F9 RID: 166137 RVA: 0x009AF336 File Offset: 0x009AD536
		// (set) Token: 0x060288FA RID: 166138 RVA: 0x009AF355 File Offset: 0x009AD555
		public TSoftObjectPtr<USkeletalMesh> 子骨骼模型
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E7E RID: 24190
		// (get) Token: 0x060288FB RID: 166139 RVA: 0x009AF37A File Offset: 0x009AD57A
		// (set) Token: 0x060288FC RID: 166140 RVA: 0x009AF399 File Offset: 0x009AD599
		public TSoftClassPtr<UAnimInstance> 子骨骼动画蓝图
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x060288FD RID: 166141 RVA: 0x009AF3BE File Offset: 0x009AD5BE
		// (set) Token: 0x060288FE RID: 166142 RVA: 0x009AF3D2 File Offset: 0x009AD5D2
		public unsafe FName 插槽名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSubSkeletalInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x060288FF RID: 166143 RVA: 0x009AF3E7 File Offset: 0x009AD5E7
		public SRoleSubSkeletalInfo()
		{
		}

		// Token: 0x06028900 RID: 166144 RVA: 0x009AF3EF File Offset: 0x009AD5EF
		public SRoleSubSkeletalInfo(TSoftObjectPtr<USkeletalMesh> 子骨骼模型, TSoftClassPtr<UAnimInstance> 子骨骼动画蓝图, FName 插槽名称)
		{
			this.子骨骼模型 = 子骨骼模型;
			this.子骨骼动画蓝图 = 子骨骼动画蓝图;
			this.插槽名称 = 插槽名称;
		}

		// Token: 0x06028901 RID: 166145 RVA: 0x009AF40C File Offset: 0x009AD60C
		protected override IntPtr GetUStructPtr()
		{
			return SRoleSubSkeletalInfo.StaticStruct();
		}

		// Token: 0x06028902 RID: 166146 RVA: 0x009AF418 File Offset: 0x009AD618
		[NullableContext(2)]
		public SRoleSubSkeletalInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028903 RID: 166147 RVA: 0x009AF422 File Offset: 0x009AD622
		public SRoleSubSkeletalInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028904 RID: 166148 RVA: 0x009AF42D File Offset: 0x009AD62D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleSubSkeletalInfo(Pointer, false, true);
		}

		// Token: 0x06028905 RID: 166149 RVA: 0x009AF437 File Offset: 0x009AD637
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleSubSkeletalInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AFB RID: 84731
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleSubSkeletalInfo.SRoleSubSkeletalInfo";

		// Token: 0x04014AFC RID: 84732
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AFD RID: 84733
		internal static int __PropertyOffset_0;

		// Token: 0x04014AFE RID: 84734
		internal static int __PropertyOffset_1;

		// Token: 0x04014AFF RID: 84735
		internal static int __PropertyOffset_2;
	}
}
