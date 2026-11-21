using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000841 RID: 2113
	[NetMessage(EMessageId.ItemGiftUseNotify)]
	public sealed class ItemGiftUseNotify : IMessage<ItemGiftUseNotify>, IMessage, IEquatable<ItemGiftUseNotify>, IDeepCloneable<ItemGiftUseNotify>, IBufferMessage
	{
		// Token: 0x0600BCDE RID: 48350 RVA: 0x001C159C File Offset: 0x001BF79C
		[NullableContext(1)]
		public static ItemGiftUseNotify Create()
		{
			return new ItemGiftUseNotify();
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x001C15A3 File Offset: 0x001BF7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x001C15A6 File Offset: 0x001BF7A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseNotify.Descriptor;
			}
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x001C15AD File Offset: 0x001BF7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify()
		{
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x001C15C0 File Offset: 0x001BF7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify(ItemGiftUseNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x001C15F6 File Offset: 0x001BF7F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify Clone()
		{
			return new ItemGiftUseNotify(this);
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x001C15FE File Offset: 0x001BF7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x001C1606 File Offset: 0x001BF806
		// (set) Token: 0x0600BCE6 RID: 48358 RVA: 0x001C160E File Offset: 0x001BF80E
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

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x001C1617 File Offset: 0x001BF817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseNotify);
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x001C1628 File Offset: 0x001BF828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x001C1678 File Offset: 0x001BF878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x001C16C5 File Offset: 0x001BF8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x001C16D2 File Offset: 0x001BF8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x001C16DC File Offset: 0x001BF8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, ItemGiftUseNotify._repeated_infos_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x001C172C File Offset: 0x001BF92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(ItemGiftUseNotify._repeated_infos_codec);
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x001C1780 File Offset: 0x001BF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemGiftUseNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x001C17CD File Offset: 0x001BF9CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x001C17D8 File Offset: 0x001BF9D8
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
				if (num != 34U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, ItemGiftUseNotify._repeated_infos_codec);
				}
			}
		}

		// Token: 0x040052F3 RID: 21235
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052F4 RID: 21236
		public const int InfosFieldNumber = 4;

		// Token: 0x040052F5 RID: 21237
		private static readonly FieldCodec<AddCountItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<AddCountItemInfo>(34U, AddCountItemInfo.Parser);

		// Token: 0x040052F6 RID: 21238
		private readonly RepeatedField<AddCountItemInfo> infos_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x040052F7 RID: 21239
		public const int IdFieldNumber = 5;

		// Token: 0x040052F8 RID: 21240
		private int id_;
	}
}
