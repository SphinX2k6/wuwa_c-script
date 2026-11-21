using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CD RID: 205
	[NetMessage(EMessageId.AdviceModifyResponse)]
	public sealed class AdviceModifyResponse : IMessage<AdviceModifyResponse>, IMessage, IEquatable<AdviceModifyResponse>, IDeepCloneable<AdviceModifyResponse>, IBufferMessage
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x00056E04 File Offset: 0x00055004
		[NullableContext(1)]
		public static AdviceModifyResponse Create()
		{
			return new AdviceModifyResponse();
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00056E0B File Offset: 0x0005500B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00056E0E File Offset: 0x0005500E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceModifyResponse.Descriptor;
			}
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00056E15 File Offset: 0x00055015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse()
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00056E1D File Offset: 0x0005501D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse(AdviceModifyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00056E42 File Offset: 0x00055042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceModifyResponse Clone()
		{
			return new AdviceModifyResponse(this);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00056E4A File Offset: 0x0005504A
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00056E52 File Offset: 0x00055052
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

		// Token: 0x06002006 RID: 8198 RVA: 0x00056E5B File Offset: 0x0005505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceModifyResponse);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00056E69 File Offset: 0x00055069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceModifyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00056E98 File Offset: 0x00055098
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

		// Token: 0x06002009 RID: 8201 RVA: 0x00056EDD File Offset: 0x000550DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x00056EEA File Offset: 0x000550EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00056EF3 File Offset: 0x000550F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00056F28 File Offset: 0x00055128
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

		// Token: 0x0600200D RID: 8205 RVA: 0x00056F66 File Offset: 0x00055166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceModifyResponse other)
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

		// Token: 0x0600200E RID: 8206 RVA: 0x00056F97 File Offset: 0x00055197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00056FA0 File Offset: 0x000551A0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400242F RID: 9263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002430 RID: 9264
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002431 RID: 9265
		private ErrorCode errorCode_;
	}
}
