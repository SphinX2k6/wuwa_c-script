using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000724 RID: 1828
	[NetMessage(EMessageId.GuideFinishResponse)]
	public sealed class GuideFinishResponse : IMessage<GuideFinishResponse>, IMessage, IEquatable<GuideFinishResponse>, IDeepCloneable<GuideFinishResponse>, IBufferMessage
	{
		// Token: 0x0600A614 RID: 42516 RVA: 0x0019089D File Offset: 0x0018EA9D
		[NullableContext(1)]
		public static GuideFinishResponse Create()
		{
			return new GuideFinishResponse();
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x001908A4 File Offset: 0x0018EAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x0600A616 RID: 42518 RVA: 0x001908A7 File Offset: 0x0018EAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x001908AE File Offset: 0x0018EAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse()
		{
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x001908C1 File Offset: 0x0018EAC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse(GuideFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x001908F7 File Offset: 0x0018EAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse Clone()
		{
			return new GuideFinishResponse(this);
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x0600A61A RID: 42522 RVA: 0x001908FF File Offset: 0x0018EAFF
		// (set) Token: 0x0600A61B RID: 42523 RVA: 0x00190907 File Offset: 0x0018EB07
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

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600A61C RID: 42524 RVA: 0x00190910 File Offset: 0x0018EB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x00190918 File Offset: 0x0018EB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideFinishResponse);
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x00190928 File Offset: 0x0018EB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00190978 File Offset: 0x0018EB78
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

		// Token: 0x0600A620 RID: 42528 RVA: 0x001909CB File Offset: 0x0018EBCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x001909D8 File Offset: 0x0018EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x001909E4 File Offset: 0x0018EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, GuideFinishResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x00190A34 File Offset: 0x0018EC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(GuideFinishResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x00190A88 File Offset: 0x0018EC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideFinishResponse other)
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

		// Token: 0x0600A625 RID: 42533 RVA: 0x00190AD5 File Offset: 0x0018ECD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x00190AE0 File Offset: 0x0018ECE0
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
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, GuideFinishResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004C43 RID: 19523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C44 RID: 19524
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004C45 RID: 19525
		private ErrorCode errorCode_;

		// Token: 0x04004C46 RID: 19526
		public const int ErrorParamsFieldNumber = 4;

		// Token: 0x04004C47 RID: 19527
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(34U);

		// Token: 0x04004C48 RID: 19528
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
