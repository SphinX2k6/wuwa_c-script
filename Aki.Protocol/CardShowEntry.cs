using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000239 RID: 569
	public sealed class CardShowEntry : IMessage<CardShowEntry>, IMessage, IEquatable<CardShowEntry>, IDeepCloneable<CardShowEntry>, IBufferMessage
	{
		// Token: 0x06003D5D RID: 15709 RVA: 0x00097F44 File Offset: 0x00096144
		[NullableContext(1)]
		public static CardShowEntry Create()
		{
			return new CardShowEntry();
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x00097F4B File Offset: 0x0009614B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CardShowEntry> Parser
		{
			get
			{
				return CardShowEntry._parser;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06003D5F RID: 15711 RVA: 0x00097F52 File Offset: 0x00096152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06003D60 RID: 15712 RVA: 0x00097F55 File Offset: 0x00096155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CardShowEntry.Descriptor;
			}
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00097F5C File Offset: 0x0009615C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry()
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00097F64 File Offset: 0x00096164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry(CardShowEntry other) : this()
		{
			this.cardId_ = other.cardId_;
			this.isRead_ = other.isRead_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00097F95 File Offset: 0x00096195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry Clone()
		{
			return new CardShowEntry(this);
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06003D64 RID: 15716 RVA: 0x00097F9D File Offset: 0x0009619D
		// (set) Token: 0x06003D65 RID: 15717 RVA: 0x00097FA5 File Offset: 0x000961A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00097FAE File Offset: 0x000961AE
		// (set) Token: 0x06003D67 RID: 15719 RVA: 0x00097FB6 File Offset: 0x000961B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRead
		{
			get
			{
				return this.isRead_;
			}
			set
			{
				this.isRead_ = value;
			}
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00097FBF File Offset: 0x000961BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CardShowEntry);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00097FCD File Offset: 0x000961CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CardShowEntry other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && this.IsRead == other.IsRead && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x0009800C File Offset: 0x0009620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this.IsRead)
			{
				num ^= this.IsRead.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00098064 File Offset: 0x00096264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00098071 File Offset: 0x00096271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x0009807C File Offset: 0x0009627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardId);
			}
			if (this.IsRead)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsRead);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x000980D4 File Offset: 0x000962D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.IsRead)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00098120 File Offset: 0x00096320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CardShowEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			if (other.IsRead)
			{
				this.IsRead = other.IsRead;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00098170 File Offset: 0x00096370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x0009817C File Offset: 0x0009637C
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsRead = input.ReadBool();
					}
				}
				else
				{
					this.CardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CA4 RID: 11428
		private static readonly MessageParser<CardShowEntry> _parser = new MessageParser<CardShowEntry>(() => new CardShowEntry());

		// Token: 0x04002CA5 RID: 11429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CA6 RID: 11430
		public const int CardIdFieldNumber = 1;

		// Token: 0x04002CA7 RID: 11431
		private int cardId_;

		// Token: 0x04002CA8 RID: 11432
		public const int IsReadFieldNumber = 2;

		// Token: 0x04002CA9 RID: 11433
		private bool isRead_;
	}
}
