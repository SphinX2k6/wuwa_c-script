using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E09 RID: 3593
	public sealed class QuestionTask : IMessage<QuestionTask>, IMessage, IEquatable<QuestionTask>, IDeepCloneable<QuestionTask>, IBufferMessage
	{
		// Token: 0x06013554 RID: 79188 RVA: 0x002D0917 File Offset: 0x002CEB17
		[NullableContext(1)]
		public static QuestionTask Create()
		{
			return new QuestionTask();
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x06013555 RID: 79189 RVA: 0x002D091E File Offset: 0x002CEB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestionTask> Parser
		{
			get
			{
				return QuestionTask._parser;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06013556 RID: 79190 RVA: 0x002D0925 File Offset: 0x002CEB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x06013557 RID: 79191 RVA: 0x002D0928 File Offset: 0x002CEB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestionTask.Descriptor;
			}
		}

		// Token: 0x06013558 RID: 79192 RVA: 0x002D092F File Offset: 0x002CEB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask()
		{
		}

		// Token: 0x06013559 RID: 79193 RVA: 0x002D0937 File Offset: 0x002CEB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask(QuestionTask other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601355A RID: 79194 RVA: 0x002D0968 File Offset: 0x002CEB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask Clone()
		{
			return new QuestionTask(this);
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x0601355B RID: 79195 RVA: 0x002D0970 File Offset: 0x002CEB70
		// (set) Token: 0x0601355C RID: 79196 RVA: 0x002D0978 File Offset: 0x002CEB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x0601355D RID: 79197 RVA: 0x002D0981 File Offset: 0x002CEB81
		// (set) Token: 0x0601355E RID: 79198 RVA: 0x002D0989 File Offset: 0x002CEB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601355F RID: 79199 RVA: 0x002D0992 File Offset: 0x002CEB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestionTask);
		}

		// Token: 0x06013560 RID: 79200 RVA: 0x002D09A0 File Offset: 0x002CEBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestionTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013561 RID: 79201 RVA: 0x002D09E0 File Offset: 0x002CEBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013562 RID: 79202 RVA: 0x002D0A3E File Offset: 0x002CEC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013563 RID: 79203 RVA: 0x002D0A4B File Offset: 0x002CEC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013564 RID: 79204 RVA: 0x002D0A54 File Offset: 0x002CEC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013565 RID: 79205 RVA: 0x002D0AAC File Offset: 0x002CECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Status != ActivityTaskState.ActivityTaskRunning)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013566 RID: 79206 RVA: 0x002D0B04 File Offset: 0x002CED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestionTask other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Status != ActivityTaskState.ActivityTaskRunning)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013567 RID: 79207 RVA: 0x002D0B54 File Offset: 0x002CED54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013568 RID: 79208 RVA: 0x002D0B60 File Offset: 0x002CED60
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
						this.Status = (ActivityTaskState)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007722 RID: 30498
		private static readonly MessageParser<QuestionTask> _parser = new MessageParser<QuestionTask>(() => new QuestionTask());

		// Token: 0x04007723 RID: 30499
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007724 RID: 30500
		public const int IdFieldNumber = 1;

		// Token: 0x04007725 RID: 30501
		private int id_;

		// Token: 0x04007726 RID: 30502
		public const int StatusFieldNumber = 2;

		// Token: 0x04007727 RID: 30503
		private ActivityTaskState status_;
	}
}
