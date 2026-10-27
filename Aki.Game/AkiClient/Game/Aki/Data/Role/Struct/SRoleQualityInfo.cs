using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003E9E RID: 16030
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleQualityInfo.SRoleQualityInfo")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SRoleQualityInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060288A3 RID: 166051 RVA: 0x009AEB26 File Offset: 0x009ACD26
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleQualityInfo._ScriptStructPtr != 0) ? SRoleQualityInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleQualityInfo.SRoleQualityInfo", ref SRoleQualityInfo._ScriptStructPtr);
		}

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x060288A4 RID: 166052 RVA: 0x009AEB4A File Offset: 0x009ACD4A
		// (set) Token: 0x060288A5 RID: 166053 RVA: 0x009AEB5E File Offset: 0x009ACD5E
		public unsafe FName 品质名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x060288A6 RID: 166054 RVA: 0x009AEB73 File Offset: 0x009ACD73
		// (set) Token: 0x060288A7 RID: 166055 RVA: 0x009AEB92 File Offset: 0x009ACD92
		public TSoftObjectPtr<UTexture2D> 品质Icon
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x060288A8 RID: 166056 RVA: 0x009AEBB7 File Offset: 0x009ACDB7
		// (set) Token: 0x060288A9 RID: 166057 RVA: 0x009AEBD6 File Offset: 0x009ACDD6
		public TSoftObjectPtr<UTexture2D> 卡牌品质边框Icon
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x060288AA RID: 166058 RVA: 0x009AEBFB File Offset: 0x009ACDFB
		// (set) Token: 0x060288AB RID: 166059 RVA: 0x009AEC0F File Offset: 0x009ACE0F
		public unsafe FLinearColor 品质颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleQualityInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x060288AC RID: 166060 RVA: 0x009AEC24 File Offset: 0x009ACE24
		public SRoleQualityInfo()
		{
		}

		// Token: 0x060288AD RID: 166061 RVA: 0x009AEC2C File Offset: 0x009ACE2C
		public SRoleQualityInfo(FName 品质名称, TSoftObjectPtr<UTexture2D> 品质Icon, TSoftObjectPtr<UTexture2D> 卡牌品质边框Icon, FLinearColor 品质颜色)
		{
			this.品质名称 = 品质名称;
			this.品质Icon = 品质Icon;
			this.卡牌品质边框Icon = 卡牌品质边框Icon;
			this.品质颜色 = 品质颜色;
		}

		// Token: 0x060288AE RID: 166062 RVA: 0x009AEC51 File Offset: 0x009ACE51
		protected override IntPtr GetUStructPtr()
		{
			return SRoleQualityInfo.StaticStruct();
		}

		// Token: 0x060288AF RID: 166063 RVA: 0x009AEC5D File Offset: 0x009ACE5D
		[NullableContext(2)]
		public SRoleQualityInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060288B0 RID: 166064 RVA: 0x009AEC67 File Offset: 0x009ACE67
		public SRoleQualityInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060288B1 RID: 166065 RVA: 0x009AEC72 File Offset: 0x009ACE72
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleQualityInfo(Pointer, false, true);
		}

		// Token: 0x060288B2 RID: 166066 RVA: 0x009AEC7C File Offset: 0x009ACE7C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleQualityInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AD2 RID: 84690
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleQualityInfo.SRoleQualityInfo";

		// Token: 0x04014AD3 RID: 84691
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AD4 RID: 84692
		internal static int __PropertyOffset_0;

		// Token: 0x04014AD5 RID: 84693
		internal static int __PropertyOffset_1;

		// Token: 0x04014AD6 RID: 84694
		internal static int __PropertyOffset_2;

		// Token: 0x04014AD7 RID: 84695
		internal static int __PropertyOffset_3;
	}
}
