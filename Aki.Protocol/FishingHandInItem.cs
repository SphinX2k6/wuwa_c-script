using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000548 RID: 1352
	public sealed class FishingHandInItem : IMessage<FishingHandInItem>, IMessage, IEquatable<FishingHandInItem>, IDeepCloneable<FishingHandInItem>, IBufferMessage
	{
		// Token: 0x06007E9F RID: 32415 RVA: 0x00132798 File Offset: 0x00130998
		[NullableContext(1)]
		public static FishingHandInItem Create()
		{
			return new FishingHandInItem();
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x0013279F File Offset: 0x0013099F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingHandInItem> Parser
		{
			get
			{
				return FishingHandInItem._parser;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x001327A6 File Offset: 0x001309A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x001327A9 File Offset: 0x001309A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInItem.Descriptor;
			}
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x001327B0 File Offset: 0x001309B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem()
		{
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x001327B8 File Offset: 0x001309B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem(FishingHandInItem other) : this()
		{
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x001327F5 File Offset: 0x001309F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInItem Clone()
		{
			return new FishingHandInItem(this);
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x001327FD File Offset: 0x001309FD
		// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x00132805 File Offset: 0x00130A05
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

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x0013280E File Offset: 0x00130A0E
		// (set) Token: 0x06007EA9 RID: 32425 RVA: 0x00132816 File Offset: 0x00130A16
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

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x0013281F File Offset: 0x00130A1F
		// (set) Token: 0x06007EAB RID: 32427 RVA: 0x00132827 File Offset: 0x00130A27
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

		// Token: 0x06007EAC RID: 32428 RVA: 0x00132830 File Offset: 0x00130A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInItem);
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x00132840 File Offset: 0x00130A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInItem other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.IncrId == other.IncrId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0013289C File Offset: 0x00130A9C
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

		// Token: 0x06007EAF RID: 32431 RVA: 0x0013290D File Offset: 0x00130B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0013291A File Offset: 0x00130B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x00132924 File Offset: 0x00130B24
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

		// Token: 0x06007EB2 RID: 32434 RVA: 0x00132998 File Offset: 0x00130B98
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

		// Token: 0x06007EB3 RID: 32435 RVA: 0x00132A08 File Offset: 0x00130C08
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

		// Token: 0x06007EB4 RID: 32436 RVA: 0x00132A6C File Offset: 0x00130C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x00132A78 File Offset: 0x00130C78
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

		// Token: 0x04004072 RID: 16498
		private static readonly MessageParser<FishingHandInItem> _parser = new MessageParser<FishingHandInItem>(() => new FishingHandInItem());

		// Token: 0x04004073 RID: 16499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004074 RID: 16500
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004075 RID: 16501
		private int itemId_;

		// Token: 0x04004076 RID: 16502
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04004077 RID: 16503
		private int incrId_;

		// Token: 0x04004078 RID: 16504
		public const int CountFieldNumber = 3;

		// Token: 0x04004079 RID: 16505
		private int count_;
	}
}
