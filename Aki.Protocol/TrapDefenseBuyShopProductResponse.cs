using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001489 RID: 5257
	[NetMessage(EMessageId.TrapDefenseBuyShopProductResponse)]
	public sealed class TrapDefenseBuyShopProductResponse : IMessage<TrapDefenseBuyShopProductResponse>, IMessage, IEquatable<TrapDefenseBuyShopProductResponse>, IDeepCloneable<TrapDefenseBuyShopProductResponse>, IBufferMessage
	{
		// Token: 0x0601BEA2 RID: 114338 RVA: 0x0040E31F File Offset: 0x0040C51F
		[NullableContext(1)]
		public static TrapDefenseBuyShopProductResponse Create()
		{
			return new TrapDefenseBuyShopProductResponse();
		}

		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x0601BEA3 RID: 114339 RVA: 0x0040E326 File Offset: 0x0040C526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x0601BEA4 RID: 114340 RVA: 0x0040E329 File Offset: 0x0040C529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuyShopProductResponse.Descriptor;
			}
		}

		// Token: 0x0601BEA5 RID: 114341 RVA: 0x0040E330 File Offset: 0x0040C530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse()
		{
		}

		// Token: 0x0601BEA6 RID: 114342 RVA: 0x0040E338 File Offset: 0x0040C538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse(TrapDefenseBuyShopProductResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BEA7 RID: 114343 RVA: 0x0040E384 File Offset: 0x0040C584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse Clone()
		{
			return new TrapDefenseBuyShopProductResponse(this);
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x0601BEA8 RID: 114344 RVA: 0x0040E38C File Offset: 0x0040C58C
		// (set) Token: 0x0601BEA9 RID: 114345 RVA: 0x0040E394 File Offset: 0x0040C594
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

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x0601BEAA RID: 114346 RVA: 0x0040E39D File Offset: 0x0040C59D
		// (set) Token: 0x0601BEAB RID: 114347 RVA: 0x0040E3A5 File Offset: 0x0040C5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseShopPanelInfo ShopInfo
		{
			get
			{
				return this.shopInfo_;
			}
			set
			{
				this.shopInfo_ = value;
			}
		}

		// Token: 0x0601BEAC RID: 114348 RVA: 0x0040E3AE File Offset: 0x0040C5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuyShopProductResponse);
		}

		// Token: 0x0601BEAD RID: 114349 RVA: 0x0040E3BC File Offset: 0x0040C5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuyShopProductResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BEAE RID: 114350 RVA: 0x0040E40C File Offset: 0x0040C60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.shopInfo_ != null)
			{
				num ^= this.ShopInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BEAF RID: 114351 RVA: 0x0040E467 File Offset: 0x0040C667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BEB0 RID: 114352 RVA: 0x0040E474 File Offset: 0x0040C674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BEB1 RID: 114353 RVA: 0x0040E480 File Offset: 0x0040C680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.shopInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BEB2 RID: 114354 RVA: 0x0040E4D8 File Offset: 0x0040C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.shopInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BEB3 RID: 114355 RVA: 0x0040E530 File Offset: 0x0040C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuyShopProductResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.shopInfo_ != null)
			{
				if (this.shopInfo_ == null)
				{
					this.ShopInfo = new TrapDefenseShopPanelInfo();
				}
				this.ShopInfo.MergeFrom(other.ShopInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BEB4 RID: 114356 RVA: 0x0040E598 File Offset: 0x0040C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BEB5 RID: 114357 RVA: 0x0040E5A4 File Offset: 0x0040C7A4
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
				if (num != 8U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.shopInfo_ == null)
						{
							this.ShopInfo = new TrapDefenseShopPanelInfo();
						}
						input.ReadMessage(this.ShopInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1E1 RID: 41441
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1E2 RID: 41442
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A1E3 RID: 41443
		private ErrorCode errorCode_;

		// Token: 0x0400A1E4 RID: 41444
		public const int ShopInfoFieldNumber = 10;

		// Token: 0x0400A1E5 RID: 41445
		private TrapDefenseShopPanelInfo shopInfo_;
	}
}
