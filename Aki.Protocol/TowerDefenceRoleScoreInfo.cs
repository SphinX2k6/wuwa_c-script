using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B0 RID: 5040
	public sealed class TowerDefenceRoleScoreInfo : IMessage<TowerDefenceRoleScoreInfo>, IMessage, IEquatable<TowerDefenceRoleScoreInfo>, IDeepCloneable<TowerDefenceRoleScoreInfo>, IBufferMessage
	{
		// Token: 0x0601ABDB RID: 109531 RVA: 0x003E0D3F File Offset: 0x003DEF3F
		[NullableContext(1)]
		public static TowerDefenceRoleScoreInfo Create()
		{
			return new TowerDefenceRoleScoreInfo();
		}

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x0601ABDC RID: 109532 RVA: 0x003E0D46 File Offset: 0x003DEF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRoleScoreInfo> Parser
		{
			get
			{
				return TowerDefenceRoleScoreInfo._parser;
			}
		}

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x0601ABDD RID: 109533 RVA: 0x003E0D4D File Offset: 0x003DEF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x0601ABDE RID: 109534 RVA: 0x003E0D50 File Offset: 0x003DEF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601ABDF RID: 109535 RVA: 0x003E0D57 File Offset: 0x003DEF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleScoreInfo()
		{
		}

		// Token: 0x0601ABE0 RID: 109536 RVA: 0x003E0D6C File Offset: 0x003DEF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleScoreInfo(TowerDefenceRoleScoreInfo other) : this()
		{
			this.scoreList_ = other.scoreList_.Clone();
			this.roleId_ = other.roleId_;
			this.playerId_ = other.playerId_;
			this.title_ = other.title_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABE1 RID: 109537 RVA: 0x003E0DC5 File Offset: 0x003DEFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleScoreInfo Clone()
		{
			return new TowerDefenceRoleScoreInfo(this);
		}

		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x0601ABE2 RID: 109538 RVA: 0x003E0DCD File Offset: 0x003DEFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceBattleScoreInfo> ScoreList
		{
			get
			{
				return this.scoreList_;
			}
		}

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0601ABE3 RID: 109539 RVA: 0x003E0DD5 File Offset: 0x003DEFD5
		// (set) Token: 0x0601ABE4 RID: 109540 RVA: 0x003E0DDD File Offset: 0x003DEFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x0601ABE5 RID: 109541 RVA: 0x003E0DE6 File Offset: 0x003DEFE6
		// (set) Token: 0x0601ABE6 RID: 109542 RVA: 0x003E0DEE File Offset: 0x003DEFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x0601ABE7 RID: 109543 RVA: 0x003E0DF7 File Offset: 0x003DEFF7
		// (set) Token: 0x0601ABE8 RID: 109544 RVA: 0x003E0DFF File Offset: 0x003DEFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Title
		{
			get
			{
				return this.title_;
			}
			set
			{
				this.title_ = value;
			}
		}

		// Token: 0x0601ABE9 RID: 109545 RVA: 0x003E0E08 File Offset: 0x003DF008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleScoreInfo);
		}

		// Token: 0x0601ABEA RID: 109546 RVA: 0x003E0E18 File Offset: 0x003DF018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleScoreInfo other)
		{
			return other != null && (other == this || (this.scoreList_.Equals(other.scoreList_) && this.RoleId == other.RoleId && this.PlayerId == other.PlayerId && this.Title == other.Title && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABEB RID: 109547 RVA: 0x003E0E88 File Offset: 0x003DF088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scoreList_.GetHashCode();
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Title != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABEC RID: 109548 RVA: 0x003E0F07 File Offset: 0x003DF107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABED RID: 109549 RVA: 0x003E0F14 File Offset: 0x003DF114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABEE RID: 109550 RVA: 0x003E0F20 File Offset: 0x003DF120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreList_.WriteTo(ref output, TowerDefenceRoleScoreInfo._repeated_scoreList_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Title != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Title);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABEF RID: 109551 RVA: 0x003E0FA8 File Offset: 0x003DF1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scoreList_.CalculateSize(TowerDefenceRoleScoreInfo._repeated_scoreList_codec);
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Title != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Title);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABF0 RID: 109552 RVA: 0x003E102C File Offset: 0x003DF22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRoleScoreInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.scoreList_.Add(other.scoreList_);
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Title != 0)
			{
				this.Title = other.Title;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABF1 RID: 109553 RVA: 0x003E10A1 File Offset: 0x003DF2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABF2 RID: 109554 RVA: 0x003E10AC File Offset: 0x003DF2AC
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
						this.scoreList_.AddEntriesFrom(ref input, TowerDefenceRoleScoreInfo._repeated_scoreList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Title = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B49 RID: 39753
		private static readonly MessageParser<TowerDefenceRoleScoreInfo> _parser = new MessageParser<TowerDefenceRoleScoreInfo>(() => new TowerDefenceRoleScoreInfo());

		// Token: 0x04009B4A RID: 39754
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B4B RID: 39755
		public const int ScoreListFieldNumber = 1;

		// Token: 0x04009B4C RID: 39756
		private static readonly FieldCodec<TowerDefenceBattleScoreInfo> _repeated_scoreList_codec = FieldCodec.ForMessage<TowerDefenceBattleScoreInfo>(10U, TowerDefenceBattleScoreInfo.Parser);

		// Token: 0x04009B4D RID: 39757
		private readonly RepeatedField<TowerDefenceBattleScoreInfo> scoreList_ = new RepeatedField<TowerDefenceBattleScoreInfo>();

		// Token: 0x04009B4E RID: 39758
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04009B4F RID: 39759
		private int roleId_;

		// Token: 0x04009B50 RID: 39760
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04009B51 RID: 39761
		private int playerId_;

		// Token: 0x04009B52 RID: 39762
		public const int TitleFieldNumber = 5;

		// Token: 0x04009B53 RID: 39763
		private int title_;
	}
}
