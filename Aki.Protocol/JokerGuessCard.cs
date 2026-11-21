using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000856 RID: 2134
	public sealed class JokerGuessCard : IMessage<JokerGuessCard>, IMessage, IEquatable<JokerGuessCard>, IDeepCloneable<JokerGuessCard>, IBufferMessage
	{
		// Token: 0x0600BE83 RID: 48771 RVA: 0x001C4E6C File Offset: 0x001C306C
		[NullableContext(1)]
		public static JokerGuessCard Create()
		{
			return new JokerGuessCard();
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x0600BE84 RID: 48772 RVA: 0x001C4E73 File Offset: 0x001C3073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600BE85 RID: 48773 RVA: 0x001C4E76 File Offset: 0x001C3076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessCard.Descriptor;
			}
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x001C4E7D File Offset: 0x001C307D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard()
		{
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x001C4E90 File Offset: 0x001C3090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard(JokerGuessCard other) : this()
		{
			this.cardIds_ = other.cardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x001C4EBA File Offset: 0x001C30BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard Clone()
		{
			return new JokerGuessCard(this);
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600BE89 RID: 48777 RVA: 0x001C4EC2 File Offset: 0x001C30C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardIds
		{
			get
			{
				return this.cardIds_;
			}
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x001C4ECA File Offset: 0x001C30CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessCard);
		}

		// Token: 0x0600BE8B RID: 48779 RVA: 0x001C4ED8 File Offset: 0x001C30D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessCard other)
		{
			return other != null && (other == this || (this.cardIds_.Equals(other.cardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE8C RID: 48780 RVA: 0x001C4F0C File Offset: 0x001C310C
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

		// Token: 0x0600BE8D RID: 48781 RVA: 0x001C4F40 File Offset: 0x001C3140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x001C4F4D File Offset: 0x001C314D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x001C4F56 File Offset: 0x001C3156
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

		// Token: 0x0600BE90 RID: 48784 RVA: 0x001C4F80 File Offset: 0x001C3180
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

		// Token: 0x0600BE91 RID: 48785 RVA: 0x001C4FB9 File Offset: 0x001C31B9
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

		// Token: 0x0600BE92 RID: 48786 RVA: 0x001C4FE7 File Offset: 0x001C31E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x001C4FF0 File Offset: 0x001C31F0
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

		// Token: 0x04005367 RID: 21351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005368 RID: 21352
		public const int CardIdsFieldNumber = 1;

		// Token: 0x04005369 RID: 21353
		private static readonly FieldCodec<int> _repeated_cardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400536A RID: 21354
		private readonly RepeatedField<int> cardIds_ = new RepeatedField<int>();
	}
}
