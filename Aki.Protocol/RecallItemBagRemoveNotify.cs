using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAE RID: 3758
	[NetMessage(EMessageId.RecallItemBagRemoveNotify)]
	public sealed class RecallItemBagRemoveNotify : IMessage<RecallItemBagRemoveNotify>, IMessage, IEquatable<RecallItemBagRemoveNotify>, IDeepCloneable<RecallItemBagRemoveNotify>, IBufferMessage
	{
		// Token: 0x060142AB RID: 82603 RVA: 0x002EF2FB File Offset: 0x002ED4FB
		[NullableContext(1)]
		public static RecallItemBagRemoveNotify Create()
		{
			return new RecallItemBagRemoveNotify();
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x060142AC RID: 82604 RVA: 0x002EF302 File Offset: 0x002ED502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x060142AD RID: 82605 RVA: 0x002EF305 File Offset: 0x002ED505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagRemoveNotify.Descriptor;
			}
		}

		// Token: 0x060142AE RID: 82606 RVA: 0x002EF30C File Offset: 0x002ED50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify()
		{
		}

		// Token: 0x060142AF RID: 82607 RVA: 0x002EF31F File Offset: 0x002ED51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify(RecallItemBagRemoveNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142B0 RID: 82608 RVA: 0x002EF355 File Offset: 0x002ED555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify Clone()
		{
			return new RecallItemBagRemoveNotify(this);
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x060142B1 RID: 82609 RVA: 0x002EF35D File Offset: 0x002ED55D
		// (set) Token: 0x060142B2 RID: 82610 RVA: 0x002EF365 File Offset: 0x002ED565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x060142B3 RID: 82611 RVA: 0x002EF36E File Offset: 0x002ED56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x060142B4 RID: 82612 RVA: 0x002EF376 File Offset: 0x002ED576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagRemoveNotify);
		}

		// Token: 0x060142B5 RID: 82613 RVA: 0x002EF384 File Offset: 0x002ED584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagRemoveNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142B6 RID: 82614 RVA: 0x002EF3D4 File Offset: 0x002ED5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			num ^= this.itemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142B7 RID: 82615 RVA: 0x002EF421 File Offset: 0x002ED621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142B8 RID: 82616 RVA: 0x002EF42E File Offset: 0x002ED62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142B9 RID: 82617 RVA: 0x002EF438 File Offset: 0x002ED638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RecallId);
			}
			this.itemIds_.WriteTo(ref output, RecallItemBagRemoveNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142BA RID: 82618 RVA: 0x002EF488 File Offset: 0x002ED688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			num += this.itemIds_.CalculateSize(RecallItemBagRemoveNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142BB RID: 82619 RVA: 0x002EF4DC File Offset: 0x002ED6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemBagRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this.itemIds_.Add(other.itemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142BC RID: 82620 RVA: 0x002EF529 File Offset: 0x002ED729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142BD RID: 82621 RVA: 0x002EF534 File Offset: 0x002ED734
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
				if (num != 40U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.itemIds_.AddEntriesFrom(ref input, RecallItemBagRemoveNotify._repeated_itemIds_codec);
					}
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007AD2 RID: 31442
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AD3 RID: 31443
		public const int RecallIdFieldNumber = 5;

		// Token: 0x04007AD4 RID: 31444
		private int recallId_;

		// Token: 0x04007AD5 RID: 31445
		public const int ItemIdsFieldNumber = 9;

		// Token: 0x04007AD6 RID: 31446
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007AD7 RID: 31447
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
