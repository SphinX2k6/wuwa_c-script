using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001522 RID: 5410
	public sealed class WuWuKujiActivityPb : IMessage<WuWuKujiActivityPb>, IMessage, IEquatable<WuWuKujiActivityPb>, IDeepCloneable<WuWuKujiActivityPb>, IBufferMessage
	{
		// Token: 0x0601C971 RID: 117105 RVA: 0x00420F6E File Offset: 0x0041F16E
		[NullableContext(1)]
		public static WuWuKujiActivityPb Create()
		{
			return new WuWuKujiActivityPb();
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x0601C972 RID: 117106 RVA: 0x00420F75 File Offset: 0x0041F175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x0601C973 RID: 117107 RVA: 0x00420F78 File Offset: 0x0041F178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiActivityPb.Descriptor;
			}
		}

		// Token: 0x0601C974 RID: 117108 RVA: 0x00420F7F File Offset: 0x0041F17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb()
		{
		}

		// Token: 0x0601C975 RID: 117109 RVA: 0x00420F94 File Offset: 0x0041F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb(WuWuKujiActivityPb other) : this()
		{
			this.activityId_ = other.activityId_;
			this.kujiId_ = other.kujiId_;
			this.kujiAwardGroupInfo_ = other.kujiAwardGroupInfo_.Clone();
			this.costItemId_ = other.costItemId_;
			this.costItemCount_ = other.costItemCount_;
			this.questFinishedCount_ = other.questFinishedCount_;
			this.questTotalCount_ = other.questTotalCount_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C976 RID: 117110 RVA: 0x0042101D File Offset: 0x0041F21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb Clone()
		{
			return new WuWuKujiActivityPb(this);
		}

		// Token: 0x17006065 RID: 24677
		// (get) Token: 0x0601C977 RID: 117111 RVA: 0x00421025 File Offset: 0x0041F225
		// (set) Token: 0x0601C978 RID: 117112 RVA: 0x0042102D File Offset: 0x0041F22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17006066 RID: 24678
		// (get) Token: 0x0601C979 RID: 117113 RVA: 0x00421036 File Offset: 0x0041F236
		// (set) Token: 0x0601C97A RID: 117114 RVA: 0x0042103E File Offset: 0x0041F23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int KujiId
		{
			get
			{
				return this.kujiId_;
			}
			set
			{
				this.kujiId_ = value;
			}
		}

		// Token: 0x17006067 RID: 24679
		// (get) Token: 0x0601C97B RID: 117115 RVA: 0x00421047 File Offset: 0x0041F247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KujiAwardGroupPb> KujiAwardGroupInfo
		{
			get
			{
				return this.kujiAwardGroupInfo_;
			}
		}

		// Token: 0x17006068 RID: 24680
		// (get) Token: 0x0601C97C RID: 117116 RVA: 0x0042104F File Offset: 0x0041F24F
		// (set) Token: 0x0601C97D RID: 117117 RVA: 0x00421057 File Offset: 0x0041F257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostItemId
		{
			get
			{
				return this.costItemId_;
			}
			set
			{
				this.costItemId_ = value;
			}
		}

		// Token: 0x17006069 RID: 24681
		// (get) Token: 0x0601C97E RID: 117118 RVA: 0x00421060 File Offset: 0x0041F260
		// (set) Token: 0x0601C97F RID: 117119 RVA: 0x00421068 File Offset: 0x0041F268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostItemCount
		{
			get
			{
				return this.costItemCount_;
			}
			set
			{
				this.costItemCount_ = value;
			}
		}

		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x0601C980 RID: 117120 RVA: 0x00421071 File Offset: 0x0041F271
		// (set) Token: 0x0601C981 RID: 117121 RVA: 0x00421079 File Offset: 0x0041F279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestFinishedCount
		{
			get
			{
				return this.questFinishedCount_;
			}
			set
			{
				this.questFinishedCount_ = value;
			}
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x0601C982 RID: 117122 RVA: 0x00421082 File Offset: 0x0041F282
		// (set) Token: 0x0601C983 RID: 117123 RVA: 0x0042108A File Offset: 0x0041F28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestTotalCount
		{
			get
			{
				return this.questTotalCount_;
			}
			set
			{
				this.questTotalCount_ = value;
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x0601C984 RID: 117124 RVA: 0x00421093 File Offset: 0x0041F293
		// (set) Token: 0x0601C985 RID: 117125 RVA: 0x0042109B File Offset: 0x0041F29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0601C986 RID: 117126 RVA: 0x004210A4 File Offset: 0x0041F2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiActivityPb);
		}

		// Token: 0x0601C987 RID: 117127 RVA: 0x004210B4 File Offset: 0x0041F2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiActivityPb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.KujiId == other.KujiId && this.kujiAwardGroupInfo_.Equals(other.kujiAwardGroupInfo_) && this.CostItemId == other.CostItemId && this.CostItemCount == other.CostItemCount && this.QuestFinishedCount == other.QuestFinishedCount && this.QuestTotalCount == other.QuestTotalCount && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C988 RID: 117128 RVA: 0x00421164 File Offset: 0x0041F364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.KujiId != 0)
			{
				num ^= this.KujiId.GetHashCode();
			}
			num ^= this.kujiAwardGroupInfo_.GetHashCode();
			if (this.CostItemId != 0)
			{
				num ^= this.CostItemId.GetHashCode();
			}
			if (this.CostItemCount != 0)
			{
				num ^= this.CostItemCount.GetHashCode();
			}
			if (this.QuestFinishedCount != 0)
			{
				num ^= this.QuestFinishedCount.GetHashCode();
			}
			if (this.QuestTotalCount != 0)
			{
				num ^= this.QuestTotalCount.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C989 RID: 117129 RVA: 0x00421247 File Offset: 0x0041F447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C98A RID: 117130 RVA: 0x00421254 File Offset: 0x0041F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C98B RID: 117131 RVA: 0x00421260 File Offset: 0x0041F460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.KujiId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.KujiId);
			}
			this.kujiAwardGroupInfo_.WriteTo(ref output, WuWuKujiActivityPb._repeated_kujiAwardGroupInfo_codec);
			if (this.CostItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CostItemId);
			}
			if (this.CostItemCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CostItemCount);
			}
			if (this.QuestFinishedCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QuestFinishedCount);
			}
			if (this.QuestTotalCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.QuestTotalCount);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C98C RID: 117132 RVA: 0x00421358 File Offset: 0x0041F558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.KujiId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.KujiId);
			}
			num += this.kujiAwardGroupInfo_.CalculateSize(WuWuKujiActivityPb._repeated_kujiAwardGroupInfo_codec);
			if (this.CostItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostItemId);
			}
			if (this.CostItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostItemCount);
			}
			if (this.QuestFinishedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestFinishedCount);
			}
			if (this.QuestTotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestTotalCount);
			}
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C98D RID: 117133 RVA: 0x0042143C File Offset: 0x0041F63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuKujiActivityPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.KujiId != 0)
			{
				this.KujiId = other.KujiId;
			}
			this.kujiAwardGroupInfo_.Add(other.kujiAwardGroupInfo_);
			if (other.CostItemId != 0)
			{
				this.CostItemId = other.CostItemId;
			}
			if (other.CostItemCount != 0)
			{
				this.CostItemCount = other.CostItemCount;
			}
			if (other.QuestFinishedCount != 0)
			{
				this.QuestFinishedCount = other.QuestFinishedCount;
			}
			if (other.QuestTotalCount != 0)
			{
				this.QuestTotalCount = other.QuestTotalCount;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C98E RID: 117134 RVA: 0x00421501 File Offset: 0x0041F701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C98F RID: 117135 RVA: 0x0042150C File Offset: 0x0041F70C
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.ActivityId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.KujiId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							this.kujiAwardGroupInfo_.AddEntriesFrom(ref input, WuWuKujiActivityPb._repeated_kujiAwardGroupInfo_codec);
							continue;
						}
						if (num == 32U)
						{
							this.CostItemId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.CostItemCount = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.QuestFinishedCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.QuestTotalCount = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A382 RID: 41858
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A383 RID: 41859
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400A384 RID: 41860
		private int activityId_;

		// Token: 0x0400A385 RID: 41861
		public const int KujiIdFieldNumber = 2;

		// Token: 0x0400A386 RID: 41862
		private int kujiId_;

		// Token: 0x0400A387 RID: 41863
		public const int KujiAwardGroupInfoFieldNumber = 3;

		// Token: 0x0400A388 RID: 41864
		private static readonly FieldCodec<KujiAwardGroupPb> _repeated_kujiAwardGroupInfo_codec = FieldCodec.ForMessage<KujiAwardGroupPb>(26U, KujiAwardGroupPb.Parser);

		// Token: 0x0400A389 RID: 41865
		private readonly RepeatedField<KujiAwardGroupPb> kujiAwardGroupInfo_ = new RepeatedField<KujiAwardGroupPb>();

		// Token: 0x0400A38A RID: 41866
		public const int CostItemIdFieldNumber = 4;

		// Token: 0x0400A38B RID: 41867
		private int costItemId_;

		// Token: 0x0400A38C RID: 41868
		public const int CostItemCountFieldNumber = 5;

		// Token: 0x0400A38D RID: 41869
		private int costItemCount_;

		// Token: 0x0400A38E RID: 41870
		public const int QuestFinishedCountFieldNumber = 6;

		// Token: 0x0400A38F RID: 41871
		private int questFinishedCount_;

		// Token: 0x0400A390 RID: 41872
		public const int QuestTotalCountFieldNumber = 7;

		// Token: 0x0400A391 RID: 41873
		private int questTotalCount_;

		// Token: 0x0400A392 RID: 41874
		public const int QuestIdFieldNumber = 8;

		// Token: 0x0400A393 RID: 41875
		private int questId_;
	}
}
