using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Quest.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Quest.Structures
{
	// Token: 0x02003EC0 RID: 16064
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Structures/SQuest.SQuest")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 33)]
	public class SQuest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A0C RID: 166412 RVA: 0x009B0D16 File Offset: 0x009AEF16
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQuest._ScriptStructPtr != 0) ? SQuest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Quest/Structures/SQuest.SQuest", ref SQuest._ScriptStructPtr);
		}

		// Token: 0x17005EC7 RID: 24263
		// (get) Token: 0x06028A0D RID: 166413 RVA: 0x009B0D3A File Offset: 0x009AEF3A
		// (set) Token: 0x06028A0E RID: 166414 RVA: 0x009B0D4A File Offset: 0x009AEF4A
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x06028A0F RID: 166415 RVA: 0x009B0D5B File Offset: 0x009AEF5B
		// (set) Token: 0x06028A10 RID: 166416 RVA: 0x009B0D6B File Offset: 0x009AEF6B
		public unsafe int 任务名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x06028A11 RID: 166417 RVA: 0x009B0D7C File Offset: 0x009AEF7C
		// (set) Token: 0x06028A12 RID: 166418 RVA: 0x009B0D90 File Offset: 0x009AEF90
		[Nullable(1)]
		public unsafe string 任务KEY
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SQuest.__PropertyOffset_2)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SQuest.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x06028A13 RID: 166419 RVA: 0x009B0DA5 File Offset: 0x009AEFA5
		// (set) Token: 0x06028A14 RID: 166420 RVA: 0x009B0DB9 File Offset: 0x009AEFB9
		public unsafe TEnumAsByte<EQuestType> 任务类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x06028A15 RID: 166421 RVA: 0x009B0DCE File Offset: 0x009AEFCE
		// (set) Token: 0x06028A16 RID: 166422 RVA: 0x009B0DDE File Offset: 0x009AEFDE
		public unsafe bool 是否可重复
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x06028A17 RID: 166423 RVA: 0x009B0DEF File Offset: 0x009AEFEF
		// (set) Token: 0x06028A18 RID: 166424 RVA: 0x009B0DFF File Offset: 0x009AEFFF
		public unsafe bool 是否完成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005ECD RID: 24269
		// (get) Token: 0x06028A19 RID: 166425 RVA: 0x009B0E10 File Offset: 0x009AF010
		// (set) Token: 0x06028A1A RID: 166426 RVA: 0x009B0E20 File Offset: 0x009AF020
		public unsafe int 任务详细信息
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005ECE RID: 24270
		// (get) Token: 0x06028A1B RID: 166427 RVA: 0x009B0E31 File Offset: 0x009AF031
		// (set) Token: 0x06028A1C RID: 166428 RVA: 0x009B0E41 File Offset: 0x009AF041
		public unsafe bool 是否可联机
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuest.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x06028A1D RID: 166429 RVA: 0x009B0E52 File Offset: 0x009AF052
		public SQuest()
		{
		}

		// Token: 0x06028A1E RID: 166430 RVA: 0x009B0E5C File Offset: 0x009AF05C
		public SQuest(int ID, int 任务名称, [Nullable(1)] string 任务KEY, TEnumAsByte<EQuestType> 任务类型, bool 是否可重复, bool 是否完成, int 任务详细信息, bool 是否可联机)
		{
			this.ID = ID;
			this.任务名称 = 任务名称;
			this.任务KEY = 任务KEY;
			this.任务类型 = 任务类型;
			this.是否可重复 = 是否可重复;
			this.是否完成 = 是否完成;
			this.任务详细信息 = 任务详细信息;
			this.是否可联机 = 是否可联机;
		}

		// Token: 0x06028A1F RID: 166431 RVA: 0x009B0EAC File Offset: 0x009AF0AC
		protected override IntPtr GetUStructPtr()
		{
			return SQuest.StaticStruct();
		}

		// Token: 0x06028A20 RID: 166432 RVA: 0x009B0EB8 File Offset: 0x009AF0B8
		[NullableContext(2)]
		public SQuest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A21 RID: 166433 RVA: 0x009B0EC2 File Offset: 0x009AF0C2
		public SQuest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A22 RID: 166434 RVA: 0x009B0ECD File Offset: 0x009AF0CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQuest(Pointer, false, true);
		}

		// Token: 0x06028A23 RID: 166435 RVA: 0x009B0ED7 File Offset: 0x009AF0D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQuest(Pointer, MemoryOwner);
		}

		// Token: 0x04014BC9 RID: 84937
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Quest/Structures/SQuest.SQuest";

		// Token: 0x04014BCA RID: 84938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BCB RID: 84939
		internal static int __PropertyOffset_0;

		// Token: 0x04014BCC RID: 84940
		internal static int __PropertyOffset_1;

		// Token: 0x04014BCD RID: 84941
		internal static int __PropertyOffset_2;

		// Token: 0x04014BCE RID: 84942
		internal static int __PropertyOffset_3;

		// Token: 0x04014BCF RID: 84943
		internal static int __PropertyOffset_4;

		// Token: 0x04014BD0 RID: 84944
		internal static int __PropertyOffset_5;

		// Token: 0x04014BD1 RID: 84945
		internal static int __PropertyOffset_6;

		// Token: 0x04014BD2 RID: 84946
		internal static int __PropertyOffset_7;
	}
}
