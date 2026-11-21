using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096C RID: 2412
	[NetMessage(EMessageId.MailInfosNotify)]
	public sealed class MailInfosNotify : IMessage<MailInfosNotify>, IMessage, IEquatable<MailInfosNotify>, IDeepCloneable<MailInfosNotify>, IBufferMessage
	{
		// Token: 0x0600D48C RID: 54412 RVA: 0x001F4C07 File Offset: 0x001F2E07
		[NullableContext(1)]
		public static MailInfosNotify Create()
		{
			return new MailInfosNotify();
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600D48D RID: 54413 RVA: 0x001F4C0E File Offset: 0x001F2E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x001F4C11 File Offset: 0x001F2E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailInfosNotify.Descriptor;
			}
		}

		// Token: 0x0600D48F RID: 54415 RVA: 0x001F4C18 File Offset: 0x001F2E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify()
		{
		}

		// Token: 0x0600D490 RID: 54416 RVA: 0x001F4C2B File Offset: 0x001F2E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify(MailInfosNotify other) : this()
		{
			this.mailInfos_ = other.mailInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D491 RID: 54417 RVA: 0x001F4C55 File Offset: 0x001F2E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify Clone()
		{
			return new MailInfosNotify(this);
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x001F4C5D File Offset: 0x001F2E5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbMailInfo> MailInfos
		{
			get
			{
				return this.mailInfos_;
			}
		}

		// Token: 0x0600D493 RID: 54419 RVA: 0x001F4C65 File Offset: 0x001F2E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailInfosNotify);
		}

		// Token: 0x0600D494 RID: 54420 RVA: 0x001F4C73 File Offset: 0x001F2E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailInfosNotify other)
		{
			return other != null && (other == this || (this.mailInfos_.Equals(other.mailInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D495 RID: 54421 RVA: 0x001F4CA8 File Offset: 0x001F2EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mailInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D496 RID: 54422 RVA: 0x001F4CDC File Offset: 0x001F2EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D497 RID: 54423 RVA: 0x001F4CE9 File Offset: 0x001F2EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x001F4CF2 File Offset: 0x001F2EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mailInfos_.WriteTo(ref output, MailInfosNotify._repeated_mailInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D499 RID: 54425 RVA: 0x001F4D1C File Offset: 0x001F2F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mailInfos_.CalculateSize(MailInfosNotify._repeated_mailInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D49A RID: 54426 RVA: 0x001F4D55 File Offset: 0x001F2F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailInfosNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mailInfos_.Add(other.mailInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D49B RID: 54427 RVA: 0x001F4D83 File Offset: 0x001F2F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x001F4D8C File Offset: 0x001F2F8C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mailInfos_.AddEntriesFrom(ref input, MailInfosNotify._repeated_mailInfos_codec);
				}
			}
		}

		// Token: 0x04005970 RID: 22896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005971 RID: 22897
		public const int MailInfosFieldNumber = 7;

		// Token: 0x04005972 RID: 22898
		private static readonly FieldCodec<PbMailInfo> _repeated_mailInfos_codec = FieldCodec.ForMessage<PbMailInfo>(58U, PbMailInfo.Parser);

		// Token: 0x04005973 RID: 22899
		private readonly RepeatedField<PbMailInfo> mailInfos_ = new RepeatedField<PbMailInfo>();
	}
}
