using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E5 RID: 741
	[NetMessage(EMessageId.ConsumptiveActivityScoreResponse)]
	public sealed class ConsumptiveActivityScoreResponse : IMessage<ConsumptiveActivityScoreResponse>, IMessage, IEquatable<ConsumptiveActivityScoreResponse>, IDeepCloneable<ConsumptiveActivityScoreResponse>, IBufferMessage
	{
		// Token: 0x06004B65 RID: 19301 RVA: 0x000B7B45 File Offset: 0x000B5D45
		[NullableContext(1)]
		public static ConsumptiveActivityScoreResponse Create()
		{
			return new ConsumptiveActivityScoreResponse();
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x000B7B4C File Offset: 0x000B5D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x000B7B4F File Offset: 0x000B5D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityScoreResponse.Descriptor;
			}
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x000B7B56 File Offset: 0x000B5D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse()
		{
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x000B7B5E File Offset: 0x000B5D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse(ConsumptiveActivityScoreResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.totalScore_ = other.totalScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x000B7B8F File Offset: 0x000B5D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityScoreResponse Clone()
		{
			return new ConsumptiveActivityScoreResponse(this);
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x000B7B97 File Offset: 0x000B5D97
		// (set) Token: 0x06004B6C RID: 19308 RVA: 0x000B7B9F File Offset: 0x000B5D9F
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x000B7BA8 File Offset: 0x000B5DA8
		// (set) Token: 0x06004B6E RID: 19310 RVA: 0x000B7BB0 File Offset: 0x000B5DB0
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

		// Token: 0x06004B6F RID: 19311 RVA: 0x000B7BB9 File Offset: 0x000B5DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityScoreResponse);
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x000B7BC7 File Offset: 0x000B5DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityScoreResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TotalScore == other.TotalScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x000B7C08 File Offset: 0x000B5E08
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

		// Token: 0x06004B72 RID: 19314 RVA: 0x000B7C66 File Offset: 0x000B5E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x000B7C73 File Offset: 0x000B5E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x000B7C7C File Offset: 0x000B5E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TotalScore);
			}
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

		// Token: 0x06004B75 RID: 19317 RVA: 0x000B7CD4 File Offset: 0x000B5ED4
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

		// Token: 0x06004B76 RID: 19318 RVA: 0x000B7D2C File Offset: 0x000B5F2C
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

		// Token: 0x06004B77 RID: 19319 RVA: 0x000B7D7C File Offset: 0x000B5F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x000B7D88 File Offset: 0x000B5F88
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
					this.TotalScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030B0 RID: 12464
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030B1 RID: 12465
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040030B2 RID: 12466
		private ErrorCode errorCode_;

		// Token: 0x040030B3 RID: 12467
		public const int TotalScoreFieldNumber = 1;

		// Token: 0x040030B4 RID: 12468
		private int totalScore_;
	}
}
