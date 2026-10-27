using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C7 RID: 1479
	[NetMessage(EMessageId.FloroRanchPlayRefreshShopResponse)]
	public sealed class FloroRanchPlayRefreshShopResponse : IMessage<FloroRanchPlayRefreshShopResponse>, IMessage, IEquatable<FloroRanchPlayRefreshShopResponse>, IDeepCloneable<FloroRanchPlayRefreshShopResponse>, IBufferMessage
	{
		// Token: 0x060088AA RID: 34986 RVA: 0x001493EF File Offset: 0x001475EF
		[NullableContext(1)]
		public static FloroRanchPlayRefreshShopResponse Create()
		{
			return new FloroRanchPlayRefreshShopResponse();
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060088AB RID: 34987 RVA: 0x001493F6 File Offset: 0x001475F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060088AC RID: 34988 RVA: 0x001493F9 File Offset: 0x001475F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshShopResponse.Descriptor;
			}
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x00149400 File Offset: 0x00147600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopResponse()
		{
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x00149408 File Offset: 0x00147608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopResponse(FloroRanchPlayRefreshShopResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x0014946C File Offset: 0x0014766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopResponse Clone()
		{
			return new FloroRanchPlayRefreshShopResponse(this);
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060088B0 RID: 34992 RVA: 0x00149474 File Offset: 0x00147674
		// (set) Token: 0x060088B1 RID: 34993 RVA: 0x0014947C File Offset: 0x0014767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060088B2 RID: 34994 RVA: 0x00149485 File Offset: 0x00147685
		// (set) Token: 0x060088B3 RID: 34995 RVA: 0x0014948D File Offset: 0x0014768D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchShop Shop
		{
			get
			{
				return this.shop_;
			}
			set
			{
				this.shop_ = value;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060088B4 RID: 34996 RVA: 0x00149496 File Offset: 0x00147696
		// (set) Token: 0x060088B5 RID: 34997 RVA: 0x0014949E File Offset: 0x0014769E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060088B6 RID: 34998 RVA: 0x001494A7 File Offset: 0x001476A7
		// (set) Token: 0x060088B7 RID: 34999 RVA: 0x001494AF File Offset: 0x001476AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurDiamond
		{
			get
			{
				return this.curDiamond_;
			}
			set
			{
				this.curDiamond_ = value;
			}
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x001494B8 File Offset: 0x001476B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshShopResponse);
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x001494C8 File Offset: 0x001476C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshShopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Shop, other.Shop) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x00149538 File Offset: 0x00147738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.shop_ != null)
			{
				num ^= this.Shop.GetHashCode();
			}
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088BB RID: 35003 RVA: 0x001495C5 File Offset: 0x001477C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x001495D2 File Offset: 0x001477D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x001495DC File Offset: 0x001477DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Shop);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurCoin);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x00149670 File Offset: 0x00147870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.shop_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Shop);
			}
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x001496F8 File Offset: 0x001478F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshShopResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.shop_ != null)
			{
				if (this.shop_ == null)
				{
					this.Shop = new FloroRanchShop();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x00149788 File Offset: 0x00147988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x00149794 File Offset: 0x00147994
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
				if (num <= 64U)
				{
					if (num == 10U)
					{
						if (this.shop_ == null)
						{
							this.Shop = new FloroRanchShop();
						}
						input.ReadMessage(this.Shop);
						continue;
					}
					if (num == 64U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004340 RID: 17216
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004341 RID: 17217
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004342 RID: 17218
		private ErrorCode errorCode_;

		// Token: 0x04004343 RID: 17219
		public const int ShopFieldNumber = 1;

		// Token: 0x04004344 RID: 17220
		private FloroRanchShop shop_;

		// Token: 0x04004345 RID: 17221
		public const int CurCoinFieldNumber = 12;

		// Token: 0x04004346 RID: 17222
		private long curCoin_;

		// Token: 0x04004347 RID: 17223
		public const int CurDiamondFieldNumber = 8;

		// Token: 0x04004348 RID: 17224
		private long curDiamond_;
	}
}
