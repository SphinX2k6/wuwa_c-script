using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001261 RID: 4705
	public sealed class SoaringChallengeData : IMessage<SoaringChallengeData>, IMessage, IEquatable<SoaringChallengeData>, IDeepCloneable<SoaringChallengeData>, IBufferMessage
	{
		// Token: 0x0601910F RID: 102671 RVA: 0x003A5981 File Offset: 0x003A3B81
		[NullableContext(1)]
		public static SoaringChallengeData Create()
		{
			return new SoaringChallengeData();
		}

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x06019110 RID: 102672 RVA: 0x003A5988 File Offset: 0x003A3B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x06019111 RID: 102673 RVA: 0x003A598B File Offset: 0x003A3B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SoaringChallengeData.Descriptor;
			}
		}

		// Token: 0x06019112 RID: 102674 RVA: 0x003A5992 File Offset: 0x003A3B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData()
		{
		}

		// Token: 0x06019113 RID: 102675 RVA: 0x003A599C File Offset: 0x003A3B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData(SoaringChallengeData other) : this()
		{
			this.rankS_ = other.rankS_;
			this.rankA_ = other.rankA_;
			this.rankB_ = other.rankB_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019114 RID: 102676 RVA: 0x003A59F0 File Offset: 0x003A3BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData Clone()
		{
			return new SoaringChallengeData(this);
		}

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x06019115 RID: 102677 RVA: 0x003A59F8 File Offset: 0x003A3BF8
		// (set) Token: 0x06019116 RID: 102678 RVA: 0x003A5A00 File Offset: 0x003A3C00
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

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x06019117 RID: 102679 RVA: 0x003A5A09 File Offset: 0x003A3C09
		// (set) Token: 0x06019118 RID: 102680 RVA: 0x003A5A11 File Offset: 0x003A3C11
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

		// Token: 0x1700548E RID: 21646
		// (get) Token: 0x06019119 RID: 102681 RVA: 0x003A5A1A File Offset: 0x003A3C1A
		// (set) Token: 0x0601911A RID: 102682 RVA: 0x003A5A22 File Offset: 0x003A3C22
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

		// Token: 0x1700548F RID: 21647
		// (get) Token: 0x0601911B RID: 102683 RVA: 0x003A5A2B File Offset: 0x003A3C2B
		// (set) Token: 0x0601911C RID: 102684 RVA: 0x003A5A33 File Offset: 0x003A3C33
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

		// Token: 0x0601911D RID: 102685 RVA: 0x003A5A3C File Offset: 0x003A3C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SoaringChallengeData);
		}

		// Token: 0x0601911E RID: 102686 RVA: 0x003A5A4C File Offset: 0x003A3C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SoaringChallengeData other)
		{
			return other != null && (other == this || (this.RankS == other.RankS && this.RankA == other.RankA && this.RankB == other.RankB && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x003A5AB8 File Offset: 0x003A3CB8
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

		// Token: 0x06019120 RID: 102688 RVA: 0x003A5B42 File Offset: 0x003A3D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019121 RID: 102689 RVA: 0x003A5B4F File Offset: 0x003A3D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019122 RID: 102690 RVA: 0x003A5B58 File Offset: 0x003A3D58
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

		// Token: 0x06019123 RID: 102691 RVA: 0x003A5BE8 File Offset: 0x003A3DE8
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

		// Token: 0x06019124 RID: 102692 RVA: 0x003A5C70 File Offset: 0x003A3E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SoaringChallengeData other)
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

		// Token: 0x06019125 RID: 102693 RVA: 0x003A5CE8 File Offset: 0x003A3EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019126 RID: 102694 RVA: 0x003A5CF4 File Offset: 0x003A3EF4
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

		// Token: 0x040093A6 RID: 37798
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093A7 RID: 37799
		public const int RankSFieldNumber = 1;

		// Token: 0x040093A8 RID: 37800
		private int rankS_;

		// Token: 0x040093A9 RID: 37801
		public const int RankAFieldNumber = 2;

		// Token: 0x040093AA RID: 37802
		private int rankA_;

		// Token: 0x040093AB RID: 37803
		public const int RankBFieldNumber = 3;

		// Token: 0x040093AC RID: 37804
		private int rankB_;

		// Token: 0x040093AD RID: 37805
		public const int ScoreFieldNumber = 4;

		// Token: 0x040093AE RID: 37806
		private int score_;
	}
}
