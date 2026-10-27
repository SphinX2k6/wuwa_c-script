using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Role.Struct
{
	// Token: 0x02003EA0 RID: 16032
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Role/Struct/SRoleSkillInfo.SRoleSkillInfo")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 324)]
	public class SRoleSkillInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060288CB RID: 166091 RVA: 0x009AEEA0 File Offset: 0x009AD0A0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SRoleSkillInfo._ScriptStructPtr != 0) ? SRoleSkillInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Role/Struct/SRoleSkillInfo.SRoleSkillInfo", ref SRoleSkillInfo._ScriptStructPtr);
		}

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x060288CC RID: 166092 RVA: 0x009AEEC4 File Offset: 0x009AD0C4
		// (set) Token: 0x060288CD RID: 166093 RVA: 0x009AEED8 File Offset: 0x009AD0D8
		public unsafe FName 技能名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x060288CE RID: 166094 RVA: 0x009AEEED File Offset: 0x009AD0ED
		// (set) Token: 0x060288CF RID: 166095 RVA: 0x009AEEFD File Offset: 0x009AD0FD
		public unsafe int 技能组Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x060288D0 RID: 166096 RVA: 0x009AEF0E File Offset: 0x009AD10E
		// (set) Token: 0x060288D1 RID: 166097 RVA: 0x009AEF1E File Offset: 0x009AD11E
		public unsafe int 技能Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x060288D2 RID: 166098 RVA: 0x009AEF2F File Offset: 0x009AD12F
		// (set) Token: 0x060288D3 RID: 166099 RVA: 0x009AEF3F File Offset: 0x009AD13F
		public unsafe int 技能类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x060288D4 RID: 166100 RVA: 0x009AEF50 File Offset: 0x009AD150
		// (set) Token: 0x060288D5 RID: 166101 RVA: 0x009AEF60 File Offset: 0x009AD160
		public unsafe int 技能等级
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x060288D6 RID: 166102 RVA: 0x009AEF71 File Offset: 0x009AD171
		// (set) Token: 0x060288D7 RID: 166103 RVA: 0x009AEF81 File Offset: 0x009AD181
		public unsafe int 技能上限
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x060288D8 RID: 166104 RVA: 0x009AEF92 File Offset: 0x009AD192
		// (set) Token: 0x060288D9 RID: 166105 RVA: 0x009AEFA2 File Offset: 0x009AD1A2
		public unsafe bool 可升级标记
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x060288DA RID: 166106 RVA: 0x009AEFB4 File Offset: 0x009AD1B4
		// (set) Token: 0x060288DB RID: 166107 RVA: 0x009AEFF7 File Offset: 0x009AD1F7
		public TArray<int> 技能等级效果Id列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._技能等级效果Id列表) == null)
				{
					result = (this._技能等级效果Id列表 = new TArray<int>(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.技能等级效果Id列表.CopyAssign(value);
			}
		}

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x060288DC RID: 166108 RVA: 0x009AF005 File Offset: 0x009AD205
		// (set) Token: 0x060288DD RID: 166109 RVA: 0x009AF019 File Offset: 0x009AD219
		public unsafe FName 技能效果描述
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x060288DE RID: 166110 RVA: 0x009AF030 File Offset: 0x009AD230
		// (set) Token: 0x060288DF RID: 166111 RVA: 0x009AF073 File Offset: 0x009AD273
		public TMap<FName, FName> 详细描述
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._详细描述) == null)
				{
					result = (this._详细描述 = new TMap<FName, FName>(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.详细描述.CopyAssign(value);
			}
		}

		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x060288E0 RID: 166112 RVA: 0x009AF081 File Offset: 0x009AD281
		// (set) Token: 0x060288E1 RID: 166113 RVA: 0x009AF095 File Offset: 0x009AD295
		public unsafe FName 新增效果描述
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x060288E2 RID: 166114 RVA: 0x009AF0AA File Offset: 0x009AD2AA
		// (set) Token: 0x060288E3 RID: 166115 RVA: 0x009AF0C9 File Offset: 0x009AD2C9
		public TSoftObjectPtr<UTexture2D> 技能Icon
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_11, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_11, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005E7A RID: 24186
		// (get) Token: 0x060288E4 RID: 166116 RVA: 0x009AF0F0 File Offset: 0x009AD2F0
		// (set) Token: 0x060288E5 RID: 166117 RVA: 0x009AF133 File Offset: 0x009AD333
		public TMap<int, int> 升到该等级所消耗的物品
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._升到该等级所消耗的物品) == null)
				{
					result = (this._升到该等级所消耗的物品 = new TMap<int, int>(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_12, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.升到该等级所消耗的物品.CopyAssign(value);
			}
		}

		// Token: 0x17005E7B RID: 24187
		// (get) Token: 0x060288E6 RID: 166118 RVA: 0x009AF144 File Offset: 0x009AD344
		// (set) Token: 0x060288E7 RID: 166119 RVA: 0x009AF187 File Offset: 0x009AD387
		public TArray<int> 升级到该等级的条件Id
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._升级到该等级的条件Id) == null)
				{
					result = (this._升级到该等级的条件Id = new TArray<int>(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_13, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.升级到该等级的条件Id.CopyAssign(value);
			}
		}

		// Token: 0x17005E7C RID: 24188
		// (get) Token: 0x060288E8 RID: 166120 RVA: 0x009AF195 File Offset: 0x009AD395
		// (set) Token: 0x060288E9 RID: 166121 RVA: 0x009AF1A9 File Offset: 0x009AD3A9
		public unsafe FName 条件描述
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SRoleSkillInfo.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x060288EA RID: 166122 RVA: 0x009AF1BE File Offset: 0x009AD3BE
		public SRoleSkillInfo()
		{
		}

		// Token: 0x060288EB RID: 166123 RVA: 0x009AF1C8 File Offset: 0x009AD3C8
		public SRoleSkillInfo(FName 技能名称, int 技能组Id, int 技能Id, int 技能类型, int 技能等级, int 技能上限, bool 可升级标记, TArray<int> 技能等级效果Id列表, FName 技能效果描述, TMap<FName, FName> 详细描述, FName 新增效果描述, TSoftObjectPtr<UTexture2D> 技能Icon, TMap<int, int> 升到该等级所消耗的物品, TArray<int> 升级到该等级的条件Id, FName 条件描述)
		{
			this.技能名称 = 技能名称;
			this.技能组Id = 技能组Id;
			this.技能Id = 技能Id;
			this.技能类型 = 技能类型;
			this.技能等级 = 技能等级;
			this.技能上限 = 技能上限;
			this.可升级标记 = 可升级标记;
			this.技能等级效果Id列表 = 技能等级效果Id列表;
			this.技能效果描述 = 技能效果描述;
			this.详细描述 = 详细描述;
			this.新增效果描述 = 新增效果描述;
			this.技能Icon = 技能Icon;
			this.升到该等级所消耗的物品 = 升到该等级所消耗的物品;
			this.升级到该等级的条件Id = 升级到该等级的条件Id;
			this.条件描述 = 条件描述;
		}

		// Token: 0x060288EC RID: 166124 RVA: 0x009AF250 File Offset: 0x009AD450
		protected override IntPtr GetUStructPtr()
		{
			return SRoleSkillInfo.StaticStruct();
		}

		// Token: 0x060288ED RID: 166125 RVA: 0x009AF25C File Offset: 0x009AD45C
		[NullableContext(2)]
		public SRoleSkillInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060288EE RID: 166126 RVA: 0x009AF266 File Offset: 0x009AD466
		public SRoleSkillInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060288EF RID: 166127 RVA: 0x009AF271 File Offset: 0x009AD471
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SRoleSkillInfo(Pointer, false, true);
		}

		// Token: 0x060288F0 RID: 166128 RVA: 0x009AF27B File Offset: 0x009AD47B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SRoleSkillInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014AE3 RID: 84707
		public const string __ObjectPath = "/Game/Aki/Data/Role/Struct/SRoleSkillInfo.SRoleSkillInfo";

		// Token: 0x04014AE4 RID: 84708
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014AE5 RID: 84709
		internal static int __PropertyOffset_0;

		// Token: 0x04014AE6 RID: 84710
		internal static int __PropertyOffset_1;

		// Token: 0x04014AE7 RID: 84711
		internal static int __PropertyOffset_2;

		// Token: 0x04014AE8 RID: 84712
		internal static int __PropertyOffset_3;

		// Token: 0x04014AE9 RID: 84713
		internal static int __PropertyOffset_4;

		// Token: 0x04014AEA RID: 84714
		internal static int __PropertyOffset_5;

		// Token: 0x04014AEB RID: 84715
		internal static int __PropertyOffset_6;

		// Token: 0x04014AEC RID: 84716
		internal static int __PropertyOffset_7;

		// Token: 0x04014AED RID: 84717
		[Nullable(2)]
		private TArray<int> _技能等级效果Id列表;

		// Token: 0x04014AEE RID: 84718
		internal static int __PropertyOffset_8;

		// Token: 0x04014AEF RID: 84719
		internal static int __PropertyOffset_9;

		// Token: 0x04014AF0 RID: 84720
		[Nullable(2)]
		private TMap<FName, FName> _详细描述;

		// Token: 0x04014AF1 RID: 84721
		internal static int __PropertyOffset_10;

		// Token: 0x04014AF2 RID: 84722
		internal static int __PropertyOffset_11;

		// Token: 0x04014AF3 RID: 84723
		internal static int __PropertyOffset_12;

		// Token: 0x04014AF4 RID: 84724
		[Nullable(2)]
		private TMap<int, int> _升到该等级所消耗的物品;

		// Token: 0x04014AF5 RID: 84725
		internal static int __PropertyOffset_13;

		// Token: 0x04014AF6 RID: 84726
		[Nullable(2)]
		private TArray<int> _升级到该等级的条件Id;

		// Token: 0x04014AF7 RID: 84727
		internal static int __PropertyOffset_14;
	}
}
