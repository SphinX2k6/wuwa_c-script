using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000016 RID: 22
	public sealed class AbyssChallengeInfo : IMessage<AbyssChallengeInfo>, IMessage, IEquatable<AbyssChallengeInfo>, IDeepCloneable<AbyssChallengeInfo>, IBufferMessage
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x0002D685 File Offset: 0x0002B885
		[NullableContext(1)]
		public static AbyssChallengeInfo Create()
		{
			return new AbyssChallengeInfo();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0002D68C File Offset: 0x0002B88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallengeInfo> Parser
		{
			get
			{
				return AbyssChallengeInfo._parser;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0002D693 File Offset: 0x0002B893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0002D696 File Offset: 0x0002B896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002D69D File Offset: 0x0002B89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeInfo()
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeInfo(AbyssChallengeInfo other) : this()
		{
			this.playerInfos_ = other.playerInfos_.Clone();
			this.passTime_ = other.passTime_;
			this.challengeId_ = other.challengeId_;
			this.isSingle_ = other.isSingle_;
			this.showName_ = other.showName_;
			this.ownerId_ = other.ownerId_;
			this.passWave_ = other.passWave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0002D72D File Offset: 0x0002B92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeInfo Clone()
		{
			return new AbyssChallengeInfo(this);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x0002D735 File Offset: 0x0002B935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssChallengePassPlayerInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0002D73D File Offset: 0x0002B93D
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0002D745 File Offset: 0x0002B945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0002D74E File Offset: 0x0002B94E
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x0002D756 File Offset: 0x0002B956
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0002D75F File Offset: 0x0002B95F
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x0002D767 File Offset: 0x0002B967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSingle
		{
			get
			{
				return this.isSingle_;
			}
			set
			{
				this.isSingle_ = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x0002D770 File Offset: 0x0002B970
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0002D778 File Offset: 0x0002B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0002D781 File Offset: 0x0002B981
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x0002D789 File Offset: 0x0002B989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0002D792 File Offset: 0x0002B992
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0002D79A File Offset: 0x0002B99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassWave
		{
			get
			{
				return this.passWave_;
			}
			set
			{
				this.passWave_ = value;
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0002D7A3 File Offset: 0x0002B9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeInfo);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0002D7B4 File Offset: 0x0002B9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeInfo other)
		{
			return other != null && (other == this || (this.playerInfos_.Equals(other.playerInfos_) && this.PassTime == other.PassTime && this.ChallengeId == other.ChallengeId && this.IsSingle == other.IsSingle && this.ShowName == other.ShowName && this.OwnerId == other.OwnerId && this.PassWave == other.PassWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002D854 File Offset: 0x0002BA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerInfos_.GetHashCode();
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.IsSingle)
			{
				num ^= this.IsSingle.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this.OwnerId != 0)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			if (this.PassWave != 0)
			{
				num ^= this.PassWave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0002D91E File Offset: 0x0002BB1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002D92B File Offset: 0x0002BB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002D934 File Offset: 0x0002BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerInfos_.WriteTo(ref output, AbyssChallengeInfo._repeated_playerInfos_codec);
			if (this.PassTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PassTime);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsSingle)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSingle);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ShowName);
			}
			if (this.OwnerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.OwnerId);
			}
			if (this.PassWave != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassWave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002DA10 File Offset: 0x0002BC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerInfos_.CalculateSize(AbyssChallengeInfo._repeated_playerInfos_codec);
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.IsSingle)
			{
				num += 2;
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this.OwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OwnerId);
			}
			if (this.PassWave != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassWave);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0002DAC4 File Offset: 0x0002BCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.playerInfos_.Add(other.playerInfos_);
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.IsSingle)
			{
				this.IsSingle = other.IsSingle;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			if (other.OwnerId != 0)
			{
				this.OwnerId = other.OwnerId;
			}
			if (other.PassWave != 0)
			{
				this.PassWave = other.PassWave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0002DB75 File Offset: 0x0002BD75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0002DB80 File Offset: 0x0002BD80
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
					if (num == 10U)
					{
						this.playerInfos_.AddEntriesFrom(ref input, AbyssChallengeInfo._repeated_playerInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.IsSingle = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.OwnerId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PassWave = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F42 RID: 8002
		private static readonly MessageParser<AbyssChallengeInfo> _parser = new MessageParser<AbyssChallengeInfo>(() => new AbyssChallengeInfo());

		// Token: 0x04001F43 RID: 8003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F44 RID: 8004
		public const int PlayerInfosFieldNumber = 1;

		// Token: 0x04001F45 RID: 8005
		private static readonly FieldCodec<AbyssChallengePassPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssChallengePassPlayerInfo>(10U, AbyssChallengePassPlayerInfo.Parser);

		// Token: 0x04001F46 RID: 8006
		private readonly RepeatedField<AbyssChallengePassPlayerInfo> playerInfos_ = new RepeatedField<AbyssChallengePassPlayerInfo>();

		// Token: 0x04001F47 RID: 8007
		public const int PassTimeFieldNumber = 2;

		// Token: 0x04001F48 RID: 8008
		private int passTime_;

		// Token: 0x04001F49 RID: 8009
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04001F4A RID: 8010
		private int challengeId_;

		// Token: 0x04001F4B RID: 8011
		public const int IsSingleFieldNumber = 4;

		// Token: 0x04001F4C RID: 8012
		private bool isSingle_;

		// Token: 0x04001F4D RID: 8013
		public const int ShowNameFieldNumber = 5;

		// Token: 0x04001F4E RID: 8014
		private bool showName_;

		// Token: 0x04001F4F RID: 8015
		public const int OwnerIdFieldNumber = 6;

		// Token: 0x04001F50 RID: 8016
		private int ownerId_;

		// Token: 0x04001F51 RID: 8017
		public const int PassWaveFieldNumber = 7;

		// Token: 0x04001F52 RID: 8018
		private int passWave_;
	}
}
