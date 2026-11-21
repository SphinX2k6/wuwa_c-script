using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F62 RID: 3938
	[NetMessage(EMessageId.RoadBookMotorRewardResponse)]
	public sealed class RoadBookMotorRewardResponse : IMessage<RoadBookMotorRewardResponse>, IMessage, IEquatable<RoadBookMotorRewardResponse>, IDeepCloneable<RoadBookMotorRewardResponse>, IBufferMessage
	{
		// Token: 0x06015153 RID: 86355 RVA: 0x0030F18D File Offset: 0x0030D38D
		[NullableContext(1)]
		public static RoadBookMotorRewardResponse Create()
		{
			return new RoadBookMotorRewardResponse();
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x06015154 RID: 86356 RVA: 0x0030F194 File Offset: 0x0030D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x06015155 RID: 86357 RVA: 0x0030F197 File Offset: 0x0030D397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015156 RID: 86358 RVA: 0x0030F19E File Offset: 0x0030D39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse()
		{
		}

		// Token: 0x06015157 RID: 86359 RVA: 0x0030F1B1 File Offset: 0x0030D3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse(RoadBookMotorRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015158 RID: 86360 RVA: 0x0030F1E7 File Offset: 0x0030D3E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse Clone()
		{
			return new RoadBookMotorRewardResponse(this);
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06015159 RID: 86361 RVA: 0x0030F1EF File Offset: 0x0030D3EF
		// (set) Token: 0x0601515A RID: 86362 RVA: 0x0030F1F7 File Offset: 0x0030D3F7
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

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x0601515B RID: 86363 RVA: 0x0030F200 File Offset: 0x0030D400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601515C RID: 86364 RVA: 0x0030F208 File Offset: 0x0030D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorRewardResponse);
		}

		// Token: 0x0601515D RID: 86365 RVA: 0x0030F218 File Offset: 0x0030D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601515E RID: 86366 RVA: 0x0030F268 File Offset: 0x0030D468
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

		// Token: 0x0601515F RID: 86367 RVA: 0x0030F2BB File Offset: 0x0030D4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015160 RID: 86368 RVA: 0x0030F2C8 File Offset: 0x0030D4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015161 RID: 86369 RVA: 0x0030F2D4 File Offset: 0x0030D4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, RoadBookMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015162 RID: 86370 RVA: 0x0030F324 File Offset: 0x0030D524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(RoadBookMotorRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015163 RID: 86371 RVA: 0x0030F378 File Offset: 0x0030D578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookMotorRewardResponse other)
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

		// Token: 0x06015164 RID: 86372 RVA: 0x0030F3C5 File Offset: 0x0030D5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015165 RID: 86373 RVA: 0x0030F3D0 File Offset: 0x0030D5D0
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
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, RoadBookMotorRewardResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F52 RID: 32594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F53 RID: 32595
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007F54 RID: 32596
		private ErrorCode errorCode_;

		// Token: 0x04007F55 RID: 32597
		public const int TaskIdsFieldNumber = 9;

		// Token: 0x04007F56 RID: 32598
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007F57 RID: 32599
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
