using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DD RID: 1501
	[NetMessage(EMessageId.FloroRanchRewardTaskRequest)]
	public sealed class FloroRanchRewardTaskRequest : IMessage<FloroRanchRewardTaskRequest>, IMessage, IEquatable<FloroRanchRewardTaskRequest>, IDeepCloneable<FloroRanchRewardTaskRequest>, IBufferMessage
	{
		// Token: 0x06008AD9 RID: 35545 RVA: 0x0014FA49 File Offset: 0x0014DC49
		[NullableContext(1)]
		public static FloroRanchRewardTaskRequest Create()
		{
			return new FloroRanchRewardTaskRequest();
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06008ADA RID: 35546 RVA: 0x0014FA50 File Offset: 0x0014DC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x0014FA53 File Offset: 0x0014DC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x0014FA5A File Offset: 0x0014DC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest()
		{
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x0014FA6D File Offset: 0x0014DC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest(FloroRanchRewardTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x0014FAA3 File Offset: 0x0014DCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest Clone()
		{
			return new FloroRanchRewardTaskRequest(this);
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x0014FAAB File Offset: 0x0014DCAB
		// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x0014FAB3 File Offset: 0x0014DCB3
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

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x0014FABC File Offset: 0x0014DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x0014FAC4 File Offset: 0x0014DCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardTaskRequest);
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x0014FAD4 File Offset: 0x0014DCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0014FB24 File Offset: 0x0014DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x0014FB71 File Offset: 0x0014DD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x0014FB7E File Offset: 0x0014DD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x0014FB88 File Offset: 0x0014DD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, FloroRanchRewardTaskRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x0014FBD8 File Offset: 0x0014DDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(FloroRanchRewardTaskRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x0014FC2C File Offset: 0x0014DE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchRewardTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x0014FC79 File Offset: 0x0014DE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x0014FC84 File Offset: 0x0014DE84
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
					if (num != 32U && num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, FloroRanchRewardTaskRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004420 RID: 17440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004421 RID: 17441
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004422 RID: 17442
		private int activityId_;

		// Token: 0x04004423 RID: 17443
		public const int TaskIdsFieldNumber = 4;

		// Token: 0x04004424 RID: 17444
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004425 RID: 17445
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
