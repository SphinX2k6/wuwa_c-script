using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001320 RID: 4896
	public sealed class TaskDoneInfo : IMessage<TaskDoneInfo>, IMessage, IEquatable<TaskDoneInfo>, IDeepCloneable<TaskDoneInfo>, IBufferMessage
	{
		// Token: 0x0601A04B RID: 106571 RVA: 0x003C7BA5 File Offset: 0x003C5DA5
		[NullableContext(1)]
		public static TaskDoneInfo Create()
		{
			return new TaskDoneInfo();
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x0601A04C RID: 106572 RVA: 0x003C7BAC File Offset: 0x003C5DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaskDoneInfo> Parser
		{
			get
			{
				return TaskDoneInfo._parser;
			}
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x0601A04D RID: 106573 RVA: 0x003C7BB3 File Offset: 0x003C5DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x0601A04E RID: 106574 RVA: 0x003C7BB6 File Offset: 0x003C5DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TaskDoneInfo.Descriptor;
			}
		}

		// Token: 0x0601A04F RID: 106575 RVA: 0x003C7BBD File Offset: 0x003C5DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo()
		{
		}

		// Token: 0x0601A050 RID: 106576 RVA: 0x003C7BC5 File Offset: 0x003C5DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo(TaskDoneInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A051 RID: 106577 RVA: 0x003C7BF6 File Offset: 0x003C5DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo Clone()
		{
			return new TaskDoneInfo(this);
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x0601A052 RID: 106578 RVA: 0x003C7BFE File Offset: 0x003C5DFE
		// (set) Token: 0x0601A053 RID: 106579 RVA: 0x003C7C06 File Offset: 0x003C5E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x0601A054 RID: 106580 RVA: 0x003C7C0F File Offset: 0x003C5E0F
		// (set) Token: 0x0601A055 RID: 106581 RVA: 0x003C7C17 File Offset: 0x003C5E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherTaskState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0601A056 RID: 106582 RVA: 0x003C7C20 File Offset: 0x003C5E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TaskDoneInfo);
		}

		// Token: 0x0601A057 RID: 106583 RVA: 0x003C7C2E File Offset: 0x003C5E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TaskDoneInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A058 RID: 106584 RVA: 0x003C7C6C File Offset: 0x003C5E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != GatherTaskState.Lock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A059 RID: 106585 RVA: 0x003C7CCA File Offset: 0x003C5ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A05A RID: 106586 RVA: 0x003C7CD7 File Offset: 0x003C5ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A05B RID: 106587 RVA: 0x003C7CE0 File Offset: 0x003C5EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != GatherTaskState.Lock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A05C RID: 106588 RVA: 0x003C7D38 File Offset: 0x003C5F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != GatherTaskState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A05D RID: 106589 RVA: 0x003C7D90 File Offset: 0x003C5F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TaskDoneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != GatherTaskState.Lock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A05E RID: 106590 RVA: 0x003C7DE0 File Offset: 0x003C5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A05F RID: 106591 RVA: 0x003C7DEC File Offset: 0x003C5FEC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = (GatherTaskState)input.ReadEnum();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009800 RID: 38912
		private static readonly MessageParser<TaskDoneInfo> _parser = new MessageParser<TaskDoneInfo>(() => new TaskDoneInfo());

		// Token: 0x04009801 RID: 38913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009802 RID: 38914
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04009803 RID: 38915
		private int taskId_;

		// Token: 0x04009804 RID: 38916
		public const int StateFieldNumber = 2;

		// Token: 0x04009805 RID: 38917
		private GatherTaskState state_;
	}
}
