using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096D RID: 2413
	[NetMessage(EMessageId.MailAddNotify)]
	public sealed class MailAddNotify : IMessage<MailAddNotify>, IMessage, IEquatable<MailAddNotify>, IDeepCloneable<MailAddNotify>, IBufferMessage
	{
		// Token: 0x0600D47A RID: 54394 RVA: 0x001F49DA File Offset: 0x001F2BDA
		[NullableContext(1)]
		public static MailAddNotify Create()
		{
			return new MailAddNotify();
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600D47B RID: 54395 RVA: 0x001F49E1 File Offset: 0x001F2BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600D47C RID: 54396 RVA: 0x001F49E4 File Offset: 0x001F2BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailAddNotify.Descriptor;
			}
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x001F49EB File Offset: 0x001F2BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify()
		{
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x001F49F4 File Offset: 0x001F2BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify(MailAddNotify other) : this()
		{
			this.newMail_ = ((other.newMail_ != null) ? other.newMail_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D47F RID: 54399 RVA: 0x001F4A40 File Offset: 0x001F2C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify Clone()
		{
			return new MailAddNotify(this);
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0600D480 RID: 54400 RVA: 0x001F4A48 File Offset: 0x001F2C48
		// (set) Token: 0x0600D481 RID: 54401 RVA: 0x001F4A50 File Offset: 0x001F2C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbMailInfo NewMail
		{
			get
			{
				return this.newMail_;
			}
			set
			{
				this.newMail_ = value;
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600D482 RID: 54402 RVA: 0x001F4A59 File Offset: 0x001F2C59
		// (set) Token: 0x0600D483 RID: 54403 RVA: 0x001F4A61 File Offset: 0x001F2C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x001F4A6A File Offset: 0x001F2C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailAddNotify);
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x001F4A78 File Offset: 0x001F2C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.NewMail, other.NewMail) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x001F4AC8 File Offset: 0x001F2CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.newMail_ != null)
			{
				num ^= this.NewMail.GetHashCode();
			}
			if (this.Reason != MailAddReason.Gm)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D487 RID: 54407 RVA: 0x001F4B23 File Offset: 0x001F2D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x001F4B30 File Offset: 0x001F2D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x001F4B3C File Offset: 0x001F2D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newMail_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.NewMail);
			}
			if (this.Reason != MailAddReason.Gm)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x001F4B98 File Offset: 0x001F2D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.newMail_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewMail);
			}
			if (this.Reason != MailAddReason.Gm)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D48B RID: 54411 RVA: 0x001F4BF0 File Offset: 0x001F2DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.newMail_ != null)
			{
				if (this.newMail_ == null)
				{
					this.NewMail = new PbMailInfo();
				}
				this.NewMail.MergeFrom(other.NewMail);
			}
			if (other.Reason != MailAddReason.Gm)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D48C RID: 54412 RVA: 0x001F4C58 File Offset: 0x001F2E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D48D RID: 54413 RVA: 0x001F4C64 File Offset: 0x001F2E64
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
				if (num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (MailAddReason)input.ReadEnum();
					}
				}
				else
				{
					if (this.newMail_ == null)
					{
						this.NewMail = new PbMailInfo();
					}
					input.ReadMessage(this.NewMail);
				}
			}
		}

		// Token: 0x04005927 RID: 22823
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005928 RID: 22824
		public const int NewMailFieldNumber = 4;

		// Token: 0x04005929 RID: 22825
		private PbMailInfo newMail_;

		// Token: 0x0400592A RID: 22826
		public const int ReasonFieldNumber = 13;

		// Token: 0x0400592B RID: 22827
		private MailAddReason reason_;
	}
}
