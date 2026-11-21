using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EF RID: 2031
	public sealed class InfrV2Pb : IMessage<InfrV2Pb>, IMessage, IEquatable<InfrV2Pb>, IDeepCloneable<InfrV2Pb>, IBufferMessage
	{
		// Token: 0x0600B648 RID: 46664 RVA: 0x001B30EA File Offset: 0x001B12EA
		[NullableContext(1)]
		public static InfrV2Pb Create()
		{
			return new InfrV2Pb();
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x001B30F1 File Offset: 0x001B12F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x001B30F4 File Offset: 0x001B12F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2Pb.Descriptor;
			}
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x001B30FB File Offset: 0x001B12FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb()
		{
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x001B3124 File Offset: 0x001B1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb(InfrV2Pb other) : this()
		{
			this.fireInfo_ = ((other.fireInfo_ != null) ? other.fireInfo_.Clone() : null);
			this.treeInfo_ = ((other.treeInfo_ != null) ? other.treeInfo_.Clone() : null);
			this.rewardScoreIds_ = other.rewardScoreIds_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.treeFinishCond_ = other.treeFinishCond_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x001B31B3 File Offset: 0x001B13B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb Clone()
		{
			return new InfrV2Pb(this);
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600B64E RID: 46670 RVA: 0x001B31BB File Offset: 0x001B13BB
		// (set) Token: 0x0600B64F RID: 46671 RVA: 0x001B31C3 File Offset: 0x001B13C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2FirePb FireInfo
		{
			get
			{
				return this.fireInfo_;
			}
			set
			{
				this.fireInfo_ = value;
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x0600B650 RID: 46672 RVA: 0x001B31CC File Offset: 0x001B13CC
		// (set) Token: 0x0600B651 RID: 46673 RVA: 0x001B31D4 File Offset: 0x001B13D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreePb TreeInfo
		{
			get
			{
				return this.treeInfo_;
			}
			set
			{
				this.treeInfo_ = value;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x0600B652 RID: 46674 RVA: 0x001B31DD File Offset: 0x001B13DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600B653 RID: 46675 RVA: 0x001B31E5 File Offset: 0x001B13E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x0600B654 RID: 46676 RVA: 0x001B31ED File Offset: 0x001B13ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreeFinishCond
		{
			get
			{
				return this.treeFinishCond_;
			}
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x001B31F5 File Offset: 0x001B13F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2Pb);
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x001B3204 File Offset: 0x001B1404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2Pb other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this.TreeInfo, other.TreeInfo) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.treeFinishCond_.Equals(other.treeFinishCond_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x001B3298 File Offset: 0x001B1498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fireInfo_ != null)
			{
				num ^= this.FireInfo.GetHashCode();
			}
			if (this.treeInfo_ != null)
			{
				num ^= this.TreeInfo.GetHashCode();
			}
			num ^= this.rewardScoreIds_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.treeFinishCond_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x001B3314 File Offset: 0x001B1514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x001B3321 File Offset: 0x001B1521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x001B332C File Offset: 0x001B152C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fireInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FireInfo);
			}
			if (this.treeInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TreeInfo);
			}
			this.rewardScoreIds_.WriteTo(ref output, InfrV2Pb._repeated_rewardScoreIds_codec);
			this.conditionTasks_.WriteTo(ref output, InfrV2Pb._repeated_conditionTasks_codec);
			this.treeFinishCond_.WriteTo(ref output, InfrV2Pb._repeated_treeFinishCond_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x001B33B8 File Offset: 0x001B15B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fireInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FireInfo);
			}
			if (this.treeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreeInfo);
			}
			num += this.rewardScoreIds_.CalculateSize(InfrV2Pb._repeated_rewardScoreIds_codec);
			num += this.conditionTasks_.CalculateSize(InfrV2Pb._repeated_conditionTasks_codec);
			num += this.treeFinishCond_.CalculateSize(InfrV2Pb._repeated_treeFinishCond_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x001B3448 File Offset: 0x001B1648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2Pb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fireInfo_ != null)
			{
				if (this.fireInfo_ == null)
				{
					this.FireInfo = new InfrV2FirePb();
				}
				this.FireInfo.MergeFrom(other.FireInfo);
			}
			if (other.treeInfo_ != null)
			{
				if (this.treeInfo_ == null)
				{
					this.TreeInfo = new InfrV2TreePb();
				}
				this.TreeInfo.MergeFrom(other.TreeInfo);
			}
			this.rewardScoreIds_.Add(other.rewardScoreIds_);
			this.conditionTasks_.Add(other.conditionTasks_);
			this.treeFinishCond_.Add(other.treeFinishCond_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x001B34FB File Offset: 0x001B16FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B65E RID: 46686 RVA: 0x001B3504 File Offset: 0x001B1704
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
						if (this.fireInfo_ == null)
						{
							this.FireInfo = new InfrV2FirePb();
						}
						input.ReadMessage(this.FireInfo);
						continue;
					}
					if (num == 18U)
					{
						if (this.treeInfo_ == null)
						{
							this.TreeInfo = new InfrV2TreePb();
						}
						input.ReadMessage(this.TreeInfo);
						continue;
					}
					if (num == 24U)
					{
						goto IL_96;
					}
				}
				else if (num <= 34U)
				{
					if (num == 26U)
					{
						goto IL_96;
					}
					if (num == 34U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, InfrV2Pb._repeated_conditionTasks_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.treeFinishCond_.AddEntriesFrom(ref input, InfrV2Pb._repeated_treeFinishCond_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_96:
				this.rewardScoreIds_.AddEntriesFrom(ref input, InfrV2Pb._repeated_rewardScoreIds_codec);
			}
		}

		// Token: 0x04005102 RID: 20738
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005103 RID: 20739
		public const int FireInfoFieldNumber = 1;

		// Token: 0x04005104 RID: 20740
		private InfrV2FirePb fireInfo_;

		// Token: 0x04005105 RID: 20741
		public const int TreeInfoFieldNumber = 2;

		// Token: 0x04005106 RID: 20742
		private InfrV2TreePb treeInfo_;

		// Token: 0x04005107 RID: 20743
		public const int RewardScoreIdsFieldNumber = 3;

		// Token: 0x04005108 RID: 20744
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005109 RID: 20745
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x0400510A RID: 20746
		public const int ConditionTasksFieldNumber = 4;

		// Token: 0x0400510B RID: 20747
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x0400510C RID: 20748
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x0400510D RID: 20749
		public const int TreeFinishCondFieldNumber = 5;

		// Token: 0x0400510E RID: 20750
		private static readonly FieldCodec<int> _repeated_treeFinishCond_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400510F RID: 20751
		private readonly RepeatedField<int> treeFinishCond_ = new RepeatedField<int>();
	}
}
