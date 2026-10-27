using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBB RID: 3771
	[NetMessage(EMessageId.RecallQuestFinishActionEndRequest)]
	public sealed class RecallQuestFinishActionEndRequest : IMessage<RecallQuestFinishActionEndRequest>, IMessage, IEquatable<RecallQuestFinishActionEndRequest>, IDeepCloneable<RecallQuestFinishActionEndRequest>, IBufferMessage
	{
		// Token: 0x060143A5 RID: 82853 RVA: 0x002F114C File Offset: 0x002EF34C
		[NullableContext(1)]
		public static RecallQuestFinishActionEndRequest Create()
		{
			return new RecallQuestFinishActionEndRequest();
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x060143A6 RID: 82854 RVA: 0x002F1153 File Offset: 0x002EF353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x060143A7 RID: 82855 RVA: 0x002F1156 File Offset: 0x002EF356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionEndRequest.Descriptor;
			}
		}

		// Token: 0x060143A8 RID: 82856 RVA: 0x002F115D File Offset: 0x002EF35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest()
		{
		}

		// Token: 0x060143A9 RID: 82857 RVA: 0x002F1170 File Offset: 0x002EF370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest(RecallQuestFinishActionEndRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060143AA RID: 82858 RVA: 0x002F119A File Offset: 0x002EF39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionEndRequest Clone()
		{
			return new RecallQuestFinishActionEndRequest(this);
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x060143AB RID: 82859 RVA: 0x002F11A2 File Offset: 0x002EF3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
		}

		// Token: 0x060143AC RID: 82860 RVA: 0x002F11AA File Offset: 0x002EF3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionEndRequest);
		}

		// Token: 0x060143AD RID: 82861 RVA: 0x002F11B8 File Offset: 0x002EF3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionEndRequest other)
		{
			return other != null && (other == this || (this.recallQuestId_.Equals(other.recallQuestId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143AE RID: 82862 RVA: 0x002F11EC File Offset: 0x002EF3EC
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

		// Token: 0x060143AF RID: 82863 RVA: 0x002F1220 File Offset: 0x002EF420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143B0 RID: 82864 RVA: 0x002F122D File Offset: 0x002EF42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143B1 RID: 82865 RVA: 0x002F1236 File Offset: 0x002EF436
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

		// Token: 0x060143B2 RID: 82866 RVA: 0x002F1260 File Offset: 0x002EF460
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

		// Token: 0x060143B3 RID: 82867 RVA: 0x002F1299 File Offset: 0x002EF499
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

		// Token: 0x060143B4 RID: 82868 RVA: 0x002F12C7 File Offset: 0x002EF4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143B5 RID: 82869 RVA: 0x002F12D0 File Offset: 0x002EF4D0
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

		// Token: 0x04007B0D RID: 31501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B0E RID: 31502
		public const int RecallQuestIdFieldNumber = 13;

		// Token: 0x04007B0F RID: 31503
		private static readonly FieldCodec<int> _repeated_recallQuestId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007B10 RID: 31504
		private readonly RepeatedField<int> recallQuestId_ = new RepeatedField<int>();
	}
}
