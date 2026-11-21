using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001033 RID: 4147
	[NetMessage(EMessageId.RogueWeeklyResultNotify)]
	public sealed class RogueWeeklyResultNotify : IMessage<RogueWeeklyResultNotify>, IMessage, IEquatable<RogueWeeklyResultNotify>, IDeepCloneable<RogueWeeklyResultNotify>, IBufferMessage
	{
		// Token: 0x06016304 RID: 90884 RVA: 0x00339C7C File Offset: 0x00337E7C
		[NullableContext(1)]
		public static RogueWeeklyResultNotify Create()
		{
			return new RogueWeeklyResultNotify();
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x06016305 RID: 90885 RVA: 0x00339C83 File Offset: 0x00337E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x06016306 RID: 90886 RVA: 0x00339C86 File Offset: 0x00337E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultNotify.Descriptor;
			}
		}

		// Token: 0x06016307 RID: 90887 RVA: 0x00339C8D File Offset: 0x00337E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultNotify()
		{
		}

		// Token: 0x06016308 RID: 90888 RVA: 0x00339C98 File Offset: 0x00337E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultNotify(RogueWeeklyResultNotify other) : this()
		{
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.score_ = other.score_;
			this.extraScore_ = other.extraScore_;
			this.useRecommendRole_ = other.useRecommendRole_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016309 RID: 90889 RVA: 0x00339CF8 File Offset: 0x00337EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultNotify Clone()
		{
			return new RogueWeeklyResultNotify(this);
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x0601630A RID: 90890 RVA: 0x00339D00 File Offset: 0x00337F00
		// (set) Token: 0x0601630B RID: 90891 RVA: 0x00339D08 File Offset: 0x00337F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x0601630C RID: 90892 RVA: 0x00339D11 File Offset: 0x00337F11
		// (set) Token: 0x0601630D RID: 90893 RVA: 0x00339D19 File Offset: 0x00337F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x0601630E RID: 90894 RVA: 0x00339D22 File Offset: 0x00337F22
		// (set) Token: 0x0601630F RID: 90895 RVA: 0x00339D2A File Offset: 0x00337F2A
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

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x06016310 RID: 90896 RVA: 0x00339D33 File Offset: 0x00337F33
		// (set) Token: 0x06016311 RID: 90897 RVA: 0x00339D3B File Offset: 0x00337F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraScore
		{
			get
			{
				return this.extraScore_;
			}
			set
			{
				this.extraScore_ = value;
			}
		}

		// Token: 0x17004A39 RID: 19001
		// (get) Token: 0x06016312 RID: 90898 RVA: 0x00339D44 File Offset: 0x00337F44
		// (set) Token: 0x06016313 RID: 90899 RVA: 0x00339D4C File Offset: 0x00337F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseRecommendRole
		{
			get
			{
				return this.useRecommendRole_;
			}
			set
			{
				this.useRecommendRole_ = value;
			}
		}

		// Token: 0x06016314 RID: 90900 RVA: 0x00339D55 File Offset: 0x00337F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultNotify);
		}

		// Token: 0x06016315 RID: 90901 RVA: 0x00339D64 File Offset: 0x00337F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.Score == other.Score && this.ExtraScore == other.ExtraScore && this.UseRecommendRole == other.UseRecommendRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016316 RID: 90902 RVA: 0x00339DE0 File Offset: 0x00337FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.ExtraScore != 0)
			{
				num ^= this.ExtraScore.GetHashCode();
			}
			if (this.UseRecommendRole)
			{
				num ^= this.UseRecommendRole.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016317 RID: 90903 RVA: 0x00339E83 File Offset: 0x00338083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016318 RID: 90904 RVA: 0x00339E90 File Offset: 0x00338090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016319 RID: 90905 RVA: 0x00339E9C File Offset: 0x0033809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.UseRecommendRole)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.UseRecommendRole);
			}
			if (this.ExtraScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ExtraScore);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Score);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurLayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601631A RID: 90906 RVA: 0x00339F4C File Offset: 0x0033814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.ExtraScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraScore);
			}
			if (this.UseRecommendRole)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601631B RID: 90907 RVA: 0x00339FE0 File Offset: 0x003381E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.ExtraScore != 0)
			{
				this.ExtraScore = other.ExtraScore;
			}
			if (other.UseRecommendRole)
			{
				this.UseRecommendRole = other.UseRecommendRole;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601631C RID: 90908 RVA: 0x0033A06C File Offset: 0x0033826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601631D RID: 90909 RVA: 0x0033A078 File Offset: 0x00338278
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
					if (num == 32U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.UseRecommendRole = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ExtraScore = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400853A RID: 34106
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400853B RID: 34107
		public const int CurLayerFieldNumber = 11;

		// Token: 0x0400853C RID: 34108
		private int curLayer_;

		// Token: 0x0400853D RID: 34109
		public const int MaxLayerFieldNumber = 4;

		// Token: 0x0400853E RID: 34110
		private int maxLayer_;

		// Token: 0x0400853F RID: 34111
		public const int ScoreFieldNumber = 10;

		// Token: 0x04008540 RID: 34112
		private int score_;

		// Token: 0x04008541 RID: 34113
		public const int ExtraScoreFieldNumber = 9;

		// Token: 0x04008542 RID: 34114
		private int extraScore_;

		// Token: 0x04008543 RID: 34115
		public const int UseRecommendRoleFieldNumber = 7;

		// Token: 0x04008544 RID: 34116
		private bool useRecommendRole_;
	}
}
