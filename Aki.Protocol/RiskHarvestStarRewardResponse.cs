using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F69 RID: 3945
	[NetMessage(EMessageId.RiskHarvestStarRewardResponse)]
	public sealed class RiskHarvestStarRewardResponse : IMessage<RiskHarvestStarRewardResponse>, IMessage, IEquatable<RiskHarvestStarRewardResponse>, IDeepCloneable<RiskHarvestStarRewardResponse>, IBufferMessage
	{
		// Token: 0x0601517E RID: 86398 RVA: 0x0030EEF4 File Offset: 0x0030D0F4
		[NullableContext(1)]
		public static RiskHarvestStarRewardResponse Create()
		{
			return new RiskHarvestStarRewardResponse();
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x0601517F RID: 86399 RVA: 0x0030EEFB File Offset: 0x0030D0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x06015180 RID: 86400 RVA: 0x0030EEFE File Offset: 0x0030D0FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015181 RID: 86401 RVA: 0x0030EF05 File Offset: 0x0030D105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse()
		{
		}

		// Token: 0x06015182 RID: 86402 RVA: 0x0030EF0D File Offset: 0x0030D10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse(RiskHarvestStarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015183 RID: 86403 RVA: 0x0030EF32 File Offset: 0x0030D132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse Clone()
		{
			return new RiskHarvestStarRewardResponse(this);
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x06015184 RID: 86404 RVA: 0x0030EF3A File Offset: 0x0030D13A
		// (set) Token: 0x06015185 RID: 86405 RVA: 0x0030EF42 File Offset: 0x0030D142
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

		// Token: 0x06015186 RID: 86406 RVA: 0x0030EF4B File Offset: 0x0030D14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardResponse);
		}

		// Token: 0x06015187 RID: 86407 RVA: 0x0030EF59 File Offset: 0x0030D159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015188 RID: 86408 RVA: 0x0030EF88 File Offset: 0x0030D188
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

		// Token: 0x06015189 RID: 86409 RVA: 0x0030EFCD File Offset: 0x0030D1CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601518A RID: 86410 RVA: 0x0030EFDA File Offset: 0x0030D1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601518B RID: 86411 RVA: 0x0030EFE3 File Offset: 0x0030D1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601518C RID: 86412 RVA: 0x0030F018 File Offset: 0x0030D218
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

		// Token: 0x0601518D RID: 86413 RVA: 0x0030F056 File Offset: 0x0030D256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestStarRewardResponse other)
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

		// Token: 0x0601518E RID: 86414 RVA: 0x0030F087 File Offset: 0x0030D287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601518F RID: 86415 RVA: 0x0030F090 File Offset: 0x0030D290
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007EF7 RID: 32503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EF8 RID: 32504
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04007EF9 RID: 32505
		private ErrorCode errorCode_;
	}
}
