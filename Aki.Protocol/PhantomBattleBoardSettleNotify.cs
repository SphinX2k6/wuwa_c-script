using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C37 RID: 3127
	[NetMessage(EMessageId.PhantomBattleBoardSettleNotify)]
	public sealed class PhantomBattleBoardSettleNotify : IMessage<PhantomBattleBoardSettleNotify>, IMessage, IEquatable<PhantomBattleBoardSettleNotify>, IDeepCloneable<PhantomBattleBoardSettleNotify>, IBufferMessage
	{
		// Token: 0x06010F59 RID: 69465 RVA: 0x0027B94B File Offset: 0x00279B4B
		[NullableContext(1)]
		public static PhantomBattleBoardSettleNotify Create()
		{
			return new PhantomBattleBoardSettleNotify();
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x06010F5A RID: 69466 RVA: 0x0027B952 File Offset: 0x00279B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x06010F5B RID: 69467 RVA: 0x0027B955 File Offset: 0x00279B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardSettleNotify.Descriptor;
			}
		}

		// Token: 0x06010F5C RID: 69468 RVA: 0x0027B95C File Offset: 0x00279B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleNotify()
		{
		}

		// Token: 0x06010F5D RID: 69469 RVA: 0x0027B964 File Offset: 0x00279B64
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

		// Token: 0x06010F5E RID: 69470 RVA: 0x0027B9C8 File Offset: 0x00279BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardSettleNotify Clone()
		{
			return new PhantomBattleBoardSettleNotify(this);
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x06010F5F RID: 69471 RVA: 0x0027B9D0 File Offset: 0x00279BD0
		// (set) Token: 0x06010F60 RID: 69472 RVA: 0x0027B9D8 File Offset: 0x00279BD8
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

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x06010F61 RID: 69473 RVA: 0x0027B9E1 File Offset: 0x00279BE1
		// (set) Token: 0x06010F62 RID: 69474 RVA: 0x0027B9E9 File Offset: 0x00279BE9
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

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x06010F63 RID: 69475 RVA: 0x0027B9F2 File Offset: 0x00279BF2
		// (set) Token: 0x06010F64 RID: 69476 RVA: 0x0027B9FA File Offset: 0x00279BFA
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

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x06010F65 RID: 69477 RVA: 0x0027BA03 File Offset: 0x00279C03
		// (set) Token: 0x06010F66 RID: 69478 RVA: 0x0027BA0B File Offset: 0x00279C0B
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

		// Token: 0x06010F67 RID: 69479 RVA: 0x0027BA14 File Offset: 0x00279C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardSettleNotify);
		}

		// Token: 0x06010F68 RID: 69480 RVA: 0x0027BA24 File Offset: 0x00279C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardSettleNotify other)
		{
			return other != null && (other == this || (this.IsWin == other.IsWin && object.Equals(this.Reward, other.Reward) && this.ActId == other.ActId && this.SettleType == other.SettleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F69 RID: 69481 RVA: 0x0027BA94 File Offset: 0x00279C94
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

		// Token: 0x06010F6A RID: 69482 RVA: 0x0027BB21 File Offset: 0x00279D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F6B RID: 69483 RVA: 0x0027BB2E File Offset: 0x00279D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F6C RID: 69484 RVA: 0x0027BB38 File Offset: 0x00279D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SettleType != PhantomBattleBoardSettleType.CommonSettle)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.SettleType);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Reward);
			}
			if (this.IsWin)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsWin);
			}
			if (this.ActId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F6D RID: 69485 RVA: 0x0027BBCC File Offset: 0x00279DCC
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

		// Token: 0x06010F6E RID: 69486 RVA: 0x0027BC48 File Offset: 0x00279E48
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

		// Token: 0x06010F6F RID: 69487 RVA: 0x0027BCD8 File Offset: 0x00279ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F70 RID: 69488 RVA: 0x0027BCE4 File Offset: 0x00279EE4
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
				if (num <= 50U)
				{
					if (num == 40U)
					{
						this.SettleType = (PhantomBattleBoardSettleType)input.ReadEnum();
						continue;
					}
					if (num == 50U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new PhantomBattleSettleReward();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.ActId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B86 RID: 27526
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B87 RID: 27527
		public const int IsWinFieldNumber = 9;

		// Token: 0x04006B88 RID: 27528
		private bool isWin_;

		// Token: 0x04006B89 RID: 27529
		public const int RewardFieldNumber = 6;

		// Token: 0x04006B8A RID: 27530
		private PhantomBattleSettleReward reward_;

		// Token: 0x04006B8B RID: 27531
		public const int ActIdFieldNumber = 10;

		// Token: 0x04006B8C RID: 27532
		private int actId_;

		// Token: 0x04006B8D RID: 27533
		public const int SettleTypeFieldNumber = 5;

		// Token: 0x04006B8E RID: 27534
		private PhantomBattleBoardSettleType settleType_;
	}
}
