using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003E9F RID: 16031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleResonanceInfo.SRoleResonanceInfo")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class SRoleResonanceInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060288B3 RID: 166067 RVA: 0x009AEC85 File Offset: 0x009ACE85
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleResonanceInfo._ScriptStructPtr != 0) ? SRoleResonanceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleResonanceInfo.SRoleResonanceInfo", ref SRoleResonanceInfo._ScriptStructPtr);
		}

		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x060288B4 RID: 166068 RVA: 0x009AECA9 File Offset: 0x009ACEA9
		// (set) Token: 0x060288B5 RID: 166069 RVA: 0x009AECB9 File Offset: 0x009ACEB9
		public unsafe int 共鸣组Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x060288B6 RID: 166070 RVA: 0x009AECCA File Offset: 0x009ACECA
		// (set) Token: 0x060288B7 RID: 166071 RVA: 0x009AECDE File Offset: 0x009ACEDE
		public unsafe FName 共鸣名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x060288B8 RID: 166072 RVA: 0x009AECF3 File Offset: 0x009ACEF3
		// (set) Token: 0x060288B9 RID: 166073 RVA: 0x009AED03 File Offset: 0x009ACF03
		public unsafe int 共鸣Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x060288BA RID: 166074 RVA: 0x009AED14 File Offset: 0x009ACF14
		// (set) Token: 0x060288BB RID: 166075 RVA: 0x009AED57 File Offset: 0x009ACF57
		public TArray<int> 共鸣效果Id列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._共鸣效果Id列表) == null)
				{
					result = (this._共鸣效果Id列表 = new TArray<int>(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.共鸣效果Id列表.CopyAssign(value);
			}
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x060288BC RID: 166076 RVA: 0x009AED65 File Offset: 0x009ACF65
		// (set) Token: 0x060288BD RID: 166077 RVA: 0x009AED79 File Offset: 0x009ACF79
		public unsafe FName 共鸣效果描述
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x060288BE RID: 166078 RVA: 0x009AED8E File Offset: 0x009ACF8E
		// (set) Token: 0x060288BF RID: 166079 RVA: 0x009AED9E File Offset: 0x009ACF9E
		public unsafe int 增幅id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x060288C0 RID: 166080 RVA: 0x009AEDAF File Offset: 0x009ACFAF
		// (set) Token: 0x060288C1 RID: 166081 RVA: 0x009AEDCE File Offset: 0x009ACFCE
		public TSoftObjectPtr<UTexture2D> Icon路径
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x060288C2 RID: 166082 RVA: 0x009AEDF3 File Offset: 0x009ACFF3
		// (set) Token: 0x060288C3 RID: 166083 RVA: 0x009AEE03 File Offset: 0x009AD003
		public unsafe int 共鸣消耗Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleResonanceInfo.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060288C4 RID: 166084 RVA: 0x009AEE14 File Offset: 0x009AD014
		public SRoleResonanceInfo()
		{
		}

		// Token: 0x060288C5 RID: 166085 RVA: 0x009AEE1C File Offset: 0x009AD01C
		public SRoleResonanceInfo(int 共鸣组Id, FName 共鸣名称, int 共鸣Id, TArray<int> 共鸣效果Id列表, FName 共鸣效果描述, int 增幅id, TSoftObjectPtr<UTexture2D> Icon路径, int 共鸣消耗Id)
		{
			this.共鸣组Id = 共鸣组Id;
			this.共鸣名称 = 共鸣名称;
			this.共鸣Id = 共鸣Id;
			this.共鸣效果Id列表 = 共鸣效果Id列表;
			this.共鸣效果描述 = 共鸣效果描述;
			this.增幅id = 增幅id;
			this.Icon路径 = Icon路径;
			this.共鸣消耗Id = 共鸣消耗Id;
		}

		// Token: 0x060288C6 RID: 166086 RVA: 0x009AEE6C File Offset: 0x009AD06C
		protected override IntPtr GetUStructPtr()
		{
			return SRoleResonanceInfo.StaticStruct();
		}

		// Token: 0x060288C7 RID: 166087 RVA: 0x009AEE78 File Offset: 0x009AD078
		[NullableContext(2)]
		public SRoleResonanceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060288C8 RID: 166088 RVA: 0x009AEE82 File Offset: 0x009AD082
		public SRoleResonanceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060288C9 RID: 166089 RVA: 0x009AEE8D File Offset: 0x009AD08D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleResonanceInfo(Pointer, false, true);
		}

		// Token: 0x060288CA RID: 166090 RVA: 0x009AEE97 File Offset: 0x009AD097
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleResonanceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AD8 RID: 84696
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleResonanceInfo.SRoleResonanceInfo";

		// Token: 0x04014AD9 RID: 84697
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014ADA RID: 84698
		internal static int __PropertyOffset_0;

		// Token: 0x04014ADB RID: 84699
		internal static int __PropertyOffset_1;

		// Token: 0x04014ADC RID: 84700
		internal static int __PropertyOffset_2;

		// Token: 0x04014ADD RID: 84701
		internal static int __PropertyOffset_3;

		// Token: 0x04014ADE RID: 84702
		[Nullable(2)]
		private TArray<int> _共鸣效果Id列表;

		// Token: 0x04014ADF RID: 84703
		internal static int __PropertyOffset_4;

		// Token: 0x04014AE0 RID: 84704
		internal static int __PropertyOffset_5;

		// Token: 0x04014AE1 RID: 84705
		internal static int __PropertyOffset_6;

		// Token: 0x04014AE2 RID: 84706
		internal static int __PropertyOffset_7;
	}
}
