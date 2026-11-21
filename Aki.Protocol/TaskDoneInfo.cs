using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138D RID: 5005
	public sealed class TaskDoneInfo : IMessage<TaskDoneInfo>, IMessage, IEquatable<TaskDoneInfo>, IDeepCloneable<TaskDoneInfo>, IBufferMessage
	{
		// Token: 0x0601AA5B RID: 109147 RVA: 0x003E1E5C File Offset: 0x003E005C
		[NullableContext(1)]
		public static TaskDoneInfo Create()
		{
			return new TaskDoneInfo();
		}

		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x0601AA5C RID: 109148 RVA: 0x003E1E63 File Offset: 0x003E0063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaskDoneInfo> Parser
		{
			get
			{
				return TaskDoneInfo._parser;
			}
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x0601AA5D RID: 109149 RVA: 0x003E1E6A File Offset: 0x003E006A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x0601AA5E RID: 109150 RVA: 0x003E1E6D File Offset: 0x003E006D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TaskDoneInfo.Descriptor;
			}
		}

		// Token: 0x0601AA5F RID: 109151 RVA: 0x003E1E74 File Offset: 0x003E0074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo()
		{
		}

		// Token: 0x0601AA60 RID: 109152 RVA: 0x003E1E7C File Offset: 0x003E007C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo(TaskDoneInfo other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA61 RID: 109153 RVA: 0x003E1EAD File Offset: 0x003E00AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaskDoneInfo Clone()
		{
			return new TaskDoneInfo(this);
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x0601AA62 RID: 109154 RVA: 0x003E1EB5 File Offset: 0x003E00B5
		// (set) Token: 0x0601AA63 RID: 109155 RVA: 0x003E1EBD File Offset: 0x003E00BD
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

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x0601AA64 RID: 109156 RVA: 0x003E1EC6 File Offset: 0x003E00C6
		// (set) Token: 0x0601AA65 RID: 109157 RVA: 0x003E1ECE File Offset: 0x003E00CE
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

		// Token: 0x0601AA66 RID: 109158 RVA: 0x003E1ED7 File Offset: 0x003E00D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TaskDoneInfo);
		}

		// Token: 0x0601AA67 RID: 109159 RVA: 0x003E1EE5 File Offset: 0x003E00E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TaskDoneInfo other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA68 RID: 109160 RVA: 0x003E1F24 File Offset: 0x003E0124
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

		// Token: 0x0601AA69 RID: 109161 RVA: 0x003E1F82 File Offset: 0x003E0182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA6A RID: 109162 RVA: 0x003E1F8F File Offset: 0x003E018F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA6B RID: 109163 RVA: 0x003E1F98 File Offset: 0x003E0198
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

		// Token: 0x0601AA6C RID: 109164 RVA: 0x003E1FF0 File Offset: 0x003E01F0
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

		// Token: 0x0601AA6D RID: 109165 RVA: 0x003E2048 File Offset: 0x003E0248
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

		// Token: 0x0601AA6E RID: 109166 RVA: 0x003E2098 File Offset: 0x003E0298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA6F RID: 109167 RVA: 0x003E20A4 File Offset: 0x003E02A4
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

		// Token: 0x04009C22 RID: 39970
		private static readonly MessageParser<TaskDoneInfo> _parser = new MessageParser<TaskDoneInfo>(() => new TaskDoneInfo());

		// Token: 0x04009C23 RID: 39971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C24 RID: 39972
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04009C25 RID: 39973
		private int taskId_;

		// Token: 0x04009C26 RID: 39974
		public const int StateFieldNumber = 2;

		// Token: 0x04009C27 RID: 39975
		private GatherTaskState state_;
	}
}
