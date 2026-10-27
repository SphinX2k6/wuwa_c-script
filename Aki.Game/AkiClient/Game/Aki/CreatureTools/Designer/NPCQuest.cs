using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FD1 RID: 16337
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/NPCQuest.NPCQuest")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class NPCQuest : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D59 RID: 171353 RVA: 0x009CD7E3 File Offset: 0x009CB9E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NPCQuest._ScriptStructPtr != 0) ? NPCQuest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/NPCQuest.NPCQuest", ref NPCQuest._ScriptStructPtr);
		}

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x06029D5A RID: 171354 RVA: 0x009CD807 File Offset: 0x009CBA07
		// (set) Token: 0x06029D5B RID: 171355 RVA: 0x009CD817 File Offset: 0x009CBA17
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x06029D5C RID: 171356 RVA: 0x009CD828 File Offset: 0x009CBA28
		// (set) Token: 0x06029D5D RID: 171357 RVA: 0x009CD83C File Offset: 0x009CBA3C
		public unsafe string QuestKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCQuest.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCQuest.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006579 RID: 25977
		// (get) Token: 0x06029D5E RID: 171358 RVA: 0x009CD851 File Offset: 0x009CBA51
		// (set) Token: 0x06029D5F RID: 171359 RVA: 0x009CD861 File Offset: 0x009CBA61
		public unsafe int QuestType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x06029D60 RID: 171360 RVA: 0x009CD872 File Offset: 0x009CBA72
		// (set) Token: 0x06029D61 RID: 171361 RVA: 0x009CD882 File Offset: 0x009CBA82
		public unsafe bool IsRepeat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700657B RID: 25979
		// (get) Token: 0x06029D62 RID: 171362 RVA: 0x009CD893 File Offset: 0x009CBA93
		// (set) Token: 0x06029D63 RID: 171363 RVA: 0x009CD8A3 File Offset: 0x009CBAA3
		public unsafe int Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuest.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x06029D64 RID: 171364 RVA: 0x009CD8B4 File Offset: 0x009CBAB4
		public NPCQuest()
		{
		}

		// Token: 0x06029D65 RID: 171365 RVA: 0x009CD8BC File Offset: 0x009CBABC
		public NPCQuest(int Id, string QuestKey, int QuestType, bool IsRepeat, int Duration)
		{
			this.Id = Id;
			this.QuestKey = QuestKey;
			this.QuestType = QuestType;
			this.IsRepeat = IsRepeat;
			this.Duration = Duration;
		}

		// Token: 0x06029D66 RID: 171366 RVA: 0x009CD8E9 File Offset: 0x009CBAE9
		protected override IntPtr GetUStructPtr()
		{
			return NPCQuest.StaticStruct();
		}

		// Token: 0x06029D67 RID: 171367 RVA: 0x009CD8F5 File Offset: 0x009CBAF5
		[NullableContext(2)]
		public NPCQuest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D68 RID: 171368 RVA: 0x009CD8FF File Offset: 0x009CBAFF
		public NPCQuest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D69 RID: 171369 RVA: 0x009CD90A File Offset: 0x009CBB0A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NPCQuest(Pointer, false, true);
		}

		// Token: 0x06029D6A RID: 171370 RVA: 0x009CD914 File Offset: 0x009CBB14
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NPCQuest(Pointer, MemoryOwner);
		}

		// Token: 0x040157BB RID: 87995
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/NPCQuest.NPCQuest";

		// Token: 0x040157BC RID: 87996
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157BD RID: 87997
		internal static int __PropertyOffset_0;

		// Token: 0x040157BE RID: 87998
		internal static int __PropertyOffset_1;

		// Token: 0x040157BF RID: 87999
		internal static int __PropertyOffset_2;

		// Token: 0x040157C0 RID: 88000
		internal static int __PropertyOffset_3;

		// Token: 0x040157C1 RID: 88001
		internal static int __PropertyOffset_4;
	}
}
