using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097D RID: 2429
	[NetMessage(EMessageId.MailInfosNotify)]
	public sealed class MailInfosNotify : IMessage<MailInfosNotify>, IMessage, IEquatable<MailInfosNotify>, IDeepCloneable<MailInfosNotify>, IBufferMessage
	{
		// Token: 0x0600D5A6 RID: 54694 RVA: 0x001F6DEF File Offset: 0x001F4FEF
		[NullableContext(1)]
		public static MailInfosNotify Create()
		{
			return new MailInfosNotify();
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x001F6DF6 File Offset: 0x001F4FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x0600D5A8 RID: 54696 RVA: 0x001F6DF9 File Offset: 0x001F4FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailInfosNotify.Descriptor;
			}
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x001F6E00 File Offset: 0x001F5000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify()
		{
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x001F6E13 File Offset: 0x001F5013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify(MailInfosNotify other) : this()
		{
			this.mailInfos_ = other.mailInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x001F6E3D File Offset: 0x001F503D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailInfosNotify Clone()
		{
			return new MailInfosNotify(this);
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x001F6E45 File Offset: 0x001F5045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbMailInfo> MailInfos
		{
			get
			{
				return this.mailInfos_;
			}
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x001F6E4D File Offset: 0x001F504D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailInfosNotify);
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x001F6E5B File Offset: 0x001F505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailInfosNotify other)
		{
			return other != null && (other == this || (this.mailInfos_.Equals(other.mailInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x001F6E90 File Offset: 0x001F5090
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

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x001F6EC4 File Offset: 0x001F50C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x001F6ED1 File Offset: 0x001F50D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x001F6EDA File Offset: 0x001F50DA
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

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x001F6F04 File Offset: 0x001F5104
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

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x001F6F3D File Offset: 0x001F513D
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

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x001F6F6B File Offset: 0x001F516B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x001F6F74 File Offset: 0x001F5174
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mailInfos_.AddEntriesFrom(ref input, MailInfosNotify._repeated_mailInfos_codec);
				}
			}
		}

		// Token: 0x04005967 RID: 22887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005968 RID: 22888
		public const int MailInfosFieldNumber = 5;

		// Token: 0x04005969 RID: 22889
		private static readonly FieldCodec<PbMailInfo> _repeated_mailInfos_codec = FieldCodec.ForMessage<PbMailInfo>(42U, PbMailInfo.Parser);

		// Token: 0x0400596A RID: 22890
		private readonly RepeatedField<PbMailInfo> mailInfos_ = new RepeatedField<PbMailInfo>();
	}
}
