using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6C RID: 3180
	[NetMessage(EMessageId.PhantomBattleChallengeUpdateNotify)]
	public sealed class PhantomBattleChallengeUpdateNotify : IMessage<PhantomBattleChallengeUpdateNotify>, IMessage, IEquatable<PhantomBattleChallengeUpdateNotify>, IDeepCloneable<PhantomBattleChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x060113D0 RID: 70608 RVA: 0x0028615D File Offset: 0x0028435D
		[NullableContext(1)]
		public static PhantomBattleChallengeUpdateNotify Create()
		{
			return new PhantomBattleChallengeUpdateNotify();
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x060113D1 RID: 70609 RVA: 0x00286164 File Offset: 0x00284364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x060113D2 RID: 70610 RVA: 0x00286167 File Offset: 0x00284367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060113D3 RID: 70611 RVA: 0x0028616E File Offset: 0x0028436E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify()
		{
		}

		// Token: 0x060113D4 RID: 70612 RVA: 0x00286184 File Offset: 0x00284384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify(PhantomBattleChallengeUpdateNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.challengeId_ = other.challengeId_;
			this.firstWin_ = other.firstWin_;
			this.unlock_ = other.unlock_;
			this.isUncover_ = other.isUncover_;
			this.isShow_ = other.isShow_;
			this.isPassRewarded_ = other.isPassRewarded_;
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113D5 RID: 70613 RVA: 0x0028620D File Offset: 0x0028440D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify Clone()
		{
			return new PhantomBattleChallengeUpdateNotify(this);
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x060113D6 RID: 70614 RVA: 0x00286215 File Offset: 0x00284415
		// (set) Token: 0x060113D7 RID: 70615 RVA: 0x0028621D File Offset: 0x0028441D
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

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x060113D8 RID: 70616 RVA: 0x00286226 File Offset: 0x00284426
		// (set) Token: 0x060113D9 RID: 70617 RVA: 0x0028622E File Offset: 0x0028442E
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

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x060113DA RID: 70618 RVA: 0x00286237 File Offset: 0x00284437
		// (set) Token: 0x060113DB RID: 70619 RVA: 0x0028623F File Offset: 0x0028443F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstWin
		{
			get
			{
				return this.firstWin_;
			}
			set
			{
				this.firstWin_ = value;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x060113DC RID: 70620 RVA: 0x00286248 File Offset: 0x00284448
		// (set) Token: 0x060113DD RID: 70621 RVA: 0x00286250 File Offset: 0x00284450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x060113DE RID: 70622 RVA: 0x00286259 File Offset: 0x00284459
		// (set) Token: 0x060113DF RID: 70623 RVA: 0x00286261 File Offset: 0x00284461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUncover
		{
			get
			{
				return this.isUncover_;
			}
			set
			{
				this.isUncover_ = value;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x060113E0 RID: 70624 RVA: 0x0028626A File Offset: 0x0028446A
		// (set) Token: 0x060113E1 RID: 70625 RVA: 0x00286272 File Offset: 0x00284472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x060113E2 RID: 70626 RVA: 0x0028627B File Offset: 0x0028447B
		// (set) Token: 0x060113E3 RID: 70627 RVA: 0x00286283 File Offset: 0x00284483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPassRewarded
		{
			get
			{
				return this.isPassRewarded_;
			}
			set
			{
				this.isPassRewarded_ = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x060113E4 RID: 70628 RVA: 0x0028628C File Offset: 0x0028448C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x060113E5 RID: 70629 RVA: 0x00286294 File Offset: 0x00284494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeUpdateNotify);
		}

		// Token: 0x060113E6 RID: 70630 RVA: 0x002862A4 File Offset: 0x002844A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ChallengeId == other.ChallengeId && this.FirstWin == other.FirstWin && this.Unlock == other.Unlock && this.IsUncover == other.IsUncover && this.IsShow == other.IsShow && this.IsPassRewarded == other.IsPassRewarded && this.challengeInfo_.Equals(other.challengeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113E7 RID: 70631 RVA: 0x00286354 File Offset: 0x00284554
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
			if (this.FirstWin)
			{
				num ^= this.FirstWin.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.IsUncover)
			{
				num ^= this.IsUncover.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.IsPassRewarded)
			{
				num ^= this.IsPassRewarded.GetHashCode();
			}
			num ^= this.challengeInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113E8 RID: 70632 RVA: 0x0028643D File Offset: 0x0028463D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113E9 RID: 70633 RVA: 0x0028644A File Offset: 0x0028464A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113EA RID: 70634 RVA: 0x00286454 File Offset: 0x00284654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Unlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Unlock);
			}
			if (this.IsUncover)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsUncover);
			}
			this.challengeInfo_.WriteTo(ref output, PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this.FirstWin)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FirstWin);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsShow);
			}
			if (this.IsPassRewarded)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsPassRewarded);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113EB RID: 70635 RVA: 0x0028654C File Offset: 0x0028474C
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
			if (this.FirstWin)
			{
				num += 2;
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.IsUncover)
			{
				num += 2;
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.IsPassRewarded)
			{
				num += 2;
			}
			num += this.challengeInfo_.CalculateSize(PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113EC RID: 70636 RVA: 0x002865F4 File Offset: 0x002847F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleChallengeUpdateNotify other)
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
			if (other.FirstWin)
			{
				this.FirstWin = other.FirstWin;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.IsUncover)
			{
				this.IsUncover = other.IsUncover;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.IsPassRewarded)
			{
				this.IsPassRewarded = other.IsPassRewarded;
			}
			this.challengeInfo_.Add(other.challengeInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113ED RID: 70637 RVA: 0x002866B9 File Offset: 0x002848B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113EE RID: 70638 RVA: 0x002866C4 File Offset: 0x002848C4
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
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.Unlock = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.IsUncover = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.challengeInfo_.AddEntriesFrom(ref input, PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
							continue;
						}
						if (num == 56U)
						{
							this.FirstWin = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.IsPassRewarded = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D06 RID: 27910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D07 RID: 27911
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006D08 RID: 27912
		private ErrorCode errorCode_;

		// Token: 0x04006D09 RID: 27913
		public const int ChallengeIdFieldNumber = 14;

		// Token: 0x04006D0A RID: 27914
		private int challengeId_;

		// Token: 0x04006D0B RID: 27915
		public const int FirstWinFieldNumber = 7;

		// Token: 0x04006D0C RID: 27916
		private bool firstWin_;

		// Token: 0x04006D0D RID: 27917
		public const int UnlockFieldNumber = 2;

		// Token: 0x04006D0E RID: 27918
		private bool unlock_;

		// Token: 0x04006D0F RID: 27919
		public const int IsUncoverFieldNumber = 4;

		// Token: 0x04006D10 RID: 27920
		private bool isUncover_;

		// Token: 0x04006D11 RID: 27921
		public const int IsShowFieldNumber = 8;

		// Token: 0x04006D12 RID: 27922
		private bool isShow_;

		// Token: 0x04006D13 RID: 27923
		public const int IsPassRewardedFieldNumber = 9;

		// Token: 0x04006D14 RID: 27924
		private bool isPassRewarded_;

		// Token: 0x04006D15 RID: 27925
		public const int ChallengeInfoFieldNumber = 6;

		// Token: 0x04006D16 RID: 27926
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(50U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006D17 RID: 27927
		private readonly RepeatedField<PhantomBattleChallengeInfo> challengeInfo_ = new RepeatedField<PhantomBattleChallengeInfo>();
	}
}
