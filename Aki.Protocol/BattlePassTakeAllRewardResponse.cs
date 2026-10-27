using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000173 RID: 371
	[NetMessage(EMessageId.BattlePassTakeAllRewardResponse)]
	public sealed class BattlePassTakeAllRewardResponse : IMessage<BattlePassTakeAllRewardResponse>, IMessage, IEquatable<BattlePassTakeAllRewardResponse>, IDeepCloneable<BattlePassTakeAllRewardResponse>, IBufferMessage
	{
		// Token: 0x06002D84 RID: 11652 RVA: 0x00075AA2 File Offset: 0x00073CA2
		[NullableContext(1)]
		public static BattlePassTakeAllRewardResponse Create()
		{
			return new BattlePassTakeAllRewardResponse();
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x00075AA9 File Offset: 0x00073CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x00075AAC File Offset: 0x00073CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeAllRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00075AB3 File Offset: 0x00073CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse()
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00075AD4 File Offset: 0x00073CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse(BattlePassTakeAllRewardResponse other) : this()
		{
			this.takenRewards_ = other.takenRewards_.Clone();
			this.recurringRewards_ = other.recurringRewards_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00075B26 File Offset: 0x00073D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse Clone()
		{
			return new BattlePassTakeAllRewardResponse(this);
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00075B2E File Offset: 0x00073D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassReward> TakenRewards
		{
			get
			{
				return this.takenRewards_;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00075B36 File Offset: 0x00073D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x00075B3E File Offset: 0x00073D3E
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x00075B46 File Offset: 0x00073D46
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

		// Token: 0x06002D8E RID: 11662 RVA: 0x00075B4F File Offset: 0x00073D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeAllRewardResponse);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x00075B60 File Offset: 0x00073D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeAllRewardResponse other)
		{
			return other != null && (other == this || (this.takenRewards_.Equals(other.takenRewards_) && this.recurringRewards_.Equals(other.recurringRewards_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00075BC4 File Offset: 0x00073DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.takenRewards_.GetHashCode();
			num ^= this.recurringRewards_.GetHashCode();
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

		// Token: 0x06002D91 RID: 11665 RVA: 0x00075C25 File Offset: 0x00073E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00075C32 File Offset: 0x00073E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00075C3C File Offset: 0x00073E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takenRewards_.WriteTo(ref output, BattlePassTakeAllRewardResponse._repeated_takenRewards_codec);
			this.recurringRewards_.WriteTo(ref output, BattlePassTakeAllRewardResponse._repeated_recurringRewards_codec);
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

		// Token: 0x06002D94 RID: 11668 RVA: 0x00075C9C File Offset: 0x00073E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.takenRewards_.CalculateSize(BattlePassTakeAllRewardResponse._repeated_takenRewards_codec);
			num += this.recurringRewards_.CalculateSize(BattlePassTakeAllRewardResponse._repeated_recurringRewards_codec);
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

		// Token: 0x06002D95 RID: 11669 RVA: 0x00075D00 File Offset: 0x00073F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeAllRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.takenRewards_.Add(other.takenRewards_);
			this.recurringRewards_.Add(other.recurringRewards_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00075D5E File Offset: 0x00073F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00075D68 File Offset: 0x00073F68
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
				if (num != 18U)
				{
					if (num != 98U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.recurringRewards_.AddEntriesFrom(ref input, BattlePassTakeAllRewardResponse._repeated_recurringRewards_codec);
					}
				}
				else
				{
					this.takenRewards_.AddEntriesFrom(ref input, BattlePassTakeAllRewardResponse._repeated_takenRewards_codec);
				}
			}
		}

		// Token: 0x04002835 RID: 10293
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002836 RID: 10294
		public const int TakenRewardsFieldNumber = 2;

		// Token: 0x04002837 RID: 10295
		private static readonly FieldCodec<PbBattlePassReward> _repeated_takenRewards_codec = FieldCodec.ForMessage<PbBattlePassReward>(18U, PbBattlePassReward.Parser);

		// Token: 0x04002838 RID: 10296
		private readonly RepeatedField<PbBattlePassReward> takenRewards_ = new RepeatedField<PbBattlePassReward>();

		// Token: 0x04002839 RID: 10297
		public const int RecurringRewardsFieldNumber = 12;

		// Token: 0x0400283A RID: 10298
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(98U, PbBattlePassRecurringReward.Parser);

		// Token: 0x0400283B RID: 10299
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();

		// Token: 0x0400283C RID: 10300
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400283D RID: 10301
		private ErrorCode errorCode_;
	}
}
