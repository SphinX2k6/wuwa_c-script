using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000926 RID: 2342
	[NetMessage(EMessageId.LivenessTaskTakeResponse)]
	public sealed class LivenessTaskTakeResponse : IMessage<LivenessTaskTakeResponse>, IMessage, IEquatable<LivenessTaskTakeResponse>, IDeepCloneable<LivenessTaskTakeResponse>, IBufferMessage
	{
		// Token: 0x0600CED2 RID: 52946 RVA: 0x001E7915 File Offset: 0x001E5B15
		[NullableContext(1)]
		public static LivenessTaskTakeResponse Create()
		{
			return new LivenessTaskTakeResponse();
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600CED3 RID: 52947 RVA: 0x001E791C File Offset: 0x001E5B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x001E791F File Offset: 0x001E5B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTaskTakeResponse.Descriptor;
			}
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x001E7926 File Offset: 0x001E5B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse()
		{
		}

		// Token: 0x0600CED6 RID: 52950 RVA: 0x001E7939 File Offset: 0x001E5B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse(LivenessTaskTakeResponse other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CED7 RID: 52951 RVA: 0x001E796F File Offset: 0x001E5B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeResponse Clone()
		{
			return new LivenessTaskTakeResponse(this);
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x001E7977 File Offset: 0x001E5B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600CED9 RID: 52953 RVA: 0x001E797F File Offset: 0x001E5B7F
		// (set) Token: 0x0600CEDA RID: 52954 RVA: 0x001E7987 File Offset: 0x001E5B87
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

		// Token: 0x0600CEDB RID: 52955 RVA: 0x001E7990 File Offset: 0x001E5B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTaskTakeResponse);
		}

		// Token: 0x0600CEDC RID: 52956 RVA: 0x001E79A0 File Offset: 0x001E5BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTaskTakeResponse other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x001E79F0 File Offset: 0x001E5BF0
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

		// Token: 0x0600CEDE RID: 52958 RVA: 0x001E7A43 File Offset: 0x001E5C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEDF RID: 52959 RVA: 0x001E7A50 File Offset: 0x001E5C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x001E7A5C File Offset: 0x001E5C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, LivenessTaskTakeResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x001E7AAC File Offset: 0x001E5CAC
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

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x001E7B00 File Offset: 0x001E5D00
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

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x001E7B4D File Offset: 0x001E5D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x001E7B58 File Offset: 0x001E5D58
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
					if (num != 24U && num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, LivenessTaskTakeResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040057B2 RID: 22450
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057B3 RID: 22451
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x040057B4 RID: 22452
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040057B5 RID: 22453
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();

		// Token: 0x040057B6 RID: 22454
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040057B7 RID: 22455
		private ErrorCode errorCode_;
	}
}
