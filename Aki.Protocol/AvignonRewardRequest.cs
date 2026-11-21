using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000132 RID: 306
	[NetMessage(EMessageId.AvignonRewardRequest)]
	public sealed class AvignonRewardRequest : IMessage<AvignonRewardRequest>, IMessage, IEquatable<AvignonRewardRequest>, IDeepCloneable<AvignonRewardRequest>, IBufferMessage
	{
		// Token: 0x0600288A RID: 10378 RVA: 0x0006AF27 File Offset: 0x00069127
		[NullableContext(1)]
		public static AvignonRewardRequest Create()
		{
			return new AvignonRewardRequest();
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x0006AF2E File Offset: 0x0006912E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x0006AF31 File Offset: 0x00069131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvignonRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0006AF38 File Offset: 0x00069138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest()
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0006AF40 File Offset: 0x00069140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest(AvignonRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0006AF71 File Offset: 0x00069171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvignonRewardRequest Clone()
		{
			return new AvignonRewardRequest(this);
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0006AF79 File Offset: 0x00069179
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x0006AF81 File Offset: 0x00069181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x0006AF8A File Offset: 0x0006918A
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x0006AF92 File Offset: 0x00069192
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

		// Token: 0x06002894 RID: 10388 RVA: 0x0006AF9B File Offset: 0x0006919B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvignonRewardRequest);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0006AFA9 File Offset: 0x000691A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvignonRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0006AFE8 File Offset: 0x000691E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0006B040 File Offset: 0x00069240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0006B04D File Offset: 0x0006924D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0006B058 File Offset: 0x00069258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TaskId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0006B0B4 File Offset: 0x000692B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0006B10C File Offset: 0x0006930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvignonRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0006B15C File Offset: 0x0006935C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0006B168 File Offset: 0x00069368
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
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002701 RID: 9985
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002702 RID: 9986
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04002703 RID: 9987
		private int activityId_;

		// Token: 0x04002704 RID: 9988
		public const int TaskIdFieldNumber = 7;

		// Token: 0x04002705 RID: 9989
		private int taskId_;
	}
}
