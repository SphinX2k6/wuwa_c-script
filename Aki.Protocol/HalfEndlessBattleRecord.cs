using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000720 RID: 1824
	public sealed class HalfEndlessBattleRecord : IMessage<HalfEndlessBattleRecord>, IMessage, IEquatable<HalfEndlessBattleRecord>, IDeepCloneable<HalfEndlessBattleRecord>, IBufferMessage
	{
		// Token: 0x0600A5E2 RID: 42466 RVA: 0x0018FEAC File Offset: 0x0018E0AC
		[NullableContext(1)]
		public static HalfEndlessBattleRecord Create()
		{
			return new HalfEndlessBattleRecord();
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x0018FEB3 File Offset: 0x0018E0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x0018FEB6 File Offset: 0x0018E0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HalfEndlessBattleRecord.Descriptor;
			}
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x0018FEBD File Offset: 0x0018E0BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord()
		{
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x0018FED0 File Offset: 0x0018E0D0
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

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x0018FF39 File Offset: 0x0018E139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HalfEndlessBattleRecord Clone()
		{
			return new HalfEndlessBattleRecord(this);
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x0018FF41 File Offset: 0x0018E141
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x0018FF49 File Offset: 0x0018E149
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

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x0018FF52 File Offset: 0x0018E152
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x0018FF5A File Offset: 0x0018E15A
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

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x0018FF63 File Offset: 0x0018E163
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x0018FF6B File Offset: 0x0018E16B
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

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x0018FF74 File Offset: 0x0018E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleLevels
		{
			get
			{
				return this.roleLevels_;
			}
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x0018FF7C File Offset: 0x0018E17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HalfEndlessBattleRecord);
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x0018FF8C File Offset: 0x0018E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HalfEndlessBattleRecord other)
		{
			return other != null && (other == this || (object.Equals(this.BattleFormation, other.BattleFormation) && this.MaxScore == other.MaxScore && this.MaxRound == other.MaxRound && this.roleLevels_.Equals(other.roleLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x00190000 File Offset: 0x0018E200
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

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x0019007C File Offset: 0x0018E27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x00190089 File Offset: 0x0018E289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x00190094 File Offset: 0x0018E294
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

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x0019011C File Offset: 0x0018E31C
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

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x001901A0 File Offset: 0x0018E3A0
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

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x0019022D File Offset: 0x0018E42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x00190238 File Offset: 0x0018E438
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

		// Token: 0x04004C75 RID: 19573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C76 RID: 19574
		public const int BattleFormationFieldNumber = 1;

		// Token: 0x04004C77 RID: 19575
		private BattleFormation battleFormation_;

		// Token: 0x04004C78 RID: 19576
		public const int MaxScoreFieldNumber = 2;

		// Token: 0x04004C79 RID: 19577
		private int maxScore_;

		// Token: 0x04004C7A RID: 19578
		public const int MaxRoundFieldNumber = 3;

		// Token: 0x04004C7B RID: 19579
		private int maxRound_;

		// Token: 0x04004C7C RID: 19580
		public const int RoleLevelsFieldNumber = 4;

		// Token: 0x04004C7D RID: 19581
		private static readonly FieldCodec<int> _repeated_roleLevels_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04004C7E RID: 19582
		private readonly RepeatedField<int> roleLevels_ = new RepeatedField<int>();
	}
}
