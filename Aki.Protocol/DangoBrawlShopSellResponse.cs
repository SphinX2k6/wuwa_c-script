using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200037F RID: 895
	[NetMessage(EMessageId.DangoBrawlShopSellResponse)]
	public sealed class DangoBrawlShopSellResponse : IMessage<DangoBrawlShopSellResponse>, IMessage, IEquatable<DangoBrawlShopSellResponse>, IDeepCloneable<DangoBrawlShopSellResponse>, IBufferMessage
	{
		// Token: 0x06005903 RID: 22787 RVA: 0x000D95EE File Offset: 0x000D77EE
		[NullableContext(1)]
		public static DangoBrawlShopSellResponse Create()
		{
			return new DangoBrawlShopSellResponse();
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06005904 RID: 22788 RVA: 0x000D95F5 File Offset: 0x000D77F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x000D95F8 File Offset: 0x000D77F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlShopSellResponse.Descriptor;
			}
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x000D95FF File Offset: 0x000D77FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse()
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x000D9607 File Offset: 0x000D7807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse(DangoBrawlShopSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x000D962C File Offset: 0x000D782C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlShopSellResponse Clone()
		{
			return new DangoBrawlShopSellResponse(this);
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06005909 RID: 22793 RVA: 0x000D9634 File Offset: 0x000D7834
		// (set) Token: 0x0600590A RID: 22794 RVA: 0x000D963C File Offset: 0x000D783C
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

		// Token: 0x0600590B RID: 22795 RVA: 0x000D9645 File Offset: 0x000D7845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlShopSellResponse);
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x000D9653 File Offset: 0x000D7853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlShopSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x000D9684 File Offset: 0x000D7884
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

		// Token: 0x0600590E RID: 22798 RVA: 0x000D96C9 File Offset: 0x000D78C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x000D96D6 File Offset: 0x000D78D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x000D96DF File Offset: 0x000D78DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06005911 RID: 22801 RVA: 0x000D9714 File Offset: 0x000D7914
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

		// Token: 0x06005912 RID: 22802 RVA: 0x000D9752 File Offset: 0x000D7952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlShopSellResponse other)
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

		// Token: 0x06005913 RID: 22803 RVA: 0x000D9783 File Offset: 0x000D7983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x000D978C File Offset: 0x000D798C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400359B RID: 13723
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400359C RID: 13724
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400359D RID: 13725
		private ErrorCode errorCode_;
	}
}
