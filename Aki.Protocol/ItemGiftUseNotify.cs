using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000853 RID: 2131
	[NetMessage(EMessageId.ItemGiftUseNotify)]
	public sealed class ItemGiftUseNotify : IMessage<ItemGiftUseNotify>, IMessage, IEquatable<ItemGiftUseNotify>, IDeepCloneable<ItemGiftUseNotify>, IBufferMessage
	{
		// Token: 0x0600BE0C RID: 48652 RVA: 0x001C3A6B File Offset: 0x001C1C6B
		[NullableContext(1)]
		public static ItemGiftUseNotify Create()
		{
			return new ItemGiftUseNotify();
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x001C3A72 File Offset: 0x001C1C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600BE0E RID: 48654 RVA: 0x001C3A75 File Offset: 0x001C1C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemGiftUseNotify.Descriptor;
			}
		}

		// Token: 0x0600BE0F RID: 48655 RVA: 0x001C3A7C File Offset: 0x001C1C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify()
		{
		}

		// Token: 0x0600BE10 RID: 48656 RVA: 0x001C3A8F File Offset: 0x001C1C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify(ItemGiftUseNotify other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x001C3AC5 File Offset: 0x001C1CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemGiftUseNotify Clone()
		{
			return new ItemGiftUseNotify(this);
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600BE12 RID: 48658 RVA: 0x001C3ACD File Offset: 0x001C1CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x001C3AD5 File Offset: 0x001C1CD5
		// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x001C3ADD File Offset: 0x001C1CDD
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

		// Token: 0x0600BE15 RID: 48661 RVA: 0x001C3AE6 File Offset: 0x001C1CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemGiftUseNotify);
		}

		// Token: 0x0600BE16 RID: 48662 RVA: 0x001C3AF4 File Offset: 0x001C1CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemGiftUseNotify other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x001C3B44 File Offset: 0x001C1D44
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

		// Token: 0x0600BE18 RID: 48664 RVA: 0x001C3B91 File Offset: 0x001C1D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x001C3B9E File Offset: 0x001C1D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x001C3BA8 File Offset: 0x001C1DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.infos_.WriteTo(ref output, ItemGiftUseNotify._repeated_infos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x001C3BF8 File Offset: 0x001C1DF8
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

		// Token: 0x0600BE1C RID: 48668 RVA: 0x001C3C4C File Offset: 0x001C1E4C
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

		// Token: 0x0600BE1D RID: 48669 RVA: 0x001C3C99 File Offset: 0x001C1E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE1E RID: 48670 RVA: 0x001C3CA4 File Offset: 0x001C1EA4
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.infos_.AddEntriesFrom(ref input, ItemGiftUseNotify._repeated_infos_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052F0 RID: 21232
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052F1 RID: 21233
		public const int InfosFieldNumber = 10;

		// Token: 0x040052F2 RID: 21234
		private static readonly FieldCodec<AddCountItemInfo> _repeated_infos_codec = FieldCodec.ForMessage<AddCountItemInfo>(82U, AddCountItemInfo.Parser);

		// Token: 0x040052F3 RID: 21235
		private readonly RepeatedField<AddCountItemInfo> infos_ = new RepeatedField<AddCountItemInfo>();

		// Token: 0x040052F4 RID: 21236
		public const int IdFieldNumber = 1;

		// Token: 0x040052F5 RID: 21237
		private int id_;
	}
}
