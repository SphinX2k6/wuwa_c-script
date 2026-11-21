using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000836 RID: 2102
	public sealed class ItemDict : IMessage<ItemDict>, IMessage, IEquatable<ItemDict>, IDeepCloneable<ItemDict>, IBufferMessage
	{
		// Token: 0x0600BC00 RID: 48128 RVA: 0x001BFA0E File Offset: 0x001BDC0E
		[NullableContext(1)]
		public static ItemDict Create()
		{
			return new ItemDict();
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x001BFA15 File Offset: 0x001BDC15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemDict> Parser
		{
			get
			{
				return ItemDict._parser;
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600BC02 RID: 48130 RVA: 0x001BFA1C File Offset: 0x001BDC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x0600BC03 RID: 48131 RVA: 0x001BFA1F File Offset: 0x001BDC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDict.Descriptor;
			}
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x001BFA26 File Offset: 0x001BDC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict()
		{
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x001BFA39 File Offset: 0x001BDC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict(ItemDict other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x001BFA63 File Offset: 0x001BDC63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict Clone()
		{
			return new ItemDict(this);
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x001BFA6B File Offset: 0x001BDC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemEntry> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x001BFA73 File Offset: 0x001BDC73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDict);
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x001BFA81 File Offset: 0x001BDC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDict other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x001BFAB4 File Offset: 0x001BDCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x001BFAE8 File Offset: 0x001BDCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x001BFAF5 File Offset: 0x001BDCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x001BFAFE File Offset: 0x001BDCFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, ItemDict._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x001BFB28 File Offset: 0x001BDD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(ItemDict._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x001BFB61 File Offset: 0x001BDD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDict other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x001BFB8F File Offset: 0x001BDD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x001BFB98 File Offset: 0x001BDD98
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, ItemDict._repeated_items_codec);
				}
			}
		}

		// Token: 0x040052B9 RID: 21177
		private static readonly MessageParser<ItemDict> _parser = new MessageParser<ItemDict>(() => new ItemDict());

		// Token: 0x040052BA RID: 21178
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052BB RID: 21179
		public const int ItemsFieldNumber = 1;

		// Token: 0x040052BC RID: 21180
		private static readonly FieldCodec<ItemEntry> _repeated_items_codec = FieldCodec.ForMessage<ItemEntry>(10U, ItemEntry.Parser);

		// Token: 0x040052BD RID: 21181
		private readonly RepeatedField<ItemEntry> items_ = new RepeatedField<ItemEntry>();
	}
}
