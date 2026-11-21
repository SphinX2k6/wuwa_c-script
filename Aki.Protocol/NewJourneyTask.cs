using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B08 RID: 2824
	public sealed class NewJourneyTask : IMessage<NewJourneyTask>, IMessage, IEquatable<NewJourneyTask>, IDeepCloneable<NewJourneyTask>, IBufferMessage
	{
		// Token: 0x0600F590 RID: 62864 RVA: 0x0023D4DD File Offset: 0x0023B6DD
		[NullableContext(1)]
		public static NewJourneyTask Create()
		{
			return new NewJourneyTask();
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600F591 RID: 62865 RVA: 0x0023D4E4 File Offset: 0x0023B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewJourneyTask> Parser
		{
			get
			{
				return NewJourneyTask._parser;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600F592 RID: 62866 RVA: 0x0023D4EB File Offset: 0x0023B6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600F593 RID: 62867 RVA: 0x0023D4EE File Offset: 0x0023B6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewJourneyTask.Descriptor;
			}
		}

		// Token: 0x0600F594 RID: 62868 RVA: 0x0023D4F5 File Offset: 0x0023B6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask()
		{
		}

		// Token: 0x0600F595 RID: 62869 RVA: 0x0023D4FD File Offset: 0x0023B6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask(NewJourneyTask other) : this()
		{
			this.taskIdx_ = other.taskIdx_;
			this.canJump_ = other.canJump_;
			this.complete_ = other.complete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F596 RID: 62870 RVA: 0x0023D53A File Offset: 0x0023B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewJourneyTask Clone()
		{
			return new NewJourneyTask(this);
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600F597 RID: 62871 RVA: 0x0023D542 File Offset: 0x0023B742
		// (set) Token: 0x0600F598 RID: 62872 RVA: 0x0023D54A File Offset: 0x0023B74A
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

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600F599 RID: 62873 RVA: 0x0023D553 File Offset: 0x0023B753
		// (set) Token: 0x0600F59A RID: 62874 RVA: 0x0023D55B File Offset: 0x0023B75B
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

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0600F59B RID: 62875 RVA: 0x0023D564 File Offset: 0x0023B764
		// (set) Token: 0x0600F59C RID: 62876 RVA: 0x0023D56C File Offset: 0x0023B76C
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

		// Token: 0x0600F59D RID: 62877 RVA: 0x0023D575 File Offset: 0x0023B775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewJourneyTask);
		}

		// Token: 0x0600F59E RID: 62878 RVA: 0x0023D584 File Offset: 0x0023B784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewJourneyTask other)
		{
			return other != null && (other == this || (this.TaskIdx == other.TaskIdx && this.CanJump == other.CanJump && this.Complete == other.Complete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F59F RID: 62879 RVA: 0x0023D5E0 File Offset: 0x0023B7E0
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

		// Token: 0x0600F5A0 RID: 62880 RVA: 0x0023D651 File Offset: 0x0023B851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5A1 RID: 62881 RVA: 0x0023D65E File Offset: 0x0023B85E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x0023D668 File Offset: 0x0023B868
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

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0023D6DC File Offset: 0x0023B8DC
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

		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0023D734 File Offset: 0x0023B934
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

		// Token: 0x0600F5A5 RID: 62885 RVA: 0x0023D798 File Offset: 0x0023B998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5A6 RID: 62886 RVA: 0x0023D7A4 File Offset: 0x0023B9A4
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

		// Token: 0x0400630D RID: 25357
		private static readonly MessageParser<NewJourneyTask> _parser = new MessageParser<NewJourneyTask>(() => new NewJourneyTask());

		// Token: 0x0400630E RID: 25358
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400630F RID: 25359
		public const int TaskIdxFieldNumber = 1;

		// Token: 0x04006310 RID: 25360
		private int taskIdx_;

		// Token: 0x04006311 RID: 25361
		public const int CanJumpFieldNumber = 2;

		// Token: 0x04006312 RID: 25362
		private bool canJump_;

		// Token: 0x04006313 RID: 25363
		public const int CompleteFieldNumber = 3;

		// Token: 0x04006314 RID: 25364
		private bool complete_;
	}
}
