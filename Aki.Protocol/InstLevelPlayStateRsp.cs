using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000827 RID: 2087
	public sealed class InstLevelPlayStateRsp : IMessage<InstLevelPlayStateRsp>, IMessage, IEquatable<InstLevelPlayStateRsp>, IDeepCloneable<InstLevelPlayStateRsp>, IBufferMessage
	{
		// Token: 0x0600BA7D RID: 47741 RVA: 0x001BBE95 File Offset: 0x001BA095
		[NullableContext(1)]
		public static InstLevelPlayStateRsp Create()
		{
			return new InstLevelPlayStateRsp();
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x001BBE9C File Offset: 0x001BA09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstLevelPlayStateRsp> Parser
		{
			get
			{
				return InstLevelPlayStateRsp._parser;
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600BA7F RID: 47743 RVA: 0x001BBEA3 File Offset: 0x001BA0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x001BBEA6 File Offset: 0x001BA0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstLevelPlayStateRsp.Descriptor;
			}
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x001BBEB0 File Offset: 0x001BA0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateRsp()
		{
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x001BBF08 File Offset: 0x001BA108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateRsp(InstLevelPlayStateRsp other) : this()
		{
			this.instId_ = other.instId_;
			this.levelPlayStateDict_ = other.levelPlayStateDict_.Clone();
			this.completeNumberDict_ = other.completeNumberDict_.Clone();
			this.hideDict_ = other.hideDict_.Clone();
			this.hideGroupInfoDict_ = other.hideGroupInfoDict_.Clone();
			this.isUnlockDict_ = other.isUnlockDict_.Clone();
			this.gainRewardInfoDict_ = other.gainRewardInfoDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x001BBF9E File Offset: 0x001BA19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateRsp Clone()
		{
			return new InstLevelPlayStateRsp(this);
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600BA84 RID: 47748 RVA: 0x001BBFA6 File Offset: 0x001BA1A6
		// (set) Token: 0x0600BA85 RID: 47749 RVA: 0x001BBFAE File Offset: 0x001BA1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x001BBFB7 File Offset: 0x001BA1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LevelPlayStateDict
		{
			get
			{
				return this.levelPlayStateDict_;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600BA87 RID: 47751 RVA: 0x001BBFBF File Offset: 0x001BA1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CompleteNumberDict
		{
			get
			{
				return this.completeNumberDict_;
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x001BBFC7 File Offset: 0x001BA1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> HideDict
		{
			get
			{
				return this.hideDict_;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x001BBFCF File Offset: 0x001BA1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> HideGroupInfoDict
		{
			get
			{
				return this.hideGroupInfoDict_;
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x001BBFD7 File Offset: 0x001BA1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> IsUnlockDict
		{
			get
			{
				return this.isUnlockDict_;
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x001BBFDF File Offset: 0x001BA1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayGainRewardInfo> GainRewardInfoDict
		{
			get
			{
				return this.gainRewardInfoDict_;
			}
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x001BBFE7 File Offset: 0x001BA1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstLevelPlayStateRsp);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x001BBFF8 File Offset: 0x001BA1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstLevelPlayStateRsp other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayStateDict.Equals(other.LevelPlayStateDict) && this.CompleteNumberDict.Equals(other.CompleteNumberDict) && this.HideDict.Equals(other.HideDict) && this.HideGroupInfoDict.Equals(other.HideGroupInfoDict) && this.IsUnlockDict.Equals(other.IsUnlockDict) && this.GainRewardInfoDict.Equals(other.GainRewardInfoDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x001BC0B0 File Offset: 0x001BA2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.LevelPlayStateDict.GetHashCode();
			num ^= this.CompleteNumberDict.GetHashCode();
			num ^= this.HideDict.GetHashCode();
			num ^= this.HideGroupInfoDict.GetHashCode();
			num ^= this.IsUnlockDict.GetHashCode();
			num ^= this.GainRewardInfoDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x001BC143 File Offset: 0x001BA343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x001BC150 File Offset: 0x001BA350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x001BC15C File Offset: 0x001BA35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.levelPlayStateDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_levelPlayStateDict_codec);
			this.completeNumberDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_completeNumberDict_codec);
			this.hideDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_hideDict_codec);
			this.hideGroupInfoDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_hideGroupInfoDict_codec);
			this.isUnlockDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_isUnlockDict_codec);
			this.gainRewardInfoDict_.WriteTo(ref output, InstLevelPlayStateRsp._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x001BC200 File Offset: 0x001BA400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.levelPlayStateDict_.CalculateSize(InstLevelPlayStateRsp._map_levelPlayStateDict_codec);
			num += this.completeNumberDict_.CalculateSize(InstLevelPlayStateRsp._map_completeNumberDict_codec);
			num += this.hideDict_.CalculateSize(InstLevelPlayStateRsp._map_hideDict_codec);
			num += this.hideGroupInfoDict_.CalculateSize(InstLevelPlayStateRsp._map_hideGroupInfoDict_codec);
			num += this.isUnlockDict_.CalculateSize(InstLevelPlayStateRsp._map_isUnlockDict_codec);
			num += this.gainRewardInfoDict_.CalculateSize(InstLevelPlayStateRsp._map_gainRewardInfoDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x001BC2B0 File Offset: 0x001BA4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstLevelPlayStateRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.levelPlayStateDict_.MergeFrom(other.levelPlayStateDict_);
			this.completeNumberDict_.MergeFrom(other.completeNumberDict_);
			this.hideDict_.MergeFrom(other.hideDict_);
			this.hideGroupInfoDict_.MergeFrom(other.hideGroupInfoDict_);
			this.isUnlockDict_.MergeFrom(other.isUnlockDict_);
			this.gainRewardInfoDict_.MergeFrom(other.gainRewardInfoDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x001BC352 File Offset: 0x001BA552
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x001BC35C File Offset: 0x001BA55C
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.levelPlayStateDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_levelPlayStateDict_codec);
						continue;
					}
					if (num == 26U)
					{
						this.completeNumberDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_completeNumberDict_codec);
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						this.hideDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_hideDict_codec);
						continue;
					}
					if (num == 42U)
					{
						this.hideGroupInfoDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_hideGroupInfoDict_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.isUnlockDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_isUnlockDict_codec);
						continue;
					}
					if (num == 58U)
					{
						this.gainRewardInfoDict_.AddEntriesFrom(ref input, InstLevelPlayStateRsp._map_gainRewardInfoDict_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051DB RID: 20955
		private static readonly MessageParser<InstLevelPlayStateRsp> _parser = new MessageParser<InstLevelPlayStateRsp>(() => new InstLevelPlayStateRsp());

		// Token: 0x040051DC RID: 20956
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051DD RID: 20957
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051DE RID: 20958
		private int instId_;

		// Token: 0x040051DF RID: 20959
		public const int LevelPlayStateDictFieldNumber = 2;

		// Token: 0x040051E0 RID: 20960
		private static readonly MapField<int, int>.Codec _map_levelPlayStateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040051E1 RID: 20961
		private readonly MapField<int, int> levelPlayStateDict_ = new MapField<int, int>();

		// Token: 0x040051E2 RID: 20962
		public const int CompleteNumberDictFieldNumber = 3;

		// Token: 0x040051E3 RID: 20963
		private static readonly MapField<int, int>.Codec _map_completeNumberDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040051E4 RID: 20964
		private readonly MapField<int, int> completeNumberDict_ = new MapField<int, int>();

		// Token: 0x040051E5 RID: 20965
		public const int HideDictFieldNumber = 4;

		// Token: 0x040051E6 RID: 20966
		private static readonly MapField<int, bool>.Codec _map_hideDict_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 34U);

		// Token: 0x040051E7 RID: 20967
		private readonly MapField<int, bool> hideDict_ = new MapField<int, bool>();

		// Token: 0x040051E8 RID: 20968
		public const int HideGroupInfoDictFieldNumber = 5;

		// Token: 0x040051E9 RID: 20969
		private static readonly MapField<int, string>.Codec _map_hideGroupInfoDict_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 42U);

		// Token: 0x040051EA RID: 20970
		private readonly MapField<int, string> hideGroupInfoDict_ = new MapField<int, string>();

		// Token: 0x040051EB RID: 20971
		public const int IsUnlockDictFieldNumber = 6;

		// Token: 0x040051EC RID: 20972
		private static readonly MapField<int, bool>.Codec _map_isUnlockDict_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 50U);

		// Token: 0x040051ED RID: 20973
		private readonly MapField<int, bool> isUnlockDict_ = new MapField<int, bool>();

		// Token: 0x040051EE RID: 20974
		public const int GainRewardInfoDictFieldNumber = 7;

		// Token: 0x040051EF RID: 20975
		private static readonly MapField<int, LevelPlayGainRewardInfo>.Codec _map_gainRewardInfoDict_codec = new MapField<int, LevelPlayGainRewardInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayGainRewardInfo>(18U, LevelPlayGainRewardInfo.Parser), 58U);

		// Token: 0x040051F0 RID: 20976
		private readonly MapField<int, LevelPlayGainRewardInfo> gainRewardInfoDict_ = new MapField<int, LevelPlayGainRewardInfo>();
	}
}
