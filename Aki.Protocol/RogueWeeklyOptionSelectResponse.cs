using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001041 RID: 4161
	[NetMessage(EMessageId.RogueWeeklyOptionSelectResponse)]
	public sealed class RogueWeeklyOptionSelectResponse : IMessage<RogueWeeklyOptionSelectResponse>, IMessage, IEquatable<RogueWeeklyOptionSelectResponse>, IDeepCloneable<RogueWeeklyOptionSelectResponse>, IBufferMessage
	{
		// Token: 0x060163C3 RID: 91075 RVA: 0x0033AED0 File Offset: 0x003390D0
		[NullableContext(1)]
		public static RogueWeeklyOptionSelectResponse Create()
		{
			return new RogueWeeklyOptionSelectResponse();
		}

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x060163C4 RID: 91076 RVA: 0x0033AED7 File Offset: 0x003390D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x060163C5 RID: 91077 RVA: 0x0033AEDA File Offset: 0x003390DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOptionSelectResponse.Descriptor;
			}
		}

		// Token: 0x060163C6 RID: 91078 RVA: 0x0033AEE1 File Offset: 0x003390E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse()
		{
		}

		// Token: 0x060163C7 RID: 91079 RVA: 0x0033AEF4 File Offset: 0x003390F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse(RogueWeeklyOptionSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163C8 RID: 91080 RVA: 0x0033AF2A File Offset: 0x0033912A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOptionSelectResponse Clone()
		{
			return new RogueWeeklyOptionSelectResponse(this);
		}

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x060163C9 RID: 91081 RVA: 0x0033AF32 File Offset: 0x00339132
		// (set) Token: 0x060163CA RID: 91082 RVA: 0x0033AF3A File Offset: 0x0033913A
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

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x060163CB RID: 91083 RVA: 0x0033AF43 File Offset: 0x00339143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x060163CC RID: 91084 RVA: 0x0033AF4B File Offset: 0x0033914B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOptionSelectResponse);
		}

		// Token: 0x060163CD RID: 91085 RVA: 0x0033AF5C File Offset: 0x0033915C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOptionSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163CE RID: 91086 RVA: 0x0033AFAC File Offset: 0x003391AC
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

		// Token: 0x060163CF RID: 91087 RVA: 0x0033AFFF File Offset: 0x003391FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163D0 RID: 91088 RVA: 0x0033B00C File Offset: 0x0033920C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163D1 RID: 91089 RVA: 0x0033B018 File Offset: 0x00339218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, RogueWeeklyOptionSelectResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060163D2 RID: 91090 RVA: 0x0033B068 File Offset: 0x00339268
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

		// Token: 0x060163D3 RID: 91091 RVA: 0x0033B0BC File Offset: 0x003392BC
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

		// Token: 0x060163D4 RID: 91092 RVA: 0x0033B109 File Offset: 0x00339309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163D5 RID: 91093 RVA: 0x0033B114 File Offset: 0x00339314
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
				if (num != 34U)
				{
					if (num != 96U)
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

		// Token: 0x04008507 RID: 34055
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008508 RID: 34056
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04008509 RID: 34057
		private ErrorCode errorCode_;

		// Token: 0x0400850A RID: 34058
		public const int ErrorParamsFieldNumber = 4;

		// Token: 0x0400850B RID: 34059
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(34U);

		// Token: 0x0400850C RID: 34060
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
