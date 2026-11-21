using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000710 RID: 1808
	[NetMessage(EMessageId.GuideFinishResponse)]
	public sealed class GuideFinishResponse : IMessage<GuideFinishResponse>, IMessage, IEquatable<GuideFinishResponse>, IDeepCloneable<GuideFinishResponse>, IBufferMessage
	{
		// Token: 0x0600A4BE RID: 42174 RVA: 0x0018DE69 File Offset: 0x0018C069
		[NullableContext(1)]
		public static GuideFinishResponse Create()
		{
			return new GuideFinishResponse();
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x0600A4BF RID: 42175 RVA: 0x0018DE70 File Offset: 0x0018C070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600A4C0 RID: 42176 RVA: 0x0018DE73 File Offset: 0x0018C073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x0018DE7A File Offset: 0x0018C07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse()
		{
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0018DE8D File Offset: 0x0018C08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse(GuideFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0018DEC3 File Offset: 0x0018C0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideFinishResponse Clone()
		{
			return new GuideFinishResponse(this);
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600A4C4 RID: 42180 RVA: 0x0018DECB File Offset: 0x0018C0CB
		// (set) Token: 0x0600A4C5 RID: 42181 RVA: 0x0018DED3 File Offset: 0x0018C0D3
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

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600A4C6 RID: 42182 RVA: 0x0018DEDC File Offset: 0x0018C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x0018DEE4 File Offset: 0x0018C0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideFinishResponse);
		}

		// Token: 0x0600A4C8 RID: 42184 RVA: 0x0018DEF4 File Offset: 0x0018C0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4C9 RID: 42185 RVA: 0x0018DF44 File Offset: 0x0018C144
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

		// Token: 0x0600A4CA RID: 42186 RVA: 0x0018DF97 File Offset: 0x0018C197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4CB RID: 42187 RVA: 0x0018DFA4 File Offset: 0x0018C1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x0018DFB0 File Offset: 0x0018C1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, GuideFinishResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x0018E000 File Offset: 0x0018C200
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

		// Token: 0x0600A4CE RID: 42190 RVA: 0x0018E054 File Offset: 0x0018C254
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

		// Token: 0x0600A4CF RID: 42191 RVA: 0x0018E0A1 File Offset: 0x0018C2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x0018E0AC File Offset: 0x0018C2AC
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
				if (num != 10U)
				{
					if (num != 48U)
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
					this.errorParams_.AddEntriesFrom(ref input, GuideFinishResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x04004C3C RID: 19516
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C3D RID: 19517
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004C3E RID: 19518
		private ErrorCode errorCode_;

		// Token: 0x04004C3F RID: 19519
		public const int ErrorParamsFieldNumber = 1;

		// Token: 0x04004C40 RID: 19520
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(10U);

		// Token: 0x04004C41 RID: 19521
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
