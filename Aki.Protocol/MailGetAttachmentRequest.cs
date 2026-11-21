using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096A RID: 2410
	[NetMessage(EMessageId.MailGetAttachmentRequest)]
	public sealed class MailGetAttachmentRequest : IMessage<MailGetAttachmentRequest>, IMessage, IEquatable<MailGetAttachmentRequest>, IDeepCloneable<MailGetAttachmentRequest>, IBufferMessage
	{
		// Token: 0x0600D466 RID: 54374 RVA: 0x001F4768 File Offset: 0x001F2968
		[NullableContext(1)]
		public static MailGetAttachmentRequest Create()
		{
			return new MailGetAttachmentRequest();
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x0600D467 RID: 54375 RVA: 0x001F476F File Offset: 0x001F296F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x0600D468 RID: 54376 RVA: 0x001F4772 File Offset: 0x001F2972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailGetAttachmentRequest.Descriptor;
			}
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x001F4779 File Offset: 0x001F2979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest()
		{
		}

		// Token: 0x0600D46A RID: 54378 RVA: 0x001F478C File Offset: 0x001F298C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest(MailGetAttachmentRequest other) : this()
		{
			this.mailIds_ = other.mailIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D46B RID: 54379 RVA: 0x001F47B6 File Offset: 0x001F29B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentRequest Clone()
		{
			return new MailGetAttachmentRequest(this);
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x0600D46C RID: 54380 RVA: 0x001F47BE File Offset: 0x001F29BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> MailIds
		{
			get
			{
				return this.mailIds_;
			}
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x001F47C6 File Offset: 0x001F29C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailGetAttachmentRequest);
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x001F47D4 File Offset: 0x001F29D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailGetAttachmentRequest other)
		{
			return other != null && (other == this || (this.mailIds_.Equals(other.mailIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x001F4808 File Offset: 0x001F2A08
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

		// Token: 0x0600D470 RID: 54384 RVA: 0x001F483C File Offset: 0x001F2A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x001F4849 File Offset: 0x001F2A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x001F4852 File Offset: 0x001F2A52
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

		// Token: 0x0600D473 RID: 54387 RVA: 0x001F487C File Offset: 0x001F2A7C
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

		// Token: 0x0600D474 RID: 54388 RVA: 0x001F48B5 File Offset: 0x001F2AB5
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

		// Token: 0x0600D475 RID: 54389 RVA: 0x001F48E3 File Offset: 0x001F2AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D476 RID: 54390 RVA: 0x001F48EC File Offset: 0x001F2AEC
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
					this.mailIds_.AddEntriesFrom(ref input, MailGetAttachmentRequest._repeated_mailIds_codec);
				}
			}
		}

		// Token: 0x04005966 RID: 22886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005967 RID: 22887
		public const int MailIdsFieldNumber = 1;

		// Token: 0x04005968 RID: 22888
		private static readonly FieldCodec<string> _repeated_mailIds_codec = FieldCodec.ForString(10U);

		// Token: 0x04005969 RID: 22889
		private readonly RepeatedField<string> mailIds_ = new RepeatedField<string>();
	}
}
