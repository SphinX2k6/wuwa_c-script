using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAF RID: 3759
	[NetMessage(EMessageId.RecallQuestFinishListNotify)]
	public sealed class RecallQuestFinishListNotify : IMessage<RecallQuestFinishListNotify>, IMessage, IEquatable<RecallQuestFinishListNotify>, IDeepCloneable<RecallQuestFinishListNotify>, IBufferMessage
	{
		// Token: 0x0601430E RID: 82702 RVA: 0x002F0441 File Offset: 0x002EE641
		[NullableContext(1)]
		public static RecallQuestFinishListNotify Create()
		{
			return new RecallQuestFinishListNotify();
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x0601430F RID: 82703 RVA: 0x002F0448 File Offset: 0x002EE648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x06014310 RID: 82704 RVA: 0x002F044B File Offset: 0x002EE64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishListNotify.Descriptor;
			}
		}

		// Token: 0x06014311 RID: 82705 RVA: 0x002F0452 File Offset: 0x002EE652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify()
		{
		}

		// Token: 0x06014312 RID: 82706 RVA: 0x002F0465 File Offset: 0x002EE665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify(RecallQuestFinishListNotify other) : this()
		{
			this.recallQuestIds_ = other.recallQuestIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014313 RID: 82707 RVA: 0x002F048F File Offset: 0x002EE68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishListNotify Clone()
		{
			return new RecallQuestFinishListNotify(this);
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x06014314 RID: 82708 RVA: 0x002F0497 File Offset: 0x002EE697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RecallQuestIds
		{
			get
			{
				return this.recallQuestIds_;
			}
		}

		// Token: 0x06014315 RID: 82709 RVA: 0x002F049F File Offset: 0x002EE69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishListNotify);
		}

		// Token: 0x06014316 RID: 82710 RVA: 0x002F04AD File Offset: 0x002EE6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishListNotify other)
		{
			return other != null && (other == this || (this.recallQuestIds_.Equals(other.recallQuestIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014317 RID: 82711 RVA: 0x002F04E0 File Offset: 0x002EE6E0
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

		// Token: 0x06014318 RID: 82712 RVA: 0x002F0514 File Offset: 0x002EE714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014319 RID: 82713 RVA: 0x002F0521 File Offset: 0x002EE721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601431A RID: 82714 RVA: 0x002F052A File Offset: 0x002EE72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.recallQuestIds_.WriteTo(ref output, RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601431B RID: 82715 RVA: 0x002F0554 File Offset: 0x002EE754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.recallQuestIds_.CalculateSize(RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601431C RID: 82716 RVA: 0x002F058D File Offset: 0x002EE78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.recallQuestIds_.Add(other.recallQuestIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601431D RID: 82717 RVA: 0x002F05BB File Offset: 0x002EE7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601431E RID: 82718 RVA: 0x002F05C4 File Offset: 0x002EE7C4
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestIds_.AddEntriesFrom(ref input, RecallQuestFinishListNotify._repeated_recallQuestIds_codec);
				}
			}
		}

		// Token: 0x04007B4A RID: 31562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B4B RID: 31563
		public const int RecallQuestIdsFieldNumber = 9;

		// Token: 0x04007B4C RID: 31564
		private static readonly FieldCodec<int> _repeated_recallQuestIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007B4D RID: 31565
		private readonly RepeatedField<int> recallQuestIds_ = new RepeatedField<int>();
	}
}
