using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B9B RID: 2971
	public sealed class OnlineMotorSettleInfo : IMessage<OnlineMotorSettleInfo>, IMessage, IEquatable<OnlineMotorSettleInfo>, IDeepCloneable<OnlineMotorSettleInfo>, IBufferMessage
	{
		// Token: 0x060101BF RID: 65983 RVA: 0x00259F4B File Offset: 0x0025814B
		[NullableContext(1)]
		public static OnlineMotorSettleInfo Create()
		{
			return new OnlineMotorSettleInfo();
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x060101C0 RID: 65984 RVA: 0x00259F52 File Offset: 0x00258152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnlineMotorSettleInfo> Parser
		{
			get
			{
				return OnlineMotorSettleInfo._parser;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x060101C1 RID: 65985 RVA: 0x00259F59 File Offset: 0x00258159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x060101C2 RID: 65986 RVA: 0x00259F5C File Offset: 0x0025815C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorSettleInfo.Descriptor;
			}
		}

		// Token: 0x060101C3 RID: 65987 RVA: 0x00259F63 File Offset: 0x00258163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleInfo()
		{
		}

		// Token: 0x060101C4 RID: 65988 RVA: 0x00259F78 File Offset: 0x00258178
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

		// Token: 0x060101C5 RID: 65989 RVA: 0x0025A00C File Offset: 0x0025820C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleInfo Clone()
		{
			return new OnlineMotorSettleInfo(this);
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x060101C6 RID: 65990 RVA: 0x0025A014 File Offset: 0x00258214
		// (set) Token: 0x060101C7 RID: 65991 RVA: 0x0025A01C File Offset: 0x0025821C
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

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x060101C8 RID: 65992 RVA: 0x0025A025 File Offset: 0x00258225
		// (set) Token: 0x060101C9 RID: 65993 RVA: 0x0025A02D File Offset: 0x0025822D
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

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x060101CA RID: 65994 RVA: 0x0025A040 File Offset: 0x00258240
		// (set) Token: 0x060101CB RID: 65995 RVA: 0x0025A048 File Offset: 0x00258248
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

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x060101CC RID: 65996 RVA: 0x0025A051 File Offset: 0x00258251
		// (set) Token: 0x060101CD RID: 65997 RVA: 0x0025A059 File Offset: 0x00258259
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

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x060101CE RID: 65998 RVA: 0x0025A062 File Offset: 0x00258262
		// (set) Token: 0x060101CF RID: 65999 RVA: 0x0025A06A File Offset: 0x0025826A
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

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x060101D0 RID: 66000 RVA: 0x0025A073 File Offset: 0x00258273
		// (set) Token: 0x060101D1 RID: 66001 RVA: 0x0025A07B File Offset: 0x0025827B
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

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x060101D2 RID: 66002 RVA: 0x0025A084 File Offset: 0x00258284
		// (set) Token: 0x060101D3 RID: 66003 RVA: 0x0025A08C File Offset: 0x0025828C
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

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x060101D4 RID: 66004 RVA: 0x0025A095 File Offset: 0x00258295
		// (set) Token: 0x060101D5 RID: 66005 RVA: 0x0025A09D File Offset: 0x0025829D
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

		// Token: 0x060101D6 RID: 66006 RVA: 0x0025A0A6 File Offset: 0x002582A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorSettleInfo);
		}

		// Token: 0x060101D7 RID: 66007 RVA: 0x0025A0B4 File Offset: 0x002582B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorSettleInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.Role == other.Role && this.Ranking == other.Ranking && this.ConsumeTime == other.ConsumeTime && this.IsFinished == other.IsFinished && object.Equals(this.ChampionExtra, other.ChampionExtra) && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060101D8 RID: 66008 RVA: 0x0025A168 File Offset: 0x00258368
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

		// Token: 0x060101D9 RID: 66009 RVA: 0x0025A255 File Offset: 0x00258455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060101DA RID: 66010 RVA: 0x0025A262 File Offset: 0x00258462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060101DB RID: 66011 RVA: 0x0025A26C File Offset: 0x0025846C
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

		// Token: 0x060101DC RID: 66012 RVA: 0x0025A374 File Offset: 0x00258574
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

		// Token: 0x060101DD RID: 66013 RVA: 0x0025A454 File Offset: 0x00258654
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

		// Token: 0x060101DE RID: 66014 RVA: 0x0025A539 File Offset: 0x00258739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060101DF RID: 66015 RVA: 0x0025A544 File Offset: 0x00258744
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

		// Token: 0x040066AD RID: 26285
		private static readonly MessageParser<OnlineMotorSettleInfo> _parser = new MessageParser<OnlineMotorSettleInfo>(() => new OnlineMotorSettleInfo());

		// Token: 0x040066AE RID: 26286
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066AF RID: 26287
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x040066B0 RID: 26288
		private int playerId_;

		// Token: 0x040066B1 RID: 26289
		public const int NameFieldNumber = 2;

		// Token: 0x040066B2 RID: 26290
		private string name_ = "";

		// Token: 0x040066B3 RID: 26291
		public const int RoleFieldNumber = 3;

		// Token: 0x040066B4 RID: 26292
		private int role_;

		// Token: 0x040066B5 RID: 26293
		public const int RankingFieldNumber = 4;

		// Token: 0x040066B6 RID: 26294
		private int ranking_;

		// Token: 0x040066B7 RID: 26295
		public const int ConsumeTimeFieldNumber = 5;

		// Token: 0x040066B8 RID: 26296
		private int consumeTime_;

		// Token: 0x040066B9 RID: 26297
		public const int IsFinishedFieldNumber = 6;

		// Token: 0x040066BA RID: 26298
		private bool isFinished_;

		// Token: 0x040066BB RID: 26299
		public const int ChampionExtraFieldNumber = 7;

		// Token: 0x040066BC RID: 26300
		private ChampionExtra championExtra_;

		// Token: 0x040066BD RID: 26301
		public const int SkinIdFieldNumber = 8;

		// Token: 0x040066BE RID: 26302
		private int skinId_;
	}
}
