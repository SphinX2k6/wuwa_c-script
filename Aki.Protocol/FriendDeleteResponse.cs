using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000640 RID: 1600
	[NetMessage(EMessageId.FriendDeleteResponse)]
	public sealed class FriendDeleteResponse : IMessage<FriendDeleteResponse>, IMessage, IEquatable<FriendDeleteResponse>, IDeepCloneable<FriendDeleteResponse>, IBufferMessage
	{
		// Token: 0x0600938C RID: 37772 RVA: 0x00164F01 File Offset: 0x00163101
		[NullableContext(1)]
		public static FriendDeleteResponse Create()
		{
			return new FriendDeleteResponse();
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600938D RID: 37773 RVA: 0x00164F08 File Offset: 0x00163108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x00164F0B File Offset: 0x0016310B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeleteResponse.Descriptor;
			}
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x00164F12 File Offset: 0x00163112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse()
		{
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00164F1A File Offset: 0x0016311A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse(FriendDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00164F3F File Offset: 0x0016313F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse Clone()
		{
			return new FriendDeleteResponse(this);
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06009392 RID: 37778 RVA: 0x00164F47 File Offset: 0x00163147
		// (set) Token: 0x06009393 RID: 37779 RVA: 0x00164F4F File Offset: 0x0016314F
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

		// Token: 0x06009394 RID: 37780 RVA: 0x00164F58 File Offset: 0x00163158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeleteResponse);
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00164F66 File Offset: 0x00163166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x00164F94 File Offset: 0x00163194
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

		// Token: 0x06009397 RID: 37783 RVA: 0x00164FD9 File Offset: 0x001631D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00164FE6 File Offset: 0x001631E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x00164FEF File Offset: 0x001631EF
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

		// Token: 0x0600939A RID: 37786 RVA: 0x00165020 File Offset: 0x00163220
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

		// Token: 0x0600939B RID: 37787 RVA: 0x0016505E File Offset: 0x0016325E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendDeleteResponse other)
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

		// Token: 0x0600939C RID: 37788 RVA: 0x0016508F File Offset: 0x0016328F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x00165098 File Offset: 0x00163298
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

		// Token: 0x04004738 RID: 18232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004739 RID: 18233
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400473A RID: 18234
		private ErrorCode errorCode_;
	}
}
