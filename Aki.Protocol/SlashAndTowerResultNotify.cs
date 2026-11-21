using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128D RID: 4749
	[NetMessage(EMessageId.SlashAndTowerResultNotify)]
	public sealed class SlashAndTowerResultNotify : IMessage<SlashAndTowerResultNotify>, IMessage, IEquatable<SlashAndTowerResultNotify>, IDeepCloneable<SlashAndTowerResultNotify>, IBufferMessage
	{
		// Token: 0x06019589 RID: 103817 RVA: 0x003B22FD File Offset: 0x003B04FD
		[NullableContext(1)]
		public static SlashAndTowerResultNotify Create()
		{
			return new SlashAndTowerResultNotify();
		}

		// Token: 0x170055B7 RID: 21943
		// (get) Token: 0x0601958A RID: 103818 RVA: 0x003B2304 File Offset: 0x003B0504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055B8 RID: 21944
		// (get) Token: 0x0601958B RID: 103819 RVA: 0x003B2307 File Offset: 0x003B0507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerResultNotify.Descriptor;
			}
		}

		// Token: 0x0601958C RID: 103820 RVA: 0x003B230E File Offset: 0x003B050E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify()
		{
		}

		// Token: 0x0601958D RID: 103821 RVA: 0x003B2318 File Offset: 0x003B0518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify(SlashAndTowerResultNotify other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.firstKillMonsterScore_ = other.firstKillMonsterScore_;
			this.firstRoundScore_ = other.firstRoundScore_;
			this.secondKillMonsterScore_ = other.secondKillMonsterScore_;
			this.secondRoundScore_ = other.secondRoundScore_;
			this.firstFormation_ = ((other.firstFormation_ != null) ? other.firstFormation_.Clone() : null);
			this.secondFormation_ = ((other.secondFormation_ != null) ? other.secondFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601958E RID: 103822 RVA: 0x003B23B0 File Offset: 0x003B05B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerResultNotify Clone()
		{
			return new SlashAndTowerResultNotify(this);
		}

		// Token: 0x170055B9 RID: 21945
		// (get) Token: 0x0601958F RID: 103823 RVA: 0x003B23B8 File Offset: 0x003B05B8
		// (set) Token: 0x06019590 RID: 103824 RVA: 0x003B23C0 File Offset: 0x003B05C0
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

		// Token: 0x170055BA RID: 21946
		// (get) Token: 0x06019591 RID: 103825 RVA: 0x003B23C9 File Offset: 0x003B05C9
		// (set) Token: 0x06019592 RID: 103826 RVA: 0x003B23D1 File Offset: 0x003B05D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstKillMonsterScore
		{
			get
			{
				return this.firstKillMonsterScore_;
			}
			set
			{
				this.firstKillMonsterScore_ = value;
			}
		}

		// Token: 0x170055BB RID: 21947
		// (get) Token: 0x06019593 RID: 103827 RVA: 0x003B23DA File Offset: 0x003B05DA
		// (set) Token: 0x06019594 RID: 103828 RVA: 0x003B23E2 File Offset: 0x003B05E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstRoundScore
		{
			get
			{
				return this.firstRoundScore_;
			}
			set
			{
				this.firstRoundScore_ = value;
			}
		}

		// Token: 0x170055BC RID: 21948
		// (get) Token: 0x06019595 RID: 103829 RVA: 0x003B23EB File Offset: 0x003B05EB
		// (set) Token: 0x06019596 RID: 103830 RVA: 0x003B23F3 File Offset: 0x003B05F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondKillMonsterScore
		{
			get
			{
				return this.secondKillMonsterScore_;
			}
			set
			{
				this.secondKillMonsterScore_ = value;
			}
		}

		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x06019597 RID: 103831 RVA: 0x003B23FC File Offset: 0x003B05FC
		// (set) Token: 0x06019598 RID: 103832 RVA: 0x003B2404 File Offset: 0x003B0604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecondRoundScore
		{
			get
			{
				return this.secondRoundScore_;
			}
			set
			{
				this.secondRoundScore_ = value;
			}
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x06019599 RID: 103833 RVA: 0x003B240D File Offset: 0x003B060D
		// (set) Token: 0x0601959A RID: 103834 RVA: 0x003B2415 File Offset: 0x003B0615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation FirstFormation
		{
			get
			{
				return this.firstFormation_;
			}
			set
			{
				this.firstFormation_ = value;
			}
		}

		// Token: 0x170055BF RID: 21951
		// (get) Token: 0x0601959B RID: 103835 RVA: 0x003B241E File Offset: 0x003B061E
		// (set) Token: 0x0601959C RID: 103836 RVA: 0x003B2426 File Offset: 0x003B0626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation SecondFormation
		{
			get
			{
				return this.secondFormation_;
			}
			set
			{
				this.secondFormation_ = value;
			}
		}

		// Token: 0x0601959D RID: 103837 RVA: 0x003B242F File Offset: 0x003B062F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerResultNotify);
		}

		// Token: 0x0601959E RID: 103838 RVA: 0x003B2440 File Offset: 0x003B0640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerResultNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKillMonsterScore == other.FirstKillMonsterScore && this.FirstRoundScore == other.FirstRoundScore && this.SecondKillMonsterScore == other.SecondKillMonsterScore && this.SecondRoundScore == other.SecondRoundScore && object.Equals(this.FirstFormation, other.FirstFormation) && object.Equals(this.SecondFormation, other.SecondFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601959F RID: 103839 RVA: 0x003B24E4 File Offset: 0x003B06E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.FirstKillMonsterScore != 0)
			{
				num ^= this.FirstKillMonsterScore.GetHashCode();
			}
			if (this.FirstRoundScore != 0)
			{
				num ^= this.FirstRoundScore.GetHashCode();
			}
			if (this.SecondKillMonsterScore != 0)
			{
				num ^= this.SecondKillMonsterScore.GetHashCode();
			}
			if (this.SecondRoundScore != 0)
			{
				num ^= this.SecondRoundScore.GetHashCode();
			}
			if (this.firstFormation_ != null)
			{
				num ^= this.FirstFormation.GetHashCode();
			}
			if (this.secondFormation_ != null)
			{
				num ^= this.SecondFormation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060195A0 RID: 103840 RVA: 0x003B25B3 File Offset: 0x003B07B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060195A1 RID: 103841 RVA: 0x003B25C0 File Offset: 0x003B07C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060195A2 RID: 103842 RVA: 0x003B25CC File Offset: 0x003B07CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SecondKillMonsterScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SecondKillMonsterScore);
			}
			if (this.FirstRoundScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FirstRoundScore);
			}
			if (this.secondFormation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SecondFormation);
			}
			if (this.SecondRoundScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SecondRoundScore);
			}
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.LevelsId);
			}
			if (this.FirstKillMonsterScore != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.FirstKillMonsterScore);
			}
			if (this.firstFormation_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FirstFormation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060195A3 RID: 103843 RVA: 0x003B26B4 File Offset: 0x003B08B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.FirstKillMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstKillMonsterScore);
			}
			if (this.FirstRoundScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstRoundScore);
			}
			if (this.SecondKillMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondKillMonsterScore);
			}
			if (this.SecondRoundScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecondRoundScore);
			}
			if (this.firstFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FirstFormation);
			}
			if (this.secondFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SecondFormation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060195A4 RID: 103844 RVA: 0x003B2784 File Offset: 0x003B0984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.FirstKillMonsterScore != 0)
			{
				this.FirstKillMonsterScore = other.FirstKillMonsterScore;
			}
			if (other.FirstRoundScore != 0)
			{
				this.FirstRoundScore = other.FirstRoundScore;
			}
			if (other.SecondKillMonsterScore != 0)
			{
				this.SecondKillMonsterScore = other.SecondKillMonsterScore;
			}
			if (other.SecondRoundScore != 0)
			{
				this.SecondRoundScore = other.SecondRoundScore;
			}
			if (other.firstFormation_ != null)
			{
				if (this.firstFormation_ == null)
				{
					this.FirstFormation = new BattleFormation();
				}
				this.FirstFormation.MergeFrom(other.FirstFormation);
			}
			if (other.secondFormation_ != null)
			{
				if (this.secondFormation_ == null)
				{
					this.SecondFormation = new BattleFormation();
				}
				this.SecondFormation.MergeFrom(other.SecondFormation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060195A5 RID: 103845 RVA: 0x003B2868 File Offset: 0x003B0A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060195A6 RID: 103846 RVA: 0x003B2874 File Offset: 0x003B0A74
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.SecondKillMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.FirstRoundScore = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						if (this.secondFormation_ == null)
						{
							this.SecondFormation = new BattleFormation();
						}
						input.ReadMessage(this.SecondFormation);
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.SecondRoundScore = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.LevelsId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.FirstKillMonsterScore = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.firstFormation_ == null)
						{
							this.FirstFormation = new BattleFormation();
						}
						input.ReadMessage(this.FirstFormation);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040095E6 RID: 38374
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095E7 RID: 38375
		public const int LevelsIdFieldNumber = 8;

		// Token: 0x040095E8 RID: 38376
		private int levelsId_;

		// Token: 0x040095E9 RID: 38377
		public const int FirstKillMonsterScoreFieldNumber = 14;

		// Token: 0x040095EA RID: 38378
		private int firstKillMonsterScore_;

		// Token: 0x040095EB RID: 38379
		public const int FirstRoundScoreFieldNumber = 4;

		// Token: 0x040095EC RID: 38380
		private int firstRoundScore_;

		// Token: 0x040095ED RID: 38381
		public const int SecondKillMonsterScoreFieldNumber = 2;

		// Token: 0x040095EE RID: 38382
		private int secondKillMonsterScore_;

		// Token: 0x040095EF RID: 38383
		public const int SecondRoundScoreFieldNumber = 7;

		// Token: 0x040095F0 RID: 38384
		private int secondRoundScore_;

		// Token: 0x040095F1 RID: 38385
		public const int FirstFormationFieldNumber = 15;

		// Token: 0x040095F2 RID: 38386
		private BattleFormation firstFormation_;

		// Token: 0x040095F3 RID: 38387
		public const int SecondFormationFieldNumber = 6;

		// Token: 0x040095F4 RID: 38388
		private BattleFormation secondFormation_;
	}
}
