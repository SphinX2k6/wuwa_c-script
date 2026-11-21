using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9D RID: 3741
	[NetMessage(EMessageId.RecallItemBagObtainNotify)]
	public sealed class RecallItemBagObtainNotify : IMessage<RecallItemBagObtainNotify>, IMessage, IEquatable<RecallItemBagObtainNotify>, IDeepCloneable<RecallItemBagObtainNotify>, IBufferMessage
	{
		// Token: 0x060141B0 RID: 82352 RVA: 0x002ED8F7 File Offset: 0x002EBAF7
		[NullableContext(1)]
		public static RecallItemBagObtainNotify Create()
		{
			return new RecallItemBagObtainNotify();
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x060141B1 RID: 82353 RVA: 0x002ED8FE File Offset: 0x002EBAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042E6 RID: 17126
		// (get) Token: 0x060141B2 RID: 82354 RVA: 0x002ED901 File Offset: 0x002EBB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagObtainNotify.Descriptor;
			}
		}

		// Token: 0x060141B3 RID: 82355 RVA: 0x002ED908 File Offset: 0x002EBB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify()
		{
		}

		// Token: 0x060141B4 RID: 82356 RVA: 0x002ED91C File Offset: 0x002EBB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify(RecallItemBagObtainNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.items_ = other.items_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141B5 RID: 82357 RVA: 0x002ED969 File Offset: 0x002EBB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify Clone()
		{
			return new RecallItemBagObtainNotify(this);
		}

		// Token: 0x170042E7 RID: 17127
		// (get) Token: 0x060141B6 RID: 82358 RVA: 0x002ED971 File Offset: 0x002EBB71
		// (set) Token: 0x060141B7 RID: 82359 RVA: 0x002ED979 File Offset: 0x002EBB79
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

		// Token: 0x170042E8 RID: 17128
		// (get) Token: 0x060141B8 RID: 82360 RVA: 0x002ED982 File Offset: 0x002EBB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x060141B9 RID: 82361 RVA: 0x002ED98A File Offset: 0x002EBB8A
		// (set) Token: 0x060141BA RID: 82362 RVA: 0x002ED992 File Offset: 0x002EBB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060141BB RID: 82363 RVA: 0x002ED99B File Offset: 0x002EBB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagObtainNotify);
		}

		// Token: 0x060141BC RID: 82364 RVA: 0x002ED9AC File Offset: 0x002EBBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagObtainNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.items_.Equals(other.items_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141BD RID: 82365 RVA: 0x002EDA0C File Offset: 0x002EBC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060141BE RID: 82366 RVA: 0x002EDA72 File Offset: 0x002EBC72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141BF RID: 82367 RVA: 0x002EDA7F File Offset: 0x002EBC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141C0 RID: 82368 RVA: 0x002EDA88 File Offset: 0x002EBC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, RecallItemBagObtainNotify._repeated_items_codec);
			if (this.RecallId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RecallId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060141C1 RID: 82369 RVA: 0x002EDAF4 File Offset: 0x002EBCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			num += this.items_.CalculateSize(RecallItemBagObtainNotify._repeated_items_codec);
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060141C2 RID: 82370 RVA: 0x002EDB60 File Offset: 0x002EBD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemBagObtainNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			this.items_.Add(other.items_);
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060141C3 RID: 82371 RVA: 0x002EDBC1 File Offset: 0x002EBDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141C4 RID: 82372 RVA: 0x002EDBCC File Offset: 0x002EBDCC
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
					if (num != 72U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reason = input.ReadInt32();
						}
					}
					else
					{
						this.RecallId = input.ReadInt32();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, RecallItemBagObtainNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x04007AF4 RID: 31476
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AF5 RID: 31477
		public const int RecallIdFieldNumber = 9;

		// Token: 0x04007AF6 RID: 31478
		private int recallId_;

		// Token: 0x04007AF7 RID: 31479
		public const int ItemsFieldNumber = 4;

		// Token: 0x04007AF8 RID: 31480
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(34U, RecallItemBagItem.Parser);

		// Token: 0x04007AF9 RID: 31481
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();

		// Token: 0x04007AFA RID: 31482
		public const int ReasonFieldNumber = 15;

		// Token: 0x04007AFB RID: 31483
		private int reason_;
	}
}
