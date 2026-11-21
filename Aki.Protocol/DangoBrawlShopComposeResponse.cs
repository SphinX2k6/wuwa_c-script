using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000378 RID: 888
	[NetMessage(EMessageId.DangoBrawlShopComposeResponse)]
	public sealed class DangoBrawlShopComposeResponse : IMessage<DangoBrawlShopComposeResponse>, IMessage, IEquatable<DangoBrawlShopComposeResponse>, IDeepCloneable<DangoBrawlShopComposeResponse>, IBufferMessage
	{
		// Token: 0x06005879 RID: 22649 RVA: 0x000D840E File Offset: 0x000D660E
		[NullableContext(1)]
		public static DangoBrawlShopComposeResponse Create()
		{
			return new DangoBrawlShopComposeResponse();
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x000D8415 File Offset: 0x000D6615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x0600587B RID: 22651 RVA: 0x000D8418 File Offset: 0x000D6618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopComposeResponse.Descriptor;
			}
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x000D841F File Offset: 0x000D661F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse()
		{
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x000D8427 File Offset: 0x000D6627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse(DangoBrawlShopComposeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.newItemUid_ = other.newItemUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x000D8458 File Offset: 0x000D6658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopComposeResponse Clone()
		{
			return new DangoBrawlShopComposeResponse(this);
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600587F RID: 22655 RVA: 0x000D8460 File Offset: 0x000D6660
		// (set) Token: 0x06005880 RID: 22656 RVA: 0x000D8468 File Offset: 0x000D6668
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

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x000D8471 File Offset: 0x000D6671
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x000D8479 File Offset: 0x000D6679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewItemUid
		{
			get
			{
				return this.newItemUid_;
			}
			set
			{
				this.newItemUid_ = value;
			}
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x000D8482 File Offset: 0x000D6682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopComposeResponse);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x000D8490 File Offset: 0x000D6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopComposeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NewItemUid == other.NewItemUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x000D84D0 File Offset: 0x000D66D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NewItemUid != 0)
			{
				num ^= this.NewItemUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x000D852E File Offset: 0x000D672E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x000D853B File Offset: 0x000D673B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x000D8544 File Offset: 0x000D6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.NewItemUid != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NewItemUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x000D859C File Offset: 0x000D679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NewItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewItemUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x000D85F4 File Offset: 0x000D67F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopComposeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NewItemUid != 0)
			{
				this.NewItemUid = other.NewItemUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x000D8644 File Offset: 0x000D6844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x000D8650 File Offset: 0x000D6850
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewItemUid = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003578 RID: 13688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003579 RID: 13689
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400357A RID: 13690
		private ErrorCode errorCode_;

		// Token: 0x0400357B RID: 13691
		public const int NewItemUidFieldNumber = 4;

		// Token: 0x0400357C RID: 13692
		private int newItemUid_;
	}
}
