using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000842 RID: 2114
	[NetMessage(EMessageId.ItemGiftUseRequest)]
	public sealed class ItemGiftUseRequest : IMessage<ItemGiftUseRequest>, IMessage, IEquatable<ItemGiftUseRequest>, IDeepCloneable<ItemGiftUseRequest>, IBufferMessage
	{
		// Token: 0x0600BCF2 RID: 48370 RVA: 0x001C1848 File Offset: 0x001BFA48
		[NullableContext(1)]
		public static ItemGiftUseRequest Create()
		{
			return new ItemGiftUseRequest();
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x001C184F File Offset: 0x001BFA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x0600BCF4 RID: 48372 RVA: 0x001C1852 File Offset: 0x001BFA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseRequest.Descriptor;
			}
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x001C1859 File Offset: 0x001BFA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest()
		{
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x001C186C File Offset: 0x001BFA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest(ItemGiftUseRequest other) : this()
		{
			this.count_ = other.count_;
			this.selectedId_ = other.selectedId_.Clone();
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x001C18B9 File Offset: 0x001BFAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseRequest Clone()
		{
			return new ItemGiftUseRequest(this);
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x001C18C1 File Offset: 0x001BFAC1
		// (set) Token: 0x0600BCF9 RID: 48377 RVA: 0x001C18C9 File Offset: 0x001BFAC9
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

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x0600BCFA RID: 48378 RVA: 0x001C18D2 File Offset: 0x001BFAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectedId
		{
			get
			{
				return this.selectedId_;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x001C18DA File Offset: 0x001BFADA
		// (set) Token: 0x0600BCFC RID: 48380 RVA: 0x001C18E2 File Offset: 0x001BFAE2
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

		// Token: 0x0600BCFD RID: 48381 RVA: 0x001C18EB File Offset: 0x001BFAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseRequest);
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x001C18FC File Offset: 0x001BFAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseRequest other)
		{
			return other != null && (other == this || (this.Count == other.Count && this.selectedId_.Equals(other.selectedId_) && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x001C195C File Offset: 0x001BFB5C
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

		// Token: 0x0600BD00 RID: 48384 RVA: 0x001C19C2 File Offset: 0x001BFBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x001C19CF File Offset: 0x001BFBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x001C19D8 File Offset: 0x001BFBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.selectedId_.WriteTo(ref output, ItemGiftUseRequest._repeated_selectedId_codec);
			if (this.ItemId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x001C1A44 File Offset: 0x001BFC44
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

		// Token: 0x0600BD04 RID: 48388 RVA: 0x001C1AB0 File Offset: 0x001BFCB0
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

		// Token: 0x0600BD05 RID: 48389 RVA: 0x001C1B11 File Offset: 0x001BFD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x001C1B1C File Offset: 0x001BFD1C
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.selectedId_.AddEntriesFrom(ref input, ItemGiftUseRequest._repeated_selectedId_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040052F9 RID: 21241
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052FA RID: 21242
		public const int CountFieldNumber = 15;

		// Token: 0x040052FB RID: 21243
		private int count_;

		// Token: 0x040052FC RID: 21244
		public const int SelectedIdFieldNumber = 2;

		// Token: 0x040052FD RID: 21245
		private static readonly FieldCodec<int> _repeated_selectedId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040052FE RID: 21246
		private readonly RepeatedField<int> selectedId_ = new RepeatedField<int>();

		// Token: 0x040052FF RID: 21247
		public const int ItemIdFieldNumber = 13;

		// Token: 0x04005300 RID: 21248
		private int itemId_;
	}
}
