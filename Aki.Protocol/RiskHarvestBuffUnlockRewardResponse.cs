using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F5A RID: 3930
	[NetMessage(EMessageId.RiskHarvestBuffUnlockRewardResponse)]
	public sealed class RiskHarvestBuffUnlockRewardResponse : IMessage<RiskHarvestBuffUnlockRewardResponse>, IMessage, IEquatable<RiskHarvestBuffUnlockRewardResponse>, IDeepCloneable<RiskHarvestBuffUnlockRewardResponse>, IBufferMessage
	{
		// Token: 0x0601504A RID: 86090 RVA: 0x0030C685 File Offset: 0x0030A885
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockRewardResponse Create()
		{
			return new RiskHarvestBuffUnlockRewardResponse();
		}

		// Token: 0x170045E7 RID: 17895
		// (get) Token: 0x0601504B RID: 86091 RVA: 0x0030C68C File Offset: 0x0030A88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045E8 RID: 17896
		// (get) Token: 0x0601504C RID: 86092 RVA: 0x0030C68F File Offset: 0x0030A88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601504D RID: 86093 RVA: 0x0030C696 File Offset: 0x0030A896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse()
		{
		}

		// Token: 0x0601504E RID: 86094 RVA: 0x0030C69E File Offset: 0x0030A89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse(RiskHarvestBuffUnlockRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601504F RID: 86095 RVA: 0x0030C6C3 File Offset: 0x0030A8C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse Clone()
		{
			return new RiskHarvestBuffUnlockRewardResponse(this);
		}

		// Token: 0x170045E9 RID: 17897
		// (get) Token: 0x06015050 RID: 86096 RVA: 0x0030C6CB File Offset: 0x0030A8CB
		// (set) Token: 0x06015051 RID: 86097 RVA: 0x0030C6D3 File Offset: 0x0030A8D3
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

		// Token: 0x06015052 RID: 86098 RVA: 0x0030C6DC File Offset: 0x0030A8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockRewardResponse);
		}

		// Token: 0x06015053 RID: 86099 RVA: 0x0030C6EA File Offset: 0x0030A8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015054 RID: 86100 RVA: 0x0030C718 File Offset: 0x0030A918
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

		// Token: 0x06015055 RID: 86101 RVA: 0x0030C75D File Offset: 0x0030A95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015056 RID: 86102 RVA: 0x0030C76A File Offset: 0x0030A96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x0030C773 File Offset: 0x0030A973
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

		// Token: 0x06015058 RID: 86104 RVA: 0x0030C7A8 File Offset: 0x0030A9A8
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

		// Token: 0x06015059 RID: 86105 RVA: 0x0030C7E6 File Offset: 0x0030A9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestBuffUnlockRewardResponse other)
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

		// Token: 0x0601505A RID: 86106 RVA: 0x0030C817 File Offset: 0x0030AA17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601505B RID: 86107 RVA: 0x0030C820 File Offset: 0x0030AA20
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

		// Token: 0x04007EA0 RID: 32416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EA1 RID: 32417
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04007EA2 RID: 32418
		private ErrorCode errorCode_;
	}
}
