using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000854 RID: 2132
	[NetMessage(EMessageId.ItemGiftUseRequest)]
	public sealed class ItemGiftUseRequest : IMessage<ItemGiftUseRequest>, IMessage, IEquatable<ItemGiftUseRequest>, IDeepCloneable<ItemGiftUseRequest>, IBufferMessage
	{
		// Token: 0x0600BE20 RID: 48672 RVA: 0x001C3D13 File Offset: 0x001C1F13
		[NullableContext(1)]
		public static ItemGiftUseRequest Create()
		{
			return new ItemGiftUseRequest();
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x001C3D1A File Offset: 0x001C1F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x0600BE22 RID: 48674 RVA: 0x001C3D1D File Offset: 0x001C1F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseRequest.Descriptor;
			}
		}

		// Token: 0x0600BE23 RID: 48675 RVA: 0x001C3D24 File Offset: 0x001C1F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest()
		{
		}

		// Token: 0x0600BE24 RID: 48676 RVA: 0x001C3D38 File Offset: 0x001C1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest(ItemGiftUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.selectedId_ = other.selectedId_.Clone();
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE25 RID: 48677 RVA: 0x001C3D85 File Offset: 0x001C1F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest Clone()
		{
			return new ItemGiftUseRequest(this);
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x0600BE26 RID: 48678 RVA: 0x001C3D8D File Offset: 0x001C1F8D
		// (set) Token: 0x0600BE27 RID: 48679 RVA: 0x001C3D95 File Offset: 0x001C1F95
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

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x0600BE28 RID: 48680 RVA: 0x001C3D9E File Offset: 0x001C1F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x0600BE29 RID: 48681 RVA: 0x001C3DA6 File Offset: 0x001C1FA6
		// (set) Token: 0x0600BE2A RID: 48682 RVA: 0x001C3DAE File Offset: 0x001C1FAE
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

		// Token: 0x0600BE2B RID: 48683 RVA: 0x001C3DB7 File Offset: 0x001C1FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseRequest);
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x001C3DC8 File Offset: 0x001C1FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.selectedId_.Equals(other.selectedId_) && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x001C3E28 File Offset: 0x001C2028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			num ^= this.selectedId_.GetHashCode();
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE2E RID: 48686 RVA: 0x001C3E8E File Offset: 0x001C208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x001C3E9B File Offset: 0x001C209B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x001C3EA4 File Offset: 0x001C20A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			this.selectedId_.WriteTo(ref output, ItemGiftUseRequest._repeated_selectedId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x001C3F10 File Offset: 0x001C2110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			num += this.selectedId_.CalculateSize(ItemGiftUseRequest._repeated_selectedId_codec);
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x001C3F7C File Offset: 0x001C217C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemGiftUseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this.selectedId_.Add(other.selectedId_);
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x001C3FDD File Offset: 0x001C21DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x001C3FE8 File Offset: 0x001C21E8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.selectedId_.AddEntriesFrom(ref input, ItemGiftUseRequest._repeated_selectedId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040052F6 RID: 21238
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052F7 RID: 21239
		public const int CountFieldNumber = 2;

		// Token: 0x040052F8 RID: 21240
		private int count_;

		// Token: 0x040052F9 RID: 21241
		public const int SelectedIdFieldNumber = 13;

		// Token: 0x040052FA RID: 21242
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040052FB RID: 21243
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();

		// Token: 0x040052FC RID: 21244
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040052FD RID: 21245
		private int itemId_;
	}
}
