using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB8 RID: 3768
	[NetMessage(EMessageId.RecallQuestChangeTraceNotify)]
	public sealed class RecallQuestChangeTraceNotify : IMessage<RecallQuestChangeTraceNotify>, IMessage, IEquatable<RecallQuestChangeTraceNotify>, IDeepCloneable<RecallQuestChangeTraceNotify>, IBufferMessage
	{
		// Token: 0x0601436F RID: 82799 RVA: 0x002F0BBC File Offset: 0x002EEDBC
		[NullableContext(1)]
		public static RecallQuestChangeTraceNotify Create()
		{
			return new RecallQuestChangeTraceNotify();
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x06014370 RID: 82800 RVA: 0x002F0BC3 File Offset: 0x002EEDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x06014371 RID: 82801 RVA: 0x002F0BC6 File Offset: 0x002EEDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestChangeTraceNotify.Descriptor;
			}
		}

		// Token: 0x06014372 RID: 82802 RVA: 0x002F0BCD File Offset: 0x002EEDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify()
		{
		}

		// Token: 0x06014373 RID: 82803 RVA: 0x002F0BE0 File Offset: 0x002EEDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify(RecallQuestChangeTraceNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014374 RID: 82804 RVA: 0x002F0C0A File Offset: 0x002EEE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify Clone()
		{
			return new RecallQuestChangeTraceNotify(this);
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x06014375 RID: 82805 RVA: 0x002F0C12 File Offset: 0x002EEE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x06014376 RID: 82806 RVA: 0x002F0C1A File Offset: 0x002EEE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestChangeTraceNotify);
		}

		// Token: 0x06014377 RID: 82807 RVA: 0x002F0C28 File Offset: 0x002EEE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestChangeTraceNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014378 RID: 82808 RVA: 0x002F0C5C File Offset: 0x002EEE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recallQuestIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014379 RID: 82809 RVA: 0x002F0C90 File Offset: 0x002EEE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601437A RID: 82810 RVA: 0x002F0C9D File Offset: 0x002EEE9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601437B RID: 82811 RVA: 0x002F0CA6 File Offset: 0x002EEEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestIds_.WriteTo(ref output, RecallQuestChangeTraceNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601437C RID: 82812 RVA: 0x002F0CD0 File Offset: 0x002EEED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestIds_.CalculateSize(RecallQuestChangeTraceNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601437D RID: 82813 RVA: 0x002F0D09 File Offset: 0x002EEF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestChangeTraceNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestIds_.Add(other.recallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601437E RID: 82814 RVA: 0x002F0D37 File Offset: 0x002EEF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601437F RID: 82815 RVA: 0x002F0D40 File Offset: 0x002EEF40
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, RecallQuestChangeTraceNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x04007B03 RID: 31491
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B04 RID: 31492
		public const int RecallQuestIdsFieldNumber = 1;

		// Token: 0x04007B05 RID: 31493
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007B06 RID: 31494
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
