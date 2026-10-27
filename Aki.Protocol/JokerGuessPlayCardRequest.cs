using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000870 RID: 2160
	[NetMessage(EMessageId.JokerGuessPlayCardRequest)]
	public sealed class JokerGuessPlayCardRequest : IMessage<JokerGuessPlayCardRequest>, IMessage, IEquatable<JokerGuessPlayCardRequest>, IDeepCloneable<JokerGuessPlayCardRequest>, IBufferMessage
	{
		// Token: 0x0600C06D RID: 49261 RVA: 0x001C93EA File Offset: 0x001C75EA
		[NullableContext(1)]
		public static JokerGuessPlayCardRequest Create()
		{
			return new JokerGuessPlayCardRequest();
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600C06E RID: 49262 RVA: 0x001C93F1 File Offset: 0x001C75F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0600C06F RID: 49263 RVA: 0x001C93F4 File Offset: 0x001C75F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardRequest.Descriptor;
			}
		}

		// Token: 0x0600C070 RID: 49264 RVA: 0x001C93FB File Offset: 0x001C75FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest()
		{
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x001C9403 File Offset: 0x001C7603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest(JokerGuessPlayCardRequest other) : this()
		{
			this.playCard_ = ((other.playCard_ != null) ? other.playCard_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x001C9438 File Offset: 0x001C7638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardRequest Clone()
		{
			return new JokerGuessPlayCardRequest(this);
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x0600C073 RID: 49267 RVA: 0x001C9440 File Offset: 0x001C7640
		// (set) Token: 0x0600C074 RID: 49268 RVA: 0x001C9448 File Offset: 0x001C7648
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

		// Token: 0x0600C075 RID: 49269 RVA: 0x001C9451 File Offset: 0x001C7651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardRequest);
		}

		// Token: 0x0600C076 RID: 49270 RVA: 0x001C945F File Offset: 0x001C765F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardRequest other)
		{
			return other != null && (other == this || (object.Equals(this.PlayCard, other.PlayCard) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C077 RID: 49271 RVA: 0x001C9494 File Offset: 0x001C7694
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

		// Token: 0x0600C078 RID: 49272 RVA: 0x001C94D0 File Offset: 0x001C76D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x001C94DD File Offset: 0x001C76DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C07A RID: 49274 RVA: 0x001C94E6 File Offset: 0x001C76E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playCard_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PlayCard);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C07B RID: 49275 RVA: 0x001C9518 File Offset: 0x001C7718
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

		// Token: 0x0600C07C RID: 49276 RVA: 0x001C9558 File Offset: 0x001C7758
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

		// Token: 0x0600C07D RID: 49277 RVA: 0x001C95AC File Offset: 0x001C77AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C07E RID: 49278 RVA: 0x001C95B8 File Offset: 0x001C77B8
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
				if (num != 26U)
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

		// Token: 0x0400539E RID: 21406
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400539F RID: 21407
		public const int PlayCardFieldNumber = 3;

		// Token: 0x040053A0 RID: 21408
		private JokerGuessCard playCard_;
	}
}
