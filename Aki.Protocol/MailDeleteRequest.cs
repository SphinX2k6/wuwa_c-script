using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000977 RID: 2423
	[NetMessage(EMessageId.MailDeleteRequest)]
	public sealed class MailDeleteRequest : IMessage<MailDeleteRequest>, IMessage, IEquatable<MailDeleteRequest>, IDeepCloneable<MailDeleteRequest>, IBufferMessage
	{
		// Token: 0x0600D52E RID: 54574 RVA: 0x001F5DE0 File Offset: 0x001F3FE0
		[NullableContext(1)]
		public static MailDeleteRequest Create()
		{
			return new MailDeleteRequest();
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x0600D52F RID: 54575 RVA: 0x001F5DE7 File Offset: 0x001F3FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x0600D530 RID: 54576 RVA: 0x001F5DEA File Offset: 0x001F3FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteRequest.Descriptor;
			}
		}

		// Token: 0x0600D531 RID: 54577 RVA: 0x001F5DF1 File Offset: 0x001F3FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest()
		{
		}

		// Token: 0x0600D532 RID: 54578 RVA: 0x001F5E04 File Offset: 0x001F4004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest(MailDeleteRequest other) : this()
		{
			this.mailIds_ = other.mailIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D533 RID: 54579 RVA: 0x001F5E2E File Offset: 0x001F402E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteRequest Clone()
		{
			return new MailDeleteRequest(this);
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x001F5E36 File Offset: 0x001F4036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> MailIds
		{
			get
			{
				return this.mailIds_;
			}
		}

		// Token: 0x0600D535 RID: 54581 RVA: 0x001F5E3E File Offset: 0x001F403E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteRequest);
		}

		// Token: 0x0600D536 RID: 54582 RVA: 0x001F5E4C File Offset: 0x001F404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteRequest other)
		{
			return other != null && (other == this || (this.mailIds_.Equals(other.mailIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x001F5E80 File Offset: 0x001F4080
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

		// Token: 0x0600D538 RID: 54584 RVA: 0x001F5EB4 File Offset: 0x001F40B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D539 RID: 54585 RVA: 0x001F5EC1 File Offset: 0x001F40C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x001F5ECA File Offset: 0x001F40CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mailIds_.WriteTo(ref output, MailDeleteRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x001F5EF4 File Offset: 0x001F40F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mailIds_.CalculateSize(MailDeleteRequest._repeated_mailIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D53C RID: 54588 RVA: 0x001F5F2D File Offset: 0x001F412D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.mailIds_.Add(other.mailIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D53D RID: 54589 RVA: 0x001F5F5B File Offset: 0x001F415B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D53E RID: 54590 RVA: 0x001F5F64 File Offset: 0x001F4164
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mailIds_.AddEntriesFrom(ref input, MailDeleteRequest._repeated_mailIds_codec);
				}
			}
		}

		// Token: 0x04005945 RID: 22853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005946 RID: 22854
		public const int MailIdsFieldNumber = 9;

		// Token: 0x04005947 RID: 22855
		private static readonly FieldCodec<string> _repeated_mailIds_codec = FieldCodec.ForString(74U);

		// Token: 0x04005948 RID: 22856
		private readonly RepeatedField<string> mailIds_ = new RepeatedField<string>();
	}
}
