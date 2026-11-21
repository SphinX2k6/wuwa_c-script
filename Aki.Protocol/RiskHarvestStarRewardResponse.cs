using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F59 RID: 3929
	[NetMessage(EMessageId.RiskHarvestStarRewardResponse)]
	public sealed class RiskHarvestStarRewardResponse : IMessage<RiskHarvestStarRewardResponse>, IMessage, IEquatable<RiskHarvestStarRewardResponse>, IDeepCloneable<RiskHarvestStarRewardResponse>, IBufferMessage
	{
		// Token: 0x06015099 RID: 86169 RVA: 0x0030D844 File Offset: 0x0030BA44
		[NullableContext(1)]
		public static RiskHarvestStarRewardResponse Create()
		{
			return new RiskHarvestStarRewardResponse();
		}

		// Token: 0x170045FE RID: 17918
		// (get) Token: 0x0601509A RID: 86170 RVA: 0x0030D84B File Offset: 0x0030BA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045FF RID: 17919
		// (get) Token: 0x0601509B RID: 86171 RVA: 0x0030D84E File Offset: 0x0030BA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestStarRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601509C RID: 86172 RVA: 0x0030D855 File Offset: 0x0030BA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse()
		{
		}

		// Token: 0x0601509D RID: 86173 RVA: 0x0030D85D File Offset: 0x0030BA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse(RiskHarvestStarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601509E RID: 86174 RVA: 0x0030D882 File Offset: 0x0030BA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestStarRewardResponse Clone()
		{
			return new RiskHarvestStarRewardResponse(this);
		}

		// Token: 0x17004600 RID: 17920
		// (get) Token: 0x0601509F RID: 86175 RVA: 0x0030D88A File Offset: 0x0030BA8A
		// (set) Token: 0x060150A0 RID: 86176 RVA: 0x0030D892 File Offset: 0x0030BA92
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

		// Token: 0x060150A1 RID: 86177 RVA: 0x0030D89B File Offset: 0x0030BA9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestStarRewardResponse);
		}

		// Token: 0x060150A2 RID: 86178 RVA: 0x0030D8A9 File Offset: 0x0030BAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestStarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060150A3 RID: 86179 RVA: 0x0030D8D8 File Offset: 0x0030BAD8
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

		// Token: 0x060150A4 RID: 86180 RVA: 0x0030D91D File Offset: 0x0030BB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060150A5 RID: 86181 RVA: 0x0030D92A File Offset: 0x0030BB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060150A6 RID: 86182 RVA: 0x0030D933 File Offset: 0x0030BB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060150A7 RID: 86183 RVA: 0x0030D968 File Offset: 0x0030BB68
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

		// Token: 0x060150A8 RID: 86184 RVA: 0x0030D9A6 File Offset: 0x0030BBA6
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

		// Token: 0x060150A9 RID: 86185 RVA: 0x0030D9D7 File Offset: 0x0030BBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060150AA RID: 86186 RVA: 0x0030D9E0 File Offset: 0x0030BBE0
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F21 RID: 32545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F22 RID: 32546
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007F23 RID: 32547
		private ErrorCode errorCode_;
	}
}
