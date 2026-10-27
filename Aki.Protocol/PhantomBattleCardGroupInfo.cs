using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4B RID: 3147
	public sealed class PhantomBattleCardGroupInfo : IMessage<PhantomBattleCardGroupInfo>, IMessage, IEquatable<PhantomBattleCardGroupInfo>, IDeepCloneable<PhantomBattleCardGroupInfo>, IBufferMessage
	{
		// Token: 0x06011113 RID: 69907 RVA: 0x0027FDEB File Offset: 0x0027DFEB
		[NullableContext(1)]
		public static PhantomBattleCardGroupInfo Create()
		{
			return new PhantomBattleCardGroupInfo();
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x06011114 RID: 69908 RVA: 0x0027FDF2 File Offset: 0x0027DFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardGroupInfo> Parser
		{
			get
			{
				return PhantomBattleCardGroupInfo._parser;
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x06011115 RID: 69909 RVA: 0x0027FDF9 File Offset: 0x0027DFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x06011116 RID: 69910 RVA: 0x0027FDFC File Offset: 0x0027DFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupInfo.Descriptor;
			}
		}

		// Token: 0x06011117 RID: 69911 RVA: 0x0027FE03 File Offset: 0x0027E003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo()
		{
		}

		// Token: 0x06011118 RID: 69912 RVA: 0x0027FE38 File Offset: 0x0027E038
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

		// Token: 0x06011119 RID: 69913 RVA: 0x0027FEB3 File Offset: 0x0027E0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo Clone()
		{
			return new PhantomBattleCardGroupInfo(this);
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0601111A RID: 69914 RVA: 0x0027FEBB File Offset: 0x0027E0BB
		// (set) Token: 0x0601111B RID: 69915 RVA: 0x0027FEC3 File Offset: 0x0027E0C3
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

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0601111C RID: 69916 RVA: 0x0027FED6 File Offset: 0x0027E0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipCardIds
		{
			get
			{
				return this.equipCardIds_;
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0601111D RID: 69917 RVA: 0x0027FEDE File Offset: 0x0027E0DE
		// (set) Token: 0x0601111E RID: 69918 RVA: 0x0027FEE6 File Offset: 0x0027E0E6
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

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0601111F RID: 69919 RVA: 0x0027FEEF File Offset: 0x0027E0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LastUseChallengeId
		{
			get
			{
				return this.lastUseChallengeId_;
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x06011120 RID: 69920 RVA: 0x0027FEF7 File Offset: 0x0027E0F7
		// (set) Token: 0x06011121 RID: 69921 RVA: 0x0027FEFF File Offset: 0x0027E0FF
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

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x06011122 RID: 69922 RVA: 0x0027FF08 File Offset: 0x0027E108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleCardSkillUnlockInfo> SkillUnlockInfos
		{
			get
			{
				return this.skillUnlockInfos_;
			}
		}

		// Token: 0x06011123 RID: 69923 RVA: 0x0027FF10 File Offset: 0x0027E110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupInfo);
		}

		// Token: 0x06011124 RID: 69924 RVA: 0x0027FF20 File Offset: 0x0027E120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.equipCardIds_.Equals(other.equipCardIds_) && this.CanUse == other.CanUse && this.lastUseChallengeId_.Equals(other.lastUseChallengeId_) && this.Index == other.Index && this.skillUnlockInfos_.Equals(other.skillUnlockInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011125 RID: 69925 RVA: 0x0027FFC0 File Offset: 0x0027E1C0
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

		// Token: 0x06011126 RID: 69926 RVA: 0x0028005D File Offset: 0x0027E25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011127 RID: 69927 RVA: 0x0028006A File Offset: 0x0027E26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011128 RID: 69928 RVA: 0x00280074 File Offset: 0x0027E274
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

		// Token: 0x06011129 RID: 69929 RVA: 0x00280124 File Offset: 0x0027E324
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

		// Token: 0x0601112A RID: 69930 RVA: 0x002801C4 File Offset: 0x0027E3C4
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

		// Token: 0x0601112B RID: 69931 RVA: 0x00280260 File Offset: 0x0027E460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601112C RID: 69932 RVA: 0x0028026C File Offset: 0x0027E46C
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

		// Token: 0x04006C25 RID: 27685
		private static readonly MessageParser<PhantomBattleCardGroupInfo> _parser = new MessageParser<PhantomBattleCardGroupInfo>(() => new PhantomBattleCardGroupInfo());

		// Token: 0x04006C26 RID: 27686
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C27 RID: 27687
		public const int NameFieldNumber = 1;

		// Token: 0x04006C28 RID: 27688
		private string name_ = "";

		// Token: 0x04006C29 RID: 27689
		public const int EquipCardIdsFieldNumber = 2;

		// Token: 0x04006C2A RID: 27690
		private static readonly FieldCodec<int> _repeated_equipCardIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006C2B RID: 27691
		private readonly RepeatedField<int> equipCardIds_ = new RepeatedField<int>();

		// Token: 0x04006C2C RID: 27692
		public const int CanUseFieldNumber = 3;

		// Token: 0x04006C2D RID: 27693
		private bool canUse_;

		// Token: 0x04006C2E RID: 27694
		public const int LastUseChallengeIdFieldNumber = 4;

		// Token: 0x04006C2F RID: 27695
		private static readonly FieldCodec<int> _repeated_lastUseChallengeId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006C30 RID: 27696
		private readonly RepeatedField<int> lastUseChallengeId_ = new RepeatedField<int>();

		// Token: 0x04006C31 RID: 27697
		public const int IndexFieldNumber = 5;

		// Token: 0x04006C32 RID: 27698
		private int index_;

		// Token: 0x04006C33 RID: 27699
		public const int SkillUnlockInfosFieldNumber = 6;

		// Token: 0x04006C34 RID: 27700
		private static readonly FieldCodec<PhantomBattleCardSkillUnlockInfo> _repeated_skillUnlockInfos_codec = FieldCodec.ForMessage<PhantomBattleCardSkillUnlockInfo>(50U, PhantomBattleCardSkillUnlockInfo.Parser);

		// Token: 0x04006C35 RID: 27701
		private readonly RepeatedField<PhantomBattleCardSkillUnlockInfo> skillUnlockInfos_ = new RepeatedField<PhantomBattleCardSkillUnlockInfo>();
	}
}
