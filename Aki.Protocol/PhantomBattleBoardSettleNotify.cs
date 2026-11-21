using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C27 RID: 3111
	[NetMessage(EMessageId.PhantomBattleBoardSettleNotify)]
	public sealed class PhantomBattleBoardSettleNotify : IMessage<PhantomBattleBoardSettleNotify>, IMessage, IEquatable<PhantomBattleBoardSettleNotify>, IDeepCloneable<PhantomBattleBoardSettleNotify>, IBufferMessage
	{
		// Token: 0x06010E59 RID: 69209 RVA: 0x00279BE8 File Offset: 0x00277DE8
		[NullableContext(1)]
		public static PhantomBattleBoardSettleNotify Create()
		{
			return new PhantomBattleBoardSettleNotify();
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x06010E5A RID: 69210 RVA: 0x00279BEF File Offset: 0x00277DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x06010E5B RID: 69211 RVA: 0x00279BF2 File Offset: 0x00277DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardSettleNotify.Descriptor;
			}
		}

		// Token: 0x06010E5C RID: 69212 RVA: 0x00279BF9 File Offset: 0x00277DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleNotify()
		{
		}

		// Token: 0x06010E5D RID: 69213 RVA: 0x00279C04 File Offset: 0x00277E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleNotify(PhantomBattleBoardSettleNotify other) : this()
		{
			this.isWin_ = other.isWin_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.actId_ = other.actId_;
			this.settleType_ = other.settleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E5E RID: 69214 RVA: 0x00279C68 File Offset: 0x00277E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleNotify Clone()
		{
			return new PhantomBattleBoardSettleNotify(this);
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x06010E5F RID: 69215 RVA: 0x00279C70 File Offset: 0x00277E70
		// (set) Token: 0x06010E60 RID: 69216 RVA: 0x00279C78 File Offset: 0x00277E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x06010E61 RID: 69217 RVA: 0x00279C81 File Offset: 0x00277E81
		// (set) Token: 0x06010E62 RID: 69218 RVA: 0x00279C89 File Offset: 0x00277E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSettleReward Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x06010E63 RID: 69219 RVA: 0x00279C92 File Offset: 0x00277E92
		// (set) Token: 0x06010E64 RID: 69220 RVA: 0x00279C9A File Offset: 0x00277E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActId
		{
			get
			{
				return this.actId_;
			}
			set
			{
				this.actId_ = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x06010E65 RID: 69221 RVA: 0x00279CA3 File Offset: 0x00277EA3
		// (set) Token: 0x06010E66 RID: 69222 RVA: 0x00279CAB File Offset: 0x00277EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleType SettleType
		{
			get
			{
				return this.settleType_;
			}
			set
			{
				this.settleType_ = value;
			}
		}

		// Token: 0x06010E67 RID: 69223 RVA: 0x00279CB4 File Offset: 0x00277EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardSettleNotify);
		}

		// Token: 0x06010E68 RID: 69224 RVA: 0x00279CC4 File Offset: 0x00277EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && object.Equals(this.Reward, other.Reward) && this.ActId == other.ActId && this.SettleType == other.SettleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E69 RID: 69225 RVA: 0x00279D34 File Offset: 0x00277F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.ActId != 0)
			{
				num ^= this.ActId.GetHashCode();
			}
			if (this.SettleType != PhantomBattleBoardSettleType.CommonSettle)
			{
				num ^= this.SettleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E6A RID: 69226 RVA: 0x00279DC1 File Offset: 0x00277FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E6B RID: 69227 RVA: 0x00279DCE File Offset: 0x00277FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E6C RID: 69228 RVA: 0x00279DD8 File Offset: 0x00277FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SettleType != PhantomBattleBoardSettleType.CommonSettle)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.SettleType);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsWin);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Reward);
			}
			if (this.ActId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E6D RID: 69229 RVA: 0x00279E6C File Offset: 0x0027806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.ActId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActId);
			}
			if (this.SettleType != PhantomBattleBoardSettleType.CommonSettle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SettleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E6E RID: 69230 RVA: 0x00279EE8 File Offset: 0x002780E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBoardSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new PhantomBattleSettleReward();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.ActId != 0)
			{
				this.ActId = other.ActId;
			}
			if (other.SettleType != PhantomBattleBoardSettleType.CommonSettle)
			{
				this.SettleType = other.SettleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E6F RID: 69231 RVA: 0x00279F78 File Offset: 0x00278178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E70 RID: 69232 RVA: 0x00279F84 File Offset: 0x00278184
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.SettleType = (PhantomBattleBoardSettleType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new PhantomBattleSettleReward();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 112U)
					{
						this.ActId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B9A RID: 27546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B9B RID: 27547
		public const int IsWinFieldNumber = 7;

		// Token: 0x04006B9C RID: 27548
		private bool isWin_;

		// Token: 0x04006B9D RID: 27549
		public const int RewardFieldNumber = 13;

		// Token: 0x04006B9E RID: 27550
		private PhantomBattleSettleReward reward_;

		// Token: 0x04006B9F RID: 27551
		public const int ActIdFieldNumber = 14;

		// Token: 0x04006BA0 RID: 27552
		private int actId_;

		// Token: 0x04006BA1 RID: 27553
		public const int SettleTypeFieldNumber = 4;

		// Token: 0x04006BA2 RID: 27554
		private PhantomBattleBoardSettleType settleType_;
	}
}
