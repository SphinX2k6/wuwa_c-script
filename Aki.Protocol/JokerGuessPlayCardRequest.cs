using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085F RID: 2143
	[NetMessage(EMessageId.JokerGuessPlayCardRequest)]
	public sealed class JokerGuessPlayCardRequest : IMessage<JokerGuessPlayCardRequest>, IMessage, IEquatable<JokerGuessPlayCardRequest>, IDeepCloneable<JokerGuessPlayCardRequest>, IBufferMessage
	{
		// Token: 0x0600BF51 RID: 48977 RVA: 0x001C7102 File Offset: 0x001C5302
		[NullableContext(1)]
		public static JokerGuessPlayCardRequest Create()
		{
			return new JokerGuessPlayCardRequest();
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x001C7109 File Offset: 0x001C5309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x001C710C File Offset: 0x001C530C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardRequest.Descriptor;
			}
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x001C7113 File Offset: 0x001C5313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest()
		{
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x001C711B File Offset: 0x001C531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest(JokerGuessPlayCardRequest other) : this()
		{
			this.playCard_ = ((other.playCard_ != null) ? other.playCard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF56 RID: 48982 RVA: 0x001C7150 File Offset: 0x001C5350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest Clone()
		{
			return new JokerGuessPlayCardRequest(this);
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x001C7158 File Offset: 0x001C5358
		// (set) Token: 0x0600BF58 RID: 48984 RVA: 0x001C7160 File Offset: 0x001C5360
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

		// Token: 0x0600BF59 RID: 48985 RVA: 0x001C7169 File Offset: 0x001C5369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardRequest);
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x001C7177 File Offset: 0x001C5377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PlayCard, other.PlayCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x001C71AC File Offset: 0x001C53AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600BF5C RID: 48988 RVA: 0x001C71E8 File Offset: 0x001C53E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x001C71F5 File Offset: 0x001C53F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF5E RID: 48990 RVA: 0x001C71FE File Offset: 0x001C53FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playCard_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PlayCard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF5F RID: 48991 RVA: 0x001C7230 File Offset: 0x001C5430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600BF60 RID: 48992 RVA: 0x001C7270 File Offset: 0x001C5470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessPlayCardRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600BF61 RID: 48993 RVA: 0x001C72C4 File Offset: 0x001C54C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF62 RID: 48994 RVA: 0x001C72D0 File Offset: 0x001C54D0
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
				if (num != 74U)
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
		}

		// Token: 0x040053A5 RID: 21413
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053A6 RID: 21414
		public const int PlayCardFieldNumber = 9;

		// Token: 0x040053A7 RID: 21415
		private JokerGuessCard playCard_;
	}
}
