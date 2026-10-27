using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000C8 RID: 200
	[NetMessage(EMessageId.AdviceCreateResponse)]
	public sealed class AdviceCreateResponse : IMessage<AdviceCreateResponse>, IMessage, IEquatable<AdviceCreateResponse>, IDeepCloneable<AdviceCreateResponse>, IBufferMessage
	{
		// Token: 0x06001F69 RID: 8041 RVA: 0x000557F4 File Offset: 0x000539F4
		[NullableContext(1)]
		public static AdviceCreateResponse Create()
		{
			return new AdviceCreateResponse();
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x000557FB File Offset: 0x000539FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x000557FE File Offset: 0x000539FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceCreateResponse.Descriptor;
			}
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00055805 File Offset: 0x00053A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse()
		{
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00055810 File Offset: 0x00053A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse(AdviceCreateResponse other) : this()
		{
			this.advice_ = ((other.advice_ != null) ? other.advice_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0005585C File Offset: 0x00053A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceCreateResponse Clone()
		{
			return new AdviceCreateResponse(this);
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x00055864 File Offset: 0x00053A64
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0005586C File Offset: 0x00053A6C
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00055875 File Offset: 0x00053A75
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0005587D File Offset: 0x00053A7D
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

		// Token: 0x06001F73 RID: 8051 RVA: 0x00055886 File Offset: 0x00053A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceCreateResponse);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00055894 File Offset: 0x00053A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceCreateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Advice, other.Advice) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000558E4 File Offset: 0x00053AE4
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

		// Token: 0x06001F76 RID: 8054 RVA: 0x0005593F File Offset: 0x00053B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0005594C File Offset: 0x00053B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00055958 File Offset: 0x00053B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.advice_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Advice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x000559B4 File Offset: 0x00053BB4
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

		// Token: 0x06001F7A RID: 8058 RVA: 0x00055A0C File Offset: 0x00053C0C
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

		// Token: 0x06001F7B RID: 8059 RVA: 0x00055A74 File Offset: 0x00053C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00055A80 File Offset: 0x00053C80
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040023BB RID: 9147
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023BC RID: 9148
		public const int AdviceFieldNumber = 13;

		// Token: 0x040023BD RID: 9149
		private PbAdvice advice_;

		// Token: 0x040023BE RID: 9150
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040023BF RID: 9151
		private ErrorCode errorCode_;
	}
}
