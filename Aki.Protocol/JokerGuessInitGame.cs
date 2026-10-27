using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086D RID: 2157
	public sealed class JokerGuessInitGame : IMessage<JokerGuessInitGame>, IMessage, IEquatable<JokerGuessInitGame>, IDeepCloneable<JokerGuessInitGame>, IBufferMessage
	{
		// Token: 0x0600C019 RID: 49177 RVA: 0x001C819F File Offset: 0x001C639F
		[NullableContext(1)]
		public static JokerGuessInitGame Create()
		{
			return new JokerGuessInitGame();
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x0600C01A RID: 49178 RVA: 0x001C81A6 File Offset: 0x001C63A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600C01B RID: 49179 RVA: 0x001C81A9 File Offset: 0x001C63A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessInitGame.Descriptor;
			}
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x001C81B0 File Offset: 0x001C63B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame()
		{
		}

		// Token: 0x0600C01D RID: 49181 RVA: 0x001C81B8 File Offset: 0x001C63B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame(JokerGuessInitGame other) : this()
		{
			this.aiHandCards_ = ((other.aiHandCards_ != null) ? other.aiHandCards_.Clone() : null);
			this.playerHandCards_ = ((other.playerHandCards_ != null) ? other.playerHandCards_.Clone() : null);
			this.firstActor_ = other.firstActor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C01E RID: 49182 RVA: 0x001C8220 File Offset: 0x001C6420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame Clone()
		{
			return new JokerGuessInitGame(this);
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x0600C01F RID: 49183 RVA: 0x001C8228 File Offset: 0x001C6428
		// (set) Token: 0x0600C020 RID: 49184 RVA: 0x001C8230 File Offset: 0x001C6430
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

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600C021 RID: 49185 RVA: 0x001C8239 File Offset: 0x001C6439
		// (set) Token: 0x0600C022 RID: 49186 RVA: 0x001C8241 File Offset: 0x001C6441
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

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600C023 RID: 49187 RVA: 0x001C824A File Offset: 0x001C644A
		// (set) Token: 0x0600C024 RID: 49188 RVA: 0x001C8252 File Offset: 0x001C6452
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

		// Token: 0x0600C025 RID: 49189 RVA: 0x001C825B File Offset: 0x001C645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessInitGame);
		}

		// Token: 0x0600C026 RID: 49190 RVA: 0x001C826C File Offset: 0x001C646C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessInitGame other)
		{
			return other != null && (other == this || (object.Equals(this.AiHandCards, other.AiHandCards) && object.Equals(this.PlayerHandCards, other.PlayerHandCards) && this.FirstActor == other.FirstActor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x001C82D0 File Offset: 0x001C64D0
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

		// Token: 0x0600C028 RID: 49192 RVA: 0x001C8341 File Offset: 0x001C6541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C029 RID: 49193 RVA: 0x001C834E File Offset: 0x001C654E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x001C8358 File Offset: 0x001C6558
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

		// Token: 0x0600C02B RID: 49195 RVA: 0x001C83D0 File Offset: 0x001C65D0
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

		// Token: 0x0600C02C RID: 49196 RVA: 0x001C8440 File Offset: 0x001C6640
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

		// Token: 0x0600C02D RID: 49197 RVA: 0x001C84D4 File Offset: 0x001C66D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x001C84E0 File Offset: 0x001C66E0
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

		// Token: 0x04005382 RID: 21378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005383 RID: 21379
		public const int AiHandCardsFieldNumber = 1;

		// Token: 0x04005384 RID: 21380
		private JokerGuessCard aiHandCards_;

		// Token: 0x04005385 RID: 21381
		public const int PlayerHandCardsFieldNumber = 2;

		// Token: 0x04005386 RID: 21382
		private JokerGuessCard playerHandCards_;

		// Token: 0x04005387 RID: 21383
		public const int FirstActorFieldNumber = 3;

		// Token: 0x04005388 RID: 21384
		private JokerGuessActor firstActor_;
	}
}
