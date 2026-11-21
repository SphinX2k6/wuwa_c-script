using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000873 RID: 2163
	public sealed class KujiAwardGroupPb : IMessage<KujiAwardGroupPb>, IMessage, IEquatable<KujiAwardGroupPb>, IDeepCloneable<KujiAwardGroupPb>, IBufferMessage
	{
		// Token: 0x0600C0EA RID: 49386 RVA: 0x001CA9A4 File Offset: 0x001C8BA4
		[NullableContext(1)]
		public static KujiAwardGroupPb Create()
		{
			return new KujiAwardGroupPb();
		}

		// Token: 0x170026F9 RID: 9977
		// (get) Token: 0x0600C0EB RID: 49387 RVA: 0x001CA9AB File Offset: 0x001C8BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KujiAwardGroupPb> Parser
		{
			get
			{
				return KujiAwardGroupPb._parser;
			}
		}

		// Token: 0x170026FA RID: 9978
		// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x001CA9B2 File Offset: 0x001C8BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x0600C0ED RID: 49389 RVA: 0x001CA9B5 File Offset: 0x001C8BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KujiAwardGroupPb.Descriptor;
			}
		}

		// Token: 0x0600C0EE RID: 49390 RVA: 0x001CA9BC File Offset: 0x001C8BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb()
		{
		}

		// Token: 0x0600C0EF RID: 49391 RVA: 0x001CA9D0 File Offset: 0x001C8BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb(KujiAwardGroupPb other) : this()
		{
			this.id_ = other.id_;
			this.groupRank_ = other.groupRank_;
			this.rewardedAmount_ = other.rewardedAmount_;
			this.allAmount_ = other.allAmount_;
			this.preItemMap_ = other.preItemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0F0 RID: 49392 RVA: 0x001CAA35 File Offset: 0x001C8C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KujiAwardGroupPb Clone()
		{
			return new KujiAwardGroupPb(this);
		}

		// Token: 0x170026FC RID: 9980
		// (get) Token: 0x0600C0F1 RID: 49393 RVA: 0x001CAA3D File Offset: 0x001C8C3D
		// (set) Token: 0x0600C0F2 RID: 49394 RVA: 0x001CAA45 File Offset: 0x001C8C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600C0F3 RID: 49395 RVA: 0x001CAA4E File Offset: 0x001C8C4E
		// (set) Token: 0x0600C0F4 RID: 49396 RVA: 0x001CAA56 File Offset: 0x001C8C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupRank
		{
			get
			{
				return this.groupRank_;
			}
			set
			{
				this.groupRank_ = value;
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x0600C0F5 RID: 49397 RVA: 0x001CAA5F File Offset: 0x001C8C5F
		// (set) Token: 0x0600C0F6 RID: 49398 RVA: 0x001CAA67 File Offset: 0x001C8C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardedAmount
		{
			get
			{
				return this.rewardedAmount_;
			}
			set
			{
				this.rewardedAmount_ = value;
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x0600C0F7 RID: 49399 RVA: 0x001CAA70 File Offset: 0x001C8C70
		// (set) Token: 0x0600C0F8 RID: 49400 RVA: 0x001CAA78 File Offset: 0x001C8C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AllAmount
		{
			get
			{
				return this.allAmount_;
			}
			set
			{
				this.allAmount_ = value;
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x0600C0F9 RID: 49401 RVA: 0x001CAA81 File Offset: 0x001C8C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> PreItemMap
		{
			get
			{
				return this.preItemMap_;
			}
		}

		// Token: 0x0600C0FA RID: 49402 RVA: 0x001CAA89 File Offset: 0x001C8C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KujiAwardGroupPb);
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x001CAA98 File Offset: 0x001C8C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KujiAwardGroupPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GroupRank == other.GroupRank && this.RewardedAmount == other.RewardedAmount && this.AllAmount == other.AllAmount && this.PreItemMap.Equals(other.PreItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0FC RID: 49404 RVA: 0x001CAB18 File Offset: 0x001C8D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GroupRank != 0)
			{
				num ^= this.GroupRank.GetHashCode();
			}
			if (this.RewardedAmount != 0)
			{
				num ^= this.RewardedAmount.GetHashCode();
			}
			if (this.AllAmount != 0)
			{
				num ^= this.AllAmount.GetHashCode();
			}
			num ^= this.PreItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0FD RID: 49405 RVA: 0x001CABB0 File Offset: 0x001C8DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0FE RID: 49406 RVA: 0x001CABBD File Offset: 0x001C8DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x001CABC8 File Offset: 0x001C8DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GroupRank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupRank);
			}
			if (this.RewardedAmount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardedAmount);
			}
			if (this.AllAmount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.AllAmount);
			}
			this.preItemMap_.WriteTo(ref output, KujiAwardGroupPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C100 RID: 49408 RVA: 0x001CAC6C File Offset: 0x001C8E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GroupRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupRank);
			}
			if (this.RewardedAmount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardedAmount);
			}
			if (this.AllAmount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AllAmount);
			}
			num += this.preItemMap_.CalculateSize(KujiAwardGroupPb._map_preItemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C101 RID: 49409 RVA: 0x001CAD08 File Offset: 0x001C8F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KujiAwardGroupPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GroupRank != 0)
			{
				this.GroupRank = other.GroupRank;
			}
			if (other.RewardedAmount != 0)
			{
				this.RewardedAmount = other.RewardedAmount;
			}
			if (other.AllAmount != 0)
			{
				this.AllAmount = other.AllAmount;
			}
			this.preItemMap_.MergeFrom(other.preItemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C102 RID: 49410 RVA: 0x001CAD91 File Offset: 0x001C8F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x001CAD9C File Offset: 0x001C8F9C
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
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GroupRank = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RewardedAmount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.AllAmount = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.preItemMap_.AddEntriesFrom(ref input, KujiAwardGroupPb._map_preItemMap_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005417 RID: 21527
		private static readonly MessageParser<KujiAwardGroupPb> _parser = new MessageParser<KujiAwardGroupPb>(() => new KujiAwardGroupPb());

		// Token: 0x04005418 RID: 21528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005419 RID: 21529
		public const int IdFieldNumber = 1;

		// Token: 0x0400541A RID: 21530
		private int id_;

		// Token: 0x0400541B RID: 21531
		public const int GroupRankFieldNumber = 2;

		// Token: 0x0400541C RID: 21532
		private int groupRank_;

		// Token: 0x0400541D RID: 21533
		public const int RewardedAmountFieldNumber = 3;

		// Token: 0x0400541E RID: 21534
		private int rewardedAmount_;

		// Token: 0x0400541F RID: 21535
		public const int AllAmountFieldNumber = 4;

		// Token: 0x04005420 RID: 21536
		private int allAmount_;

		// Token: 0x04005421 RID: 21537
		public const int PreItemMapFieldNumber = 5;

		// Token: 0x04005422 RID: 21538
		private static readonly MapField<int, int>.Codec _map_preItemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04005423 RID: 21539
		private readonly MapField<int, int> preItemMap_ = new MapField<int, int>();
	}
}
