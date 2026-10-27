using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000294 RID: 660
	public sealed class CircumFluenceData : IMessage<CircumFluenceData>, IMessage, IEquatable<CircumFluenceData>, IDeepCloneable<CircumFluenceData>, IBufferMessage
	{
		// Token: 0x060044CC RID: 17612 RVA: 0x000A8BBE File Offset: 0x000A6DBE
		[NullableContext(1)]
		public static CircumFluenceData Create()
		{
			return new CircumFluenceData();
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x000A8BC5 File Offset: 0x000A6DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x000A8BC8 File Offset: 0x000A6DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CircumFluenceData.Descriptor;
			}
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x000A8BCF File Offset: 0x000A6DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData()
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x000A8BF8 File Offset: 0x000A6DF8
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

		// Token: 0x060044D1 RID: 17617 RVA: 0x000A8C73 File Offset: 0x000A6E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CircumFluenceData Clone()
		{
			return new CircumFluenceData(this);
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060044D2 RID: 17618 RVA: 0x000A8C7B File Offset: 0x000A6E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x000A8C83 File Offset: 0x000A6E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> SignRewards
		{
			get
			{
				return this.signRewards_;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060044D4 RID: 17620 RVA: 0x000A8C8B File Offset: 0x000A6E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewards
		{
			get
			{
				return this.scoreRewards_;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060044D5 RID: 17621 RVA: 0x000A8C93 File Offset: 0x000A6E93
		// (set) Token: 0x060044D6 RID: 17622 RVA: 0x000A8C9B File Offset: 0x000A6E9B
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

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060044D7 RID: 17623 RVA: 0x000A8CA4 File Offset: 0x000A6EA4
		// (set) Token: 0x060044D8 RID: 17624 RVA: 0x000A8CAC File Offset: 0x000A6EAC
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

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x000A8CB5 File Offset: 0x000A6EB5
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x000A8CBD File Offset: 0x000A6EBD
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

		// Token: 0x060044DB RID: 17627 RVA: 0x000A8CC6 File Offset: 0x000A6EC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CircumFluenceData);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x000A8CD4 File Offset: 0x000A6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CircumFluenceData other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && this.signRewards_.Equals(other.signRewards_) && this.scoreRewards_.Equals(other.scoreRewards_) && this.NowRoundOpen == other.NowRoundOpen && this.EndTime == other.EndTime && this.NextRefreshTime == other.NextRefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x000A8D6C File Offset: 0x000A6F6C
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

		// Token: 0x060044DE RID: 17630 RVA: 0x000A8E07 File Offset: 0x000A7007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x000A8E14 File Offset: 0x000A7014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x000A8E20 File Offset: 0x000A7020
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

		// Token: 0x060044E1 RID: 17633 RVA: 0x000A8EC8 File Offset: 0x000A70C8
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

		// Token: 0x060044E2 RID: 17634 RVA: 0x000A8F64 File Offset: 0x000A7164
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

		// Token: 0x060044E3 RID: 17635 RVA: 0x000A8FFB File Offset: 0x000A71FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x000A9004 File Offset: 0x000A7204
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

		// Token: 0x04002EC0 RID: 11968
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EC1 RID: 11969
		public const int ActivityTasksFieldNumber = 1;

		// Token: 0x04002EC2 RID: 11970
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(10U, ActivityTask.Parser);

		// Token: 0x04002EC3 RID: 11971
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002EC4 RID: 11972
		public const int SignRewardsFieldNumber = 2;

		// Token: 0x04002EC5 RID: 11973
		private static readonly FieldCodec<ActivityTask> _repeated_signRewards_codec = FieldCodec.ForMessage<ActivityTask>(18U, ActivityTask.Parser);

		// Token: 0x04002EC6 RID: 11974
		private readonly RepeatedField<ActivityTask> signRewards_ = new RepeatedField<ActivityTask>();

		// Token: 0x04002EC7 RID: 11975
		public const int ScoreRewardsFieldNumber = 3;

		// Token: 0x04002EC8 RID: 11976
		private static readonly FieldCodec<int> _repeated_scoreRewards_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002EC9 RID: 11977
		private readonly RepeatedField<int> scoreRewards_ = new RepeatedField<int>();

		// Token: 0x04002ECA RID: 11978
		public const int NowRoundOpenFieldNumber = 5;

		// Token: 0x04002ECB RID: 11979
		private bool nowRoundOpen_;

		// Token: 0x04002ECC RID: 11980
		public const int EndTimeFieldNumber = 6;

		// Token: 0x04002ECD RID: 11981
		private long endTime_;

		// Token: 0x04002ECE RID: 11982
		public const int NextRefreshTimeFieldNumber = 7;

		// Token: 0x04002ECF RID: 11983
		private long nextRefreshTime_;
	}
}
