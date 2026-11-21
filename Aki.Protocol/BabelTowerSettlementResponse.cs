using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000155 RID: 341
	[NetMessage(EMessageId.BabelTowerSettlementResponse)]
	public sealed class BabelTowerSettlementResponse : IMessage<BabelTowerSettlementResponse>, IMessage, IEquatable<BabelTowerSettlementResponse>, IDeepCloneable<BabelTowerSettlementResponse>, IBufferMessage
	{
		// Token: 0x06002B6C RID: 11116 RVA: 0x00071926 File Offset: 0x0006FB26
		[NullableContext(1)]
		public static BabelTowerSettlementResponse Create()
		{
			return new BabelTowerSettlementResponse();
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x0007192D File Offset: 0x0006FB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x00071930 File Offset: 0x0006FB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSettlementResponse.Descriptor;
			}
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x00071937 File Offset: 0x0006FB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse()
		{
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0007193F File Offset: 0x0006FB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse(BabelTowerSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x00071964 File Offset: 0x0006FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementResponse Clone()
		{
			return new BabelTowerSettlementResponse(this);
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x0007196C File Offset: 0x0006FB6C
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x00071974 File Offset: 0x0006FB74
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

		// Token: 0x06002B74 RID: 11124 RVA: 0x0007197D File Offset: 0x0006FB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSettlementResponse);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0007198B File Offset: 0x0006FB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000719BC File Offset: 0x0006FBBC
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

		// Token: 0x06002B77 RID: 11127 RVA: 0x00071A01 File Offset: 0x0006FC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00071A0E File Offset: 0x0006FC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00071A17 File Offset: 0x0006FC17
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x00071A4C File Offset: 0x0006FC4C
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

		// Token: 0x06002B7B RID: 11131 RVA: 0x00071A8A File Offset: 0x0006FC8A
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

		// Token: 0x06002B7C RID: 11132 RVA: 0x00071ABB File Offset: 0x0006FCBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00071AC4 File Offset: 0x0006FCC4
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

		// Token: 0x040027F6 RID: 10230
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F7 RID: 10231
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040027F8 RID: 10232
		private ErrorCode errorCode_;
	}
}
