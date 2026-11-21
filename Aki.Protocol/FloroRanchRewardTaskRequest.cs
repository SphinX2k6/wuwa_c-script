using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C8 RID: 1480
	[NetMessage(EMessageId.FloroRanchRewardTaskRequest)]
	public sealed class FloroRanchRewardTaskRequest : IMessage<FloroRanchRewardTaskRequest>, IMessage, IEquatable<FloroRanchRewardTaskRequest>, IDeepCloneable<FloroRanchRewardTaskRequest>, IBufferMessage
	{
		// Token: 0x06008971 RID: 35185 RVA: 0x0014CE31 File Offset: 0x0014B031
		[NullableContext(1)]
		public static FloroRanchRewardTaskRequest Create()
		{
			return new FloroRanchRewardTaskRequest();
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06008972 RID: 35186 RVA: 0x0014CE38 File Offset: 0x0014B038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x0014CE3B File Offset: 0x0014B03B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchRewardTaskRequest.Descriptor;
			}
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x0014CE42 File Offset: 0x0014B042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest()
		{
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x0014CE55 File Offset: 0x0014B055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest(FloroRanchRewardTaskRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x0014CE8B File Offset: 0x0014B08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchRewardTaskRequest Clone()
		{
			return new FloroRanchRewardTaskRequest(this);
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x06008977 RID: 35191 RVA: 0x0014CE93 File Offset: 0x0014B093
		// (set) Token: 0x06008978 RID: 35192 RVA: 0x0014CE9B File Offset: 0x0014B09B
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06008979 RID: 35193 RVA: 0x0014CEA4 File Offset: 0x0014B0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x0014CEAC File Offset: 0x0014B0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchRewardTaskRequest);
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x0014CEBC File Offset: 0x0014B0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchRewardTaskRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0014CF0C File Offset: 0x0014B10C
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

		// Token: 0x0600897D RID: 35197 RVA: 0x0014CF59 File Offset: 0x0014B159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x0014CF66 File Offset: 0x0014B166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x0014CF70 File Offset: 0x0014B170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, FloroRanchRewardTaskRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x0014CFC0 File Offset: 0x0014B1C0
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

		// Token: 0x06008981 RID: 35201 RVA: 0x0014D014 File Offset: 0x0014B214
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

		// Token: 0x06008982 RID: 35202 RVA: 0x0014D061 File Offset: 0x0014B261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x0014D06C File Offset: 0x0014B26C
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
					if (num != 64U && num != 66U)
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

		// Token: 0x04004416 RID: 17430
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004417 RID: 17431
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04004418 RID: 17432
		private int activityId_;

		// Token: 0x04004419 RID: 17433
		public const int TaskIdsFieldNumber = 8;

		// Token: 0x0400441A RID: 17434
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x0400441B RID: 17435
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
