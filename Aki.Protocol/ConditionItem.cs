using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D4 RID: 724
	public sealed class ConditionItem : IMessage<ConditionItem>, IMessage, IEquatable<ConditionItem>, IDeepCloneable<ConditionItem>, IBufferMessage
	{
		// Token: 0x06004A62 RID: 19042 RVA: 0x000B62A1 File Offset: 0x000B44A1
		[NullableContext(1)]
		public static ConditionItem Create()
		{
			return new ConditionItem();
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x000B62A8 File Offset: 0x000B44A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ConditionItem> Parser
		{
			get
			{
				return ConditionItem._parser;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x000B62AF File Offset: 0x000B44AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x000B62B2 File Offset: 0x000B44B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConditionItem.Descriptor;
			}
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x000B62B9 File Offset: 0x000B44B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem()
		{
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x000B62CC File Offset: 0x000B44CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem(ConditionItem other) : this()
		{
			this.itemFinishMap_ = other.itemFinishMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x000B62F6 File Offset: 0x000B44F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionItem Clone()
		{
			return new ConditionItem(this);
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06004A69 RID: 19049 RVA: 0x000B62FE File Offset: 0x000B44FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, ItemFinishList> ItemFinishMap
		{
			get
			{
				return this.itemFinishMap_;
			}
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x000B6306 File Offset: 0x000B4506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConditionItem);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x000B6314 File Offset: 0x000B4514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConditionItem other)
		{
			return other != null && (other == this || (this.ItemFinishMap.Equals(other.ItemFinishMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x000B6348 File Offset: 0x000B4548
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

		// Token: 0x06004A6D RID: 19053 RVA: 0x000B637C File Offset: 0x000B457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x000B6389 File Offset: 0x000B4589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x000B6392 File Offset: 0x000B4592
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

		// Token: 0x06004A70 RID: 19056 RVA: 0x000B63BC File Offset: 0x000B45BC
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

		// Token: 0x06004A71 RID: 19057 RVA: 0x000B63F5 File Offset: 0x000B45F5
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

		// Token: 0x06004A72 RID: 19058 RVA: 0x000B6423 File Offset: 0x000B4623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x000B642C File Offset: 0x000B462C
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

		// Token: 0x040030CC RID: 12492
		private static readonly MessageParser<ConditionItem> _parser = new MessageParser<ConditionItem>(() => new ConditionItem());

		// Token: 0x040030CD RID: 12493
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030CE RID: 12494
		public const int ItemFinishMapFieldNumber = 1;

		// Token: 0x040030CF RID: 12495
		private static readonly MapField<int, ItemFinishList>.Codec _map_itemFinishMap_codec = new MapField<int, ItemFinishList>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<ItemFinishList>(18U, ItemFinishList.Parser), 10U);

		// Token: 0x040030D0 RID: 12496
		private readonly MapField<int, ItemFinishList> itemFinishMap_ = new MapField<int, ItemFinishList>();
	}
}
