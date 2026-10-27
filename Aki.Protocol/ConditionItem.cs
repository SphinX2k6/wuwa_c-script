using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CD RID: 717
	public sealed class ConditionItem : IMessage<ConditionItem>, IMessage, IEquatable<ConditionItem>, IDeepCloneable<ConditionItem>, IBufferMessage
	{
		// Token: 0x06004989 RID: 18825 RVA: 0x000B3EB9 File Offset: 0x000B20B9
		[NullableContext(1)]
		public static ConditionItem Create()
		{
			return new ConditionItem();
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600498A RID: 18826 RVA: 0x000B3EC0 File Offset: 0x000B20C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionItem> Parser
		{
			get
			{
				return ConditionItem._parser;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x000B3EC7 File Offset: 0x000B20C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600498C RID: 18828 RVA: 0x000B3ECA File Offset: 0x000B20CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionItem.Descriptor;
			}
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x000B3ED1 File Offset: 0x000B20D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem()
		{
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x000B3EE4 File Offset: 0x000B20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem(ConditionItem other) : this()
		{
			this.itemFinishMap_ = other.itemFinishMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x000B3F0E File Offset: 0x000B210E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem Clone()
		{
			return new ConditionItem(this);
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06004990 RID: 18832 RVA: 0x000B3F16 File Offset: 0x000B2116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ItemFinishList> ItemFinishMap
		{
			get
			{
				return this.itemFinishMap_;
			}
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x000B3F1E File Offset: 0x000B211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionItem);
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x000B3F2C File Offset: 0x000B212C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionItem other)
		{
			return other != null && (other == this || (this.ItemFinishMap.Equals(other.ItemFinishMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x000B3F60 File Offset: 0x000B2160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ItemFinishMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x000B3F94 File Offset: 0x000B2194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x000B3FA1 File Offset: 0x000B21A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000B3FAA File Offset: 0x000B21AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemFinishMap_.WriteTo(ref output, ConditionItem._map_itemFinishMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x000B3FD4 File Offset: 0x000B21D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemFinishMap_.CalculateSize(ConditionItem._map_itemFinishMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x000B400D File Offset: 0x000B220D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConditionItem other)
		{
			if (other == null)
			{
				return;
			}
			this.itemFinishMap_.MergeFrom(other.itemFinishMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x000B403B File Offset: 0x000B223B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x000B4044 File Offset: 0x000B2244
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
					this.itemFinishMap_.AddEntriesFrom(ref input, ConditionItem._map_itemFinishMap_codec);
				}
			}
		}

		// Token: 0x04003035 RID: 12341
		private static readonly MessageParser<ConditionItem> _parser = new MessageParser<ConditionItem>(() => new ConditionItem());

		// Token: 0x04003036 RID: 12342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003037 RID: 12343
		public const int ItemFinishMapFieldNumber = 1;

		// Token: 0x04003038 RID: 12344
		private static readonly MapField<int, ItemFinishList>.Codec _map_itemFinishMap_codec = new MapField<int, ItemFinishList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ItemFinishList>(18U, ItemFinishList.Parser), 10U);

		// Token: 0x04003039 RID: 12345
		private readonly MapField<int, ItemFinishList> itemFinishMap_ = new MapField<int, ItemFinishList>();
	}
}
