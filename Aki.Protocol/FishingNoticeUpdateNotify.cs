using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200056D RID: 1389
	[NetMessage(EMessageId.FishingNoticeUpdateNotify)]
	public sealed class FishingNoticeUpdateNotify : IMessage<FishingNoticeUpdateNotify>, IMessage, IEquatable<FishingNoticeUpdateNotify>, IDeepCloneable<FishingNoticeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008162 RID: 33122 RVA: 0x00138A6D File Offset: 0x00136C6D
		[NullableContext(1)]
		public static FishingNoticeUpdateNotify Create()
		{
			return new FishingNoticeUpdateNotify();
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06008163 RID: 33123 RVA: 0x00138A74 File Offset: 0x00136C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x00138A77 File Offset: 0x00136C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingNoticeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x00138A7E File Offset: 0x00136C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify()
		{
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00138A9C File Offset: 0x00136C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify(FishingNoticeUpdateNotify other) : this()
		{
			this.noticeIds_ = other.noticeIds_.Clone();
			this.completeNoticeIds_ = other.completeNoticeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x00138AD7 File Offset: 0x00136CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingNoticeUpdateNotify Clone()
		{
			return new FishingNoticeUpdateNotify(this);
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x06008168 RID: 33128 RVA: 0x00138ADF File Offset: 0x00136CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NoticeIds
		{
			get
			{
				return this.noticeIds_;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06008169 RID: 33129 RVA: 0x00138AE7 File Offset: 0x00136CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompleteNoticeIds
		{
			get
			{
				return this.completeNoticeIds_;
			}
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x00138AEF File Offset: 0x00136CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingNoticeUpdateNotify);
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00138B00 File Offset: 0x00136D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingNoticeUpdateNotify other)
		{
			return other != null && (other == this || (this.noticeIds_.Equals(other.noticeIds_) && this.completeNoticeIds_.Equals(other.completeNoticeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00138B54 File Offset: 0x00136D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.noticeIds_.GetHashCode();
			num ^= this.completeNoticeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00138B96 File Offset: 0x00136D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00138BA3 File Offset: 0x00136DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x00138BAC File Offset: 0x00136DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.completeNoticeIds_.WriteTo(ref output, FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
			this.noticeIds_.WriteTo(ref output, FishingNoticeUpdateNotify._repeated_noticeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00138BE4 File Offset: 0x00136DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.noticeIds_.CalculateSize(FishingNoticeUpdateNotify._repeated_noticeIds_codec);
			num += this.completeNoticeIds_.CalculateSize(FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x00138C30 File Offset: 0x00136E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingNoticeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.noticeIds_.Add(other.noticeIds_);
			this.completeNoticeIds_.Add(other.completeNoticeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x00138C6F File Offset: 0x00136E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x00138C78 File Offset: 0x00136E78
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
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.completeNoticeIds_.AddEntriesFrom(ref input, FishingNoticeUpdateNotify._repeated_completeNoticeIds_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.noticeIds_.AddEntriesFrom(ref input, FishingNoticeUpdateNotify._repeated_noticeIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004100 RID: 16640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004101 RID: 16641
		public const int NoticeIdsFieldNumber = 15;

		// Token: 0x04004102 RID: 16642
		private static readonly FieldCodec<int> _repeated_noticeIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04004103 RID: 16643
		private readonly RepeatedField<int> noticeIds_ = new RepeatedField<int>();

		// Token: 0x04004104 RID: 16644
		public const int CompleteNoticeIdsFieldNumber = 4;

		// Token: 0x04004105 RID: 16645
		private static readonly FieldCodec<int> _repeated_completeNoticeIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004106 RID: 16646
		private readonly RepeatedField<int> completeNoticeIds_ = new RepeatedField<int>();
	}
}
