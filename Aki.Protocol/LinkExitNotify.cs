using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091A RID: 2330
	[NetMessage(EMessageId.LinkExitNotify)]
	public sealed class LinkExitNotify : IMessage<LinkExitNotify>, IMessage, IEquatable<LinkExitNotify>, IDeepCloneable<LinkExitNotify>, IBufferMessage
	{
		// Token: 0x0600CDDB RID: 52699 RVA: 0x001E5765 File Offset: 0x001E3965
		[NullableContext(1)]
		public static LinkExitNotify Create()
		{
			return new LinkExitNotify();
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x001E576C File Offset: 0x001E396C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600CDDD RID: 52701 RVA: 0x001E576F File Offset: 0x001E396F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkExitNotify.Descriptor;
			}
		}

		// Token: 0x0600CDDE RID: 52702 RVA: 0x001E5776 File Offset: 0x001E3976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify()
		{
		}

		// Token: 0x0600CDDF RID: 52703 RVA: 0x001E577E File Offset: 0x001E397E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify(LinkExitNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.playerId_ = other.playerId_;
			this.step_ = other.step_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDE0 RID: 52704 RVA: 0x001E57BB File Offset: 0x001E39BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify Clone()
		{
			return new LinkExitNotify(this);
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x0600CDE1 RID: 52705 RVA: 0x001E57C3 File Offset: 0x001E39C3
		// (set) Token: 0x0600CDE2 RID: 52706 RVA: 0x001E57CB File Offset: 0x001E39CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELinkExitReason Reason
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

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0600CDE3 RID: 52707 RVA: 0x001E57D4 File Offset: 0x001E39D4
		// (set) Token: 0x0600CDE4 RID: 52708 RVA: 0x001E57DC File Offset: 0x001E39DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600CDE5 RID: 52709 RVA: 0x001E57E5 File Offset: 0x001E39E5
		// (set) Token: 0x0600CDE6 RID: 52710 RVA: 0x001E57ED File Offset: 0x001E39ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Step
		{
			get
			{
				return this.step_;
			}
			set
			{
				this.step_ = value;
			}
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x001E57F6 File Offset: 0x001E39F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkExitNotify);
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x001E5804 File Offset: 0x001E3A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkExitNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.PlayerId == other.PlayerId && this.Step == other.Step && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDE9 RID: 52713 RVA: 0x001E5860 File Offset: 0x001E3A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != ELinkExitReason.LinkExitNormal)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Step != 0)
			{
				num ^= this.Step.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDEA RID: 52714 RVA: 0x001E58D7 File Offset: 0x001E3AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDEB RID: 52715 RVA: 0x001E58E4 File Offset: 0x001E3AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDEC RID: 52716 RVA: 0x001E58F0 File Offset: 0x001E3AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ELinkExitReason.LinkExitNormal)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Reason);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Step != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Step);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDED RID: 52717 RVA: 0x001E5964 File Offset: 0x001E3B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != ELinkExitReason.LinkExitNormal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Step != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Step);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDEE RID: 52718 RVA: 0x001E59D4 File Offset: 0x001E3BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkExitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != ELinkExitReason.LinkExitNormal)
			{
				this.Reason = other.Reason;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Step != 0)
			{
				this.Step = other.Step;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDEF RID: 52719 RVA: 0x001E5A38 File Offset: 0x001E3C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDF0 RID: 52720 RVA: 0x001E5A44 File Offset: 0x001E3C44
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
				if (num != 8U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Step = input.ReadInt32();
						}
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (ELinkExitReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005769 RID: 22377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400576A RID: 22378
		public const int ReasonFieldNumber = 1;

		// Token: 0x0400576B RID: 22379
		private ELinkExitReason reason_;

		// Token: 0x0400576C RID: 22380
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x0400576D RID: 22381
		private int playerId_;

		// Token: 0x0400576E RID: 22382
		public const int StepFieldNumber = 14;

		// Token: 0x0400576F RID: 22383
		private int step_;
	}
}
