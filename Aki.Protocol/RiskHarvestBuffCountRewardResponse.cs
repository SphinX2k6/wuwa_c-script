using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F57 RID: 3927
	[NetMessage(EMessageId.RiskHarvestBuffCountRewardResponse)]
	public sealed class RiskHarvestBuffCountRewardResponse : IMessage<RiskHarvestBuffCountRewardResponse>, IMessage, IEquatable<RiskHarvestBuffCountRewardResponse>, IDeepCloneable<RiskHarvestBuffCountRewardResponse>, IBufferMessage
	{
		// Token: 0x06015014 RID: 86036 RVA: 0x0030C0F1 File Offset: 0x0030A2F1
		[NullableContext(1)]
		public static RiskHarvestBuffCountRewardResponse Create()
		{
			return new RiskHarvestBuffCountRewardResponse();
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x06015015 RID: 86037 RVA: 0x0030C0F8 File Offset: 0x0030A2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x06015016 RID: 86038 RVA: 0x0030C0FB File Offset: 0x0030A2FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffCountRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015017 RID: 86039 RVA: 0x0030C102 File Offset: 0x0030A302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse()
		{
		}

		// Token: 0x06015018 RID: 86040 RVA: 0x0030C10A File Offset: 0x0030A30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse(RiskHarvestBuffCountRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015019 RID: 86041 RVA: 0x0030C12F File Offset: 0x0030A32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffCountRewardResponse Clone()
		{
			return new RiskHarvestBuffCountRewardResponse(this);
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x0601501A RID: 86042 RVA: 0x0030C137 File Offset: 0x0030A337
		// (set) Token: 0x0601501B RID: 86043 RVA: 0x0030C13F File Offset: 0x0030A33F
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

		// Token: 0x0601501C RID: 86044 RVA: 0x0030C148 File Offset: 0x0030A348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffCountRewardResponse);
		}

		// Token: 0x0601501D RID: 86045 RVA: 0x0030C156 File Offset: 0x0030A356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffCountRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x0030C184 File Offset: 0x0030A384
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

		// Token: 0x0601501F RID: 86047 RVA: 0x0030C1C9 File Offset: 0x0030A3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015020 RID: 86048 RVA: 0x0030C1D6 File Offset: 0x0030A3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x0030C1DF File Offset: 0x0030A3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015022 RID: 86050 RVA: 0x0030C210 File Offset: 0x0030A410
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

		// Token: 0x06015023 RID: 86051 RVA: 0x0030C24E File Offset: 0x0030A44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffCountRewardResponse other)
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

		// Token: 0x06015024 RID: 86052 RVA: 0x0030C27F File Offset: 0x0030A47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015025 RID: 86053 RVA: 0x0030C288 File Offset: 0x0030A488
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E96 RID: 32406
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E97 RID: 32407
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007E98 RID: 32408
		private ErrorCode errorCode_;
	}
}
