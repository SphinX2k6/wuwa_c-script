using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001031 RID: 4145
	[NetMessage(EMessageId.RogueWeeklyOptionSelectResponse)]
	public sealed class RogueWeeklyOptionSelectResponse : IMessage<RogueWeeklyOptionSelectResponse>, IMessage, IEquatable<RogueWeeklyOptionSelectResponse>, IDeepCloneable<RogueWeeklyOptionSelectResponse>, IBufferMessage
	{
		// Token: 0x060162DE RID: 90846 RVA: 0x00339800 File Offset: 0x00337A00
		[NullableContext(1)]
		public static RogueWeeklyOptionSelectResponse Create()
		{
			return new RogueWeeklyOptionSelectResponse();
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x060162DF RID: 90847 RVA: 0x00339807 File Offset: 0x00337A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x060162E0 RID: 90848 RVA: 0x0033980A File Offset: 0x00337A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOptionSelectResponse.Descriptor;
			}
		}

		// Token: 0x060162E1 RID: 90849 RVA: 0x00339811 File Offset: 0x00337A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse()
		{
		}

		// Token: 0x060162E2 RID: 90850 RVA: 0x00339824 File Offset: 0x00337A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse(RogueWeeklyOptionSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162E3 RID: 90851 RVA: 0x0033985A File Offset: 0x00337A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse Clone()
		{
			return new RogueWeeklyOptionSelectResponse(this);
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x060162E4 RID: 90852 RVA: 0x00339862 File Offset: 0x00337A62
		// (set) Token: 0x060162E5 RID: 90853 RVA: 0x0033986A File Offset: 0x00337A6A
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

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x060162E6 RID: 90854 RVA: 0x00339873 File Offset: 0x00337A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x060162E7 RID: 90855 RVA: 0x0033987B File Offset: 0x00337A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOptionSelectResponse);
		}

		// Token: 0x060162E8 RID: 90856 RVA: 0x0033988C File Offset: 0x00337A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOptionSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162E9 RID: 90857 RVA: 0x003398DC File Offset: 0x00337ADC
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

		// Token: 0x060162EA RID: 90858 RVA: 0x0033992F File Offset: 0x00337B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162EB RID: 90859 RVA: 0x0033993C File Offset: 0x00337B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162EC RID: 90860 RVA: 0x00339948 File Offset: 0x00337B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, RogueWeeklyOptionSelectResponse._repeated_errorParams_codec);
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

		// Token: 0x060162ED RID: 90861 RVA: 0x00339998 File Offset: 0x00337B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(RogueWeeklyOptionSelectResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162EE RID: 90862 RVA: 0x003399EC File Offset: 0x00337BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyOptionSelectResponse other)
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

		// Token: 0x060162EF RID: 90863 RVA: 0x00339A39 File Offset: 0x00337C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162F0 RID: 90864 RVA: 0x00339A44 File Offset: 0x00337C44
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
				if (num != 106U)
				{
					if (num != 112U)
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
					this.errorParams_.AddEntriesFrom(ref input, RogueWeeklyOptionSelectResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x04008531 RID: 34097
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008532 RID: 34098
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008533 RID: 34099
		private ErrorCode errorCode_;

		// Token: 0x04008534 RID: 34100
		public const int ErrorParamsFieldNumber = 13;

		// Token: 0x04008535 RID: 34101
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(106U);

		// Token: 0x04008536 RID: 34102
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
