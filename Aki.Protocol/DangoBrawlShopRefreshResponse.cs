using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037D RID: 893
	[NetMessage(EMessageId.DangoBrawlShopRefreshResponse)]
	public sealed class DangoBrawlShopRefreshResponse : IMessage<DangoBrawlShopRefreshResponse>, IMessage, IEquatable<DangoBrawlShopRefreshResponse>, IDeepCloneable<DangoBrawlShopRefreshResponse>, IBufferMessage
	{
		// Token: 0x060058D9 RID: 22745 RVA: 0x000D8FA6 File Offset: 0x000D71A6
		[NullableContext(1)]
		public static DangoBrawlShopRefreshResponse Create()
		{
			return new DangoBrawlShopRefreshResponse();
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x000D8FAD File Offset: 0x000D71AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x000D8FB0 File Offset: 0x000D71B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopRefreshResponse.Descriptor;
			}
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x000D8FB7 File Offset: 0x000D71B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse()
		{
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x000D8FC0 File Offset: 0x000D71C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse(DangoBrawlShopRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x000D900C File Offset: 0x000D720C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopRefreshResponse Clone()
		{
			return new DangoBrawlShopRefreshResponse(this);
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x000D9014 File Offset: 0x000D7214
		// (set) Token: 0x060058E0 RID: 22752 RVA: 0x000D901C File Offset: 0x000D721C
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

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x000D9025 File Offset: 0x000D7225
		// (set) Token: 0x060058E2 RID: 22754 RVA: 0x000D902D File Offset: 0x000D722D
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

		// Token: 0x060058E3 RID: 22755 RVA: 0x000D9036 File Offset: 0x000D7236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopRefreshResponse);
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x000D9044 File Offset: 0x000D7244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Shop, other.Shop) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x000D9094 File Offset: 0x000D7294
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

		// Token: 0x060058E6 RID: 22758 RVA: 0x000D90EF File Offset: 0x000D72EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x000D90FC File Offset: 0x000D72FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x000D9108 File Offset: 0x000D7308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.shop_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Shop);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x000D9164 File Offset: 0x000D7364
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

		// Token: 0x060058EA RID: 22762 RVA: 0x000D91BC File Offset: 0x000D73BC
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

		// Token: 0x060058EB RID: 22763 RVA: 0x000D9224 File Offset: 0x000D7424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x000D9230 File Offset: 0x000D7430
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
				if (num != 42U)
				{
					if (num != 80U)
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

		// Token: 0x0400358E RID: 13710
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400358F RID: 13711
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003590 RID: 13712
		private ErrorCode errorCode_;

		// Token: 0x04003591 RID: 13713
		public const int ShopFieldNumber = 5;

		// Token: 0x04003592 RID: 13714
		private DangoBrawlShopInfo shop_;
	}
}
