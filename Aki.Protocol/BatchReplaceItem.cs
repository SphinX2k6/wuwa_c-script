using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000162 RID: 354
	public sealed class BatchReplaceItem : IMessage<BatchReplaceItem>, IMessage, IEquatable<BatchReplaceItem>, IDeepCloneable<BatchReplaceItem>, IBufferMessage
	{
		// Token: 0x06002C7D RID: 11389 RVA: 0x00074071 File Offset: 0x00072271
		[NullableContext(1)]
		public static BatchReplaceItem Create()
		{
			return new BatchReplaceItem();
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00074078 File Offset: 0x00072278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchReplaceItem> Parser
		{
			get
			{
				return BatchReplaceItem._parser;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x0007407F File Offset: 0x0007227F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00074082 File Offset: 0x00072282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchReplaceItem.Descriptor;
			}
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00074089 File Offset: 0x00072289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem()
		{
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0007409C File Offset: 0x0007229C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem(BatchReplaceItem other) : this()
		{
			this.targetReplaceItemId_ = other.targetReplaceItemId_;
			this.targetNum_ = other.targetNum_;
			this.consumeItems_ = other.consumeItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000740E9 File Offset: 0x000722E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchReplaceItem Clone()
		{
			return new BatchReplaceItem(this);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000740F1 File Offset: 0x000722F1
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x000740F9 File Offset: 0x000722F9
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

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00074102 File Offset: 0x00072302
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x0007410A File Offset: 0x0007230A
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

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002C88 RID: 11400 RVA: 0x00074113 File Offset: 0x00072313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ConsumeItems
		{
			get
			{
				return this.consumeItems_;
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0007411B File Offset: 0x0007231B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchReplaceItem);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x0007412C File Offset: 0x0007232C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchReplaceItem other)
		{
			return other != null && (other == this || (this.TargetReplaceItemId == other.TargetReplaceItemId && this.TargetNum == other.TargetNum && this.ConsumeItems.Equals(other.ConsumeItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x0007418C File Offset: 0x0007238C
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

		// Token: 0x06002C8C RID: 11404 RVA: 0x000741F2 File Offset: 0x000723F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000741FF File Offset: 0x000723FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00074208 File Offset: 0x00072408
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

		// Token: 0x06002C8F RID: 11407 RVA: 0x00074274 File Offset: 0x00072474
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

		// Token: 0x06002C90 RID: 11408 RVA: 0x000742E0 File Offset: 0x000724E0
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

		// Token: 0x06002C91 RID: 11409 RVA: 0x00074341 File Offset: 0x00072541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0007434C File Offset: 0x0007254C
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

		// Token: 0x04002850 RID: 10320
		private static readonly MessageParser<BatchReplaceItem> _parser = new MessageParser<BatchReplaceItem>(() => new BatchReplaceItem());

		// Token: 0x04002851 RID: 10321
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002852 RID: 10322
		public const int TargetReplaceItemIdFieldNumber = 1;

		// Token: 0x04002853 RID: 10323
		private int targetReplaceItemId_;

		// Token: 0x04002854 RID: 10324
		public const int TargetNumFieldNumber = 2;

		// Token: 0x04002855 RID: 10325
		private int targetNum_;

		// Token: 0x04002856 RID: 10326
		public const int ConsumeItemsFieldNumber = 3;

		// Token: 0x04002857 RID: 10327
		private static readonly MapField<int, int>.Codec _map_consumeItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x04002858 RID: 10328
		private readonly MapField<int, int> consumeItems_ = new MapField<int, int>();
	}
}
