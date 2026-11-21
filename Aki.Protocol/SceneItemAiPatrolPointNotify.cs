using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001198 RID: 4504
	[NetMessage(EMessageId.SceneItemAiPatrolPointNotify)]
	public sealed class SceneItemAiPatrolPointNotify : IMessage<SceneItemAiPatrolPointNotify>, IMessage, IEquatable<SceneItemAiPatrolPointNotify>, IDeepCloneable<SceneItemAiPatrolPointNotify>, IBufferMessage
	{
		// Token: 0x060180DE RID: 98526 RVA: 0x0038082E File Offset: 0x0037EA2E
		[NullableContext(1)]
		public static SceneItemAiPatrolPointNotify Create()
		{
			return new SceneItemAiPatrolPointNotify();
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x060180DF RID: 98527 RVA: 0x00380835 File Offset: 0x0037EA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x060180E0 RID: 98528 RVA: 0x00380838 File Offset: 0x0037EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemAiPatrolPointNotify.Descriptor;
			}
		}

		// Token: 0x060180E1 RID: 98529 RVA: 0x0038083F File Offset: 0x0037EA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify()
		{
		}

		// Token: 0x060180E2 RID: 98530 RVA: 0x00380847 File Offset: 0x0037EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify(SceneItemAiPatrolPointNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.patrolPointIndex_ = other.patrolPointIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060180E3 RID: 98531 RVA: 0x00380878 File Offset: 0x0037EA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemAiPatrolPointNotify Clone()
		{
			return new SceneItemAiPatrolPointNotify(this);
		}

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x060180E4 RID: 98532 RVA: 0x00380880 File Offset: 0x0037EA80
		// (set) Token: 0x060180E5 RID: 98533 RVA: 0x00380888 File Offset: 0x0037EA88
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

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x060180E6 RID: 98534 RVA: 0x00380891 File Offset: 0x0037EA91
		// (set) Token: 0x060180E7 RID: 98535 RVA: 0x00380899 File Offset: 0x0037EA99
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

		// Token: 0x060180E8 RID: 98536 RVA: 0x003808A2 File Offset: 0x0037EAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemAiPatrolPointNotify);
		}

		// Token: 0x060180E9 RID: 98537 RVA: 0x003808B0 File Offset: 0x0037EAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemAiPatrolPointNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PatrolPointIndex == other.PatrolPointIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060180EA RID: 98538 RVA: 0x003808F0 File Offset: 0x0037EAF0
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

		// Token: 0x060180EB RID: 98539 RVA: 0x00380948 File Offset: 0x0037EB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060180EC RID: 98540 RVA: 0x00380955 File Offset: 0x0037EB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060180ED RID: 98541 RVA: 0x00380960 File Offset: 0x0037EB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PatrolPointIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PatrolPointIndex);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060180EE RID: 98542 RVA: 0x003809BC File Offset: 0x0037EBBC
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

		// Token: 0x060180EF RID: 98543 RVA: 0x00380A14 File Offset: 0x0037EC14
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

		// Token: 0x060180F0 RID: 98544 RVA: 0x00380A64 File Offset: 0x0037EC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060180F1 RID: 98545 RVA: 0x00380A70 File Offset: 0x0037EC70
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
				if (num != 40U)
				{
					if (num != 64U)
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

		// Token: 0x04008F52 RID: 36690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F53 RID: 36691
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04008F54 RID: 36692
		private long entityId_;

		// Token: 0x04008F55 RID: 36693
		public const int PatrolPointIndexFieldNumber = 5;

		// Token: 0x04008F56 RID: 36694
		private int patrolPointIndex_;
	}
}
