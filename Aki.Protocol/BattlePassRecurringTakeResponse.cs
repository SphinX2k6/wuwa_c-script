using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000172 RID: 370
	[NetMessage(EMessageId.BattlePassRecurringTakeResponse)]
	public sealed class BattlePassRecurringTakeResponse : IMessage<BattlePassRecurringTakeResponse>, IMessage, IEquatable<BattlePassRecurringTakeResponse>, IDeepCloneable<BattlePassRecurringTakeResponse>, IBufferMessage
	{
		// Token: 0x06002DB5 RID: 11701 RVA: 0x00076784 File Offset: 0x00074984
		[NullableContext(1)]
		public static BattlePassRecurringTakeResponse Create()
		{
			return new BattlePassRecurringTakeResponse();
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x0007678B File Offset: 0x0007498B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0007678E File Offset: 0x0007498E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRecurringTakeResponse.Descriptor;
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x00076795 File Offset: 0x00074995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse()
		{
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x0007679D File Offset: 0x0007499D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse(BattlePassRecurringTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000767C2 File Offset: 0x000749C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse Clone()
		{
			return new BattlePassRecurringTakeResponse(this);
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000767CA File Offset: 0x000749CA
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x000767D2 File Offset: 0x000749D2
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

		// Token: 0x06002DBD RID: 11709 RVA: 0x000767DB File Offset: 0x000749DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRecurringTakeResponse);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000767E9 File Offset: 0x000749E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRecurringTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x00076818 File Offset: 0x00074A18
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

		// Token: 0x06002DC0 RID: 11712 RVA: 0x0007685D File Offset: 0x00074A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x0007686A File Offset: 0x00074A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00076873 File Offset: 0x00074A73
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

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000768A8 File Offset: 0x00074AA8
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

		// Token: 0x06002DC4 RID: 11716 RVA: 0x000768E6 File Offset: 0x00074AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassRecurringTakeResponse other)
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

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00076917 File Offset: 0x00074B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00076920 File Offset: 0x00074B20
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

		// Token: 0x0400289F RID: 10399
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028A0 RID: 10400
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040028A1 RID: 10401
		private ErrorCode errorCode_;
	}
}
