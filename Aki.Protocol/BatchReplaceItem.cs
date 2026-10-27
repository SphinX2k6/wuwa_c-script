using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015F RID: 351
	public sealed class BatchReplaceItem : IMessage<BatchReplaceItem>, IMessage, IEquatable<BatchReplaceItem>, IDeepCloneable<BatchReplaceItem>, IBufferMessage
	{
		// Token: 0x06002C06 RID: 11270 RVA: 0x00072C41 File Offset: 0x00070E41
		[NullableContext(1)]
		public static BatchReplaceItem Create()
		{
			return new BatchReplaceItem();
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x00072C48 File Offset: 0x00070E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchReplaceItem> Parser
		{
			get
			{
				return BatchReplaceItem._parser;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002C08 RID: 11272 RVA: 0x00072C4F File Offset: 0x00070E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x00072C52 File Offset: 0x00070E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchReplaceItem.Descriptor;
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x00072C59 File Offset: 0x00070E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem()
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00072C6C File Offset: 0x00070E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem(BatchReplaceItem other) : this()
		{
			this.targetReplaceItemId_ = other.targetReplaceItemId_;
			this.targetNum_ = other.targetNum_;
			this.consumeItems_ = other.consumeItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00072CB9 File Offset: 0x00070EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem Clone()
		{
			return new BatchReplaceItem(this);
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x00072CC1 File Offset: 0x00070EC1
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x00072CC9 File Offset: 0x00070EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetReplaceItemId
		{
			get
			{
				return this.targetReplaceItemId_;
			}
			set
			{
				this.targetReplaceItemId_ = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x00072CD2 File Offset: 0x00070ED2
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x00072CDA File Offset: 0x00070EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetNum
		{
			get
			{
				return this.targetNum_;
			}
			set
			{
				this.targetNum_ = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x00072CE3 File Offset: 0x00070EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ConsumeItems
		{
			get
			{
				return this.consumeItems_;
			}
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x00072CEB File Offset: 0x00070EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchReplaceItem);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00072CFC File Offset: 0x00070EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchReplaceItem other)
		{
			return other != null && (other == this || (this.TargetReplaceItemId == other.TargetReplaceItemId && this.TargetNum == other.TargetNum && this.ConsumeItems.Equals(other.ConsumeItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00072D5C File Offset: 0x00070F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetReplaceItemId != 0)
			{
				num ^= this.TargetReplaceItemId.GetHashCode();
			}
			if (this.TargetNum != 0)
			{
				num ^= this.TargetNum.GetHashCode();
			}
			num ^= this.ConsumeItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00072DC2 File Offset: 0x00070FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00072DCF File Offset: 0x00070FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00072DD8 File Offset: 0x00070FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetReplaceItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetReplaceItemId);
			}
			if (this.TargetNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TargetNum);
			}
			this.consumeItems_.WriteTo(ref output, BatchReplaceItem._map_consumeItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00072E44 File Offset: 0x00071044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetReplaceItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetReplaceItemId);
			}
			if (this.TargetNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetNum);
			}
			num += this.consumeItems_.CalculateSize(BatchReplaceItem._map_consumeItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00072EB0 File Offset: 0x000710B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchReplaceItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetReplaceItemId != 0)
			{
				this.TargetReplaceItemId = other.TargetReplaceItemId;
			}
			if (other.TargetNum != 0)
			{
				this.TargetNum = other.TargetNum;
			}
			this.consumeItems_.MergeFrom(other.consumeItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x00072F11 File Offset: 0x00071111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00072F1C File Offset: 0x0007111C
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.consumeItems_.AddEntriesFrom(ref input, BatchReplaceItem._map_consumeItems_codec);
						}
					}
					else
					{
						this.TargetNum = input.ReadInt32();
					}
				}
				else
				{
					this.TargetReplaceItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027DC RID: 10204
		private static readonly MessageParser<BatchReplaceItem> _parser = new MessageParser<BatchReplaceItem>(() => new BatchReplaceItem());

		// Token: 0x040027DD RID: 10205
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027DE RID: 10206
		public const int TargetReplaceItemIdFieldNumber = 1;

		// Token: 0x040027DF RID: 10207
		private int targetReplaceItemId_;

		// Token: 0x040027E0 RID: 10208
		public const int TargetNumFieldNumber = 2;

		// Token: 0x040027E1 RID: 10209
		private int targetNum_;

		// Token: 0x040027E2 RID: 10210
		public const int ConsumeItemsFieldNumber = 3;

		// Token: 0x040027E3 RID: 10211
		private static readonly MapField<int, int>.Codec _map_consumeItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040027E4 RID: 10212
		private readonly MapField<int, int> consumeItems_ = new MapField<int, int>();
	}
}
