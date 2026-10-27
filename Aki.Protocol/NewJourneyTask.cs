using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B19 RID: 2841
	public sealed class NewJourneyTask : IMessage<NewJourneyTask>, IMessage, IEquatable<NewJourneyTask>, IDeepCloneable<NewJourneyTask>, IBufferMessage
	{
		// Token: 0x0600F6AA RID: 63146 RVA: 0x0023F6F1 File Offset: 0x0023D8F1
		[NullableContext(1)]
		public static NewJourneyTask Create()
		{
			return new NewJourneyTask();
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600F6AB RID: 63147 RVA: 0x0023F6F8 File Offset: 0x0023D8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewJourneyTask> Parser
		{
			get
			{
				return NewJourneyTask._parser;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600F6AC RID: 63148 RVA: 0x0023F6FF File Offset: 0x0023D8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600F6AD RID: 63149 RVA: 0x0023F702 File Offset: 0x0023D902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyTask.Descriptor;
			}
		}

		// Token: 0x0600F6AE RID: 63150 RVA: 0x0023F709 File Offset: 0x0023D909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask()
		{
		}

		// Token: 0x0600F6AF RID: 63151 RVA: 0x0023F711 File Offset: 0x0023D911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask(NewJourneyTask other) : this()
		{
			this.taskIdx_ = other.taskIdx_;
			this.canJump_ = other.canJump_;
			this.complete_ = other.complete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x0023F74E File Offset: 0x0023D94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask Clone()
		{
			return new NewJourneyTask(this);
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600F6B1 RID: 63153 RVA: 0x0023F756 File Offset: 0x0023D956
		// (set) Token: 0x0600F6B2 RID: 63154 RVA: 0x0023F75E File Offset: 0x0023D95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskIdx
		{
			get
			{
				return this.taskIdx_;
			}
			set
			{
				this.taskIdx_ = value;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600F6B3 RID: 63155 RVA: 0x0023F767 File Offset: 0x0023D967
		// (set) Token: 0x0600F6B4 RID: 63156 RVA: 0x0023F76F File Offset: 0x0023D96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanJump
		{
			get
			{
				return this.canJump_;
			}
			set
			{
				this.canJump_ = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600F6B5 RID: 63157 RVA: 0x0023F778 File Offset: 0x0023D978
		// (set) Token: 0x0600F6B6 RID: 63158 RVA: 0x0023F780 File Offset: 0x0023D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Complete
		{
			get
			{
				return this.complete_;
			}
			set
			{
				this.complete_ = value;
			}
		}

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x0023F789 File Offset: 0x0023D989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyTask);
		}

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x0023F798 File Offset: 0x0023D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyTask other)
		{
			return other != null && (other == this || (this.TaskIdx == other.TaskIdx && this.CanJump == other.CanJump && this.Complete == other.Complete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x0023F7F4 File Offset: 0x0023D9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskIdx != 0)
			{
				num ^= this.TaskIdx.GetHashCode();
			}
			if (this.CanJump)
			{
				num ^= this.CanJump.GetHashCode();
			}
			if (this.Complete)
			{
				num ^= this.Complete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x0023F865 File Offset: 0x0023DA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x0023F872 File Offset: 0x0023DA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6BC RID: 63164 RVA: 0x0023F87C File Offset: 0x0023DA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskIdx != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskIdx);
			}
			if (this.CanJump)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.CanJump);
			}
			if (this.Complete)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Complete);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6BD RID: 63165 RVA: 0x0023F8F0 File Offset: 0x0023DAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskIdx != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskIdx);
			}
			if (this.CanJump)
			{
				num += 2;
			}
			if (this.Complete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F6BE RID: 63166 RVA: 0x0023F948 File Offset: 0x0023DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewJourneyTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskIdx != 0)
			{
				this.TaskIdx = other.TaskIdx;
			}
			if (other.CanJump)
			{
				this.CanJump = other.CanJump;
			}
			if (other.Complete)
			{
				this.Complete = other.Complete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F6BF RID: 63167 RVA: 0x0023F9AC File Offset: 0x0023DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Complete = input.ReadBool();
						}
					}
					else
					{
						this.CanJump = input.ReadBool();
					}
				}
				else
				{
					this.TaskIdx = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006304 RID: 25348
		private static readonly MessageParser<NewJourneyTask> _parser = new MessageParser<NewJourneyTask>(() => new NewJourneyTask());

		// Token: 0x04006305 RID: 25349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006306 RID: 25350
		public const int TaskIdxFieldNumber = 1;

		// Token: 0x04006307 RID: 25351
		private int taskIdx_;

		// Token: 0x04006308 RID: 25352
		public const int CanJumpFieldNumber = 2;

		// Token: 0x04006309 RID: 25353
		private bool canJump_;

		// Token: 0x0400630A RID: 25354
		public const int CompleteFieldNumber = 3;

		// Token: 0x0400630B RID: 25355
		private bool complete_;
	}
}
