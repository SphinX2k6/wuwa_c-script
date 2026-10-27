using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053D RID: 1341
	[NetMessage(EMessageId.FinishDownloadQuestResourceRequest)]
	public sealed class FinishDownloadQuestResourceRequest : IMessage<FinishDownloadQuestResourceRequest>, IMessage, IEquatable<FinishDownloadQuestResourceRequest>, IDeepCloneable<FinishDownloadQuestResourceRequest>, IBufferMessage
	{
		// Token: 0x06007DA3 RID: 32163 RVA: 0x001307F2 File Offset: 0x0012E9F2
		[NullableContext(1)]
		public static FinishDownloadQuestResourceRequest Create()
		{
			return new FinishDownloadQuestResourceRequest();
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06007DA4 RID: 32164 RVA: 0x001307F9 File Offset: 0x0012E9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x001307FC File Offset: 0x0012E9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishDownloadQuestResourceRequest.Descriptor;
			}
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x00130803 File Offset: 0x0012EA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest()
		{
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x00130816 File Offset: 0x0012EA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest(FinishDownloadQuestResourceRequest other) : this()
		{
			this.questIds_ = other.questIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x00130840 File Offset: 0x0012EA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishDownloadQuestResourceRequest Clone()
		{
			return new FinishDownloadQuestResourceRequest(this);
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x00130848 File Offset: 0x0012EA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestIds
		{
			get
			{
				return this.questIds_;
			}
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x00130850 File Offset: 0x0012EA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishDownloadQuestResourceRequest);
		}

		// Token: 0x06007DAB RID: 32171 RVA: 0x0013085E File Offset: 0x0012EA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishDownloadQuestResourceRequest other)
		{
			return other != null && (other == this || (this.questIds_.Equals(other.questIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DAC RID: 32172 RVA: 0x00130894 File Offset: 0x0012EA94
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

		// Token: 0x06007DAD RID: 32173 RVA: 0x001308C8 File Offset: 0x0012EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x001308D5 File Offset: 0x0012EAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x001308DE File Offset: 0x0012EADE
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

		// Token: 0x06007DB0 RID: 32176 RVA: 0x00130908 File Offset: 0x0012EB08
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

		// Token: 0x06007DB1 RID: 32177 RVA: 0x00130941 File Offset: 0x0012EB41
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

		// Token: 0x06007DB2 RID: 32178 RVA: 0x0013096F File Offset: 0x0012EB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DB3 RID: 32179 RVA: 0x00130978 File Offset: 0x0012EB78
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
					this.questIds_.AddEntriesFrom(ref input, FinishDownloadQuestResourceRequest._repeated_questIds_codec);
				}
			}
		}

		// Token: 0x04003FE7 RID: 16359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FE8 RID: 16360
		public const int QuestIdsFieldNumber = 6;

		// Token: 0x04003FE9 RID: 16361
		private static readonly FieldCodec<int> _repeated_questIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04003FEA RID: 16362
		private readonly RepeatedField<int> questIds_ = new RepeatedField<int>();
	}
}
