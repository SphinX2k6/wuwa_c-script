using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000721 RID: 1825
	public sealed class GuessJokerLevelInfoArray : IMessage<GuessJokerLevelInfoArray>, IMessage, IEquatable<GuessJokerLevelInfoArray>, IDeepCloneable<GuessJokerLevelInfoArray>, IBufferMessage
	{
		// Token: 0x0600A5DE RID: 42462 RVA: 0x0019030A File Offset: 0x0018E50A
		[NullableContext(1)]
		public static GuessJokerLevelInfoArray Create()
		{
			return new GuessJokerLevelInfoArray();
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x0600A5DF RID: 42463 RVA: 0x00190311 File Offset: 0x0018E511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x00190314 File Offset: 0x0018E514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuessJokerLevelInfoArray.Descriptor;
			}
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x0019031B File Offset: 0x0018E51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray()
		{
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x0019032E File Offset: 0x0018E52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray(GuessJokerLevelInfoArray other) : this()
		{
			this.guessJokerLevelInfos_ = other.guessJokerLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x00190358 File Offset: 0x0018E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuessJokerLevelInfoArray Clone()
		{
			return new GuessJokerLevelInfoArray(this);
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x00190360 File Offset: 0x0018E560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GuessJokerLevelInfo> GuessJokerLevelInfos
		{
			get
			{
				return this.guessJokerLevelInfos_;
			}
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x00190368 File Offset: 0x0018E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuessJokerLevelInfoArray);
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x00190376 File Offset: 0x0018E576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuessJokerLevelInfoArray other)
		{
			return other != null && (other == this || (this.guessJokerLevelInfos_.Equals(other.guessJokerLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x001903AC File Offset: 0x0018E5AC
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

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x001903E0 File Offset: 0x0018E5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x001903ED File Offset: 0x0018E5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x001903F6 File Offset: 0x0018E5F6
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

		// Token: 0x0600A5EB RID: 42475 RVA: 0x00190420 File Offset: 0x0018E620
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

		// Token: 0x0600A5EC RID: 42476 RVA: 0x00190459 File Offset: 0x0018E659
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

		// Token: 0x0600A5ED RID: 42477 RVA: 0x00190487 File Offset: 0x0018E687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x00190490 File Offset: 0x0018E690
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

		// Token: 0x04004C39 RID: 19513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C3A RID: 19514
		public const int GuessJokerLevelInfosFieldNumber = 1;

		// Token: 0x04004C3B RID: 19515
		private static readonly FieldCodec<GuessJokerLevelInfo> _repeated_guessJokerLevelInfos_codec = FieldCodec.ForMessage<GuessJokerLevelInfo>(10U, GuessJokerLevelInfo.Parser);

		// Token: 0x04004C3C RID: 19516
		private readonly RepeatedField<GuessJokerLevelInfo> guessJokerLevelInfos_ = new RepeatedField<GuessJokerLevelInfo>();
	}
}
