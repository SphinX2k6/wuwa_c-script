using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000839 RID: 2105
	public sealed class ItemEntry : IMessage<ItemEntry>, IMessage, IEquatable<ItemEntry>, IDeepCloneable<ItemEntry>, IBufferMessage
	{
		// Token: 0x0600BC39 RID: 48185 RVA: 0x001C0085 File Offset: 0x001BE285
		[NullableContext(1)]
		public static ItemEntry Create()
		{
			return new ItemEntry();
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600BC3A RID: 48186 RVA: 0x001C008C File Offset: 0x001BE28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ItemEntry> Parser
		{
			get
			{
				return ItemEntry._parser;
			}
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600BC3B RID: 48187 RVA: 0x001C0093 File Offset: 0x001BE293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600BC3C RID: 48188 RVA: 0x001C0096 File Offset: 0x001BE296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemEntry.Descriptor;
			}
		}

		// Token: 0x0600BC3D RID: 48189 RVA: 0x001C009D File Offset: 0x001BE29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry()
		{
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x001C00A5 File Offset: 0x001BE2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry(ItemEntry other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x001C00D6 File Offset: 0x001BE2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemEntry Clone()
		{
			return new ItemEntry(this);
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x001C00DE File Offset: 0x001BE2DE
		// (set) Token: 0x0600BC41 RID: 48193 RVA: 0x001C00E6 File Offset: 0x001BE2E6
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

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x0600BC42 RID: 48194 RVA: 0x001C00EF File Offset: 0x001BE2EF
		// (set) Token: 0x0600BC43 RID: 48195 RVA: 0x001C00F7 File Offset: 0x001BE2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x001C0100 File Offset: 0x001BE300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemEntry);
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x001C010E File Offset: 0x001BE30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemEntry other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x001C014C File Offset: 0x001BE34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x001C01A4 File Offset: 0x001BE3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x001C01B1 File Offset: 0x001BE3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x001C01BC File Offset: 0x001BE3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x001C0214 File Offset: 0x001BE414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x001C026C File Offset: 0x001BE46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x001C02BC File Offset: 0x001BE4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x001C02C8 File Offset: 0x001BE4C8
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052C6 RID: 21190
		private static readonly MessageParser<ItemEntry> _parser = new MessageParser<ItemEntry>(() => new ItemEntry());

		// Token: 0x040052C7 RID: 21191
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052C8 RID: 21192
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052C9 RID: 21193
		private int itemId_;

		// Token: 0x040052CA RID: 21194
		public const int ItemCountFieldNumber = 2;

		// Token: 0x040052CB RID: 21195
		private int itemCount_;
	}
}
