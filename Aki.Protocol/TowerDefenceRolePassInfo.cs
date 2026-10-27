using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AE RID: 5038
	public sealed class TowerDefenceRolePassInfo : IMessage<TowerDefenceRolePassInfo>, IMessage, IEquatable<TowerDefenceRolePassInfo>, IDeepCloneable<TowerDefenceRolePassInfo>, IBufferMessage
	{
		// Token: 0x0601ABAA RID: 109482 RVA: 0x003E052E File Offset: 0x003DE72E
		[NullableContext(1)]
		public static TowerDefenceRolePassInfo Create()
		{
			return new TowerDefenceRolePassInfo();
		}

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x0601ABAB RID: 109483 RVA: 0x003E0535 File Offset: 0x003DE735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRolePassInfo> Parser
		{
			get
			{
				return TowerDefenceRolePassInfo._parser;
			}
		}

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x0601ABAC RID: 109484 RVA: 0x003E053C File Offset: 0x003DE73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x0601ABAD RID: 109485 RVA: 0x003E053F File Offset: 0x003DE73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRolePassInfo.Descriptor;
			}
		}

		// Token: 0x0601ABAE RID: 109486 RVA: 0x003E0546 File Offset: 0x003DE746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRolePassInfo()
		{
		}

		// Token: 0x0601ABAF RID: 109487 RVA: 0x003E055C File Offset: 0x003DE75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRolePassInfo(TowerDefenceRolePassInfo other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.roleLevel_ = other.roleLevel_;
			this.phantomId_ = other.phantomId_;
			this.title_ = other.title_;
			this.scoreList_ = other.scoreList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABB0 RID: 109488 RVA: 0x003E05C1 File Offset: 0x003DE7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRolePassInfo Clone()
		{
			return new TowerDefenceRolePassInfo(this);
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x0601ABB1 RID: 109489 RVA: 0x003E05C9 File Offset: 0x003DE7C9
		// (set) Token: 0x0601ABB2 RID: 109490 RVA: 0x003E05D1 File Offset: 0x003DE7D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x0601ABB3 RID: 109491 RVA: 0x003E05DA File Offset: 0x003DE7DA
		// (set) Token: 0x0601ABB4 RID: 109492 RVA: 0x003E05E2 File Offset: 0x003DE7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x0601ABB5 RID: 109493 RVA: 0x003E05EB File Offset: 0x003DE7EB
		// (set) Token: 0x0601ABB6 RID: 109494 RVA: 0x003E05F3 File Offset: 0x003DE7F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomId
		{
			get
			{
				return this.phantomId_;
			}
			set
			{
				this.phantomId_ = value;
			}
		}

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x0601ABB7 RID: 109495 RVA: 0x003E05FC File Offset: 0x003DE7FC
		// (set) Token: 0x0601ABB8 RID: 109496 RVA: 0x003E0604 File Offset: 0x003DE804
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

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x0601ABB9 RID: 109497 RVA: 0x003E060D File Offset: 0x003DE80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceBattleScoreInfo> ScoreList
		{
			get
			{
				return this.scoreList_;
			}
		}

		// Token: 0x0601ABBA RID: 109498 RVA: 0x003E0615 File Offset: 0x003DE815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRolePassInfo);
		}

		// Token: 0x0601ABBB RID: 109499 RVA: 0x003E0624 File Offset: 0x003DE824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRolePassInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.PhantomId == other.PhantomId && this.Title == other.Title && this.scoreList_.Equals(other.scoreList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABBC RID: 109500 RVA: 0x003E06A4 File Offset: 0x003DE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.PhantomId != 0)
			{
				num ^= this.PhantomId.GetHashCode();
			}
			if (this.Title != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			num ^= this.scoreList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ABBD RID: 109501 RVA: 0x003E073C File Offset: 0x003DE93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABBE RID: 109502 RVA: 0x003E0749 File Offset: 0x003DE949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ABBF RID: 109503 RVA: 0x003E0754 File Offset: 0x003DE954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.PhantomId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PhantomId);
			}
			if (this.Title != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Title);
			}
			this.scoreList_.WriteTo(ref output, TowerDefenceRolePassInfo._repeated_scoreList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ABC0 RID: 109504 RVA: 0x003E07F8 File Offset: 0x003DE9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.PhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomId);
			}
			if (this.Title != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Title);
			}
			num += this.scoreList_.CalculateSize(TowerDefenceRolePassInfo._repeated_scoreList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ABC1 RID: 109505 RVA: 0x003E0894 File Offset: 0x003DEA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRolePassInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.PhantomId != 0)
			{
				this.PhantomId = other.PhantomId;
			}
			if (other.Title != 0)
			{
				this.Title = other.Title;
			}
			this.scoreList_.Add(other.scoreList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ABC2 RID: 109506 RVA: 0x003E091D File Offset: 0x003DEB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ABC3 RID: 109507 RVA: 0x003E0928 File Offset: 0x003DEB28
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
					if (num == 8U)
					{
						this.RoleSkinId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PhantomId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Title = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.scoreList_.AddEntriesFrom(ref input, TowerDefenceRolePassInfo._repeated_scoreList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B35 RID: 39733
		private static readonly MessageParser<TowerDefenceRolePassInfo> _parser = new MessageParser<TowerDefenceRolePassInfo>(() => new TowerDefenceRolePassInfo());

		// Token: 0x04009B36 RID: 39734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B37 RID: 39735
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04009B38 RID: 39736
		private int roleSkinId_;

		// Token: 0x04009B39 RID: 39737
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04009B3A RID: 39738
		private int roleLevel_;

		// Token: 0x04009B3B RID: 39739
		public const int PhantomIdFieldNumber = 3;

		// Token: 0x04009B3C RID: 39740
		private int phantomId_;

		// Token: 0x04009B3D RID: 39741
		public const int TitleFieldNumber = 4;

		// Token: 0x04009B3E RID: 39742
		private int title_;

		// Token: 0x04009B3F RID: 39743
		public const int ScoreListFieldNumber = 5;

		// Token: 0x04009B40 RID: 39744
		private static readonly FieldCodec<TowerDefenceBattleScoreInfo> _repeated_scoreList_codec = FieldCodec.ForMessage<TowerDefenceBattleScoreInfo>(42U, TowerDefenceBattleScoreInfo.Parser);

		// Token: 0x04009B41 RID: 39745
		private readonly RepeatedField<TowerDefenceBattleScoreInfo> scoreList_ = new RepeatedField<TowerDefenceBattleScoreInfo>();
	}
}
