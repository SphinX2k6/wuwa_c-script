using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092B RID: 2347
	[NetMessage(EMessageId.LinkExitNotify)]
	public sealed class LinkExitNotify : IMessage<LinkExitNotify>, IMessage, IEquatable<LinkExitNotify>, IDeepCloneable<LinkExitNotify>, IBufferMessage
	{
		// Token: 0x0600CEF7 RID: 52983 RVA: 0x001E7A35 File Offset: 0x001E5C35
		[NullableContext(1)]
		public static LinkExitNotify Create()
		{
			return new LinkExitNotify();
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600CEF8 RID: 52984 RVA: 0x001E7A3C File Offset: 0x001E5C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600CEF9 RID: 52985 RVA: 0x001E7A3F File Offset: 0x001E5C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkExitNotify.Descriptor;
			}
		}

		// Token: 0x0600CEFA RID: 52986 RVA: 0x001E7A46 File Offset: 0x001E5C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify()
		{
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x001E7A4E File Offset: 0x001E5C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify(LinkExitNotify other) : this()
		{
			this.reason_ = other.reason_;
			this.playerId_ = other.playerId_;
			this.step_ = other.step_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x001E7A8B File Offset: 0x001E5C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkExitNotify Clone()
		{
			return new LinkExitNotify(this);
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600CEFD RID: 52989 RVA: 0x001E7A93 File Offset: 0x001E5C93
		// (set) Token: 0x0600CEFE RID: 52990 RVA: 0x001E7A9B File Offset: 0x001E5C9B
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

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0600CEFF RID: 52991 RVA: 0x001E7AA4 File Offset: 0x001E5CA4
		// (set) Token: 0x0600CF00 RID: 52992 RVA: 0x001E7AAC File Offset: 0x001E5CAC
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

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600CF01 RID: 52993 RVA: 0x001E7AB5 File Offset: 0x001E5CB5
		// (set) Token: 0x0600CF02 RID: 52994 RVA: 0x001E7ABD File Offset: 0x001E5CBD
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

		// Token: 0x0600CF03 RID: 52995 RVA: 0x001E7AC6 File Offset: 0x001E5CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkExitNotify);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x001E7AD4 File Offset: 0x001E5CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkExitNotify other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.PlayerId == other.PlayerId && this.Step == other.Step && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x001E7B30 File Offset: 0x001E5D30
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

		// Token: 0x0600CF06 RID: 52998 RVA: 0x001E7BA7 File Offset: 0x001E5DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x001E7BB4 File Offset: 0x001E5DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF08 RID: 53000 RVA: 0x001E7BC0 File Offset: 0x001E5DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ELinkExitReason.LinkExitNormal)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Reason);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Step != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Step);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x001E7C38 File Offset: 0x001E5E38
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

		// Token: 0x0600CF0A RID: 53002 RVA: 0x001E7CA8 File Offset: 0x001E5EA8
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

		// Token: 0x0600CF0B RID: 53003 RVA: 0x001E7D0C File Offset: 0x001E5F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x001E7D18 File Offset: 0x001E5F18
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
				if (num != 16U)
				{
					if (num != 72U)
					{
						if (num != 88U)
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

		// Token: 0x04005762 RID: 22370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005763 RID: 22371
		public const int ReasonFieldNumber = 2;

		// Token: 0x04005764 RID: 22372
		private ELinkExitReason reason_;

		// Token: 0x04005765 RID: 22373
		public const int PlayerIdFieldNumber = 9;

		// Token: 0x04005766 RID: 22374
		private int playerId_;

		// Token: 0x04005767 RID: 22375
		public const int StepFieldNumber = 11;

		// Token: 0x04005768 RID: 22376
		private int step_;
	}
}
