using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C9 RID: 201
	[NetMessage(EMessageId.AdviceCreateResponse)]
	public sealed class AdviceCreateResponse : IMessage<AdviceCreateResponse>, IMessage, IEquatable<AdviceCreateResponse>, IDeepCloneable<AdviceCreateResponse>, IBufferMessage
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x000564A8 File Offset: 0x000546A8
		[NullableContext(1)]
		public static AdviceCreateResponse Create()
		{
			return new AdviceCreateResponse();
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x000564AF File Offset: 0x000546AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000564B2 File Offset: 0x000546B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceCreateResponse.Descriptor;
			}
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x000564B9 File Offset: 0x000546B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse()
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000564C4 File Offset: 0x000546C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse(AdviceCreateResponse other) : this()
		{
			this.advice_ = ((other.advice_ != null) ? other.advice_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00056510 File Offset: 0x00054710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse Clone()
		{
			return new AdviceCreateResponse(this);
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00056518 File Offset: 0x00054718
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x00056520 File Offset: 0x00054720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbAdvice Advice
		{
			get
			{
				return this.advice_;
			}
			set
			{
				this.advice_ = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00056529 File Offset: 0x00054729
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00056531 File Offset: 0x00054731
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

		// Token: 0x06001FBC RID: 8124 RVA: 0x0005653A File Offset: 0x0005473A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceCreateResponse);
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x00056548 File Offset: 0x00054748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceCreateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Advice, other.Advice) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00056598 File Offset: 0x00054798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.advice_ != null)
			{
				num ^= this.Advice.GetHashCode();
			}
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

		// Token: 0x06001FBF RID: 8127 RVA: 0x000565F3 File Offset: 0x000547F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00056600 File Offset: 0x00054800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0005660C File Offset: 0x0005480C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.advice_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Advice);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00056668 File Offset: 0x00054868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.advice_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Advice);
			}
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

		// Token: 0x06001FC3 RID: 8131 RVA: 0x000566C0 File Offset: 0x000548C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceCreateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.advice_ != null)
			{
				if (this.advice_ == null)
				{
					this.Advice = new PbAdvice();
				}
				this.Advice.MergeFrom(other.Advice);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00056728 File Offset: 0x00054928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00056734 File Offset: 0x00054934
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
				if (num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.advice_ == null)
					{
						this.Advice = new PbAdvice();
					}
					input.ReadMessage(this.Advice);
				}
			}
		}

		// Token: 0x0400241E RID: 9246
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400241F RID: 9247
		public const int AdviceFieldNumber = 2;

		// Token: 0x04002420 RID: 9248
		private PbAdvice advice_;

		// Token: 0x04002421 RID: 9249
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002422 RID: 9250
		private ErrorCode errorCode_;
	}
}
