using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED7 RID: 3799
	[NetMessage(EMessageId.RegressTaskRequest)]
	public sealed class RegressTaskRequest : IMessage<RegressTaskRequest>, IMessage, IEquatable<RegressTaskRequest>, IDeepCloneable<RegressTaskRequest>, IBufferMessage
	{
		// Token: 0x0601463D RID: 83517 RVA: 0x002F72BC File Offset: 0x002F54BC
		[NullableContext(1)]
		public static RegressTaskRequest Create()
		{
			return new RegressTaskRequest();
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x0601463E RID: 83518 RVA: 0x002F72C3 File Offset: 0x002F54C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x0601463F RID: 83519 RVA: 0x002F72C6 File Offset: 0x002F54C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTaskRequest.Descriptor;
			}
		}

		// Token: 0x06014640 RID: 83520 RVA: 0x002F72CD File Offset: 0x002F54CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest()
		{
		}

		// Token: 0x06014641 RID: 83521 RVA: 0x002F72D5 File Offset: 0x002F54D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest(RegressTaskRequest other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.taskId_ = other.taskId_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014642 RID: 83522 RVA: 0x002F7312 File Offset: 0x002F5512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest Clone()
		{
			return new RegressTaskRequest(this);
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x06014643 RID: 83523 RVA: 0x002F731A File Offset: 0x002F551A
		// (set) Token: 0x06014644 RID: 83524 RVA: 0x002F7322 File Offset: 0x002F5522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskTypeEnum RewardType
		{
			get
			{
				return this.rewardType_;
			}
			set
			{
				this.rewardType_ = value;
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x06014645 RID: 83525 RVA: 0x002F732B File Offset: 0x002F552B
		// (set) Token: 0x06014646 RID: 83526 RVA: 0x002F7333 File Offset: 0x002F5533
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

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x06014647 RID: 83527 RVA: 0x002F733C File Offset: 0x002F553C
		// (set) Token: 0x06014648 RID: 83528 RVA: 0x002F7344 File Offset: 0x002F5544
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

		// Token: 0x06014649 RID: 83529 RVA: 0x002F734D File Offset: 0x002F554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTaskRequest);
		}

		// Token: 0x0601464A RID: 83530 RVA: 0x002F735C File Offset: 0x002F555C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTaskRequest other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.TaskId == other.TaskId && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601464B RID: 83531 RVA: 0x002F73B8 File Offset: 0x002F55B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardType != RegressTaskTypeEnum.TaskReward)
			{
				num ^= this.RewardType.GetHashCode();
			}
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601464C RID: 83532 RVA: 0x002F742F File Offset: 0x002F562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601464D RID: 83533 RVA: 0x002F743C File Offset: 0x002F563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601464E RID: 83534 RVA: 0x002F7448 File Offset: 0x002F5648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardType != RegressTaskTypeEnum.TaskReward)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.RewardType);
			}
			if (this.TaskId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TaskId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601464F RID: 83535 RVA: 0x002F74BC File Offset: 0x002F56BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardType != RegressTaskTypeEnum.TaskReward)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RewardType);
			}
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014650 RID: 83536 RVA: 0x002F752C File Offset: 0x002F572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardType != RegressTaskTypeEnum.TaskReward)
			{
				this.RewardType = other.RewardType;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014651 RID: 83537 RVA: 0x002F7590 File Offset: 0x002F5790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014652 RID: 83538 RVA: 0x002F759C File Offset: 0x002F579C
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
					if (num != 56U)
					{
						if (num != 64U)
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
				else
				{
					this.RewardType = (RegressTaskTypeEnum)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C3A RID: 31802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C3B RID: 31803
		public const int RewardTypeFieldNumber = 1;

		// Token: 0x04007C3C RID: 31804
		private RegressTaskTypeEnum rewardType_;

		// Token: 0x04007C3D RID: 31805
		public const int TaskIdFieldNumber = 7;

		// Token: 0x04007C3E RID: 31806
		private int taskId_;

		// Token: 0x04007C3F RID: 31807
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04007C40 RID: 31808
		private int activityId_;
	}
}
