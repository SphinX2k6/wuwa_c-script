using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000398 RID: 920
	public sealed class DangoMonopolyTaskData : IMessage<DangoMonopolyTaskData>, IMessage, IEquatable<DangoMonopolyTaskData>, IDeepCloneable<DangoMonopolyTaskData>, IBufferMessage
	{
		// Token: 0x06005B02 RID: 23298 RVA: 0x000DDAE8 File Offset: 0x000DBCE8
		[NullableContext(1)]
		public static DangoMonopolyTaskData Create()
		{
			return new DangoMonopolyTaskData();
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06005B03 RID: 23299 RVA: 0x000DDAEF File Offset: 0x000DBCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoMonopolyTaskData> Parser
		{
			get
			{
				return DangoMonopolyTaskData._parser;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x000DDAF6 File Offset: 0x000DBCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06005B05 RID: 23301 RVA: 0x000DDAF9 File Offset: 0x000DBCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskData.Descriptor;
			}
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x000DDB00 File Offset: 0x000DBD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData()
		{
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x000DDB08 File Offset: 0x000DBD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData(DangoMonopolyTaskData other) : this()
		{
			this.taskId_ = other.taskId_;
			this.state_ = other.state_;
			this.progress_ = other.progress_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x000DDB5C File Offset: 0x000DBD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskData Clone()
		{
			return new DangoMonopolyTaskData(this);
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06005B09 RID: 23305 RVA: 0x000DDB64 File Offset: 0x000DBD64
		// (set) Token: 0x06005B0A RID: 23306 RVA: 0x000DDB6C File Offset: 0x000DBD6C
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06005B0B RID: 23307 RVA: 0x000DDB75 File Offset: 0x000DBD75
		// (set) Token: 0x06005B0C RID: 23308 RVA: 0x000DDB7D File Offset: 0x000DBD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskState State
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06005B0D RID: 23309 RVA: 0x000DDB86 File Offset: 0x000DBD86
		// (set) Token: 0x06005B0E RID: 23310 RVA: 0x000DDB8E File Offset: 0x000DBD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x000DDB97 File Offset: 0x000DBD97
		// (set) Token: 0x06005B10 RID: 23312 RVA: 0x000DDB9F File Offset: 0x000DBD9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x000DDBA8 File Offset: 0x000DBDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskData);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x000DDBB8 File Offset: 0x000DBDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskData other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && this.State == other.State && this.Progress == other.Progress && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x000DDC24 File Offset: 0x000DBE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.Progress != 0)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x000DDCB4 File Offset: 0x000DBEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x000DDCC1 File Offset: 0x000DBEC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x000DDCCC File Offset: 0x000DBECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TaskId);
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.State);
			}
			if (this.Progress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Progress);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x000DDD5C File Offset: 0x000DBF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.State != DangoMonopolyTaskState.NotCompleted)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.Progress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Progress);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x000DDDE4 File Offset: 0x000DBFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.State != DangoMonopolyTaskState.NotCompleted)
			{
				this.State = other.State;
			}
			if (other.Progress != 0)
			{
				this.Progress = other.Progress;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x000DDE5C File Offset: 0x000DC05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x000DDE68 File Offset: 0x000DC068
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.TaskId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.State = (DangoMonopolyTaskState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Progress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003634 RID: 13876
		private static readonly MessageParser<DangoMonopolyTaskData> _parser = new MessageParser<DangoMonopolyTaskData>(() => new DangoMonopolyTaskData());

		// Token: 0x04003635 RID: 13877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003636 RID: 13878
		public const int TaskIdFieldNumber = 1;

		// Token: 0x04003637 RID: 13879
		private int taskId_;

		// Token: 0x04003638 RID: 13880
		public const int StateFieldNumber = 2;

		// Token: 0x04003639 RID: 13881
		private DangoMonopolyTaskState state_;

		// Token: 0x0400363A RID: 13882
		public const int ProgressFieldNumber = 3;

		// Token: 0x0400363B RID: 13883
		private int progress_;

		// Token: 0x0400363C RID: 13884
		public const int TargetFieldNumber = 4;

		// Token: 0x0400363D RID: 13885
		private int target_;
	}
}
