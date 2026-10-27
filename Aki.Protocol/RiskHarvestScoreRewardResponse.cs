using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F64 RID: 3940
	[NetMessage(EMessageId.RiskHarvestScoreRewardResponse)]
	public sealed class RiskHarvestScoreRewardResponse : IMessage<RiskHarvestScoreRewardResponse>, IMessage, IEquatable<RiskHarvestScoreRewardResponse>, IDeepCloneable<RiskHarvestScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06015120 RID: 86304 RVA: 0x0030E4A5 File Offset: 0x0030C6A5
		[NullableContext(1)]
		public static RiskHarvestScoreRewardResponse Create()
		{
			return new RiskHarvestScoreRewardResponse();
		}

		// Token: 0x17004617 RID: 17943
		// (get) Token: 0x06015121 RID: 86305 RVA: 0x0030E4AC File Offset: 0x0030C6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004618 RID: 17944
		// (get) Token: 0x06015122 RID: 86306 RVA: 0x0030E4AF File Offset: 0x0030C6AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015123 RID: 86307 RVA: 0x0030E4B6 File Offset: 0x0030C6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse()
		{
		}

		// Token: 0x06015124 RID: 86308 RVA: 0x0030E4BE File Offset: 0x0030C6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse(RiskHarvestScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015125 RID: 86309 RVA: 0x0030E4E3 File Offset: 0x0030C6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse Clone()
		{
			return new RiskHarvestScoreRewardResponse(this);
		}

		// Token: 0x17004619 RID: 17945
		// (get) Token: 0x06015126 RID: 86310 RVA: 0x0030E4EB File Offset: 0x0030C6EB
		// (set) Token: 0x06015127 RID: 86311 RVA: 0x0030E4F3 File Offset: 0x0030C6F3
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

		// Token: 0x06015128 RID: 86312 RVA: 0x0030E4FC File Offset: 0x0030C6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestScoreRewardResponse);
		}

		// Token: 0x06015129 RID: 86313 RVA: 0x0030E50A File Offset: 0x0030C70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601512A RID: 86314 RVA: 0x0030E538 File Offset: 0x0030C738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601512B RID: 86315 RVA: 0x0030E57D File Offset: 0x0030C77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601512C RID: 86316 RVA: 0x0030E58A File Offset: 0x0030C78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601512D RID: 86317 RVA: 0x0030E593 File Offset: 0x0030C793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601512E RID: 86318 RVA: 0x0030E5C8 File Offset: 0x0030C7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601512F RID: 86319 RVA: 0x0030E606 File Offset: 0x0030C806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015130 RID: 86320 RVA: 0x0030E637 File Offset: 0x0030C837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015131 RID: 86321 RVA: 0x0030E640 File Offset: 0x0030C840
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007EE5 RID: 32485
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EE6 RID: 32486
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007EE7 RID: 32487
		private ErrorCode errorCode_;
	}
}
