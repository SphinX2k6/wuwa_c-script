using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C90 RID: 3216
	[NetMessage(EMessageId.PhantomBattleReChallengeResponse)]
	public sealed class PhantomBattleReChallengeResponse : IMessage<PhantomBattleReChallengeResponse>, IMessage, IEquatable<PhantomBattleReChallengeResponse>, IDeepCloneable<PhantomBattleReChallengeResponse>, IBufferMessage
	{
		// Token: 0x06011735 RID: 71477 RVA: 0x0028EEB4 File Offset: 0x0028D0B4
		[NullableContext(1)]
		public static PhantomBattleReChallengeResponse Create()
		{
			return new PhantomBattleReChallengeResponse();
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x06011736 RID: 71478 RVA: 0x0028EEBB File Offset: 0x0028D0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x06011737 RID: 71479 RVA: 0x0028EEBE File Offset: 0x0028D0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x06011738 RID: 71480 RVA: 0x0028EEC5 File Offset: 0x0028D0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse()
		{
		}

		// Token: 0x06011739 RID: 71481 RVA: 0x0028EED0 File Offset: 0x0028D0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse(PhantomBattleReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.challengeId_ = other.challengeId_;
			this.phantomBattleNPCId_ = other.phantomBattleNPCId_;
			this.cardGroupId_ = other.cardGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601173A RID: 71482 RVA: 0x0028EF24 File Offset: 0x0028D124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse Clone()
		{
			return new PhantomBattleReChallengeResponse(this);
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0601173B RID: 71483 RVA: 0x0028EF2C File Offset: 0x0028D12C
		// (set) Token: 0x0601173C RID: 71484 RVA: 0x0028EF34 File Offset: 0x0028D134
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

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0601173D RID: 71485 RVA: 0x0028EF3D File Offset: 0x0028D13D
		// (set) Token: 0x0601173E RID: 71486 RVA: 0x0028EF45 File Offset: 0x0028D145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0601173F RID: 71487 RVA: 0x0028EF4E File Offset: 0x0028D14E
		// (set) Token: 0x06011740 RID: 71488 RVA: 0x0028EF56 File Offset: 0x0028D156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleNPCId
		{
			get
			{
				return this.phantomBattleNPCId_;
			}
			set
			{
				this.phantomBattleNPCId_ = value;
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x06011741 RID: 71489 RVA: 0x0028EF5F File Offset: 0x0028D15F
		// (set) Token: 0x06011742 RID: 71490 RVA: 0x0028EF67 File Offset: 0x0028D167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardGroupId
		{
			get
			{
				return this.cardGroupId_;
			}
			set
			{
				this.cardGroupId_ = value;
			}
		}

		// Token: 0x06011743 RID: 71491 RVA: 0x0028EF70 File Offset: 0x0028D170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReChallengeResponse);
		}

		// Token: 0x06011744 RID: 71492 RVA: 0x0028EF80 File Offset: 0x0028D180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ChallengeId == other.ChallengeId && this.PhantomBattleNPCId == other.PhantomBattleNPCId && this.CardGroupId == other.CardGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011745 RID: 71493 RVA: 0x0028EFEC File Offset: 0x0028D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.PhantomBattleNPCId != 0)
			{
				num ^= this.PhantomBattleNPCId.GetHashCode();
			}
			if (this.CardGroupId != 0)
			{
				num ^= this.CardGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011746 RID: 71494 RVA: 0x0028F07C File Offset: 0x0028D27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011747 RID: 71495 RVA: 0x0028F089 File Offset: 0x0028D289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x0028F094 File Offset: 0x0028D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleNPCId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PhantomBattleNPCId);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CardGroupId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CardGroupId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011749 RID: 71497 RVA: 0x0028F128 File Offset: 0x0028D328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.PhantomBattleNPCId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleNPCId);
			}
			if (this.CardGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601174A RID: 71498 RVA: 0x0028F1B0 File Offset: 0x0028D3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReChallengeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.PhantomBattleNPCId != 0)
			{
				this.PhantomBattleNPCId = other.PhantomBattleNPCId;
			}
			if (other.CardGroupId != 0)
			{
				this.CardGroupId = other.CardGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601174B RID: 71499 RVA: 0x0028F228 File Offset: 0x0028D428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601174C RID: 71500 RVA: 0x0028F234 File Offset: 0x0028D434
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
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.PhantomBattleNPCId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.CardGroupId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E82 RID: 28290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E83 RID: 28291
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006E84 RID: 28292
		private ErrorCode errorCode_;

		// Token: 0x04006E85 RID: 28293
		public const int ChallengeIdFieldNumber = 8;

		// Token: 0x04006E86 RID: 28294
		private int challengeId_;

		// Token: 0x04006E87 RID: 28295
		public const int PhantomBattleNPCIdFieldNumber = 2;

		// Token: 0x04006E88 RID: 28296
		private int phantomBattleNPCId_;

		// Token: 0x04006E89 RID: 28297
		public const int CardGroupIdFieldNumber = 11;

		// Token: 0x04006E8A RID: 28298
		private int cardGroupId_;
	}
}
