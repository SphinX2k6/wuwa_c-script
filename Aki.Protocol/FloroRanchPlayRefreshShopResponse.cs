using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B2 RID: 1458
	[NetMessage(EMessageId.FloroRanchPlayRefreshShopResponse)]
	public sealed class FloroRanchPlayRefreshShopResponse : IMessage<FloroRanchPlayRefreshShopResponse>, IMessage, IEquatable<FloroRanchPlayRefreshShopResponse>, IDeepCloneable<FloroRanchPlayRefreshShopResponse>, IBufferMessage
	{
		// Token: 0x06008742 RID: 34626 RVA: 0x001467D6 File Offset: 0x001449D6
		[NullableContext(1)]
		public static FloroRanchPlayRefreshShopResponse Create()
		{
			return new FloroRanchPlayRefreshShopResponse();
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06008743 RID: 34627 RVA: 0x001467DD File Offset: 0x001449DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06008744 RID: 34628 RVA: 0x001467E0 File Offset: 0x001449E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshShopResponse.Descriptor;
			}
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x001467E7 File Offset: 0x001449E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopResponse()
		{
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x001467F0 File Offset: 0x001449F0
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

		// Token: 0x06008747 RID: 34631 RVA: 0x00146854 File Offset: 0x00144A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopResponse Clone()
		{
			return new FloroRanchPlayRefreshShopResponse(this);
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06008748 RID: 34632 RVA: 0x0014685C File Offset: 0x00144A5C
		// (set) Token: 0x06008749 RID: 34633 RVA: 0x00146864 File Offset: 0x00144A64
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

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x0600874A RID: 34634 RVA: 0x0014686D File Offset: 0x00144A6D
		// (set) Token: 0x0600874B RID: 34635 RVA: 0x00146875 File Offset: 0x00144A75
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

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600874C RID: 34636 RVA: 0x0014687E File Offset: 0x00144A7E
		// (set) Token: 0x0600874D RID: 34637 RVA: 0x00146886 File Offset: 0x00144A86
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

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x0014688F File Offset: 0x00144A8F
		// (set) Token: 0x0600874F RID: 34639 RVA: 0x00146897 File Offset: 0x00144A97
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

		// Token: 0x06008750 RID: 34640 RVA: 0x001468A0 File Offset: 0x00144AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshShopResponse);
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x001468B0 File Offset: 0x00144AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshShopResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Shop, other.Shop) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00146920 File Offset: 0x00144B20
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

		// Token: 0x06008753 RID: 34643 RVA: 0x001469AD File Offset: 0x00144BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x001469BA File Offset: 0x00144BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x001469C4 File Offset: 0x00144BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Shop);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.CurCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00146A58 File Offset: 0x00144C58
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

		// Token: 0x06008757 RID: 34647 RVA: 0x00146AE0 File Offset: 0x00144CE0
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

		// Token: 0x06008758 RID: 34648 RVA: 0x00146B70 File Offset: 0x00144D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00146B7C File Offset: 0x00144D7C
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
					if (num == 26U)
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004336 RID: 17206
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004337 RID: 17207
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004338 RID: 17208
		private ErrorCode errorCode_;

		// Token: 0x04004339 RID: 17209
		public const int ShopFieldNumber = 3;

		// Token: 0x0400433A RID: 17210
		private FloroRanchShop shop_;

		// Token: 0x0400433B RID: 17211
		public const int CurCoinFieldNumber = 13;

		// Token: 0x0400433C RID: 17212
		private long curCoin_;

		// Token: 0x0400433D RID: 17213
		public const int CurDiamondFieldNumber = 11;

		// Token: 0x0400433E RID: 17214
		private long curDiamond_;
	}
}
