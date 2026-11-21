using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000830 RID: 2096
	public sealed class ItemData : IMessage<ItemData>, IMessage, IEquatable<ItemData>, IDeepCloneable<ItemData>, IBufferMessage
	{
		// Token: 0x0600BB88 RID: 48008 RVA: 0x001BEB04 File Offset: 0x001BCD04
		[NullableContext(1)]
		public static ItemData Create()
		{
			return new ItemData();
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x0600BB89 RID: 48009 RVA: 0x001BEB0B File Offset: 0x001BCD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemData> Parser
		{
			get
			{
				return ItemData._parser;
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x0600BB8A RID: 48010 RVA: 0x001BEB12 File Offset: 0x001BCD12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x0600BB8B RID: 48011 RVA: 0x001BEB15 File Offset: 0x001BCD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemData.Descriptor;
			}
		}

		// Token: 0x0600BB8C RID: 48012 RVA: 0x001BEB1C File Offset: 0x001BCD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData()
		{
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x001BEB24 File Offset: 0x001BCD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData(ItemData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemIncId_ = other.itemIncId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB8E RID: 48014 RVA: 0x001BEB61 File Offset: 0x001BCD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemData Clone()
		{
			return new ItemData(this);
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x0600BB8F RID: 48015 RVA: 0x001BEB69 File Offset: 0x001BCD69
		// (set) Token: 0x0600BB90 RID: 48016 RVA: 0x001BEB71 File Offset: 0x001BCD71
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

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x0600BB91 RID: 48017 RVA: 0x001BEB7A File Offset: 0x001BCD7A
		// (set) Token: 0x0600BB92 RID: 48018 RVA: 0x001BEB82 File Offset: 0x001BCD82
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

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x0600BB93 RID: 48019 RVA: 0x001BEB8B File Offset: 0x001BCD8B
		// (set) Token: 0x0600BB94 RID: 48020 RVA: 0x001BEB93 File Offset: 0x001BCD93
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

		// Token: 0x0600BB95 RID: 48021 RVA: 0x001BEB9C File Offset: 0x001BCD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemData);
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x001BEBAC File Offset: 0x001BCDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemIncId == other.ItemIncId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x001BEC08 File Offset: 0x001BCE08
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

		// Token: 0x0600BB98 RID: 48024 RVA: 0x001BEC79 File Offset: 0x001BCE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x001BEC86 File Offset: 0x001BCE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x001BEC90 File Offset: 0x001BCE90
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

		// Token: 0x0600BB9B RID: 48027 RVA: 0x001BED04 File Offset: 0x001BCF04
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

		// Token: 0x0600BB9C RID: 48028 RVA: 0x001BED74 File Offset: 0x001BCF74
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

		// Token: 0x0600BB9D RID: 48029 RVA: 0x001BEDD8 File Offset: 0x001BCFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x001BEDE4 File Offset: 0x001BCFE4
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

		// Token: 0x04005299 RID: 21145
		private static readonly MessageParser<ItemData> _parser = new MessageParser<ItemData>(() => new ItemData());

		// Token: 0x0400529A RID: 21146
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400529B RID: 21147
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400529C RID: 21148
		private int itemId_;

		// Token: 0x0400529D RID: 21149
		public const int ItemIncIdFieldNumber = 2;

		// Token: 0x0400529E RID: 21150
		private int itemIncId_;

		// Token: 0x0400529F RID: 21151
		public const int CountFieldNumber = 3;

		// Token: 0x040052A0 RID: 21152
		private int count_;
	}
}
