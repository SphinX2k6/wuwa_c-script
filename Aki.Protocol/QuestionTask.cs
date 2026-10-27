using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E19 RID: 3609
	public sealed class QuestionTask : IMessage<QuestionTask>, IMessage, IEquatable<QuestionTask>, IDeepCloneable<QuestionTask>, IBufferMessage
	{
		// Token: 0x06013639 RID: 79417 RVA: 0x002D1FDB File Offset: 0x002D01DB
		[NullableContext(1)]
		public static QuestionTask Create()
		{
			return new QuestionTask();
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x0601363A RID: 79418 RVA: 0x002D1FE2 File Offset: 0x002D01E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestionTask> Parser
		{
			get
			{
				return QuestionTask._parser;
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x0601363B RID: 79419 RVA: 0x002D1FE9 File Offset: 0x002D01E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x0601363C RID: 79420 RVA: 0x002D1FEC File Offset: 0x002D01EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestionTask.Descriptor;
			}
		}

		// Token: 0x0601363D RID: 79421 RVA: 0x002D1FF3 File Offset: 0x002D01F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask()
		{
		}

		// Token: 0x0601363E RID: 79422 RVA: 0x002D1FFB File Offset: 0x002D01FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask(QuestionTask other) : this()
		{
			this.id_ = other.id_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601363F RID: 79423 RVA: 0x002D202C File Offset: 0x002D022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestionTask Clone()
		{
			return new QuestionTask(this);
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x06013640 RID: 79424 RVA: 0x002D2034 File Offset: 0x002D0234
		// (set) Token: 0x06013641 RID: 79425 RVA: 0x002D203C File Offset: 0x002D023C
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

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x06013642 RID: 79426 RVA: 0x002D2045 File Offset: 0x002D0245
		// (set) Token: 0x06013643 RID: 79427 RVA: 0x002D204D File Offset: 0x002D024D
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

		// Token: 0x06013644 RID: 79428 RVA: 0x002D2056 File Offset: 0x002D0256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestionTask);
		}

		// Token: 0x06013645 RID: 79429 RVA: 0x002D2064 File Offset: 0x002D0264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestionTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013646 RID: 79430 RVA: 0x002D20A4 File Offset: 0x002D02A4
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

		// Token: 0x06013647 RID: 79431 RVA: 0x002D2102 File Offset: 0x002D0302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013648 RID: 79432 RVA: 0x002D210F File Offset: 0x002D030F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013649 RID: 79433 RVA: 0x002D2118 File Offset: 0x002D0318
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

		// Token: 0x0601364A RID: 79434 RVA: 0x002D2170 File Offset: 0x002D0370
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

		// Token: 0x0601364B RID: 79435 RVA: 0x002D21C8 File Offset: 0x002D03C8
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

		// Token: 0x0601364C RID: 79436 RVA: 0x002D2218 File Offset: 0x002D0418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601364D RID: 79437 RVA: 0x002D2224 File Offset: 0x002D0424
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

		// Token: 0x040076F8 RID: 30456
		private static readonly MessageParser<QuestionTask> _parser = new MessageParser<QuestionTask>(() => new QuestionTask());

		// Token: 0x040076F9 RID: 30457
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076FA RID: 30458
		public const int IdFieldNumber = 1;

		// Token: 0x040076FB RID: 30459
		private int id_;

		// Token: 0x040076FC RID: 30460
		public const int StatusFieldNumber = 2;

		// Token: 0x040076FD RID: 30461
		private ActivityTaskState status_;
	}
}
