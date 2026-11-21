using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001428 RID: 5160
	public sealed class TowerDifficultyPb : IMessage<TowerDifficultyPb>, IMessage, IEquatable<TowerDifficultyPb>, IDeepCloneable<TowerDifficultyPb>, IBufferMessage
	{
		// Token: 0x0601B6C7 RID: 112327 RVA: 0x003FCB9D File Offset: 0x003FAD9D
		[NullableContext(1)]
		public static TowerDifficultyPb Create()
		{
			return new TowerDifficultyPb();
		}

		// Token: 0x17005CD7 RID: 23767
		// (get) Token: 0x0601B6C8 RID: 112328 RVA: 0x003FCBA4 File Offset: 0x003FADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDifficultyPb> Parser
		{
			get
			{
				return TowerDifficultyPb._parser;
			}
		}

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x0601B6C9 RID: 112329 RVA: 0x003FCBAB File Offset: 0x003FADAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x0601B6CA RID: 112330 RVA: 0x003FCBAE File Offset: 0x003FADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDifficultyPb.Descriptor;
			}
		}

		// Token: 0x0601B6CB RID: 112331 RVA: 0x003FCBB5 File Offset: 0x003FADB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyPb()
		{
		}

		// Token: 0x0601B6CC RID: 112332 RVA: 0x003FCBD4 File Offset: 0x003FADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyPb(TowerDifficultyPb other) : this()
		{
			this.difficulty_ = other.difficulty_;
			this.rewardIndex_ = other.rewardIndex_.Clone();
			this.towerAreas_ = other.towerAreas_.Clone();
			this.maxStar_ = other.maxStar_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6CD RID: 112333 RVA: 0x003FCC32 File Offset: 0x003FAE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyPb Clone()
		{
			return new TowerDifficultyPb(this);
		}

		// Token: 0x17005CDA RID: 23770
		// (get) Token: 0x0601B6CE RID: 112334 RVA: 0x003FCC3A File Offset: 0x003FAE3A
		// (set) Token: 0x0601B6CF RID: 112335 RVA: 0x003FCC42 File Offset: 0x003FAE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Difficulty
		{
			get
			{
				return this.difficulty_;
			}
			set
			{
				this.difficulty_ = value;
			}
		}

		// Token: 0x17005CDB RID: 23771
		// (get) Token: 0x0601B6D0 RID: 112336 RVA: 0x003FCC4B File Offset: 0x003FAE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
		}

		// Token: 0x17005CDC RID: 23772
		// (get) Token: 0x0601B6D1 RID: 112337 RVA: 0x003FCC53 File Offset: 0x003FAE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerAreaPb> TowerAreas
		{
			get
			{
				return this.towerAreas_;
			}
		}

		// Token: 0x17005CDD RID: 23773
		// (get) Token: 0x0601B6D2 RID: 112338 RVA: 0x003FCC5B File Offset: 0x003FAE5B
		// (set) Token: 0x0601B6D3 RID: 112339 RVA: 0x003FCC63 File Offset: 0x003FAE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxStar
		{
			get
			{
				return this.maxStar_;
			}
			set
			{
				this.maxStar_ = value;
			}
		}

		// Token: 0x0601B6D4 RID: 112340 RVA: 0x003FCC6C File Offset: 0x003FAE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDifficultyPb);
		}

		// Token: 0x0601B6D5 RID: 112341 RVA: 0x003FCC7C File Offset: 0x003FAE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDifficultyPb other)
		{
			return other != null && (other == this || (this.Difficulty == other.Difficulty && this.rewardIndex_.Equals(other.rewardIndex_) && this.towerAreas_.Equals(other.towerAreas_) && this.MaxStar == other.MaxStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6D6 RID: 112342 RVA: 0x003FCCF0 File Offset: 0x003FAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Difficulty != 0)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			num ^= this.rewardIndex_.GetHashCode();
			num ^= this.towerAreas_.GetHashCode();
			if (this.MaxStar != 0)
			{
				num ^= this.MaxStar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B6D7 RID: 112343 RVA: 0x003FCD64 File Offset: 0x003FAF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6D8 RID: 112344 RVA: 0x003FCD71 File Offset: 0x003FAF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6D9 RID: 112345 RVA: 0x003FCD7C File Offset: 0x003FAF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Difficulty != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Difficulty);
			}
			this.rewardIndex_.WriteTo(ref output, TowerDifficultyPb._repeated_rewardIndex_codec);
			this.towerAreas_.WriteTo(ref output, TowerDifficultyPb._repeated_towerAreas_codec);
			if (this.MaxStar != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MaxStar);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6DA RID: 112346 RVA: 0x003FCDF8 File Offset: 0x003FAFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Difficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Difficulty);
			}
			num += this.rewardIndex_.CalculateSize(TowerDifficultyPb._repeated_rewardIndex_codec);
			num += this.towerAreas_.CalculateSize(TowerDifficultyPb._repeated_towerAreas_codec);
			if (this.MaxStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxStar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6DB RID: 112347 RVA: 0x003FCE74 File Offset: 0x003FB074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDifficultyPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Difficulty != 0)
			{
				this.Difficulty = other.Difficulty;
			}
			this.rewardIndex_.Add(other.rewardIndex_);
			this.towerAreas_.Add(other.towerAreas_);
			if (other.MaxStar != 0)
			{
				this.MaxStar = other.MaxStar;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6DC RID: 112348 RVA: 0x003FCEE6 File Offset: 0x003FB0E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6DD RID: 112349 RVA: 0x003FCEF0 File Offset: 0x003FB0F0
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
						this.Difficulty = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 26U)
					{
						this.towerAreas_.AddEntriesFrom(ref input, TowerDifficultyPb._repeated_towerAreas_codec);
						continue;
					}
					if (num == 32U)
					{
						this.MaxStar = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.rewardIndex_.AddEntriesFrom(ref input, TowerDifficultyPb._repeated_rewardIndex_codec);
			}
		}

		// Token: 0x04009FA9 RID: 40873
		private static readonly MessageParser<TowerDifficultyPb> _parser = new MessageParser<TowerDifficultyPb>(() => new TowerDifficultyPb());

		// Token: 0x04009FAA RID: 40874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FAB RID: 40875
		public const int DifficultyFieldNumber = 1;

		// Token: 0x04009FAC RID: 40876
		private int difficulty_;

		// Token: 0x04009FAD RID: 40877
		public const int RewardIndexFieldNumber = 2;

		// Token: 0x04009FAE RID: 40878
		private static readonly FieldCodec<int> _repeated_rewardIndex_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009FAF RID: 40879
		private readonly RepeatedField<int> rewardIndex_ = new RepeatedField<int>();

		// Token: 0x04009FB0 RID: 40880
		public const int TowerAreasFieldNumber = 3;

		// Token: 0x04009FB1 RID: 40881
		private static readonly FieldCodec<TowerAreaPb> _repeated_towerAreas_codec = FieldCodec.ForMessage<TowerAreaPb>(26U, TowerAreaPb.Parser);

		// Token: 0x04009FB2 RID: 40882
		private readonly RepeatedField<TowerAreaPb> towerAreas_ = new RepeatedField<TowerAreaPb>();

		// Token: 0x04009FB3 RID: 40883
		public const int MaxStarFieldNumber = 4;

		// Token: 0x04009FB4 RID: 40884
		private int maxStar_;
	}
}
