using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095C RID: 2396
	[NetMessage(EMessageId.MailAddNotify)]
	public sealed class MailAddNotify : IMessage<MailAddNotify>, IMessage, IEquatable<MailAddNotify>, IDeepCloneable<MailAddNotify>, IBufferMessage
	{
		// Token: 0x0600D360 RID: 54112 RVA: 0x001F27F2 File Offset: 0x001F09F2
		[NullableContext(1)]
		public static MailAddNotify Create()
		{
			return new MailAddNotify();
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600D361 RID: 54113 RVA: 0x001F27F9 File Offset: 0x001F09F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0600D362 RID: 54114 RVA: 0x001F27FC File Offset: 0x001F09FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailAddNotify.Descriptor;
			}
		}

		// Token: 0x0600D363 RID: 54115 RVA: 0x001F2803 File Offset: 0x001F0A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify()
		{
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x001F280C File Offset: 0x001F0A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify(MailAddNotify other) : this()
		{
			this.newMail_ = ((other.newMail_ != null) ? other.newMail_.Clone() : null);
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D365 RID: 54117 RVA: 0x001F2858 File Offset: 0x001F0A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailAddNotify Clone()
		{
			return new MailAddNotify(this);
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600D366 RID: 54118 RVA: 0x001F2860 File Offset: 0x001F0A60
		// (set) Token: 0x0600D367 RID: 54119 RVA: 0x001F2868 File Offset: 0x001F0A68
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

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0600D368 RID: 54120 RVA: 0x001F2871 File Offset: 0x001F0A71
		// (set) Token: 0x0600D369 RID: 54121 RVA: 0x001F2879 File Offset: 0x001F0A79
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

		// Token: 0x0600D36A RID: 54122 RVA: 0x001F2882 File Offset: 0x001F0A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailAddNotify);
		}

		// Token: 0x0600D36B RID: 54123 RVA: 0x001F2890 File Offset: 0x001F0A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.NewMail, other.NewMail) && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D36C RID: 54124 RVA: 0x001F28E0 File Offset: 0x001F0AE0
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

		// Token: 0x0600D36D RID: 54125 RVA: 0x001F293B File Offset: 0x001F0B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D36E RID: 54126 RVA: 0x001F2948 File Offset: 0x001F0B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x001F2954 File Offset: 0x001F0B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newMail_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NewMail);
			}
			if (this.Reason != MailAddReason.Gm)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x001F29B0 File Offset: 0x001F0BB0
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

		// Token: 0x0600D371 RID: 54129 RVA: 0x001F2A08 File Offset: 0x001F0C08
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

		// Token: 0x0600D372 RID: 54130 RVA: 0x001F2A70 File Offset: 0x001F0C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D373 RID: 54131 RVA: 0x001F2A7C File Offset: 0x001F0C7C
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
				if (num != 26U)
				{
					if (num != 56U)
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

		// Token: 0x04005930 RID: 22832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005931 RID: 22833
		public const int NewMailFieldNumber = 3;

		// Token: 0x04005932 RID: 22834
		private PbMailInfo newMail_;

		// Token: 0x04005933 RID: 22835
		public const int ReasonFieldNumber = 7;

		// Token: 0x04005934 RID: 22836
		private MailAddReason reason_;
	}
}
