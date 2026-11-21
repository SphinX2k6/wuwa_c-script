using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F54 RID: 3924
	[NetMessage(EMessageId.RiskHarvestScoreRewardResponse)]
	public sealed class RiskHarvestScoreRewardResponse : IMessage<RiskHarvestScoreRewardResponse>, IMessage, IEquatable<RiskHarvestScoreRewardResponse>, IDeepCloneable<RiskHarvestScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601503B RID: 86075 RVA: 0x0030CDF5 File Offset: 0x0030AFF5
		[NullableContext(1)]
		public static RiskHarvestScoreRewardResponse Create()
		{
			return new RiskHarvestScoreRewardResponse();
		}

		// Token: 0x170045ED RID: 17901
		// (get) Token: 0x0601503C RID: 86076 RVA: 0x0030CDFC File Offset: 0x0030AFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045EE RID: 17902
		// (get) Token: 0x0601503D RID: 86077 RVA: 0x0030CDFF File Offset: 0x0030AFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x0030CE06 File Offset: 0x0030B006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse()
		{
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x0030CE0E File Offset: 0x0030B00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse(RiskHarvestScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x0030CE33 File Offset: 0x0030B033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestScoreRewardResponse Clone()
		{
			return new RiskHarvestScoreRewardResponse(this);
		}

		// Token: 0x170045EF RID: 17903
		// (get) Token: 0x06015041 RID: 86081 RVA: 0x0030CE3B File Offset: 0x0030B03B
		// (set) Token: 0x06015042 RID: 86082 RVA: 0x0030CE43 File Offset: 0x0030B043
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

		// Token: 0x06015043 RID: 86083 RVA: 0x0030CE4C File Offset: 0x0030B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestScoreRewardResponse);
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x0030CE5A File Offset: 0x0030B05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x0030CE88 File Offset: 0x0030B088
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

		// Token: 0x06015046 RID: 86086 RVA: 0x0030CECD File Offset: 0x0030B0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015047 RID: 86087 RVA: 0x0030CEDA File Offset: 0x0030B0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x0030CEE3 File Offset: 0x0030B0E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06015049 RID: 86089 RVA: 0x0030CF18 File Offset: 0x0030B118
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

		// Token: 0x0601504A RID: 86090 RVA: 0x0030CF56 File Offset: 0x0030B156
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

		// Token: 0x0601504B RID: 86091 RVA: 0x0030CF87 File Offset: 0x0030B187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x0030CF90 File Offset: 0x0030B190
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F0F RID: 32527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F10 RID: 32528
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007F11 RID: 32529
		private ErrorCode errorCode_;
	}
}
