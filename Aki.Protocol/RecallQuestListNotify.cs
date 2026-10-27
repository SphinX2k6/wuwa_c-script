using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC2 RID: 3778
	[NetMessage(EMessageId.RecallQuestListNotify)]
	public sealed class RecallQuestListNotify : IMessage<RecallQuestListNotify>, IMessage, IEquatable<RecallQuestListNotify>, IDeepCloneable<RecallQuestListNotify>, IBufferMessage
	{
		// Token: 0x06014431 RID: 82993 RVA: 0x002F22EF File Offset: 0x002F04EF
		[NullableContext(1)]
		public static RecallQuestListNotify Create()
		{
			return new RecallQuestListNotify();
		}

		// Token: 0x1700435F RID: 17247
		// (get) Token: 0x06014432 RID: 82994 RVA: 0x002F22F6 File Offset: 0x002F04F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004360 RID: 17248
		// (get) Token: 0x06014433 RID: 82995 RVA: 0x002F22F9 File Offset: 0x002F04F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestListNotify.Descriptor;
			}
		}

		// Token: 0x06014434 RID: 82996 RVA: 0x002F2300 File Offset: 0x002F0500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify()
		{
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x002F2313 File Offset: 0x002F0513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify(RecallQuestListNotify other) : this()
		{
			this.recallQuestInfos_ = other.recallQuestInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x002F233D File Offset: 0x002F053D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestListNotify Clone()
		{
			return new RecallQuestListNotify(this);
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x06014437 RID: 82999 RVA: 0x002F2345 File Offset: 0x002F0545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecallQuestInfo> RecallQuestInfos
		{
			get
			{
				return this.recallQuestInfos_;
			}
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x002F234D File Offset: 0x002F054D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestListNotify);
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x002F235B File Offset: 0x002F055B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestListNotify other)
		{
			return other != null && (other == this || (this.recallQuestInfos_.Equals(other.recallQuestInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601443A RID: 83002 RVA: 0x002F2390 File Offset: 0x002F0590
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

		// Token: 0x0601443B RID: 83003 RVA: 0x002F23C4 File Offset: 0x002F05C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601443C RID: 83004 RVA: 0x002F23D1 File Offset: 0x002F05D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601443D RID: 83005 RVA: 0x002F23DA File Offset: 0x002F05DA
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

		// Token: 0x0601443E RID: 83006 RVA: 0x002F2404 File Offset: 0x002F0604
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

		// Token: 0x0601443F RID: 83007 RVA: 0x002F243D File Offset: 0x002F063D
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

		// Token: 0x06014440 RID: 83008 RVA: 0x002F246B File Offset: 0x002F066B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014441 RID: 83009 RVA: 0x002F2474 File Offset: 0x002F0674
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.recallQuestInfos_.AddEntriesFrom(ref input, RecallQuestListNotify._repeated_recallQuestInfos_codec);
				}
			}
		}

		// Token: 0x04007B32 RID: 31538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B33 RID: 31539
		public const int RecallQuestInfosFieldNumber = 13;

		// Token: 0x04007B34 RID: 31540
		private static readonly FieldCodec<RecallQuestInfo> _repeated_recallQuestInfos_codec = FieldCodec.ForMessage<RecallQuestInfo>(106U, RecallQuestInfo.Parser);

		// Token: 0x04007B35 RID: 31541
		private readonly RepeatedField<RecallQuestInfo> recallQuestInfos_ = new RepeatedField<RecallQuestInfo>();
	}
}
