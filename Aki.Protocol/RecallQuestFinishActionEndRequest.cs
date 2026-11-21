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
	[NetMessage(EMessageId.RecallQuestFinishActionEndRequest)]
	public sealed class RecallQuestFinishActionEndRequest : IMessage<RecallQuestFinishActionEndRequest>, IMessage, IEquatable<RecallQuestFinishActionEndRequest>, IDeepCloneable<RecallQuestFinishActionEndRequest>, IBufferMessage
	{
		// Token: 0x060142C0 RID: 82624 RVA: 0x002EFA9C File Offset: 0x002EDC9C
		[NullableContext(1)]
		public static RecallQuestFinishActionEndRequest Create()
		{
			return new RecallQuestFinishActionEndRequest();
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x060142C1 RID: 82625 RVA: 0x002EFAA3 File Offset: 0x002EDCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x060142C2 RID: 82626 RVA: 0x002EFAA6 File Offset: 0x002EDCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionEndRequest.Descriptor;
			}
		}

		// Token: 0x060142C3 RID: 82627 RVA: 0x002EFAAD File Offset: 0x002EDCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest()
		{
		}

		// Token: 0x060142C4 RID: 82628 RVA: 0x002EFAC0 File Offset: 0x002EDCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest(RecallQuestFinishActionEndRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142C5 RID: 82629 RVA: 0x002EFAEA File Offset: 0x002EDCEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest Clone()
		{
			return new RecallQuestFinishActionEndRequest(this);
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x060142C6 RID: 82630 RVA: 0x002EFAF2 File Offset: 0x002EDCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
		}

		// Token: 0x060142C7 RID: 82631 RVA: 0x002EFAFA File Offset: 0x002EDCFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionEndRequest);
		}

		// Token: 0x060142C8 RID: 82632 RVA: 0x002EFB08 File Offset: 0x002EDD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionEndRequest other)
		{
			return other != null && (other == this || (this.recallQuestId_.Equals(other.recallQuestId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142C9 RID: 82633 RVA: 0x002EFB3C File Offset: 0x002EDD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.recallQuestId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060142CA RID: 82634 RVA: 0x002EFB70 File Offset: 0x002EDD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142CB RID: 82635 RVA: 0x002EFB7D File Offset: 0x002EDD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142CC RID: 82636 RVA: 0x002EFB86 File Offset: 0x002EDD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestId_.WriteTo(ref output, RecallQuestFinishActionEndRequest._repeated_recallQuestId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142CD RID: 82637 RVA: 0x002EFBB0 File Offset: 0x002EDDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestId_.CalculateSize(RecallQuestFinishActionEndRequest._repeated_recallQuestId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060142CE RID: 82638 RVA: 0x002EFBE9 File Offset: 0x002EDDE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestId_.Add(other.recallQuestId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060142CF RID: 82639 RVA: 0x002EFC17 File Offset: 0x002EDE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142D0 RID: 82640 RVA: 0x002EFC20 File Offset: 0x002EDE20
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestId_.AddEntriesFrom(ref input, RecallQuestFinishActionEndRequest._repeated_recallQuestId_codec);
				}
			}
		}

		// Token: 0x04007B37 RID: 31543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B38 RID: 31544
		public const int RecallQuestIdFieldNumber = 13;

		// Token: 0x04007B39 RID: 31545
		private static readonly FieldCodec<int> _repeated_recallQuestId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007B3A RID: 31546
		private readonly RepeatedField<int> recallQuestId_ = new RepeatedField<int>();
	}
}
