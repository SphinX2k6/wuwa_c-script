using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001423 RID: 5155
	public sealed class TowerDefenceRoleScoreInfo : IMessage<TowerDefenceRoleScoreInfo>, IMessage, IEquatable<TowerDefenceRoleScoreInfo>, IDeepCloneable<TowerDefenceRoleScoreInfo>, IBufferMessage
	{
		// Token: 0x0601B666 RID: 112230 RVA: 0x003FBFFF File Offset: 0x003FA1FF
		[NullableContext(1)]
		public static TowerDefenceRoleScoreInfo Create()
		{
			return new TowerDefenceRoleScoreInfo();
		}

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0601B667 RID: 112231 RVA: 0x003FC006 File Offset: 0x003FA206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDefenceRoleScoreInfo> Parser
		{
			get
			{
				return TowerDefenceRoleScoreInfo._parser;
			}
		}

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0601B668 RID: 112232 RVA: 0x003FC00D File Offset: 0x003FA20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x0601B669 RID: 112233 RVA: 0x003FC010 File Offset: 0x003FA210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRoleScoreInfo.Descriptor;
			}
		}

		// Token: 0x0601B66A RID: 112234 RVA: 0x003FC017 File Offset: 0x003FA217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleScoreInfo()
		{
		}

		// Token: 0x0601B66B RID: 112235 RVA: 0x003FC02C File Offset: 0x003FA22C
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

		// Token: 0x0601B66C RID: 112236 RVA: 0x003FC085 File Offset: 0x003FA285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRoleScoreInfo Clone()
		{
			return new TowerDefenceRoleScoreInfo(this);
		}

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x0601B66D RID: 112237 RVA: 0x003FC08D File Offset: 0x003FA28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceBattleScoreInfo> ScoreList
		{
			get
			{
				return this.scoreList_;
			}
		}

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0601B66E RID: 112238 RVA: 0x003FC095 File Offset: 0x003FA295
		// (set) Token: 0x0601B66F RID: 112239 RVA: 0x003FC09D File Offset: 0x003FA29D
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

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x0601B670 RID: 112240 RVA: 0x003FC0A6 File Offset: 0x003FA2A6
		// (set) Token: 0x0601B671 RID: 112241 RVA: 0x003FC0AE File Offset: 0x003FA2AE
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

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x0601B672 RID: 112242 RVA: 0x003FC0B7 File Offset: 0x003FA2B7
		// (set) Token: 0x0601B673 RID: 112243 RVA: 0x003FC0BF File Offset: 0x003FA2BF
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

		// Token: 0x0601B674 RID: 112244 RVA: 0x003FC0C8 File Offset: 0x003FA2C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRoleScoreInfo);
		}

		// Token: 0x0601B675 RID: 112245 RVA: 0x003FC0D8 File Offset: 0x003FA2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRoleScoreInfo other)
		{
			return other != null && (other == this || (this.scoreList_.Equals(other.scoreList_) && this.RoleId == other.RoleId && this.PlayerId == other.PlayerId && this.Title == other.Title && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B676 RID: 112246 RVA: 0x003FC148 File Offset: 0x003FA348
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

		// Token: 0x0601B677 RID: 112247 RVA: 0x003FC1C7 File Offset: 0x003FA3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B678 RID: 112248 RVA: 0x003FC1D4 File Offset: 0x003FA3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B679 RID: 112249 RVA: 0x003FC1E0 File Offset: 0x003FA3E0
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

		// Token: 0x0601B67A RID: 112250 RVA: 0x003FC268 File Offset: 0x003FA468
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

		// Token: 0x0601B67B RID: 112251 RVA: 0x003FC2EC File Offset: 0x003FA4EC
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

		// Token: 0x0601B67C RID: 112252 RVA: 0x003FC361 File Offset: 0x003FA561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B67D RID: 112253 RVA: 0x003FC36C File Offset: 0x003FA56C
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

		// Token: 0x04009F90 RID: 40848
		private static readonly MessageParser<TowerDefenceRoleScoreInfo> _parser = new MessageParser<TowerDefenceRoleScoreInfo>(() => new TowerDefenceRoleScoreInfo());

		// Token: 0x04009F91 RID: 40849
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F92 RID: 40850
		public const int ScoreListFieldNumber = 1;

		// Token: 0x04009F93 RID: 40851
		private static readonly FieldCodec<TowerDefenceBattleScoreInfo> _repeated_scoreList_codec = FieldCodec.ForMessage<TowerDefenceBattleScoreInfo>(10U, TowerDefenceBattleScoreInfo.Parser);

		// Token: 0x04009F94 RID: 40852
		private readonly RepeatedField<TowerDefenceBattleScoreInfo> scoreList_ = new RepeatedField<TowerDefenceBattleScoreInfo>();

		// Token: 0x04009F95 RID: 40853
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04009F96 RID: 40854
		private int roleId_;

		// Token: 0x04009F97 RID: 40855
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04009F98 RID: 40856
		private int playerId_;

		// Token: 0x04009F99 RID: 40857
		public const int TitleFieldNumber = 5;

		// Token: 0x04009F9A RID: 40858
		private int title_;
	}
}
