using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085C RID: 2140
	public sealed class JokerGuessInitGame : IMessage<JokerGuessInitGame>, IMessage, IEquatable<JokerGuessInitGame>, IDeepCloneable<JokerGuessInitGame>, IBufferMessage
	{
		// Token: 0x0600BEFD RID: 48893 RVA: 0x001C5EB7 File Offset: 0x001C40B7
		[NullableContext(1)]
		public static JokerGuessInitGame Create()
		{
			return new JokerGuessInitGame();
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x001C5EBE File Offset: 0x001C40BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x0600BEFF RID: 48895 RVA: 0x001C5EC1 File Offset: 0x001C40C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessInitGame.Descriptor;
			}
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x001C5EC8 File Offset: 0x001C40C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame()
		{
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x001C5ED0 File Offset: 0x001C40D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame(JokerGuessInitGame other) : this()
		{
			this.aiHandCards_ = ((other.aiHandCards_ != null) ? other.aiHandCards_.Clone() : null);
			this.playerHandCards_ = ((other.playerHandCards_ != null) ? other.playerHandCards_.Clone() : null);
			this.firstActor_ = other.firstActor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x001C5F38 File Offset: 0x001C4138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame Clone()
		{
			return new JokerGuessInitGame(this);
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x0600BF03 RID: 48899 RVA: 0x001C5F40 File Offset: 0x001C4140
		// (set) Token: 0x0600BF04 RID: 48900 RVA: 0x001C5F48 File Offset: 0x001C4148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard AiHandCards
		{
			get
			{
				return this.aiHandCards_;
			}
			set
			{
				this.aiHandCards_ = value;
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600BF05 RID: 48901 RVA: 0x001C5F51 File Offset: 0x001C4151
		// (set) Token: 0x0600BF06 RID: 48902 RVA: 0x001C5F59 File Offset: 0x001C4159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard PlayerHandCards
		{
			get
			{
				return this.playerHandCards_;
			}
			set
			{
				this.playerHandCards_ = value;
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600BF07 RID: 48903 RVA: 0x001C5F62 File Offset: 0x001C4162
		// (set) Token: 0x0600BF08 RID: 48904 RVA: 0x001C5F6A File Offset: 0x001C416A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor FirstActor
		{
			get
			{
				return this.firstActor_;
			}
			set
			{
				this.firstActor_ = value;
			}
		}

		// Token: 0x0600BF09 RID: 48905 RVA: 0x001C5F73 File Offset: 0x001C4173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessInitGame);
		}

		// Token: 0x0600BF0A RID: 48906 RVA: 0x001C5F84 File Offset: 0x001C4184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessInitGame other)
		{
			return other != null && (other == this || (object.Equals(this.AiHandCards, other.AiHandCards) && object.Equals(this.PlayerHandCards, other.PlayerHandCards) && this.FirstActor == other.FirstActor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x001C5FE8 File Offset: 0x001C41E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aiHandCards_ != null)
			{
				num ^= this.AiHandCards.GetHashCode();
			}
			if (this.playerHandCards_ != null)
			{
				num ^= this.PlayerHandCards.GetHashCode();
			}
			if (this.FirstActor != JokerGuessActor.Who)
			{
				num ^= this.FirstActor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x001C6059 File Offset: 0x001C4259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x001C6066 File Offset: 0x001C4266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x001C6070 File Offset: 0x001C4270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aiHandCards_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AiHandCards);
			}
			if (this.playerHandCards_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PlayerHandCards);
			}
			if (this.FirstActor != JokerGuessActor.Who)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.FirstActor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x001C60E8 File Offset: 0x001C42E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aiHandCards_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AiHandCards);
			}
			if (this.playerHandCards_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerHandCards);
			}
			if (this.FirstActor != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FirstActor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x001C6158 File Offset: 0x001C4358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessInitGame other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aiHandCards_ != null)
			{
				if (this.aiHandCards_ == null)
				{
					this.AiHandCards = new JokerGuessCard();
				}
				this.AiHandCards.MergeFrom(other.AiHandCards);
			}
			if (other.playerHandCards_ != null)
			{
				if (this.playerHandCards_ == null)
				{
					this.PlayerHandCards = new JokerGuessCard();
				}
				this.PlayerHandCards.MergeFrom(other.PlayerHandCards);
			}
			if (other.FirstActor != JokerGuessActor.Who)
			{
				this.FirstActor = other.FirstActor;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x001C61EC File Offset: 0x001C43EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x001C61F8 File Offset: 0x001C43F8
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FirstActor = (JokerGuessActor)input.ReadEnum();
						}
					}
					else
					{
						if (this.playerHandCards_ == null)
						{
							this.PlayerHandCards = new JokerGuessCard();
						}
						input.ReadMessage(this.PlayerHandCards);
					}
				}
				else
				{
					if (this.aiHandCards_ == null)
					{
						this.AiHandCards = new JokerGuessCard();
					}
					input.ReadMessage(this.AiHandCards);
				}
			}
		}

		// Token: 0x04005389 RID: 21385
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400538A RID: 21386
		public const int AiHandCardsFieldNumber = 1;

		// Token: 0x0400538B RID: 21387
		private JokerGuessCard aiHandCards_;

		// Token: 0x0400538C RID: 21388
		public const int PlayerHandCardsFieldNumber = 2;

		// Token: 0x0400538D RID: 21389
		private JokerGuessCard playerHandCards_;

		// Token: 0x0400538E RID: 21390
		public const int FirstActorFieldNumber = 3;

		// Token: 0x0400538F RID: 21391
		private JokerGuessActor firstActor_;
	}
}
