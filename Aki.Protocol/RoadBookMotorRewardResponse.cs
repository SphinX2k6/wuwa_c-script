using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F72 RID: 3954
	[NetMessage(EMessageId.RoadBookMotorRewardResponse)]
	public sealed class RoadBookMotorRewardResponse : IMessage<RoadBookMotorRewardResponse>, IMessage, IEquatable<RoadBookMotorRewardResponse>, IDeepCloneable<RoadBookMotorRewardResponse>, IBufferMessage
	{
		// Token: 0x06015238 RID: 86584 RVA: 0x0031083D File Offset: 0x0030EA3D
		[NullableContext(1)]
		public static RoadBookMotorRewardResponse Create()
		{
			return new RoadBookMotorRewardResponse();
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x06015239 RID: 86585 RVA: 0x00310844 File Offset: 0x0030EA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x0601523A RID: 86586 RVA: 0x00310847 File Offset: 0x0030EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601523B RID: 86587 RVA: 0x0031084E File Offset: 0x0030EA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse()
		{
		}

		// Token: 0x0601523C RID: 86588 RVA: 0x00310861 File Offset: 0x0030EA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse(RoadBookMotorRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601523D RID: 86589 RVA: 0x00310897 File Offset: 0x0030EA97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardResponse Clone()
		{
			return new RoadBookMotorRewardResponse(this);
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x0601523E RID: 86590 RVA: 0x0031089F File Offset: 0x0030EA9F
		// (set) Token: 0x0601523F RID: 86591 RVA: 0x003108A7 File Offset: 0x0030EAA7
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

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x06015240 RID: 86592 RVA: 0x003108B0 File Offset: 0x0030EAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06015241 RID: 86593 RVA: 0x003108B8 File Offset: 0x0030EAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorRewardResponse);
		}

		// Token: 0x06015242 RID: 86594 RVA: 0x003108C8 File Offset: 0x0030EAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x00310918 File Offset: 0x0030EB18
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

		// Token: 0x06015244 RID: 86596 RVA: 0x0031096B File Offset: 0x0030EB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015245 RID: 86597 RVA: 0x00310978 File Offset: 0x0030EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015246 RID: 86598 RVA: 0x00310984 File Offset: 0x0030EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookMotorRewardResponse._repeated_taskIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015247 RID: 86599 RVA: 0x003109D4 File Offset: 0x0030EBD4
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

		// Token: 0x06015248 RID: 86600 RVA: 0x00310A28 File Offset: 0x0030EC28
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

		// Token: 0x06015249 RID: 86601 RVA: 0x00310A75 File Offset: 0x0030EC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601524A RID: 86602 RVA: 0x00310A80 File Offset: 0x0030EC80
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
				if (num != 24U && num != 26U)
				{
					if (num != 40U)
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
					this.taskIds_.AddEntriesFrom(ref input, RoadBookMotorRewardResponse._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F28 RID: 32552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F29 RID: 32553
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007F2A RID: 32554
		private ErrorCode errorCode_;

		// Token: 0x04007F2B RID: 32555
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x04007F2C RID: 32556
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007F2D RID: 32557
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
