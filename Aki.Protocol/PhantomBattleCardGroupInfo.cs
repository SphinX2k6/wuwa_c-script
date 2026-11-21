using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3B RID: 3131
	public sealed class PhantomBattleCardGroupInfo : IMessage<PhantomBattleCardGroupInfo>, IMessage, IEquatable<PhantomBattleCardGroupInfo>, IDeepCloneable<PhantomBattleCardGroupInfo>, IBufferMessage
	{
		// Token: 0x06011013 RID: 69651 RVA: 0x0027E083 File Offset: 0x0027C283
		[NullableContext(1)]
		public static PhantomBattleCardGroupInfo Create()
		{
			return new PhantomBattleCardGroupInfo();
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x06011014 RID: 69652 RVA: 0x0027E08A File Offset: 0x0027C28A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardGroupInfo> Parser
		{
			get
			{
				return PhantomBattleCardGroupInfo._parser;
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x06011015 RID: 69653 RVA: 0x0027E091 File Offset: 0x0027C291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x06011016 RID: 69654 RVA: 0x0027E094 File Offset: 0x0027C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011017 RID: 69655 RVA: 0x0027E09B File Offset: 0x0027C29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo()
		{
		}

		// Token: 0x06011018 RID: 69656 RVA: 0x0027E0D0 File Offset: 0x0027C2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo(PhantomBattleCardGroupInfo other) : this()
		{
			this.name_ = other.name_;
			this.equipCardIds_ = other.equipCardIds_.Clone();
			this.canUse_ = other.canUse_;
			this.lastUseChallengeId_ = other.lastUseChallengeId_.Clone();
			this.index_ = other.index_;
			this.skillUnlockInfos_ = other.skillUnlockInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011019 RID: 69657 RVA: 0x0027E14B File Offset: 0x0027C34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo Clone()
		{
			return new PhantomBattleCardGroupInfo(this);
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0601101A RID: 69658 RVA: 0x0027E153 File Offset: 0x0027C353
		// (set) Token: 0x0601101B RID: 69659 RVA: 0x0027E15B File Offset: 0x0027C35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0601101C RID: 69660 RVA: 0x0027E16E File Offset: 0x0027C36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0601101D RID: 69661 RVA: 0x0027E176 File Offset: 0x0027C376
		// (set) Token: 0x0601101E RID: 69662 RVA: 0x0027E17E File Offset: 0x0027C37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanUse
		{
			get
			{
				return this.canUse_;
			}
			set
			{
				this.canUse_ = value;
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0601101F RID: 69663 RVA: 0x0027E187 File Offset: 0x0027C387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LastUseChallengeId
		{
			get
			{
				return this.lastUseChallengeId_;
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x06011020 RID: 69664 RVA: 0x0027E18F File Offset: 0x0027C38F
		// (set) Token: 0x06011021 RID: 69665 RVA: 0x0027E197 File Offset: 0x0027C397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x06011022 RID: 69666 RVA: 0x0027E1A0 File Offset: 0x0027C3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardSkillUnlockInfo> SkillUnlockInfos
		{
			get
			{
				return this.skillUnlockInfos_;
			}
		}

		// Token: 0x06011023 RID: 69667 RVA: 0x0027E1A8 File Offset: 0x0027C3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupInfo);
		}

		// Token: 0x06011024 RID: 69668 RVA: 0x0027E1B8 File Offset: 0x0027C3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.equipCardIds_.Equals(other.equipCardIds_) && this.CanUse == other.CanUse && this.lastUseChallengeId_.Equals(other.lastUseChallengeId_) && this.Index == other.Index && this.skillUnlockInfos_.Equals(other.skillUnlockInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011025 RID: 69669 RVA: 0x0027E258 File Offset: 0x0027C458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.equipCardIds_.GetHashCode();
			if (this.CanUse)
			{
				num ^= this.CanUse.GetHashCode();
			}
			num ^= this.lastUseChallengeId_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.skillUnlockInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011026 RID: 69670 RVA: 0x0027E2F5 File Offset: 0x0027C4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011027 RID: 69671 RVA: 0x0027E302 File Offset: 0x0027C502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011028 RID: 69672 RVA: 0x0027E30C File Offset: 0x0027C50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			this.equipCardIds_.WriteTo(ref output, PhantomBattleCardGroupInfo._repeated_equipCardIds_codec);
			if (this.CanUse)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanUse);
			}
			this.lastUseChallengeId_.WriteTo(ref output, PhantomBattleCardGroupInfo._repeated_lastUseChallengeId_codec);
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			this.skillUnlockInfos_.WriteTo(ref output, PhantomBattleCardGroupInfo._repeated_skillUnlockInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011029 RID: 69673 RVA: 0x0027E3BC File Offset: 0x0027C5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.equipCardIds_.CalculateSize(PhantomBattleCardGroupInfo._repeated_equipCardIds_codec);
			if (this.CanUse)
			{
				num += 2;
			}
			num += this.lastUseChallengeId_.CalculateSize(PhantomBattleCardGroupInfo._repeated_lastUseChallengeId_codec);
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.skillUnlockInfos_.CalculateSize(PhantomBattleCardGroupInfo._repeated_skillUnlockInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601102A RID: 69674 RVA: 0x0027E45C File Offset: 0x0027C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this.equipCardIds_.Add(other.equipCardIds_);
			if (other.CanUse)
			{
				this.CanUse = other.CanUse;
			}
			this.lastUseChallengeId_.Add(other.lastUseChallengeId_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.skillUnlockInfos_.Add(other.skillUnlockInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601102B RID: 69675 RVA: 0x0027E4F8 File Offset: 0x0027C6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601102C RID: 69676 RVA: 0x0027E504 File Offset: 0x0027C704
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
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.Name = input.ReadString();
							continue;
						}
						if (num != 16U)
						{
							goto IL_49;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_49;
						}
						this.CanUse = input.ReadBool();
						continue;
					}
					this.equipCardIds_.AddEntriesFrom(ref input, PhantomBattleCardGroupInfo._repeated_equipCardIds_codec);
					continue;
				}
				if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.lastUseChallengeId_.AddEntriesFrom(ref input, PhantomBattleCardGroupInfo._repeated_lastUseChallengeId_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.skillUnlockInfos_.AddEntriesFrom(ref input, PhantomBattleCardGroupInfo._repeated_skillUnlockInfos_codec);
						continue;
					}
				}
				IL_49:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006C39 RID: 27705
		private static readonly MessageParser<PhantomBattleCardGroupInfo> _parser = new MessageParser<PhantomBattleCardGroupInfo>(() => new PhantomBattleCardGroupInfo());

		// Token: 0x04006C3A RID: 27706
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C3B RID: 27707
		public const int NameFieldNumber = 1;

		// Token: 0x04006C3C RID: 27708
		private string name_ = "";

		// Token: 0x04006C3D RID: 27709
		public const int EquipCardIdsFieldNumber = 2;

		// Token: 0x04006C3E RID: 27710
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006C3F RID: 27711
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C40 RID: 27712
		public const int CanUseFieldNumber = 3;

		// Token: 0x04006C41 RID: 27713
		private bool canUse_;

		// Token: 0x04006C42 RID: 27714
		public const int LastUseChallengeIdFieldNumber = 4;

		// Token: 0x04006C43 RID: 27715
		private static readonly FieldCodec<int> _repeated_lastUseChallengeId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006C44 RID: 27716
		private readonly RepeatedField<int> lastUseChallengeId_ = new RepeatedField<int>();

		// Token: 0x04006C45 RID: 27717
		public const int IndexFieldNumber = 5;

		// Token: 0x04006C46 RID: 27718
		private int index_;

		// Token: 0x04006C47 RID: 27719
		public const int SkillUnlockInfosFieldNumber = 6;

		// Token: 0x04006C48 RID: 27720
		private static readonly FieldCodec<PhantomBattleCardSkillUnlockInfo> _repeated_skillUnlockInfos_codec = FieldCodec.ForMessage<PhantomBattleCardSkillUnlockInfo>(50U, PhantomBattleCardSkillUnlockInfo.Parser);

		// Token: 0x04006C49 RID: 27721
		private readonly RepeatedField<PhantomBattleCardSkillUnlockInfo> skillUnlockInfos_ = new RepeatedField<PhantomBattleCardSkillUnlockInfo>();
	}
}
