using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001043 RID: 4163
	[NetMessage(EMessageId.RogueWeeklyResultNotify)]
	public sealed class RogueWeeklyResultNotify : IMessage<RogueWeeklyResultNotify>, IMessage, IEquatable<RogueWeeklyResultNotify>, IDeepCloneable<RogueWeeklyResultNotify>, IBufferMessage
	{
		// Token: 0x060163E9 RID: 91113 RVA: 0x0033B34C File Offset: 0x0033954C
		[NullableContext(1)]
		public static RogueWeeklyResultNotify Create()
		{
			return new RogueWeeklyResultNotify();
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x060163EA RID: 91114 RVA: 0x0033B353 File Offset: 0x00339553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x060163EB RID: 91115 RVA: 0x0033B356 File Offset: 0x00339556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyResultNotify.Descriptor;
			}
		}

		// Token: 0x060163EC RID: 91116 RVA: 0x0033B35D File Offset: 0x0033955D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultNotify()
		{
		}

		// Token: 0x060163ED RID: 91117 RVA: 0x0033B368 File Offset: 0x00339568
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

		// Token: 0x060163EE RID: 91118 RVA: 0x0033B3C8 File Offset: 0x003395C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyResultNotify Clone()
		{
			return new RogueWeeklyResultNotify(this);
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x060163EF RID: 91119 RVA: 0x0033B3D0 File Offset: 0x003395D0
		// (set) Token: 0x060163F0 RID: 91120 RVA: 0x0033B3D8 File Offset: 0x003395D8
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

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x060163F1 RID: 91121 RVA: 0x0033B3E1 File Offset: 0x003395E1
		// (set) Token: 0x060163F2 RID: 91122 RVA: 0x0033B3E9 File Offset: 0x003395E9
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

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x060163F3 RID: 91123 RVA: 0x0033B3F2 File Offset: 0x003395F2
		// (set) Token: 0x060163F4 RID: 91124 RVA: 0x0033B3FA File Offset: 0x003395FA
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

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x060163F5 RID: 91125 RVA: 0x0033B403 File Offset: 0x00339603
		// (set) Token: 0x060163F6 RID: 91126 RVA: 0x0033B40B File Offset: 0x0033960B
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

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x060163F7 RID: 91127 RVA: 0x0033B414 File Offset: 0x00339614
		// (set) Token: 0x060163F8 RID: 91128 RVA: 0x0033B41C File Offset: 0x0033961C
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

		// Token: 0x060163F9 RID: 91129 RVA: 0x0033B425 File Offset: 0x00339625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyResultNotify);
		}

		// Token: 0x060163FA RID: 91130 RVA: 0x0033B434 File Offset: 0x00339634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyResultNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.Score == other.Score && this.ExtraScore == other.ExtraScore && this.UseRecommendRole == other.UseRecommendRole && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163FB RID: 91131 RVA: 0x0033B4B0 File Offset: 0x003396B0
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

		// Token: 0x060163FC RID: 91132 RVA: 0x0033B553 File Offset: 0x00339753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163FD RID: 91133 RVA: 0x0033B560 File Offset: 0x00339760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163FE RID: 91134 RVA: 0x0033B56C File Offset: 0x0033976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurLayer);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Score);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.UseRecommendRole)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.UseRecommendRole);
			}
			if (this.ExtraScore != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ExtraScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060163FF RID: 91135 RVA: 0x0033B61C File Offset: 0x0033981C
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

		// Token: 0x06016400 RID: 91136 RVA: 0x0033B6B0 File Offset: 0x003398B0
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

		// Token: 0x06016401 RID: 91137 RVA: 0x0033B73C File Offset: 0x0033993C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016402 RID: 91138 RVA: 0x0033B748 File Offset: 0x00339948
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
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.UseRecommendRole = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.ExtraScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008510 RID: 34064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008511 RID: 34065
		public const int CurLayerFieldNumber = 5;

		// Token: 0x04008512 RID: 34066
		private int curLayer_;

		// Token: 0x04008513 RID: 34067
		public const int MaxLayerFieldNumber = 8;

		// Token: 0x04008514 RID: 34068
		private int maxLayer_;

		// Token: 0x04008515 RID: 34069
		public const int ScoreFieldNumber = 6;

		// Token: 0x04008516 RID: 34070
		private int score_;

		// Token: 0x04008517 RID: 34071
		public const int ExtraScoreFieldNumber = 13;

		// Token: 0x04008518 RID: 34072
		private int extraScore_;

		// Token: 0x04008519 RID: 34073
		public const int UseRecommendRoleFieldNumber = 10;

		// Token: 0x0400851A RID: 34074
		private bool useRecommendRole_;
	}
}
