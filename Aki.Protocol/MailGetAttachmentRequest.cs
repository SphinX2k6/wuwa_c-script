using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097B RID: 2427
	[NetMessage(EMessageId.MailGetAttachmentRequest)]
	public sealed class MailGetAttachmentRequest : IMessage<MailGetAttachmentRequest>, IMessage, IEquatable<MailGetAttachmentRequest>, IDeepCloneable<MailGetAttachmentRequest>, IBufferMessage
	{
		// Token: 0x0600D580 RID: 54656 RVA: 0x001F6951 File Offset: 0x001F4B51
		[NullableContext(1)]
		public static MailGetAttachmentRequest Create()
		{
			return new MailGetAttachmentRequest();
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x0600D581 RID: 54657 RVA: 0x001F6958 File Offset: 0x001F4B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x0600D582 RID: 54658 RVA: 0x001F695B File Offset: 0x001F4B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailGetAttachmentRequest.Descriptor;
			}
		}

		// Token: 0x0600D583 RID: 54659 RVA: 0x001F6962 File Offset: 0x001F4B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest()
		{
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x001F6975 File Offset: 0x001F4B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest(MailGetAttachmentRequest other) : this()
		{
			this.mailIds_ = other.mailIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D585 RID: 54661 RVA: 0x001F699F File Offset: 0x001F4B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest Clone()
		{
			return new MailGetAttachmentRequest(this);
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x001F69A7 File Offset: 0x001F4BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> MailIds
		{
			get
			{
				return this.mailIds_;
			}
		}

		// Token: 0x0600D587 RID: 54663 RVA: 0x001F69AF File Offset: 0x001F4BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailGetAttachmentRequest);
		}

		// Token: 0x0600D588 RID: 54664 RVA: 0x001F69BD File Offset: 0x001F4BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailGetAttachmentRequest other)
		{
			return other != null && (other == this || (this.mailIds_.Equals(other.mailIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x001F69F0 File Offset: 0x001F4BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mailIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x001F6A24 File Offset: 0x001F4C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x001F6A31 File Offset: 0x001F4C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x001F6A3A File Offset: 0x001F4C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mailIds_.WriteTo(ref output, MailGetAttachmentRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D58D RID: 54669 RVA: 0x001F6A64 File Offset: 0x001F4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mailIds_.CalculateSize(MailGetAttachmentRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D58E RID: 54670 RVA: 0x001F6A9D File Offset: 0x001F4C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailGetAttachmentRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mailIds_.Add(other.mailIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D58F RID: 54671 RVA: 0x001F6ACB File Offset: 0x001F4CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D590 RID: 54672 RVA: 0x001F6AD4 File Offset: 0x001F4CD4
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
					this.mailIds_.AddEntriesFrom(ref input, MailGetAttachmentRequest._repeated_mailIds_codec);
				}
			}
		}

		// Token: 0x0400595D RID: 22877
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400595E RID: 22878
		public const int MailIdsFieldNumber = 6;

		// Token: 0x0400595F RID: 22879
		private static readonly FieldCodec<string> _repeated_mailIds_codec = FieldCodec.ForString(50U);

		// Token: 0x04005960 RID: 22880
		private readonly RepeatedField<string> mailIds_ = new RepeatedField<string>();
	}
}
