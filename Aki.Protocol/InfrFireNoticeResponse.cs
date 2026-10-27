using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007DA RID: 2010
	[NetMessage(EMessageId.InfrFireNoticeResponse)]
	public sealed class InfrFireNoticeResponse : IMessage<InfrFireNoticeResponse>, IMessage, IEquatable<InfrFireNoticeResponse>, IDeepCloneable<InfrFireNoticeResponse>, IBufferMessage
	{
		// Token: 0x0600B486 RID: 46214 RVA: 0x001AF8AE File Offset: 0x001ADAAE
		[NullableContext(1)]
		public static InfrFireNoticeResponse Create()
		{
			return new InfrFireNoticeResponse();
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600B487 RID: 46215 RVA: 0x001AF8B5 File Offset: 0x001ADAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600B488 RID: 46216 RVA: 0x001AF8B8 File Offset: 0x001ADAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrFireNoticeResponse.Descriptor;
			}
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x001AF8BF File Offset: 0x001ADABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse()
		{
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x001AF8D2 File Offset: 0x001ADAD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse(InfrFireNoticeResponse other) : this()
		{
			this.notices_ = other.notices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x001AF8FC File Offset: 0x001ADAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrFireNoticeResponse Clone()
		{
			return new InfrFireNoticeResponse(this);
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600B48C RID: 46220 RVA: 0x001AF904 File Offset: 0x001ADB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InfrNotice> Notices
		{
			get
			{
				return this.notices_;
			}
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x001AF90C File Offset: 0x001ADB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrFireNoticeResponse);
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x001AF91A File Offset: 0x001ADB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrFireNoticeResponse other)
		{
			return other != null && (other == this || (this.notices_.Equals(other.notices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x001AF950 File Offset: 0x001ADB50
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

		// Token: 0x0600B490 RID: 46224 RVA: 0x001AF984 File Offset: 0x001ADB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x001AF991 File Offset: 0x001ADB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x001AF99A File Offset: 0x001ADB9A
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

		// Token: 0x0600B493 RID: 46227 RVA: 0x001AF9C4 File Offset: 0x001ADBC4
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

		// Token: 0x0600B494 RID: 46228 RVA: 0x001AF9FD File Offset: 0x001ADBFD
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

		// Token: 0x0600B495 RID: 46229 RVA: 0x001AFA2B File Offset: 0x001ADC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x001AFA34 File Offset: 0x001ADC34
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.notices_.AddEntriesFrom(ref input, InfrFireNoticeResponse._repeated_notices_codec);
				}
			}
		}

		// Token: 0x0400504E RID: 20558
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400504F RID: 20559
		public const int NoticesFieldNumber = 1;

		// Token: 0x04005050 RID: 20560
		private static readonly FieldCodec<InfrNotice> _repeated_notices_codec = FieldCodec.ForMessage<InfrNotice>(10U, InfrNotice.Parser);

		// Token: 0x04005051 RID: 20561
		private readonly RepeatedField<InfrNotice> notices_ = new RepeatedField<InfrNotice>();
	}
}
