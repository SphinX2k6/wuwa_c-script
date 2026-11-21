using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E9B RID: 3739
	[NetMessage(EMessageId.RecallItemBagDeltaNotify)]
	public sealed class RecallItemBagDeltaNotify : IMessage<RecallItemBagDeltaNotify>, IMessage, IEquatable<RecallItemBagDeltaNotify>, IDeepCloneable<RecallItemBagDeltaNotify>, IBufferMessage
	{
		// Token: 0x06014184 RID: 82308 RVA: 0x002ED2E8 File Offset: 0x002EB4E8
		[NullableContext(1)]
		public static RecallItemBagDeltaNotify Create()
		{
			return new RecallItemBagDeltaNotify();
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x06014185 RID: 82309 RVA: 0x002ED2EF File Offset: 0x002EB4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042DC RID: 17116
		// (get) Token: 0x06014186 RID: 82310 RVA: 0x002ED2F2 File Offset: 0x002EB4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemBagDeltaNotify.Descriptor;
			}
		}

		// Token: 0x06014187 RID: 82311 RVA: 0x002ED2F9 File Offset: 0x002EB4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify()
		{
		}

		// Token: 0x06014188 RID: 82312 RVA: 0x002ED30C File Offset: 0x002EB50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify(RecallItemBagDeltaNotify other) : this()
		{
			this.recallId_ = other.recallId_;
			this.items_ = other.items_.Clone();
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014189 RID: 82313 RVA: 0x002ED359 File Offset: 0x002EB559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemBagDeltaNotify Clone()
		{
			return new RecallItemBagDeltaNotify(this);
		}

		// Token: 0x170042DD RID: 17117
		// (get) Token: 0x0601418A RID: 82314 RVA: 0x002ED361 File Offset: 0x002EB561
		// (set) Token: 0x0601418B RID: 82315 RVA: 0x002ED369 File Offset: 0x002EB569
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

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x0601418C RID: 82316 RVA: 0x002ED372 File Offset: 0x002EB572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallItemBagItem> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x0601418D RID: 82317 RVA: 0x002ED37A File Offset: 0x002EB57A
		// (set) Token: 0x0601418E RID: 82318 RVA: 0x002ED382 File Offset: 0x002EB582
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

		// Token: 0x0601418F RID: 82319 RVA: 0x002ED38B File Offset: 0x002EB58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemBagDeltaNotify);
		}

		// Token: 0x06014190 RID: 82320 RVA: 0x002ED39C File Offset: 0x002EB59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemBagDeltaNotify other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.items_.Equals(other.items_) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014191 RID: 82321 RVA: 0x002ED3FC File Offset: 0x002EB5FC
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

		// Token: 0x06014192 RID: 82322 RVA: 0x002ED462 File Offset: 0x002EB662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014193 RID: 82323 RVA: 0x002ED46F File Offset: 0x002EB66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014194 RID: 82324 RVA: 0x002ED478 File Offset: 0x002EB678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallId);
			}
			if (this.Reason != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Reason);
			}
			this.items_.WriteTo(ref output, RecallItemBagDeltaNotify._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014195 RID: 82325 RVA: 0x002ED4E4 File Offset: 0x002EB6E4
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

		// Token: 0x06014196 RID: 82326 RVA: 0x002ED550 File Offset: 0x002EB750
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

		// Token: 0x06014197 RID: 82327 RVA: 0x002ED5B1 File Offset: 0x002EB7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014198 RID: 82328 RVA: 0x002ED5BC File Offset: 0x002EB7BC
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						if (num != 82U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.items_.AddEntriesFrom(ref input, RecallItemBagDeltaNotify._repeated_items_codec);
						}
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
		}

		// Token: 0x04007AE6 RID: 31462
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AE7 RID: 31463
		public const int RecallIdFieldNumber = 2;

		// Token: 0x04007AE8 RID: 31464
		private int recallId_;

		// Token: 0x04007AE9 RID: 31465
		public const int ItemsFieldNumber = 10;

		// Token: 0x04007AEA RID: 31466
		private static readonly FieldCodec<RecallItemBagItem> _repeated_items_codec = FieldCodec.ForMessage<RecallItemBagItem>(82U, RecallItemBagItem.Parser);

		// Token: 0x04007AEB RID: 31467
		private readonly RepeatedField<RecallItemBagItem> items_ = new RepeatedField<RecallItemBagItem>();

		// Token: 0x04007AEC RID: 31468
		public const int ReasonFieldNumber = 6;

		// Token: 0x04007AED RID: 31469
		private int reason_;
	}
}
