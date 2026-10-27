using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CD RID: 461
	public sealed class BossRushActivityData : IMessage<BossRushActivityData>, IMessage, IEquatable<BossRushActivityData>, IDeepCloneable<BossRushActivityData>, IBufferMessage
	{
		// Token: 0x0600349B RID: 13467 RVA: 0x000848FD File Offset: 0x00082AFD
		[NullableContext(1)]
		public static BossRushActivityData Create()
		{
			return new BossRushActivityData();
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x00084904 File Offset: 0x00082B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x00084907 File Offset: 0x00082B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushActivityData.Descriptor;
			}
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x0008490E File Offset: 0x00082B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData()
		{
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00084944 File Offset: 0x00082B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData(BossRushActivityData other) : this()
		{
			this.bossRushLevelInfo_ = other.bossRushLevelInfo_.Clone();
			this.bossRushScoreScoreRewardInfo_ = other.bossRushScoreScoreRewardInfo_.Clone();
			this.unlockedBuffIndices_ = other.unlockedBuffIndices_.Clone();
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000849AC File Offset: 0x00082BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushActivityData Clone()
		{
			return new BossRushActivityData(this);
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x000849B4 File Offset: 0x00082BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushLevelData> BossRushLevelInfo
		{
			get
			{
				return this.bossRushLevelInfo_;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000849BC File Offset: 0x00082BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushScoreRewardData> BossRushScoreScoreRewardInfo
		{
			get
			{
				return this.bossRushScoreScoreRewardInfo_;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x000849C4 File Offset: 0x00082BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedBuffIndices
		{
			get
			{
				return this.unlockedBuffIndices_;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x000849CC File Offset: 0x00082BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000849D4 File Offset: 0x00082BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushActivityData);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000849E4 File Offset: 0x00082BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushActivityData other)
		{
			return other != null && (other == this || (this.bossRushLevelInfo_.Equals(other.bossRushLevelInfo_) && this.bossRushScoreScoreRewardInfo_.Equals(other.bossRushScoreScoreRewardInfo_) && this.unlockedBuffIndices_.Equals(other.unlockedBuffIndices_) && this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00084A64 File Offset: 0x00082C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.bossRushLevelInfo_.GetHashCode();
			num ^= this.bossRushScoreScoreRewardInfo_.GetHashCode();
			num ^= this.unlockedBuffIndices_.GetHashCode();
			num ^= this.activityTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00084AC2 File Offset: 0x00082CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00084ACF File Offset: 0x00082CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x00084AD8 File Offset: 0x00082CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossRushLevelInfo_.WriteTo(ref output, BossRushActivityData._repeated_bossRushLevelInfo_codec);
			this.bossRushScoreScoreRewardInfo_.WriteTo(ref output, BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
			this.unlockedBuffIndices_.WriteTo(ref output, BossRushActivityData._repeated_unlockedBuffIndices_codec);
			this.activityTasks_.WriteTo(ref output, BossRushActivityData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x00084B40 File Offset: 0x00082D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bossRushLevelInfo_.CalculateSize(BossRushActivityData._repeated_bossRushLevelInfo_codec);
			num += this.bossRushScoreScoreRewardInfo_.CalculateSize(BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
			num += this.unlockedBuffIndices_.CalculateSize(BossRushActivityData._repeated_unlockedBuffIndices_codec);
			num += this.activityTasks_.CalculateSize(BossRushActivityData._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x00084BB4 File Offset: 0x00082DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.bossRushLevelInfo_.Add(other.bossRushLevelInfo_);
			this.bossRushScoreScoreRewardInfo_.Add(other.bossRushScoreScoreRewardInfo_);
			this.unlockedBuffIndices_.Add(other.unlockedBuffIndices_);
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00084C20 File Offset: 0x00082E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00084C2C File Offset: 0x00082E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.bossRushLevelInfo_.AddEntriesFrom(ref input, BossRushActivityData._repeated_bossRushLevelInfo_codec);
						continue;
					}
					if (num == 18U)
					{
						this.bossRushScoreScoreRewardInfo_.AddEntriesFrom(ref input, BossRushActivityData._repeated_bossRushScoreScoreRewardInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.unlockedBuffIndices_.AddEntriesFrom(ref input, BossRushActivityData._repeated_unlockedBuffIndices_codec);
						continue;
					}
					if (num == 34U)
					{
						this.activityTasks_.AddEntriesFrom(ref input, BossRushActivityData._repeated_activityTasks_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A0F RID: 10767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A10 RID: 10768
		public const int BossRushLevelInfoFieldNumber = 1;

		// Token: 0x04002A11 RID: 10769
		private static readonly FieldCodec<BossRushLevelData> _repeated_bossRushLevelInfo_codec = FieldCodec.ForMessage<BossRushLevelData>(10U, BossRushLevelData.Parser);

		// Token: 0x04002A12 RID: 10770
		private readonly RepeatedField<BossRushLevelData> bossRushLevelInfo_ = new RepeatedField<BossRushLevelData>();

		// Token: 0x04002A13 RID: 10771
		public const int BossRushScoreScoreRewardInfoFieldNumber = 2;

		// Token: 0x04002A14 RID: 10772
		private static readonly FieldCodec<BossRushScoreRewardData> _repeated_bossRushScoreScoreRewardInfo_codec = FieldCodec.ForMessage<BossRushScoreRewardData>(18U, BossRushScoreRewardData.Parser);

		// Token: 0x04002A15 RID: 10773
		private readonly RepeatedField<BossRushScoreRewardData> bossRushScoreScoreRewardInfo_ = new RepeatedField<BossRushScoreRewardData>();

		// Token: 0x04002A16 RID: 10774
		public const int UnlockedBuffIndicesFieldNumber = 3;

		// Token: 0x04002A17 RID: 10775
		private static readonly FieldCodec<int> _repeated_unlockedBuffIndices_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002A18 RID: 10776
		private readonly RepeatedField<int> unlockedBuffIndices_ = new RepeatedField<int>();

		// Token: 0x04002A19 RID: 10777
		public const int ActivityTasksFieldNumber = 4;

		// Token: 0x04002A1A RID: 10778
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(34U, ActivityTask.Parser);

		// Token: 0x04002A1B RID: 10779
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
