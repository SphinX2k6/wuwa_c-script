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
		// Token: 0x06001015 RID: 4117 RVA: 0x0002D0D0 File Offset: 0x0002B2D0
		[NullableContext(1)]
		public static AbyssChallengeInfo Create()
		{
			return new AbyssChallengeInfo();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0002D0D7 File Offset: 0x0002B2D7
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
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0002D0DE File Offset: 0x0002B2DE
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
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0002D0E1 File Offset: 0x0002B2E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0002D0E8 File Offset: 0x0002B2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeInfo()
		{
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0002D0FC File Offset: 0x0002B2FC
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

		// Token: 0x0600101B RID: 4123 RVA: 0x0002D179 File Offset: 0x0002B379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeInfo Clone()
		{
			return new AbyssChallengeInfo(this);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0002D181 File Offset: 0x0002B381
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
		// (get) Token: 0x0600101D RID: 4125 RVA: 0x0002D189 File Offset: 0x0002B389
		// (set) Token: 0x0600101E RID: 4126 RVA: 0x0002D191 File Offset: 0x0002B391
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
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x0002D19A File Offset: 0x0002B39A
		// (set) Token: 0x06001020 RID: 4128 RVA: 0x0002D1A2 File Offset: 0x0002B3A2
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
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0002D1AB File Offset: 0x0002B3AB
		// (set) Token: 0x06001022 RID: 4130 RVA: 0x0002D1B3 File Offset: 0x0002B3B3
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
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x0002D1BC File Offset: 0x0002B3BC
		// (set) Token: 0x06001024 RID: 4132 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
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
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x0002D1CD File Offset: 0x0002B3CD
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x0002D1D5 File Offset: 0x0002B3D5
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
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x0002D1DE File Offset: 0x0002B3DE
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x0002D1E6 File Offset: 0x0002B3E6
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

		// Token: 0x06001029 RID: 4137 RVA: 0x0002D1EF File Offset: 0x0002B3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeInfo);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002D200 File Offset: 0x0002B400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeInfo other)
		{
			return other != null && (other == this || (this.playerInfos_.Equals(other.playerInfos_) && this.PassTime == other.PassTime && this.ChallengeId == other.ChallengeId && this.IsSingle == other.IsSingle && this.ShowName == other.ShowName && this.OwnerId == other.OwnerId && this.PassWave == other.PassWave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
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

		// Token: 0x0600102C RID: 4140 RVA: 0x0002D36A File Offset: 0x0002B56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002D377 File Offset: 0x0002B577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002D380 File Offset: 0x0002B580
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

		// Token: 0x0600102F RID: 4143 RVA: 0x0002D45C File Offset: 0x0002B65C
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

		// Token: 0x06001030 RID: 4144 RVA: 0x0002D510 File Offset: 0x0002B710
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

		// Token: 0x06001031 RID: 4145 RVA: 0x0002D5C1 File Offset: 0x0002B7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0002D5CC File Offset: 0x0002B7CC
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

		// Token: 0x04001EEC RID: 7916
		private static readonly MessageParser<AbyssChallengeInfo> _parser = new MessageParser<AbyssChallengeInfo>(() => new AbyssChallengeInfo());

		// Token: 0x04001EED RID: 7917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EEE RID: 7918
		public const int PlayerInfosFieldNumber = 1;

		// Token: 0x04001EEF RID: 7919
		private static readonly FieldCodec<AbyssChallengePassPlayerInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssChallengePassPlayerInfo>(10U, AbyssChallengePassPlayerInfo.Parser);

		// Token: 0x04001EF0 RID: 7920
		private readonly RepeatedField<AbyssChallengePassPlayerInfo> playerInfos_ = new RepeatedField<AbyssChallengePassPlayerInfo>();

		// Token: 0x04001EF1 RID: 7921
		public const int PassTimeFieldNumber = 2;

		// Token: 0x04001EF2 RID: 7922
		private int passTime_;

		// Token: 0x04001EF3 RID: 7923
		public const int ChallengeIdFieldNumber = 3;

		// Token: 0x04001EF4 RID: 7924
		private int challengeId_;

		// Token: 0x04001EF5 RID: 7925
		public const int IsSingleFieldNumber = 4;

		// Token: 0x04001EF6 RID: 7926
		private bool isSingle_;

		// Token: 0x04001EF7 RID: 7927
		public const int ShowNameFieldNumber = 5;

		// Token: 0x04001EF8 RID: 7928
		private bool showName_;

		// Token: 0x04001EF9 RID: 7929
		public const int OwnerIdFieldNumber = 6;

		// Token: 0x04001EFA RID: 7930
		private int ownerId_;

		// Token: 0x04001EFB RID: 7931
		public const int PassWaveFieldNumber = 7;

		// Token: 0x04001EFC RID: 7932
		private int passWave_;
	}
}
