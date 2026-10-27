using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD2 RID: 2770
	[NetMessage(EMessageId.MowTowerSettlementResponse)]
	public sealed class MowTowerSettlementResponse : IMessage<MowTowerSettlementResponse>, IMessage, IEquatable<MowTowerSettlementResponse>, IDeepCloneable<MowTowerSettlementResponse>, IBufferMessage
	{
		// Token: 0x0600F125 RID: 61733 RVA: 0x00233BAA File Offset: 0x00231DAA
		[NullableContext(1)]
		public static MowTowerSettlementResponse Create()
		{
			return new MowTowerSettlementResponse();
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600F126 RID: 61734 RVA: 0x00233BB1 File Offset: 0x00231DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600F127 RID: 61735 RVA: 0x00233BB4 File Offset: 0x00231DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerSettlementResponse.Descriptor;
			}
		}

		// Token: 0x0600F128 RID: 61736 RVA: 0x00233BBB File Offset: 0x00231DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse()
		{
		}

		// Token: 0x0600F129 RID: 61737 RVA: 0x00233BC3 File Offset: 0x00231DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse(MowTowerSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F12A RID: 61738 RVA: 0x00233BE8 File Offset: 0x00231DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerSettlementResponse Clone()
		{
			return new MowTowerSettlementResponse(this);
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600F12B RID: 61739 RVA: 0x00233BF0 File Offset: 0x00231DF0
		// (set) Token: 0x0600F12C RID: 61740 RVA: 0x00233BF8 File Offset: 0x00231DF8
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

		// Token: 0x0600F12D RID: 61741 RVA: 0x00233C01 File Offset: 0x00231E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerSettlementResponse);
		}

		// Token: 0x0600F12E RID: 61742 RVA: 0x00233C0F File Offset: 0x00231E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F12F RID: 61743 RVA: 0x00233C40 File Offset: 0x00231E40
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

		// Token: 0x0600F130 RID: 61744 RVA: 0x00233C85 File Offset: 0x00231E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F131 RID: 61745 RVA: 0x00233C92 File Offset: 0x00231E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F132 RID: 61746 RVA: 0x00233C9B File Offset: 0x00231E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F133 RID: 61747 RVA: 0x00233CD0 File Offset: 0x00231ED0
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

		// Token: 0x0600F134 RID: 61748 RVA: 0x00233D0E File Offset: 0x00231F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerSettlementResponse other)
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

		// Token: 0x0600F135 RID: 61749 RVA: 0x00233D3F File Offset: 0x00231F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F136 RID: 61750 RVA: 0x00233D48 File Offset: 0x00231F48
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006173 RID: 24947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006174 RID: 24948
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006175 RID: 24949
		private ErrorCode errorCode_;
	}
}
