using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4A RID: 3914
	[NetMessage(EMessageId.RiskHarvestBuffUnlockRewardResponse)]
	public sealed class RiskHarvestBuffUnlockRewardResponse : IMessage<RiskHarvestBuffUnlockRewardResponse>, IMessage, IEquatable<RiskHarvestBuffUnlockRewardResponse>, IDeepCloneable<RiskHarvestBuffUnlockRewardResponse>, IBufferMessage
	{
		// Token: 0x06014F65 RID: 85861 RVA: 0x0030AFCD File Offset: 0x003091CD
		[NullableContext(1)]
		public static RiskHarvestBuffUnlockRewardResponse Create()
		{
			return new RiskHarvestBuffUnlockRewardResponse();
		}

		// Token: 0x170045BD RID: 17853
		// (get) Token: 0x06014F66 RID: 85862 RVA: 0x0030AFD4 File Offset: 0x003091D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045BE RID: 17854
		// (get) Token: 0x06014F67 RID: 85863 RVA: 0x0030AFD7 File Offset: 0x003091D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestBuffUnlockRewardResponse.Descriptor;
			}
		}

		// Token: 0x06014F68 RID: 85864 RVA: 0x0030AFDE File Offset: 0x003091DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse()
		{
		}

		// Token: 0x06014F69 RID: 85865 RVA: 0x0030AFE6 File Offset: 0x003091E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse(RiskHarvestBuffUnlockRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F6A RID: 85866 RVA: 0x0030B00B File Offset: 0x0030920B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestBuffUnlockRewardResponse Clone()
		{
			return new RiskHarvestBuffUnlockRewardResponse(this);
		}

		// Token: 0x170045BF RID: 17855
		// (get) Token: 0x06014F6B RID: 85867 RVA: 0x0030B013 File Offset: 0x00309213
		// (set) Token: 0x06014F6C RID: 85868 RVA: 0x0030B01B File Offset: 0x0030921B
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

		// Token: 0x06014F6D RID: 85869 RVA: 0x0030B024 File Offset: 0x00309224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestBuffUnlockRewardResponse);
		}

		// Token: 0x06014F6E RID: 85870 RVA: 0x0030B032 File Offset: 0x00309232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestBuffUnlockRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F6F RID: 85871 RVA: 0x0030B060 File Offset: 0x00309260
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

		// Token: 0x06014F70 RID: 85872 RVA: 0x0030B0A5 File Offset: 0x003092A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F71 RID: 85873 RVA: 0x0030B0B2 File Offset: 0x003092B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F72 RID: 85874 RVA: 0x0030B0BB File Offset: 0x003092BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06014F73 RID: 85875 RVA: 0x0030B0F0 File Offset: 0x003092F0
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

		// Token: 0x06014F74 RID: 85876 RVA: 0x0030B12E File Offset: 0x0030932E
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

		// Token: 0x06014F75 RID: 85877 RVA: 0x0030B15F File Offset: 0x0030935F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F76 RID: 85878 RVA: 0x0030B168 File Offset: 0x00309368
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007ECA RID: 32458
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007ECB RID: 32459
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04007ECC RID: 32460
		private ErrorCode errorCode_;
	}
}
