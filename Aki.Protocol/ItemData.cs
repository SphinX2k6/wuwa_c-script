using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000843 RID: 2115
	public sealed class ItemData : IMessage<ItemData>, IMessage, IEquatable<ItemData>, IDeepCloneable<ItemData>, IBufferMessage
	{
		// Token: 0x0600BCCC RID: 48332 RVA: 0x001C1315 File Offset: 0x001BF515
		[NullableContext(1)]
		public static ItemData Create()
		{
			return new ItemData();
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x001C131C File Offset: 0x001BF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemData> Parser
		{
			get
			{
				return ItemData._parser;
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x001C1323 File Offset: 0x001BF523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600BCCF RID: 48335 RVA: 0x001C1326 File Offset: 0x001BF526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemData.Descriptor;
			}
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x001C132D File Offset: 0x001BF52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData()
		{
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x001C1335 File Offset: 0x001BF535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData(ItemData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemIncId_ = other.itemIncId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x001C1372 File Offset: 0x001BF572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData Clone()
		{
			return new ItemData(this);
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x001C137A File Offset: 0x001BF57A
		// (set) Token: 0x0600BCD4 RID: 48340 RVA: 0x001C1382 File Offset: 0x001BF582
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

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600BCD5 RID: 48341 RVA: 0x001C138B File Offset: 0x001BF58B
		// (set) Token: 0x0600BCD6 RID: 48342 RVA: 0x001C1393 File Offset: 0x001BF593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemIncId
		{
			get
			{
				return this.itemIncId_;
			}
			set
			{
				this.itemIncId_ = value;
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600BCD7 RID: 48343 RVA: 0x001C139C File Offset: 0x001BF59C
		// (set) Token: 0x0600BCD8 RID: 48344 RVA: 0x001C13A4 File Offset: 0x001BF5A4
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

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x001C13AD File Offset: 0x001BF5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemData);
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x001C13BC File Offset: 0x001BF5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemIncId == other.ItemIncId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x001C1418 File Offset: 0x001BF618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemIncId != 0)
			{
				num ^= this.ItemIncId.GetHashCode();
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

		// Token: 0x0600BCDC RID: 48348 RVA: 0x001C1489 File Offset: 0x001BF689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x001C1496 File Offset: 0x001BF696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x001C14A0 File Offset: 0x001BF6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemIncId);
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

		// Token: 0x0600BCDF RID: 48351 RVA: 0x001C1514 File Offset: 0x001BF714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemIncId);
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

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x001C1584 File Offset: 0x001BF784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemIncId != 0)
			{
				this.ItemIncId = other.ItemIncId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x001C15E8 File Offset: 0x001BF7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x001C15F4 File Offset: 0x001BF7F4
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
						this.ItemIncId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400529D RID: 21149
		private static readonly MessageParser<ItemData> _parser = new MessageParser<ItemData>(() => new ItemData());

		// Token: 0x0400529E RID: 21150
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400529F RID: 21151
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052A0 RID: 21152
		private int itemId_;

		// Token: 0x040052A1 RID: 21153
		public const int ItemIncIdFieldNumber = 2;

		// Token: 0x040052A2 RID: 21154
		private int itemIncId_;

		// Token: 0x040052A3 RID: 21155
		public const int CountFieldNumber = 3;

		// Token: 0x040052A4 RID: 21156
		private int count_;
	}
}
