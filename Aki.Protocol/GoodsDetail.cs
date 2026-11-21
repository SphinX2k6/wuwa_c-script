using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F2 RID: 1778
	public sealed class GoodsDetail : IMessage<GoodsDetail>, IMessage, IEquatable<GoodsDetail>, IDeepCloneable<GoodsDetail>, IBufferMessage
	{
		// Token: 0x0600A248 RID: 41544 RVA: 0x00188875 File Offset: 0x00186A75
		[NullableContext(1)]
		public static GoodsDetail Create()
		{
			return new GoodsDetail();
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600A249 RID: 41545 RVA: 0x0018887C File Offset: 0x00186A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GoodsDetail> Parser
		{
			get
			{
				return GoodsDetail._parser;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600A24A RID: 41546 RVA: 0x00188883 File Offset: 0x00186A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600A24B RID: 41547 RVA: 0x00188886 File Offset: 0x00186A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GoodsDetail.Descriptor;
			}
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x0018888D File Offset: 0x00186A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodsDetail()
		{
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x00188898 File Offset: 0x00186A98
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

		// Token: 0x0600A24E RID: 41550 RVA: 0x0018892C File Offset: 0x00186B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoodsDetail Clone()
		{
			return new GoodsDetail(this);
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600A24F RID: 41551 RVA: 0x00188934 File Offset: 0x00186B34
		// (set) Token: 0x0600A250 RID: 41552 RVA: 0x0018893C File Offset: 0x00186B3C
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

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x00188945 File Offset: 0x00186B45
		// (set) Token: 0x0600A252 RID: 41554 RVA: 0x0018894D File Offset: 0x00186B4D
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

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600A253 RID: 41555 RVA: 0x00188956 File Offset: 0x00186B56
		// (set) Token: 0x0600A254 RID: 41556 RVA: 0x0018895E File Offset: 0x00186B5E
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

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600A255 RID: 41557 RVA: 0x00188967 File Offset: 0x00186B67
		// (set) Token: 0x0600A256 RID: 41558 RVA: 0x0018896F File Offset: 0x00186B6F
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

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600A257 RID: 41559 RVA: 0x00188978 File Offset: 0x00186B78
		// (set) Token: 0x0600A258 RID: 41560 RVA: 0x00188980 File Offset: 0x00186B80
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

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600A259 RID: 41561 RVA: 0x00188989 File Offset: 0x00186B89
		// (set) Token: 0x0600A25A RID: 41562 RVA: 0x00188991 File Offset: 0x00186B91
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

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600A25B RID: 41563 RVA: 0x0018899A File Offset: 0x00186B9A
		// (set) Token: 0x0600A25C RID: 41564 RVA: 0x001889A2 File Offset: 0x00186BA2
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

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600A25D RID: 41565 RVA: 0x001889AB File Offset: 0x00186BAB
		// (set) Token: 0x0600A25E RID: 41566 RVA: 0x001889B3 File Offset: 0x00186BB3
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

		// Token: 0x0600A25F RID: 41567 RVA: 0x001889BC File Offset: 0x00186BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GoodsDetail);
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x001889CC File Offset: 0x00186BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GoodsDetail other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.IsLock == other.IsLock && this.IsNew == other.IsNew && this.IsSell == other.IsSell && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && object.Equals(this.SurvivorsGainData, other.SurvivorsGainData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x00188A7C File Offset: 0x00186C7C
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

		// Token: 0x0600A262 RID: 41570 RVA: 0x00188B67 File Offset: 0x00186D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x00188B74 File Offset: 0x00186D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x00188B80 File Offset: 0x00186D80
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

		// Token: 0x0600A265 RID: 41573 RVA: 0x00188C80 File Offset: 0x00186E80
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

		// Token: 0x0600A266 RID: 41574 RVA: 0x00188D44 File Offset: 0x00186F44
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

		// Token: 0x0600A267 RID: 41575 RVA: 0x00188E24 File Offset: 0x00187024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x00188E30 File Offset: 0x00187030
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

		// Token: 0x04004B8C RID: 19340
		private static readonly MessageParser<GoodsDetail> _parser = new MessageParser<GoodsDetail>(() => new GoodsDetail());

		// Token: 0x04004B8D RID: 19341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B8E RID: 19342
		public const int IndexFieldNumber = 1;

		// Token: 0x04004B8F RID: 19343
		private int index_;

		// Token: 0x04004B90 RID: 19344
		public const int IsLockFieldNumber = 2;

		// Token: 0x04004B91 RID: 19345
		private bool isLock_;

		// Token: 0x04004B92 RID: 19346
		public const int IsNewFieldNumber = 3;

		// Token: 0x04004B93 RID: 19347
		private bool isNew_;

		// Token: 0x04004B94 RID: 19348
		public const int IsSellFieldNumber = 4;

		// Token: 0x04004B95 RID: 19349
		private bool isSell_;

		// Token: 0x04004B96 RID: 19350
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x04004B97 RID: 19351
		private int sourcePrice_;

		// Token: 0x04004B98 RID: 19352
		public const int CurPriceFieldNumber = 6;

		// Token: 0x04004B99 RID: 19353
		private int curPrice_;

		// Token: 0x04004B9A RID: 19354
		public const int ItemIdFieldNumber = 7;

		// Token: 0x04004B9B RID: 19355
		private int itemId_;

		// Token: 0x04004B9C RID: 19356
		public const int SurvivorsGainDataFieldNumber = 8;

		// Token: 0x04004B9D RID: 19357
		private SurvivorsGainData survivorsGainData_;
	}
}
