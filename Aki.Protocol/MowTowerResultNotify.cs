using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABF RID: 2751
	[NetMessage(EMessageId.MowTowerResultNotify)]
	public sealed class MowTowerResultNotify : IMessage<MowTowerResultNotify>, IMessage, IEquatable<MowTowerResultNotify>, IDeepCloneable<MowTowerResultNotify>, IBufferMessage
	{
		// Token: 0x0600EFDF RID: 61407 RVA: 0x00231321 File Offset: 0x0022F521
		[NullableContext(1)]
		public static MowTowerResultNotify Create()
		{
			return new MowTowerResultNotify();
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600EFE0 RID: 61408 RVA: 0x00231328 File Offset: 0x0022F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600EFE1 RID: 61409 RVA: 0x0023132B File Offset: 0x0022F52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x0600EFE2 RID: 61410 RVA: 0x00231332 File Offset: 0x0022F532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerResultNotify()
		{
		}

		// Token: 0x0600EFE3 RID: 61411 RVA: 0x0023133C File Offset: 0x0022F53C
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

		// Token: 0x0600EFE4 RID: 61412 RVA: 0x002313A8 File Offset: 0x0022F5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerResultNotify Clone()
		{
			return new MowTowerResultNotify(this);
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600EFE5 RID: 61413 RVA: 0x002313B0 File Offset: 0x0022F5B0
		// (set) Token: 0x0600EFE6 RID: 61414 RVA: 0x002313B8 File Offset: 0x0022F5B8
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

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600EFE7 RID: 61415 RVA: 0x002313C1 File Offset: 0x0022F5C1
		// (set) Token: 0x0600EFE8 RID: 61416 RVA: 0x002313C9 File Offset: 0x0022F5C9
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

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600EFE9 RID: 61417 RVA: 0x002313D2 File Offset: 0x0022F5D2
		// (set) Token: 0x0600EFEA RID: 61418 RVA: 0x002313DA File Offset: 0x0022F5DA
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

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600EFEB RID: 61419 RVA: 0x002313E3 File Offset: 0x0022F5E3
		// (set) Token: 0x0600EFEC RID: 61420 RVA: 0x002313EB File Offset: 0x0022F5EB
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

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600EFED RID: 61421 RVA: 0x002313F4 File Offset: 0x0022F5F4
		// (set) Token: 0x0600EFEE RID: 61422 RVA: 0x002313FC File Offset: 0x0022F5FC
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

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600EFEF RID: 61423 RVA: 0x00231405 File Offset: 0x0022F605
		// (set) Token: 0x0600EFF0 RID: 61424 RVA: 0x0023140D File Offset: 0x0022F60D
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

		// Token: 0x0600EFF1 RID: 61425 RVA: 0x00231416 File Offset: 0x0022F616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerResultNotify);
		}

		// Token: 0x0600EFF2 RID: 61426 RVA: 0x00231424 File Offset: 0x0022F624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKilMonsterScore == other.FirstKilMonsterScore && this.FirstTimerScore == other.FirstTimerScore && this.SecondKilMonsterScore == other.SecondKilMonsterScore && this.SecondTimerScore == other.SecondTimerScore && this.HighScore == other.HighScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EFF3 RID: 61427 RVA: 0x002314B0 File Offset: 0x0022F6B0
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

		// Token: 0x0600EFF4 RID: 61428 RVA: 0x0023156C File Offset: 0x0022F76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EFF5 RID: 61429 RVA: 0x00231579 File Offset: 0x0022F779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EFF6 RID: 61430 RVA: 0x00231584 File Offset: 0x0022F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelsId);
			}
			if (this.FirstTimerScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FirstTimerScore);
			}
			if (this.HighScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HighScore);
			}
			if (this.SecondTimerScore != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SecondTimerScore);
			}
			if (this.SecondKilMonsterScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SecondKilMonsterScore);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.FirstKilMonsterScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EFF7 RID: 61431 RVA: 0x00231650 File Offset: 0x0022F850
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

		// Token: 0x0600EFF8 RID: 61432 RVA: 0x00231708 File Offset: 0x0022F908
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

		// Token: 0x0600EFF9 RID: 61433 RVA: 0x002317A8 File Offset: 0x0022F9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EFFA RID: 61434 RVA: 0x002317B4 File Offset: 0x0022F9B4
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
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.LevelsId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.FirstTimerScore = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.HighScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.SecondTimerScore = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SecondKilMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.FirstKilMonsterScore = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400616E RID: 24942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400616F RID: 24943
		public const int LevelsIdFieldNumber = 2;

		// Token: 0x04006170 RID: 24944
		private int levelsId_;

		// Token: 0x04006171 RID: 24945
		public const int FirstKilMonsterScoreFieldNumber = 15;

		// Token: 0x04006172 RID: 24946
		private int firstKilMonsterScore_;

		// Token: 0x04006173 RID: 24947
		public const int FirstTimerScoreFieldNumber = 3;

		// Token: 0x04006174 RID: 24948
		private int firstTimerScore_;

		// Token: 0x04006175 RID: 24949
		public const int SecondKilMonsterScoreFieldNumber = 14;

		// Token: 0x04006176 RID: 24950
		private int secondKilMonsterScore_;

		// Token: 0x04006177 RID: 24951
		public const int SecondTimerScoreFieldNumber = 11;

		// Token: 0x04006178 RID: 24952
		private int secondTimerScore_;

		// Token: 0x04006179 RID: 24953
		public const int HighScoreFieldNumber = 9;

		// Token: 0x0400617A RID: 24954
		private int highScore_;
	}
}
