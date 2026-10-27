using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000420 RID: 1056
	public sealed class EdgeRunnerActivityInfo : IMessage<EdgeRunnerActivityInfo>, IMessage, IEquatable<EdgeRunnerActivityInfo>, IDeepCloneable<EdgeRunnerActivityInfo>, IBufferMessage
	{
		// Token: 0x06006590 RID: 26000 RVA: 0x000F4728 File Offset: 0x000F2928
		[NullableContext(1)]
		public static EdgeRunnerActivityInfo Create()
		{
			return new EdgeRunnerActivityInfo();
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x000F472F File Offset: 0x000F292F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x000F4732 File Offset: 0x000F2932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerActivityInfo.Descriptor;
			}
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x000F4739 File Offset: 0x000F2939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo()
		{
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x000F4770 File Offset: 0x000F2970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo(EdgeRunnerActivityInfo other) : this()
		{
			this.edgeRunnerFunctionIds_ = other.edgeRunnerFunctionIds_.Clone();
			this.rewardScoreId_ = other.rewardScoreId_;
			this.edgeRunnerLordGymPassRecords_ = other.edgeRunnerLordGymPassRecords_.Clone();
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this.preUnlockIds_ = other.preUnlockIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x000F47E4 File Offset: 0x000F29E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo Clone()
		{
			return new EdgeRunnerActivityInfo(this);
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x000F47EC File Offset: 0x000F29EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EdgeRunnerFunctionIds
		{
			get
			{
				return this.edgeRunnerFunctionIds_;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x000F47F4 File Offset: 0x000F29F4
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x000F47FC File Offset: 0x000F29FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardScoreId
		{
			get
			{
				return this.rewardScoreId_;
			}
			set
			{
				this.rewardScoreId_ = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x000F4805 File Offset: 0x000F2A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EdgeRunnerLordGymPassRecord> EdgeRunnerLordGymPassRecords
		{
			get
			{
				return this.edgeRunnerLordGymPassRecords_;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x000F480D File Offset: 0x000F2A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x000F4815 File Offset: 0x000F2A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreUnlockIds
		{
			get
			{
				return this.preUnlockIds_;
			}
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x000F481D File Offset: 0x000F2A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerActivityInfo);
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x000F482C File Offset: 0x000F2A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerActivityInfo other)
		{
			return other != null && (other == this || (this.edgeRunnerFunctionIds_.Equals(other.edgeRunnerFunctionIds_) && this.RewardScoreId == other.RewardScoreId && this.edgeRunnerLordGymPassRecords_.Equals(other.edgeRunnerLordGymPassRecords_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.preUnlockIds_.Equals(other.preUnlockIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x000F48BC File Offset: 0x000F2ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.edgeRunnerFunctionIds_.GetHashCode();
			if (this.RewardScoreId != 0)
			{
				num ^= this.RewardScoreId.GetHashCode();
			}
			num ^= this.edgeRunnerLordGymPassRecords_.GetHashCode();
			num ^= this.conditionTasks_.GetHashCode();
			num ^= this.preUnlockIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600659F RID: 26015 RVA: 0x000F4933 File Offset: 0x000F2B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x000F4940 File Offset: 0x000F2B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x000F494C File Offset: 0x000F2B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.edgeRunnerFunctionIds_.WriteTo(ref output, EdgeRunnerActivityInfo._repeated_edgeRunnerFunctionIds_codec);
			if (this.RewardScoreId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RewardScoreId);
			}
			this.edgeRunnerLordGymPassRecords_.WriteTo(ref output, EdgeRunnerActivityInfo._repeated_edgeRunnerLordGymPassRecords_codec);
			this.conditionTasks_.WriteTo(ref output, EdgeRunnerActivityInfo._repeated_conditionTasks_codec);
			this.preUnlockIds_.WriteTo(ref output, EdgeRunnerActivityInfo._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x000F49D0 File Offset: 0x000F2BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.edgeRunnerFunctionIds_.CalculateSize(EdgeRunnerActivityInfo._repeated_edgeRunnerFunctionIds_codec);
			if (this.RewardScoreId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardScoreId);
			}
			num += this.edgeRunnerLordGymPassRecords_.CalculateSize(EdgeRunnerActivityInfo._repeated_edgeRunnerLordGymPassRecords_codec);
			num += this.conditionTasks_.CalculateSize(EdgeRunnerActivityInfo._repeated_conditionTasks_codec);
			num += this.preUnlockIds_.CalculateSize(EdgeRunnerActivityInfo._repeated_preUnlockIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065A3 RID: 26019 RVA: 0x000F4A5C File Offset: 0x000F2C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.edgeRunnerFunctionIds_.Add(other.edgeRunnerFunctionIds_);
			if (other.RewardScoreId != 0)
			{
				this.RewardScoreId = other.RewardScoreId;
			}
			this.edgeRunnerLordGymPassRecords_.Add(other.edgeRunnerLordGymPassRecords_);
			this.conditionTasks_.Add(other.conditionTasks_);
			this.preUnlockIds_.Add(other.preUnlockIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x000F4ADC File Offset: 0x000F2CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x000F4AE8 File Offset: 0x000F2CE8
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
				if (num <= 16U)
				{
					if (num == 8U || num == 10U)
					{
						this.edgeRunnerFunctionIds_.AddEntriesFrom(ref input, EdgeRunnerActivityInfo._repeated_edgeRunnerFunctionIds_codec);
						continue;
					}
					if (num == 16U)
					{
						this.RewardScoreId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 26U)
					{
						this.edgeRunnerLordGymPassRecords_.AddEntriesFrom(ref input, EdgeRunnerActivityInfo._repeated_edgeRunnerLordGymPassRecords_codec);
						continue;
					}
					if (num == 34U)
					{
						this.conditionTasks_.AddEntriesFrom(ref input, EdgeRunnerActivityInfo._repeated_conditionTasks_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.preUnlockIds_.AddEntriesFrom(ref input, EdgeRunnerActivityInfo._repeated_preUnlockIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038E1 RID: 14561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038E2 RID: 14562
		public const int EdgeRunnerFunctionIdsFieldNumber = 1;

		// Token: 0x040038E3 RID: 14563
		private static readonly FieldCodec<int> _repeated_edgeRunnerFunctionIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040038E4 RID: 14564
		private readonly RepeatedField<int> edgeRunnerFunctionIds_ = new RepeatedField<int>();

		// Token: 0x040038E5 RID: 14565
		public const int RewardScoreIdFieldNumber = 2;

		// Token: 0x040038E6 RID: 14566
		private int rewardScoreId_;

		// Token: 0x040038E7 RID: 14567
		public const int EdgeRunnerLordGymPassRecordsFieldNumber = 3;

		// Token: 0x040038E8 RID: 14568
		private static readonly FieldCodec<EdgeRunnerLordGymPassRecord> _repeated_edgeRunnerLordGymPassRecords_codec = FieldCodec.ForMessage<EdgeRunnerLordGymPassRecord>(26U, EdgeRunnerLordGymPassRecord.Parser);

		// Token: 0x040038E9 RID: 14569
		private readonly RepeatedField<EdgeRunnerLordGymPassRecord> edgeRunnerLordGymPassRecords_ = new RepeatedField<EdgeRunnerLordGymPassRecord>();

		// Token: 0x040038EA RID: 14570
		public const int ConditionTasksFieldNumber = 4;

		// Token: 0x040038EB RID: 14571
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x040038EC RID: 14572
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040038ED RID: 14573
		public const int PreUnlockIdsFieldNumber = 5;

		// Token: 0x040038EE RID: 14574
		private static readonly FieldCodec<int> _repeated_preUnlockIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040038EF RID: 14575
		private readonly RepeatedField<int> preUnlockIds_ = new RepeatedField<int>();
	}
}
