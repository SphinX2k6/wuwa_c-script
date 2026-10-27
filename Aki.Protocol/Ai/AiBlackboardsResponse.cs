using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016A9 RID: 5801
	[NetMessage(EMessageId.AiBlackboardsResponse)]
	public sealed class AiBlackboardsResponse : IMessage<AiBlackboardsResponse>, IMessage, IEquatable<AiBlackboardsResponse>, IDeepCloneable<AiBlackboardsResponse>, IBufferMessage
	{
		// Token: 0x0601D113 RID: 119059 RVA: 0x00441099 File Offset: 0x0043F299
		[NullableContext(1)]
		public static AiBlackboardsResponse Create()
		{
			return new AiBlackboardsResponse();
		}

		// Token: 0x170062A0 RID: 25248
		// (get) Token: 0x0601D114 RID: 119060 RVA: 0x004410A0 File Offset: 0x0043F2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A1 RID: 25249
		// (get) Token: 0x0601D115 RID: 119061 RVA: 0x004410A3 File Offset: 0x0043F2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardsResponse.Descriptor;
			}
		}

		// Token: 0x0601D116 RID: 119062 RVA: 0x004410AA File Offset: 0x0043F2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse()
		{
		}

		// Token: 0x0601D117 RID: 119063 RVA: 0x004410B2 File Offset: 0x0043F2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse(AiBlackboardsResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D118 RID: 119064 RVA: 0x004410D7 File Offset: 0x0043F2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardsResponse Clone()
		{
			return new AiBlackboardsResponse(this);
		}

		// Token: 0x170062A2 RID: 25250
		// (get) Token: 0x0601D119 RID: 119065 RVA: 0x004410DF File Offset: 0x0043F2DF
		// (set) Token: 0x0601D11A RID: 119066 RVA: 0x004410E7 File Offset: 0x0043F2E7
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

		// Token: 0x0601D11B RID: 119067 RVA: 0x004410F0 File Offset: 0x0043F2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardsResponse);
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x004410FE File Offset: 0x0043F2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardsResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D11D RID: 119069 RVA: 0x0044112C File Offset: 0x0043F32C
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

		// Token: 0x0601D11E RID: 119070 RVA: 0x00441171 File Offset: 0x0043F371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D11F RID: 119071 RVA: 0x0044117E File Offset: 0x0043F37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D120 RID: 119072 RVA: 0x00441187 File Offset: 0x0043F387
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

		// Token: 0x0601D121 RID: 119073 RVA: 0x004411BC File Offset: 0x0043F3BC
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

		// Token: 0x0601D122 RID: 119074 RVA: 0x004411FA File Offset: 0x0043F3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardsResponse other)
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

		// Token: 0x0601D123 RID: 119075 RVA: 0x0044122B File Offset: 0x0043F42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D124 RID: 119076 RVA: 0x00441234 File Offset: 0x0043F434
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

		// Token: 0x0400C425 RID: 50213
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C426 RID: 50214
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400C427 RID: 50215
		private ErrorCode errorCode_;
	}
}
