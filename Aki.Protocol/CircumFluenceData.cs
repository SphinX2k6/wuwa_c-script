using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000299 RID: 665
	public sealed class CircumFluenceData : IMessage<CircumFluenceData>, IMessage, IEquatable<CircumFluenceData>, IDeepCloneable<CircumFluenceData>, IBufferMessage
	{
		// Token: 0x06004573 RID: 17779 RVA: 0x000AA886 File Offset: 0x000A8A86
		[NullableContext(1)]
		public static CircumFluenceData Create()
		{
			return new CircumFluenceData();
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x000AA88D File Offset: 0x000A8A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x000AA890 File Offset: 0x000A8A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceData.Descriptor;
			}
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x000AA897 File Offset: 0x000A8A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData()
		{
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x000AA8C0 File Offset: 0x000A8AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData(CircumFluenceData other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this.signRewards_ = other.signRewards_.Clone();
			this.scoreRewards_ = other.scoreRewards_.Clone();
			this.nowRoundOpen_ = other.nowRoundOpen_;
			this.endTime_ = other.endTime_;
			this.nextRefreshTime_ = other.nextRefreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x000AA93B File Offset: 0x000A8B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData Clone()
		{
			return new CircumFluenceData(this);
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x000AA943 File Offset: 0x000A8B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x000AA94B File Offset: 0x000A8B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SignRewards
		{
			get
			{
				return this.signRewards_;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x000AA953 File Offset: 0x000A8B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewards
		{
			get
			{
				return this.scoreRewards_;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x000AA95B File Offset: 0x000A8B5B
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x000AA963 File Offset: 0x000A8B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NowRoundOpen
		{
			get
			{
				return this.nowRoundOpen_;
			}
			set
			{
				this.nowRoundOpen_ = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x000AA96C File Offset: 0x000A8B6C
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x000AA974 File Offset: 0x000A8B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x000AA97D File Offset: 0x000A8B7D
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x000AA985 File Offset: 0x000A8B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRefreshTime
		{
			get
			{
				return this.nextRefreshTime_;
			}
			set
			{
				this.nextRefreshTime_ = value;
			}
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000AA98E File Offset: 0x000A8B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceData);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000AA99C File Offset: 0x000A8B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.signRewards_.Equals(other.signRewards_) && this.scoreRewards_.Equals(other.scoreRewards_) && this.NowRoundOpen == other.NowRoundOpen && this.EndTime == other.EndTime && this.NextRefreshTime == other.NextRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x000AAA34 File Offset: 0x000A8C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			num ^= this.signRewards_.GetHashCode();
			num ^= this.scoreRewards_.GetHashCode();
			if (this.NowRoundOpen)
			{
				num ^= this.NowRoundOpen.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.NextRefreshTime != 0L)
			{
				num ^= this.NextRefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x000AAACF File Offset: 0x000A8CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x000AAADC File Offset: 0x000A8CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x000AAAE8 File Offset: 0x000A8CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, CircumFluenceData._repeated_activityTasks_codec);
			this.signRewards_.WriteTo(ref output, CircumFluenceData._repeated_signRewards_codec);
			this.scoreRewards_.WriteTo(ref output, CircumFluenceData._repeated_scoreRewards_codec);
			if (this.NowRoundOpen)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.NowRoundOpen);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EndTime);
			}
			if (this.NextRefreshTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x000AAB90 File Offset: 0x000A8D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(CircumFluenceData._repeated_activityTasks_codec);
			num += this.signRewards_.CalculateSize(CircumFluenceData._repeated_signRewards_codec);
			num += this.scoreRewards_.CalculateSize(CircumFluenceData._repeated_scoreRewards_codec);
			if (this.NowRoundOpen)
			{
				num += 2;
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.NextRefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x000AAC2C File Offset: 0x000A8E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CircumFluenceData other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this.signRewards_.Add(other.signRewards_);
			this.scoreRewards_.Add(other.scoreRewards_);
			if (other.NowRoundOpen)
			{
				this.NowRoundOpen = other.NowRoundOpen;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.NextRefreshTime != 0L)
			{
				this.NextRefreshTime = other.NextRefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x000AACC3 File Offset: 0x000A8EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000AACCC File Offset: 0x000A8ECC
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.activityTasks_.AddEntriesFrom(ref input, CircumFluenceData._repeated_activityTasks_codec);
						continue;
					}
					if (num == 18U)
					{
						this.signRewards_.AddEntriesFrom(ref input, CircumFluenceData._repeated_signRewards_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_77;
					}
				}
				else if (num <= 40U)
				{
					if (num == 26U)
					{
						goto IL_77;
					}
					if (num == 40U)
					{
						this.NowRoundOpen = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.NextRefreshTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_77:
				this.scoreRewards_.AddEntriesFrom(ref input, CircumFluenceData._repeated_scoreRewards_codec);
			}
		}

		// Token: 0x04002F44 RID: 12100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F45 RID: 12101
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04002F46 RID: 12102
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04002F47 RID: 12103
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002F48 RID: 12104
		public const int SignRewardsFieldNumber = 2;

		// Token: 0x04002F49 RID: 12105
		private static readonly FieldCodec<ActivityTask> _repeated_signRewards_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04002F4A RID: 12106
		private readonly RepeatedField<ActivityTask> signRewards_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002F4B RID: 12107
		public const int ScoreRewardsFieldNumber = 3;

		// Token: 0x04002F4C RID: 12108
		private static readonly FieldCodec<int> _repeated_scoreRewards_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002F4D RID: 12109
		private readonly RepeatedField<int> scoreRewards_ = new RepeatedField<int>();

		// Token: 0x04002F4E RID: 12110
		public const int NowRoundOpenFieldNumber = 5;

		// Token: 0x04002F4F RID: 12111
		private bool nowRoundOpen_;

		// Token: 0x04002F50 RID: 12112
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04002F51 RID: 12113
		private long endTime_;

		// Token: 0x04002F52 RID: 12114
		public const int NextRefreshTimeFieldNumber = 7;

		// Token: 0x04002F53 RID: 12115
		private long nextRefreshTime_;
	}
}
