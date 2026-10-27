using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000375 RID: 885
	[NetMessage(EMessageId.DangoBrawlShopRefreshResponse)]
	public sealed class DangoBrawlShopRefreshResponse : IMessage<DangoBrawlShopRefreshResponse>, IMessage, IEquatable<DangoBrawlShopRefreshResponse>, IDeepCloneable<DangoBrawlShopRefreshResponse>, IBufferMessage
	{
		// Token: 0x060057EC RID: 22508 RVA: 0x000D691E File Offset: 0x000D4B1E
		[NullableContext(1)]
		public static DangoBrawlShopRefreshResponse Create()
		{
			return new DangoBrawlShopRefreshResponse();
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060057ED RID: 22509 RVA: 0x000D6925 File Offset: 0x000D4B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x000D6928 File Offset: 0x000D4B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopRefreshResponse.Descriptor;
			}
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x000D692F File Offset: 0x000D4B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse()
		{
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x000D6938 File Offset: 0x000D4B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse(DangoBrawlShopRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x000D6984 File Offset: 0x000D4B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse Clone()
		{
			return new DangoBrawlShopRefreshResponse(this);
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060057F2 RID: 22514 RVA: 0x000D698C File Offset: 0x000D4B8C
		// (set) Token: 0x060057F3 RID: 22515 RVA: 0x000D6994 File Offset: 0x000D4B94
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

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x000D699D File Offset: 0x000D4B9D
		// (set) Token: 0x060057F5 RID: 22517 RVA: 0x000D69A5 File Offset: 0x000D4BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopInfo Shop
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

		// Token: 0x060057F6 RID: 22518 RVA: 0x000D69AE File Offset: 0x000D4BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopRefreshResponse);
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x000D69BC File Offset: 0x000D4BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Shop, other.Shop) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x000D6A0C File Offset: 0x000D4C0C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x000D6A67 File Offset: 0x000D4C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x000D6A74 File Offset: 0x000D4C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x000D6A80 File Offset: 0x000D4C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Shop);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x000D6ADC File Offset: 0x000D4CDC
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x000D6B34 File Offset: 0x000D4D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopRefreshResponse other)
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
					this.Shop = new DangoBrawlShopInfo();
				}
				this.Shop.MergeFrom(other.Shop);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x000D6B9C File Offset: 0x000D4D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x000D6BA8 File Offset: 0x000D4DA8
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
				if (num != 34U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.shop_ == null)
					{
						this.Shop = new DangoBrawlShopInfo();
					}
					input.ReadMessage(this.Shop);
				}
			}
		}

		// Token: 0x040034F2 RID: 13554
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034F3 RID: 13555
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040034F4 RID: 13556
		private ErrorCode errorCode_;

		// Token: 0x040034F5 RID: 13557
		public const int ShopFieldNumber = 4;

		// Token: 0x040034F6 RID: 13558
		private DangoBrawlShopInfo shop_;
	}
}
