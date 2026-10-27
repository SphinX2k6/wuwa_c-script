using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD0 RID: 2768
	[NetMessage(EMessageId.MowTowerResultNotify)]
	public sealed class MowTowerResultNotify : IMessage<MowTowerResultNotify>, IMessage, IEquatable<MowTowerResultNotify>, IDeepCloneable<MowTowerResultNotify>, IBufferMessage
	{
		// Token: 0x0600F0F9 RID: 61689 RVA: 0x00233531 File Offset: 0x00231731
		[NullableContext(1)]
		public static MowTowerResultNotify Create()
		{
			return new MowTowerResultNotify();
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600F0FA RID: 61690 RVA: 0x00233538 File Offset: 0x00231738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600F0FB RID: 61691 RVA: 0x0023353B File Offset: 0x0023173B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x0600F0FC RID: 61692 RVA: 0x00233542 File Offset: 0x00231742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerResultNotify()
		{
		}

		// Token: 0x0600F0FD RID: 61693 RVA: 0x0023354C File Offset: 0x0023174C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerResultNotify(MowTowerResultNotify other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.firstKilMonsterScore_ = other.firstKilMonsterScore_;
			this.firstTimerScore_ = other.firstTimerScore_;
			this.secondKilMonsterScore_ = other.secondKilMonsterScore_;
			this.secondTimerScore_ = other.secondTimerScore_;
			this.highScore_ = other.highScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0FE RID: 61694 RVA: 0x002335B8 File Offset: 0x002317B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerResultNotify Clone()
		{
			return new MowTowerResultNotify(this);
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600F0FF RID: 61695 RVA: 0x002335C0 File Offset: 0x002317C0
		// (set) Token: 0x0600F100 RID: 61696 RVA: 0x002335C8 File Offset: 0x002317C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600F101 RID: 61697 RVA: 0x002335D1 File Offset: 0x002317D1
		// (set) Token: 0x0600F102 RID: 61698 RVA: 0x002335D9 File Offset: 0x002317D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstKilMonsterScore
		{
			get
			{
				return this.firstKilMonsterScore_;
			}
			set
			{
				this.firstKilMonsterScore_ = value;
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600F103 RID: 61699 RVA: 0x002335E2 File Offset: 0x002317E2
		// (set) Token: 0x0600F104 RID: 61700 RVA: 0x002335EA File Offset: 0x002317EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstTimerScore
		{
			get
			{
				return this.firstTimerScore_;
			}
			set
			{
				this.firstTimerScore_ = value;
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600F105 RID: 61701 RVA: 0x002335F3 File Offset: 0x002317F3
		// (set) Token: 0x0600F106 RID: 61702 RVA: 0x002335FB File Offset: 0x002317FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondKilMonsterScore
		{
			get
			{
				return this.secondKilMonsterScore_;
			}
			set
			{
				this.secondKilMonsterScore_ = value;
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600F107 RID: 61703 RVA: 0x00233604 File Offset: 0x00231804
		// (set) Token: 0x0600F108 RID: 61704 RVA: 0x0023360C File Offset: 0x0023180C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondTimerScore
		{
			get
			{
				return this.secondTimerScore_;
			}
			set
			{
				this.secondTimerScore_ = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600F109 RID: 61705 RVA: 0x00233615 File Offset: 0x00231815
		// (set) Token: 0x0600F10A RID: 61706 RVA: 0x0023361D File Offset: 0x0023181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HighScore
		{
			get
			{
				return this.highScore_;
			}
			set
			{
				this.highScore_ = value;
			}
		}

		// Token: 0x0600F10B RID: 61707 RVA: 0x00233626 File Offset: 0x00231826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerResultNotify);
		}

		// Token: 0x0600F10C RID: 61708 RVA: 0x00233634 File Offset: 0x00231834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKilMonsterScore == other.FirstKilMonsterScore && this.FirstTimerScore == other.FirstTimerScore && this.SecondKilMonsterScore == other.SecondKilMonsterScore && this.SecondTimerScore == other.SecondTimerScore && this.HighScore == other.HighScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F10D RID: 61709 RVA: 0x002336C0 File Offset: 0x002318C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.FirstKilMonsterScore != 0)
			{
				num ^= this.FirstKilMonsterScore.GetHashCode();
			}
			if (this.FirstTimerScore != 0)
			{
				num ^= this.FirstTimerScore.GetHashCode();
			}
			if (this.SecondKilMonsterScore != 0)
			{
				num ^= this.SecondKilMonsterScore.GetHashCode();
			}
			if (this.SecondTimerScore != 0)
			{
				num ^= this.SecondTimerScore.GetHashCode();
			}
			if (this.HighScore != 0)
			{
				num ^= this.HighScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F10E RID: 61710 RVA: 0x0023377C File Offset: 0x0023197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F10F RID: 61711 RVA: 0x00233789 File Offset: 0x00231989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F110 RID: 61712 RVA: 0x00233794 File Offset: 0x00231994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			if (this.FirstTimerScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FirstTimerScore);
			}
			if (this.HighScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HighScore);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FirstKilMonsterScore);
			}
			if (this.SecondKilMonsterScore != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SecondKilMonsterScore);
			}
			if (this.SecondTimerScore != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SecondTimerScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F111 RID: 61713 RVA: 0x0023385C File Offset: 0x00231A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstKilMonsterScore);
			}
			if (this.FirstTimerScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstTimerScore);
			}
			if (this.SecondKilMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondKilMonsterScore);
			}
			if (this.SecondTimerScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondTimerScore);
			}
			if (this.HighScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HighScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F112 RID: 61714 RVA: 0x00233914 File Offset: 0x00231B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.FirstKilMonsterScore != 0)
			{
				this.FirstKilMonsterScore = other.FirstKilMonsterScore;
			}
			if (other.FirstTimerScore != 0)
			{
				this.FirstTimerScore = other.FirstTimerScore;
			}
			if (other.SecondKilMonsterScore != 0)
			{
				this.SecondKilMonsterScore = other.SecondKilMonsterScore;
			}
			if (other.SecondTimerScore != 0)
			{
				this.SecondTimerScore = other.SecondTimerScore;
			}
			if (other.HighScore != 0)
			{
				this.HighScore = other.HighScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F113 RID: 61715 RVA: 0x002339B4 File Offset: 0x00231BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F114 RID: 61716 RVA: 0x002339C0 File Offset: 0x00231BC0
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
					if (num == 8U)
					{
						this.LevelsId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FirstTimerScore = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.FirstKilMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SecondKilMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.SecondTimerScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006165 RID: 24933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006166 RID: 24934
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04006167 RID: 24935
		private int levelsId_;

		// Token: 0x04006168 RID: 24936
		public const int FirstKilMonsterScoreFieldNumber = 8;

		// Token: 0x04006169 RID: 24937
		private int firstKilMonsterScore_;

		// Token: 0x0400616A RID: 24938
		public const int FirstTimerScoreFieldNumber = 4;

		// Token: 0x0400616B RID: 24939
		private int firstTimerScore_;

		// Token: 0x0400616C RID: 24940
		public const int SecondKilMonsterScoreFieldNumber = 10;

		// Token: 0x0400616D RID: 24941
		private int secondKilMonsterScore_;

		// Token: 0x0400616E RID: 24942
		public const int SecondTimerScoreFieldNumber = 15;

		// Token: 0x0400616F RID: 24943
		private int secondTimerScore_;

		// Token: 0x04006170 RID: 24944
		public const int HighScoreFieldNumber = 7;

		// Token: 0x04006171 RID: 24945
		private int highScore_;
	}
}
