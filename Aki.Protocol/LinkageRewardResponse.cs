using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092A RID: 2346
	[NetMessage(EMessageId.LinkageRewardResponse)]
	public sealed class LinkageRewardResponse : IMessage<LinkageRewardResponse>, IMessage, IEquatable<LinkageRewardResponse>, IDeepCloneable<LinkageRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CEE5 RID: 52965 RVA: 0x001E7854 File Offset: 0x001E5A54
		[NullableContext(1)]
		public static LinkageRewardResponse Create()
		{
			return new LinkageRewardResponse();
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600CEE6 RID: 52966 RVA: 0x001E785B File Offset: 0x001E5A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600CEE7 RID: 52967 RVA: 0x001E785E File Offset: 0x001E5A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CEE8 RID: 52968 RVA: 0x001E7865 File Offset: 0x001E5A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse()
		{
		}

		// Token: 0x0600CEE9 RID: 52969 RVA: 0x001E786D File Offset: 0x001E5A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse(LinkageRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x001E7892 File Offset: 0x001E5A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse Clone()
		{
			return new LinkageRewardResponse(this);
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600CEEB RID: 52971 RVA: 0x001E789A File Offset: 0x001E5A9A
		// (set) Token: 0x0600CEEC RID: 52972 RVA: 0x001E78A2 File Offset: 0x001E5AA2
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

		// Token: 0x0600CEED RID: 52973 RVA: 0x001E78AB File Offset: 0x001E5AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageRewardResponse);
		}

		// Token: 0x0600CEEE RID: 52974 RVA: 0x001E78B9 File Offset: 0x001E5AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x001E78E8 File Offset: 0x001E5AE8
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

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x001E792D File Offset: 0x001E5B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x001E793A File Offset: 0x001E5B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x001E7943 File Offset: 0x001E5B43
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

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x001E7978 File Offset: 0x001E5B78
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

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x001E79B6 File Offset: 0x001E5BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageRewardResponse other)
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

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x001E79E7 File Offset: 0x001E5BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x001E79F0 File Offset: 0x001E5BF0
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

		// Token: 0x0400575F RID: 22367
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005760 RID: 22368
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005761 RID: 22369
		private ErrorCode errorCode_;
	}
}
