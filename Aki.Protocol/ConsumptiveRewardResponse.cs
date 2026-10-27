using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E7 RID: 743
	[NetMessage(EMessageId.ConsumptiveRewardResponse)]
	public sealed class ConsumptiveRewardResponse : IMessage<ConsumptiveRewardResponse>, IMessage, IEquatable<ConsumptiveRewardResponse>, IDeepCloneable<ConsumptiveRewardResponse>, IBufferMessage
	{
		// Token: 0x06004B8D RID: 19341 RVA: 0x000B8088 File Offset: 0x000B6288
		[NullableContext(1)]
		public static ConsumptiveRewardResponse Create()
		{
			return new ConsumptiveRewardResponse();
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06004B8E RID: 19342 RVA: 0x000B808F File Offset: 0x000B628F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06004B8F RID: 19343 RVA: 0x000B8092 File Offset: 0x000B6292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x000B8099 File Offset: 0x000B6299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse()
		{
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x000B80AC File Offset: 0x000B62AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse(ConsumptiveRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskInfo_ = ((other.taskInfo_ != null) ? other.taskInfo_.Clone() : null);
			this.taskInfos_ = other.taskInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x000B8109 File Offset: 0x000B6309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveRewardResponse Clone()
		{
			return new ConsumptiveRewardResponse(this);
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x000B8111 File Offset: 0x000B6311
		// (set) Token: 0x06004B94 RID: 19348 RVA: 0x000B8119 File Offset: 0x000B6319
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

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x000B8122 File Offset: 0x000B6322
		// (set) Token: 0x06004B96 RID: 19350 RVA: 0x000B812A File Offset: 0x000B632A
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

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06004B97 RID: 19351 RVA: 0x000B8133 File Offset: 0x000B6333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConsumptiveTaskInfo> TaskInfos
		{
			get
			{
				return this.taskInfos_;
			}
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x000B813B File Offset: 0x000B633B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveRewardResponse);
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x000B814C File Offset: 0x000B634C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.TaskInfo, other.TaskInfo) && this.taskInfos_.Equals(other.taskInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x000B81B0 File Offset: 0x000B63B0
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

		// Token: 0x06004B9B RID: 19355 RVA: 0x000B8219 File Offset: 0x000B6419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x000B8226 File Offset: 0x000B6426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x000B8230 File Offset: 0x000B6430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskInfos_.WriteTo(ref output, ConsumptiveRewardResponse._repeated_taskInfos_codec);
			if (this.taskInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TaskInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x000B829C File Offset: 0x000B649C
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

		// Token: 0x06004B9F RID: 19359 RVA: 0x000B8308 File Offset: 0x000B6508
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

		// Token: 0x06004BA0 RID: 19360 RVA: 0x000B8381 File Offset: 0x000B6581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x000B838C File Offset: 0x000B658C
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
				if (num != 24U)
				{
					if (num != 58U)
					{
						if (num != 66U)
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

		// Token: 0x040030BB RID: 12475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030BC RID: 12476
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040030BD RID: 12477
		private ErrorCode errorCode_;

		// Token: 0x040030BE RID: 12478
		public const int TaskInfoFieldNumber = 8;

		// Token: 0x040030BF RID: 12479
		private ConsumptiveTaskInfo taskInfo_;

		// Token: 0x040030C0 RID: 12480
		public const int TaskInfosFieldNumber = 7;

		// Token: 0x040030C1 RID: 12481
		private static readonly FieldCodec<ConsumptiveTaskInfo> _repeated_taskInfos_codec = FieldCodec.ForMessage<ConsumptiveTaskInfo>(58U, ConsumptiveTaskInfo.Parser);

		// Token: 0x040030C2 RID: 12482
		private readonly RepeatedField<ConsumptiveTaskInfo> taskInfos_ = new RepeatedField<ConsumptiveTaskInfo>();
	}
}
