using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023E RID: 574
	public sealed class CardShowEntry : IMessage<CardShowEntry>, IMessage, IEquatable<CardShowEntry>, IDeepCloneable<CardShowEntry>, IBufferMessage
	{
		// Token: 0x06003E02 RID: 15874 RVA: 0x00099B60 File Offset: 0x00097D60
		[NullableContext(1)]
		public static CardShowEntry Create()
		{
			return new CardShowEntry();
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x00099B67 File Offset: 0x00097D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CardShowEntry> Parser
		{
			get
			{
				return CardShowEntry._parser;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06003E04 RID: 15876 RVA: 0x00099B6E File Offset: 0x00097D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x00099B71 File Offset: 0x00097D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CardShowEntry.Descriptor;
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00099B78 File Offset: 0x00097D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry()
		{
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x00099B80 File Offset: 0x00097D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry(CardShowEntry other) : this()
		{
			this.cardId_ = other.cardId_;
			this.isRead_ = other.isRead_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x00099BB1 File Offset: 0x00097DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CardShowEntry Clone()
		{
			return new CardShowEntry(this);
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06003E09 RID: 15881 RVA: 0x00099BB9 File Offset: 0x00097DB9
		// (set) Token: 0x06003E0A RID: 15882 RVA: 0x00099BC1 File Offset: 0x00097DC1
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06003E0B RID: 15883 RVA: 0x00099BCA File Offset: 0x00097DCA
		// (set) Token: 0x06003E0C RID: 15884 RVA: 0x00099BD2 File Offset: 0x00097DD2
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

		// Token: 0x06003E0D RID: 15885 RVA: 0x00099BDB File Offset: 0x00097DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CardShowEntry);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x00099BE9 File Offset: 0x00097DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CardShowEntry other)
		{
			return other != null && (other == this || (this.CardId == other.CardId && this.IsRead == other.IsRead && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x00099C28 File Offset: 0x00097E28
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

		// Token: 0x06003E10 RID: 15888 RVA: 0x00099C80 File Offset: 0x00097E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x00099C8D File Offset: 0x00097E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x00099C98 File Offset: 0x00097E98
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

		// Token: 0x06003E13 RID: 15891 RVA: 0x00099CF0 File Offset: 0x00097EF0
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

		// Token: 0x06003E14 RID: 15892 RVA: 0x00099D3C File Offset: 0x00097F3C
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

		// Token: 0x06003E15 RID: 15893 RVA: 0x00099D8C File Offset: 0x00097F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x00099D98 File Offset: 0x00097F98
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

		// Token: 0x04002D26 RID: 11558
		private static readonly MessageParser<CardShowEntry> _parser = new MessageParser<CardShowEntry>(() => new CardShowEntry());

		// Token: 0x04002D27 RID: 11559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D28 RID: 11560
		public const int CardIdFieldNumber = 1;

		// Token: 0x04002D29 RID: 11561
		private int cardId_;

		// Token: 0x04002D2A RID: 11562
		public const int IsReadFieldNumber = 2;

		// Token: 0x04002D2B RID: 11563
		private bool isRead_;
	}
}
