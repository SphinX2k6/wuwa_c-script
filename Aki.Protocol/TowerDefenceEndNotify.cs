using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001410 RID: 5136
	[NetMessage(EMessageId.TowerDefenceEndNotify)]
	public sealed class TowerDefenceEndNotify : IMessage<TowerDefenceEndNotify>, IMessage, IEquatable<TowerDefenceEndNotify>, IDeepCloneable<TowerDefenceEndNotify>, IBufferMessage
	{
		// Token: 0x0601B4CB RID: 111819 RVA: 0x003F85BC File Offset: 0x003F67BC
		[NullableContext(1)]
		public static TowerDefenceEndNotify Create()
		{
			return new TowerDefenceEndNotify();
		}

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x0601B4CC RID: 111820 RVA: 0x003F85C3 File Offset: 0x003F67C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x0601B4CD RID: 111821 RVA: 0x003F85C6 File Offset: 0x003F67C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceEndNotify.Descriptor;
			}
		}

		// Token: 0x0601B4CE RID: 111822 RVA: 0x003F85CD File Offset: 0x003F67CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify()
		{
		}

		// Token: 0x0601B4CF RID: 111823 RVA: 0x003F85E0 File Offset: 0x003F67E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify(TowerDefenceEndNotify other) : this()
		{
			this.success_ = other.success_;
			this.score_ = other.score_;
			this.maxScore_ = other.maxScore_;
			this.instId_ = other.instId_;
			this.passTime_ = other.passTime_;
			this.minPassTime_ = other.minPassTime_;
			this.battleInfo_ = other.battleInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B4D0 RID: 111824 RVA: 0x003F865D File Offset: 0x003F685D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceEndNotify Clone()
		{
			return new TowerDefenceEndNotify(this);
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x0601B4D1 RID: 111825 RVA: 0x003F8665 File Offset: 0x003F6865
		// (set) Token: 0x0601B4D2 RID: 111826 RVA: 0x003F866D File Offset: 0x003F686D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x0601B4D3 RID: 111827 RVA: 0x003F8676 File Offset: 0x003F6876
		// (set) Token: 0x0601B4D4 RID: 111828 RVA: 0x003F867E File Offset: 0x003F687E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x0601B4D5 RID: 111829 RVA: 0x003F8687 File Offset: 0x003F6887
		// (set) Token: 0x0601B4D6 RID: 111830 RVA: 0x003F868F File Offset: 0x003F688F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x0601B4D7 RID: 111831 RVA: 0x003F8698 File Offset: 0x003F6898
		// (set) Token: 0x0601B4D8 RID: 111832 RVA: 0x003F86A0 File Offset: 0x003F68A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x0601B4D9 RID: 111833 RVA: 0x003F86A9 File Offset: 0x003F68A9
		// (set) Token: 0x0601B4DA RID: 111834 RVA: 0x003F86B1 File Offset: 0x003F68B1
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

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x0601B4DB RID: 111835 RVA: 0x003F86BA File Offset: 0x003F68BA
		// (set) Token: 0x0601B4DC RID: 111836 RVA: 0x003F86C2 File Offset: 0x003F68C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinPassTime
		{
			get
			{
				return this.minPassTime_;
			}
			set
			{
				this.minPassTime_ = value;
			}
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x0601B4DD RID: 111837 RVA: 0x003F86CB File Offset: 0x003F68CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceRoleScoreInfo> BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
		}

		// Token: 0x0601B4DE RID: 111838 RVA: 0x003F86D3 File Offset: 0x003F68D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceEndNotify);
		}

		// Token: 0x0601B4DF RID: 111839 RVA: 0x003F86E4 File Offset: 0x003F68E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceEndNotify other)
		{
			return other != null && (other == this || (this.Success == other.Success && this.Score == other.Score && this.MaxScore == other.MaxScore && this.InstId == other.InstId && this.PassTime == other.PassTime && this.MinPassTime == other.MinPassTime && this.battleInfo_.Equals(other.battleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4E0 RID: 111840 RVA: 0x003F8784 File Offset: 0x003F6984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this.MinPassTime != 0)
			{
				num ^= this.MinPassTime.GetHashCode();
			}
			num ^= this.battleInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x003F884E File Offset: 0x003F6A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x003F885B File Offset: 0x003F6A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x003F8864 File Offset: 0x003F6A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxScore);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Score);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.PassTime);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.InstId);
			}
			if (this.MinPassTime != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.MinPassTime);
			}
			if (this.Success)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.Success);
			}
			this.battleInfo_.WriteTo(ref output, TowerDefenceEndNotify._repeated_battleInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x003F8940 File Offset: 0x003F6B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Success)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this.MinPassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinPassTime);
			}
			num += this.battleInfo_.CalculateSize(TowerDefenceEndNotify._repeated_battleInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B4E5 RID: 111845 RVA: 0x003F8A00 File Offset: 0x003F6C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceEndNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			if (other.MinPassTime != 0)
			{
				this.MinPassTime = other.MinPassTime;
			}
			this.battleInfo_.Add(other.battleInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x003F8AB1 File Offset: 0x003F6CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4E7 RID: 111847 RVA: 0x003F8ABC File Offset: 0x003F6CBC
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 80U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.MinPassTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Success = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.battleInfo_.AddEntriesFrom(ref input, TowerDefenceEndNotify._repeated_battleInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F0A RID: 40714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F0B RID: 40715
		public const int SuccessFieldNumber = 13;

		// Token: 0x04009F0C RID: 40716
		private bool success_;

		// Token: 0x04009F0D RID: 40717
		public const int ScoreFieldNumber = 6;

		// Token: 0x04009F0E RID: 40718
		private int score_;

		// Token: 0x04009F0F RID: 40719
		public const int MaxScoreFieldNumber = 5;

		// Token: 0x04009F10 RID: 40720
		private int maxScore_;

		// Token: 0x04009F11 RID: 40721
		public const int InstIdFieldNumber = 10;

		// Token: 0x04009F12 RID: 40722
		private int instId_;

		// Token: 0x04009F13 RID: 40723
		public const int PassTimeFieldNumber = 8;

		// Token: 0x04009F14 RID: 40724
		private int passTime_;

		// Token: 0x04009F15 RID: 40725
		public const int MinPassTimeFieldNumber = 11;

		// Token: 0x04009F16 RID: 40726
		private int minPassTime_;

		// Token: 0x04009F17 RID: 40727
		public const int BattleInfoFieldNumber = 15;

		// Token: 0x04009F18 RID: 40728
		private static readonly FieldCodec<TowerDefenceRoleScoreInfo> _repeated_battleInfo_codec = FieldCodec.ForMessage<TowerDefenceRoleScoreInfo>(122U, TowerDefenceRoleScoreInfo.Parser);

		// Token: 0x04009F19 RID: 40729
		private readonly RepeatedField<TowerDefenceRoleScoreInfo> battleInfo_ = new RepeatedField<TowerDefenceRoleScoreInfo>();
	}
}
