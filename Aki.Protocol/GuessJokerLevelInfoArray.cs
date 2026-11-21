using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070D RID: 1805
	public sealed class GuessJokerLevelInfoArray : IMessage<GuessJokerLevelInfoArray>, IMessage, IEquatable<GuessJokerLevelInfoArray>, IDeepCloneable<GuessJokerLevelInfoArray>, IBufferMessage
	{
		// Token: 0x0600A488 RID: 42120 RVA: 0x0018D8D6 File Offset: 0x0018BAD6
		[NullableContext(1)]
		public static GuessJokerLevelInfoArray Create()
		{
			return new GuessJokerLevelInfoArray();
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x0018D8DD File Offset: 0x0018BADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x0018D8E0 File Offset: 0x0018BAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuessJokerLevelInfoArray.Descriptor;
			}
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x0018D8E7 File Offset: 0x0018BAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray()
		{
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x0018D8FA File Offset: 0x0018BAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray(GuessJokerLevelInfoArray other) : this()
		{
			this.guessJokerLevelInfos_ = other.guessJokerLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x0018D924 File Offset: 0x0018BB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray Clone()
		{
			return new GuessJokerLevelInfoArray(this);
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600A48E RID: 42126 RVA: 0x0018D92C File Offset: 0x0018BB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuessJokerLevelInfo> GuessJokerLevelInfos
		{
			get
			{
				return this.guessJokerLevelInfos_;
			}
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x0018D934 File Offset: 0x0018BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuessJokerLevelInfoArray);
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x0018D942 File Offset: 0x0018BB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuessJokerLevelInfoArray other)
		{
			return other != null && (other == this || (this.guessJokerLevelInfos_.Equals(other.guessJokerLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x0018D978 File Offset: 0x0018BB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.guessJokerLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x0018D9AC File Offset: 0x0018BBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x0018D9B9 File Offset: 0x0018BBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x0018D9C2 File Offset: 0x0018BBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.guessJokerLevelInfos_.WriteTo(ref output, GuessJokerLevelInfoArray._repeated_guessJokerLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x0018D9EC File Offset: 0x0018BBEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.guessJokerLevelInfos_.CalculateSize(GuessJokerLevelInfoArray._repeated_guessJokerLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x0018DA25 File Offset: 0x0018BC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuessJokerLevelInfoArray other)
		{
			if (other == null)
			{
				return;
			}
			this.guessJokerLevelInfos_.Add(other.guessJokerLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x0018DA53 File Offset: 0x0018BC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x0018DA5C File Offset: 0x0018BC5C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.guessJokerLevelInfos_.AddEntriesFrom(ref input, GuessJokerLevelInfoArray._repeated_guessJokerLevelInfos_codec);
				}
			}
		}

		// Token: 0x04004C32 RID: 19506
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C33 RID: 19507
		public const int GuessJokerLevelInfosFieldNumber = 1;

		// Token: 0x04004C34 RID: 19508
		private static readonly FieldCodec<GuessJokerLevelInfo> _repeated_guessJokerLevelInfos_codec = FieldCodec.ForMessage<GuessJokerLevelInfo>(10U, GuessJokerLevelInfo.Parser);

		// Token: 0x04004C35 RID: 19509
		private readonly RepeatedField<GuessJokerLevelInfo> guessJokerLevelInfos_ = new RepeatedField<GuessJokerLevelInfo>();
	}
}
