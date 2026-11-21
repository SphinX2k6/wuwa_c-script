using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001DD RID: 477
	[NetMessage(EMessageId.BossRushLevelInfoNotify)]
	public sealed class BossRushLevelInfoNotify : IMessage<BossRushLevelInfoNotify>, IMessage, IEquatable<BossRushLevelInfoNotify>, IDeepCloneable<BossRushLevelInfoNotify>, IBufferMessage
	{
		// Token: 0x0600361A RID: 13850 RVA: 0x000882DC File Offset: 0x000864DC
		[NullableContext(1)]
		public static BossRushLevelInfoNotify Create()
		{
			return new BossRushLevelInfoNotify();
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x000882E3 File Offset: 0x000864E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x000882E6 File Offset: 0x000864E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushLevelInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x000882ED File Offset: 0x000864ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify()
		{
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00088318 File Offset: 0x00086518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify(BossRushLevelInfoNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.bossRushLevelInfo_ = other.bossRushLevelInfo_.Clone();
			this.bossRushScoreScoreRewardInfo_ = other.bossRushScoreScoreRewardInfo_.Clone();
			this.unlockedBuffIndices_ = other.unlockedBuffIndices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0008837B File Offset: 0x0008657B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushLevelInfoNotify Clone()
		{
			return new BossRushLevelInfoNotify(this);
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x00088383 File Offset: 0x00086583
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x0008838B File Offset: 0x0008658B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x00088394 File Offset: 0x00086594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushLevelData> BossRushLevelInfo
		{
			get
			{
				return this.bossRushLevelInfo_;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x0008839C File Offset: 0x0008659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BossRushScoreRewardData> BossRushScoreScoreRewardInfo
		{
			get
			{
				return this.bossRushScoreScoreRewardInfo_;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x000883A4 File Offset: 0x000865A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedBuffIndices
		{
			get
			{
				return this.unlockedBuffIndices_;
			}
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x000883AC File Offset: 0x000865AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushLevelInfoNotify);
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x000883BC File Offset: 0x000865BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushLevelInfoNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.bossRushLevelInfo_.Equals(other.bossRushLevelInfo_) && this.bossRushScoreScoreRewardInfo_.Equals(other.bossRushScoreScoreRewardInfo_) && this.unlockedBuffIndices_.Equals(other.unlockedBuffIndices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00088434 File Offset: 0x00086634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.bossRushLevelInfo_.GetHashCode();
			num ^= this.bossRushScoreScoreRewardInfo_.GetHashCode();
			num ^= this.unlockedBuffIndices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0008849D File Offset: 0x0008669D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x000884AA File Offset: 0x000866AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x000884B4 File Offset: 0x000866B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bossRushScoreScoreRewardInfo_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			this.bossRushLevelInfo_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
			this.unlockedBuffIndices_.WriteTo(ref output, BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00088524 File Offset: 0x00086724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.bossRushLevelInfo_.CalculateSize(BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
			num += this.bossRushScoreScoreRewardInfo_.CalculateSize(BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
			num += this.unlockedBuffIndices_.CalculateSize(BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0008859C File Offset: 0x0008679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushLevelInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.bossRushLevelInfo_.Add(other.bossRushLevelInfo_);
			this.bossRushScoreScoreRewardInfo_.Add(other.bossRushScoreScoreRewardInfo_);
			this.unlockedBuffIndices_.Add(other.unlockedBuffIndices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0008860B File Offset: 0x0008680B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00088614 File Offset: 0x00086814
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
				if (num <= 64U)
				{
					if (num == 34U)
					{
						this.bossRushScoreScoreRewardInfo_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_bossRushScoreScoreRewardInfo_codec);
						continue;
					}
					if (num == 64U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.bossRushLevelInfo_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_bossRushLevelInfo_codec);
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.unlockedBuffIndices_.AddEntriesFrom(ref input, BossRushLevelInfoNotify._repeated_unlockedBuffIndices_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ADB RID: 10971
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ADC RID: 10972
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04002ADD RID: 10973
		private int activityId_;

		// Token: 0x04002ADE RID: 10974
		public const int BossRushLevelInfoFieldNumber = 9;

		// Token: 0x04002ADF RID: 10975
		private static readonly FieldCodec<BossRushLevelData> _repeated_bossRushLevelInfo_codec = FieldCodec.ForMessage<BossRushLevelData>(74U, BossRushLevelData.Parser);

		// Token: 0x04002AE0 RID: 10976
		private readonly RepeatedField<BossRushLevelData> bossRushLevelInfo_ = new RepeatedField<BossRushLevelData>();

		// Token: 0x04002AE1 RID: 10977
		public const int BossRushScoreScoreRewardInfoFieldNumber = 4;

		// Token: 0x04002AE2 RID: 10978
		private static readonly FieldCodec<BossRushScoreRewardData> _repeated_bossRushScoreScoreRewardInfo_codec = FieldCodec.ForMessage<BossRushScoreRewardData>(34U, BossRushScoreRewardData.Parser);

		// Token: 0x04002AE3 RID: 10979
		private readonly RepeatedField<BossRushScoreRewardData> bossRushScoreScoreRewardInfo_ = new RepeatedField<BossRushScoreRewardData>();

		// Token: 0x04002AE4 RID: 10980
		public const int UnlockedBuffIndicesFieldNumber = 14;

		// Token: 0x04002AE5 RID: 10981
		private static readonly FieldCodec<int> _repeated_unlockedBuffIndices_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04002AE6 RID: 10982
		private readonly RepeatedField<int> unlockedBuffIndices_ = new RepeatedField<int>();
	}
}
