using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000646 RID: 1606
	[NetMessage(EMessageId.FriendRemarkResponse)]
	public sealed class FriendRemarkResponse : IMessage<FriendRemarkResponse>, IMessage, IEquatable<FriendRemarkResponse>, IDeepCloneable<FriendRemarkResponse>, IBufferMessage
	{
		// Token: 0x06009400 RID: 37888 RVA: 0x00165E3C File Offset: 0x0016403C
		[NullableContext(1)]
		public static FriendRemarkResponse Create()
		{
			return new FriendRemarkResponse();
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x00165E43 File Offset: 0x00164043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x06009402 RID: 37890 RVA: 0x00165E46 File Offset: 0x00164046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRemarkResponse.Descriptor;
			}
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00165E4D File Offset: 0x0016404D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse()
		{
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00165E55 File Offset: 0x00164055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse(FriendRemarkResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00165E7A File Offset: 0x0016407A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRemarkResponse Clone()
		{
			return new FriendRemarkResponse(this);
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06009406 RID: 37894 RVA: 0x00165E82 File Offset: 0x00164082
		// (set) Token: 0x06009407 RID: 37895 RVA: 0x00165E8A File Offset: 0x0016408A
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

		// Token: 0x06009408 RID: 37896 RVA: 0x00165E93 File Offset: 0x00164093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRemarkResponse);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00165EA1 File Offset: 0x001640A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRemarkResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00165ED0 File Offset: 0x001640D0
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

		// Token: 0x0600940B RID: 37899 RVA: 0x00165F15 File Offset: 0x00164115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00165F22 File Offset: 0x00164122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00165F2B File Offset: 0x0016412B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00165F60 File Offset: 0x00164160
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

		// Token: 0x0600940F RID: 37903 RVA: 0x00165F9E File Offset: 0x0016419E
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

		// Token: 0x06009410 RID: 37904 RVA: 0x00165FCF File Offset: 0x001641CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00165FD8 File Offset: 0x001641D8
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004757 RID: 18263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004758 RID: 18264
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004759 RID: 18265
		private ErrorCode errorCode_;
	}
}
