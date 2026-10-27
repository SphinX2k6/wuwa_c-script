using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C36 RID: 3126
	[NetMessage(EMessageId.PhantomBattleBoardInfoNotify)]
	public sealed class PhantomBattleBoardInfoNotify : IMessage<PhantomBattleBoardInfoNotify>, IMessage, IEquatable<PhantomBattleBoardInfoNotify>, IDeepCloneable<PhantomBattleBoardInfoNotify>, IBufferMessage
	{
		// Token: 0x06010F40 RID: 69440 RVA: 0x0027B4BE File Offset: 0x002796BE
		[NullableContext(1)]
		public static PhantomBattleBoardInfoNotify Create()
		{
			return new PhantomBattleBoardInfoNotify();
		}

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x06010F41 RID: 69441 RVA: 0x0027B4C5 File Offset: 0x002796C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x06010F42 RID: 69442 RVA: 0x0027B4C8 File Offset: 0x002796C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBoardInfoNotify.Descriptor;
			}
		}

		// Token: 0x06010F43 RID: 69443 RVA: 0x0027B4CF File Offset: 0x002796CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardInfoNotify()
		{
		}

		// Token: 0x06010F44 RID: 69444 RVA: 0x0027B4F0 File Offset: 0x002796F0
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

		// Token: 0x06010F45 RID: 69445 RVA: 0x0027B55A File Offset: 0x0027975A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBoardInfoNotify Clone()
		{
			return new PhantomBattleBoardInfoNotify(this);
		}

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x06010F46 RID: 69446 RVA: 0x0027B562 File Offset: 0x00279762
		// (set) Token: 0x06010F47 RID: 69447 RVA: 0x0027B56A File Offset: 0x0027976A
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

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x06010F48 RID: 69448 RVA: 0x0027B573 File Offset: 0x00279773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x06010F49 RID: 69449 RVA: 0x0027B57B File Offset: 0x0027977B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleGamerFourCTaskInfo> PhantomBattleGamerFourCTaskInfo
		{
			get
			{
				return this.phantomBattleGamerFourCTaskInfo_;
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x06010F4A RID: 69450 RVA: 0x0027B583 File Offset: 0x00279783
		// (set) Token: 0x06010F4B RID: 69451 RVA: 0x0027B58B File Offset: 0x0027978B
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

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x06010F4C RID: 69452 RVA: 0x0027B594 File Offset: 0x00279794
		// (set) Token: 0x06010F4D RID: 69453 RVA: 0x0027B59C File Offset: 0x0027979C
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

		// Token: 0x06010F4E RID: 69454 RVA: 0x0027B5A5 File Offset: 0x002797A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBoardInfoNotify);
		}

		// Token: 0x06010F4F RID: 69455 RVA: 0x0027B5B4 File Offset: 0x002797B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBoardInfoNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.phantomBattleGamerFourCTaskInfo_.Equals(other.phantomBattleGamerFourCTaskInfo_) && this.NpcAreaCardSkillUnlock == other.NpcAreaCardSkillUnlock && this.PlayerAreaCardSkillUnlock == other.PlayerAreaCardSkillUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F50 RID: 69456 RVA: 0x0027B638 File Offset: 0x00279838
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

		// Token: 0x06010F51 RID: 69457 RVA: 0x0027B6C5 File Offset: 0x002798C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F52 RID: 69458 RVA: 0x0027B6D2 File Offset: 0x002798D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F53 RID: 69459 RVA: 0x0027B6DC File Offset: 0x002798DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcAreaCardSkillUnlock)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.NpcAreaCardSkillUnlock);
			}
			if (this.PlayerAreaCardSkillUnlock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.PlayerAreaCardSkillUnlock);
			}
			this.phantomBattleGamerFourCTaskInfo_.WriteTo(ref output, PhantomBattleBoardInfoNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChallengeId);
			}
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleBoardInfoNotify._repeated_phantomBattleFighterInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F54 RID: 69460 RVA: 0x0027B774 File Offset: 0x00279974
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

		// Token: 0x06010F55 RID: 69461 RVA: 0x0027B7F0 File Offset: 0x002799F0
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

		// Token: 0x06010F56 RID: 69462 RVA: 0x0027B876 File Offset: 0x00279A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F57 RID: 69463 RVA: 0x0027B880 File Offset: 0x00279A80
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.NpcAreaCardSkillUnlock = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.PlayerAreaCardSkillUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.phantomBattleGamerFourCTaskInfo_.AddEntriesFrom(ref input, PhantomBattleBoardInfoNotify._repeated_phantomBattleGamerFourCTaskInfo_codec);
						continue;
					}
					if (num == 72U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleBoardInfoNotify._repeated_phantomBattleFighterInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006B79 RID: 27513
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B7A RID: 27514
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x04006B7B RID: 27515
		private int challengeId_;

		// Token: 0x04006B7C RID: 27516
		public const int PhantomBattleFighterInfoFieldNumber = 15;

		// Token: 0x04006B7D RID: 27517
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(122U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006B7E RID: 27518
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006B7F RID: 27519
		public const int PhantomBattleGamerFourCTaskInfoFieldNumber = 6;

		// Token: 0x04006B80 RID: 27520
		private static readonly FieldCodec<PhantomBattleGamerFourCTaskInfo> _repeated_phantomBattleGamerFourCTaskInfo_codec = FieldCodec.ForMessage<PhantomBattleGamerFourCTaskInfo>(50U, Aki.Protocol.PhantomBattleGamerFourCTaskInfo.Parser);

		// Token: 0x04006B81 RID: 27521
		private readonly RepeatedField<PhantomBattleGamerFourCTaskInfo> phantomBattleGamerFourCTaskInfo_ = new RepeatedField<PhantomBattleGamerFourCTaskInfo>();

		// Token: 0x04006B82 RID: 27522
		public const int NpcAreaCardSkillUnlockFieldNumber = 1;

		// Token: 0x04006B83 RID: 27523
		private bool npcAreaCardSkillUnlock_;

		// Token: 0x04006B84 RID: 27524
		public const int PlayerAreaCardSkillUnlockFieldNumber = 3;

		// Token: 0x04006B85 RID: 27525
		private bool playerAreaCardSkillUnlock_;
	}
}
