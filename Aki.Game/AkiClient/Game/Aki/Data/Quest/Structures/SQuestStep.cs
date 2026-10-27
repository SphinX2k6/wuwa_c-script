using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Quest.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Quest.Structures
{
	// Token: 0x02003EC2 RID: 16066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Structures/SQuestStep.SQuestStep")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 157)]
	public class SQuestStep : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A36 RID: 166454 RVA: 0x009B1032 File Offset: 0x009AF232
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQuestStep._ScriptStructPtr != 0) ? SQuestStep._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Quest/Structures/SQuestStep.SQuestStep", ref SQuestStep._ScriptStructPtr);
		}

		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x06028A37 RID: 166455 RVA: 0x009B1056 File Offset: 0x009AF256
		// (set) Token: 0x06028A38 RID: 166456 RVA: 0x009B1066 File Offset: 0x009AF266
		public unsafe int 步骤ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005ED5 RID: 24277
		// (get) Token: 0x06028A39 RID: 166457 RVA: 0x009B1078 File Offset: 0x009AF278
		// (set) Token: 0x06028A3A RID: 166458 RVA: 0x009B10BB File Offset: 0x009AF2BB
		public TArray<int> 承接步骤ID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._承接步骤ID) == null)
				{
					result = (this._承接步骤ID = new TArray<int>(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.承接步骤ID.CopyAssign(value);
			}
		}

		// Token: 0x17005ED6 RID: 24278
		// (get) Token: 0x06028A3B RID: 166459 RVA: 0x009B10C9 File Offset: 0x009AF2C9
		// (set) Token: 0x06028A3C RID: 166460 RVA: 0x009B10DD File Offset: 0x009AF2DD
		[Nullable(0)]
		public unsafe TEnumAsByte<EQuestStepOrder> 步骤连接类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_2);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17005ED7 RID: 24279
		// (get) Token: 0x06028A3D RID: 166461 RVA: 0x009B10F2 File Offset: 0x009AF2F2
		// (set) Token: 0x06028A3E RID: 166462 RVA: 0x009B1106 File Offset: 0x009AF306
		[Nullable(0)]
		public unsafe TEnumAsByte<EQuestStepState> 步骤状态
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x06028A3F RID: 166463 RVA: 0x009B111B File Offset: 0x009AF31B
		// (set) Token: 0x06028A40 RID: 166464 RVA: 0x009B112F File Offset: 0x009AF32F
		[Nullable(0)]
		public unsafe TEnumAsByte<EQuestStepType> 步骤类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x06028A41 RID: 166465 RVA: 0x009B1144 File Offset: 0x009AF344
		// (set) Token: 0x06028A42 RID: 166466 RVA: 0x009B1154 File Offset: 0x009AF354
		public unsafe int 追踪文本
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005EDA RID: 24282
		// (get) Token: 0x06028A43 RID: 166467 RVA: 0x009B1165 File Offset: 0x009AF365
		// (set) Token: 0x06028A44 RID: 166468 RVA: 0x009B1175 File Offset: 0x009AF375
		public unsafe int 步骤进度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005EDB RID: 24283
		// (get) Token: 0x06028A45 RID: 166469 RVA: 0x009B1186 File Offset: 0x009AF386
		// (set) Token: 0x06028A46 RID: 166470 RVA: 0x009B119A File Offset: 0x009AF39A
		public unsafe string 剧情ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQuestStep.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQuestStep.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x17005EDC RID: 24284
		// (get) Token: 0x06028A47 RID: 166471 RVA: 0x009B11B0 File Offset: 0x009AF3B0
		// (set) Token: 0x06028A48 RID: 166472 RVA: 0x009B11F3 File Offset: 0x009AF3F3
		public FSoftObjectPath 剧情资源
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._剧情资源) == null)
				{
					result = (this._剧情资源 = new FSoftObjectPath(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005EDD RID: 24285
		// (get) Token: 0x06028A49 RID: 166473 RVA: 0x009B1214 File Offset: 0x009AF414
		// (set) Token: 0x06028A4A RID: 166474 RVA: 0x009B1224 File Offset: 0x009AF424
		public unsafe bool 自动触发
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EDE RID: 24286
		// (get) Token: 0x06028A4B RID: 166475 RVA: 0x009B1235 File Offset: 0x009AF435
		// (set) Token: 0x06028A4C RID: 166476 RVA: 0x009B1245 File Offset: 0x009AF445
		public unsafe bool 是否需要全部承接步骤完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EDF RID: 24287
		// (get) Token: 0x06028A4D RID: 166477 RVA: 0x009B1256 File Offset: 0x009AF456
		// (set) Token: 0x06028A4E RID: 166478 RVA: 0x009B1266 File Offset: 0x009AF466
		public unsafe bool 是否显示追踪标记
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005EE0 RID: 24288
		// (get) Token: 0x06028A4F RID: 166479 RVA: 0x009B1277 File Offset: 0x009AF477
		// (set) Token: 0x06028A50 RID: 166480 RVA: 0x009B1287 File Offset: 0x009AF487
		public unsafe int 地图标记配置ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17005EE1 RID: 24289
		// (get) Token: 0x06028A51 RID: 166481 RVA: 0x009B1298 File Offset: 0x009AF498
		// (set) Token: 0x06028A52 RID: 166482 RVA: 0x009B12A8 File Offset: 0x009AF4A8
		public unsafe int 触发条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x06028A53 RID: 166483 RVA: 0x009B12B9 File Offset: 0x009AF4B9
		// (set) Token: 0x06028A54 RID: 166484 RVA: 0x009B12C9 File Offset: 0x009AF4C9
		public unsafe int 触发事件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x06028A55 RID: 166485 RVA: 0x009B12DA File Offset: 0x009AF4DA
		// (set) Token: 0x06028A56 RID: 166486 RVA: 0x009B12EA File Offset: 0x009AF4EA
		public unsafe int 完成条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x06028A57 RID: 166487 RVA: 0x009B12FB File Offset: 0x009AF4FB
		// (set) Token: 0x06028A58 RID: 166488 RVA: 0x009B130B File Offset: 0x009AF50B
		public unsafe int 完成事件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x06028A59 RID: 166489 RVA: 0x009B131C File Offset: 0x009AF51C
		// (set) Token: 0x06028A5A RID: 166490 RVA: 0x009B132C File Offset: 0x009AF52C
		public unsafe int 失败条件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x06028A5B RID: 166491 RVA: 0x009B133D File Offset: 0x009AF53D
		// (set) Token: 0x06028A5C RID: 166492 RVA: 0x009B134D File Offset: 0x009AF54D
		public unsafe int 失败事件组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x06028A5D RID: 166493 RVA: 0x009B135E File Offset: 0x009AF55E
		// (set) Token: 0x06028A5E RID: 166494 RVA: 0x009B136E File Offset: 0x009AF56E
		public unsafe int 步骤奖励组ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17005EE8 RID: 24296
		// (get) Token: 0x06028A5F RID: 166495 RVA: 0x009B1380 File Offset: 0x009AF580
		// (set) Token: 0x06028A60 RID: 166496 RVA: 0x009B13C3 File Offset: 0x009AF5C3
		public TArray<AActor> Triggers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._Triggers) == null)
				{
					result = (this._Triggers = new TArray<AActor>(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_20, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Triggers.CopyAssign(value);
			}
		}

		// Token: 0x17005EE9 RID: 24297
		// (get) Token: 0x06028A61 RID: 166497 RVA: 0x009B13D1 File Offset: 0x009AF5D1
		// (set) Token: 0x06028A62 RID: 166498 RVA: 0x009B13E5 File Offset: 0x009AF5E5
		public unsafe FVector TrackPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17005EEA RID: 24298
		// (get) Token: 0x06028A63 RID: 166499 RVA: 0x009B13FA File Offset: 0x009AF5FA
		// (set) Token: 0x06028A64 RID: 166500 RVA: 0x009B140A File Offset: 0x009AF60A
		public unsafe bool 是否添加地图标记
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestStep.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028A65 RID: 166501 RVA: 0x009B141B File Offset: 0x009AF61B
		public SQuestStep()
		{
		}

		// Token: 0x06028A66 RID: 166502 RVA: 0x009B1424 File Offset: 0x009AF624
		public SQuestStep(int 步骤ID, TArray<int> 承接步骤ID, [Nullable(0)] TEnumAsByte<EQuestStepOrder> 步骤连接类型, [Nullable(0)] TEnumAsByte<EQuestStepState> 步骤状态, [Nullable(0)] TEnumAsByte<EQuestStepType> 步骤类型, int 追踪文本, int 步骤进度, string 剧情ID, FSoftObjectPath 剧情资源, bool 自动触发, bool 是否需要全部承接步骤完成, bool 是否显示追踪标记, int 地图标记配置ID, int 触发条件组ID, int 触发事件组ID, int 完成条件组ID, int 完成事件组ID, int 失败条件组ID, int 失败事件组ID, int 步骤奖励组ID, TArray<AActor> Triggers, FVector TrackPosition, bool 是否添加地图标记)
		{
			this.步骤ID = 步骤ID;
			this.承接步骤ID = 承接步骤ID;
			this.步骤连接类型 = 步骤连接类型;
			this.步骤状态 = 步骤状态;
			this.步骤类型 = 步骤类型;
			this.追踪文本 = 追踪文本;
			this.步骤进度 = 步骤进度;
			this.剧情ID = 剧情ID;
			this.剧情资源 = 剧情资源;
			this.自动触发 = 自动触发;
			this.是否需要全部承接步骤完成 = 是否需要全部承接步骤完成;
			this.是否显示追踪标记 = 是否显示追踪标记;
			this.地图标记配置ID = 地图标记配置ID;
			this.触发条件组ID = 触发条件组ID;
			this.触发事件组ID = 触发事件组ID;
			this.完成条件组ID = 完成条件组ID;
			this.完成事件组ID = 完成事件组ID;
			this.失败条件组ID = 失败条件组ID;
			this.失败事件组ID = 失败事件组ID;
			this.步骤奖励组ID = 步骤奖励组ID;
			this.Triggers = Triggers;
			this.TrackPosition = TrackPosition;
			this.是否添加地图标记 = 是否添加地图标记;
		}

		// Token: 0x06028A67 RID: 166503 RVA: 0x009B14EC File Offset: 0x009AF6EC
		protected override IntPtr GetUStructPtr()
		{
			return SQuestStep.StaticStruct();
		}

		// Token: 0x06028A68 RID: 166504 RVA: 0x009B14F8 File Offset: 0x009AF6F8
		[NullableContext(2)]
		public SQuestStep(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A69 RID: 166505 RVA: 0x009B1502 File Offset: 0x009AF702
		public SQuestStep(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A6A RID: 166506 RVA: 0x009B150D File Offset: 0x009AF70D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQuestStep(Pointer, false, true);
		}

		// Token: 0x06028A6B RID: 166507 RVA: 0x009B1517 File Offset: 0x009AF717
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQuestStep(Pointer, MemoryOwner);
		}

		// Token: 0x04014BDA RID: 84954
		public const string __ObjectPath = "/Game/Aki/Data/Quest/Structures/SQuestStep.SQuestStep";

		// Token: 0x04014BDB RID: 84955
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BDC RID: 84956
		internal static int __PropertyOffset_0;

		// Token: 0x04014BDD RID: 84957
		internal static int __PropertyOffset_1;

		// Token: 0x04014BDE RID: 84958
		[Nullable(2)]
		private TArray<int> _承接步骤ID;

		// Token: 0x04014BDF RID: 84959
		internal static int __PropertyOffset_2;

		// Token: 0x04014BE0 RID: 84960
		internal static int __PropertyOffset_3;

		// Token: 0x04014BE1 RID: 84961
		internal static int __PropertyOffset_4;

		// Token: 0x04014BE2 RID: 84962
		internal static int __PropertyOffset_5;

		// Token: 0x04014BE3 RID: 84963
		internal static int __PropertyOffset_6;

		// Token: 0x04014BE4 RID: 84964
		internal static int __PropertyOffset_7;

		// Token: 0x04014BE5 RID: 84965
		internal static int __PropertyOffset_8;

		// Token: 0x04014BE6 RID: 84966
		[Nullable(2)]
		private FSoftObjectPath _剧情资源;

		// Token: 0x04014BE7 RID: 84967
		internal static int __PropertyOffset_9;

		// Token: 0x04014BE8 RID: 84968
		internal static int __PropertyOffset_10;

		// Token: 0x04014BE9 RID: 84969
		internal static int __PropertyOffset_11;

		// Token: 0x04014BEA RID: 84970
		internal static int __PropertyOffset_12;

		// Token: 0x04014BEB RID: 84971
		internal static int __PropertyOffset_13;

		// Token: 0x04014BEC RID: 84972
		internal static int __PropertyOffset_14;

		// Token: 0x04014BED RID: 84973
		internal static int __PropertyOffset_15;

		// Token: 0x04014BEE RID: 84974
		internal static int __PropertyOffset_16;

		// Token: 0x04014BEF RID: 84975
		internal static int __PropertyOffset_17;

		// Token: 0x04014BF0 RID: 84976
		internal static int __PropertyOffset_18;

		// Token: 0x04014BF1 RID: 84977
		internal static int __PropertyOffset_19;

		// Token: 0x04014BF2 RID: 84978
		internal static int __PropertyOffset_20;

		// Token: 0x04014BF3 RID: 84979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _Triggers;

		// Token: 0x04014BF4 RID: 84980
		internal static int __PropertyOffset_21;

		// Token: 0x04014BF5 RID: 84981
		internal static int __PropertyOffset_22;
	}
}
