using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000528 RID: 1320
	[NetMessage(EMessageId.FinishDownloadQuestResourceRequest)]
	public sealed class FinishDownloadQuestResourceRequest : IMessage<FinishDownloadQuestResourceRequest>, IMessage, IEquatable<FinishDownloadQuestResourceRequest>, IDeepCloneable<FinishDownloadQuestResourceRequest>, IBufferMessage
	{
		// Token: 0x06007C3B RID: 31803 RVA: 0x0012DBEE File Offset: 0x0012BDEE
		[NullableContext(1)]
		public static FinishDownloadQuestResourceRequest Create()
		{
			return new FinishDownloadQuestResourceRequest();
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06007C3C RID: 31804 RVA: 0x0012DBF5 File Offset: 0x0012BDF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x0012DBF8 File Offset: 0x0012BDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishDownloadQuestResourceRequest.Descriptor;
			}
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x0012DBFF File Offset: 0x0012BDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest()
		{
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x0012DC12 File Offset: 0x0012BE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest(FinishDownloadQuestResourceRequest other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x0012DC3C File Offset: 0x0012BE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest Clone()
		{
			return new FinishDownloadQuestResourceRequest(this);
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06007C41 RID: 31809 RVA: 0x0012DC44 File Offset: 0x0012BE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x0012DC4C File Offset: 0x0012BE4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishDownloadQuestResourceRequest);
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x0012DC5A File Offset: 0x0012BE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishDownloadQuestResourceRequest other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x0012DC90 File Offset: 0x0012BE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x0012DCC4 File Offset: 0x0012BEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x0012DCD1 File Offset: 0x0012BED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x0012DCDA File Offset: 0x0012BEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questIds_.WriteTo(ref output, FinishDownloadQuestResourceRequest._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x0012DD04 File Offset: 0x0012BF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questIds_.CalculateSize(FinishDownloadQuestResourceRequest._repeated_questIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x0012DD3D File Offset: 0x0012BF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishDownloadQuestResourceRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.questIds_.Add(other.questIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x0012DD6B File Offset: 0x0012BF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x0012DD74 File Offset: 0x0012BF74
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
				if (num != 64U && num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questIds_.AddEntriesFrom(ref input, FinishDownloadQuestResourceRequest._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x04003FDD RID: 16349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FDE RID: 16350
		public const int QuestIdsFieldNumber = 8;

		// Token: 0x04003FDF RID: 16351
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04003FE0 RID: 16352
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
