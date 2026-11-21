using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EC RID: 748
	[NetMessage(EMessageId.ConsumptiveActivityScoreResponse)]
	public sealed class ConsumptiveActivityScoreResponse : IMessage<ConsumptiveActivityScoreResponse>, IMessage, IEquatable<ConsumptiveActivityScoreResponse>, IDeepCloneable<ConsumptiveActivityScoreResponse>, IBufferMessage
	{
		// Token: 0x06004C3E RID: 19518 RVA: 0x000B9F2D File Offset: 0x000B812D
		[NullableContext(1)]
		public static ConsumptiveActivityScoreResponse Create()
		{
			return new ConsumptiveActivityScoreResponse();
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x000B9F34 File Offset: 0x000B8134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x000B9F37 File Offset: 0x000B8137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityScoreResponse.Descriptor;
			}
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x000B9F3E File Offset: 0x000B813E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse()
		{
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x000B9F46 File Offset: 0x000B8146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse(ConsumptiveActivityScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x000B9F77 File Offset: 0x000B8177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse Clone()
		{
			return new ConsumptiveActivityScoreResponse(this);
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06004C44 RID: 19524 RVA: 0x000B9F7F File Offset: 0x000B817F
		// (set) Token: 0x06004C45 RID: 19525 RVA: 0x000B9F87 File Offset: 0x000B8187
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

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x000B9F90 File Offset: 0x000B8190
		// (set) Token: 0x06004C47 RID: 19527 RVA: 0x000B9F98 File Offset: 0x000B8198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x000B9FA1 File Offset: 0x000B81A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityScoreResponse);
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x000B9FAF File Offset: 0x000B81AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x000B9FF0 File Offset: 0x000B81F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x000BA04E File Offset: 0x000B824E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x000BA05B File Offset: 0x000B825B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x000BA064 File Offset: 0x000B8264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x000BA0BC File Offset: 0x000B82BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x000BA114 File Offset: 0x000B8314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityScoreResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x000BA164 File Offset: 0x000B8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x000BA170 File Offset: 0x000B8370
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
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalScore = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003147 RID: 12615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003148 RID: 12616
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003149 RID: 12617
		private ErrorCode errorCode_;

		// Token: 0x0400314A RID: 12618
		public const int TotalScoreFieldNumber = 8;

		// Token: 0x0400314B RID: 12619
		private int totalScore_;
	}
}
