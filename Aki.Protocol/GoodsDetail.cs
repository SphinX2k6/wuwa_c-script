using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000706 RID: 1798
	public sealed class GoodsDetail : IMessage<GoodsDetail>, IMessage, IEquatable<GoodsDetail>, IDeepCloneable<GoodsDetail>, IBufferMessage
	{
		// Token: 0x0600A39E RID: 41886 RVA: 0x0018B2A9 File Offset: 0x001894A9
		[NullableContext(1)]
		public static GoodsDetail Create()
		{
			return new GoodsDetail();
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600A39F RID: 41887 RVA: 0x0018B2B0 File Offset: 0x001894B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GoodsDetail> Parser
		{
			get
			{
				return GoodsDetail._parser;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600A3A0 RID: 41888 RVA: 0x0018B2B7 File Offset: 0x001894B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x0600A3A1 RID: 41889 RVA: 0x0018B2BA File Offset: 0x001894BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GoodsDetail.Descriptor;
			}
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x0018B2C1 File Offset: 0x001894C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodsDetail()
		{
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x0018B2CC File Offset: 0x001894CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodsDetail(GoodsDetail other) : this()
		{
			this.index_ = other.index_;
			this.isLock_ = other.isLock_;
			this.isNew_ = other.isNew_;
			this.isSell_ = other.isSell_;
			this.sourcePrice_ = other.sourcePrice_;
			this.curPrice_ = other.curPrice_;
			this.itemId_ = other.itemId_;
			this.survivorsGainData_ = ((other.survivorsGainData_ != null) ? other.survivorsGainData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x0018B360 File Offset: 0x00189560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodsDetail Clone()
		{
			return new GoodsDetail(this);
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600A3A5 RID: 41893 RVA: 0x0018B368 File Offset: 0x00189568
		// (set) Token: 0x0600A3A6 RID: 41894 RVA: 0x0018B370 File Offset: 0x00189570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600A3A7 RID: 41895 RVA: 0x0018B379 File Offset: 0x00189579
		// (set) Token: 0x0600A3A8 RID: 41896 RVA: 0x0018B381 File Offset: 0x00189581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600A3A9 RID: 41897 RVA: 0x0018B38A File Offset: 0x0018958A
		// (set) Token: 0x0600A3AA RID: 41898 RVA: 0x0018B392 File Offset: 0x00189592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600A3AB RID: 41899 RVA: 0x0018B39B File Offset: 0x0018959B
		// (set) Token: 0x0600A3AC RID: 41900 RVA: 0x0018B3A3 File Offset: 0x001895A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSell
		{
			get
			{
				return this.isSell_;
			}
			set
			{
				this.isSell_ = value;
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600A3AD RID: 41901 RVA: 0x0018B3AC File Offset: 0x001895AC
		// (set) Token: 0x0600A3AE RID: 41902 RVA: 0x0018B3B4 File Offset: 0x001895B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourcePrice
		{
			get
			{
				return this.sourcePrice_;
			}
			set
			{
				this.sourcePrice_ = value;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x0018B3BD File Offset: 0x001895BD
		// (set) Token: 0x0600A3B0 RID: 41904 RVA: 0x0018B3C5 File Offset: 0x001895C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPrice
		{
			get
			{
				return this.curPrice_;
			}
			set
			{
				this.curPrice_ = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x0018B3CE File Offset: 0x001895CE
		// (set) Token: 0x0600A3B2 RID: 41906 RVA: 0x0018B3D6 File Offset: 0x001895D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x0018B3DF File Offset: 0x001895DF
		// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x0018B3E7 File Offset: 0x001895E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGainData SurvivorsGainData
		{
			get
			{
				return this.survivorsGainData_;
			}
			set
			{
				this.survivorsGainData_ = value;
			}
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x0018B3F0 File Offset: 0x001895F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GoodsDetail);
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x0018B400 File Offset: 0x00189600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GoodsDetail other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.IsLock == other.IsLock && this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && object.Equals(this.SurvivorsGainData, other.SurvivorsGainData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x0018B4B0 File Offset: 0x001896B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.IsSell)
			{
				num ^= this.IsSell.GetHashCode();
			}
			if (this.SourcePrice != 0)
			{
				num ^= this.SourcePrice.GetHashCode();
			}
			if (this.CurPrice != 0)
			{
				num ^= this.CurPrice.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.survivorsGainData_ != null)
			{
				num ^= this.SurvivorsGainData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x0018B59B File Offset: 0x0018979B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x0018B5A8 File Offset: 0x001897A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x0018B5B4 File Offset: 0x001897B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsLock);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsNew);
			}
			if (this.IsSell)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSell);
			}
			if (this.SourcePrice != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.survivorsGainData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SurvivorsGainData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3BB RID: 41915 RVA: 0x0018B6B4 File Offset: 0x001898B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.IsLock)
			{
				num += 2;
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.IsSell)
			{
				num += 2;
			}
			if (this.SourcePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.survivorsGainData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsGainData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x0018B778 File Offset: 0x00189978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GoodsDetail other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.IsSell)
			{
				this.IsSell = other.IsSell;
			}
			if (other.SourcePrice != 0)
			{
				this.SourcePrice = other.SourcePrice;
			}
			if (other.CurPrice != 0)
			{
				this.CurPrice = other.CurPrice;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.survivorsGainData_ != null)
			{
				if (this.survivorsGainData_ == null)
				{
					this.SurvivorsGainData = new SurvivorsGainData();
				}
				this.SurvivorsGainData.MergeFrom(other.SurvivorsGainData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x0018B858 File Offset: 0x00189A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x0018B864 File Offset: 0x00189A64
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
							this.Index = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IsLock = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.IsNew = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.IsSell = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.SourcePrice = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.CurPrice = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 66U)
					{
						if (this.survivorsGainData_ == null)
						{
							this.SurvivorsGainData = new SurvivorsGainData();
						}
						input.ReadMessage(this.SurvivorsGainData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B93 RID: 19347
		private static readonly MessageParser<GoodsDetail> _parser = new MessageParser<GoodsDetail>(() => new GoodsDetail());

		// Token: 0x04004B94 RID: 19348
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B95 RID: 19349
		public const int IndexFieldNumber = 1;

		// Token: 0x04004B96 RID: 19350
		private int index_;

		// Token: 0x04004B97 RID: 19351
		public const int IsLockFieldNumber = 2;

		// Token: 0x04004B98 RID: 19352
		private bool isLock_;

		// Token: 0x04004B99 RID: 19353
		public const int IsNewFieldNumber = 3;

		// Token: 0x04004B9A RID: 19354
		private bool isNew_;

		// Token: 0x04004B9B RID: 19355
		public const int IsSellFieldNumber = 4;

		// Token: 0x04004B9C RID: 19356
		private bool isSell_;

		// Token: 0x04004B9D RID: 19357
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x04004B9E RID: 19358
		private int sourcePrice_;

		// Token: 0x04004B9F RID: 19359
		public const int CurPriceFieldNumber = 6;

		// Token: 0x04004BA0 RID: 19360
		private int curPrice_;

		// Token: 0x04004BA1 RID: 19361
		public const int ItemIdFieldNumber = 7;

		// Token: 0x04004BA2 RID: 19362
		private int itemId_;

		// Token: 0x04004BA3 RID: 19363
		public const int SurvivorsGainDataFieldNumber = 8;

		// Token: 0x04004BA4 RID: 19364
		private SurvivorsGainData survivorsGainData_;
	}
}
