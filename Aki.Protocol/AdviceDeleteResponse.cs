using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CB RID: 203
	[NetMessage(EMessageId.AdviceDeleteResponse)]
	public sealed class AdviceDeleteResponse : IMessage<AdviceDeleteResponse>, IMessage, IEquatable<AdviceDeleteResponse>, IDeepCloneable<AdviceDeleteResponse>, IBufferMessage
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x00056979 File Offset: 0x00054B79
		[NullableContext(1)]
		public static AdviceDeleteResponse Create()
		{
			return new AdviceDeleteResponse();
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00056980 File Offset: 0x00054B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00056983 File Offset: 0x00054B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceDeleteResponse.Descriptor;
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0005698A File Offset: 0x00054B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse()
		{
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00056992 File Offset: 0x00054B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse(AdviceDeleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000569B7 File Offset: 0x00054BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteResponse Clone()
		{
			return new AdviceDeleteResponse(this);
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000569BF File Offset: 0x00054BBF
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x000569C7 File Offset: 0x00054BC7
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

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000569D0 File Offset: 0x00054BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceDeleteResponse);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000569DE File Offset: 0x00054BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceDeleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00056A0C File Offset: 0x00054C0C
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

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00056A51 File Offset: 0x00054C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00056A5E File Offset: 0x00054C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00056A67 File Offset: 0x00054C67
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

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00056A9C File Offset: 0x00054C9C
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

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00056ADA File Offset: 0x00054CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceDeleteResponse other)
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

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00056B0B File Offset: 0x00054D0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00056B14 File Offset: 0x00054D14
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

		// Token: 0x04002426 RID: 9254
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002427 RID: 9255
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04002428 RID: 9256
		private ErrorCode errorCode_;
	}
}
