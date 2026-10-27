using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000734 RID: 1844
	public sealed class HalfEndlessBattleRecord : IMessage<HalfEndlessBattleRecord>, IMessage, IEquatable<HalfEndlessBattleRecord>, IDeepCloneable<HalfEndlessBattleRecord>, IBufferMessage
	{
		// Token: 0x0600A738 RID: 42808 RVA: 0x001928E0 File Offset: 0x00190AE0
		[NullableContext(1)]
		public static HalfEndlessBattleRecord Create()
		{
			return new HalfEndlessBattleRecord();
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x0600A739 RID: 42809 RVA: 0x001928E7 File Offset: 0x00190AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x0600A73A RID: 42810 RVA: 0x001928EA File Offset: 0x00190AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HalfEndlessBattleRecord.Descriptor;
			}
		}

		// Token: 0x0600A73B RID: 42811 RVA: 0x001928F1 File Offset: 0x00190AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord()
		{
		}

		// Token: 0x0600A73C RID: 42812 RVA: 0x00192904 File Offset: 0x00190B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord(HalfEndlessBattleRecord other) : this()
		{
			this.battleFormation_ = ((other.battleFormation_ != null) ? other.battleFormation_.Clone() : null);
			this.maxScore_ = other.maxScore_;
			this.maxRound_ = other.maxRound_;
			this.roleLevels_ = other.roleLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A73D RID: 42813 RVA: 0x0019296D File Offset: 0x00190B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord Clone()
		{
			return new HalfEndlessBattleRecord(this);
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x00192975 File Offset: 0x00190B75
		// (set) Token: 0x0600A73F RID: 42815 RVA: 0x0019297D File Offset: 0x00190B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleFormation BattleFormation
		{
			get
			{
				return this.battleFormation_;
			}
			set
			{
				this.battleFormation_ = value;
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x0600A740 RID: 42816 RVA: 0x00192986 File Offset: 0x00190B86
		// (set) Token: 0x0600A741 RID: 42817 RVA: 0x0019298E File Offset: 0x00190B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x00192997 File Offset: 0x00190B97
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x0019299F File Offset: 0x00190B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxRound
		{
			get
			{
				return this.maxRound_;
			}
			set
			{
				this.maxRound_ = value;
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x001929A8 File Offset: 0x00190BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleLevels
		{
			get
			{
				return this.roleLevels_;
			}
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x001929B0 File Offset: 0x00190BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HalfEndlessBattleRecord);
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x001929C0 File Offset: 0x00190BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HalfEndlessBattleRecord other)
		{
			return other != null && (other == this || (object.Equals(this.BattleFormation, other.BattleFormation) && this.MaxScore == other.MaxScore && this.MaxRound == other.MaxRound && this.roleLevels_.Equals(other.roleLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x00192A34 File Offset: 0x00190C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleFormation_ != null)
			{
				num ^= this.BattleFormation.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.MaxRound != 0)
			{
				num ^= this.MaxRound.GetHashCode();
			}
			num ^= this.roleLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x00192AB0 File Offset: 0x00190CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x00192ABD File Offset: 0x00190CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x00192AC8 File Offset: 0x00190CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleFormation_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BattleFormation);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxScore);
			}
			if (this.MaxRound != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxRound);
			}
			this.roleLevels_.WriteTo(ref output, HalfEndlessBattleRecord._repeated_roleLevels_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x00192B50 File Offset: 0x00190D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleFormation);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this.MaxRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxRound);
			}
			num += this.roleLevels_.CalculateSize(HalfEndlessBattleRecord._repeated_roleLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x00192BD4 File Offset: 0x00190DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HalfEndlessBattleRecord other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleFormation_ != null)
			{
				if (this.battleFormation_ == null)
				{
					this.BattleFormation = new BattleFormation();
				}
				this.BattleFormation.MergeFrom(other.BattleFormation);
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.MaxRound != 0)
			{
				this.MaxRound = other.MaxRound;
			}
			this.roleLevels_.Add(other.roleLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x00192C61 File Offset: 0x00190E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x00192C6C File Offset: 0x00190E6C
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
					if (num == 10U)
					{
						if (this.battleFormation_ == null)
						{
							this.BattleFormation = new BattleFormation();
						}
						input.ReadMessage(this.BattleFormation);
						continue;
					}
					if (num == 16U)
					{
						this.MaxScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxRound = input.ReadInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.roleLevels_.AddEntriesFrom(ref input, HalfEndlessBattleRecord._repeated_roleLevels_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C7C RID: 19580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C7D RID: 19581
		public const int BattleFormationFieldNumber = 1;

		// Token: 0x04004C7E RID: 19582
		private BattleFormation battleFormation_;

		// Token: 0x04004C7F RID: 19583
		public const int MaxScoreFieldNumber = 2;

		// Token: 0x04004C80 RID: 19584
		private int maxScore_;

		// Token: 0x04004C81 RID: 19585
		public const int MaxRoundFieldNumber = 3;

		// Token: 0x04004C82 RID: 19586
		private int maxRound_;

		// Token: 0x04004C83 RID: 19587
		public const int RoleLevelsFieldNumber = 4;

		// Token: 0x04004C84 RID: 19588
		private static readonly FieldCodec<int> _repeated_roleLevels_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004C85 RID: 19589
		private readonly RepeatedField<int> roleLevels_ = new RepeatedField<int>();
	}
}
