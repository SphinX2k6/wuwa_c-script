using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C86 RID: 3206
	[NetMessage(EMessageId.PhantomBattleEvolveResponse)]
	public sealed class PhantomBattleEvolveResponse : IMessage<PhantomBattleEvolveResponse>, IMessage, IEquatable<PhantomBattleEvolveResponse>, IDeepCloneable<PhantomBattleEvolveResponse>, IBufferMessage
	{
		// Token: 0x06011610 RID: 71184 RVA: 0x0028BE6C File Offset: 0x0028A06C
		[NullableContext(1)]
		public static PhantomBattleEvolveResponse Create()
		{
			return new PhantomBattleEvolveResponse();
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x06011611 RID: 71185 RVA: 0x0028BE73 File Offset: 0x0028A073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x06011612 RID: 71186 RVA: 0x0028BE76 File Offset: 0x0028A076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEvolveResponse.Descriptor;
			}
		}

		// Token: 0x06011613 RID: 71187 RVA: 0x0028BE7D File Offset: 0x0028A07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse()
		{
		}

		// Token: 0x06011614 RID: 71188 RVA: 0x0028BE88 File Offset: 0x0028A088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse(PhantomBattleEvolveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.canEvolveNum_ = other.canEvolveNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011615 RID: 71189 RVA: 0x0028BEEC File Offset: 0x0028A0EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveResponse Clone()
		{
			return new PhantomBattleEvolveResponse(this);
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x06011616 RID: 71190 RVA: 0x0028BEF4 File Offset: 0x0028A0F4
		// (set) Token: 0x06011617 RID: 71191 RVA: 0x0028BEFC File Offset: 0x0028A0FC
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

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x06011618 RID: 71192 RVA: 0x0028BF05 File Offset: 0x0028A105
		// (set) Token: 0x06011619 RID: 71193 RVA: 0x0028BF0D File Offset: 0x0028A10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0601161A RID: 71194 RVA: 0x0028BF16 File Offset: 0x0028A116
		// (set) Token: 0x0601161B RID: 71195 RVA: 0x0028BF1E File Offset: 0x0028A11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CanEvolveNum
		{
			get
			{
				return this.canEvolveNum_;
			}
			set
			{
				this.canEvolveNum_ = value;
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0601161C RID: 71196 RVA: 0x0028BF27 File Offset: 0x0028A127
		// (set) Token: 0x0601161D RID: 71197 RVA: 0x0028BF2F File Offset: 0x0028A12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0601161E RID: 71198 RVA: 0x0028BF38 File Offset: 0x0028A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEvolveResponse);
		}

		// Token: 0x0601161F RID: 71199 RVA: 0x0028BF48 File Offset: 0x0028A148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEvolveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CanEvolveNum == other.CanEvolveNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011620 RID: 71200 RVA: 0x0028BFB8 File Offset: 0x0028A1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this.CanEvolveNum != 0)
			{
				num ^= this.CanEvolveNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011621 RID: 71201 RVA: 0x0028C045 File Offset: 0x0028A245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011622 RID: 71202 RVA: 0x0028C052 File Offset: 0x0028A252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011623 RID: 71203 RVA: 0x0028C05C File Offset: 0x0028A25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this.CanEvolveNum != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CanEvolveNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011624 RID: 71204 RVA: 0x0028C0F0 File Offset: 0x0028A2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this.CanEvolveNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CanEvolveNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011625 RID: 71205 RVA: 0x0028C178 File Offset: 0x0028A378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEvolveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			if (other.CanEvolveNum != 0)
			{
				this.CanEvolveNum = other.CanEvolveNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011626 RID: 71206 RVA: 0x0028C208 File Offset: 0x0028A408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011627 RID: 71207 RVA: 0x0028C214 File Offset: 0x0028A414
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
				if (num <= 90U)
				{
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						if (this.phantomBattleFighterInfo_ == null)
						{
							this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
						}
						input.ReadMessage(this.PhantomBattleFighterInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CardLibraryNum = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.CanEvolveNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006DC8 RID: 28104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DC9 RID: 28105
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006DCA RID: 28106
		private ErrorCode errorCode_;

		// Token: 0x04006DCB RID: 28107
		public const int PhantomBattleFighterInfoFieldNumber = 11;

		// Token: 0x04006DCC RID: 28108
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x04006DCD RID: 28109
		public const int CanEvolveNumFieldNumber = 14;

		// Token: 0x04006DCE RID: 28110
		private int canEvolveNum_;

		// Token: 0x04006DCF RID: 28111
		public const int CardLibraryNumFieldNumber = 12;

		// Token: 0x04006DD0 RID: 28112
		private int cardLibraryNum_;
	}
}
