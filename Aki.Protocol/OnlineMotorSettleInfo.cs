using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8B RID: 2955
	public sealed class OnlineMotorSettleInfo : IMessage<OnlineMotorSettleInfo>, IMessage, IEquatable<OnlineMotorSettleInfo>, IDeepCloneable<OnlineMotorSettleInfo>, IBufferMessage
	{
		// Token: 0x060100BB RID: 65723 RVA: 0x0025807F File Offset: 0x0025627F
		[NullableContext(1)]
		public static OnlineMotorSettleInfo Create()
		{
			return new OnlineMotorSettleInfo();
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x060100BC RID: 65724 RVA: 0x00258086 File Offset: 0x00256286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorSettleInfo> Parser
		{
			get
			{
				return OnlineMotorSettleInfo._parser;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x060100BD RID: 65725 RVA: 0x0025808D File Offset: 0x0025628D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x060100BE RID: 65726 RVA: 0x00258090 File Offset: 0x00256290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorSettleInfo.Descriptor;
			}
		}

		// Token: 0x060100BF RID: 65727 RVA: 0x00258097 File Offset: 0x00256297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleInfo()
		{
		}

		// Token: 0x060100C0 RID: 65728 RVA: 0x002580AC File Offset: 0x002562AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleInfo(OnlineMotorSettleInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.role_ = other.role_;
			this.ranking_ = other.ranking_;
			this.consumeTime_ = other.consumeTime_;
			this.isFinished_ = other.isFinished_;
			this.championExtra_ = ((other.championExtra_ != null) ? other.championExtra_.Clone() : null);
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100C1 RID: 65729 RVA: 0x00258140 File Offset: 0x00256340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleInfo Clone()
		{
			return new OnlineMotorSettleInfo(this);
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x060100C2 RID: 65730 RVA: 0x00258148 File Offset: 0x00256348
		// (set) Token: 0x060100C3 RID: 65731 RVA: 0x00258150 File Offset: 0x00256350
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

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x060100C4 RID: 65732 RVA: 0x00258159 File Offset: 0x00256359
		// (set) Token: 0x060100C5 RID: 65733 RVA: 0x00258161 File Offset: 0x00256361
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

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x060100C6 RID: 65734 RVA: 0x00258174 File Offset: 0x00256374
		// (set) Token: 0x060100C7 RID: 65735 RVA: 0x0025817C File Offset: 0x0025637C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Role
		{
			get
			{
				return this.role_;
			}
			set
			{
				this.role_ = value;
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x060100C8 RID: 65736 RVA: 0x00258185 File Offset: 0x00256385
		// (set) Token: 0x060100C9 RID: 65737 RVA: 0x0025818D File Offset: 0x0025638D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Ranking
		{
			get
			{
				return this.ranking_;
			}
			set
			{
				this.ranking_ = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x060100CA RID: 65738 RVA: 0x00258196 File Offset: 0x00256396
		// (set) Token: 0x060100CB RID: 65739 RVA: 0x0025819E File Offset: 0x0025639E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsumeTime
		{
			get
			{
				return this.consumeTime_;
			}
			set
			{
				this.consumeTime_ = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x060100CC RID: 65740 RVA: 0x002581A7 File Offset: 0x002563A7
		// (set) Token: 0x060100CD RID: 65741 RVA: 0x002581AF File Offset: 0x002563AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x060100CE RID: 65742 RVA: 0x002581B8 File Offset: 0x002563B8
		// (set) Token: 0x060100CF RID: 65743 RVA: 0x002581C0 File Offset: 0x002563C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChampionExtra ChampionExtra
		{
			get
			{
				return this.championExtra_;
			}
			set
			{
				this.championExtra_ = value;
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x060100D0 RID: 65744 RVA: 0x002581C9 File Offset: 0x002563C9
		// (set) Token: 0x060100D1 RID: 65745 RVA: 0x002581D1 File Offset: 0x002563D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x060100D2 RID: 65746 RVA: 0x002581DA File Offset: 0x002563DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorSettleInfo);
		}

		// Token: 0x060100D3 RID: 65747 RVA: 0x002581E8 File Offset: 0x002563E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorSettleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.Role == other.Role && this.Ranking == other.Ranking && this.ConsumeTime == other.ConsumeTime && this.IsFinished == other.IsFinished && object.Equals(this.ChampionExtra, other.ChampionExtra) && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100D4 RID: 65748 RVA: 0x0025829C File Offset: 0x0025649C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Role != 0)
			{
				num ^= this.Role.GetHashCode();
			}
			if (this.Ranking != 0)
			{
				num ^= this.Ranking.GetHashCode();
			}
			if (this.ConsumeTime != 0)
			{
				num ^= this.ConsumeTime.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.championExtra_ != null)
			{
				num ^= this.ChampionExtra.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100D5 RID: 65749 RVA: 0x00258389 File Offset: 0x00256589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100D6 RID: 65750 RVA: 0x00258396 File Offset: 0x00256596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100D7 RID: 65751 RVA: 0x002583A0 File Offset: 0x002565A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.Role != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Role);
			}
			if (this.Ranking != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Ranking);
			}
			if (this.ConsumeTime != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ConsumeTime);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsFinished);
			}
			if (this.championExtra_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ChampionExtra);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100D8 RID: 65752 RVA: 0x002584A8 File Offset: 0x002566A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Role != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Role);
			}
			if (this.Ranking != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Ranking);
			}
			if (this.ConsumeTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeTime);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.championExtra_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChampionExtra);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060100D9 RID: 65753 RVA: 0x00258588 File Offset: 0x00256788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorSettleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Role != 0)
			{
				this.Role = other.Role;
			}
			if (other.Ranking != 0)
			{
				this.Ranking = other.Ranking;
			}
			if (other.ConsumeTime != 0)
			{
				this.ConsumeTime = other.ConsumeTime;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.championExtra_ != null)
			{
				if (this.championExtra_ == null)
				{
					this.ChampionExtra = new ChampionExtra();
				}
				this.ChampionExtra.MergeFrom(other.ChampionExtra);
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060100DA RID: 65754 RVA: 0x0025866D File Offset: 0x0025686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100DB RID: 65755 RVA: 0x00258678 File Offset: 0x00256878
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
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.Name = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Role = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Ranking = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.ConsumeTime = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.championExtra_ == null)
						{
							this.ChampionExtra = new ChampionExtra();
						}
						input.ReadMessage(this.ChampionExtra);
						continue;
					}
					if (num == 64U)
					{
						this.SkinId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040066BD RID: 26301
		private static readonly MessageParser<OnlineMotorSettleInfo> _parser = new MessageParser<OnlineMotorSettleInfo>(() => new OnlineMotorSettleInfo());

		// Token: 0x040066BE RID: 26302
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066BF RID: 26303
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040066C0 RID: 26304
		private int playerId_;

		// Token: 0x040066C1 RID: 26305
		public const int NameFieldNumber = 2;

		// Token: 0x040066C2 RID: 26306
		private string name_ = "";

		// Token: 0x040066C3 RID: 26307
		public const int RoleFieldNumber = 3;

		// Token: 0x040066C4 RID: 26308
		private int role_;

		// Token: 0x040066C5 RID: 26309
		public const int RankingFieldNumber = 4;

		// Token: 0x040066C6 RID: 26310
		private int ranking_;

		// Token: 0x040066C7 RID: 26311
		public const int ConsumeTimeFieldNumber = 5;

		// Token: 0x040066C8 RID: 26312
		private int consumeTime_;

		// Token: 0x040066C9 RID: 26313
		public const int IsFinishedFieldNumber = 6;

		// Token: 0x040066CA RID: 26314
		private bool isFinished_;

		// Token: 0x040066CB RID: 26315
		public const int ChampionExtraFieldNumber = 7;

		// Token: 0x040066CC RID: 26316
		private ChampionExtra championExtra_;

		// Token: 0x040066CD RID: 26317
		public const int SkinIdFieldNumber = 8;

		// Token: 0x040066CE RID: 26318
		private int skinId_;
	}
}
