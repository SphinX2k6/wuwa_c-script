using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB2 RID: 3762
	[NetMessage(EMessageId.RecallQuestListNotify)]
	public sealed class RecallQuestListNotify : IMessage<RecallQuestListNotify>, IMessage, IEquatable<RecallQuestListNotify>, IDeepCloneable<RecallQuestListNotify>, IBufferMessage
	{
		// Token: 0x0601434C RID: 82764 RVA: 0x002F0C3F File Offset: 0x002EEE3F
		[NullableContext(1)]
		public static RecallQuestListNotify Create()
		{
			return new RecallQuestListNotify();
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0601434D RID: 82765 RVA: 0x002F0C46 File Offset: 0x002EEE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0601434E RID: 82766 RVA: 0x002F0C49 File Offset: 0x002EEE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestListNotify.Descriptor;
			}
		}

		// Token: 0x0601434F RID: 82767 RVA: 0x002F0C50 File Offset: 0x002EEE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify()
		{
		}

		// Token: 0x06014350 RID: 82768 RVA: 0x002F0C63 File Offset: 0x002EEE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify(RecallQuestListNotify other) : this()
		{
			this.recallQuestInfos_ = other.recallQuestInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014351 RID: 82769 RVA: 0x002F0C8D File Offset: 0x002EEE8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify Clone()
		{
			return new RecallQuestListNotify(this);
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x06014352 RID: 82770 RVA: 0x002F0C95 File Offset: 0x002EEE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallQuestInfo> RecallQuestInfos
		{
			get
			{
				return this.recallQuestInfos_;
			}
		}

		// Token: 0x06014353 RID: 82771 RVA: 0x002F0C9D File Offset: 0x002EEE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestListNotify);
		}

		// Token: 0x06014354 RID: 82772 RVA: 0x002F0CAB File Offset: 0x002EEEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestListNotify other)
		{
			return other != null && (other == this || (this.recallQuestInfos_.Equals(other.recallQuestInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014355 RID: 82773 RVA: 0x002F0CE0 File Offset: 0x002EEEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recallQuestInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014356 RID: 82774 RVA: 0x002F0D14 File Offset: 0x002EEF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014357 RID: 82775 RVA: 0x002F0D21 File Offset: 0x002EEF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014358 RID: 82776 RVA: 0x002F0D2A File Offset: 0x002EEF2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestInfos_.WriteTo(ref output, RecallQuestListNotify._repeated_recallQuestInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014359 RID: 82777 RVA: 0x002F0D54 File Offset: 0x002EEF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestInfos_.CalculateSize(RecallQuestListNotify._repeated_recallQuestInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601435A RID: 82778 RVA: 0x002F0D8D File Offset: 0x002EEF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestInfos_.Add(other.recallQuestInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601435B RID: 82779 RVA: 0x002F0DBB File Offset: 0x002EEFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601435C RID: 82780 RVA: 0x002F0DC4 File Offset: 0x002EEFC4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestInfos_.AddEntriesFrom(ref input, RecallQuestListNotify._repeated_recallQuestInfos_codec);
				}
			}
		}

		// Token: 0x04007B5C RID: 31580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B5D RID: 31581
		public const int RecallQuestInfosFieldNumber = 15;

		// Token: 0x04007B5E RID: 31582
		private static readonly FieldCodec<RecallQuestInfo> _repeated_recallQuestInfos_codec = FieldCodec.ForMessage<RecallQuestInfo>(122U, RecallQuestInfo.Parser);

		// Token: 0x04007B5F RID: 31583
		private readonly RepeatedField<RecallQuestInfo> recallQuestInfos_ = new RepeatedField<RecallQuestInfo>();
	}
}
