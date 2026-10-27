using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B5 RID: 5045
	public sealed class TowerDifficultyPb : IMessage<TowerDifficultyPb>, IMessage, IEquatable<TowerDifficultyPb>, IDeepCloneable<TowerDifficultyPb>, IBufferMessage
	{
		// Token: 0x0601AC3C RID: 109628 RVA: 0x003E18DD File Offset: 0x003DFADD
		[NullableContext(1)]
		public static TowerDifficultyPb Create()
		{
			return new TowerDifficultyPb();
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x0601AC3D RID: 109629 RVA: 0x003E18E4 File Offset: 0x003DFAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerDifficultyPb> Parser
		{
			get
			{
				return TowerDifficultyPb._parser;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x0601AC3E RID: 109630 RVA: 0x003E18EB File Offset: 0x003DFAEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x0601AC3F RID: 109631 RVA: 0x003E18EE File Offset: 0x003DFAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDifficultyPb.Descriptor;
			}
		}

		// Token: 0x0601AC40 RID: 109632 RVA: 0x003E18F5 File Offset: 0x003DFAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyPb()
		{
		}

		// Token: 0x0601AC41 RID: 109633 RVA: 0x003E1914 File Offset: 0x003DFB14
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

		// Token: 0x0601AC42 RID: 109634 RVA: 0x003E1972 File Offset: 0x003DFB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDifficultyPb Clone()
		{
			return new TowerDifficultyPb(this);
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x0601AC43 RID: 109635 RVA: 0x003E197A File Offset: 0x003DFB7A
		// (set) Token: 0x0601AC44 RID: 109636 RVA: 0x003E1982 File Offset: 0x003DFB82
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

		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x0601AC45 RID: 109637 RVA: 0x003E198B File Offset: 0x003DFB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
		}

		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x0601AC46 RID: 109638 RVA: 0x003E1993 File Offset: 0x003DFB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerAreaPb> TowerAreas
		{
			get
			{
				return this.towerAreas_;
			}
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x0601AC47 RID: 109639 RVA: 0x003E199B File Offset: 0x003DFB9B
		// (set) Token: 0x0601AC48 RID: 109640 RVA: 0x003E19A3 File Offset: 0x003DFBA3
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

		// Token: 0x0601AC49 RID: 109641 RVA: 0x003E19AC File Offset: 0x003DFBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDifficultyPb);
		}

		// Token: 0x0601AC4A RID: 109642 RVA: 0x003E19BC File Offset: 0x003DFBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDifficultyPb other)
		{
			return other != null && (other == this || (this.Difficulty == other.Difficulty && this.rewardIndex_.Equals(other.rewardIndex_) && this.towerAreas_.Equals(other.towerAreas_) && this.MaxStar == other.MaxStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC4B RID: 109643 RVA: 0x003E1A30 File Offset: 0x003DFC30
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

		// Token: 0x0601AC4C RID: 109644 RVA: 0x003E1AA4 File Offset: 0x003DFCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AC4D RID: 109645 RVA: 0x003E1AB1 File Offset: 0x003DFCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x003E1ABC File Offset: 0x003DFCBC
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

		// Token: 0x0601AC4F RID: 109647 RVA: 0x003E1B38 File Offset: 0x003DFD38
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

		// Token: 0x0601AC50 RID: 109648 RVA: 0x003E1BB4 File Offset: 0x003DFDB4
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

		// Token: 0x0601AC51 RID: 109649 RVA: 0x003E1C26 File Offset: 0x003DFE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC52 RID: 109650 RVA: 0x003E1C30 File Offset: 0x003DFE30
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

		// Token: 0x04009B62 RID: 39778
		private static readonly MessageParser<TowerDifficultyPb> _parser = new MessageParser<TowerDifficultyPb>(() => new TowerDifficultyPb());

		// Token: 0x04009B63 RID: 39779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B64 RID: 39780
		public const int DifficultyFieldNumber = 1;

		// Token: 0x04009B65 RID: 39781
		private int difficulty_;

		// Token: 0x04009B66 RID: 39782
		public const int RewardIndexFieldNumber = 2;

		// Token: 0x04009B67 RID: 39783
		private static readonly FieldCodec<int> _repeated_rewardIndex_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009B68 RID: 39784
		private readonly RepeatedField<int> rewardIndex_ = new RepeatedField<int>();

		// Token: 0x04009B69 RID: 39785
		public const int TowerAreasFieldNumber = 3;

		// Token: 0x04009B6A RID: 39786
		private static readonly FieldCodec<TowerAreaPb> _repeated_towerAreas_codec = FieldCodec.ForMessage<TowerAreaPb>(26U, TowerAreaPb.Parser);

		// Token: 0x04009B6B RID: 39787
		private readonly RepeatedField<TowerAreaPb> towerAreas_ = new RepeatedField<TowerAreaPb>();

		// Token: 0x04009B6C RID: 39788
		public const int MaxStarFieldNumber = 4;

		// Token: 0x04009B6D RID: 39789
		private int maxStar_;
	}
}
