using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Role.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003E9D RID: 16029
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleMeshInfo.SRoleMeshInfo")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class SRoleMeshInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602888D RID: 166029 RVA: 0x009AE8DC File Offset: 0x009ACADC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleMeshInfo._ScriptStructPtr != 0) ? SRoleMeshInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleMeshInfo.SRoleMeshInfo", ref SRoleMeshInfo._ScriptStructPtr);
		}

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x0602888E RID: 166030 RVA: 0x009AE900 File Offset: 0x009ACB00
		// (set) Token: 0x0602888F RID: 166031 RVA: 0x009AE914 File Offset: 0x009ACB14
		public unsafe FName 模型名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x06028890 RID: 166032 RVA: 0x009AE929 File Offset: 0x009ACB29
		// (set) Token: 0x06028891 RID: 166033 RVA: 0x009AE939 File Offset: 0x009ACB39
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x06028892 RID: 166034 RVA: 0x009AE94A File Offset: 0x009ACB4A
		// (set) Token: 0x06028893 RID: 166035 RVA: 0x009AE969 File Offset: 0x009ACB69
		public TSoftObjectPtr<USkeletalMesh> 角色骨骼模型
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x06028894 RID: 166036 RVA: 0x009AE98E File Offset: 0x009ACB8E
		// (set) Token: 0x06028895 RID: 166037 RVA: 0x009AE9AD File Offset: 0x009ACBAD
		public TSoftClassPtr<UAnimInstance> 角色动画蓝图
		{
			get
			{
				return new TSoftClassPtr<UAnimInstance>(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x06028896 RID: 166038 RVA: 0x009AE9D4 File Offset: 0x009ACBD4
		// (set) Token: 0x06028897 RID: 166039 RVA: 0x009AEA17 File Offset: 0x009ACC17
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ESubRoleSkeletalMeshType>, SRoleSubSkeletalInfo> 子骨骼信息
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
				TMap<TEnumAsByte<ESubRoleSkeletalMeshType>, SRoleSubSkeletalInfo> result;
				if ((result = this._子骨骼信息) == null)
				{
					result = (this._子骨骼信息 = new TMap<TEnumAsByte<ESubRoleSkeletalMeshType>, SRoleSubSkeletalInfo>(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
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
				this.子骨骼信息.CopyAssign(value);
			}
		}

		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x06028898 RID: 166040 RVA: 0x009AEA25 File Offset: 0x009ACC25
		// (set) Token: 0x06028899 RID: 166041 RVA: 0x009AEA44 File Offset: 0x009ACC44
		public TSoftClassPtr<TsBaseCharacter> 角色类
		{
			get
			{
				return new TSoftClassPtr<TsBaseCharacter>(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x0602889A RID: 166042 RVA: 0x009AEA69 File Offset: 0x009ACC69
		// (set) Token: 0x0602889B RID: 166043 RVA: 0x009AEA88 File Offset: 0x009ACC88
		public TSoftObjectPtr<UAnimSequence> 预览时的动画
		{
			get
			{
				return new TSoftObjectPtr<UAnimSequence>(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleMeshInfo.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602889C RID: 166044 RVA: 0x009AEAAD File Offset: 0x009ACCAD
		public SRoleMeshInfo()
		{
		}

		// Token: 0x0602889D RID: 166045 RVA: 0x009AEAB5 File Offset: 0x009ACCB5
		public SRoleMeshInfo(FName 模型名称, int ID, TSoftObjectPtr<USkeletalMesh> 角色骨骼模型, TSoftClassPtr<UAnimInstance> 角色动画蓝图, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] TMap<TEnumAsByte<ESubRoleSkeletalMeshType>, SRoleSubSkeletalInfo> 子骨骼信息, TSoftClassPtr<TsBaseCharacter> 角色类, TSoftObjectPtr<UAnimSequence> 预览时的动画)
		{
			this.模型名称 = 模型名称;
			this.ID = ID;
			this.角色骨骼模型 = 角色骨骼模型;
			this.角色动画蓝图 = 角色动画蓝图;
			this.子骨骼信息 = 子骨骼信息;
			this.角色类 = 角色类;
			this.预览时的动画 = 预览时的动画;
		}

		// Token: 0x0602889E RID: 166046 RVA: 0x009AEAF2 File Offset: 0x009ACCF2
		protected override IntPtr GetUStructPtr()
		{
			return SRoleMeshInfo.StaticStruct();
		}

		// Token: 0x0602889F RID: 166047 RVA: 0x009AEAFE File Offset: 0x009ACCFE
		[NullableContext(2)]
		public SRoleMeshInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060288A0 RID: 166048 RVA: 0x009AEB08 File Offset: 0x009ACD08
		public SRoleMeshInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060288A1 RID: 166049 RVA: 0x009AEB13 File Offset: 0x009ACD13
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleMeshInfo(Pointer, false, true);
		}

		// Token: 0x060288A2 RID: 166050 RVA: 0x009AEB1D File Offset: 0x009ACD1D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleMeshInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AC8 RID: 84680
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleMeshInfo.SRoleMeshInfo";

		// Token: 0x04014AC9 RID: 84681
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014ACA RID: 84682
		internal static int __PropertyOffset_0;

		// Token: 0x04014ACB RID: 84683
		internal static int __PropertyOffset_1;

		// Token: 0x04014ACC RID: 84684
		internal static int __PropertyOffset_2;

		// Token: 0x04014ACD RID: 84685
		internal static int __PropertyOffset_3;

		// Token: 0x04014ACE RID: 84686
		internal static int __PropertyOffset_4;

		// Token: 0x04014ACF RID: 84687
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ESubRoleSkeletalMeshType>, SRoleSubSkeletalInfo> _子骨骼信息;

		// Token: 0x04014AD0 RID: 84688
		internal static int __PropertyOffset_5;

		// Token: 0x04014AD1 RID: 84689
		internal static int __PropertyOffset_6;
	}
}
