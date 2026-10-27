using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000152 RID: 338
	[NetMessage(EMessageId.BabelTowerSettlementResponse)]
	public sealed class BabelTowerSettlementResponse : IMessage<BabelTowerSettlementResponse>, IMessage, IEquatable<BabelTowerSettlementResponse>, IDeepCloneable<BabelTowerSettlementResponse>, IBufferMessage
	{
		// Token: 0x06002AF5 RID: 10997 RVA: 0x000704F6 File Offset: 0x0006E6F6
		[NullableContext(1)]
		public static BabelTowerSettlementResponse Create()
		{
			return new BabelTowerSettlementResponse();
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002AF6 RID: 10998 RVA: 0x000704FD File Offset: 0x0006E6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x00070500 File Offset: 0x0006E700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSettlementResponse.Descriptor;
			}
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00070507 File Offset: 0x0006E707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse()
		{
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0007050F File Offset: 0x0006E70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse(BabelTowerSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00070534 File Offset: 0x0006E734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse Clone()
		{
			return new BabelTowerSettlementResponse(this);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002AFB RID: 11003 RVA: 0x0007053C File Offset: 0x0006E73C
		// (set) Token: 0x06002AFC RID: 11004 RVA: 0x00070544 File Offset: 0x0006E744
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

		// Token: 0x06002AFD RID: 11005 RVA: 0x0007054D File Offset: 0x0006E74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSettlementResponse);
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0007055B File Offset: 0x0006E75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0007058C File Offset: 0x0006E78C
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

		// Token: 0x06002B00 RID: 11008 RVA: 0x000705D1 File Offset: 0x0006E7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000705DE File Offset: 0x0006E7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000705E7 File Offset: 0x0006E7E7
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

		// Token: 0x06002B03 RID: 11011 RVA: 0x0007061C File Offset: 0x0006E81C
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

		// Token: 0x06002B04 RID: 11012 RVA: 0x0007065A File Offset: 0x0006E85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSettlementResponse other)
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

		// Token: 0x06002B05 RID: 11013 RVA: 0x0007068B File Offset: 0x0006E88B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00070694 File Offset: 0x0006E894
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

		// Token: 0x04002782 RID: 10114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002783 RID: 10115
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002784 RID: 10116
		private ErrorCode errorCode_;
	}
}
