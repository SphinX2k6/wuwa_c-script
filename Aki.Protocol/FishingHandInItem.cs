using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055D RID: 1373
	public sealed class FishingHandInItem : IMessage<FishingHandInItem>, IMessage, IEquatable<FishingHandInItem>, IDeepCloneable<FishingHandInItem>, IBufferMessage
	{
		// Token: 0x06008007 RID: 32775 RVA: 0x00135398 File Offset: 0x00133598
		[NullableContext(1)]
		public static FishingHandInItem Create()
		{
			return new FishingHandInItem();
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06008008 RID: 32776 RVA: 0x0013539F File Offset: 0x0013359F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingHandInItem> Parser
		{
			get
			{
				return FishingHandInItem._parser;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06008009 RID: 32777 RVA: 0x001353A6 File Offset: 0x001335A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600800A RID: 32778 RVA: 0x001353A9 File Offset: 0x001335A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInItem.Descriptor;
			}
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x001353B0 File Offset: 0x001335B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem()
		{
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x001353B8 File Offset: 0x001335B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem(FishingHandInItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600800D RID: 32781 RVA: 0x001353F5 File Offset: 0x001335F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem Clone()
		{
			return new FishingHandInItem(this);
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600800E RID: 32782 RVA: 0x001353FD File Offset: 0x001335FD
		// (set) Token: 0x0600800F RID: 32783 RVA: 0x00135405 File Offset: 0x00133605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06008010 RID: 32784 RVA: 0x0013540E File Offset: 0x0013360E
		// (set) Token: 0x06008011 RID: 32785 RVA: 0x00135416 File Offset: 0x00133616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06008012 RID: 32786 RVA: 0x0013541F File Offset: 0x0013361F
		// (set) Token: 0x06008013 RID: 32787 RVA: 0x00135427 File Offset: 0x00133627
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

		// Token: 0x06008014 RID: 32788 RVA: 0x00135430 File Offset: 0x00133630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInItem);
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00135440 File Offset: 0x00133640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x0013549C File Offset: 0x0013369C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x0013550D File Offset: 0x0013370D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x0013551A File Offset: 0x0013371A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x00135524 File Offset: 0x00133724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00135598 File Offset: 0x00133798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x00135608 File Offset: 0x00133808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x0013566C File Offset: 0x0013386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x00135678 File Offset: 0x00133878
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Count = input.ReadInt32();
						}
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400407C RID: 16508
		private static readonly MessageParser<FishingHandInItem> _parser = new MessageParser<FishingHandInItem>(() => new FishingHandInItem());

		// Token: 0x0400407D RID: 16509
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400407E RID: 16510
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400407F RID: 16511
		private int itemId_;

		// Token: 0x04004080 RID: 16512
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04004081 RID: 16513
		private int incrId_;

		// Token: 0x04004082 RID: 16514
		public const int CountFieldNumber = 3;

		// Token: 0x04004083 RID: 16515
		private int count_;
	}
}
