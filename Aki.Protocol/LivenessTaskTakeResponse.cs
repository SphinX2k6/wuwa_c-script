using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000937 RID: 2359
	[NetMessage(EMessageId.LivenessTaskTakeResponse)]
	public sealed class LivenessTaskTakeResponse : IMessage<LivenessTaskTakeResponse>, IMessage, IEquatable<LivenessTaskTakeResponse>, IDeepCloneable<LivenessTaskTakeResponse>, IBufferMessage
	{
		// Token: 0x0600CFEE RID: 53230 RVA: 0x001E9BE9 File Offset: 0x001E7DE9
		[NullableContext(1)]
		public static LivenessTaskTakeResponse Create()
		{
			return new LivenessTaskTakeResponse();
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600CFEF RID: 53231 RVA: 0x001E9BF0 File Offset: 0x001E7DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x001E9BF3 File Offset: 0x001E7DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTaskTakeResponse.Descriptor;
			}
		}

		// Token: 0x0600CFF1 RID: 53233 RVA: 0x001E9BFA File Offset: 0x001E7DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse()
		{
		}

		// Token: 0x0600CFF2 RID: 53234 RVA: 0x001E9C0D File Offset: 0x001E7E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse(LivenessTaskTakeResponse other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFF3 RID: 53235 RVA: 0x001E9C43 File Offset: 0x001E7E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse Clone()
		{
			return new LivenessTaskTakeResponse(this);
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x001E9C4B File Offset: 0x001E7E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x001E9C53 File Offset: 0x001E7E53
		// (set) Token: 0x0600CFF6 RID: 53238 RVA: 0x001E9C5B File Offset: 0x001E7E5B
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

		// Token: 0x0600CFF7 RID: 53239 RVA: 0x001E9C64 File Offset: 0x001E7E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTaskTakeResponse);
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x001E9C74 File Offset: 0x001E7E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTaskTakeResponse other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x001E9CC4 File Offset: 0x001E7EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CFFA RID: 53242 RVA: 0x001E9D17 File Offset: 0x001E7F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x001E9D24 File Offset: 0x001E7F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x001E9D30 File Offset: 0x001E7F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LivenessTaskTakeResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x001E9D80 File Offset: 0x001E7F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LivenessTaskTakeResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x001E9DD4 File Offset: 0x001E7FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTaskTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CFFF RID: 53247 RVA: 0x001E9E21 File Offset: 0x001E8021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x001E9E2C File Offset: 0x001E802C
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
				if (num != 64U && num != 66U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LivenessTaskTakeResponse._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040057AB RID: 22443
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057AC RID: 22444
		public const int TaskIdsFieldNumber = 8;

		// Token: 0x040057AD RID: 22445
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040057AE RID: 22446
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x040057AF RID: 22447
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040057B0 RID: 22448
		private ErrorCode errorCode_;
	}
}
