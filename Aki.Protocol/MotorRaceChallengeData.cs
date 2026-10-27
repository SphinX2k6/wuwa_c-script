using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9D RID: 2717
	public sealed class MotorRaceChallengeData : IMessage<MotorRaceChallengeData>, IMessage, IEquatable<MotorRaceChallengeData>, IDeepCloneable<MotorRaceChallengeData>, IBufferMessage
	{
		// Token: 0x0600EC91 RID: 60561 RVA: 0x00228934 File Offset: 0x00226B34
		[NullableContext(1)]
		public static MotorRaceChallengeData Create()
		{
			return new MotorRaceChallengeData();
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600EC92 RID: 60562 RVA: 0x0022893B File Offset: 0x00226B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600EC93 RID: 60563 RVA: 0x0022893E File Offset: 0x00226B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorRaceChallengeData.Descriptor;
			}
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x00228945 File Offset: 0x00226B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData()
		{
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x00228950 File Offset: 0x00226B50
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

		// Token: 0x0600EC96 RID: 60566 RVA: 0x002289A4 File Offset: 0x00226BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorRaceChallengeData Clone()
		{
			return new MotorRaceChallengeData(this);
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600EC97 RID: 60567 RVA: 0x002289AC File Offset: 0x00226BAC
		// (set) Token: 0x0600EC98 RID: 60568 RVA: 0x002289B4 File Offset: 0x00226BB4
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

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600EC99 RID: 60569 RVA: 0x002289BD File Offset: 0x00226BBD
		// (set) Token: 0x0600EC9A RID: 60570 RVA: 0x002289C5 File Offset: 0x00226BC5
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

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x002289CE File Offset: 0x00226BCE
		// (set) Token: 0x0600EC9C RID: 60572 RVA: 0x002289D6 File Offset: 0x00226BD6
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

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x0600EC9D RID: 60573 RVA: 0x002289DF File Offset: 0x00226BDF
		// (set) Token: 0x0600EC9E RID: 60574 RVA: 0x002289E7 File Offset: 0x00226BE7
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

		// Token: 0x0600EC9F RID: 60575 RVA: 0x002289F0 File Offset: 0x00226BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorRaceChallengeData);
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x00228A00 File Offset: 0x00226C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorRaceChallengeData other)
		{
			return other != null && (other == this || (this.RankS == other.RankS && this.RankA == other.RankA && this.RankB == other.RankB && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x00228A6C File Offset: 0x00226C6C
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

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x00228AF6 File Offset: 0x00226CF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x00228B03 File Offset: 0x00226D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x00228B0C File Offset: 0x00226D0C
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

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x00228B9C File Offset: 0x00226D9C
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

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x00228C24 File Offset: 0x00226E24
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

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x00228C9C File Offset: 0x00226E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECA8 RID: 60584 RVA: 0x00228CA8 File Offset: 0x00226EA8
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

		// Token: 0x04005FE9 RID: 24553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FEA RID: 24554
		public const int RankSFieldNumber = 1;

		// Token: 0x04005FEB RID: 24555
		private int rankS_;

		// Token: 0x04005FEC RID: 24556
		public const int RankAFieldNumber = 2;

		// Token: 0x04005FED RID: 24557
		private int rankA_;

		// Token: 0x04005FEE RID: 24558
		public const int RankBFieldNumber = 3;

		// Token: 0x04005FEF RID: 24559
		private int rankB_;

		// Token: 0x04005FF0 RID: 24560
		public const int ScoreFieldNumber = 4;

		// Token: 0x04005FF1 RID: 24561
		private int score_;
	}
}
