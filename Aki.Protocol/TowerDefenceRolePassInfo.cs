using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001421 RID: 5153
	public sealed class TowerDefenceRolePassInfo : IMessage<TowerDefenceRolePassInfo>, IMessage, IEquatable<TowerDefenceRolePassInfo>, IDeepCloneable<TowerDefenceRolePassInfo>, IBufferMessage
	{
		// Token: 0x0601B635 RID: 112181 RVA: 0x003FB7EE File Offset: 0x003F99EE
		[NullableContext(1)]
		public static TowerDefenceRolePassInfo Create()
		{
			return new TowerDefenceRolePassInfo();
		}

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x0601B636 RID: 112182 RVA: 0x003FB7F5 File Offset: 0x003F99F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRolePassInfo> Parser
		{
			get
			{
				return TowerDefenceRolePassInfo._parser;
			}
		}

		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x0601B637 RID: 112183 RVA: 0x003FB7FC File Offset: 0x003F99FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x0601B638 RID: 112184 RVA: 0x003FB7FF File Offset: 0x003F99FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRolePassInfo.Descriptor;
			}
		}

		// Token: 0x0601B639 RID: 112185 RVA: 0x003FB806 File Offset: 0x003F9A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRolePassInfo()
		{
		}

		// Token: 0x0601B63A RID: 112186 RVA: 0x003FB81C File Offset: 0x003F9A1C
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

		// Token: 0x0601B63B RID: 112187 RVA: 0x003FB881 File Offset: 0x003F9A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRolePassInfo Clone()
		{
			return new TowerDefenceRolePassInfo(this);
		}

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x0601B63C RID: 112188 RVA: 0x003FB889 File Offset: 0x003F9A89
		// (set) Token: 0x0601B63D RID: 112189 RVA: 0x003FB891 File Offset: 0x003F9A91
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

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x0601B63E RID: 112190 RVA: 0x003FB89A File Offset: 0x003F9A9A
		// (set) Token: 0x0601B63F RID: 112191 RVA: 0x003FB8A2 File Offset: 0x003F9AA2
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

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x0601B640 RID: 112192 RVA: 0x003FB8AB File Offset: 0x003F9AAB
		// (set) Token: 0x0601B641 RID: 112193 RVA: 0x003FB8B3 File Offset: 0x003F9AB3
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

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x0601B642 RID: 112194 RVA: 0x003FB8BC File Offset: 0x003F9ABC
		// (set) Token: 0x0601B643 RID: 112195 RVA: 0x003FB8C4 File Offset: 0x003F9AC4
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

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x0601B644 RID: 112196 RVA: 0x003FB8CD File Offset: 0x003F9ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceBattleScoreInfo> ScoreList
		{
			get
			{
				return this.scoreList_;
			}
		}

		// Token: 0x0601B645 RID: 112197 RVA: 0x003FB8D5 File Offset: 0x003F9AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRolePassInfo);
		}

		// Token: 0x0601B646 RID: 112198 RVA: 0x003FB8E4 File Offset: 0x003F9AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRolePassInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.PhantomId == other.PhantomId && this.Title == other.Title && this.scoreList_.Equals(other.scoreList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B647 RID: 112199 RVA: 0x003FB964 File Offset: 0x003F9B64
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

		// Token: 0x0601B648 RID: 112200 RVA: 0x003FB9FC File Offset: 0x003F9BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B649 RID: 112201 RVA: 0x003FBA09 File Offset: 0x003F9C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B64A RID: 112202 RVA: 0x003FBA14 File Offset: 0x003F9C14
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

		// Token: 0x0601B64B RID: 112203 RVA: 0x003FBAB8 File Offset: 0x003F9CB8
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

		// Token: 0x0601B64C RID: 112204 RVA: 0x003FBB54 File Offset: 0x003F9D54
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

		// Token: 0x0601B64D RID: 112205 RVA: 0x003FBBDD File Offset: 0x003F9DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B64E RID: 112206 RVA: 0x003FBBE8 File Offset: 0x003F9DE8
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

		// Token: 0x04009F7C RID: 40828
		private static readonly MessageParser<TowerDefenceRolePassInfo> _parser = new MessageParser<TowerDefenceRolePassInfo>(() => new TowerDefenceRolePassInfo());

		// Token: 0x04009F7D RID: 40829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F7E RID: 40830
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04009F7F RID: 40831
		private int roleSkinId_;

		// Token: 0x04009F80 RID: 40832
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04009F81 RID: 40833
		private int roleLevel_;

		// Token: 0x04009F82 RID: 40834
		public const int PhantomIdFieldNumber = 3;

		// Token: 0x04009F83 RID: 40835
		private int phantomId_;

		// Token: 0x04009F84 RID: 40836
		public const int TitleFieldNumber = 4;

		// Token: 0x04009F85 RID: 40837
		private int title_;

		// Token: 0x04009F86 RID: 40838
		public const int ScoreListFieldNumber = 5;

		// Token: 0x04009F87 RID: 40839
		private static readonly FieldCodec<TowerDefenceBattleScoreInfo> _repeated_scoreList_codec = FieldCodec.ForMessage<TowerDefenceBattleScoreInfo>(42U, TowerDefenceBattleScoreInfo.Parser);

		// Token: 0x04009F88 RID: 40840
		private readonly RepeatedField<TowerDefenceBattleScoreInfo> scoreList_ = new RepeatedField<TowerDefenceBattleScoreInfo>();
	}
}
