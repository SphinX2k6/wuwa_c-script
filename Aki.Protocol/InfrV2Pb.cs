using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000803 RID: 2051
	public sealed class InfrV2Pb : IMessage<InfrV2Pb>, IMessage, IEquatable<InfrV2Pb>, IDeepCloneable<InfrV2Pb>, IBufferMessage
	{
		// Token: 0x0600B79E RID: 47006 RVA: 0x001B5B2A File Offset: 0x001B3D2A
		[NullableContext(1)]
		public static InfrV2Pb Create()
		{
			return new InfrV2Pb();
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x001B5B31 File Offset: 0x001B3D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x001B5B34 File Offset: 0x001B3D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2Pb.Descriptor;
			}
		}

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x001B5B3B File Offset: 0x001B3D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb()
		{
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x001B5B64 File Offset: 0x001B3D64
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

		// Token: 0x0600B7A3 RID: 47011 RVA: 0x001B5BF3 File Offset: 0x001B3DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2Pb Clone()
		{
			return new InfrV2Pb(this);
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x0600B7A4 RID: 47012 RVA: 0x001B5BFB File Offset: 0x001B3DFB
		// (set) Token: 0x0600B7A5 RID: 47013 RVA: 0x001B5C03 File Offset: 0x001B3E03
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

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x001B5C0C File Offset: 0x001B3E0C
		// (set) Token: 0x0600B7A7 RID: 47015 RVA: 0x001B5C14 File Offset: 0x001B3E14
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

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x001B5C1D File Offset: 0x001B3E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardScoreIds
		{
			get
			{
				return this.rewardScoreIds_;
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x001B5C25 File Offset: 0x001B3E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x0600B7AA RID: 47018 RVA: 0x001B5C2D File Offset: 0x001B3E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreeFinishCond
		{
			get
			{
				return this.treeFinishCond_;
			}
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x001B5C35 File Offset: 0x001B3E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2Pb);
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x001B5C44 File Offset: 0x001B3E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2Pb other)
		{
			return other != null && (other == this || (object.Equals(this.FireInfo, other.FireInfo) && object.Equals(this.TreeInfo, other.TreeInfo) && this.rewardScoreIds_.Equals(other.rewardScoreIds_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.treeFinishCond_.Equals(other.treeFinishCond_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x001B5CD8 File Offset: 0x001B3ED8
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

		// Token: 0x0600B7AE RID: 47022 RVA: 0x001B5D54 File Offset: 0x001B3F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x001B5D61 File Offset: 0x001B3F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x001B5D6C File Offset: 0x001B3F6C
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

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x001B5DF8 File Offset: 0x001B3FF8
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

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x001B5E88 File Offset: 0x001B4088
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

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x001B5F3B File Offset: 0x001B413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x001B5F44 File Offset: 0x001B4144
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

		// Token: 0x04005109 RID: 20745
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400510A RID: 20746
		public const int FireInfoFieldNumber = 1;

		// Token: 0x0400510B RID: 20747
		private InfrV2FirePb fireInfo_;

		// Token: 0x0400510C RID: 20748
		public const int TreeInfoFieldNumber = 2;

		// Token: 0x0400510D RID: 20749
		private InfrV2TreePb treeInfo_;

		// Token: 0x0400510E RID: 20750
		public const int RewardScoreIdsFieldNumber = 3;

		// Token: 0x0400510F RID: 20751
		private static readonly FieldCodec<int> _repeated_rewardScoreIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005110 RID: 20752
		private readonly RepeatedField<int> rewardScoreIds_ = new RepeatedField<int>();

		// Token: 0x04005111 RID: 20753
		public const int ConditionTasksFieldNumber = 4;

		// Token: 0x04005112 RID: 20754
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x04005113 RID: 20755
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x04005114 RID: 20756
		public const int TreeFinishCondFieldNumber = 5;

		// Token: 0x04005115 RID: 20757
		private static readonly FieldCodec<int> _repeated_treeFinishCond_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005116 RID: 20758
		private readonly RepeatedField<int> treeFinishCond_ = new RepeatedField<int>();
	}
}
