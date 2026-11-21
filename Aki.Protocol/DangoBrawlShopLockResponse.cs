using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037B RID: 891
	[NetMessage(EMessageId.DangoBrawlShopLockResponse)]
	public sealed class DangoBrawlShopLockResponse : IMessage<DangoBrawlShopLockResponse>, IMessage, IEquatable<DangoBrawlShopLockResponse>, IDeepCloneable<DangoBrawlShopLockResponse>, IBufferMessage
	{
		// Token: 0x060058B7 RID: 22711 RVA: 0x000D8C8C File Offset: 0x000D6E8C
		[NullableContext(1)]
		public static DangoBrawlShopLockResponse Create()
		{
			return new DangoBrawlShopLockResponse();
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x000D8C93 File Offset: 0x000D6E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060058B9 RID: 22713 RVA: 0x000D8C96 File Offset: 0x000D6E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopLockResponse.Descriptor;
			}
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x000D8C9D File Offset: 0x000D6E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse()
		{
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x000D8CA5 File Offset: 0x000D6EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse(DangoBrawlShopLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x000D8CCA File Offset: 0x000D6ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopLockResponse Clone()
		{
			return new DangoBrawlShopLockResponse(this);
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060058BD RID: 22717 RVA: 0x000D8CD2 File Offset: 0x000D6ED2
		// (set) Token: 0x060058BE RID: 22718 RVA: 0x000D8CDA File Offset: 0x000D6EDA
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

		// Token: 0x060058BF RID: 22719 RVA: 0x000D8CE3 File Offset: 0x000D6EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopLockResponse);
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x000D8CF1 File Offset: 0x000D6EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x000D8D20 File Offset: 0x000D6F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x000D8D65 File Offset: 0x000D6F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x000D8D72 File Offset: 0x000D6F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x000D8D7B File Offset: 0x000D6F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x000D8DB0 File Offset: 0x000D6FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x000D8DEE File Offset: 0x000D6FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x000D8E1F File Offset: 0x000D701F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x000D8E28 File Offset: 0x000D7028
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400358A RID: 13706
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400358B RID: 13707
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400358C RID: 13708
		private ErrorCode errorCode_;
	}
}
