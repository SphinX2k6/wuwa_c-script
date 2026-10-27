using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000848 RID: 2120
	public sealed class ItemDict : IMessage<ItemDict>, IMessage, IEquatable<ItemDict>, IDeepCloneable<ItemDict>, IBufferMessage
	{
		// Token: 0x0600BD2E RID: 48430 RVA: 0x001C1EDD File Offset: 0x001C00DD
		[NullableContext(1)]
		public static ItemDict Create()
		{
			return new ItemDict();
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x0600BD2F RID: 48431 RVA: 0x001C1EE4 File Offset: 0x001C00E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemDict> Parser
		{
			get
			{
				return ItemDict._parser;
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600BD30 RID: 48432 RVA: 0x001C1EEB File Offset: 0x001C00EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600BD31 RID: 48433 RVA: 0x001C1EEE File Offset: 0x001C00EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDict.Descriptor;
			}
		}

		// Token: 0x0600BD32 RID: 48434 RVA: 0x001C1EF5 File Offset: 0x001C00F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict()
		{
		}

		// Token: 0x0600BD33 RID: 48435 RVA: 0x001C1F08 File Offset: 0x001C0108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict(ItemDict other) : this()
		{
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x001C1F32 File Offset: 0x001C0132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDict Clone()
		{
			return new ItemDict(this);
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0600BD35 RID: 48437 RVA: 0x001C1F3A File Offset: 0x001C013A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemEntry> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x001C1F42 File Offset: 0x001C0142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDict);
		}

		// Token: 0x0600BD37 RID: 48439 RVA: 0x001C1F50 File Offset: 0x001C0150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDict other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x001C1F84 File Offset: 0x001C0184
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

		// Token: 0x0600BD39 RID: 48441 RVA: 0x001C1FB8 File Offset: 0x001C01B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD3A RID: 48442 RVA: 0x001C1FC5 File Offset: 0x001C01C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD3B RID: 48443 RVA: 0x001C1FCE File Offset: 0x001C01CE
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

		// Token: 0x0600BD3C RID: 48444 RVA: 0x001C1FF8 File Offset: 0x001C01F8
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

		// Token: 0x0600BD3D RID: 48445 RVA: 0x001C2031 File Offset: 0x001C0231
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

		// Token: 0x0600BD3E RID: 48446 RVA: 0x001C205F File Offset: 0x001C025F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD3F RID: 48447 RVA: 0x001C2068 File Offset: 0x001C0268
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

		// Token: 0x040052B6 RID: 21174
		private static readonly MessageParser<ItemDict> _parser = new MessageParser<ItemDict>(() => new ItemDict());

		// Token: 0x040052B7 RID: 21175
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052B8 RID: 21176
		public const int ItemsFieldNumber = 1;

		// Token: 0x040052B9 RID: 21177
		private static readonly FieldCodec<ItemEntry> _repeated_items_codec = FieldCodec.ForMessage<ItemEntry>(10U, ItemEntry.Parser);

		// Token: 0x040052BA RID: 21178
		private readonly RepeatedField<ItemEntry> items_ = new RepeatedField<ItemEntry>();
	}
}
