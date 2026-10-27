using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115E RID: 4446
	[NetMessage(EMessageId.SceneItemAiPatrolPointNotify)]
	public sealed class SceneItemAiPatrolPointNotify : IMessage<SceneItemAiPatrolPointNotify>, IMessage, IEquatable<SceneItemAiPatrolPointNotify>, IDeepCloneable<SceneItemAiPatrolPointNotify>, IBufferMessage
	{
		// Token: 0x06017B3D RID: 97085 RVA: 0x003714DE File Offset: 0x0036F6DE
		[NullableContext(1)]
		public static SceneItemAiPatrolPointNotify Create()
		{
			return new SceneItemAiPatrolPointNotify();
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x06017B3E RID: 97086 RVA: 0x003714E5 File Offset: 0x0036F6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x06017B3F RID: 97087 RVA: 0x003714E8 File Offset: 0x0036F6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiPatrolPointNotify.Descriptor;
			}
		}

		// Token: 0x06017B40 RID: 97088 RVA: 0x003714EF File Offset: 0x0036F6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify()
		{
		}

		// Token: 0x06017B41 RID: 97089 RVA: 0x003714F7 File Offset: 0x0036F6F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify(SceneItemAiPatrolPointNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.patrolPointIndex_ = other.patrolPointIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B42 RID: 97090 RVA: 0x00371528 File Offset: 0x0036F728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify Clone()
		{
			return new SceneItemAiPatrolPointNotify(this);
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x06017B43 RID: 97091 RVA: 0x00371530 File Offset: 0x0036F730
		// (set) Token: 0x06017B44 RID: 97092 RVA: 0x00371538 File Offset: 0x0036F738
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

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x06017B45 RID: 97093 RVA: 0x00371541 File Offset: 0x0036F741
		// (set) Token: 0x06017B46 RID: 97094 RVA: 0x00371549 File Offset: 0x0036F749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PatrolPointIndex
		{
			get
			{
				return this.patrolPointIndex_;
			}
			set
			{
				this.patrolPointIndex_ = value;
			}
		}

		// Token: 0x06017B47 RID: 97095 RVA: 0x00371552 File Offset: 0x0036F752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiPatrolPointNotify);
		}

		// Token: 0x06017B48 RID: 97096 RVA: 0x00371560 File Offset: 0x0036F760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiPatrolPointNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PatrolPointIndex == other.PatrolPointIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B49 RID: 97097 RVA: 0x003715A0 File Offset: 0x0036F7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PatrolPointIndex != 0)
			{
				num ^= this.PatrolPointIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B4A RID: 97098 RVA: 0x003715F8 File Offset: 0x0036F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B4B RID: 97099 RVA: 0x00371605 File Offset: 0x0036F805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B4C RID: 97100 RVA: 0x00371610 File Offset: 0x0036F810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PatrolPointIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PatrolPointIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B4D RID: 97101 RVA: 0x0037166C File Offset: 0x0036F86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PatrolPointIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PatrolPointIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B4E RID: 97102 RVA: 0x003716C4 File Offset: 0x0036F8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemAiPatrolPointNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PatrolPointIndex != 0)
			{
				this.PatrolPointIndex = other.PatrolPointIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B4F RID: 97103 RVA: 0x00371714 File Offset: 0x0036F914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B50 RID: 97104 RVA: 0x00371720 File Offset: 0x0036F920
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
				if (num != 64U)
				{
					if (num != 120U)
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
					this.PatrolPointIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008CBF RID: 36031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008CC0 RID: 36032
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04008CC1 RID: 36033
		private long entityId_;

		// Token: 0x04008CC2 RID: 36034
		public const int PatrolPointIndexFieldNumber = 8;

		// Token: 0x04008CC3 RID: 36035
		private int patrolPointIndex_;
	}
}
