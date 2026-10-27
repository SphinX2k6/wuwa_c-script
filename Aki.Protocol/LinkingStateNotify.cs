using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092C RID: 2348
	[NetMessage(EMessageId.LinkingStateNotify)]
	public sealed class LinkingStateNotify : IMessage<LinkingStateNotify>, IMessage, IEquatable<LinkingStateNotify>, IDeepCloneable<LinkingStateNotify>, IBufferMessage
	{
		// Token: 0x0600CF0D RID: 53005 RVA: 0x001E7D83 File Offset: 0x001E5F83
		[NullableContext(1)]
		public static LinkingStateNotify Create()
		{
			return new LinkingStateNotify();
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600CF0E RID: 53006 RVA: 0x001E7D8A File Offset: 0x001E5F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x001E7D8D File Offset: 0x001E5F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkingStateNotify.Descriptor;
			}
		}

		// Token: 0x0600CF10 RID: 53008 RVA: 0x001E7D94 File Offset: 0x001E5F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkingStateNotify()
		{
		}

		// Token: 0x0600CF11 RID: 53009 RVA: 0x001E7D9C File Offset: 0x001E5F9C
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

		// Token: 0x0600CF12 RID: 53010 RVA: 0x001E7DF0 File Offset: 0x001E5FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkingStateNotify Clone()
		{
			return new LinkingStateNotify(this);
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0600CF13 RID: 53011 RVA: 0x001E7DF8 File Offset: 0x001E5FF8
		// (set) Token: 0x0600CF14 RID: 53012 RVA: 0x001E7E00 File Offset: 0x001E6000
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

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x001E7E09 File Offset: 0x001E6009
		// (set) Token: 0x0600CF16 RID: 53014 RVA: 0x001E7E11 File Offset: 0x001E6011
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

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600CF17 RID: 53015 RVA: 0x001E7E1A File Offset: 0x001E601A
		// (set) Token: 0x0600CF18 RID: 53016 RVA: 0x001E7E22 File Offset: 0x001E6022
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

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600CF19 RID: 53017 RVA: 0x001E7E2B File Offset: 0x001E602B
		// (set) Token: 0x0600CF1A RID: 53018 RVA: 0x001E7E33 File Offset: 0x001E6033
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

		// Token: 0x0600CF1B RID: 53019 RVA: 0x001E7E3C File Offset: 0x001E603C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkingStateNotify);
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x001E7E4C File Offset: 0x001E604C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkingStateNotify other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && this.PlayerId == other.PlayerId && this.Step == other.Step && this.TimeStamp == other.TimeStamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF1D RID: 53021 RVA: 0x001E7EB8 File Offset: 0x001E60B8
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

		// Token: 0x0600CF1E RID: 53022 RVA: 0x001E7F42 File Offset: 0x001E6142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x001E7F4F File Offset: 0x001E614F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x001E7F58 File Offset: 0x001E6158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Step != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Step);
			}
			if (this.TimeStamp != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TimeStamp);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x001E7FEC File Offset: 0x001E61EC
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

		// Token: 0x0600CF22 RID: 53026 RVA: 0x001E8074 File Offset: 0x001E6274
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

		// Token: 0x0600CF23 RID: 53027 RVA: 0x001E80EC File Offset: 0x001E62EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x001E80F8 File Offset: 0x001E62F8
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.Step = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.TimeStamp = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ContextId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005769 RID: 22377
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400576A RID: 22378
		public const int ContextIdFieldNumber = 13;

		// Token: 0x0400576B RID: 22379
		private long contextId_;

		// Token: 0x0400576C RID: 22380
		public const int PlayerIdFieldNumber = 11;

		// Token: 0x0400576D RID: 22381
		private int playerId_;

		// Token: 0x0400576E RID: 22382
		public const int StepFieldNumber = 5;

		// Token: 0x0400576F RID: 22383
		private int step_;

		// Token: 0x04005770 RID: 22384
		public const int TimeStampFieldNumber = 10;

		// Token: 0x04005771 RID: 22385
		private long timeStamp_;
	}
}
