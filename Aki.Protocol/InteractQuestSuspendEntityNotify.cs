using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000835 RID: 2101
	[NetMessage(EMessageId.InteractQuestSuspendEntityNotify)]
	public sealed class InteractQuestSuspendEntityNotify : IMessage<InteractQuestSuspendEntityNotify>, IMessage, IEquatable<InteractQuestSuspendEntityNotify>, IDeepCloneable<InteractQuestSuspendEntityNotify>, IBufferMessage
	{
		// Token: 0x0600BBB4 RID: 48052 RVA: 0x001BEFC0 File Offset: 0x001BD1C0
		[NullableContext(1)]
		public static InteractQuestSuspendEntityNotify Create()
		{
			return new InteractQuestSuspendEntityNotify();
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x0600BBB5 RID: 48053 RVA: 0x001BEFC7 File Offset: 0x001BD1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x0600BBB6 RID: 48054 RVA: 0x001BEFCA File Offset: 0x001BD1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractQuestSuspendEntityNotify.Descriptor;
			}
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x001BEFD1 File Offset: 0x001BD1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify()
		{
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x001BEFD9 File Offset: 0x001BD1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify(InteractQuestSuspendEntityNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBB9 RID: 48057 RVA: 0x001BF00A File Offset: 0x001BD20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify Clone()
		{
			return new InteractQuestSuspendEntityNotify(this);
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x0600BBBA RID: 48058 RVA: 0x001BF012 File Offset: 0x001BD212
		// (set) Token: 0x0600BBBB RID: 48059 RVA: 0x001BF01A File Offset: 0x001BD21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x001BF023 File Offset: 0x001BD223
		// (set) Token: 0x0600BBBD RID: 48061 RVA: 0x001BF02B File Offset: 0x001BD22B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x001BF034 File Offset: 0x001BD234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractQuestSuspendEntityNotify);
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x001BF042 File Offset: 0x001BD242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractQuestSuspendEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x001BF080 File Offset: 0x001BD280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x001BF0D8 File Offset: 0x001BD2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x001BF0E5 File Offset: 0x001BD2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x001BF0F0 File Offset: 0x001BD2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QuestId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x001BF14C File Offset: 0x001BD34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x001BF1A4 File Offset: 0x001BD3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractQuestSuspendEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x001BF1F4 File Offset: 0x001BD3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x001BF200 File Offset: 0x001BD400
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
				if (num != 48U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005257 RID: 21079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005258 RID: 21080
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04005259 RID: 21081
		private long entityId_;

		// Token: 0x0400525A RID: 21082
		public const int QuestIdFieldNumber = 6;

		// Token: 0x0400525B RID: 21083
		private int questId_;
	}
}
