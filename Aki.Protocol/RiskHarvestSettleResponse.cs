using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F56 RID: 3926
	[NetMessage(EMessageId.RiskHarvestSettleResponse)]
	public sealed class RiskHarvestSettleResponse : IMessage<RiskHarvestSettleResponse>, IMessage, IEquatable<RiskHarvestSettleResponse>, IDeepCloneable<RiskHarvestSettleResponse>, IBufferMessage
	{
		// Token: 0x0601505D RID: 86109 RVA: 0x0030D10E File Offset: 0x0030B30E
		[NullableContext(1)]
		public static RiskHarvestSettleResponse Create()
		{
			return new RiskHarvestSettleResponse();
		}

		// Token: 0x170045F2 RID: 17906
		// (get) Token: 0x0601505E RID: 86110 RVA: 0x0030D115 File Offset: 0x0030B315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045F3 RID: 17907
		// (get) Token: 0x0601505F RID: 86111 RVA: 0x0030D118 File Offset: 0x0030B318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestSettleResponse.Descriptor;
			}
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x0030D11F File Offset: 0x0030B31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse()
		{
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x0030D127 File Offset: 0x0030B327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse(RiskHarvestSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015062 RID: 86114 RVA: 0x0030D14C File Offset: 0x0030B34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleResponse Clone()
		{
			return new RiskHarvestSettleResponse(this);
		}

		// Token: 0x170045F4 RID: 17908
		// (get) Token: 0x06015063 RID: 86115 RVA: 0x0030D154 File Offset: 0x0030B354
		// (set) Token: 0x06015064 RID: 86116 RVA: 0x0030D15C File Offset: 0x0030B35C
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

		// Token: 0x06015065 RID: 86117 RVA: 0x0030D165 File Offset: 0x0030B365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestSettleResponse);
		}

		// Token: 0x06015066 RID: 86118 RVA: 0x0030D173 File Offset: 0x0030B373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015067 RID: 86119 RVA: 0x0030D1A4 File Offset: 0x0030B3A4
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

		// Token: 0x06015068 RID: 86120 RVA: 0x0030D1E9 File Offset: 0x0030B3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015069 RID: 86121 RVA: 0x0030D1F6 File Offset: 0x0030B3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601506A RID: 86122 RVA: 0x0030D1FF File Offset: 0x0030B3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601506B RID: 86123 RVA: 0x0030D234 File Offset: 0x0030B434
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

		// Token: 0x0601506C RID: 86124 RVA: 0x0030D272 File Offset: 0x0030B472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestSettleResponse other)
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

		// Token: 0x0601506D RID: 86125 RVA: 0x0030D2A3 File Offset: 0x0030B4A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601506E RID: 86126 RVA: 0x0030D2AC File Offset: 0x0030B4AC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F13 RID: 32531
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F14 RID: 32532
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04007F15 RID: 32533
		private ErrorCode errorCode_;
	}
}
