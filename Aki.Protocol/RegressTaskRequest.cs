using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE7 RID: 3815
	[NetMessage(EMessageId.RegressTaskRequest)]
	public sealed class RegressTaskRequest : IMessage<RegressTaskRequest>, IMessage, IEquatable<RegressTaskRequest>, IDeepCloneable<RegressTaskRequest>, IBufferMessage
	{
		// Token: 0x06014722 RID: 83746 RVA: 0x002F896D File Offset: 0x002F6B6D
		[NullableContext(1)]
		public static RegressTaskRequest Create()
		{
			return new RegressTaskRequest();
		}

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x06014723 RID: 83747 RVA: 0x002F8974 File Offset: 0x002F6B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x06014724 RID: 83748 RVA: 0x002F8977 File Offset: 0x002F6B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressTaskRequest.Descriptor;
			}
		}

		// Token: 0x06014725 RID: 83749 RVA: 0x002F897E File Offset: 0x002F6B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest()
		{
		}

		// Token: 0x06014726 RID: 83750 RVA: 0x002F8986 File Offset: 0x002F6B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest(RegressTaskRequest other) : this()
		{
			this.rewardType_ = other.rewardType_;
			this.taskId_ = other.taskId_;
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014727 RID: 83751 RVA: 0x002F89C3 File Offset: 0x002F6BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressTaskRequest Clone()
		{
			return new RegressTaskRequest(this);
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x06014728 RID: 83752 RVA: 0x002F89CB File Offset: 0x002F6BCB
		// (set) Token: 0x06014729 RID: 83753 RVA: 0x002F89D3 File Offset: 0x002F6BD3
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

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x0601472A RID: 83754 RVA: 0x002F89DC File Offset: 0x002F6BDC
		// (set) Token: 0x0601472B RID: 83755 RVA: 0x002F89E4 File Offset: 0x002F6BE4
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

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x0601472C RID: 83756 RVA: 0x002F89ED File Offset: 0x002F6BED
		// (set) Token: 0x0601472D RID: 83757 RVA: 0x002F89F5 File Offset: 0x002F6BF5
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

		// Token: 0x0601472E RID: 83758 RVA: 0x002F89FE File Offset: 0x002F6BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressTaskRequest);
		}

		// Token: 0x0601472F RID: 83759 RVA: 0x002F8A0C File Offset: 0x002F6C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressTaskRequest other)
		{
			return other != null && (other == this || (this.RewardType == other.RewardType && this.TaskId == other.TaskId && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014730 RID: 83760 RVA: 0x002F8A68 File Offset: 0x002F6C68
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

		// Token: 0x06014731 RID: 83761 RVA: 0x002F8ADF File Offset: 0x002F6CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014732 RID: 83762 RVA: 0x002F8AEC File Offset: 0x002F6CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014733 RID: 83763 RVA: 0x002F8AF8 File Offset: 0x002F6CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RewardType != RegressTaskTypeEnum.TaskReward)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.RewardType);
			}
			if (this.TaskId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014734 RID: 83764 RVA: 0x002F8B70 File Offset: 0x002F6D70
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

		// Token: 0x06014735 RID: 83765 RVA: 0x002F8BE0 File Offset: 0x002F6DE0
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

		// Token: 0x06014736 RID: 83766 RVA: 0x002F8C44 File Offset: 0x002F6E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014737 RID: 83767 RVA: 0x002F8C50 File Offset: 0x002F6E50
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007C10 RID: 31760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C11 RID: 31761
		public const int RewardTypeFieldNumber = 7;

		// Token: 0x04007C12 RID: 31762
		private RegressTaskTypeEnum rewardType_;

		// Token: 0x04007C13 RID: 31763
		public const int TaskIdFieldNumber = 15;

		// Token: 0x04007C14 RID: 31764
		private int taskId_;

		// Token: 0x04007C15 RID: 31765
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04007C16 RID: 31766
		private int activityId_;
	}
}
