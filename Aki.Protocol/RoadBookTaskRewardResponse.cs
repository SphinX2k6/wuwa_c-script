using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F74 RID: 3956
	[NetMessage(EMessageId.RoadBookTaskRewardResponse)]
	public sealed class RoadBookTaskRewardResponse : IMessage<RoadBookTaskRewardResponse>, IMessage, IEquatable<RoadBookTaskRewardResponse>, IDeepCloneable<RoadBookTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0601525E RID: 86622 RVA: 0x00310CD1 File Offset: 0x0030EED1
		[NullableContext(1)]
		public static RoadBookTaskRewardResponse Create()
		{
			return new RoadBookTaskRewardResponse();
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x0601525F RID: 86623 RVA: 0x00310CD8 File Offset: 0x0030EED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x06015260 RID: 86624 RVA: 0x00310CDB File Offset: 0x0030EEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015261 RID: 86625 RVA: 0x00310CE2 File Offset: 0x0030EEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse()
		{
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x00310CF5 File Offset: 0x0030EEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse(RoadBookTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015263 RID: 86627 RVA: 0x00310D2B File Offset: 0x0030EF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardResponse Clone()
		{
			return new RoadBookTaskRewardResponse(this);
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x06015264 RID: 86628 RVA: 0x00310D33 File Offset: 0x0030EF33
		// (set) Token: 0x06015265 RID: 86629 RVA: 0x00310D3B File Offset: 0x0030EF3B
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

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x06015266 RID: 86630 RVA: 0x00310D44 File Offset: 0x0030EF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06015267 RID: 86631 RVA: 0x00310D4C File Offset: 0x0030EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookTaskRewardResponse);
		}

		// Token: 0x06015268 RID: 86632 RVA: 0x00310D5C File Offset: 0x0030EF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015269 RID: 86633 RVA: 0x00310DAC File Offset: 0x0030EFAC
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

		// Token: 0x0601526A RID: 86634 RVA: 0x00310DFF File Offset: 0x0030EFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601526B RID: 86635 RVA: 0x00310E0C File Offset: 0x0030F00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601526C RID: 86636 RVA: 0x00310E18 File Offset: 0x0030F018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookTaskRewardResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601526D RID: 86637 RVA: 0x00310E68 File Offset: 0x0030F068
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

		// Token: 0x0601526E RID: 86638 RVA: 0x00310EBC File Offset: 0x0030F0BC
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

		// Token: 0x0601526F RID: 86639 RVA: 0x00310F09 File Offset: 0x0030F109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015270 RID: 86640 RVA: 0x00310F14 File Offset: 0x0030F114
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
				if (num != 8U && num != 10U)
				{
					if (num != 112U)
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

		// Token: 0x04007F32 RID: 32562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F33 RID: 32563
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007F34 RID: 32564
		private ErrorCode errorCode_;

		// Token: 0x04007F35 RID: 32565
		public const int TaskIdsFieldNumber = 1;

		// Token: 0x04007F36 RID: 32566
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007F37 RID: 32567
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
