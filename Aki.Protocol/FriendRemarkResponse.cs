using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065A RID: 1626
	[NetMessage(EMessageId.FriendRemarkResponse)]
	public sealed class FriendRemarkResponse : IMessage<FriendRemarkResponse>, IMessage, IEquatable<FriendRemarkResponse>, IDeepCloneable<FriendRemarkResponse>, IBufferMessage
	{
		// Token: 0x06009556 RID: 38230 RVA: 0x00168870 File Offset: 0x00166A70
		[NullableContext(1)]
		public static FriendRemarkResponse Create()
		{
			return new FriendRemarkResponse();
		}

		// Token: 0x17001DB8 RID: 7608
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x00168877 File Offset: 0x00166A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DB9 RID: 7609
		// (get) Token: 0x06009558 RID: 38232 RVA: 0x0016887A File Offset: 0x00166A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRemarkResponse.Descriptor;
			}
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x00168881 File Offset: 0x00166A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse()
		{
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x00168889 File Offset: 0x00166A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse(FriendRemarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x001688AE File Offset: 0x00166AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse Clone()
		{
			return new FriendRemarkResponse(this);
		}

		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x001688B6 File Offset: 0x00166AB6
		// (set) Token: 0x0600955D RID: 38237 RVA: 0x001688BE File Offset: 0x00166ABE
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

		// Token: 0x0600955E RID: 38238 RVA: 0x001688C7 File Offset: 0x00166AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRemarkResponse);
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x001688D5 File Offset: 0x00166AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRemarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x00168904 File Offset: 0x00166B04
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

		// Token: 0x06009561 RID: 38241 RVA: 0x00168949 File Offset: 0x00166B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009562 RID: 38242 RVA: 0x00168956 File Offset: 0x00166B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x0016895F File Offset: 0x00166B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x00168990 File Offset: 0x00166B90
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

		// Token: 0x06009565 RID: 38245 RVA: 0x001689CE File Offset: 0x00166BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRemarkResponse other)
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

		// Token: 0x06009566 RID: 38246 RVA: 0x001689FF File Offset: 0x00166BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x00168A08 File Offset: 0x00166C08
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400475E RID: 18270
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400475F RID: 18271
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04004760 RID: 18272
		private ErrorCode errorCode_;
	}
}
