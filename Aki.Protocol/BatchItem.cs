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
	public sealed class BatchItem : IMessage<BatchItem>, IMessage, IEquatable<BatchItem>, IDeepCloneable<BatchItem>, IBufferMessage
	{
		// Token: 0x06002C42 RID: 11330 RVA: 0x00073938 File Offset: 0x00071B38
		[NullableContext(1)]
		public static BatchItem Create()
		{
			return new BatchItem();
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x0007393F File Offset: 0x00071B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchItem> Parser
		{
			get
			{
				return BatchItem._parser;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x00073946 File Offset: 0x00071B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00073949 File Offset: 0x00071B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchItem.Descriptor;
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00073950 File Offset: 0x00071B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem()
		{
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x00073964 File Offset: 0x00071B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem(BatchItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.costItems_ = other.costItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000739B1 File Offset: 0x00071BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem Clone()
		{
			return new BatchItem(this);
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000739B9 File Offset: 0x00071BB9
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x000739C1 File Offset: 0x00071BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000739CA File Offset: 0x00071BCA
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000739D2 File Offset: 0x00071BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000739DB File Offset: 0x00071BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> CostItems
		{
			get
			{
				return this.costItems_;
			}
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000739E3 File Offset: 0x00071BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchItem);
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000739F4 File Offset: 0x00071BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.costItems_.Equals(other.costItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x00073A54 File Offset: 0x00071C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			num ^= this.costItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x00073ABA File Offset: 0x00071CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x00073AC7 File Offset: 0x00071CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00073AD0 File Offset: 0x00071CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			this.costItems_.WriteTo(ref output, BatchItem._repeated_costItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00073B3C File Offset: 0x00071D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			num += this.costItems_.CalculateSize(BatchItem._repeated_costItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00073BA8 File Offset: 0x00071DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BatchItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this.costItems_.Add(other.costItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00073C09 File Offset: 0x00071E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x00073C14 File Offset: 0x00071E14
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
							this.costItems_.AddEntriesFrom(ref input, BatchItem._repeated_costItems_codec);
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002840 RID: 10304
		private static readonly MessageParser<BatchItem> _parser = new MessageParser<BatchItem>(() => new BatchItem());

		// Token: 0x04002841 RID: 10305
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002842 RID: 10306
		public const int IdFieldNumber = 1;

		// Token: 0x04002843 RID: 10307
		private int id_;

		// Token: 0x04002844 RID: 10308
		public const int CountFieldNumber = 2;

		// Token: 0x04002845 RID: 10309
		private int count_;

		// Token: 0x04002846 RID: 10310
		public const int CostItemsFieldNumber = 3;

		// Token: 0x04002847 RID: 10311
		private static readonly FieldCodec<SingleItemInfo> _repeated_costItems_codec = FieldCodec.ForMessage<SingleItemInfo>(26U, SingleItemInfo.Parser);

		// Token: 0x04002848 RID: 10312
		private readonly RepeatedField<SingleItemInfo> costItems_ = new RepeatedField<SingleItemInfo>();
	}
}
