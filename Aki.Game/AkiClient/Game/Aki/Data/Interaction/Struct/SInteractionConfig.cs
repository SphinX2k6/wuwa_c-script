using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Interaction.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x02003F1A RID: 16154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 202)]
	public class SInteractionConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602903F RID: 167999 RVA: 0x009B9ACC File Offset: 0x009B7CCC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionConfig._ScriptStructPtr != 0) ? SInteractionConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig", ref SInteractionConfig._ScriptStructPtr);
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x06029040 RID: 168000 RVA: 0x009B9AF0 File Offset: 0x009B7CF0
		// (set) Token: 0x06029041 RID: 168001 RVA: 0x009B9B04 File Offset: 0x009B7D04
		public unsafe FName ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x06029042 RID: 168002 RVA: 0x009B9B19 File Offset: 0x009B7D19
		// (set) Token: 0x06029043 RID: 168003 RVA: 0x009B9B2D File Offset: 0x009B7D2D
		public unsafe FName 组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x06029044 RID: 168004 RVA: 0x009B9B42 File Offset: 0x009B7D42
		// (set) Token: 0x06029045 RID: 168005 RVA: 0x009B9B52 File Offset: 0x009B7D52
		public unsafe bool 是否自动触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x06029046 RID: 168006 RVA: 0x009B9B63 File Offset: 0x009B7D63
		// (set) Token: 0x06029047 RID: 168007 RVA: 0x009B9B77 File Offset: 0x009B7D77
		[Nullable(0)]
		public unsafe TEnumAsByte<EInteractionType> 交互类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x06029048 RID: 168008 RVA: 0x009B9B8C File Offset: 0x009B7D8C
		// (set) Token: 0x06029049 RID: 168009 RVA: 0x009B9BCF File Offset: 0x009B7DCF
		public TArray<SInteractionOption> 交互选项组
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInteractionOption> result;
				if ((result = this._交互选项组) == null)
				{
					result = (this._交互选项组 = new TArray<SInteractionOption>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.交互选项组.CopyAssign(value);
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x0602904A RID: 168010 RVA: 0x009B9BDD File Offset: 0x009B7DDD
		// (set) Token: 0x0602904B RID: 168011 RVA: 0x009B9BF1 File Offset: 0x009B7DF1
		public unsafe FName 交互SequenceNetwrokID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x0602904C RID: 168012 RVA: 0x009B9C06 File Offset: 0x009B7E06
		// (set) Token: 0x0602904D RID: 168013 RVA: 0x009B9C25 File Offset: 0x009B7E25
		public TSoftObjectPtr<UDataTable> 交互SequenceNetwrok
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_6, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_6, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x0602904E RID: 168014 RVA: 0x009B9C4A File Offset: 0x009B7E4A
		// (set) Token: 0x0602904F RID: 168015 RVA: 0x009B9C5E File Offset: 0x009B7E5E
		public unsafe FName 交互条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x06029050 RID: 168016 RVA: 0x009B9C73 File Offset: 0x009B7E73
		// (set) Token: 0x06029051 RID: 168017 RVA: 0x009B9C83 File Offset: 0x009B7E83
		public unsafe float 交互范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x06029052 RID: 168018 RVA: 0x009B9C94 File Offset: 0x009B7E94
		// (set) Token: 0x06029053 RID: 168019 RVA: 0x009B9CD7 File Offset: 0x009B7ED7
		public unsafe FText 描述
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._描述) == null)
				{
					result = (this._描述 = new FText(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_9, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionConfig.__PropertyOffset_9)), value.NativePtr, 1);
			}
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x06029054 RID: 168020 RVA: 0x009B9CF2 File Offset: 0x009B7EF2
		// (set) Token: 0x06029055 RID: 168021 RVA: 0x009B9D11 File Offset: 0x009B7F11
		public TSoftObjectPtr<UTexture2D> 图标路径
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_10, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x06029056 RID: 168022 RVA: 0x009B9D36 File Offset: 0x009B7F36
		// (set) Token: 0x06029057 RID: 168023 RVA: 0x009B9D4A File Offset: 0x009B7F4A
		[Nullable(0)]
		public unsafe TEnumAsByte<EInteractionIconType> 图标类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x06029058 RID: 168024 RVA: 0x009B9D5F File Offset: 0x009B7F5F
		// (set) Token: 0x06029059 RID: 168025 RVA: 0x009B9D6F File Offset: 0x009B7F6F
		public unsafe bool 是否添加离开选项
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionConfig.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602905A RID: 168026 RVA: 0x009B9D80 File Offset: 0x009B7F80
		public SInteractionConfig()
		{
		}

		// Token: 0x0602905B RID: 168027 RVA: 0x009B9D88 File Offset: 0x009B7F88
		public SInteractionConfig(FName ID, FName 组ID, bool 是否自动触发, [Nullable(0)] TEnumAsByte<EInteractionType> 交互类型, TArray<SInteractionOption> 交互选项组, FName 交互SequenceNetwrokID, TSoftObjectPtr<UDataTable> 交互SequenceNetwrok, FName 交互条件组ID, float 交互范围, FText 描述, TSoftObjectPtr<UTexture2D> 图标路径, [Nullable(0)] TEnumAsByte<EInteractionIconType> 图标类型, bool 是否添加离开选项)
		{
			this.ID = ID;
			this.组ID = 组ID;
			this.是否自动触发 = 是否自动触发;
			this.交互类型 = 交互类型;
			this.交互选项组 = 交互选项组;
			this.交互SequenceNetwrokID = 交互SequenceNetwrokID;
			this.交互SequenceNetwrok = 交互SequenceNetwrok;
			this.交互条件组ID = 交互条件组ID;
			this.交互范围 = 交互范围;
			this.描述 = 描述;
			this.图标路径 = 图标路径;
			this.图标类型 = 图标类型;
			this.是否添加离开选项 = 是否添加离开选项;
		}

		// Token: 0x0602905C RID: 168028 RVA: 0x009B9E00 File Offset: 0x009B8000
		protected override IntPtr GetUStructPtr()
		{
			return SInteractionConfig.StaticStruct();
		}

		// Token: 0x0602905D RID: 168029 RVA: 0x009B9E0C File Offset: 0x009B800C
		[NullableContext(2)]
		public SInteractionConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602905E RID: 168030 RVA: 0x009B9E16 File Offset: 0x009B8016
		public SInteractionConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602905F RID: 168031 RVA: 0x009B9E21 File Offset: 0x009B8021
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractionConfig(Pointer, false, true);
		}

		// Token: 0x06029060 RID: 168032 RVA: 0x009B9E2B File Offset: 0x009B802B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractionConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04014FCF RID: 85967
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionConfig.SInteractionConfig";

		// Token: 0x04014FD0 RID: 85968
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014FD1 RID: 85969
		internal static int __PropertyOffset_0;

		// Token: 0x04014FD2 RID: 85970
		internal static int __PropertyOffset_1;

		// Token: 0x04014FD3 RID: 85971
		internal static int __PropertyOffset_2;

		// Token: 0x04014FD4 RID: 85972
		internal static int __PropertyOffset_3;

		// Token: 0x04014FD5 RID: 85973
		internal static int __PropertyOffset_4;

		// Token: 0x04014FD6 RID: 85974
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SInteractionOption> _交互选项组;

		// Token: 0x04014FD7 RID: 85975
		internal static int __PropertyOffset_5;

		// Token: 0x04014FD8 RID: 85976
		internal static int __PropertyOffset_6;

		// Token: 0x04014FD9 RID: 85977
		internal static int __PropertyOffset_7;

		// Token: 0x04014FDA RID: 85978
		internal static int __PropertyOffset_8;

		// Token: 0x04014FDB RID: 85979
		internal static int __PropertyOffset_9;

		// Token: 0x04014FDC RID: 85980
		[Nullable(2)]
		private FText _描述;

		// Token: 0x04014FDD RID: 85981
		internal static int __PropertyOffset_10;

		// Token: 0x04014FDE RID: 85982
		internal static int __PropertyOffset_11;

		// Token: 0x04014FDF RID: 85983
		internal static int __PropertyOffset_12;
	}
}
