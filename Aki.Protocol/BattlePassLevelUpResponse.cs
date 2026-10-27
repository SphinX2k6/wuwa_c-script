using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016C RID: 364
	[NetMessage(EMessageId.BattlePassLevelUpResponse)]
	public sealed class BattlePassLevelUpResponse : IMessage<BattlePassLevelUpResponse>, IMessage, IEquatable<BattlePassLevelUpResponse>, IDeepCloneable<BattlePassLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x00074CF9 File Offset: 0x00072EF9
		[NullableContext(1)]
		public static BattlePassLevelUpResponse Create()
		{
			return new BattlePassLevelUpResponse();
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x00074D00 File Offset: 0x00072F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00074D03 File Offset: 0x00072F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00074D0A File Offset: 0x00072F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse()
		{
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00074D12 File Offset: 0x00072F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse(BattlePassLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00074D37 File Offset: 0x00072F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassLevelUpResponse Clone()
		{
			return new BattlePassLevelUpResponse(this);
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x00074D3F File Offset: 0x00072F3F
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00074D47 File Offset: 0x00072F47
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

		// Token: 0x06002D0E RID: 11534 RVA: 0x00074D50 File Offset: 0x00072F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassLevelUpResponse);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00074D5E File Offset: 0x00072F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x00074D8C File Offset: 0x00072F8C
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

		// Token: 0x06002D11 RID: 11537 RVA: 0x00074DD1 File Offset: 0x00072FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00074DDE File Offset: 0x00072FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00074DE7 File Offset: 0x00072FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06002D14 RID: 11540 RVA: 0x00074E1C File Offset: 0x0007301C
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

		// Token: 0x06002D15 RID: 11541 RVA: 0x00074E5A File Offset: 0x0007305A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassLevelUpResponse other)
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

		// Token: 0x06002D16 RID: 11542 RVA: 0x00074E8B File Offset: 0x0007308B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00074E94 File Offset: 0x00073094
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002820 RID: 10272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002821 RID: 10273
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002822 RID: 10274
		private ErrorCode errorCode_;
	}
}
