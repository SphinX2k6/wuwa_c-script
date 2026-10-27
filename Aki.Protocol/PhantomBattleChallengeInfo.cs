using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6A RID: 3178
	public sealed class PhantomBattleChallengeInfo : IMessage<PhantomBattleChallengeInfo>, IMessage, IEquatable<PhantomBattleChallengeInfo>, IDeepCloneable<PhantomBattleChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601139D RID: 70557 RVA: 0x002858F0 File Offset: 0x00283AF0
		[NullableContext(1)]
		public static PhantomBattleChallengeInfo Create()
		{
			return new PhantomBattleChallengeInfo();
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0601139E RID: 70558 RVA: 0x002858F7 File Offset: 0x00283AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleChallengeInfo> Parser
		{
			get
			{
				return PhantomBattleChallengeInfo._parser;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0601139F RID: 70559 RVA: 0x002858FE File Offset: 0x00283AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x060113A0 RID: 70560 RVA: 0x00285901 File Offset: 0x00283B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060113A1 RID: 70561 RVA: 0x00285908 File Offset: 0x00283B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo()
		{
		}

		// Token: 0x060113A2 RID: 70562 RVA: 0x0028591C File Offset: 0x00283B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo(PhantomBattleChallengeInfo other) : this()
		{
			this.phantomBattleChallengeId_ = other.phantomBattleChallengeId_;
			this.isUnlock_ = other.isUnlock_;
			this.isPassRewarded_ = other.isPassRewarded_;
			this.lastCardRoleId_ = other.lastCardRoleId_;
			this.lastCardGroupIndex_ = other.lastCardGroupIndex_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this.isUncover_ = other.isUncover_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113A3 RID: 70563 RVA: 0x002859A5 File Offset: 0x00283BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo Clone()
		{
			return new PhantomBattleChallengeInfo(this);
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x060113A4 RID: 70564 RVA: 0x002859AD File Offset: 0x00283BAD
		// (set) Token: 0x060113A5 RID: 70565 RVA: 0x002859B5 File Offset: 0x00283BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleChallengeId
		{
			get
			{
				return this.phantomBattleChallengeId_;
			}
			set
			{
				this.phantomBattleChallengeId_ = value;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x060113A6 RID: 70566 RVA: 0x002859BE File Offset: 0x00283BBE
		// (set) Token: 0x060113A7 RID: 70567 RVA: 0x002859C6 File Offset: 0x00283BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x060113A8 RID: 70568 RVA: 0x002859CF File Offset: 0x00283BCF
		// (set) Token: 0x060113A9 RID: 70569 RVA: 0x002859D7 File Offset: 0x00283BD7
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

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x060113AA RID: 70570 RVA: 0x002859E0 File Offset: 0x00283BE0
		// (set) Token: 0x060113AB RID: 70571 RVA: 0x002859E8 File Offset: 0x00283BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCardRoleId
		{
			get
			{
				return this.lastCardRoleId_;
			}
			set
			{
				this.lastCardRoleId_ = value;
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x060113AC RID: 70572 RVA: 0x002859F1 File Offset: 0x00283BF1
		// (set) Token: 0x060113AD RID: 70573 RVA: 0x002859F9 File Offset: 0x00283BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCardGroupIndex
		{
			get
			{
				return this.lastCardGroupIndex_;
			}
			set
			{
				this.lastCardGroupIndex_ = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x060113AE RID: 70574 RVA: 0x00285A02 File Offset: 0x00283C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x060113AF RID: 70575 RVA: 0x00285A0A File Offset: 0x00283C0A
		// (set) Token: 0x060113B0 RID: 70576 RVA: 0x00285A12 File Offset: 0x00283C12
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

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x060113B1 RID: 70577 RVA: 0x00285A1B File Offset: 0x00283C1B
		// (set) Token: 0x060113B2 RID: 70578 RVA: 0x00285A23 File Offset: 0x00283C23
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

		// Token: 0x060113B3 RID: 70579 RVA: 0x00285A2C File Offset: 0x00283C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeInfo);
		}

		// Token: 0x060113B4 RID: 70580 RVA: 0x00285A3C File Offset: 0x00283C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleChallengeId == other.PhantomBattleChallengeId && this.IsUnlock == other.IsUnlock && this.IsPassRewarded == other.IsPassRewarded && this.LastCardRoleId == other.LastCardRoleId && this.LastCardGroupIndex == other.LastCardGroupIndex && this.finishConditions_.Equals(other.finishConditions_) && this.IsUncover == other.IsUncover && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113B5 RID: 70581 RVA: 0x00285AEC File Offset: 0x00283CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleChallengeId != 0)
			{
				num ^= this.PhantomBattleChallengeId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsPassRewarded)
			{
				num ^= this.IsPassRewarded.GetHashCode();
			}
			if (this.LastCardRoleId != 0)
			{
				num ^= this.LastCardRoleId.GetHashCode();
			}
			if (this.LastCardGroupIndex != 0)
			{
				num ^= this.LastCardGroupIndex.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this.IsUncover)
			{
				num ^= this.IsUncover.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113B6 RID: 70582 RVA: 0x00285BCF File Offset: 0x00283DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113B7 RID: 70583 RVA: 0x00285BDC File Offset: 0x00283DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113B8 RID: 70584 RVA: 0x00285BE8 File Offset: 0x00283DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleChallengeId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsPassRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPassRewarded);
			}
			if (this.LastCardRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LastCardRoleId);
			}
			if (this.LastCardGroupIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastCardGroupIndex);
			}
			this.finishConditions_.WriteTo(ref output, PhantomBattleChallengeInfo._repeated_finishConditions_codec);
			if (this.IsUncover)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUncover);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113B9 RID: 70585 RVA: 0x00285CE0 File Offset: 0x00283EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleChallengeId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsPassRewarded)
			{
				num += 2;
			}
			if (this.LastCardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCardRoleId);
			}
			if (this.LastCardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCardGroupIndex);
			}
			num += this.finishConditions_.CalculateSize(PhantomBattleChallengeInfo._repeated_finishConditions_codec);
			if (this.IsUncover)
			{
				num += 2;
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113BA RID: 70586 RVA: 0x00285D94 File Offset: 0x00283F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleChallengeId != 0)
			{
				this.PhantomBattleChallengeId = other.PhantomBattleChallengeId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsPassRewarded)
			{
				this.IsPassRewarded = other.IsPassRewarded;
			}
			if (other.LastCardRoleId != 0)
			{
				this.LastCardRoleId = other.LastCardRoleId;
			}
			if (other.LastCardGroupIndex != 0)
			{
				this.LastCardGroupIndex = other.LastCardGroupIndex;
			}
			this.finishConditions_.Add(other.finishConditions_);
			if (other.IsUncover)
			{
				this.IsUncover = other.IsUncover;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113BB RID: 70587 RVA: 0x00285E59 File Offset: 0x00284059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113BC RID: 70588 RVA: 0x00285E64 File Offset: 0x00284064
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
				if (num > 32U)
				{
					if (num <= 48U)
					{
						if (num == 40U)
						{
							this.LastCardGroupIndex = input.ReadInt32();
							continue;
						}
						if (num != 48U)
						{
							goto IL_4D;
						}
					}
					else if (num != 50U)
					{
						if (num == 56U)
						{
							this.IsUncover = input.ReadBool();
							continue;
						}
						if (num != 64U)
						{
							goto IL_4D;
						}
						this.IsShow = input.ReadBool();
						continue;
					}
					this.finishConditions_.AddEntriesFrom(ref input, PhantomBattleChallengeInfo._repeated_finishConditions_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PhantomBattleChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsPassRewarded = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.LastCardRoleId = input.ReadInt32();
						continue;
					}
				}
				IL_4D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006CEF RID: 27887
		private static readonly MessageParser<PhantomBattleChallengeInfo> _parser = new MessageParser<PhantomBattleChallengeInfo>(() => new PhantomBattleChallengeInfo());

		// Token: 0x04006CF0 RID: 27888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006CF1 RID: 27889
		public const int PhantomBattleChallengeIdFieldNumber = 1;

		// Token: 0x04006CF2 RID: 27890
		private int phantomBattleChallengeId_;

		// Token: 0x04006CF3 RID: 27891
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006CF4 RID: 27892
		private bool isUnlock_;

		// Token: 0x04006CF5 RID: 27893
		public const int IsPassRewardedFieldNumber = 3;

		// Token: 0x04006CF6 RID: 27894
		private bool isPassRewarded_;

		// Token: 0x04006CF7 RID: 27895
		public const int LastCardRoleIdFieldNumber = 4;

		// Token: 0x04006CF8 RID: 27896
		private int lastCardRoleId_;

		// Token: 0x04006CF9 RID: 27897
		public const int LastCardGroupIndexFieldNumber = 5;

		// Token: 0x04006CFA RID: 27898
		private int lastCardGroupIndex_;

		// Token: 0x04006CFB RID: 27899
		public const int FinishConditionsFieldNumber = 6;

		// Token: 0x04006CFC RID: 27900
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006CFD RID: 27901
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x04006CFE RID: 27902
		public const int IsUncoverFieldNumber = 7;

		// Token: 0x04006CFF RID: 27903
		private bool isUncover_;

		// Token: 0x04006D00 RID: 27904
		public const int IsShowFieldNumber = 8;

		// Token: 0x04006D01 RID: 27905
		private bool isShow_;
	}
}
