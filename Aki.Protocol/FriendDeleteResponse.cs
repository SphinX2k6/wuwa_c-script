using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000654 RID: 1620
	[NetMessage(EMessageId.FriendDeleteResponse)]
	public sealed class FriendDeleteResponse : IMessage<FriendDeleteResponse>, IMessage, IEquatable<FriendDeleteResponse>, IDeepCloneable<FriendDeleteResponse>, IBufferMessage
	{
		// Token: 0x060094E2 RID: 38114 RVA: 0x00167931 File Offset: 0x00165B31
		[NullableContext(1)]
		public static FriendDeleteResponse Create()
		{
			return new FriendDeleteResponse();
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x060094E3 RID: 38115 RVA: 0x00167938 File Offset: 0x00165B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x0016793B File Offset: 0x00165B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendDeleteResponse.Descriptor;
			}
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x00167942 File Offset: 0x00165B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse()
		{
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x0016794A File Offset: 0x00165B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse(FriendDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x0016796F File Offset: 0x00165B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendDeleteResponse Clone()
		{
			return new FriendDeleteResponse(this);
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x00167977 File Offset: 0x00165B77
		// (set) Token: 0x060094E9 RID: 38121 RVA: 0x0016797F File Offset: 0x00165B7F
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

		// Token: 0x060094EA RID: 38122 RVA: 0x00167988 File Offset: 0x00165B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendDeleteResponse);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x00167996 File Offset: 0x00165B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x001679C4 File Offset: 0x00165BC4
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

		// Token: 0x060094ED RID: 38125 RVA: 0x00167A09 File Offset: 0x00165C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x00167A16 File Offset: 0x00165C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x00167A1F File Offset: 0x00165C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x00167A54 File Offset: 0x00165C54
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

		// Token: 0x060094F1 RID: 38129 RVA: 0x00167A92 File Offset: 0x00165C92
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

		// Token: 0x060094F2 RID: 38130 RVA: 0x00167AC3 File Offset: 0x00165CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00167ACC File Offset: 0x00165CCC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400473F RID: 18239
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004740 RID: 18240
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004741 RID: 18241
		private ErrorCode errorCode_;
	}
}
