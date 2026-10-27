using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FD4 RID: 16340
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/QuestStepAll.QuestStepAll")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class QuestStepAll : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029DA7 RID: 171431 RVA: 0x009CDE56 File Offset: 0x009CC056
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (QuestStepAll._ScriptStructPtr != 0) ? QuestStepAll._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/QuestStepAll.QuestStepAll", ref QuestStepAll._ScriptStructPtr);
		}

		// Token: 0x17006592 RID: 26002
		// (get) Token: 0x06029DA8 RID: 171432 RVA: 0x009CDE7A File Offset: 0x009CC07A
		// (set) Token: 0x06029DA9 RID: 171433 RVA: 0x009CDE8E File Offset: 0x009CC08E
		public unsafe string DefineMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)QuestStepAll.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)QuestStepAll.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006593 RID: 26003
		// (get) Token: 0x06029DAA RID: 171434 RVA: 0x009CDEA3 File Offset: 0x009CC0A3
		// (set) Token: 0x06029DAB RID: 171435 RVA: 0x009CDEB7 File Offset: 0x009CC0B7
		public unsafe string DataMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)QuestStepAll.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)QuestStepAll.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006594 RID: 26004
		// (get) Token: 0x06029DAC RID: 171436 RVA: 0x009CDECC File Offset: 0x009CC0CC
		// (set) Token: 0x06029DAD RID: 171437 RVA: 0x009CDF0F File Offset: 0x009CC10F
		public TArray<NPCQuestStep> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<NPCQuestStep> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<NPCQuestStep>(base.NativePtr + (IntPtr)QuestStepAll.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06029DAE RID: 171438 RVA: 0x009CDF1D File Offset: 0x009CC11D
		public QuestStepAll()
		{
		}

		// Token: 0x06029DAF RID: 171439 RVA: 0x009CDF25 File Offset: 0x009CC125
		public QuestStepAll(string DefineMd5, string DataMd5, TArray<NPCQuestStep> Data)
		{
			this.DefineMd5 = DefineMd5;
			this.DataMd5 = DataMd5;
			this.Data = Data;
		}

		// Token: 0x06029DB0 RID: 171440 RVA: 0x009CDF42 File Offset: 0x009CC142
		protected override IntPtr GetUStructPtr()
		{
			return QuestStepAll.StaticStruct();
		}

		// Token: 0x06029DB1 RID: 171441 RVA: 0x009CDF4E File Offset: 0x009CC14E
		[NullableContext(2)]
		public QuestStepAll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029DB2 RID: 171442 RVA: 0x009CDF58 File Offset: 0x009CC158
		public QuestStepAll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029DB3 RID: 171443 RVA: 0x009CDF63 File Offset: 0x009CC163
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new QuestStepAll(Pointer, false, true);
		}

		// Token: 0x06029DB4 RID: 171444 RVA: 0x009CDF6D File Offset: 0x009CC16D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new QuestStepAll(Pointer, MemoryOwner);
		}

		// Token: 0x040157E0 RID: 88032
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/QuestStepAll.QuestStepAll";

		// Token: 0x040157E1 RID: 88033
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157E2 RID: 88034
		internal static int __PropertyOffset_0;

		// Token: 0x040157E3 RID: 88035
		internal static int __PropertyOffset_1;

		// Token: 0x040157E4 RID: 88036
		internal static int __PropertyOffset_2;

		// Token: 0x040157E5 RID: 88037
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NPCQuestStep> _Data;
	}
}
