using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Quest.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Quest.Structures
{
	// Token: 0x02003EC1 RID: 16065
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Structures/SQuestRequest.SQuestRequest")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SQuestRequest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028A24 RID: 166436 RVA: 0x009B0EE0 File Offset: 0x009AF0E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SQuestRequest._ScriptStructPtr != 0) ? SQuestRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Quest/Structures/SQuestRequest.SQuestRequest", ref SQuestRequest._ScriptStructPtr);
		}

		// Token: 0x17005ECF RID: 24271
		// (get) Token: 0x06028A25 RID: 166437 RVA: 0x009B0F04 File Offset: 0x009AF104
		// (set) Token: 0x06028A26 RID: 166438 RVA: 0x009B0F18 File Offset: 0x009AF118
		public unsafe FName QuestID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005ED0 RID: 24272
		// (get) Token: 0x06028A27 RID: 166439 RVA: 0x009B0F2D File Offset: 0x009AF12D
		// (set) Token: 0x06028A28 RID: 166440 RVA: 0x009B0F41 File Offset: 0x009AF141
		public unsafe FName QuestStepID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17005ED1 RID: 24273
		// (get) Token: 0x06028A29 RID: 166441 RVA: 0x009B0F56 File Offset: 0x009AF156
		// (set) Token: 0x06028A2A RID: 166442 RVA: 0x009B0F6A File Offset: 0x009AF16A
		[Nullable(2)]
		public unsafe UDataTable QuestData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + SQuestRequest.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SQuestRequest.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x06028A2B RID: 166443 RVA: 0x009B0F7F File Offset: 0x009AF17F
		// (set) Token: 0x06028A2C RID: 166444 RVA: 0x009B0F93 File Offset: 0x009AF193
		public unsafe TEnumAsByte<EQuestHandleType> QuesetHandleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17005ED3 RID: 24275
		// (get) Token: 0x06028A2D RID: 166445 RVA: 0x009B0FA8 File Offset: 0x009AF1A8
		// (set) Token: 0x06028A2E RID: 166446 RVA: 0x009B0FB8 File Offset: 0x009AF1B8
		public unsafe float QuestDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SQuestRequest.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06028A2F RID: 166447 RVA: 0x009B0FC9 File Offset: 0x009AF1C9
		public SQuestRequest()
		{
		}

		// Token: 0x06028A30 RID: 166448 RVA: 0x009B0FD1 File Offset: 0x009AF1D1
		public SQuestRequest(FName QuestID, FName QuestStepID, [Nullable(1)] UDataTable QuestData, TEnumAsByte<EQuestHandleType> QuesetHandleType, float QuestDelay)
		{
			this.QuestID = QuestID;
			this.QuestStepID = QuestStepID;
			this.QuestData = QuestData;
			this.QuesetHandleType = QuesetHandleType;
			this.QuestDelay = QuestDelay;
		}

		// Token: 0x06028A31 RID: 166449 RVA: 0x009B0FFE File Offset: 0x009AF1FE
		protected override IntPtr GetUStructPtr()
		{
			return SQuestRequest.StaticStruct();
		}

		// Token: 0x06028A32 RID: 166450 RVA: 0x009B100A File Offset: 0x009AF20A
		[NullableContext(2)]
		public SQuestRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028A33 RID: 166451 RVA: 0x009B1014 File Offset: 0x009AF214
		public SQuestRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028A34 RID: 166452 RVA: 0x009B101F File Offset: 0x009AF21F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SQuestRequest(Pointer, false, true);
		}

		// Token: 0x06028A35 RID: 166453 RVA: 0x009B1029 File Offset: 0x009AF229
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SQuestRequest(Pointer, MemoryOwner);
		}

		// Token: 0x04014BD3 RID: 84947
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Quest/Structures/SQuestRequest.SQuestRequest";

		// Token: 0x04014BD4 RID: 84948
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014BD5 RID: 84949
		internal static int __PropertyOffset_0;

		// Token: 0x04014BD6 RID: 84950
		internal static int __PropertyOffset_1;

		// Token: 0x04014BD7 RID: 84951
		internal static int __PropertyOffset_2;

		// Token: 0x04014BD8 RID: 84952
		internal static int __PropertyOffset_3;

		// Token: 0x04014BD9 RID: 84953
		internal static int __PropertyOffset_4;
	}
}
