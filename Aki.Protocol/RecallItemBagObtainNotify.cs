using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAD RID: 3757
	[NetMessage(EMessageId.RecallItemBagObtainNotify)]
	public sealed class RecallItemBagObtainNotify : IMessage<RecallItemBagObtainNotify>, IMessage, IEquatable<RecallItemBagObtainNotify>, IDeepCloneable<RecallItemBagObtainNotify>, IBufferMessage
	{
		// Token: 0x06014295 RID: 82581 RVA: 0x002EEFA3 File Offset: 0x002ED1A3
		[NullableContext(1)]
		public static RecallItemBagObtainNotify Create()
		{
			return new RecallItemBagObtainNotify();
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x06014296 RID: 82582 RVA: 0x002EEFAA File Offset: 0x002ED1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x06014297 RID: 82583 RVA: 0x002EEFAD File Offset: 0x002ED1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagObtainNotify.Descriptor;
			}
		}

		// Token: 0x06014298 RID: 82584 RVA: 0x002EEFB4 File Offset: 0x002ED1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify()
		{
		}

		// Token: 0x06014299 RID: 82585 RVA: 0x002EEFC8 File Offset: 0x002ED1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify(RecallItemBagObtainNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.items_ = other.items_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601429A RID: 82586 RVA: 0x002EF015 File Offset: 0x002ED215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagObtainNotify Clone()
		{
			return new RecallItemBagObtainNotify(this);
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0601429B RID: 82587 RVA: 0x002EF01D File Offset: 0x002ED21D
		// (set) Token: 0x0601429C RID: 82588 RVA: 0x002EF025 File Offset: 0x002ED225
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

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x0601429D RID: 82589 RVA: 0x002EF02E File Offset: 0x002ED22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0601429E RID: 82590 RVA: 0x002EF036 File Offset: 0x002ED236
		// (set) Token: 0x0601429F RID: 82591 RVA: 0x002EF03E File Offset: 0x002ED23E
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

		// Token: 0x060142A0 RID: 82592 RVA: 0x002EF047 File Offset: 0x002ED247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagObtainNotify);
		}

		// Token: 0x060142A1 RID: 82593 RVA: 0x002EF058 File Offset: 0x002ED258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagObtainNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.items_.Equals(other.items_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142A2 RID: 82594 RVA: 0x002EF0B8 File Offset: 0x002ED2B8
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

		// Token: 0x060142A3 RID: 82595 RVA: 0x002EF11E File Offset: 0x002ED31E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142A4 RID: 82596 RVA: 0x002EF12B File Offset: 0x002ED32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142A5 RID: 82597 RVA: 0x002EF134 File Offset: 0x002ED334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, RecallItemBagObtainNotify._repeated_items_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Reason);
			}
			if (this.RecallId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142A6 RID: 82598 RVA: 0x002EF1A0 File Offset: 0x002ED3A0
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

		// Token: 0x060142A7 RID: 82599 RVA: 0x002EF20C File Offset: 0x002ED40C
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

		// Token: 0x060142A8 RID: 82600 RVA: 0x002EF26D File Offset: 0x002ED46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142A9 RID: 82601 RVA: 0x002EF278 File Offset: 0x002ED478
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
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RecallId = input.ReadInt32();
						}
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, RecallItemBagObtainNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x04007ACA RID: 31434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ACB RID: 31435
		public const int RecallIdFieldNumber = 14;

		// Token: 0x04007ACC RID: 31436
		private int recallId_;

		// Token: 0x04007ACD RID: 31437
		public const int ItemsFieldNumber = 4;

		// Token: 0x04007ACE RID: 31438
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(34U, RecallItemBagItem.Parser);

		// Token: 0x04007ACF RID: 31439
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();

		// Token: 0x04007AD0 RID: 31440
		public const int ReasonFieldNumber = 5;

		// Token: 0x04007AD1 RID: 31441
		private int reason_;
	}
}
