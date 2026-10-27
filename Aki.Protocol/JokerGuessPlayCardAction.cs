using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086F RID: 2159
	public sealed class JokerGuessPlayCardAction : IMessage<JokerGuessPlayCardAction>, IMessage, IEquatable<JokerGuessPlayCardAction>, IDeepCloneable<JokerGuessPlayCardAction>, IBufferMessage
	{
		// Token: 0x0600C059 RID: 49241 RVA: 0x001C90FA File Offset: 0x001C72FA
		[NullableContext(1)]
		public static JokerGuessPlayCardAction Create()
		{
			return new JokerGuessPlayCardAction();
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x0600C05A RID: 49242 RVA: 0x001C9101 File Offset: 0x001C7301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600C05B RID: 49243 RVA: 0x001C9104 File Offset: 0x001C7304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardAction.Descriptor;
			}
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x001C910B File Offset: 0x001C730B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction()
		{
		}

		// Token: 0x0600C05D RID: 49245 RVA: 0x001C9114 File Offset: 0x001C7314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction(JokerGuessPlayCardAction other) : this()
		{
			this.playActor_ = other.playActor_;
			this.playCard_ = ((other.playCard_ != null) ? other.playCard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C05E RID: 49246 RVA: 0x001C9160 File Offset: 0x001C7360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction Clone()
		{
			return new JokerGuessPlayCardAction(this);
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600C05F RID: 49247 RVA: 0x001C9168 File Offset: 0x001C7368
		// (set) Token: 0x0600C060 RID: 49248 RVA: 0x001C9170 File Offset: 0x001C7370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessActor PlayActor
		{
			get
			{
				return this.playActor_;
			}
			set
			{
				this.playActor_ = value;
			}
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x0600C061 RID: 49249 RVA: 0x001C9179 File Offset: 0x001C7379
		// (set) Token: 0x0600C062 RID: 49250 RVA: 0x001C9181 File Offset: 0x001C7381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessCard PlayCard
		{
			get
			{
				return this.playCard_;
			}
			set
			{
				this.playCard_ = value;
			}
		}

		// Token: 0x0600C063 RID: 49251 RVA: 0x001C918A File Offset: 0x001C738A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardAction);
		}

		// Token: 0x0600C064 RID: 49252 RVA: 0x001C9198 File Offset: 0x001C7398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardAction other)
		{
			return other != null && (other == this || (this.PlayActor == other.PlayActor && object.Equals(this.PlayCard, other.PlayCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C065 RID: 49253 RVA: 0x001C91E8 File Offset: 0x001C73E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayActor != JokerGuessActor.Who)
			{
				num ^= this.PlayActor.GetHashCode();
			}
			if (this.playCard_ != null)
			{
				num ^= this.PlayCard.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C066 RID: 49254 RVA: 0x001C9243 File Offset: 0x001C7443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x001C9250 File Offset: 0x001C7450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x001C925C File Offset: 0x001C745C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayActor != JokerGuessActor.Who)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.PlayActor);
			}
			if (this.playCard_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PlayCard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x001C92B4 File Offset: 0x001C74B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayActor != JokerGuessActor.Who)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PlayActor);
			}
			if (this.playCard_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayCard);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x001C930C File Offset: 0x001C750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessPlayCardAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayActor != JokerGuessActor.Who)
			{
				this.PlayActor = other.PlayActor;
			}
			if (other.playCard_ != null)
			{
				if (this.playCard_ == null)
				{
					this.PlayCard = new JokerGuessCard();
				}
				this.PlayCard.MergeFrom(other.PlayCard);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x001C9374 File Offset: 0x001C7574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x001C9380 File Offset: 0x001C7580
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.playCard_ == null)
						{
							this.PlayCard = new JokerGuessCard();
						}
						input.ReadMessage(this.PlayCard);
					}
				}
				else
				{
					this.PlayActor = (JokerGuessActor)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005399 RID: 21401
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400539A RID: 21402
		public const int PlayActorFieldNumber = 1;

		// Token: 0x0400539B RID: 21403
		private JokerGuessActor playActor_;

		// Token: 0x0400539C RID: 21404
		public const int PlayCardFieldNumber = 2;

		// Token: 0x0400539D RID: 21405
		private JokerGuessCard playCard_;
	}
}
