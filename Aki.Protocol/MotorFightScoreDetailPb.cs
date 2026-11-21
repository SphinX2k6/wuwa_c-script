using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A51 RID: 2641
	public sealed class MotorFightScoreDetailPb : IMessage<MotorFightScoreDetailPb>, IMessage, IEquatable<MotorFightScoreDetailPb>, IDeepCloneable<MotorFightScoreDetailPb>, IBufferMessage
	{
		// Token: 0x0600E6CC RID: 59084 RVA: 0x0021C118 File Offset: 0x0021A318
		[NullableContext(1)]
		public static MotorFightScoreDetailPb Create()
		{
			return new MotorFightScoreDetailPb();
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x0600E6CD RID: 59085 RVA: 0x0021C11F File Offset: 0x0021A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x0021C122 File Offset: 0x0021A322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightScoreDetailPb.Descriptor;
			}
		}

		// Token: 0x0600E6CF RID: 59087 RVA: 0x0021C129 File Offset: 0x0021A329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb()
		{
		}

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x0021C134 File Offset: 0x0021A334
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

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x0021C188 File Offset: 0x0021A388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightScoreDetailPb Clone()
		{
			return new MotorFightScoreDetailPb(this);
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0600E6D2 RID: 59090 RVA: 0x0021C190 File Offset: 0x0021A390
		// (set) Token: 0x0600E6D3 RID: 59091 RVA: 0x0021C198 File Offset: 0x0021A398
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

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x0021C1A1 File Offset: 0x0021A3A1
		// (set) Token: 0x0600E6D5 RID: 59093 RVA: 0x0021C1A9 File Offset: 0x0021A3A9
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

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x0021C1B2 File Offset: 0x0021A3B2
		// (set) Token: 0x0600E6D7 RID: 59095 RVA: 0x0021C1BA File Offset: 0x0021A3BA
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

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x0021C1C3 File Offset: 0x0021A3C3
		// (set) Token: 0x0600E6D9 RID: 59097 RVA: 0x0021C1CB File Offset: 0x0021A3CB
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

		// Token: 0x0600E6DA RID: 59098 RVA: 0x0021C1D4 File Offset: 0x0021A3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightScoreDetailPb);
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x0021C1E4 File Offset: 0x0021A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightScoreDetailPb other)
		{
			return other != null && (other == this || (this.CollectionScore == other.CollectionScore && this.WaveScore == other.WaveScore && this.MonsterScore == other.MonsterScore && this.BuffGateScore == other.BuffGateScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x0021C250 File Offset: 0x0021A450
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

		// Token: 0x0600E6DD RID: 59101 RVA: 0x0021C2DA File Offset: 0x0021A4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x0021C2E7 File Offset: 0x0021A4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x0021C2F0 File Offset: 0x0021A4F0
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

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x0021C380 File Offset: 0x0021A580
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

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x0021C408 File Offset: 0x0021A608
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

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x0021C480 File Offset: 0x0021A680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x0021C48C File Offset: 0x0021A68C
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

		// Token: 0x04005E8B RID: 24203
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E8C RID: 24204
		public const int CollectionScoreFieldNumber = 1;

		// Token: 0x04005E8D RID: 24205
		private int collectionScore_;

		// Token: 0x04005E8E RID: 24206
		public const int WaveScoreFieldNumber = 2;

		// Token: 0x04005E8F RID: 24207
		private int waveScore_;

		// Token: 0x04005E90 RID: 24208
		public const int MonsterScoreFieldNumber = 3;

		// Token: 0x04005E91 RID: 24209
		private int monsterScore_;

		// Token: 0x04005E92 RID: 24210
		public const int BuffGateScoreFieldNumber = 4;

		// Token: 0x04005E93 RID: 24211
		private int buffGateScore_;
	}
}
