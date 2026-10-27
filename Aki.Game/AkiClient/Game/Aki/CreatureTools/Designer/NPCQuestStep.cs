using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FD2 RID: 16338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/NPCQuestStep.NPCQuestStep")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class NPCQuestStep : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D6B RID: 171371 RVA: 0x009CD91D File Offset: 0x009CBB1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (NPCQuestStep._ScriptStructPtr != 0) ? NPCQuestStep._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/NPCQuestStep.NPCQuestStep", ref NPCQuestStep._ScriptStructPtr);
		}

		// Token: 0x1700657C RID: 25980
		// (get) Token: 0x06029D6C RID: 171372 RVA: 0x009CD941 File Offset: 0x009CBB41
		// (set) Token: 0x06029D6D RID: 171373 RVA: 0x009CD951 File Offset: 0x009CBB51
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700657D RID: 25981
		// (get) Token: 0x06029D6E RID: 171374 RVA: 0x009CD962 File Offset: 0x009CBB62
		// (set) Token: 0x06029D6F RID: 171375 RVA: 0x009CD972 File Offset: 0x009CBB72
		public unsafe int QuestKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700657E RID: 25982
		// (get) Token: 0x06029D70 RID: 171376 RVA: 0x009CD983 File Offset: 0x009CBB83
		// (set) Token: 0x06029D71 RID: 171377 RVA: 0x009CD993 File Offset: 0x009CBB93
		public unsafe int StepId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700657F RID: 25983
		// (get) Token: 0x06029D72 RID: 171378 RVA: 0x009CD9A4 File Offset: 0x009CBBA4
		// (set) Token: 0x06029D73 RID: 171379 RVA: 0x009CD9E7 File Offset: 0x009CBBE7
		public TArray<int> NeedSteps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._NeedSteps) == null)
				{
					result = (this._NeedSteps = new TArray<int>(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NeedSteps.CopyAssign(value);
			}
		}

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x06029D74 RID: 171380 RVA: 0x009CD9F5 File Offset: 0x009CBBF5
		// (set) Token: 0x06029D75 RID: 171381 RVA: 0x009CDA05 File Offset: 0x009CBC05
		public unsafe int ProcessType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x06029D76 RID: 171382 RVA: 0x009CDA16 File Offset: 0x009CBC16
		// (set) Token: 0x06029D77 RID: 171383 RVA: 0x009CDA26 File Offset: 0x009CBC26
		public unsafe bool IsAutoAccept
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x06029D78 RID: 171384 RVA: 0x009CDA37 File Offset: 0x009CBC37
		// (set) Token: 0x06029D79 RID: 171385 RVA: 0x009CDA47 File Offset: 0x009CBC47
		public unsafe bool IsAllFinish
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x06029D7A RID: 171386 RVA: 0x009CDA58 File Offset: 0x009CBC58
		// (set) Token: 0x06029D7B RID: 171387 RVA: 0x009CDA6C File Offset: 0x009CBC6C
		public unsafe string StepType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)NPCQuestStep.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)NPCQuestStep.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x06029D7C RID: 171388 RVA: 0x009CDA81 File Offset: 0x009CBC81
		// (set) Token: 0x06029D7D RID: 171389 RVA: 0x009CDA91 File Offset: 0x009CBC91
		public unsafe int AcceptCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x06029D7E RID: 171390 RVA: 0x009CDAA2 File Offset: 0x009CBCA2
		// (set) Token: 0x06029D7F RID: 171391 RVA: 0x009CDAB2 File Offset: 0x009CBCB2
		public unsafe int AcceptedAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x06029D80 RID: 171392 RVA: 0x009CDAC3 File Offset: 0x009CBCC3
		// (set) Token: 0x06029D81 RID: 171393 RVA: 0x009CDAD3 File Offset: 0x009CBCD3
		public unsafe int TargetCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x06029D82 RID: 171394 RVA: 0x009CDAE4 File Offset: 0x009CBCE4
		// (set) Token: 0x06029D83 RID: 171395 RVA: 0x009CDAF4 File Offset: 0x009CBCF4
		public unsafe int SubmitAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x06029D84 RID: 171396 RVA: 0x009CDB05 File Offset: 0x009CBD05
		// (set) Token: 0x06029D85 RID: 171397 RVA: 0x009CDB15 File Offset: 0x009CBD15
		public unsafe int FailCondition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x06029D86 RID: 171398 RVA: 0x009CDB26 File Offset: 0x009CBD26
		// (set) Token: 0x06029D87 RID: 171399 RVA: 0x009CDB36 File Offset: 0x009CBD36
		public unsafe int FailAction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x06029D88 RID: 171400 RVA: 0x009CDB47 File Offset: 0x009CBD47
		// (set) Token: 0x06029D89 RID: 171401 RVA: 0x009CDB57 File Offset: 0x009CBD57
		public unsafe int RewardId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x06029D8A RID: 171402 RVA: 0x009CDB68 File Offset: 0x009CBD68
		// (set) Token: 0x06029D8B RID: 171403 RVA: 0x009CDBAB File Offset: 0x009CBDAB
		public TArray<long> AcceptCreatureGen
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._AcceptCreatureGen) == null)
				{
					result = (this._AcceptCreatureGen = new TArray<long>(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_15, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AcceptCreatureGen.CopyAssign(value);
			}
		}

		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x06029D8C RID: 171404 RVA: 0x009CDBBC File Offset: 0x009CBDBC
		// (set) Token: 0x06029D8D RID: 171405 RVA: 0x009CDBFF File Offset: 0x009CBDFF
		public TArray<long> FinishCreatureGen
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._FinishCreatureGen) == null)
				{
					result = (this._FinishCreatureGen = new TArray<long>(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_16, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FinishCreatureGen.CopyAssign(value);
			}
		}

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x06029D8E RID: 171406 RVA: 0x009CDC0D File Offset: 0x009CBE0D
		// (set) Token: 0x06029D8F RID: 171407 RVA: 0x009CDC1D File Offset: 0x009CBE1D
		public unsafe int SaveType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x06029D90 RID: 171408 RVA: 0x009CDC2E File Offset: 0x009CBE2E
		// (set) Token: 0x06029D91 RID: 171409 RVA: 0x009CDC3E File Offset: 0x009CBE3E
		public unsafe int IsSavePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NPCQuestStep.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x06029D92 RID: 171410 RVA: 0x009CDC4F File Offset: 0x009CBE4F
		public NPCQuestStep()
		{
		}

		// Token: 0x06029D93 RID: 171411 RVA: 0x009CDC58 File Offset: 0x009CBE58
		public NPCQuestStep(int ID, int QuestKey, int StepId, TArray<int> NeedSteps, int ProcessType, bool IsAutoAccept, bool IsAllFinish, string StepType, int AcceptCondition, int AcceptedAction, int TargetCondition, int SubmitAction, int FailCondition, int FailAction, int RewardId, TArray<long> AcceptCreatureGen, TArray<long> FinishCreatureGen, int SaveType, int IsSavePoint)
		{
			this.ID = ID;
			this.QuestKey = QuestKey;
			this.StepId = StepId;
			this.NeedSteps = NeedSteps;
			this.ProcessType = ProcessType;
			this.IsAutoAccept = IsAutoAccept;
			this.IsAllFinish = IsAllFinish;
			this.StepType = StepType;
			this.AcceptCondition = AcceptCondition;
			this.AcceptedAction = AcceptedAction;
			this.TargetCondition = TargetCondition;
			this.SubmitAction = SubmitAction;
			this.FailCondition = FailCondition;
			this.FailAction = FailAction;
			this.RewardId = RewardId;
			this.AcceptCreatureGen = AcceptCreatureGen;
			this.FinishCreatureGen = FinishCreatureGen;
			this.SaveType = SaveType;
			this.IsSavePoint = IsSavePoint;
		}

		// Token: 0x06029D94 RID: 171412 RVA: 0x009CDD00 File Offset: 0x009CBF00
		protected override IntPtr GetUStructPtr()
		{
			return NPCQuestStep.StaticStruct();
		}

		// Token: 0x06029D95 RID: 171413 RVA: 0x009CDD0C File Offset: 0x009CBF0C
		[NullableContext(2)]
		public NPCQuestStep(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D96 RID: 171414 RVA: 0x009CDD16 File Offset: 0x009CBF16
		public NPCQuestStep(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D97 RID: 171415 RVA: 0x009CDD21 File Offset: 0x009CBF21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new NPCQuestStep(Pointer, false, true);
		}

		// Token: 0x06029D98 RID: 171416 RVA: 0x009CDD2B File Offset: 0x009CBF2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new NPCQuestStep(Pointer, MemoryOwner);
		}

		// Token: 0x040157C2 RID: 88002
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/NPCQuestStep.NPCQuestStep";

		// Token: 0x040157C3 RID: 88003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040157C4 RID: 88004
		internal static int __PropertyOffset_0;

		// Token: 0x040157C5 RID: 88005
		internal static int __PropertyOffset_1;

		// Token: 0x040157C6 RID: 88006
		internal static int __PropertyOffset_2;

		// Token: 0x040157C7 RID: 88007
		internal static int __PropertyOffset_3;

		// Token: 0x040157C8 RID: 88008
		[Nullable(2)]
		private TArray<int> _NeedSteps;

		// Token: 0x040157C9 RID: 88009
		internal static int __PropertyOffset_4;

		// Token: 0x040157CA RID: 88010
		internal static int __PropertyOffset_5;

		// Token: 0x040157CB RID: 88011
		internal static int __PropertyOffset_6;

		// Token: 0x040157CC RID: 88012
		internal static int __PropertyOffset_7;

		// Token: 0x040157CD RID: 88013
		internal static int __PropertyOffset_8;

		// Token: 0x040157CE RID: 88014
		internal static int __PropertyOffset_9;

		// Token: 0x040157CF RID: 88015
		internal static int __PropertyOffset_10;

		// Token: 0x040157D0 RID: 88016
		internal static int __PropertyOffset_11;

		// Token: 0x040157D1 RID: 88017
		internal static int __PropertyOffset_12;

		// Token: 0x040157D2 RID: 88018
		internal static int __PropertyOffset_13;

		// Token: 0x040157D3 RID: 88019
		internal static int __PropertyOffset_14;

		// Token: 0x040157D4 RID: 88020
		internal static int __PropertyOffset_15;

		// Token: 0x040157D5 RID: 88021
		[Nullable(2)]
		private TArray<long> _AcceptCreatureGen;

		// Token: 0x040157D6 RID: 88022
		internal static int __PropertyOffset_16;

		// Token: 0x040157D7 RID: 88023
		[Nullable(2)]
		private TArray<long> _FinishCreatureGen;

		// Token: 0x040157D8 RID: 88024
		internal static int __PropertyOffset_17;

		// Token: 0x040157D9 RID: 88025
		internal static int __PropertyOffset_18;
	}
}
