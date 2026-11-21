using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082E RID: 2094
	[NetMessage(EMessageId.InviteRechallengeResponse)]
	public sealed class InviteRechallengeResponse : IMessage<InviteRechallengeResponse>, IMessage, IEquatable<InviteRechallengeResponse>, IDeepCloneable<InviteRechallengeResponse>, IBufferMessage
	{
		// Token: 0x0600BB64 RID: 47972 RVA: 0x001BE6FA File Offset: 0x001BC8FA
		[NullableContext(1)]
		public static InviteRechallengeResponse Create()
		{
			return new InviteRechallengeResponse();
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x0600BB65 RID: 47973 RVA: 0x001BE701 File Offset: 0x001BC901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x001BE704 File Offset: 0x001BC904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InviteRechallengeResponse.Descriptor;
			}
		}

		// Token: 0x0600BB67 RID: 47975 RVA: 0x001BE70B File Offset: 0x001BC90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse()
		{
		}

		// Token: 0x0600BB68 RID: 47976 RVA: 0x001BE713 File Offset: 0x001BC913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse(InviteRechallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x001BE738 File Offset: 0x001BC938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InviteRechallengeResponse Clone()
		{
			return new InviteRechallengeResponse(this);
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x001BE740 File Offset: 0x001BC940
		// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x001BE748 File Offset: 0x001BC948
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

		// Token: 0x0600BB6C RID: 47980 RVA: 0x001BE751 File Offset: 0x001BC951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InviteRechallengeResponse);
		}

		// Token: 0x0600BB6D RID: 47981 RVA: 0x001BE75F File Offset: 0x001BC95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InviteRechallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x001BE790 File Offset: 0x001BC990
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

		// Token: 0x0600BB6F RID: 47983 RVA: 0x001BE7D5 File Offset: 0x001BC9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB70 RID: 47984 RVA: 0x001BE7E2 File Offset: 0x001BC9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x001BE7EB File Offset: 0x001BC9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x001BE820 File Offset: 0x001BCA20
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

		// Token: 0x0600BB73 RID: 47987 RVA: 0x001BE85E File Offset: 0x001BCA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InviteRechallengeResponse other)
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

		// Token: 0x0600BB74 RID: 47988 RVA: 0x001BE88F File Offset: 0x001BCA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x001BE898 File Offset: 0x001BCA98
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005293 RID: 21139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005294 RID: 21140
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005295 RID: 21141
		private ErrorCode errorCode_;
	}
}
