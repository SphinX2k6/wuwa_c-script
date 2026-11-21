using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F64 RID: 3940
	[NetMessage(EMessageId.RoadBookTaskRewardResponse)]
	public sealed class RoadBookTaskRewardResponse : IMessage<RoadBookTaskRewardResponse>, IMessage, IEquatable<RoadBookTaskRewardResponse>, IDeepCloneable<RoadBookTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06015179 RID: 86393 RVA: 0x0030F621 File Offset: 0x0030D821
		[NullableContext(1)]
		public static RoadBookTaskRewardResponse Create()
		{
			return new RoadBookTaskRewardResponse();
		}

		// Token: 0x1700462E RID: 17966
		// (get) Token: 0x0601517A RID: 86394 RVA: 0x0030F628 File Offset: 0x0030D828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x0601517B RID: 86395 RVA: 0x0030F62B File Offset: 0x0030D82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601517C RID: 86396 RVA: 0x0030F632 File Offset: 0x0030D832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse()
		{
		}

		// Token: 0x0601517D RID: 86397 RVA: 0x0030F645 File Offset: 0x0030D845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse(RoadBookTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601517E RID: 86398 RVA: 0x0030F67B File Offset: 0x0030D87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse Clone()
		{
			return new RoadBookTaskRewardResponse(this);
		}

		// Token: 0x17004630 RID: 17968
		// (get) Token: 0x0601517F RID: 86399 RVA: 0x0030F683 File Offset: 0x0030D883
		// (set) Token: 0x06015180 RID: 86400 RVA: 0x0030F68B File Offset: 0x0030D88B
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

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x06015181 RID: 86401 RVA: 0x0030F694 File Offset: 0x0030D894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06015182 RID: 86402 RVA: 0x0030F69C File Offset: 0x0030D89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookTaskRewardResponse);
		}

		// Token: 0x06015183 RID: 86403 RVA: 0x0030F6AC File Offset: 0x0030D8AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015184 RID: 86404 RVA: 0x0030F6FC File Offset: 0x0030D8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015185 RID: 86405 RVA: 0x0030F74F File Offset: 0x0030D94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015186 RID: 86406 RVA: 0x0030F75C File Offset: 0x0030D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015187 RID: 86407 RVA: 0x0030F768 File Offset: 0x0030D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookTaskRewardResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015188 RID: 86408 RVA: 0x0030F7B8 File Offset: 0x0030D9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RoadBookTaskRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015189 RID: 86409 RVA: 0x0030F80C File Offset: 0x0030DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601518A RID: 86410 RVA: 0x0030F859 File Offset: 0x0030DA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601518B RID: 86411 RVA: 0x0030F864 File Offset: 0x0030DA64
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
				if (num != 48U && num != 50U)
				{
					if (num != 56U)
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
					this.taskIds_.AddEntriesFrom(ref input, RoadBookTaskRewardResponse._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F5C RID: 32604
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F5D RID: 32605
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007F5E RID: 32606
		private ErrorCode errorCode_;

		// Token: 0x04007F5F RID: 32607
		public const int TaskIdsFieldNumber = 6;

		// Token: 0x04007F60 RID: 32608
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007F61 RID: 32609
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
