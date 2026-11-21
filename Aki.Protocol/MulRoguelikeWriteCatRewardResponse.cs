using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD6 RID: 2774
	[NetMessage(EMessageId.MulRoguelikeWriteCatRewardResponse)]
	public sealed class MulRoguelikeWriteCatRewardResponse : IMessage<MulRoguelikeWriteCatRewardResponse>, IMessage, IEquatable<MulRoguelikeWriteCatRewardResponse>, IDeepCloneable<MulRoguelikeWriteCatRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F19F RID: 61855 RVA: 0x00234C4F File Offset: 0x00232E4F
		[NullableContext(1)]
		public static MulRoguelikeWriteCatRewardResponse Create()
		{
			return new MulRoguelikeWriteCatRewardResponse();
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600F1A0 RID: 61856 RVA: 0x00234C56 File Offset: 0x00232E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x00234C59 File Offset: 0x00232E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRoguelikeWriteCatRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F1A2 RID: 61858 RVA: 0x00234C60 File Offset: 0x00232E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse()
		{
		}

		// Token: 0x0600F1A3 RID: 61859 RVA: 0x00234C73 File Offset: 0x00232E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse(MulRoguelikeWriteCatRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1A4 RID: 61860 RVA: 0x00234CA9 File Offset: 0x00232EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardResponse Clone()
		{
			return new MulRoguelikeWriteCatRewardResponse(this);
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600F1A5 RID: 61861 RVA: 0x00234CB1 File Offset: 0x00232EB1
		// (set) Token: 0x0600F1A6 RID: 61862 RVA: 0x00234CB9 File Offset: 0x00232EB9
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

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600F1A7 RID: 61863 RVA: 0x00234CC2 File Offset: 0x00232EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x0600F1A8 RID: 61864 RVA: 0x00234CCA File Offset: 0x00232ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRoguelikeWriteCatRewardResponse);
		}

		// Token: 0x0600F1A9 RID: 61865 RVA: 0x00234CD8 File Offset: 0x00232ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRoguelikeWriteCatRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1AA RID: 61866 RVA: 0x00234D28 File Offset: 0x00232F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.index_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x00234D7B File Offset: 0x00232F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1AC RID: 61868 RVA: 0x00234D88 File Offset: 0x00232F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1AD RID: 61869 RVA: 0x00234D94 File Offset: 0x00232F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.index_.WriteTo(ref output, MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1AE RID: 61870 RVA: 0x00234DE4 File Offset: 0x00232FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.index_.CalculateSize(MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1AF RID: 61871 RVA: 0x00234E38 File Offset: 0x00233038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRoguelikeWriteCatRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.index_.Add(other.index_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x00234E85 File Offset: 0x00233085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x00234E90 File Offset: 0x00233090
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
				if (num != 24U && num != 26U)
				{
					if (num != 88U)
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
					this.index_.AddEntriesFrom(ref input, MulRoguelikeWriteCatRewardResponse._repeated_index_codec);
				}
			}
		}

		// Token: 0x040061EB RID: 25067
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061EC RID: 25068
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040061ED RID: 25069
		private ErrorCode errorCode_;

		// Token: 0x040061EE RID: 25070
		public const int IndexFieldNumber = 3;

		// Token: 0x040061EF RID: 25071
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040061F0 RID: 25072
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
