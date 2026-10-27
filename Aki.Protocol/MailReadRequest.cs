using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097E RID: 2430
	[NetMessage(EMessageId.MailReadRequest)]
	public sealed class MailReadRequest : IMessage<MailReadRequest>, IMessage, IEquatable<MailReadRequest>, IDeepCloneable<MailReadRequest>, IBufferMessage
	{
		// Token: 0x0600D5B8 RID: 54712 RVA: 0x001F6FD1 File Offset: 0x001F51D1
		[NullableContext(1)]
		public static MailReadRequest Create()
		{
			return new MailReadRequest();
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x0600D5B9 RID: 54713 RVA: 0x001F6FD8 File Offset: 0x001F51D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x001F6FDB File Offset: 0x001F51DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailReadRequest.Descriptor;
			}
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x001F6FE2 File Offset: 0x001F51E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest()
		{
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x001F6FF5 File Offset: 0x001F51F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest(MailReadRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x001F701A File Offset: 0x001F521A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailReadRequest Clone()
		{
			return new MailReadRequest(this);
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x001F7022 File Offset: 0x001F5222
		// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x001F702A File Offset: 0x001F522A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D5C0 RID: 54720 RVA: 0x001F703D File Offset: 0x001F523D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailReadRequest);
		}

		// Token: 0x0600D5C1 RID: 54721 RVA: 0x001F704B File Offset: 0x001F524B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailReadRequest other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5C2 RID: 54722 RVA: 0x001F7080 File Offset: 0x001F5280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D5C3 RID: 54723 RVA: 0x001F70C1 File Offset: 0x001F52C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x001F70CE File Offset: 0x001F52CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x001F70D7 File Offset: 0x001F52D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x001F7110 File Offset: 0x001F5310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x001F7153 File Offset: 0x001F5353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailReadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x001F7189 File Offset: 0x001F5389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5C9 RID: 54729 RVA: 0x001F7194 File Offset: 0x001F5394
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
					this.Id = input.ReadString();
				}
			}
		}

		// Token: 0x0400596B RID: 22891
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400596C RID: 22892
		public const int IdFieldNumber = 9;

		// Token: 0x0400596D RID: 22893
		private string id_ = "";
	}
}
