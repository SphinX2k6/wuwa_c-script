using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Interaction.Enum;
using AkiClient.Game.Aki.Data.Quest.Structures;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Interaction.Struct
{
	// Token: 0x02003F1C RID: 16156
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 241)]
	public class SInteractionOption : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029068 RID: 168040 RVA: 0x009B9EFA File Offset: 0x009B80FA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInteractionOption._ScriptStructPtr != 0) ? SInteractionOption._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption", ref SInteractionOption._ScriptStructPtr);
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x06029069 RID: 168041 RVA: 0x009B9F20 File Offset: 0x009B8120
		// (set) Token: 0x0602906A RID: 168042 RVA: 0x009B9F63 File Offset: 0x009B8163
		public unsafe FText 选项内容
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._选项内容) == null)
				{
					result = (this._选项内容 = new FText(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_0)), value.NativePtr, 1);
			}
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x0602906B RID: 168043 RVA: 0x009B9F7E File Offset: 0x009B817E
		// (set) Token: 0x0602906C RID: 168044 RVA: 0x009B9F92 File Offset: 0x009B8192
		[Nullable(0)]
		public unsafe TEnumAsByte<EInteractOptionType> 类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x0602906D RID: 168045 RVA: 0x009B9FA7 File Offset: 0x009B81A7
		// (set) Token: 0x0602906E RID: 168046 RVA: 0x009B9FBB File Offset: 0x009B81BB
		public unsafe FName 解锁条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x0602906F RID: 168047 RVA: 0x009B9FD0 File Offset: 0x009B81D0
		// (set) Token: 0x06029070 RID: 168048 RVA: 0x009BA013 File Offset: 0x009B8213
		public SQuestRequest 任务
		{
			get
			{
				base.FastCheckIsValid();
				SQuestRequest result;
				if ((result = this._任务) == null)
				{
					result = (this._任务 = new SQuestRequest(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SQuestRequest.StaticStruct(), base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x06029071 RID: 168049 RVA: 0x009BA034 File Offset: 0x009B8234
		// (set) Token: 0x06029072 RID: 168050 RVA: 0x009BA048 File Offset: 0x009B8248
		public unsafe FName 剧情ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x06029073 RID: 168051 RVA: 0x009BA05D File Offset: 0x009B825D
		// (set) Token: 0x06029074 RID: 168052 RVA: 0x009BA07C File Offset: 0x009B827C
		public TSoftObjectPtr<UDataTable> 剧情资源
		{
			get
			{
				return new TSoftObjectPtr<UDataTable>(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_5, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x06029075 RID: 168053 RVA: 0x009BA0A1 File Offset: 0x009B82A1
		// (set) Token: 0x06029076 RID: 168054 RVA: 0x009BA0B5 File Offset: 0x009B82B5
		public unsafe string Plot
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SInteractionOption.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x06029077 RID: 168055 RVA: 0x009BA0CA File Offset: 0x009B82CA
		// (set) Token: 0x06029078 RID: 168056 RVA: 0x009BA0DE File Offset: 0x009B82DE
		public unsafe FName 事件ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x06029079 RID: 168057 RVA: 0x009BA0F3 File Offset: 0x009B82F3
		// (set) Token: 0x0602907A RID: 168058 RVA: 0x009BA103 File Offset: 0x009B8303
		public unsafe bool 是否关闭交互界面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x0602907B RID: 168059 RVA: 0x009BA114 File Offset: 0x009B8314
		// (set) Token: 0x0602907C RID: 168060 RVA: 0x009BA128 File Offset: 0x009B8328
		public unsafe SInteractionLimit 交互选项限制
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x0602907D RID: 168061 RVA: 0x009BA13D File Offset: 0x009B833D
		// (set) Token: 0x0602907E RID: 168062 RVA: 0x009BA15C File Offset: 0x009B835C
		public TSoftObjectPtr<UTexture2D> 图标路径
		{
			get
			{
				return new TSoftObjectPtr<UTexture2D>(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_10, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_10, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x0602907F RID: 168063 RVA: 0x009BA181 File Offset: 0x009B8381
		// (set) Token: 0x06029080 RID: 168064 RVA: 0x009BA195 File Offset: 0x009B8395
		[Nullable(0)]
		public unsafe TEnumAsByte<EInteractionIconType> 交互图标类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_11);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SInteractionOption.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06029081 RID: 168065 RVA: 0x009BA1AA File Offset: 0x009B83AA
		public SInteractionOption()
		{
		}

		// Token: 0x06029082 RID: 168066 RVA: 0x009BA1B4 File Offset: 0x009B83B4
		public SInteractionOption(FText 选项内容, [Nullable(0)] TEnumAsByte<EInteractOptionType> 类型, FName 解锁条件组ID, SQuestRequest 任务, FName 剧情ID, TSoftObjectPtr<UDataTable> 剧情资源, string Plot, FName 事件ID, bool 是否关闭交互界面, SInteractionLimit 交互选项限制, TSoftObjectPtr<UTexture2D> 图标路径, [Nullable(0)] TEnumAsByte<EInteractionIconType> 交互图标类型)
		{
			this.选项内容 = 选项内容;
			this.类型 = 类型;
			this.解锁条件组ID = 解锁条件组ID;
			this.任务 = 任务;
			this.剧情ID = 剧情ID;
			this.剧情资源 = 剧情资源;
			this.Plot = Plot;
			this.事件ID = 事件ID;
			this.是否关闭交互界面 = 是否关闭交互界面;
			this.交互选项限制 = 交互选项限制;
			this.图标路径 = 图标路径;
			this.交互图标类型 = 交互图标类型;
		}

		// Token: 0x06029083 RID: 168067 RVA: 0x009BA224 File Offset: 0x009B8424
		protected override IntPtr GetUStructPtr()
		{
			return SInteractionOption.StaticStruct();
		}

		// Token: 0x06029084 RID: 168068 RVA: 0x009BA230 File Offset: 0x009B8430
		[NullableContext(2)]
		public SInteractionOption(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029085 RID: 168069 RVA: 0x009BA23A File Offset: 0x009B843A
		public SInteractionOption(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029086 RID: 168070 RVA: 0x009BA245 File Offset: 0x009B8445
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInteractionOption(Pointer, false, true);
		}

		// Token: 0x06029087 RID: 168071 RVA: 0x009BA24F File Offset: 0x009B844F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInteractionOption(Pointer, MemoryOwner);
		}

		// Token: 0x04014FE5 RID: 85989
		public const string __ObjectPath = "/Game/Aki/Data/Interaction/Struct/SInteractionOption.SInteractionOption";

		// Token: 0x04014FE6 RID: 85990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014FE7 RID: 85991
		internal static int __PropertyOffset_0;

		// Token: 0x04014FE8 RID: 85992
		[Nullable(2)]
		private FText _选项内容;

		// Token: 0x04014FE9 RID: 85993
		internal static int __PropertyOffset_1;

		// Token: 0x04014FEA RID: 85994
		internal static int __PropertyOffset_2;

		// Token: 0x04014FEB RID: 85995
		internal static int __PropertyOffset_3;

		// Token: 0x04014FEC RID: 85996
		[Nullable(2)]
		private SQuestRequest _任务;

		// Token: 0x04014FED RID: 85997
		internal static int __PropertyOffset_4;

		// Token: 0x04014FEE RID: 85998
		internal static int __PropertyOffset_5;

		// Token: 0x04014FEF RID: 85999
		internal static int __PropertyOffset_6;

		// Token: 0x04014FF0 RID: 86000
		internal static int __PropertyOffset_7;

		// Token: 0x04014FF1 RID: 86001
		internal static int __PropertyOffset_8;

		// Token: 0x04014FF2 RID: 86002
		internal static int __PropertyOffset_9;

		// Token: 0x04014FF3 RID: 86003
		internal static int __PropertyOffset_10;

		// Token: 0x04014FF4 RID: 86004
		internal static int __PropertyOffset_11;
	}
}
