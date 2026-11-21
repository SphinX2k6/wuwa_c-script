using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085E RID: 2142
	public sealed class JokerGuessPlayCardAction : IMessage<JokerGuessPlayCardAction>, IMessage, IEquatable<JokerGuessPlayCardAction>, IDeepCloneable<JokerGuessPlayCardAction>, IBufferMessage
	{
		// Token: 0x0600BF3D RID: 48957 RVA: 0x001C6E12 File Offset: 0x001C5012
		[NullableContext(1)]
		public static JokerGuessPlayCardAction Create()
		{
			return new JokerGuessPlayCardAction();
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x0600BF3E RID: 48958 RVA: 0x001C6E19 File Offset: 0x001C5019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x0600BF3F RID: 48959 RVA: 0x001C6E1C File Offset: 0x001C501C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardAction.Descriptor;
			}
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x001C6E23 File Offset: 0x001C5023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction()
		{
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x001C6E2C File Offset: 0x001C502C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction(JokerGuessPlayCardAction other) : this()
		{
			this.playActor_ = other.playActor_;
			this.playCard_ = ((other.playCard_ != null) ? other.playCard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x001C6E78 File Offset: 0x001C5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardAction Clone()
		{
			return new JokerGuessPlayCardAction(this);
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x001C6E80 File Offset: 0x001C5080
		// (set) Token: 0x0600BF44 RID: 48964 RVA: 0x001C6E88 File Offset: 0x001C5088
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

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x001C6E91 File Offset: 0x001C5091
		// (set) Token: 0x0600BF46 RID: 48966 RVA: 0x001C6E99 File Offset: 0x001C5099
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

		// Token: 0x0600BF47 RID: 48967 RVA: 0x001C6EA2 File Offset: 0x001C50A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardAction);
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x001C6EB0 File Offset: 0x001C50B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardAction other)
		{
			return other != null && (other == this || (this.PlayActor == other.PlayActor && object.Equals(this.PlayCard, other.PlayCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x001C6F00 File Offset: 0x001C5100
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

		// Token: 0x0600BF4A RID: 48970 RVA: 0x001C6F5B File Offset: 0x001C515B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x001C6F68 File Offset: 0x001C5168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x001C6F74 File Offset: 0x001C5174
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

		// Token: 0x0600BF4D RID: 48973 RVA: 0x001C6FCC File Offset: 0x001C51CC
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

		// Token: 0x0600BF4E RID: 48974 RVA: 0x001C7024 File Offset: 0x001C5224
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

		// Token: 0x0600BF4F RID: 48975 RVA: 0x001C708C File Offset: 0x001C528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x001C7098 File Offset: 0x001C5298
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

		// Token: 0x040053A0 RID: 21408
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053A1 RID: 21409
		public const int PlayActorFieldNumber = 1;

		// Token: 0x040053A2 RID: 21410
		private JokerGuessActor playActor_;

		// Token: 0x040053A3 RID: 21411
		public const int PlayCardFieldNumber = 2;

		// Token: 0x040053A4 RID: 21412
		private JokerGuessCard playCard_;
	}
}
