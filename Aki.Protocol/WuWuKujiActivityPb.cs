using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001598 RID: 5528
	public sealed class WuWuKujiActivityPb : IMessage<WuWuKujiActivityPb>, IMessage, IEquatable<WuWuKujiActivityPb>, IDeepCloneable<WuWuKujiActivityPb>, IBufferMessage
	{
		// Token: 0x0601D438 RID: 119864 RVA: 0x0043CA2A File Offset: 0x0043AC2A
		[NullableContext(1)]
		public static WuWuKujiActivityPb Create()
		{
			return new WuWuKujiActivityPb();
		}

		// Token: 0x17006304 RID: 25348
		// (get) Token: 0x0601D439 RID: 119865 RVA: 0x0043CA31 File Offset: 0x0043AC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006305 RID: 25349
		// (get) Token: 0x0601D43A RID: 119866 RVA: 0x0043CA34 File Offset: 0x0043AC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuKujiActivityPb.Descriptor;
			}
		}

		// Token: 0x0601D43B RID: 119867 RVA: 0x0043CA3B File Offset: 0x0043AC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb()
		{
		}

		// Token: 0x0601D43C RID: 119868 RVA: 0x0043CA50 File Offset: 0x0043AC50
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

		// Token: 0x0601D43D RID: 119869 RVA: 0x0043CAD9 File Offset: 0x0043ACD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuKujiActivityPb Clone()
		{
			return new WuWuKujiActivityPb(this);
		}

		// Token: 0x17006306 RID: 25350
		// (get) Token: 0x0601D43E RID: 119870 RVA: 0x0043CAE1 File Offset: 0x0043ACE1
		// (set) Token: 0x0601D43F RID: 119871 RVA: 0x0043CAE9 File Offset: 0x0043ACE9
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

		// Token: 0x17006307 RID: 25351
		// (get) Token: 0x0601D440 RID: 119872 RVA: 0x0043CAF2 File Offset: 0x0043ACF2
		// (set) Token: 0x0601D441 RID: 119873 RVA: 0x0043CAFA File Offset: 0x0043ACFA
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

		// Token: 0x17006308 RID: 25352
		// (get) Token: 0x0601D442 RID: 119874 RVA: 0x0043CB03 File Offset: 0x0043AD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KujiAwardGroupPb> KujiAwardGroupInfo
		{
			get
			{
				return this.kujiAwardGroupInfo_;
			}
		}

		// Token: 0x17006309 RID: 25353
		// (get) Token: 0x0601D443 RID: 119875 RVA: 0x0043CB0B File Offset: 0x0043AD0B
		// (set) Token: 0x0601D444 RID: 119876 RVA: 0x0043CB13 File Offset: 0x0043AD13
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

		// Token: 0x1700630A RID: 25354
		// (get) Token: 0x0601D445 RID: 119877 RVA: 0x0043CB1C File Offset: 0x0043AD1C
		// (set) Token: 0x0601D446 RID: 119878 RVA: 0x0043CB24 File Offset: 0x0043AD24
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

		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x0601D447 RID: 119879 RVA: 0x0043CB2D File Offset: 0x0043AD2D
		// (set) Token: 0x0601D448 RID: 119880 RVA: 0x0043CB35 File Offset: 0x0043AD35
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

		// Token: 0x1700630C RID: 25356
		// (get) Token: 0x0601D449 RID: 119881 RVA: 0x0043CB3E File Offset: 0x0043AD3E
		// (set) Token: 0x0601D44A RID: 119882 RVA: 0x0043CB46 File Offset: 0x0043AD46
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

		// Token: 0x1700630D RID: 25357
		// (get) Token: 0x0601D44B RID: 119883 RVA: 0x0043CB4F File Offset: 0x0043AD4F
		// (set) Token: 0x0601D44C RID: 119884 RVA: 0x0043CB57 File Offset: 0x0043AD57
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

		// Token: 0x0601D44D RID: 119885 RVA: 0x0043CB60 File Offset: 0x0043AD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuKujiActivityPb);
		}

		// Token: 0x0601D44E RID: 119886 RVA: 0x0043CB70 File Offset: 0x0043AD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuKujiActivityPb other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.KujiId == other.KujiId && this.kujiAwardGroupInfo_.Equals(other.kujiAwardGroupInfo_) && this.CostItemId == other.CostItemId && this.CostItemCount == other.CostItemCount && this.QuestFinishedCount == other.QuestFinishedCount && this.QuestTotalCount == other.QuestTotalCount && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D44F RID: 119887 RVA: 0x0043CC20 File Offset: 0x0043AE20
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

		// Token: 0x0601D450 RID: 119888 RVA: 0x0043CD03 File Offset: 0x0043AF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D451 RID: 119889 RVA: 0x0043CD10 File Offset: 0x0043AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D452 RID: 119890 RVA: 0x0043CD1C File Offset: 0x0043AF1C
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

		// Token: 0x0601D453 RID: 119891 RVA: 0x0043CE14 File Offset: 0x0043B014
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

		// Token: 0x0601D454 RID: 119892 RVA: 0x0043CEF8 File Offset: 0x0043B0F8
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

		// Token: 0x0601D455 RID: 119893 RVA: 0x0043CFBD File Offset: 0x0043B1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D456 RID: 119894 RVA: 0x0043CFC8 File Offset: 0x0043B1C8
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

		// Token: 0x0400A7DB RID: 42971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A7DC RID: 42972
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400A7DD RID: 42973
		private int activityId_;

		// Token: 0x0400A7DE RID: 42974
		public const int KujiIdFieldNumber = 2;

		// Token: 0x0400A7DF RID: 42975
		private int kujiId_;

		// Token: 0x0400A7E0 RID: 42976
		public const int KujiAwardGroupInfoFieldNumber = 3;

		// Token: 0x0400A7E1 RID: 42977
		private static readonly FieldCodec<KujiAwardGroupPb> _repeated_kujiAwardGroupInfo_codec = FieldCodec.ForMessage<KujiAwardGroupPb>(26U, KujiAwardGroupPb.Parser);

		// Token: 0x0400A7E2 RID: 42978
		private readonly RepeatedField<KujiAwardGroupPb> kujiAwardGroupInfo_ = new RepeatedField<KujiAwardGroupPb>();

		// Token: 0x0400A7E3 RID: 42979
		public const int CostItemIdFieldNumber = 4;

		// Token: 0x0400A7E4 RID: 42980
		private int costItemId_;

		// Token: 0x0400A7E5 RID: 42981
		public const int CostItemCountFieldNumber = 5;

		// Token: 0x0400A7E6 RID: 42982
		private int costItemCount_;

		// Token: 0x0400A7E7 RID: 42983
		public const int QuestFinishedCountFieldNumber = 6;

		// Token: 0x0400A7E8 RID: 42984
		private int questFinishedCount_;

		// Token: 0x0400A7E9 RID: 42985
		public const int QuestTotalCountFieldNumber = 7;

		// Token: 0x0400A7EA RID: 42986
		private int questTotalCount_;

		// Token: 0x0400A7EB RID: 42987
		public const int QuestIdFieldNumber = 8;

		// Token: 0x0400A7EC RID: 42988
		private int questId_;
	}
}
