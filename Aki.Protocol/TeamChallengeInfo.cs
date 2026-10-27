using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001321 RID: 4897
	public sealed class TeamChallengeInfo : IMessage<TeamChallengeInfo>, IMessage, IEquatable<TeamChallengeInfo>, IDeepCloneable<TeamChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601A061 RID: 106593 RVA: 0x003C7E5F File Offset: 0x003C605F
		[NullableContext(1)]
		public static TeamChallengeInfo Create()
		{
			return new TeamChallengeInfo();
		}

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x0601A062 RID: 106594 RVA: 0x003C7E66 File Offset: 0x003C6066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeamChallengeInfo> Parser
		{
			get
			{
				return TeamChallengeInfo._parser;
			}
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x0601A063 RID: 106595 RVA: 0x003C7E6D File Offset: 0x003C606D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x0601A064 RID: 106596 RVA: 0x003C7E70 File Offset: 0x003C6070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeInfo.Descriptor;
			}
		}

		// Token: 0x0601A065 RID: 106597 RVA: 0x003C7E77 File Offset: 0x003C6077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo()
		{
		}

		// Token: 0x0601A066 RID: 106598 RVA: 0x003C7E98 File Offset: 0x003C6098
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

		// Token: 0x0601A067 RID: 106599 RVA: 0x003C7F06 File Offset: 0x003C6106
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeInfo Clone()
		{
			return new TeamChallengeInfo(this);
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x0601A068 RID: 106600 RVA: 0x003C7F0E File Offset: 0x003C610E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSaveInfo> RoleSaveInfos
		{
			get
			{
				return this.roleSaveInfos_;
			}
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x0601A069 RID: 106601 RVA: 0x003C7F16 File Offset: 0x003C6116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x0601A06A RID: 106602 RVA: 0x003C7F1E File Offset: 0x003C611E
		// (set) Token: 0x0601A06B RID: 106603 RVA: 0x003C7F26 File Offset: 0x003C6126
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

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x0601A06C RID: 106604 RVA: 0x003C7F2F File Offset: 0x003C612F
		// (set) Token: 0x0601A06D RID: 106605 RVA: 0x003C7F37 File Offset: 0x003C6137
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

		// Token: 0x0601A06E RID: 106606 RVA: 0x003C7F40 File Offset: 0x003C6140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeInfo);
		}

		// Token: 0x0601A06F RID: 106607 RVA: 0x003C7F50 File Offset: 0x003C6150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeInfo other)
		{
			return other != null && (other == this || (this.roleSaveInfos_.Equals(other.roleSaveInfos_) && this.buffIds_.Equals(other.buffIds_) && object.Equals(this.LastMonsterInfoPreview, other.LastMonsterInfoPreview) && this.TeamScore == other.TeamScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A070 RID: 106608 RVA: 0x003C7FC8 File Offset: 0x003C61C8
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

		// Token: 0x0601A071 RID: 106609 RVA: 0x003C8039 File Offset: 0x003C6239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A072 RID: 106610 RVA: 0x003C8046 File Offset: 0x003C6246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x003C8050 File Offset: 0x003C6250
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

		// Token: 0x0601A074 RID: 106612 RVA: 0x003C80CC File Offset: 0x003C62CC
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

		// Token: 0x0601A075 RID: 106613 RVA: 0x003C8148 File Offset: 0x003C6348
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

		// Token: 0x0601A076 RID: 106614 RVA: 0x003C81D2 File Offset: 0x003C63D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A077 RID: 106615 RVA: 0x003C81DC File Offset: 0x003C63DC
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

		// Token: 0x04009806 RID: 38918
		private static readonly MessageParser<TeamChallengeInfo> _parser = new MessageParser<TeamChallengeInfo>(() => new TeamChallengeInfo());

		// Token: 0x04009807 RID: 38919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009808 RID: 38920
		public const int RoleSaveInfosFieldNumber = 1;

		// Token: 0x04009809 RID: 38921
		private static readonly FieldCodec<RoleSaveInfo> _repeated_roleSaveInfos_codec = FieldCodec.ForMessage<RoleSaveInfo>(10U, RoleSaveInfo.Parser);

		// Token: 0x0400980A RID: 38922
		private readonly RepeatedField<RoleSaveInfo> roleSaveInfos_ = new RepeatedField<RoleSaveInfo>();

		// Token: 0x0400980B RID: 38923
		public const int BuffIdsFieldNumber = 2;

		// Token: 0x0400980C RID: 38924
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400980D RID: 38925
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x0400980E RID: 38926
		public const int LastMonsterInfoPreviewFieldNumber = 3;

		// Token: 0x0400980F RID: 38927
		private MonsterInfoPreview lastMonsterInfoPreview_;

		// Token: 0x04009810 RID: 38928
		public const int TeamScoreFieldNumber = 4;

		// Token: 0x04009811 RID: 38929
		private int teamScore_;
	}
}
