using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9E RID: 3742
	[NetMessage(EMessageId.RecallItemBagRemoveNotify)]
	public sealed class RecallItemBagRemoveNotify : IMessage<RecallItemBagRemoveNotify>, IMessage, IEquatable<RecallItemBagRemoveNotify>, IDeepCloneable<RecallItemBagRemoveNotify>, IBufferMessage
	{
		// Token: 0x060141C6 RID: 82374 RVA: 0x002EDC4F File Offset: 0x002EBE4F
		[NullableContext(1)]
		public static RecallItemBagRemoveNotify Create()
		{
			return new RecallItemBagRemoveNotify();
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x060141C7 RID: 82375 RVA: 0x002EDC56 File Offset: 0x002EBE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042EB RID: 17131
		// (get) Token: 0x060141C8 RID: 82376 RVA: 0x002EDC59 File Offset: 0x002EBE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagRemoveNotify.Descriptor;
			}
		}

		// Token: 0x060141C9 RID: 82377 RVA: 0x002EDC60 File Offset: 0x002EBE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify()
		{
		}

		// Token: 0x060141CA RID: 82378 RVA: 0x002EDC73 File Offset: 0x002EBE73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify(RecallItemBagRemoveNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060141CB RID: 82379 RVA: 0x002EDCA9 File Offset: 0x002EBEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagRemoveNotify Clone()
		{
			return new RecallItemBagRemoveNotify(this);
		}

		// Token: 0x170042EC RID: 17132
		// (get) Token: 0x060141CC RID: 82380 RVA: 0x002EDCB1 File Offset: 0x002EBEB1
		// (set) Token: 0x060141CD RID: 82381 RVA: 0x002EDCB9 File Offset: 0x002EBEB9
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

		// Token: 0x170042ED RID: 17133
		// (get) Token: 0x060141CE RID: 82382 RVA: 0x002EDCC2 File Offset: 0x002EBEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x060141CF RID: 82383 RVA: 0x002EDCCA File Offset: 0x002EBECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagRemoveNotify);
		}

		// Token: 0x060141D0 RID: 82384 RVA: 0x002EDCD8 File Offset: 0x002EBED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagRemoveNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060141D1 RID: 82385 RVA: 0x002EDD28 File Offset: 0x002EBF28
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

		// Token: 0x060141D2 RID: 82386 RVA: 0x002EDD75 File Offset: 0x002EBF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060141D3 RID: 82387 RVA: 0x002EDD82 File Offset: 0x002EBF82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060141D4 RID: 82388 RVA: 0x002EDD8C File Offset: 0x002EBF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RecallId);
			}
			this.itemIds_.WriteTo(ref output, RecallItemBagRemoveNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060141D5 RID: 82389 RVA: 0x002EDDDC File Offset: 0x002EBFDC
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

		// Token: 0x060141D6 RID: 82390 RVA: 0x002EDE30 File Offset: 0x002EC030
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

		// Token: 0x060141D7 RID: 82391 RVA: 0x002EDE7D File Offset: 0x002EC07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060141D8 RID: 82392 RVA: 0x002EDE88 File Offset: 0x002EC088
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
				if (num != 96U)
				{
					if (num != 120U && num != 122U)
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

		// Token: 0x04007AFC RID: 31484
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AFD RID: 31485
		public const int RecallIdFieldNumber = 12;

		// Token: 0x04007AFE RID: 31486
		private int recallId_;

		// Token: 0x04007AFF RID: 31487
		public const int ItemIdsFieldNumber = 15;

		// Token: 0x04007B00 RID: 31488
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04007B01 RID: 31489
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
