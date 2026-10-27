using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A66 RID: 2662
	[NetMessage(EMessageId.MotorFightSelectCollectionRequest)]
	public sealed class MotorFightSelectCollectionRequest : IMessage<MotorFightSelectCollectionRequest>, IMessage, IEquatable<MotorFightSelectCollectionRequest>, IDeepCloneable<MotorFightSelectCollectionRequest>, IBufferMessage
	{
		// Token: 0x0600E83A RID: 59450 RVA: 0x0021EEC1 File Offset: 0x0021D0C1
		[NullableContext(1)]
		public static MotorFightSelectCollectionRequest Create()
		{
			return new MotorFightSelectCollectionRequest();
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600E83B RID: 59451 RVA: 0x0021EEC8 File Offset: 0x0021D0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600E83C RID: 59452 RVA: 0x0021EECB File Offset: 0x0021D0CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSelectCollectionRequest.Descriptor;
			}
		}

		// Token: 0x0600E83D RID: 59453 RVA: 0x0021EED2 File Offset: 0x0021D0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest()
		{
		}

		// Token: 0x0600E83E RID: 59454 RVA: 0x0021EEDC File Offset: 0x0021D0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest(MotorFightSelectCollectionRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this.waveGroupIndex_ = other.waveGroupIndex_;
			this.bossId_ = other.bossId_;
			this.pos_ = other.pos_;
			this.playerHp_ = other.playerHp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E83F RID: 59455 RVA: 0x0021EF3C File Offset: 0x0021D13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSelectCollectionRequest Clone()
		{
			return new MotorFightSelectCollectionRequest(this);
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600E840 RID: 59456 RVA: 0x0021EF44 File Offset: 0x0021D144
		// (set) Token: 0x0600E841 RID: 59457 RVA: 0x0021EF4C File Offset: 0x0021D14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600E842 RID: 59458 RVA: 0x0021EF55 File Offset: 0x0021D155
		// (set) Token: 0x0600E843 RID: 59459 RVA: 0x0021EF5D File Offset: 0x0021D15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveGroupIndex
		{
			get
			{
				return this.waveGroupIndex_;
			}
			set
			{
				this.waveGroupIndex_ = value;
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600E844 RID: 59460 RVA: 0x0021EF66 File Offset: 0x0021D166
		// (set) Token: 0x0600E845 RID: 59461 RVA: 0x0021EF6E File Offset: 0x0021D16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossId
		{
			get
			{
				return this.bossId_;
			}
			set
			{
				this.bossId_ = value;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600E846 RID: 59462 RVA: 0x0021EF77 File Offset: 0x0021D177
		// (set) Token: 0x0600E847 RID: 59463 RVA: 0x0021EF7F File Offset: 0x0021D17F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightCollectionPos Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600E848 RID: 59464 RVA: 0x0021EF88 File Offset: 0x0021D188
		// (set) Token: 0x0600E849 RID: 59465 RVA: 0x0021EF90 File Offset: 0x0021D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerHp
		{
			get
			{
				return this.playerHp_;
			}
			set
			{
				this.playerHp_ = value;
			}
		}

		// Token: 0x0600E84A RID: 59466 RVA: 0x0021EF99 File Offset: 0x0021D199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSelectCollectionRequest);
		}

		// Token: 0x0600E84B RID: 59467 RVA: 0x0021EFA8 File Offset: 0x0021D1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSelectCollectionRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && this.WaveGroupIndex == other.WaveGroupIndex && this.BossId == other.BossId && this.Pos == other.Pos && this.PlayerHp == other.PlayerHp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E84C RID: 59468 RVA: 0x0021F024 File Offset: 0x0021D224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this.WaveGroupIndex != 0)
			{
				num ^= this.WaveGroupIndex.GetHashCode();
			}
			if (this.BossId != 0)
			{
				num ^= this.BossId.GetHashCode();
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.PlayerHp != 0)
			{
				num ^= this.PlayerHp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E84D RID: 59469 RVA: 0x0021F0CD File Offset: 0x0021D2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E84E RID: 59470 RVA: 0x0021F0DA File Offset: 0x0021D2DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E84F RID: 59471 RVA: 0x0021F0E4 File Offset: 0x0021D2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this.BossId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BossId);
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.Pos);
			}
			if (this.PlayerHp != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.PlayerHp);
			}
			if (this.WaveGroupIndex != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WaveGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E850 RID: 59472 RVA: 0x0021F194 File Offset: 0x0021D394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this.WaveGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveGroupIndex);
			}
			if (this.BossId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossId);
			}
			if (this.Pos != MotorFightCollectionPos.First)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this.PlayerHp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerHp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E851 RID: 59473 RVA: 0x0021F234 File Offset: 0x0021D434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSelectCollectionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			if (other.WaveGroupIndex != 0)
			{
				this.WaveGroupIndex = other.WaveGroupIndex;
			}
			if (other.BossId != 0)
			{
				this.BossId = other.BossId;
			}
			if (other.Pos != MotorFightCollectionPos.First)
			{
				this.Pos = other.Pos;
			}
			if (other.PlayerHp != 0)
			{
				this.PlayerHp = other.PlayerHp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E852 RID: 59474 RVA: 0x0021F2C0 File Offset: 0x0021D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E853 RID: 59475 RVA: 0x0021F2CC File Offset: 0x0021D4CC
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.SubLevelIndex = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.BossId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Pos = (MotorFightCollectionPos)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.PlayerHp = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.WaveGroupIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E9B RID: 24219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E9C RID: 24220
		public const int SubLevelIndexFieldNumber = 3;

		// Token: 0x04005E9D RID: 24221
		private int subLevelIndex_;

		// Token: 0x04005E9E RID: 24222
		public const int WaveGroupIndexFieldNumber = 12;

		// Token: 0x04005E9F RID: 24223
		private int waveGroupIndex_;

		// Token: 0x04005EA0 RID: 24224
		public const int BossIdFieldNumber = 7;

		// Token: 0x04005EA1 RID: 24225
		private int bossId_;

		// Token: 0x04005EA2 RID: 24226
		public const int PosFieldNumber = 9;

		// Token: 0x04005EA3 RID: 24227
		private MotorFightCollectionPos pos_;

		// Token: 0x04005EA4 RID: 24228
		public const int PlayerHpFieldNumber = 11;

		// Token: 0x04005EA5 RID: 24229
		private int playerHp_;
	}
}
