using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C26 RID: 3110
	[NetMessage(EMessageId.PhantomBattleBoardInfoNotify)]
	public sealed class PhantomBattleBoardInfoNotify : IMessage<PhantomBattleBoardInfoNotify>, IMessage, IEquatable<PhantomBattleBoardInfoNotify>, IDeepCloneable<PhantomBattleBoardInfoNotify>, IBufferMessage
	{
		// Token: 0x06010E40 RID: 69184 RVA: 0x0027975A File Offset: 0x0027795A
		[NullableContext(1)]
		public static PhantomBattleBoardInfoNotify Create()
		{
			return new PhantomBattleBoardInfoNotify();
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x06010E41 RID: 69185 RVA: 0x00279761 File Offset: 0x00277961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x06010E42 RID: 69186 RVA: 0x00279764 File Offset: 0x00277964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010E43 RID: 69187 RVA: 0x0027976B File Offset: 0x0027796B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardInfoNotify()
		{
		}

		// Token: 0x06010E44 RID: 69188 RVA: 0x0027978C File Offset: 0x0027798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardInfoNotify(PhantomBattleBoardInfoNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.phantomBattleGamerFourCTaskInfo_ = other.phantomBattleGamerFourCTaskInfo_.Clone();
			this.npcAreaCardSkillUnlock_ = other.npcAreaCardSkillUnlock_;
			this.playerAreaCardSkillUnlock_ = other.playerAreaCardSkillUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E45 RID: 69189 RVA: 0x002797F6 File Offset: 0x002779F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardInfoNotify Clone()
		{
			return new PhantomBattleBoardInfoNotify(this);
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x06010E46 RID: 69190 RVA: 0x002797FE File Offset: 0x002779FE
		// (set) Token: 0x06010E47 RID: 69191 RVA: 0x00279806 File Offset: 0x00277A06
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

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x06010E48 RID: 69192 RVA: 0x0027980F File Offset: 0x00277A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x06010E49 RID: 69193 RVA: 0x00279817 File Offset: 0x00277A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleGamerFourCTaskInfo> PhantomBattleGamerFourCTaskInfo
		{
			get
			{
				return this.phantomBattleGamerFourCTaskInfo_;
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x06010E4A RID: 69194 RVA: 0x0027981F File Offset: 0x00277A1F
		// (set) Token: 0x06010E4B RID: 69195 RVA: 0x00279827 File Offset: 0x00277A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NpcAreaCardSkillUnlock
		{
			get
			{
				return this.npcAreaCardSkillUnlock_;
			}
			set
			{
				this.npcAreaCardSkillUnlock_ = value;
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x06010E4C RID: 69196 RVA: 0x00279830 File Offset: 0x00277A30
		// (set) Token: 0x06010E4D RID: 69197 RVA: 0x00279838 File Offset: 0x00277A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PlayerAreaCardSkillUnlock
		{
			get
			{
				return this.playerAreaCardSkillUnlock_;
			}
			set
			{
				this.playerAreaCardSkillUnlock_ = value;
			}
		}

		// Token: 0x06010E4E RID: 69198 RVA: 0x00279841 File Offset: 0x00277A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardInfoNotify);
		}

		// Token: 0x06010E4F RID: 69199 RVA: 0x00279850 File Offset: 0x00277A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardInfoNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.phantomBattleGamerFourCTaskInfo_.Equals(other.phantomBattleGamerFourCTaskInfo_) && this.NpcAreaCardSkillUnlock == other.NpcAreaCardSkillUnlock && this.PlayerAreaCardSkillUnlock == other.PlayerAreaCardSkillUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E50 RID: 69200 RVA: 0x002798D4 File Offset: 0x00277AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
			num ^= this.phantomBattleGamerFourCTaskInfo_.GetHashCode();
			if (this.NpcAreaCardSkillUnlock)
			{
				num ^= this.NpcAreaCardSkillUnlock.GetHashCode();
			}
			if (this.PlayerAreaCardSkillUnlock)
			{
				num ^= this.PlayerAreaCardSkillUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E51 RID: 69201 RVA: 0x00279961 File Offset: 0x00277B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E52 RID: 69202 RVA: 0x0027996E File Offset: 0x00277B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E53 RID: 69203 RVA: 0x00279978 File Offset: 0x00277B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleGamerFourCTaskInfo_.WriteTo(ref output, PhantomBattleBoardInfoNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleBoardInfoNotify._repeated_phantomBattleFighterInfo_codec);
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.PlayerAreaCardSkillUnlock)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.PlayerAreaCardSkillUnlock);
			}
			if (this.NpcAreaCardSkillUnlock)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NpcAreaCardSkillUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E54 RID: 69204 RVA: 0x00279A10 File Offset: 0x00277C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleBoardInfoNotify._repeated_phantomBattleFighterInfo_codec);
			num += this.phantomBattleGamerFourCTaskInfo_.CalculateSize(PhantomBattleBoardInfoNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
			if (this.NpcAreaCardSkillUnlock)
			{
				num += 2;
			}
			if (this.PlayerAreaCardSkillUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E55 RID: 69205 RVA: 0x00279A8C File Offset: 0x00277C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBoardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			this.phantomBattleGamerFourCTaskInfo_.Add(other.phantomBattleGamerFourCTaskInfo_);
			if (other.NpcAreaCardSkillUnlock)
			{
				this.NpcAreaCardSkillUnlock = other.NpcAreaCardSkillUnlock;
			}
			if (other.PlayerAreaCardSkillUnlock)
			{
				this.PlayerAreaCardSkillUnlock = other.PlayerAreaCardSkillUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E56 RID: 69206 RVA: 0x00279B12 File Offset: 0x00277D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E57 RID: 69207 RVA: 0x00279B1C File Offset: 0x00277D1C
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
				if (num <= 74U)
				{
					if (num == 50U)
					{
						this.phantomBattleGamerFourCTaskInfo_.AddEntriesFrom(ref input, PhantomBattleBoardInfoNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
						continue;
					}
					if (num == 74U)
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleBoardInfoNotify._repeated_phantomBattleFighterInfo_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.PlayerAreaCardSkillUnlock = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.NpcAreaCardSkillUnlock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B8D RID: 27533
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B8E RID: 27534
		public const int ChallengeIdFieldNumber = 10;

		// Token: 0x04006B8F RID: 27535
		private int challengeId_;

		// Token: 0x04006B90 RID: 27536
		public const int PhantomBattleFighterInfoFieldNumber = 9;

		// Token: 0x04006B91 RID: 27537
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(74U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006B92 RID: 27538
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006B93 RID: 27539
		public const int PhantomBattleGamerFourCTaskInfoFieldNumber = 6;

		// Token: 0x04006B94 RID: 27540
		private static readonly FieldCodec<PhantomBattleGamerFourCTaskInfo> _repeated_phantomBattleGamerFourCTaskInfo_codec = FieldCodec.ForMessage<PhantomBattleGamerFourCTaskInfo>(50U, Aki.Protocol.PhantomBattleGamerFourCTaskInfo.Parser);

		// Token: 0x04006B95 RID: 27541
		private readonly RepeatedField<PhantomBattleGamerFourCTaskInfo> phantomBattleGamerFourCTaskInfo_ = new RepeatedField<PhantomBattleGamerFourCTaskInfo>();

		// Token: 0x04006B96 RID: 27542
		public const int NpcAreaCardSkillUnlockFieldNumber = 13;

		// Token: 0x04006B97 RID: 27543
		private bool npcAreaCardSkillUnlock_;

		// Token: 0x04006B98 RID: 27544
		public const int PlayerAreaCardSkillUnlockFieldNumber = 12;

		// Token: 0x04006B99 RID: 27545
		private bool playerAreaCardSkillUnlock_;
	}
}
