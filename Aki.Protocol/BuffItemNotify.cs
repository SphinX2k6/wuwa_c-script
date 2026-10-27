using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000202 RID: 514
	[NetMessage(EMessageId.BuffItemNotify)]
	public sealed class BuffItemNotify : IMessage<BuffItemNotify>, IMessage, IEquatable<BuffItemNotify>, IDeepCloneable<BuffItemNotify>, IBufferMessage
	{
		// Token: 0x060038DE RID: 14558 RVA: 0x0008DE33 File Offset: 0x0008C033
		[NullableContext(1)]
		public static BuffItemNotify Create()
		{
			return new BuffItemNotify();
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x0008DE3A File Offset: 0x0008C03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x0008DE3D File Offset: 0x0008C03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffItemNotify.Descriptor;
			}
		}

		// Token: 0x060038E1 RID: 14561 RVA: 0x0008DE44 File Offset: 0x0008C044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify()
		{
		}

		// Token: 0x060038E2 RID: 14562 RVA: 0x0008DE62 File Offset: 0x0008C062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify(BuffItemNotify other) : this()
		{
			this.itemBuffList_ = other.itemBuffList_.Clone();
			this.equipItemList_ = other.equipItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x0008DE9D File Offset: 0x0008C09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffItemNotify Clone()
		{
			return new BuffItemNotify(this);
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x0008DEA5 File Offset: 0x0008C0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BuffItem> ItemBuffList
		{
			get
			{
				return this.itemBuffList_;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x0008DEAD File Offset: 0x0008C0AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EquipBuffItem> EquipItemList
		{
			get
			{
				return this.equipItemList_;
			}
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0008DEB5 File Offset: 0x0008C0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffItemNotify);
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0008DEC4 File Offset: 0x0008C0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffItemNotify other)
		{
			return other != null && (other == this || (this.itemBuffList_.Equals(other.itemBuffList_) && this.equipItemList_.Equals(other.equipItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x0008DF18 File Offset: 0x0008C118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemBuffList_.GetHashCode();
			num ^= this.equipItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0008DF5A File Offset: 0x0008C15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0008DF67 File Offset: 0x0008C167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x0008DF70 File Offset: 0x0008C170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipItemList_.WriteTo(ref output, BuffItemNotify._repeated_equipItemList_codec);
			this.itemBuffList_.WriteTo(ref output, BuffItemNotify._repeated_itemBuffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x0008DFA8 File Offset: 0x0008C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemBuffList_.CalculateSize(BuffItemNotify._repeated_itemBuffList_codec);
			num += this.equipItemList_.CalculateSize(BuffItemNotify._repeated_equipItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0008DFF4 File Offset: 0x0008C1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemBuffList_.Add(other.itemBuffList_);
			this.equipItemList_.Add(other.equipItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x0008E033 File Offset: 0x0008C233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0008E03C File Offset: 0x0008C23C
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
				if (num != 42U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemBuffList_.AddEntriesFrom(ref input, BuffItemNotify._repeated_itemBuffList_codec);
					}
				}
				else
				{
					this.equipItemList_.AddEntriesFrom(ref input, BuffItemNotify._repeated_equipItemList_codec);
				}
			}
		}

		// Token: 0x04002B50 RID: 11088
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B51 RID: 11089
		public const int ItemBuffListFieldNumber = 12;

		// Token: 0x04002B52 RID: 11090
		private static readonly FieldCodec<BuffItem> _repeated_itemBuffList_codec = FieldCodec.ForMessage<BuffItem>(98U, BuffItem.Parser);

		// Token: 0x04002B53 RID: 11091
		private readonly RepeatedField<BuffItem> itemBuffList_ = new RepeatedField<BuffItem>();

		// Token: 0x04002B54 RID: 11092
		public const int EquipItemListFieldNumber = 5;

		// Token: 0x04002B55 RID: 11093
		private static readonly FieldCodec<EquipBuffItem> _repeated_equipItemList_codec = FieldCodec.ForMessage<EquipBuffItem>(42U, EquipBuffItem.Parser);

		// Token: 0x04002B56 RID: 11094
		private readonly RepeatedField<EquipBuffItem> equipItemList_ = new RepeatedField<EquipBuffItem>();
	}
}
