using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000867 RID: 2151
	public sealed class JokerGuessCard : IMessage<JokerGuessCard>, IMessage, IEquatable<JokerGuessCard>, IDeepCloneable<JokerGuessCard>, IBufferMessage
	{
		// Token: 0x0600BF9F RID: 49055 RVA: 0x001C7154 File Offset: 0x001C5354
		[NullableContext(1)]
		public static JokerGuessCard Create()
		{
			return new JokerGuessCard();
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x0600BFA0 RID: 49056 RVA: 0x001C715B File Offset: 0x001C535B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x0600BFA1 RID: 49057 RVA: 0x001C715E File Offset: 0x001C535E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessCard.Descriptor;
			}
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x001C7165 File Offset: 0x001C5365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard()
		{
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x001C7178 File Offset: 0x001C5378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard(JokerGuessCard other) : this()
		{
			this.cardIds_ = other.cardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x001C71A2 File Offset: 0x001C53A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard Clone()
		{
			return new JokerGuessCard(this);
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600BFA5 RID: 49061 RVA: 0x001C71AA File Offset: 0x001C53AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x001C71B2 File Offset: 0x001C53B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessCard);
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x001C71C0 File Offset: 0x001C53C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessCard other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x001C71F4 File Offset: 0x001C53F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x001C7228 File Offset: 0x001C5428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x001C7235 File Offset: 0x001C5435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x001C723E File Offset: 0x001C543E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardIds_.WriteTo(ref output, JokerGuessCard._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x001C7268 File Offset: 0x001C5468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardIds_.CalculateSize(JokerGuessCard._repeated_cardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x001C72A1 File Offset: 0x001C54A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessCard other)
		{
			if (other == null)
			{
				return;
			}
			this.cardIds_.Add(other.cardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x001C72CF File Offset: 0x001C54CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x001C72D8 File Offset: 0x001C54D8
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cardIds_.AddEntriesFrom(ref input, JokerGuessCard._repeated_cardIds_codec);
				}
			}
		}

		// Token: 0x04005360 RID: 21344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005361 RID: 21345
		public const int CardIdsFieldNumber = 1;

		// Token: 0x04005362 RID: 21346
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005363 RID: 21347
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();
	}
}
