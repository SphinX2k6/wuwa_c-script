using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000176 RID: 374
	[NetMessage(EMessageId.BattlePassTakeAllRewardResponse)]
	public sealed class BattlePassTakeAllRewardResponse : IMessage<BattlePassTakeAllRewardResponse>, IMessage, IEquatable<BattlePassTakeAllRewardResponse>, IDeepCloneable<BattlePassTakeAllRewardResponse>, IBufferMessage
	{
		// Token: 0x06002DFB RID: 11771 RVA: 0x00076ECE File Offset: 0x000750CE
		[NullableContext(1)]
		public static BattlePassTakeAllRewardResponse Create()
		{
			return new BattlePassTakeAllRewardResponse();
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x00076ED5 File Offset: 0x000750D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00076ED8 File Offset: 0x000750D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeAllRewardResponse.Descriptor;
			}
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00076EDF File Offset: 0x000750DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse()
		{
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00076F00 File Offset: 0x00075100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse(BattlePassTakeAllRewardResponse other) : this()
		{
			this.takenRewards_ = other.takenRewards_.Clone();
			this.recurringRewards_ = other.recurringRewards_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00076F52 File Offset: 0x00075152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeAllRewardResponse Clone()
		{
			return new BattlePassTakeAllRewardResponse(this);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00076F5A File Offset: 0x0007515A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassReward> TakenRewards
		{
			get
			{
				return this.takenRewards_;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x00076F62 File Offset: 0x00075162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassRecurringReward> RecurringRewards
		{
			get
			{
				return this.recurringRewards_;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x00076F6A File Offset: 0x0007516A
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00076F72 File Offset: 0x00075172
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

		// Token: 0x06002E05 RID: 11781 RVA: 0x00076F7B File Offset: 0x0007517B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeAllRewardResponse);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x00076F8C File Offset: 0x0007518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeAllRewardResponse other)
		{
			return other != null && (other == this || (this.takenRewards_.Equals(other.takenRewards_) && this.recurringRewards_.Equals(other.recurringRewards_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00076FF0 File Offset: 0x000751F0
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

		// Token: 0x06002E08 RID: 11784 RVA: 0x00077051 File Offset: 0x00075251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0007705E File Offset: 0x0007525E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00077068 File Offset: 0x00075268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.recurringRewards_.WriteTo(ref output, BattlePassTakeAllRewardResponse._repeated_recurringRewards_codec);
			this.takenRewards_.WriteTo(ref output, BattlePassTakeAllRewardResponse._repeated_takenRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000770C8 File Offset: 0x000752C8
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

		// Token: 0x06002E0C RID: 11788 RVA: 0x0007712C File Offset: 0x0007532C
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

		// Token: 0x06002E0D RID: 11789 RVA: 0x0007718A File Offset: 0x0007538A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00077194 File Offset: 0x00075394
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
				if (num != 8U)
				{
					if (num != 34U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.takenRewards_.AddEntriesFrom(ref input, BattlePassTakeAllRewardResponse._repeated_takenRewards_codec);
						}
					}
					else
					{
						this.recurringRewards_.AddEntriesFrom(ref input, BattlePassTakeAllRewardResponse._repeated_recurringRewards_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040028A9 RID: 10409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028AA RID: 10410
		public const int TakenRewardsFieldNumber = 11;

		// Token: 0x040028AB RID: 10411
		private static readonly FieldCodec<PbBattlePassReward> _repeated_takenRewards_codec = FieldCodec.ForMessage<PbBattlePassReward>(90U, PbBattlePassReward.Parser);

		// Token: 0x040028AC RID: 10412
		private readonly RepeatedField<PbBattlePassReward> takenRewards_ = new RepeatedField<PbBattlePassReward>();

		// Token: 0x040028AD RID: 10413
		public const int RecurringRewardsFieldNumber = 4;

		// Token: 0x040028AE RID: 10414
		private static readonly FieldCodec<PbBattlePassRecurringReward> _repeated_recurringRewards_codec = FieldCodec.ForMessage<PbBattlePassRecurringReward>(34U, PbBattlePassRecurringReward.Parser);

		// Token: 0x040028AF RID: 10415
		private readonly RepeatedField<PbBattlePassRecurringReward> recurringRewards_ = new RepeatedField<PbBattlePassRecurringReward>();

		// Token: 0x040028B0 RID: 10416
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040028B1 RID: 10417
		private ErrorCode errorCode_;
	}
}
