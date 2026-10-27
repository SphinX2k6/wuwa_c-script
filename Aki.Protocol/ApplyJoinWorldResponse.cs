using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000107 RID: 263
	[NetMessage(EMessageId.ApplyJoinWorldResponse)]
	public sealed class ApplyJoinWorldResponse : IMessage<ApplyJoinWorldResponse>, IMessage, IEquatable<ApplyJoinWorldResponse>, IDeepCloneable<ApplyJoinWorldResponse>, IBufferMessage
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x000628F3 File Offset: 0x00060AF3
		[NullableContext(1)]
		public static ApplyJoinWorldResponse Create()
		{
			return new ApplyJoinWorldResponse();
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x000628FA File Offset: 0x00060AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000628FD File Offset: 0x00060AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldResponse.Descriptor;
			}
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00062904 File Offset: 0x00060B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse()
		{
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00062917 File Offset: 0x00060B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse(ApplyJoinWorldResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x0006294D File Offset: 0x00060B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldResponse Clone()
		{
			return new ApplyJoinWorldResponse(this);
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00062955 File Offset: 0x00060B55
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0006295D File Offset: 0x00060B5D
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x00062966 File Offset: 0x00060B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0006296E File Offset: 0x00060B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldResponse);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0006297C File Offset: 0x00060B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000629CC File Offset: 0x00060BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00062A1F File Offset: 0x00060C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00062A2C File Offset: 0x00060C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00062A38 File Offset: 0x00060C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, ApplyJoinWorldResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00062A88 File Offset: 0x00060C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(ApplyJoinWorldResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00062ADC File Offset: 0x00060CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyJoinWorldResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00062B29 File Offset: 0x00060D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00062B34 File Offset: 0x00060D34
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
				if (num != 64U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, ApplyJoinWorldResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002597 RID: 9623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002598 RID: 9624
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04002599 RID: 9625
		private ErrorCode errorCode_;

		// Token: 0x0400259A RID: 9626
		public const int ErrorParamsFieldNumber = 15;

		// Token: 0x0400259B RID: 9627
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(122U);

		// Token: 0x0400259C RID: 9628
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
