using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5F RID: 3423
	public sealed class PinballSettlePayload : IMessage<PinballSettlePayload>, IMessage, IEquatable<PinballSettlePayload>, IDeepCloneable<PinballSettlePayload>, IBufferMessage
	{
		// Token: 0x06012764 RID: 75620 RVA: 0x002B1A4B File Offset: 0x002AFC4B
		[NullableContext(1)]
		public static PinballSettlePayload Create()
		{
			return new PinballSettlePayload();
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x06012765 RID: 75621 RVA: 0x002B1A52 File Offset: 0x002AFC52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x06012766 RID: 75622 RVA: 0x002B1A55 File Offset: 0x002AFC55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettlePayload.Descriptor;
			}
		}

		// Token: 0x06012767 RID: 75623 RVA: 0x002B1A5C File Offset: 0x002AFC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload()
		{
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x002B1A70 File Offset: 0x002AFC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload(PinballSettlePayload other) : this()
		{
			this.rolePbs_ = other.rolePbs_.Clone();
			this.score_ = other.score_;
			this.dashTimes_ = other.dashTimes_;
			this.bossSkillTimes_ = other.bossSkillTimes_;
			this.fullEnergyTimes_ = other.fullEnergyTimes_;
			this.attackTimes_ = other.attackTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x002B1AE1 File Offset: 0x002AFCE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload Clone()
		{
			return new PinballSettlePayload(this);
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0601276A RID: 75626 RVA: 0x002B1AE9 File Offset: 0x002AFCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballResultRolePb> RolePbs
		{
			get
			{
				return this.rolePbs_;
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0601276B RID: 75627 RVA: 0x002B1AF1 File Offset: 0x002AFCF1
		// (set) Token: 0x0601276C RID: 75628 RVA: 0x002B1AF9 File Offset: 0x002AFCF9
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

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0601276D RID: 75629 RVA: 0x002B1B02 File Offset: 0x002AFD02
		// (set) Token: 0x0601276E RID: 75630 RVA: 0x002B1B0A File Offset: 0x002AFD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DashTimes
		{
			get
			{
				return this.dashTimes_;
			}
			set
			{
				this.dashTimes_ = value;
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0601276F RID: 75631 RVA: 0x002B1B13 File Offset: 0x002AFD13
		// (set) Token: 0x06012770 RID: 75632 RVA: 0x002B1B1B File Offset: 0x002AFD1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossSkillTimes
		{
			get
			{
				return this.bossSkillTimes_;
			}
			set
			{
				this.bossSkillTimes_ = value;
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x06012771 RID: 75633 RVA: 0x002B1B24 File Offset: 0x002AFD24
		// (set) Token: 0x06012772 RID: 75634 RVA: 0x002B1B2C File Offset: 0x002AFD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FullEnergyTimes
		{
			get
			{
				return this.fullEnergyTimes_;
			}
			set
			{
				this.fullEnergyTimes_ = value;
			}
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x06012773 RID: 75635 RVA: 0x002B1B35 File Offset: 0x002AFD35
		// (set) Token: 0x06012774 RID: 75636 RVA: 0x002B1B3D File Offset: 0x002AFD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AttackTimes
		{
			get
			{
				return this.attackTimes_;
			}
			set
			{
				this.attackTimes_ = value;
			}
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x002B1B46 File Offset: 0x002AFD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettlePayload);
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x002B1B54 File Offset: 0x002AFD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettlePayload other)
		{
			return other != null && (other == this || (this.rolePbs_.Equals(other.rolePbs_) && this.Score == other.Score && this.DashTimes == other.DashTimes && this.BossSkillTimes == other.BossSkillTimes && this.FullEnergyTimes == other.FullEnergyTimes && this.AttackTimes == other.AttackTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x002B1BE4 File Offset: 0x002AFDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rolePbs_.GetHashCode();
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.DashTimes != 0)
			{
				num ^= this.DashTimes.GetHashCode();
			}
			if (this.BossSkillTimes != 0)
			{
				num ^= this.BossSkillTimes.GetHashCode();
			}
			if (this.FullEnergyTimes != 0)
			{
				num ^= this.FullEnergyTimes.GetHashCode();
			}
			if (this.AttackTimes != 0)
			{
				num ^= this.AttackTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012778 RID: 75640 RVA: 0x002B1C95 File Offset: 0x002AFE95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012779 RID: 75641 RVA: 0x002B1CA2 File Offset: 0x002AFEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601277A RID: 75642 RVA: 0x002B1CAC File Offset: 0x002AFEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rolePbs_.WriteTo(ref output, PinballSettlePayload._repeated_rolePbs_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.DashTimes != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DashTimes);
			}
			if (this.BossSkillTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BossSkillTimes);
			}
			if (this.FullEnergyTimes != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FullEnergyTimes);
			}
			if (this.AttackTimes != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.AttackTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x002B1D6C File Offset: 0x002AFF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rolePbs_.CalculateSize(PinballSettlePayload._repeated_rolePbs_codec);
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.DashTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DashTimes);
			}
			if (this.BossSkillTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossSkillTimes);
			}
			if (this.FullEnergyTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FullEnergyTimes);
			}
			if (this.AttackTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AttackTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601277C RID: 75644 RVA: 0x002B1E20 File Offset: 0x002B0020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSettlePayload other)
		{
			if (other == null)
			{
				return;
			}
			this.rolePbs_.Add(other.rolePbs_);
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.DashTimes != 0)
			{
				this.DashTimes = other.DashTimes;
			}
			if (other.BossSkillTimes != 0)
			{
				this.BossSkillTimes = other.BossSkillTimes;
			}
			if (other.FullEnergyTimes != 0)
			{
				this.FullEnergyTimes = other.FullEnergyTimes;
			}
			if (other.AttackTimes != 0)
			{
				this.AttackTimes = other.AttackTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601277D RID: 75645 RVA: 0x002B1EBD File Offset: 0x002B00BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601277E RID: 75646 RVA: 0x002B1EC8 File Offset: 0x002B00C8
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
						this.rolePbs_.AddEntriesFrom(ref input, PinballSettlePayload._repeated_rolePbs_codec);
						continue;
					}
					if (num == 16U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.DashTimes = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.BossSkillTimes = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.FullEnergyTimes = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.AttackTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040072DC RID: 29404
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072DD RID: 29405
		public const int RolePbsFieldNumber = 1;

		// Token: 0x040072DE RID: 29406
		private static readonly FieldCodec<PinballResultRolePb> _repeated_rolePbs_codec = FieldCodec.ForMessage<PinballResultRolePb>(10U, PinballResultRolePb.Parser);

		// Token: 0x040072DF RID: 29407
		private readonly RepeatedField<PinballResultRolePb> rolePbs_ = new RepeatedField<PinballResultRolePb>();

		// Token: 0x040072E0 RID: 29408
		public const int ScoreFieldNumber = 2;

		// Token: 0x040072E1 RID: 29409
		private int score_;

		// Token: 0x040072E2 RID: 29410
		public const int DashTimesFieldNumber = 3;

		// Token: 0x040072E3 RID: 29411
		private int dashTimes_;

		// Token: 0x040072E4 RID: 29412
		public const int BossSkillTimesFieldNumber = 4;

		// Token: 0x040072E5 RID: 29413
		private int bossSkillTimes_;

		// Token: 0x040072E6 RID: 29414
		public const int FullEnergyTimesFieldNumber = 5;

		// Token: 0x040072E7 RID: 29415
		private int fullEnergyTimes_;

		// Token: 0x040072E8 RID: 29416
		public const int AttackTimesFieldNumber = 6;

		// Token: 0x040072E9 RID: 29417
		private int attackTimes_;
	}
}
