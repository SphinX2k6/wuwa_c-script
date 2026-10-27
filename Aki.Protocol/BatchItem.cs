using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200015C RID: 348
	public sealed class BatchItem : IMessage<BatchItem>, IMessage, IEquatable<BatchItem>, IDeepCloneable<BatchItem>, IBufferMessage
	{
		// Token: 0x06002BCB RID: 11211 RVA: 0x00072508 File Offset: 0x00070708
		[NullableContext(1)]
		public static BatchItem Create()
		{
			return new BatchItem();
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x0007250F File Offset: 0x0007070F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BatchItem> Parser
		{
			get
			{
				return BatchItem._parser;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00072516 File Offset: 0x00070716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00072519 File Offset: 0x00070719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BatchItem.Descriptor;
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00072520 File Offset: 0x00070720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem()
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00072534 File Offset: 0x00070734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem(BatchItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.costItems_ = other.costItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00072581 File Offset: 0x00070781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BatchItem Clone()
		{
			return new BatchItem(this);
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x00072589 File Offset: 0x00070789
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00072591 File Offset: 0x00070791
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0007259A File Offset: 0x0007079A
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x000725A2 File Offset: 0x000707A2
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000725AB File Offset: 0x000707AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> CostItems
		{
			get
			{
				return this.costItems_;
			}
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000725B3 File Offset: 0x000707B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BatchItem);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000725C4 File Offset: 0x000707C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BatchItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.costItems_.Equals(other.costItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00072624 File Offset: 0x00070824
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

		// Token: 0x06002BDA RID: 11226 RVA: 0x0007268A File Offset: 0x0007088A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00072697 File Offset: 0x00070897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000726A0 File Offset: 0x000708A0
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

		// Token: 0x06002BDD RID: 11229 RVA: 0x0007270C File Offset: 0x0007090C
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

		// Token: 0x06002BDE RID: 11230 RVA: 0x00072778 File Offset: 0x00070978
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

		// Token: 0x06002BDF RID: 11231 RVA: 0x000727D9 File Offset: 0x000709D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000727E4 File Offset: 0x000709E4
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

		// Token: 0x040027CC RID: 10188
		private static readonly MessageParser<BatchItem> _parser = new MessageParser<BatchItem>(() => new BatchItem());

		// Token: 0x040027CD RID: 10189
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027CE RID: 10190
		public const int IdFieldNumber = 1;

		// Token: 0x040027CF RID: 10191
		private int id_;

		// Token: 0x040027D0 RID: 10192
		public const int CountFieldNumber = 2;

		// Token: 0x040027D1 RID: 10193
		private int count_;

		// Token: 0x040027D2 RID: 10194
		public const int CostItemsFieldNumber = 3;

		// Token: 0x040027D3 RID: 10195
		private static readonly FieldCodec<SingleItemInfo> _repeated_costItems_codec = FieldCodec.ForMessage<SingleItemInfo>(26U, SingleItemInfo.Parser);

		// Token: 0x040027D4 RID: 10196
		private readonly RepeatedField<SingleItemInfo> costItems_ = new RepeatedField<SingleItemInfo>();
	}
}
