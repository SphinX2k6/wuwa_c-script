using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A62 RID: 2658
	public sealed class MotorFightScoreDetailPb : IMessage<MotorFightScoreDetailPb>, IMessage, IEquatable<MotorFightScoreDetailPb>, IDeepCloneable<MotorFightScoreDetailPb>, IBufferMessage
	{
		// Token: 0x0600E7E6 RID: 59366 RVA: 0x0021E30C File Offset: 0x0021C50C
		[NullableContext(1)]
		public static MotorFightScoreDetailPb Create()
		{
			return new MotorFightScoreDetailPb();
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x0021E313 File Offset: 0x0021C513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x0600E7E8 RID: 59368 RVA: 0x0021E316 File Offset: 0x0021C516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightScoreDetailPb.Descriptor;
			}
		}

		// Token: 0x0600E7E9 RID: 59369 RVA: 0x0021E31D File Offset: 0x0021C51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb()
		{
		}

		// Token: 0x0600E7EA RID: 59370 RVA: 0x0021E328 File Offset: 0x0021C528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb(MotorFightScoreDetailPb other) : this()
		{
			this.collectionScore_ = other.collectionScore_;
			this.waveScore_ = other.waveScore_;
			this.monsterScore_ = other.monsterScore_;
			this.buffGateScore_ = other.buffGateScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7EB RID: 59371 RVA: 0x0021E37C File Offset: 0x0021C57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb Clone()
		{
			return new MotorFightScoreDetailPb(this);
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x0600E7EC RID: 59372 RVA: 0x0021E384 File Offset: 0x0021C584
		// (set) Token: 0x0600E7ED RID: 59373 RVA: 0x0021E38C File Offset: 0x0021C58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CollectionScore
		{
			get
			{
				return this.collectionScore_;
			}
			set
			{
				this.collectionScore_ = value;
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x0021E395 File Offset: 0x0021C595
		// (set) Token: 0x0600E7EF RID: 59375 RVA: 0x0021E39D File Offset: 0x0021C59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveScore
		{
			get
			{
				return this.waveScore_;
			}
			set
			{
				this.waveScore_ = value;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x0021E3A6 File Offset: 0x0021C5A6
		// (set) Token: 0x0600E7F1 RID: 59377 RVA: 0x0021E3AE File Offset: 0x0021C5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterScore
		{
			get
			{
				return this.monsterScore_;
			}
			set
			{
				this.monsterScore_ = value;
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x0600E7F2 RID: 59378 RVA: 0x0021E3B7 File Offset: 0x0021C5B7
		// (set) Token: 0x0600E7F3 RID: 59379 RVA: 0x0021E3BF File Offset: 0x0021C5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffGateScore
		{
			get
			{
				return this.buffGateScore_;
			}
			set
			{
				this.buffGateScore_ = value;
			}
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x0021E3C8 File Offset: 0x0021C5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightScoreDetailPb);
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x0021E3D8 File Offset: 0x0021C5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightScoreDetailPb other)
		{
			return other != null && (other == this || (this.CollectionScore == other.CollectionScore && this.WaveScore == other.WaveScore && this.MonsterScore == other.MonsterScore && this.BuffGateScore == other.BuffGateScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x0021E444 File Offset: 0x0021C644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CollectionScore != 0)
			{
				num ^= this.CollectionScore.GetHashCode();
			}
			if (this.WaveScore != 0)
			{
				num ^= this.WaveScore.GetHashCode();
			}
			if (this.MonsterScore != 0)
			{
				num ^= this.MonsterScore.GetHashCode();
			}
			if (this.BuffGateScore != 0)
			{
				num ^= this.BuffGateScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x0021E4CE File Offset: 0x0021C6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7F8 RID: 59384 RVA: 0x0021E4DB File Offset: 0x0021C6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7F9 RID: 59385 RVA: 0x0021E4E4 File Offset: 0x0021C6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CollectionScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CollectionScore);
			}
			if (this.WaveScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WaveScore);
			}
			if (this.MonsterScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MonsterScore);
			}
			if (this.BuffGateScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BuffGateScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7FA RID: 59386 RVA: 0x0021E574 File Offset: 0x0021C774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CollectionScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CollectionScore);
			}
			if (this.WaveScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveScore);
			}
			if (this.MonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterScore);
			}
			if (this.BuffGateScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffGateScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7FB RID: 59387 RVA: 0x0021E5FC File Offset: 0x0021C7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightScoreDetailPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CollectionScore != 0)
			{
				this.CollectionScore = other.CollectionScore;
			}
			if (other.WaveScore != 0)
			{
				this.WaveScore = other.WaveScore;
			}
			if (other.MonsterScore != 0)
			{
				this.MonsterScore = other.MonsterScore;
			}
			if (other.BuffGateScore != 0)
			{
				this.BuffGateScore = other.BuffGateScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7FC RID: 59388 RVA: 0x0021E674 File Offset: 0x0021C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7FD RID: 59389 RVA: 0x0021E680 File Offset: 0x0021C880
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
						this.CollectionScore = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.WaveScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BuffGateScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005E82 RID: 24194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E83 RID: 24195
		public const int CollectionScoreFieldNumber = 1;

		// Token: 0x04005E84 RID: 24196
		private int collectionScore_;

		// Token: 0x04005E85 RID: 24197
		public const int WaveScoreFieldNumber = 2;

		// Token: 0x04005E86 RID: 24198
		private int waveScore_;

		// Token: 0x04005E87 RID: 24199
		public const int MonsterScoreFieldNumber = 3;

		// Token: 0x04005E88 RID: 24200
		private int monsterScore_;

		// Token: 0x04005E89 RID: 24201
		public const int BuffGateScoreFieldNumber = 4;

		// Token: 0x04005E8A RID: 24202
		private int buffGateScore_;
	}
}
