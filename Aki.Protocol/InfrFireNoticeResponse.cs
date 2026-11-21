using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C6 RID: 1990
	[NetMessage(EMessageId.InfrFireNoticeResponse)]
	public sealed class InfrFireNoticeResponse : IMessage<InfrFireNoticeResponse>, IMessage, IEquatable<InfrFireNoticeResponse>, IDeepCloneable<InfrFireNoticeResponse>, IBufferMessage
	{
		// Token: 0x0600B330 RID: 45872 RVA: 0x001ACE7A File Offset: 0x001AB07A
		[NullableContext(1)]
		public static InfrFireNoticeResponse Create()
		{
			return new InfrFireNoticeResponse();
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600B331 RID: 45873 RVA: 0x001ACE81 File Offset: 0x001AB081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600B332 RID: 45874 RVA: 0x001ACE84 File Offset: 0x001AB084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireNoticeResponse.Descriptor;
			}
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x001ACE8B File Offset: 0x001AB08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse()
		{
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x001ACE9E File Offset: 0x001AB09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse(InfrFireNoticeResponse other) : this()
		{
			this.notices_ = other.notices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x001ACEC8 File Offset: 0x001AB0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse Clone()
		{
			return new InfrFireNoticeResponse(this);
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x001ACED0 File Offset: 0x001AB0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrNotice> Notices
		{
			get
			{
				return this.notices_;
			}
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x001ACED8 File Offset: 0x001AB0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireNoticeResponse);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x001ACEE6 File Offset: 0x001AB0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireNoticeResponse other)
		{
			return other != null && (other == this || (this.notices_.Equals(other.notices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x001ACF1C File Offset: 0x001AB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.notices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x001ACF50 File Offset: 0x001AB150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x001ACF5D File Offset: 0x001AB15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x001ACF66 File Offset: 0x001AB166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.notices_.WriteTo(ref output, InfrFireNoticeResponse._repeated_notices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x001ACF90 File Offset: 0x001AB190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.notices_.CalculateSize(InfrFireNoticeResponse._repeated_notices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x001ACFC9 File Offset: 0x001AB1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrFireNoticeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.notices_.Add(other.notices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x001ACFF7 File Offset: 0x001AB1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x001AD000 File Offset: 0x001AB200
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.notices_.AddEntriesFrom(ref input, InfrFireNoticeResponse._repeated_notices_codec);
				}
			}
		}

		// Token: 0x04005047 RID: 20551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005048 RID: 20552
		public const int NoticesFieldNumber = 6;

		// Token: 0x04005049 RID: 20553
		private static readonly FieldCodec<InfrNotice> _repeated_notices_codec = FieldCodec.ForMessage<InfrNotice>(50U, InfrNotice.Parser);

		// Token: 0x0400504A RID: 20554
		private readonly RepeatedField<InfrNotice> notices_ = new RepeatedField<InfrNotice>();
	}
}
