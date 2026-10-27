using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000175 RID: 373
	[NetMessage(EMessageId.BattlePassTakeRewardResponse)]
	public sealed class BattlePassTakeRewardResponse : IMessage<BattlePassTakeRewardResponse>, IMessage, IEquatable<BattlePassTakeRewardResponse>, IDeepCloneable<BattlePassTakeRewardResponse>, IBufferMessage
	{
		// Token: 0x06002DAF RID: 11695 RVA: 0x0007614F File Offset: 0x0007434F
		[NullableContext(1)]
		public static BattlePassTakeRewardResponse Create()
		{
			return new BattlePassTakeRewardResponse();
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00076156 File Offset: 0x00074356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x00076159 File Offset: 0x00074359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00076160 File Offset: 0x00074360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse()
		{
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00076168 File Offset: 0x00074368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse(BattlePassTakeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x0007618D File Offset: 0x0007438D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardResponse Clone()
		{
			return new BattlePassTakeRewardResponse(this);
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x00076195 File Offset: 0x00074395
		// (set) Token: 0x06002DB6 RID: 11702 RVA: 0x0007619D File Offset: 0x0007439D
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

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000761A6 File Offset: 0x000743A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeRewardResponse);
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000761B4 File Offset: 0x000743B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000761E4 File Offset: 0x000743E4
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

		// Token: 0x06002DBA RID: 11706 RVA: 0x00076229 File Offset: 0x00074429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00076236 File Offset: 0x00074436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x0007623F File Offset: 0x0007443F
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

		// Token: 0x06002DBD RID: 11709 RVA: 0x00076274 File Offset: 0x00074474
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

		// Token: 0x06002DBE RID: 11710 RVA: 0x000762B2 File Offset: 0x000744B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeRewardResponse other)
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

		// Token: 0x06002DBF RID: 11711 RVA: 0x000762E3 File Offset: 0x000744E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000762EC File Offset: 0x000744EC
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

		// Token: 0x04002845 RID: 10309
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002846 RID: 10310
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002847 RID: 10311
		private ErrorCode errorCode_;
	}
}
