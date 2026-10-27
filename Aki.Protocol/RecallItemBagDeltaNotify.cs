using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAB RID: 3755
	[NetMessage(EMessageId.RecallItemBagDeltaNotify)]
	public sealed class RecallItemBagDeltaNotify : IMessage<RecallItemBagDeltaNotify>, IMessage, IEquatable<RecallItemBagDeltaNotify>, IDeepCloneable<RecallItemBagDeltaNotify>, IBufferMessage
	{
		// Token: 0x06014269 RID: 82537 RVA: 0x002EE994 File Offset: 0x002ECB94
		[NullableContext(1)]
		public static RecallItemBagDeltaNotify Create()
		{
			return new RecallItemBagDeltaNotify();
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x0601426A RID: 82538 RVA: 0x002EE99B File Offset: 0x002ECB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x0601426B RID: 82539 RVA: 0x002EE99E File Offset: 0x002ECB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagDeltaNotify.Descriptor;
			}
		}

		// Token: 0x0601426C RID: 82540 RVA: 0x002EE9A5 File Offset: 0x002ECBA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify()
		{
		}

		// Token: 0x0601426D RID: 82541 RVA: 0x002EE9B8 File Offset: 0x002ECBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify(RecallItemBagDeltaNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.items_ = other.items_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601426E RID: 82542 RVA: 0x002EEA05 File Offset: 0x002ECC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify Clone()
		{
			return new RecallItemBagDeltaNotify(this);
		}

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x0601426F RID: 82543 RVA: 0x002EEA0D File Offset: 0x002ECC0D
		// (set) Token: 0x06014270 RID: 82544 RVA: 0x002EEA15 File Offset: 0x002ECC15
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

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x06014271 RID: 82545 RVA: 0x002EEA1E File Offset: 0x002ECC1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x06014272 RID: 82546 RVA: 0x002EEA26 File Offset: 0x002ECC26
		// (set) Token: 0x06014273 RID: 82547 RVA: 0x002EEA2E File Offset: 0x002ECC2E
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

		// Token: 0x06014274 RID: 82548 RVA: 0x002EEA37 File Offset: 0x002ECC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagDeltaNotify);
		}

		// Token: 0x06014275 RID: 82549 RVA: 0x002EEA48 File Offset: 0x002ECC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagDeltaNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.items_.Equals(other.items_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014276 RID: 82550 RVA: 0x002EEAA8 File Offset: 0x002ECCA8
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

		// Token: 0x06014277 RID: 82551 RVA: 0x002EEB0E File Offset: 0x002ECD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014278 RID: 82552 RVA: 0x002EEB1B File Offset: 0x002ECD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014279 RID: 82553 RVA: 0x002EEB24 File Offset: 0x002ECD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, RecallItemBagDeltaNotify._repeated_items_codec);
			if (this.RecallId != 0)
			{
				output.WriteRawTag(32);
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

		// Token: 0x0601427A RID: 82554 RVA: 0x002EEB90 File Offset: 0x002ECD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			num += this.items_.CalculateSize(RecallItemBagDeltaNotify._repeated_items_codec);
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

		// Token: 0x0601427B RID: 82555 RVA: 0x002EEBFC File Offset: 0x002ECDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemBagDeltaNotify other)
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

		// Token: 0x0601427C RID: 82556 RVA: 0x002EEC5D File Offset: 0x002ECE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601427D RID: 82557 RVA: 0x002EEC68 File Offset: 0x002ECE68
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
				if (num != 26U)
				{
					if (num != 32U)
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
					this.items_.AddEntriesFrom(ref input, RecallItemBagDeltaNotify._repeated_items_codec);
				}
			}
		}

		// Token: 0x04007ABC RID: 31420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ABD RID: 31421
		public const int RecallIdFieldNumber = 4;

		// Token: 0x04007ABE RID: 31422
		private int recallId_;

		// Token: 0x04007ABF RID: 31423
		public const int ItemsFieldNumber = 3;

		// Token: 0x04007AC0 RID: 31424
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(26U, RecallItemBagItem.Parser);

		// Token: 0x04007AC1 RID: 31425
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();

		// Token: 0x04007AC2 RID: 31426
		public const int ReasonFieldNumber = 15;

		// Token: 0x04007AC3 RID: 31427
		private int reason_;
	}
}
