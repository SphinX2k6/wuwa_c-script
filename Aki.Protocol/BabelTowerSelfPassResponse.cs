using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000150 RID: 336
	[NetMessage(EMessageId.BabelTowerSelfPassResponse)]
	public sealed class BabelTowerSelfPassResponse : IMessage<BabelTowerSelfPassResponse>, IMessage, IEquatable<BabelTowerSelfPassResponse>, IDeepCloneable<BabelTowerSelfPassResponse>, IBufferMessage
	{
		// Token: 0x06002AD1 RID: 10961 RVA: 0x000700C4 File Offset: 0x0006E2C4
		[NullableContext(1)]
		public static BabelTowerSelfPassResponse Create()
		{
			return new BabelTowerSelfPassResponse();
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000700CB File Offset: 0x0006E2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000700CE File Offset: 0x0006E2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000700D5 File Offset: 0x0006E2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse()
		{
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000700E0 File Offset: 0x0006E2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse(BabelTowerSelfPassResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfPassData_ = ((other.selfPassData_ != null) ? other.selfPassData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x0007012C File Offset: 0x0006E32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse Clone()
		{
			return new BabelTowerSelfPassResponse(this);
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x00070134 File Offset: 0x0006E334
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0007013C File Offset: 0x0006E33C
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x00070145 File Offset: 0x0006E345
		// (set) Token: 0x06002ADA RID: 10970 RVA: 0x0007014D File Offset: 0x0006E34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
			set
			{
				this.selfPassData_ = value;
			}
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00070156 File Offset: 0x0006E356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSelfPassResponse);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00070164 File Offset: 0x0006E364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSelfPassResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfPassData, other.SelfPassData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000701B4 File Offset: 0x0006E3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.selfPassData_ != null)
			{
				num ^= this.SelfPassData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0007020F File Offset: 0x0006E40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0007021C File Offset: 0x0006E41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00070228 File Offset: 0x0006E428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selfPassData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SelfPassData);
			}
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

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00070284 File Offset: 0x0006E484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.selfPassData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfPassData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000702DC File Offset: 0x0006E4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSelfPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.selfPassData_ != null)
			{
				if (this.selfPassData_ == null)
				{
					this.SelfPassData = new PublicBabelTowerInfo();
				}
				this.SelfPassData.MergeFrom(other.SelfPassData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00070344 File Offset: 0x0006E544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00070350 File Offset: 0x0006E550
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
				if (num != 66U)
				{
					if (num != 96U)
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
					if (this.selfPassData_ == null)
					{
						this.SelfPassData = new PublicBabelTowerInfo();
					}
					input.ReadMessage(this.SelfPassData);
				}
			}
		}

		// Token: 0x0400277C RID: 10108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400277D RID: 10109
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400277E RID: 10110
		private ErrorCode errorCode_;

		// Token: 0x0400277F RID: 10111
		public const int SelfPassDataFieldNumber = 8;

		// Token: 0x04002780 RID: 10112
		private PublicBabelTowerInfo selfPassData_;
	}
}
