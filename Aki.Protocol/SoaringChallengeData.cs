using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129E RID: 4766
	public sealed class SoaringChallengeData : IMessage<SoaringChallengeData>, IMessage, IEquatable<SoaringChallengeData>, IDeepCloneable<SoaringChallengeData>, IBufferMessage
	{
		// Token: 0x060196F9 RID: 104185 RVA: 0x003B58D9 File Offset: 0x003B3AD9
		[NullableContext(1)]
		public static SoaringChallengeData Create()
		{
			return new SoaringChallengeData();
		}

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x060196FA RID: 104186 RVA: 0x003B58E0 File Offset: 0x003B3AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x060196FB RID: 104187 RVA: 0x003B58E3 File Offset: 0x003B3AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SoaringChallengeData.Descriptor;
			}
		}

		// Token: 0x060196FC RID: 104188 RVA: 0x003B58EA File Offset: 0x003B3AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData()
		{
		}

		// Token: 0x060196FD RID: 104189 RVA: 0x003B58F4 File Offset: 0x003B3AF4
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

		// Token: 0x060196FE RID: 104190 RVA: 0x003B5948 File Offset: 0x003B3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SoaringChallengeData Clone()
		{
			return new SoaringChallengeData(this);
		}

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x060196FF RID: 104191 RVA: 0x003B5950 File Offset: 0x003B3B50
		// (set) Token: 0x06019700 RID: 104192 RVA: 0x003B5958 File Offset: 0x003B3B58
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

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x06019701 RID: 104193 RVA: 0x003B5961 File Offset: 0x003B3B61
		// (set) Token: 0x06019702 RID: 104194 RVA: 0x003B5969 File Offset: 0x003B3B69
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

		// Token: 0x1700560D RID: 22029
		// (get) Token: 0x06019703 RID: 104195 RVA: 0x003B5972 File Offset: 0x003B3B72
		// (set) Token: 0x06019704 RID: 104196 RVA: 0x003B597A File Offset: 0x003B3B7A
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

		// Token: 0x1700560E RID: 22030
		// (get) Token: 0x06019705 RID: 104197 RVA: 0x003B5983 File Offset: 0x003B3B83
		// (set) Token: 0x06019706 RID: 104198 RVA: 0x003B598B File Offset: 0x003B3B8B
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

		// Token: 0x06019707 RID: 104199 RVA: 0x003B5994 File Offset: 0x003B3B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SoaringChallengeData);
		}

		// Token: 0x06019708 RID: 104200 RVA: 0x003B59A4 File Offset: 0x003B3BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SoaringChallengeData other)
		{
			return other != null && (other == this || (this.RankS == other.RankS && this.RankA == other.RankA && this.RankB == other.RankB && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019709 RID: 104201 RVA: 0x003B5A10 File Offset: 0x003B3C10
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

		// Token: 0x0601970A RID: 104202 RVA: 0x003B5A9A File Offset: 0x003B3C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601970B RID: 104203 RVA: 0x003B5AA7 File Offset: 0x003B3CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601970C RID: 104204 RVA: 0x003B5AB0 File Offset: 0x003B3CB0
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

		// Token: 0x0601970D RID: 104205 RVA: 0x003B5B40 File Offset: 0x003B3D40
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

		// Token: 0x0601970E RID: 104206 RVA: 0x003B5BC8 File Offset: 0x003B3DC8
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

		// Token: 0x0601970F RID: 104207 RVA: 0x003B5C40 File Offset: 0x003B3E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019710 RID: 104208 RVA: 0x003B5C4C File Offset: 0x003B3E4C
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

		// Token: 0x04009658 RID: 38488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009659 RID: 38489
		public const int RankSFieldNumber = 1;

		// Token: 0x0400965A RID: 38490
		private int rankS_;

		// Token: 0x0400965B RID: 38491
		public const int RankAFieldNumber = 2;

		// Token: 0x0400965C RID: 38492
		private int rankA_;

		// Token: 0x0400965D RID: 38493
		public const int RankBFieldNumber = 3;

		// Token: 0x0400965E RID: 38494
		private int rankB_;

		// Token: 0x0400965F RID: 38495
		public const int ScoreFieldNumber = 4;

		// Token: 0x04009660 RID: 38496
		private int score_;
	}
}
