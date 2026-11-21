using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000715 RID: 1813
	[NetMessage(EMessageId.GuideTriggerResponse)]
	public sealed class GuideTriggerResponse : IMessage<GuideTriggerResponse>, IMessage, IEquatable<GuideTriggerResponse>, IDeepCloneable<GuideTriggerResponse>, IBufferMessage
	{
		// Token: 0x0600A518 RID: 42264 RVA: 0x0018E7ED File Offset: 0x0018C9ED
		[NullableContext(1)]
		public static GuideTriggerResponse Create()
		{
			return new GuideTriggerResponse();
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600A519 RID: 42265 RVA: 0x0018E7F4 File Offset: 0x0018C9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x0600A51A RID: 42266 RVA: 0x0018E7F7 File Offset: 0x0018C9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideTriggerResponse.Descriptor;
			}
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x0018E7FE File Offset: 0x0018C9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse()
		{
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x0018E811 File Offset: 0x0018CA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse(GuideTriggerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x0018E847 File Offset: 0x0018CA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse Clone()
		{
			return new GuideTriggerResponse(this);
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x0600A51E RID: 42270 RVA: 0x0018E84F File Offset: 0x0018CA4F
		// (set) Token: 0x0600A51F RID: 42271 RVA: 0x0018E857 File Offset: 0x0018CA57
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

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x0600A520 RID: 42272 RVA: 0x0018E860 File Offset: 0x0018CA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x0018E868 File Offset: 0x0018CA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideTriggerResponse);
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x0018E878 File Offset: 0x0018CA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideTriggerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x0018E8C8 File Offset: 0x0018CAC8
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

		// Token: 0x0600A524 RID: 42276 RVA: 0x0018E91B File Offset: 0x0018CB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x0018E928 File Offset: 0x0018CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x0018E934 File Offset: 0x0018CB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, GuideTriggerResponse._repeated_errorParams_codec);
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

		// Token: 0x0600A527 RID: 42279 RVA: 0x0018E984 File Offset: 0x0018CB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(GuideTriggerResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x0018E9D8 File Offset: 0x0018CBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideTriggerResponse other)
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

		// Token: 0x0600A529 RID: 42281 RVA: 0x0018EA25 File Offset: 0x0018CC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x0018EA30 File Offset: 0x0018CC30
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
				if (num != 42U)
				{
					if (num != 80U)
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
					this.errorParams_.AddEntriesFrom(ref input, GuideTriggerResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x04004C4E RID: 19534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C4F RID: 19535
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004C50 RID: 19536
		private ErrorCode errorCode_;

		// Token: 0x04004C51 RID: 19537
		public const int ErrorParamsFieldNumber = 5;

		// Token: 0x04004C52 RID: 19538
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(42U);

		// Token: 0x04004C53 RID: 19539
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
