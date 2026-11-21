using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000821 RID: 2081
	[NetMessage(EMessageId.InteractQuestSuspendEntityNotify)]
	public sealed class InteractQuestSuspendEntityNotify : IMessage<InteractQuestSuspendEntityNotify>, IMessage, IEquatable<InteractQuestSuspendEntityNotify>, IDeepCloneable<InteractQuestSuspendEntityNotify>, IBufferMessage
	{
		// Token: 0x0600BA5E RID: 47710 RVA: 0x001BC584 File Offset: 0x001BA784
		[NullableContext(1)]
		public static InteractQuestSuspendEntityNotify Create()
		{
			return new InteractQuestSuspendEntityNotify();
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600BA5F RID: 47711 RVA: 0x001BC58B File Offset: 0x001BA78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600BA60 RID: 47712 RVA: 0x001BC58E File Offset: 0x001BA78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractQuestSuspendEntityNotify.Descriptor;
			}
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x001BC595 File Offset: 0x001BA795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify()
		{
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x001BC59D File Offset: 0x001BA79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify(InteractQuestSuspendEntityNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x001BC5CE File Offset: 0x001BA7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractQuestSuspendEntityNotify Clone()
		{
			return new InteractQuestSuspendEntityNotify(this);
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x001BC5D6 File Offset: 0x001BA7D6
		// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x001BC5DE File Offset: 0x001BA7DE
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

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x001BC5E7 File Offset: 0x001BA7E7
		// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x001BC5EF File Offset: 0x001BA7EF
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

		// Token: 0x0600BA68 RID: 47720 RVA: 0x001BC5F8 File Offset: 0x001BA7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractQuestSuspendEntityNotify);
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x001BC606 File Offset: 0x001BA806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractQuestSuspendEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x001BC644 File Offset: 0x001BA844
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

		// Token: 0x0600BA6B RID: 47723 RVA: 0x001BC69C File Offset: 0x001BA89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x001BC6A9 File Offset: 0x001BA8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x001BC6B4 File Offset: 0x001BA8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x001BC710 File Offset: 0x001BA910
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

		// Token: 0x0600BA6F RID: 47727 RVA: 0x001BC768 File Offset: 0x001BA968
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

		// Token: 0x0600BA70 RID: 47728 RVA: 0x001BC7B8 File Offset: 0x001BA9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA71 RID: 47729 RVA: 0x001BC7C4 File Offset: 0x001BA9C4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QuestId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005250 RID: 21072
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005251 RID: 21073
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04005252 RID: 21074
		private long entityId_;

		// Token: 0x04005253 RID: 21075
		public const int QuestIdFieldNumber = 9;

		// Token: 0x04005254 RID: 21076
		private int questId_;
	}
}
