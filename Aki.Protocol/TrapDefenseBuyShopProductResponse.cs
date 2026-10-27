using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001416 RID: 5142
	[NetMessage(EMessageId.TrapDefenseBuyShopProductResponse)]
	public sealed class TrapDefenseBuyShopProductResponse : IMessage<TrapDefenseBuyShopProductResponse>, IMessage, IEquatable<TrapDefenseBuyShopProductResponse>, IDeepCloneable<TrapDefenseBuyShopProductResponse>, IBufferMessage
	{
		// Token: 0x0601B417 RID: 111639 RVA: 0x003F3047 File Offset: 0x003F1247
		[NullableContext(1)]
		public static TrapDefenseBuyShopProductResponse Create()
		{
			return new TrapDefenseBuyShopProductResponse();
		}

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x0601B418 RID: 111640 RVA: 0x003F304E File Offset: 0x003F124E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BF0 RID: 23536
		// (get) Token: 0x0601B419 RID: 111641 RVA: 0x003F3051 File Offset: 0x003F1251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuyShopProductResponse.Descriptor;
			}
		}

		// Token: 0x0601B41A RID: 111642 RVA: 0x003F3058 File Offset: 0x003F1258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse()
		{
		}

		// Token: 0x0601B41B RID: 111643 RVA: 0x003F3060 File Offset: 0x003F1260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse(TrapDefenseBuyShopProductResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shopInfo_ = ((other.shopInfo_ != null) ? other.shopInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B41C RID: 111644 RVA: 0x003F30AC File Offset: 0x003F12AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuyShopProductResponse Clone()
		{
			return new TrapDefenseBuyShopProductResponse(this);
		}

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x0601B41D RID: 111645 RVA: 0x003F30B4 File Offset: 0x003F12B4
		// (set) Token: 0x0601B41E RID: 111646 RVA: 0x003F30BC File Offset: 0x003F12BC
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

		// Token: 0x17005BF2 RID: 23538
		// (get) Token: 0x0601B41F RID: 111647 RVA: 0x003F30C5 File Offset: 0x003F12C5
		// (set) Token: 0x0601B420 RID: 111648 RVA: 0x003F30CD File Offset: 0x003F12CD
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

		// Token: 0x0601B421 RID: 111649 RVA: 0x003F30D6 File Offset: 0x003F12D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuyShopProductResponse);
		}

		// Token: 0x0601B422 RID: 111650 RVA: 0x003F30E4 File Offset: 0x003F12E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuyShopProductResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ShopInfo, other.ShopInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B423 RID: 111651 RVA: 0x003F3134 File Offset: 0x003F1334
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

		// Token: 0x0601B424 RID: 111652 RVA: 0x003F318F File Offset: 0x003F138F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B425 RID: 111653 RVA: 0x003F319C File Offset: 0x003F139C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x003F31A8 File Offset: 0x003F13A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.shopInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ShopInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B427 RID: 111655 RVA: 0x003F3204 File Offset: 0x003F1404
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

		// Token: 0x0601B428 RID: 111656 RVA: 0x003F325C File Offset: 0x003F145C
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

		// Token: 0x0601B429 RID: 111657 RVA: 0x003F32C4 File Offset: 0x003F14C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B42A RID: 111658 RVA: 0x003F32D0 File Offset: 0x003F14D0
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
				if (num != 32U)
				{
					if (num != 98U)
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

		// Token: 0x04009D9A RID: 40346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D9B RID: 40347
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009D9C RID: 40348
		private ErrorCode errorCode_;

		// Token: 0x04009D9D RID: 40349
		public const int ShopInfoFieldNumber = 12;

		// Token: 0x04009D9E RID: 40350
		private TrapDefenseShopPanelInfo shopInfo_;
	}
}
