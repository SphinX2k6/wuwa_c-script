using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8C RID: 2700
	public sealed class MotorRaceChallengeData : IMessage<MotorRaceChallengeData>, IMessage, IEquatable<MotorRaceChallengeData>, IDeepCloneable<MotorRaceChallengeData>, IBufferMessage
	{
		// Token: 0x0600EB77 RID: 60279 RVA: 0x0022673C File Offset: 0x0022493C
		[NullableContext(1)]
		public static MotorRaceChallengeData Create()
		{
			return new MotorRaceChallengeData();
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600EB78 RID: 60280 RVA: 0x00226743 File Offset: 0x00224943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600EB79 RID: 60281 RVA: 0x00226746 File Offset: 0x00224946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorRaceChallengeData.Descriptor;
			}
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x0022674D File Offset: 0x0022494D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData()
		{
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x00226758 File Offset: 0x00224958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData(MotorRaceChallengeData other) : this()
		{
			this.rankS_ = other.rankS_;
			this.rankA_ = other.rankA_;
			this.rankB_ = other.rankB_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x002267AC File Offset: 0x002249AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData Clone()
		{
			return new MotorRaceChallengeData(this);
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0600EB7D RID: 60285 RVA: 0x002267B4 File Offset: 0x002249B4
		// (set) Token: 0x0600EB7E RID: 60286 RVA: 0x002267BC File Offset: 0x002249BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankS
		{
			get
			{
				return this.rankS_;
			}
			set
			{
				this.rankS_ = value;
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600EB7F RID: 60287 RVA: 0x002267C5 File Offset: 0x002249C5
		// (set) Token: 0x0600EB80 RID: 60288 RVA: 0x002267CD File Offset: 0x002249CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankA
		{
			get
			{
				return this.rankA_;
			}
			set
			{
				this.rankA_ = value;
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x002267D6 File Offset: 0x002249D6
		// (set) Token: 0x0600EB82 RID: 60290 RVA: 0x002267DE File Offset: 0x002249DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankB
		{
			get
			{
				return this.rankB_;
			}
			set
			{
				this.rankB_ = value;
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600EB83 RID: 60291 RVA: 0x002267E7 File Offset: 0x002249E7
		// (set) Token: 0x0600EB84 RID: 60292 RVA: 0x002267EF File Offset: 0x002249EF
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

		// Token: 0x0600EB85 RID: 60293 RVA: 0x002267F8 File Offset: 0x002249F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorRaceChallengeData);
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x00226808 File Offset: 0x00224A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorRaceChallengeData other)
		{
			return other != null && (other == this || (this.RankS == other.RankS && this.RankA == other.RankA && this.RankB == other.RankB && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x00226874 File Offset: 0x00224A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RankS != 0)
			{
				num ^= this.RankS.GetHashCode();
			}
			if (this.RankA != 0)
			{
				num ^= this.RankA.GetHashCode();
			}
			if (this.RankB != 0)
			{
				num ^= this.RankB.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x002268FE File Offset: 0x00224AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB89 RID: 60297 RVA: 0x0022690B File Offset: 0x00224B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x00226914 File Offset: 0x00224B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RankS != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RankS);
			}
			if (this.RankA != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RankA);
			}
			if (this.RankB != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RankB);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x002269A4 File Offset: 0x00224BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RankS != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankS);
			}
			if (this.RankA != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankA);
			}
			if (this.RankB != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankB);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x00226A2C File Offset: 0x00224C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorRaceChallengeData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RankS != 0)
			{
				this.RankS = other.RankS;
			}
			if (other.RankA != 0)
			{
				this.RankA = other.RankA;
			}
			if (other.RankB != 0)
			{
				this.RankB = other.RankB;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x00226AA4 File Offset: 0x00224CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x00226AB0 File Offset: 0x00224CB0
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
						this.RankS = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RankA = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RankB = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005FF2 RID: 24562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FF3 RID: 24563
		public const int RankSFieldNumber = 1;

		// Token: 0x04005FF4 RID: 24564
		private int rankS_;

		// Token: 0x04005FF5 RID: 24565
		public const int RankAFieldNumber = 2;

		// Token: 0x04005FF6 RID: 24566
		private int rankA_;

		// Token: 0x04005FF7 RID: 24567
		public const int RankBFieldNumber = 3;

		// Token: 0x04005FF8 RID: 24568
		private int rankB_;

		// Token: 0x04005FF9 RID: 24569
		public const int ScoreFieldNumber = 4;

		// Token: 0x04005FFA RID: 24570
		private int score_;
	}
}
