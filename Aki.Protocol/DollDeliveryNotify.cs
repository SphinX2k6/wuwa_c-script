using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E7 RID: 999
	[NetMessage(EMessageId.DollDeliveryNotify)]
	public sealed class DollDeliveryNotify : IMessage<DollDeliveryNotify>, IMessage, IEquatable<DollDeliveryNotify>, IDeepCloneable<DollDeliveryNotify>, IBufferMessage
	{
		// Token: 0x06006102 RID: 24834 RVA: 0x000EA539 File Offset: 0x000E8739
		[NullableContext(1)]
		public static DollDeliveryNotify Create()
		{
			return new DollDeliveryNotify();
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x000EA540 File Offset: 0x000E8740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06006104 RID: 24836 RVA: 0x000EA543 File Offset: 0x000E8743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryNotify.Descriptor;
			}
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x000EA54A File Offset: 0x000E874A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify()
		{
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x000EA568 File Offset: 0x000E8768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify(DollDeliveryNotify other) : this()
		{
			this.itemIds_ = other.itemIds_.Clone();
			this.dropIds_ = other.dropIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x000EA5A3 File Offset: 0x000E87A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify Clone()
		{
			return new DollDeliveryNotify(this);
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06006108 RID: 24840 RVA: 0x000EA5AB File Offset: 0x000E87AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x000EA5B3 File Offset: 0x000E87B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DropIds
		{
			get
			{
				return this.dropIds_;
			}
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x000EA5BB File Offset: 0x000E87BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryNotify);
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x000EA5CC File Offset: 0x000E87CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryNotify other)
		{
			return other != null && (other == this || (this.itemIds_.Equals(other.itemIds_) && this.dropIds_.Equals(other.dropIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x000EA620 File Offset: 0x000E8820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemIds_.GetHashCode();
			num ^= this.dropIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x000EA662 File Offset: 0x000E8862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x000EA66F File Offset: 0x000E886F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x000EA678 File Offset: 0x000E8878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropIds_.WriteTo(ref output, DollDeliveryNotify._repeated_dropIds_codec);
			this.itemIds_.WriteTo(ref output, DollDeliveryNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x000EA6B0 File Offset: 0x000E88B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemIds_.CalculateSize(DollDeliveryNotify._repeated_itemIds_codec);
			num += this.dropIds_.CalculateSize(DollDeliveryNotify._repeated_dropIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x000EA6FC File Offset: 0x000E88FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemIds_.Add(other.itemIds_);
			this.dropIds_.Add(other.dropIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x000EA73B File Offset: 0x000E893B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x000EA744 File Offset: 0x000E8944
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.dropIds_.AddEntriesFrom(ref input, DollDeliveryNotify._repeated_dropIds_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.itemIds_.AddEntriesFrom(ref input, DollDeliveryNotify._repeated_itemIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003784 RID: 14212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003785 RID: 14213
		public const int ItemIdsFieldNumber = 15;

		// Token: 0x04003786 RID: 14214
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04003787 RID: 14215
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();

		// Token: 0x04003788 RID: 14216
		public const int DropIdsFieldNumber = 3;

		// Token: 0x04003789 RID: 14217
		private static readonly FieldCodec<int> _repeated_dropIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400378A RID: 14218
		private readonly RepeatedField<int> dropIds_ = new RepeatedField<int>();
	}
}
