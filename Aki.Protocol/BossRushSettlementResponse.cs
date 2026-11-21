using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E4 RID: 484
	[NetMessage(EMessageId.BossRushSettlementResponse)]
	public sealed class BossRushSettlementResponse : IMessage<BossRushSettlementResponse>, IMessage, IEquatable<BossRushSettlementResponse>, IDeepCloneable<BossRushSettlementResponse>, IBufferMessage
	{
		// Token: 0x060036B0 RID: 14000 RVA: 0x0008989A File Offset: 0x00087A9A
		[NullableContext(1)]
		public static BossRushSettlementResponse Create()
		{
			return new BossRushSettlementResponse();
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x000898A1 File Offset: 0x00087AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000898A4 File Offset: 0x00087AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushSettlementResponse.Descriptor;
			}
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000898AB File Offset: 0x00087AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse()
		{
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000898B3 File Offset: 0x00087AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse(BossRushSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000898D8 File Offset: 0x00087AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushSettlementResponse Clone()
		{
			return new BossRushSettlementResponse(this);
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000898E0 File Offset: 0x00087AE0
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x000898E8 File Offset: 0x00087AE8
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

		// Token: 0x060036B8 RID: 14008 RVA: 0x000898F1 File Offset: 0x00087AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushSettlementResponse);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000898FF File Offset: 0x00087AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00089930 File Offset: 0x00087B30
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

		// Token: 0x060036BB RID: 14011 RVA: 0x00089975 File Offset: 0x00087B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00089982 File Offset: 0x00087B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x0008998B File Offset: 0x00087B8B
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

		// Token: 0x060036BE RID: 14014 RVA: 0x000899C0 File Offset: 0x00087BC0
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

		// Token: 0x060036BF RID: 14015 RVA: 0x000899FE File Offset: 0x00087BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushSettlementResponse other)
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

		// Token: 0x060036C0 RID: 14016 RVA: 0x00089A2F File Offset: 0x00087C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00089A38 File Offset: 0x00087C38
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

		// Token: 0x04002B0D RID: 11021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B0E RID: 11022
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002B0F RID: 11023
		private ErrorCode errorCode_;
	}
}
