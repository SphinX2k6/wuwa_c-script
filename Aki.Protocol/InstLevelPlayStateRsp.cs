using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000813 RID: 2067
	public sealed class InstLevelPlayStateRsp : IMessage<InstLevelPlayStateRsp>, IMessage, IEquatable<InstLevelPlayStateRsp>, IDeepCloneable<InstLevelPlayStateRsp>, IBufferMessage
	{
		// Token: 0x0600B927 RID: 47399 RVA: 0x001B9455 File Offset: 0x001B7655
		[NullableContext(1)]
		public static InstLevelPlayStateRsp Create()
		{
			return new InstLevelPlayStateRsp();
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x0600B928 RID: 47400 RVA: 0x001B945C File Offset: 0x001B765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstLevelPlayStateRsp> Parser
		{
			get
			{
				return InstLevelPlayStateRsp._parser;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x0600B929 RID: 47401 RVA: 0x001B9463 File Offset: 0x001B7663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x0600B92A RID: 47402 RVA: 0x001B9466 File Offset: 0x001B7666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstLevelPlayStateRsp.Descriptor;
			}
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x001B9470 File Offset: 0x001B7670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateRsp()
		{
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x001B94C8 File Offset: 0x001B76C8
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

		// Token: 0x0600B92D RID: 47405 RVA: 0x001B955E File Offset: 0x001B775E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstLevelPlayStateRsp Clone()
		{
			return new InstLevelPlayStateRsp(this);
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600B92E RID: 47406 RVA: 0x001B9566 File Offset: 0x001B7766
		// (set) Token: 0x0600B92F RID: 47407 RVA: 0x001B956E File Offset: 0x001B776E
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

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x0600B930 RID: 47408 RVA: 0x001B9577 File Offset: 0x001B7777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LevelPlayStateDict
		{
			get
			{
				return this.levelPlayStateDict_;
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x0600B931 RID: 47409 RVA: 0x001B957F File Offset: 0x001B777F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> CompleteNumberDict
		{
			get
			{
				return this.completeNumberDict_;
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x001B9587 File Offset: 0x001B7787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> HideDict
		{
			get
			{
				return this.hideDict_;
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x0600B933 RID: 47411 RVA: 0x001B958F File Offset: 0x001B778F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> HideGroupInfoDict
		{
			get
			{
				return this.hideGroupInfoDict_;
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x0600B934 RID: 47412 RVA: 0x001B9597 File Offset: 0x001B7797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, bool> IsUnlockDict
		{
			get
			{
				return this.isUnlockDict_;
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x0600B935 RID: 47413 RVA: 0x001B959F File Offset: 0x001B779F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, LevelPlayGainRewardInfo> GainRewardInfoDict
		{
			get
			{
				return this.gainRewardInfoDict_;
			}
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x001B95A7 File Offset: 0x001B77A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstLevelPlayStateRsp);
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x001B95B8 File Offset: 0x001B77B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstLevelPlayStateRsp other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.LevelPlayStateDict.Equals(other.LevelPlayStateDict) && this.CompleteNumberDict.Equals(other.CompleteNumberDict) && this.HideDict.Equals(other.HideDict) && this.HideGroupInfoDict.Equals(other.HideGroupInfoDict) && this.IsUnlockDict.Equals(other.IsUnlockDict) && this.GainRewardInfoDict.Equals(other.GainRewardInfoDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x001B9670 File Offset: 0x001B7870
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

		// Token: 0x0600B939 RID: 47417 RVA: 0x001B9703 File Offset: 0x001B7903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x001B9710 File Offset: 0x001B7910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x001B971C File Offset: 0x001B791C
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

		// Token: 0x0600B93C RID: 47420 RVA: 0x001B97C0 File Offset: 0x001B79C0
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

		// Token: 0x0600B93D RID: 47421 RVA: 0x001B9870 File Offset: 0x001B7A70
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

		// Token: 0x0600B93E RID: 47422 RVA: 0x001B9912 File Offset: 0x001B7B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x001B991C File Offset: 0x001B7B1C
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

		// Token: 0x040051D4 RID: 20948
		private static readonly MessageParser<InstLevelPlayStateRsp> _parser = new MessageParser<InstLevelPlayStateRsp>(() => new InstLevelPlayStateRsp());

		// Token: 0x040051D5 RID: 20949
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051D6 RID: 20950
		public const int InstIdFieldNumber = 1;

		// Token: 0x040051D7 RID: 20951
		private int instId_;

		// Token: 0x040051D8 RID: 20952
		public const int LevelPlayStateDictFieldNumber = 2;

		// Token: 0x040051D9 RID: 20953
		private static readonly MapField<int, int>.Codec _map_levelPlayStateDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040051DA RID: 20954
		private readonly MapField<int, int> levelPlayStateDict_ = new MapField<int, int>();

		// Token: 0x040051DB RID: 20955
		public const int CompleteNumberDictFieldNumber = 3;

		// Token: 0x040051DC RID: 20956
		private static readonly MapField<int, int>.Codec _map_completeNumberDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x040051DD RID: 20957
		private readonly MapField<int, int> completeNumberDict_ = new MapField<int, int>();

		// Token: 0x040051DE RID: 20958
		public const int HideDictFieldNumber = 4;

		// Token: 0x040051DF RID: 20959
		private static readonly MapField<int, bool>.Codec _map_hideDict_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 34U);

		// Token: 0x040051E0 RID: 20960
		private readonly MapField<int, bool> hideDict_ = new MapField<int, bool>();

		// Token: 0x040051E1 RID: 20961
		public const int HideGroupInfoDictFieldNumber = 5;

		// Token: 0x040051E2 RID: 20962
		private static readonly MapField<int, string>.Codec _map_hideGroupInfoDict_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 42U);

		// Token: 0x040051E3 RID: 20963
		private readonly MapField<int, string> hideGroupInfoDict_ = new MapField<int, string>();

		// Token: 0x040051E4 RID: 20964
		public const int IsUnlockDictFieldNumber = 6;

		// Token: 0x040051E5 RID: 20965
		private static readonly MapField<int, bool>.Codec _map_isUnlockDict_codec = new MapField<int, bool>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForBool(16U, false), 50U);

		// Token: 0x040051E6 RID: 20966
		private readonly MapField<int, bool> isUnlockDict_ = new MapField<int, bool>();

		// Token: 0x040051E7 RID: 20967
		public const int GainRewardInfoDictFieldNumber = 7;

		// Token: 0x040051E8 RID: 20968
		private static readonly MapField<int, LevelPlayGainRewardInfo>.Codec _map_gainRewardInfoDict_codec = new MapField<int, LevelPlayGainRewardInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<LevelPlayGainRewardInfo>(18U, LevelPlayGainRewardInfo.Parser), 58U);

		// Token: 0x040051E9 RID: 20969
		private readonly MapField<int, LevelPlayGainRewardInfo> gainRewardInfoDict_ = new MapField<int, LevelPlayGainRewardInfo>();
	}
}
