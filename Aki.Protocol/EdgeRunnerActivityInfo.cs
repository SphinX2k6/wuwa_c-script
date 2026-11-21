using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000409 RID: 1033
	public sealed class EdgeRunnerActivityInfo : IMessage<EdgeRunnerActivityInfo>, IMessage, IEquatable<EdgeRunnerActivityInfo>, IDeepCloneable<EdgeRunnerActivityInfo>, IBufferMessage
	{
		// Token: 0x06006400 RID: 25600 RVA: 0x000F15B4 File Offset: 0x000EF7B4
		[NullableContext(1)]
		public static EdgeRunnerActivityInfo Create()
		{
			return new EdgeRunnerActivityInfo();
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x000F15BB File Offset: 0x000EF7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x000F15BE File Offset: 0x000EF7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerActivityInfo.Descriptor;
			}
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x000F15C5 File Offset: 0x000EF7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo()
		{
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x000F15FC File Offset: 0x000EF7FC
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

		// Token: 0x06006405 RID: 25605 RVA: 0x000F1670 File Offset: 0x000EF870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerActivityInfo Clone()
		{
			return new EdgeRunnerActivityInfo(this);
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06006406 RID: 25606 RVA: 0x000F1678 File Offset: 0x000EF878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EdgeRunnerFunctionIds
		{
			get
			{
				return this.edgeRunnerFunctionIds_;
			}
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x000F1680 File Offset: 0x000EF880
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x000F1688 File Offset: 0x000EF888
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

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x000F1691 File Offset: 0x000EF891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EdgeRunnerLordGymPassRecord> EdgeRunnerLordGymPassRecords
		{
			get
			{
				return this.edgeRunnerLordGymPassRecords_;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x000F1699 File Offset: 0x000EF899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x000F16A1 File Offset: 0x000EF8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PreUnlockIds
		{
			get
			{
				return this.preUnlockIds_;
			}
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x000F16A9 File Offset: 0x000EF8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerActivityInfo);
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x000F16B8 File Offset: 0x000EF8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerActivityInfo other)
		{
			return other != null && (other == this || (this.edgeRunnerFunctionIds_.Equals(other.edgeRunnerFunctionIds_) && this.RewardScoreId == other.RewardScoreId && this.edgeRunnerLordGymPassRecords_.Equals(other.edgeRunnerLordGymPassRecords_) && this.conditionTasks_.Equals(other.conditionTasks_) && this.preUnlockIds_.Equals(other.preUnlockIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x000F1748 File Offset: 0x000EF948
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

		// Token: 0x0600640F RID: 25615 RVA: 0x000F17BF File Offset: 0x000EF9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x000F17CC File Offset: 0x000EF9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x000F17D8 File Offset: 0x000EF9D8
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

		// Token: 0x06006412 RID: 25618 RVA: 0x000F185C File Offset: 0x000EFA5C
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

		// Token: 0x06006413 RID: 25619 RVA: 0x000F18E8 File Offset: 0x000EFAE8
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

		// Token: 0x06006414 RID: 25620 RVA: 0x000F1968 File Offset: 0x000EFB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006415 RID: 25621 RVA: 0x000F1974 File Offset: 0x000EFB74
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

		// Token: 0x040038CE RID: 14542
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038CF RID: 14543
		public const int EdgeRunnerFunctionIdsFieldNumber = 1;

		// Token: 0x040038D0 RID: 14544
		private static readonly FieldCodec<int> _repeated_edgeRunnerFunctionIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040038D1 RID: 14545
		private readonly RepeatedField<int> edgeRunnerFunctionIds_ = new RepeatedField<int>();

		// Token: 0x040038D2 RID: 14546
		public const int RewardScoreIdFieldNumber = 2;

		// Token: 0x040038D3 RID: 14547
		private int rewardScoreId_;

		// Token: 0x040038D4 RID: 14548
		public const int EdgeRunnerLordGymPassRecordsFieldNumber = 3;

		// Token: 0x040038D5 RID: 14549
		private static readonly FieldCodec<EdgeRunnerLordGymPassRecord> _repeated_edgeRunnerLordGymPassRecords_codec = FieldCodec.ForMessage<EdgeRunnerLordGymPassRecord>(26U, EdgeRunnerLordGymPassRecord.Parser);

		// Token: 0x040038D6 RID: 14550
		private readonly RepeatedField<EdgeRunnerLordGymPassRecord> edgeRunnerLordGymPassRecords_ = new RepeatedField<EdgeRunnerLordGymPassRecord>();

		// Token: 0x040038D7 RID: 14551
		public const int ConditionTasksFieldNumber = 4;

		// Token: 0x040038D8 RID: 14552
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x040038D9 RID: 14553
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();

		// Token: 0x040038DA RID: 14554
		public const int PreUnlockIdsFieldNumber = 5;

		// Token: 0x040038DB RID: 14555
		private static readonly FieldCodec<int> _repeated_preUnlockIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040038DC RID: 14556
		private readonly RepeatedField<int> preUnlockIds_ = new RepeatedField<int>();
	}
}
