using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091B RID: 2331
	[NetMessage(EMessageId.LinkingStateNotify)]
	public sealed class LinkingStateNotify : IMessage<LinkingStateNotify>, IMessage, IEquatable<LinkingStateNotify>, IDeepCloneable<LinkingStateNotify>, IBufferMessage
	{
		// Token: 0x0600CDF1 RID: 52721 RVA: 0x001E5AAE File Offset: 0x001E3CAE
		[NullableContext(1)]
		public static LinkingStateNotify Create()
		{
			return new LinkingStateNotify();
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x001E5AB5 File Offset: 0x001E3CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600CDF3 RID: 52723 RVA: 0x001E5AB8 File Offset: 0x001E3CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkingStateNotify.Descriptor;
			}
		}

		// Token: 0x0600CDF4 RID: 52724 RVA: 0x001E5ABF File Offset: 0x001E3CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkingStateNotify()
		{
		}

		// Token: 0x0600CDF5 RID: 52725 RVA: 0x001E5AC8 File Offset: 0x001E3CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkingStateNotify(LinkingStateNotify other) : this()
		{
			this.contextId_ = other.contextId_;
			this.playerId_ = other.playerId_;
			this.step_ = other.step_;
			this.timeStamp_ = other.timeStamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDF6 RID: 52726 RVA: 0x001E5B1C File Offset: 0x001E3D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkingStateNotify Clone()
		{
			return new LinkingStateNotify(this);
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600CDF7 RID: 52727 RVA: 0x001E5B24 File Offset: 0x001E3D24
		// (set) Token: 0x0600CDF8 RID: 52728 RVA: 0x001E5B2C File Offset: 0x001E3D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600CDF9 RID: 52729 RVA: 0x001E5B35 File Offset: 0x001E3D35
		// (set) Token: 0x0600CDFA RID: 52730 RVA: 0x001E5B3D File Offset: 0x001E3D3D
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

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x001E5B46 File Offset: 0x001E3D46
		// (set) Token: 0x0600CDFC RID: 52732 RVA: 0x001E5B4E File Offset: 0x001E3D4E
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

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x001E5B57 File Offset: 0x001E3D57
		// (set) Token: 0x0600CDFE RID: 52734 RVA: 0x001E5B5F File Offset: 0x001E3D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TimeStamp
		{
			get
			{
				return this.timeStamp_;
			}
			set
			{
				this.timeStamp_ = value;
			}
		}

		// Token: 0x0600CDFF RID: 52735 RVA: 0x001E5B68 File Offset: 0x001E3D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkingStateNotify);
		}

		// Token: 0x0600CE00 RID: 52736 RVA: 0x001E5B78 File Offset: 0x001E3D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkingStateNotify other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && this.PlayerId == other.PlayerId && this.Step == other.Step && this.TimeStamp == other.TimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE01 RID: 52737 RVA: 0x001E5BE4 File Offset: 0x001E3DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Step != 0)
			{
				num ^= this.Step.GetHashCode();
			}
			if (this.TimeStamp != 0L)
			{
				num ^= this.TimeStamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CE02 RID: 52738 RVA: 0x001E5C6E File Offset: 0x001E3E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE03 RID: 52739 RVA: 0x001E5C7B File Offset: 0x001E3E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE04 RID: 52740 RVA: 0x001E5C84 File Offset: 0x001E3E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Step != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Step);
			}
			if (this.TimeStamp != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TimeStamp);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.ContextId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE05 RID: 52741 RVA: 0x001E5D18 File Offset: 0x001E3F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Step != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Step);
			}
			if (this.TimeStamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TimeStamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CE06 RID: 52742 RVA: 0x001E5DA0 File Offset: 0x001E3FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkingStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Step != 0)
			{
				this.Step = other.Step;
			}
			if (other.TimeStamp != 0L)
			{
				this.TimeStamp = other.TimeStamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CE07 RID: 52743 RVA: 0x001E5E18 File Offset: 0x001E4018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x001E5E24 File Offset: 0x001E4024
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
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.Step = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.TimeStamp = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.ContextId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005770 RID: 22384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005771 RID: 22385
		public const int ContextIdFieldNumber = 7;

		// Token: 0x04005772 RID: 22386
		private long contextId_;

		// Token: 0x04005773 RID: 22387
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x04005774 RID: 22388
		private int playerId_;

		// Token: 0x04005775 RID: 22389
		public const int StepFieldNumber = 4;

		// Token: 0x04005776 RID: 22390
		private int step_;

		// Token: 0x04005777 RID: 22391
		public const int TimeStampFieldNumber = 5;

		// Token: 0x04005778 RID: 22392
		private long timeStamp_;
	}
}
