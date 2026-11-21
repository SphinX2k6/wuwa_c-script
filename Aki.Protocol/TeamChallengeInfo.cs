using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138E RID: 5006
	public sealed class TeamChallengeInfo : IMessage<TeamChallengeInfo>, IMessage, IEquatable<TeamChallengeInfo>, IDeepCloneable<TeamChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601AA71 RID: 109169 RVA: 0x003E2117 File Offset: 0x003E0317
		[NullableContext(1)]
		public static TeamChallengeInfo Create()
		{
			return new TeamChallengeInfo();
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x0601AA72 RID: 109170 RVA: 0x003E211E File Offset: 0x003E031E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamChallengeInfo> Parser
		{
			get
			{
				return TeamChallengeInfo._parser;
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x0601AA73 RID: 109171 RVA: 0x003E2125 File Offset: 0x003E0325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x0601AA74 RID: 109172 RVA: 0x003E2128 File Offset: 0x003E0328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0601AA75 RID: 109173 RVA: 0x003E212F File Offset: 0x003E032F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo()
		{
		}

		// Token: 0x0601AA76 RID: 109174 RVA: 0x003E2150 File Offset: 0x003E0350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo(TeamChallengeInfo other) : this()
		{
			this.roleSaveInfos_ = other.roleSaveInfos_.Clone();
			this.buffIds_ = other.buffIds_.Clone();
			this.lastMonsterInfoPreview_ = ((other.lastMonsterInfoPreview_ != null) ? other.lastMonsterInfoPreview_.Clone() : null);
			this.teamScore_ = other.teamScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA77 RID: 109175 RVA: 0x003E21BE File Offset: 0x003E03BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo Clone()
		{
			return new TeamChallengeInfo(this);
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x0601AA78 RID: 109176 RVA: 0x003E21C6 File Offset: 0x003E03C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSaveInfo> RoleSaveInfos
		{
			get
			{
				return this.roleSaveInfos_;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x0601AA79 RID: 109177 RVA: 0x003E21CE File Offset: 0x003E03CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x0601AA7A RID: 109178 RVA: 0x003E21D6 File Offset: 0x003E03D6
		// (set) Token: 0x0601AA7B RID: 109179 RVA: 0x003E21DE File Offset: 0x003E03DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterInfoPreview LastMonsterInfoPreview
		{
			get
			{
				return this.lastMonsterInfoPreview_;
			}
			set
			{
				this.lastMonsterInfoPreview_ = value;
			}
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x0601AA7C RID: 109180 RVA: 0x003E21E7 File Offset: 0x003E03E7
		// (set) Token: 0x0601AA7D RID: 109181 RVA: 0x003E21EF File Offset: 0x003E03EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamScore
		{
			get
			{
				return this.teamScore_;
			}
			set
			{
				this.teamScore_ = value;
			}
		}

		// Token: 0x0601AA7E RID: 109182 RVA: 0x003E21F8 File Offset: 0x003E03F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeInfo);
		}

		// Token: 0x0601AA7F RID: 109183 RVA: 0x003E2208 File Offset: 0x003E0408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeInfo other)
		{
			return other != null && (other == this || (this.roleSaveInfos_.Equals(other.roleSaveInfos_) && this.buffIds_.Equals(other.buffIds_) && object.Equals(this.LastMonsterInfoPreview, other.LastMonsterInfoPreview) && this.TeamScore == other.TeamScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA80 RID: 109184 RVA: 0x003E2280 File Offset: 0x003E0480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleSaveInfos_.GetHashCode();
			num ^= this.buffIds_.GetHashCode();
			if (this.lastMonsterInfoPreview_ != null)
			{
				num ^= this.LastMonsterInfoPreview.GetHashCode();
			}
			if (this.TeamScore != 0)
			{
				num ^= this.TeamScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AA81 RID: 109185 RVA: 0x003E22F1 File Offset: 0x003E04F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA82 RID: 109186 RVA: 0x003E22FE File Offset: 0x003E04FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA83 RID: 109187 RVA: 0x003E2308 File Offset: 0x003E0508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleSaveInfos_.WriteTo(ref output, TeamChallengeInfo._repeated_roleSaveInfos_codec);
			this.buffIds_.WriteTo(ref output, TeamChallengeInfo._repeated_buffIds_codec);
			if (this.lastMonsterInfoPreview_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LastMonsterInfoPreview);
			}
			if (this.TeamScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TeamScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA84 RID: 109188 RVA: 0x003E2384 File Offset: 0x003E0584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleSaveInfos_.CalculateSize(TeamChallengeInfo._repeated_roleSaveInfos_codec);
			num += this.buffIds_.CalculateSize(TeamChallengeInfo._repeated_buffIds_codec);
			if (this.lastMonsterInfoPreview_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LastMonsterInfoPreview);
			}
			if (this.TeamScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeamScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AA85 RID: 109189 RVA: 0x003E2400 File Offset: 0x003E0600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.roleSaveInfos_.Add(other.roleSaveInfos_);
			this.buffIds_.Add(other.buffIds_);
			if (other.lastMonsterInfoPreview_ != null)
			{
				if (this.lastMonsterInfoPreview_ == null)
				{
					this.LastMonsterInfoPreview = new MonsterInfoPreview();
				}
				this.LastMonsterInfoPreview.MergeFrom(other.LastMonsterInfoPreview);
			}
			if (other.TeamScore != 0)
			{
				this.TeamScore = other.TeamScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AA86 RID: 109190 RVA: 0x003E248A File Offset: 0x003E068A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA87 RID: 109191 RVA: 0x003E2494 File Offset: 0x003E0694
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.roleSaveInfos_.AddEntriesFrom(ref input, TeamChallengeInfo._repeated_roleSaveInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_53;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_53;
					}
					if (num == 26U)
					{
						if (this.lastMonsterInfoPreview_ == null)
						{
							this.LastMonsterInfoPreview = new MonsterInfoPreview();
						}
						input.ReadMessage(this.LastMonsterInfoPreview);
						continue;
					}
					if (num == 32U)
					{
						this.TeamScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_53:
				this.buffIds_.AddEntriesFrom(ref input, TeamChallengeInfo._repeated_buffIds_codec);
			}
		}

		// Token: 0x04009C28 RID: 39976
		private static readonly MessageParser<TeamChallengeInfo> _parser = new MessageParser<TeamChallengeInfo>(() => new TeamChallengeInfo());

		// Token: 0x04009C29 RID: 39977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C2A RID: 39978
		public const int RoleSaveInfosFieldNumber = 1;

		// Token: 0x04009C2B RID: 39979
		private static readonly FieldCodec<RoleSaveInfo> _repeated_roleSaveInfos_codec = FieldCodec.ForMessage<RoleSaveInfo>(10U, RoleSaveInfo.Parser);

		// Token: 0x04009C2C RID: 39980
		private readonly RepeatedField<RoleSaveInfo> roleSaveInfos_ = new RepeatedField<RoleSaveInfo>();

		// Token: 0x04009C2D RID: 39981
		public const int BuffIdsFieldNumber = 2;

		// Token: 0x04009C2E RID: 39982
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009C2F RID: 39983
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x04009C30 RID: 39984
		public const int LastMonsterInfoPreviewFieldNumber = 3;

		// Token: 0x04009C31 RID: 39985
		private MonsterInfoPreview lastMonsterInfoPreview_;

		// Token: 0x04009C32 RID: 39986
		public const int TeamScoreFieldNumber = 4;

		// Token: 0x04009C33 RID: 39987
		private int teamScore_;
	}
}
