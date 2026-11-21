using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EE RID: 750
	[NetMessage(EMessageId.ConsumptiveRewardResponse)]
	public sealed class ConsumptiveRewardResponse : IMessage<ConsumptiveRewardResponse>, IMessage, IEquatable<ConsumptiveRewardResponse>, IDeepCloneable<ConsumptiveRewardResponse>, IBufferMessage
	{
		// Token: 0x06004C66 RID: 19558 RVA: 0x000BA470 File Offset: 0x000B8670
		[NullableContext(1)]
		public static ConsumptiveRewardResponse Create()
		{
			return new ConsumptiveRewardResponse();
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x000BA477 File Offset: 0x000B8677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x000BA47A File Offset: 0x000B867A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x000BA481 File Offset: 0x000B8681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse()
		{
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x000BA494 File Offset: 0x000B8694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse(ConsumptiveRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskInfo_ = ((other.taskInfo_ != null) ? other.taskInfo_.Clone() : null);
			this.taskInfos_ = other.taskInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x000BA4F1 File Offset: 0x000B86F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse Clone()
		{
			return new ConsumptiveRewardResponse(this);
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06004C6C RID: 19564 RVA: 0x000BA4F9 File Offset: 0x000B86F9
		// (set) Token: 0x06004C6D RID: 19565 RVA: 0x000BA501 File Offset: 0x000B8701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x000BA50A File Offset: 0x000B870A
		// (set) Token: 0x06004C6F RID: 19567 RVA: 0x000BA512 File Offset: 0x000B8712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskInfo TaskInfo
		{
			get
			{
				return this.taskInfo_;
			}
			set
			{
				this.taskInfo_ = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x000BA51B File Offset: 0x000B871B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConsumptiveTaskInfo> TaskInfos
		{
			get
			{
				return this.taskInfos_;
			}
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x000BA523 File Offset: 0x000B8723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveRewardResponse);
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x000BA534 File Offset: 0x000B8734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.TaskInfo, other.TaskInfo) && this.taskInfos_.Equals(other.taskInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x000BA598 File Offset: 0x000B8798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.taskInfo_ != null)
			{
				num ^= this.TaskInfo.GetHashCode();
			}
			num ^= this.taskInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x000BA601 File Offset: 0x000B8801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x000BA60E File Offset: 0x000B880E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x000BA618 File Offset: 0x000B8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskInfos_.WriteTo(ref output, ConsumptiveRewardResponse._repeated_taskInfos_codec);
			if (this.taskInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TaskInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x000BA684 File Offset: 0x000B8884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.taskInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TaskInfo);
			}
			num += this.taskInfos_.CalculateSize(ConsumptiveRewardResponse._repeated_taskInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x000BA6F0 File Offset: 0x000B88F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.taskInfo_ != null)
			{
				if (this.taskInfo_ == null)
				{
					this.TaskInfo = new ConsumptiveTaskInfo();
				}
				this.TaskInfo.MergeFrom(other.TaskInfo);
			}
			this.taskInfos_.Add(other.taskInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x000BA769 File Offset: 0x000B8969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x000BA774 File Offset: 0x000B8974
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
				if (num != 32U)
				{
					if (num != 50U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.taskInfo_ == null)
							{
								this.TaskInfo = new ConsumptiveTaskInfo();
							}
							input.ReadMessage(this.TaskInfo);
						}
					}
					else
					{
						this.taskInfos_.AddEntriesFrom(ref input, ConsumptiveRewardResponse._repeated_taskInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003152 RID: 12626
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003153 RID: 12627
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003154 RID: 12628
		private ErrorCode errorCode_;

		// Token: 0x04003155 RID: 12629
		public const int TaskInfoFieldNumber = 7;

		// Token: 0x04003156 RID: 12630
		private ConsumptiveTaskInfo taskInfo_;

		// Token: 0x04003157 RID: 12631
		public const int TaskInfosFieldNumber = 6;

		// Token: 0x04003158 RID: 12632
		private static readonly FieldCodec<ConsumptiveTaskInfo> _repeated_taskInfos_codec = FieldCodec.ForMessage<ConsumptiveTaskInfo>(50U, ConsumptiveTaskInfo.Parser);

		// Token: 0x04003159 RID: 12633
		private readonly RepeatedField<ConsumptiveTaskInfo> taskInfos_ = new RepeatedField<ConsumptiveTaskInfo>();
	}
}
