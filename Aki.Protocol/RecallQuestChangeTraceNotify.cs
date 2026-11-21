using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA8 RID: 3752
	[NetMessage(EMessageId.RecallQuestChangeTraceNotify)]
	public sealed class RecallQuestChangeTraceNotify : IMessage<RecallQuestChangeTraceNotify>, IMessage, IEquatable<RecallQuestChangeTraceNotify>, IDeepCloneable<RecallQuestChangeTraceNotify>, IBufferMessage
	{
		// Token: 0x0601428A RID: 82570 RVA: 0x002EF50C File Offset: 0x002ED70C
		[NullableContext(1)]
		public static RecallQuestChangeTraceNotify Create()
		{
			return new RecallQuestChangeTraceNotify();
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x0601428B RID: 82571 RVA: 0x002EF513 File Offset: 0x002ED713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0601428C RID: 82572 RVA: 0x002EF516 File Offset: 0x002ED716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestChangeTraceNotify.Descriptor;
			}
		}

		// Token: 0x0601428D RID: 82573 RVA: 0x002EF51D File Offset: 0x002ED71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify()
		{
		}

		// Token: 0x0601428E RID: 82574 RVA: 0x002EF530 File Offset: 0x002ED730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify(RecallQuestChangeTraceNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601428F RID: 82575 RVA: 0x002EF55A File Offset: 0x002ED75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestChangeTraceNotify Clone()
		{
			return new RecallQuestChangeTraceNotify(this);
		}

		// Token: 0x17004312 RID: 17170
		// (get) Token: 0x06014290 RID: 82576 RVA: 0x002EF562 File Offset: 0x002ED762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x06014291 RID: 82577 RVA: 0x002EF56A File Offset: 0x002ED76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestChangeTraceNotify);
		}

		// Token: 0x06014292 RID: 82578 RVA: 0x002EF578 File Offset: 0x002ED778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestChangeTraceNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014293 RID: 82579 RVA: 0x002EF5AC File Offset: 0x002ED7AC
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

		// Token: 0x06014294 RID: 82580 RVA: 0x002EF5E0 File Offset: 0x002ED7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014295 RID: 82581 RVA: 0x002EF5ED File Offset: 0x002ED7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014296 RID: 82582 RVA: 0x002EF5F6 File Offset: 0x002ED7F6
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

		// Token: 0x06014297 RID: 82583 RVA: 0x002EF620 File Offset: 0x002ED820
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

		// Token: 0x06014298 RID: 82584 RVA: 0x002EF659 File Offset: 0x002ED859
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

		// Token: 0x06014299 RID: 82585 RVA: 0x002EF687 File Offset: 0x002ED887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601429A RID: 82586 RVA: 0x002EF690 File Offset: 0x002ED890
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, RecallQuestChangeTraceNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x04007B2D RID: 31533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B2E RID: 31534
		public const int RecallQuestIdsFieldNumber = 6;

		// Token: 0x04007B2F RID: 31535
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007B30 RID: 31536
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
