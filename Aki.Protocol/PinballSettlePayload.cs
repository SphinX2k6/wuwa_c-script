using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D4F RID: 3407
	public sealed class PinballSettlePayload : IMessage<PinballSettlePayload>, IMessage, IEquatable<PinballSettlePayload>, IDeepCloneable<PinballSettlePayload>, IBufferMessage
	{
		// Token: 0x06012668 RID: 75368 RVA: 0x002AFE27 File Offset: 0x002AE027
		[NullableContext(1)]
		public static PinballSettlePayload Create()
		{
			return new PinballSettlePayload();
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x06012669 RID: 75369 RVA: 0x002AFE2E File Offset: 0x002AE02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0601266A RID: 75370 RVA: 0x002AFE31 File Offset: 0x002AE031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSettlePayload.Descriptor;
			}
		}

		// Token: 0x0601266B RID: 75371 RVA: 0x002AFE38 File Offset: 0x002AE038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload()
		{
		}

		// Token: 0x0601266C RID: 75372 RVA: 0x002AFE4C File Offset: 0x002AE04C
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

		// Token: 0x0601266D RID: 75373 RVA: 0x002AFEBD File Offset: 0x002AE0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSettlePayload Clone()
		{
			return new PinballSettlePayload(this);
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0601266E RID: 75374 RVA: 0x002AFEC5 File Offset: 0x002AE0C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballResultRolePb> RolePbs
		{
			get
			{
				return this.rolePbs_;
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0601266F RID: 75375 RVA: 0x002AFECD File Offset: 0x002AE0CD
		// (set) Token: 0x06012670 RID: 75376 RVA: 0x002AFED5 File Offset: 0x002AE0D5
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

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x06012671 RID: 75377 RVA: 0x002AFEDE File Offset: 0x002AE0DE
		// (set) Token: 0x06012672 RID: 75378 RVA: 0x002AFEE6 File Offset: 0x002AE0E6
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

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x06012673 RID: 75379 RVA: 0x002AFEEF File Offset: 0x002AE0EF
		// (set) Token: 0x06012674 RID: 75380 RVA: 0x002AFEF7 File Offset: 0x002AE0F7
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

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x06012675 RID: 75381 RVA: 0x002AFF00 File Offset: 0x002AE100
		// (set) Token: 0x06012676 RID: 75382 RVA: 0x002AFF08 File Offset: 0x002AE108
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

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x06012677 RID: 75383 RVA: 0x002AFF11 File Offset: 0x002AE111
		// (set) Token: 0x06012678 RID: 75384 RVA: 0x002AFF19 File Offset: 0x002AE119
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

		// Token: 0x06012679 RID: 75385 RVA: 0x002AFF22 File Offset: 0x002AE122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSettlePayload);
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x002AFF30 File Offset: 0x002AE130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSettlePayload other)
		{
			return other != null && (other == this || (this.rolePbs_.Equals(other.rolePbs_) && this.Score == other.Score && this.DashTimes == other.DashTimes && this.BossSkillTimes == other.BossSkillTimes && this.FullEnergyTimes == other.FullEnergyTimes && this.AttackTimes == other.AttackTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601267B RID: 75387 RVA: 0x002AFFC0 File Offset: 0x002AE1C0
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

		// Token: 0x0601267C RID: 75388 RVA: 0x002B0071 File Offset: 0x002AE271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601267D RID: 75389 RVA: 0x002B007E File Offset: 0x002AE27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x002B0088 File Offset: 0x002AE288
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

		// Token: 0x0601267F RID: 75391 RVA: 0x002B0148 File Offset: 0x002AE348
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

		// Token: 0x06012680 RID: 75392 RVA: 0x002B01FC File Offset: 0x002AE3FC
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

		// Token: 0x06012681 RID: 75393 RVA: 0x002B0299 File Offset: 0x002AE499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012682 RID: 75394 RVA: 0x002B02A4 File Offset: 0x002AE4A4
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

		// Token: 0x040072F4 RID: 29428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072F5 RID: 29429
		public const int RolePbsFieldNumber = 1;

		// Token: 0x040072F6 RID: 29430
		private static readonly FieldCodec<PinballResultRolePb> _repeated_rolePbs_codec = FieldCodec.ForMessage<PinballResultRolePb>(10U, PinballResultRolePb.Parser);

		// Token: 0x040072F7 RID: 29431
		private readonly RepeatedField<PinballResultRolePb> rolePbs_ = new RepeatedField<PinballResultRolePb>();

		// Token: 0x040072F8 RID: 29432
		public const int ScoreFieldNumber = 2;

		// Token: 0x040072F9 RID: 29433
		private int score_;

		// Token: 0x040072FA RID: 29434
		public const int DashTimesFieldNumber = 3;

		// Token: 0x040072FB RID: 29435
		private int dashTimes_;

		// Token: 0x040072FC RID: 29436
		public const int BossSkillTimesFieldNumber = 4;

		// Token: 0x040072FD RID: 29437
		private int bossSkillTimes_;

		// Token: 0x040072FE RID: 29438
		public const int FullEnergyTimesFieldNumber = 5;

		// Token: 0x040072FF RID: 29439
		private int fullEnergyTimes_;

		// Token: 0x04007300 RID: 29440
		public const int AttackTimesFieldNumber = 6;

		// Token: 0x04007301 RID: 29441
		private int attackTimes_;
	}
}
