using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001403 RID: 5123
	public sealed class TotalTopUpScoreInfo : IMessage<TotalTopUpScoreInfo>, IMessage, IEquatable<TotalTopUpScoreInfo>, IDeepCloneable<TotalTopUpScoreInfo>, IBufferMessage
	{
		// Token: 0x0601B3C3 RID: 111555 RVA: 0x003F63B1 File Offset: 0x003F45B1
		[NullableContext(1)]
		public static TotalTopUpScoreInfo Create()
		{
			return new TotalTopUpScoreInfo();
		}

		// Token: 0x17005C30 RID: 23600
		// (get) Token: 0x0601B3C4 RID: 111556 RVA: 0x003F63B8 File Offset: 0x003F45B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TotalTopUpScoreInfo> Parser
		{
			get
			{
				return TotalTopUpScoreInfo._parser;
			}
		}

		// Token: 0x17005C31 RID: 23601
		// (get) Token: 0x0601B3C5 RID: 111557 RVA: 0x003F63BF File Offset: 0x003F45BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C32 RID: 23602
		// (get) Token: 0x0601B3C6 RID: 111558 RVA: 0x003F63C2 File Offset: 0x003F45C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601B3C7 RID: 111559 RVA: 0x003F63C9 File Offset: 0x003F45C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo()
		{
		}

		// Token: 0x0601B3C8 RID: 111560 RVA: 0x003F63D4 File Offset: 0x003F45D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo(TotalTopUpScoreInfo other) : this()
		{
			this.id_ = other.id_;
			this.goodsId_ = other.goodsId_;
			this.type_ = other.type_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3C9 RID: 111561 RVA: 0x003F6428 File Offset: 0x003F4628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpScoreInfo Clone()
		{
			return new TotalTopUpScoreInfo(this);
		}

		// Token: 0x17005C33 RID: 23603
		// (get) Token: 0x0601B3CA RID: 111562 RVA: 0x003F6430 File Offset: 0x003F4630
		// (set) Token: 0x0601B3CB RID: 111563 RVA: 0x003F6438 File Offset: 0x003F4638
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

		// Token: 0x17005C34 RID: 23604
		// (get) Token: 0x0601B3CC RID: 111564 RVA: 0x003F6441 File Offset: 0x003F4641
		// (set) Token: 0x0601B3CD RID: 111565 RVA: 0x003F6449 File Offset: 0x003F4649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodsId
		{
			get
			{
				return this.goodsId_;
			}
			set
			{
				this.goodsId_ = value;
			}
		}

		// Token: 0x17005C35 RID: 23605
		// (get) Token: 0x0601B3CE RID: 111566 RVA: 0x003F6452 File Offset: 0x003F4652
		// (set) Token: 0x0601B3CF RID: 111567 RVA: 0x003F645A File Offset: 0x003F465A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17005C36 RID: 23606
		// (get) Token: 0x0601B3D0 RID: 111568 RVA: 0x003F6463 File Offset: 0x003F4663
		// (set) Token: 0x0601B3D1 RID: 111569 RVA: 0x003F646B File Offset: 0x003F466B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x003F6474 File Offset: 0x003F4674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpScoreInfo);
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x003F6484 File Offset: 0x003F4684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpScoreInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GoodsId == other.GoodsId && this.Type == other.Type && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x003F64F0 File Offset: 0x003F46F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GoodsId != 0)
			{
				num ^= this.GoodsId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x003F657A File Offset: 0x003F477A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3D6 RID: 111574 RVA: 0x003F6587 File Offset: 0x003F4787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3D7 RID: 111575 RVA: 0x003F6590 File Offset: 0x003F4790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GoodsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GoodsId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Type);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3D8 RID: 111576 RVA: 0x003F6620 File Offset: 0x003F4820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GoodsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodsId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3D9 RID: 111577 RVA: 0x003F66A8 File Offset: 0x003F48A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GoodsId != 0)
			{
				this.GoodsId = other.GoodsId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3DA RID: 111578 RVA: 0x003F6720 File Offset: 0x003F4920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3DB RID: 111579 RVA: 0x003F672C File Offset: 0x003F492C
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
						this.GoodsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Type = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009EC2 RID: 40642
		private static readonly MessageParser<TotalTopUpScoreInfo> _parser = new MessageParser<TotalTopUpScoreInfo>(() => new TotalTopUpScoreInfo());

		// Token: 0x04009EC3 RID: 40643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EC4 RID: 40644
		public const int IdFieldNumber = 1;

		// Token: 0x04009EC5 RID: 40645
		private int id_;

		// Token: 0x04009EC6 RID: 40646
		public const int GoodsIdFieldNumber = 2;

		// Token: 0x04009EC7 RID: 40647
		private int goodsId_;

		// Token: 0x04009EC8 RID: 40648
		public const int TypeFieldNumber = 3;

		// Token: 0x04009EC9 RID: 40649
		private int type_;

		// Token: 0x04009ECA RID: 40650
		public const int ScoreFieldNumber = 4;

		// Token: 0x04009ECB RID: 40651
		private int score_;
	}
}
