using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000566 RID: 1382
	public sealed class FishingInfo : IMessage<FishingInfo>, IMessage, IEquatable<FishingInfo>, IDeepCloneable<FishingInfo>, IBufferMessage
	{
		// Token: 0x060080C6 RID: 32966 RVA: 0x00136F0D File Offset: 0x0013510D
		[NullableContext(1)]
		public static FishingInfo Create()
		{
			return new FishingInfo();
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060080C7 RID: 32967 RVA: 0x00136F14 File Offset: 0x00135114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060080C8 RID: 32968 RVA: 0x00136F17 File Offset: 0x00135117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfo.Descriptor;
			}
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x00136F20 File Offset: 0x00135120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo()
		{
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x00136F8C File Offset: 0x0013518C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo(FishingInfo other) : this()
		{
			this.entrusts_ = other.entrusts_.Clone();
			this.traceEntrusts_ = other.traceEntrusts_;
			this.fishingTech_ = other.fishingTech_.Clone();
			this.shipInfo_ = ((other.shipInfo_ != null) ? other.shipInfo_.Clone() : null);
			this.illustratedInfo_ = ((other.illustratedInfo_ != null) ? other.illustratedInfo_.Clone() : null);
			this.sceneCages_ = other.sceneCages_.Clone();
			this.sceneFishPoints_ = other.sceneFishPoints_.Clone();
			this.noticeIds_ = other.noticeIds_.Clone();
			this.handInInfo_ = other.handInInfo_.Clone();
			this.unlockPortId_ = other.unlockPortId_.Clone();
			this.unlockSkins_ = other.unlockSkins_.Clone();
			this.entrustRefreshRatio_ = other.entrustRefreshRatio_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x00137088 File Offset: 0x00135288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo Clone()
		{
			return new FishingInfo(this);
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060080CC RID: 32972 RVA: 0x00137090 File Offset: 0x00135290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FishingEntrustStatus> Entrusts
		{
			get
			{
				return this.entrusts_;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x00137098 File Offset: 0x00135298
		// (set) Token: 0x060080CE RID: 32974 RVA: 0x001370A0 File Offset: 0x001352A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TraceEntrusts
		{
			get
			{
				return this.traceEntrusts_;
			}
			set
			{
				this.traceEntrusts_ = value;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x001370A9 File Offset: 0x001352A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingTechInfo> FishingTech
		{
			get
			{
				return this.fishingTech_;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x001370B1 File Offset: 0x001352B1
		// (set) Token: 0x060080D1 RID: 32977 RVA: 0x001370B9 File Offset: 0x001352B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipInfo ShipInfo
		{
			get
			{
				return this.shipInfo_;
			}
			set
			{
				this.shipInfo_ = value;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060080D2 RID: 32978 RVA: 0x001370C2 File Offset: 0x001352C2
		// (set) Token: 0x060080D3 RID: 32979 RVA: 0x001370CA File Offset: 0x001352CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo IllustratedInfo
		{
			get
			{
				return this.illustratedInfo_;
			}
			set
			{
				this.illustratedInfo_ = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060080D4 RID: 32980 RVA: 0x001370D3 File Offset: 0x001352D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SceneFishCageInfo> SceneCages
		{
			get
			{
				return this.sceneCages_;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060080D5 RID: 32981 RVA: 0x001370DB File Offset: 0x001352DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SceneFishPointInfo> SceneFishPoints
		{
			get
			{
				return this.sceneFishPoints_;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060080D6 RID: 32982 RVA: 0x001370E3 File Offset: 0x001352E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NoticeIds
		{
			get
			{
				return this.noticeIds_;
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060080D7 RID: 32983 RVA: 0x001370EB File Offset: 0x001352EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HandInInfo> HandInInfo
		{
			get
			{
				return this.handInInfo_;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x001370F3 File Offset: 0x001352F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockPortId
		{
			get
			{
				return this.unlockPortId_;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x060080D9 RID: 32985 RVA: 0x001370FB File Offset: 0x001352FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x00137103 File Offset: 0x00135303
		// (set) Token: 0x060080DB RID: 32987 RVA: 0x0013710B File Offset: 0x0013530B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustRefreshRatio
		{
			get
			{
				return this.entrustRefreshRatio_;
			}
			set
			{
				this.entrustRefreshRatio_ = value;
			}
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x00137114 File Offset: 0x00135314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfo);
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x00137124 File Offset: 0x00135324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfo other)
		{
			return other != null && (other == this || (this.Entrusts.Equals(other.Entrusts) && this.TraceEntrusts == other.TraceEntrusts && this.fishingTech_.Equals(other.fishingTech_) && object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this.IllustratedInfo, other.IllustratedInfo) && this.SceneCages.Equals(other.SceneCages) && this.SceneFishPoints.Equals(other.SceneFishPoints) && this.noticeIds_.Equals(other.noticeIds_) && this.handInInfo_.Equals(other.handInInfo_) && this.unlockPortId_.Equals(other.unlockPortId_) && this.unlockSkins_.Equals(other.unlockSkins_) && this.EntrustRefreshRatio == other.EntrustRefreshRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x00137240 File Offset: 0x00135440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Entrusts.GetHashCode();
			if (this.TraceEntrusts != 0)
			{
				num ^= this.TraceEntrusts.GetHashCode();
			}
			num ^= this.fishingTech_.GetHashCode();
			if (this.shipInfo_ != null)
			{
				num ^= this.ShipInfo.GetHashCode();
			}
			if (this.illustratedInfo_ != null)
			{
				num ^= this.IllustratedInfo.GetHashCode();
			}
			num ^= this.SceneCages.GetHashCode();
			num ^= this.SceneFishPoints.GetHashCode();
			num ^= this.noticeIds_.GetHashCode();
			num ^= this.handInInfo_.GetHashCode();
			num ^= this.unlockPortId_.GetHashCode();
			num ^= this.unlockSkins_.GetHashCode();
			if (this.EntrustRefreshRatio != 0)
			{
				num ^= this.EntrustRefreshRatio.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00137334 File Offset: 0x00135534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00137341 File Offset: 0x00135541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x0013734C File Offset: 0x0013554C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entrusts_.WriteTo(ref output, FishingInfo._map_entrusts_codec);
			if (this.TraceEntrusts != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TraceEntrusts);
			}
			this.fishingTech_.WriteTo(ref output, FishingInfo._repeated_fishingTech_codec);
			if (this.shipInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ShipInfo);
			}
			if (this.illustratedInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.IllustratedInfo);
			}
			this.sceneCages_.WriteTo(ref output, FishingInfo._map_sceneCages_codec);
			this.sceneFishPoints_.WriteTo(ref output, FishingInfo._map_sceneFishPoints_codec);
			this.noticeIds_.WriteTo(ref output, FishingInfo._repeated_noticeIds_codec);
			this.handInInfo_.WriteTo(ref output, FishingInfo._repeated_handInInfo_codec);
			this.unlockPortId_.WriteTo(ref output, FishingInfo._repeated_unlockPortId_codec);
			this.unlockSkins_.WriteTo(ref output, FishingInfo._repeated_unlockSkins_codec);
			if (this.EntrustRefreshRatio != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntrustRefreshRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x00137468 File Offset: 0x00135668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entrusts_.CalculateSize(FishingInfo._map_entrusts_codec);
			if (this.TraceEntrusts != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TraceEntrusts);
			}
			num += this.fishingTech_.CalculateSize(FishingInfo._repeated_fishingTech_codec);
			if (this.shipInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ShipInfo);
			}
			if (this.illustratedInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IllustratedInfo);
			}
			num += this.sceneCages_.CalculateSize(FishingInfo._map_sceneCages_codec);
			num += this.sceneFishPoints_.CalculateSize(FishingInfo._map_sceneFishPoints_codec);
			num += this.noticeIds_.CalculateSize(FishingInfo._repeated_noticeIds_codec);
			num += this.handInInfo_.CalculateSize(FishingInfo._repeated_handInInfo_codec);
			num += this.unlockPortId_.CalculateSize(FishingInfo._repeated_unlockPortId_codec);
			num += this.unlockSkins_.CalculateSize(FishingInfo._repeated_unlockSkins_codec);
			if (this.EntrustRefreshRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustRefreshRatio);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x00137588 File Offset: 0x00135788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.entrusts_.MergeFrom(other.entrusts_);
			if (other.TraceEntrusts != 0)
			{
				this.TraceEntrusts = other.TraceEntrusts;
			}
			this.fishingTech_.Add(other.fishingTech_);
			if (other.shipInfo_ != null)
			{
				if (this.shipInfo_ == null)
				{
					this.ShipInfo = new FishingShipInfo();
				}
				this.ShipInfo.MergeFrom(other.ShipInfo);
			}
			if (other.illustratedInfo_ != null)
			{
				if (this.illustratedInfo_ == null)
				{
					this.IllustratedInfo = new FishingIllustratedInfo();
				}
				this.IllustratedInfo.MergeFrom(other.IllustratedInfo);
			}
			this.sceneCages_.MergeFrom(other.sceneCages_);
			this.sceneFishPoints_.MergeFrom(other.sceneFishPoints_);
			this.noticeIds_.Add(other.noticeIds_);
			this.handInInfo_.Add(other.handInInfo_);
			this.unlockPortId_.Add(other.unlockPortId_);
			this.unlockSkins_.Add(other.unlockSkins_);
			if (other.EntrustRefreshRatio != 0)
			{
				this.EntrustRefreshRatio = other.EntrustRefreshRatio;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x001376B8 File Offset: 0x001358B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x001376C4 File Offset: 0x001358C4
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
				if (num > 74U)
				{
					if (num > 96U)
					{
						if (num <= 104U)
						{
							if (num == 98U)
							{
								goto IL_193;
							}
							if (num != 104U)
							{
								goto IL_AE;
							}
						}
						else if (num != 106U)
						{
							if (num != 112U)
							{
								goto IL_AE;
							}
							this.EntrustRefreshRatio = input.ReadInt32();
							continue;
						}
						this.unlockSkins_.AddEntriesFrom(ref input, FishingInfo._repeated_unlockSkins_codec);
						continue;
					}
					if (num <= 82U)
					{
						if (num != 80U && num != 82U)
						{
							goto IL_AE;
						}
						this.noticeIds_.AddEntriesFrom(ref input, FishingInfo._repeated_noticeIds_codec);
						continue;
					}
					else
					{
						if (num == 90U)
						{
							this.handInInfo_.AddEntriesFrom(ref input, FishingInfo._repeated_handInInfo_codec);
							continue;
						}
						if (num != 96U)
						{
							goto IL_AE;
						}
					}
					IL_193:
					this.unlockPortId_.AddEntriesFrom(ref input, FishingInfo._repeated_unlockPortId_codec);
					continue;
				}
				if (num <= 42U)
				{
					if (num == 26U)
					{
						this.entrusts_.AddEntriesFrom(ref input, FishingInfo._map_entrusts_codec);
						continue;
					}
					if (num == 32U)
					{
						this.TraceEntrusts = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.fishingTech_.AddEntriesFrom(ref input, FishingInfo._repeated_fishingTech_codec);
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 50U)
					{
						if (this.shipInfo_ == null)
						{
							this.ShipInfo = new FishingShipInfo();
						}
						input.ReadMessage(this.ShipInfo);
						continue;
					}
					if (num == 58U)
					{
						if (this.illustratedInfo_ == null)
						{
							this.IllustratedInfo = new FishingIllustratedInfo();
						}
						input.ReadMessage(this.IllustratedInfo);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.sceneCages_.AddEntriesFrom(ref input, FishingInfo._map_sceneCages_codec);
						continue;
					}
					if (num == 74U)
					{
						this.sceneFishPoints_.AddEntriesFrom(ref input, FishingInfo._map_sceneFishPoints_codec);
						continue;
					}
				}
				IL_AE:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040040BB RID: 16571
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040BC RID: 16572
		public const int EntrustsFieldNumber = 3;

		// Token: 0x040040BD RID: 16573
		private static readonly MapField<int, FishingEntrustStatus>.Codec _map_entrusts_codec = new MapField<int, FishingEntrustStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<FishingEntrustStatus>(16U, (FishingEntrustStatus x) => (int)x, (int x) => (FishingEntrustStatus)x, FishingEntrustStatus.Created), 26U);

		// Token: 0x040040BE RID: 16574
		private readonly MapField<int, FishingEntrustStatus> entrusts_ = new MapField<int, FishingEntrustStatus>();

		// Token: 0x040040BF RID: 16575
		public const int TraceEntrustsFieldNumber = 4;

		// Token: 0x040040C0 RID: 16576
		private int traceEntrusts_;

		// Token: 0x040040C1 RID: 16577
		public const int FishingTechFieldNumber = 5;

		// Token: 0x040040C2 RID: 16578
		private static readonly FieldCodec<FishingTechInfo> _repeated_fishingTech_codec = FieldCodec.ForMessage<FishingTechInfo>(42U, FishingTechInfo.Parser);

		// Token: 0x040040C3 RID: 16579
		private readonly RepeatedField<FishingTechInfo> fishingTech_ = new RepeatedField<FishingTechInfo>();

		// Token: 0x040040C4 RID: 16580
		public const int ShipInfoFieldNumber = 6;

		// Token: 0x040040C5 RID: 16581
		private FishingShipInfo shipInfo_;

		// Token: 0x040040C6 RID: 16582
		public const int IllustratedInfoFieldNumber = 7;

		// Token: 0x040040C7 RID: 16583
		private FishingIllustratedInfo illustratedInfo_;

		// Token: 0x040040C8 RID: 16584
		public const int SceneCagesFieldNumber = 8;

		// Token: 0x040040C9 RID: 16585
		private static readonly MapField<int, SceneFishCageInfo>.Codec _map_sceneCages_codec = new MapField<int, SceneFishCageInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<SceneFishCageInfo>(18U, SceneFishCageInfo.Parser), 66U);

		// Token: 0x040040CA RID: 16586
		private readonly MapField<int, SceneFishCageInfo> sceneCages_ = new MapField<int, SceneFishCageInfo>();

		// Token: 0x040040CB RID: 16587
		public const int SceneFishPointsFieldNumber = 9;

		// Token: 0x040040CC RID: 16588
		private static readonly MapField<int, SceneFishPointInfo>.Codec _map_sceneFishPoints_codec = new MapField<int, SceneFishPointInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<SceneFishPointInfo>(18U, SceneFishPointInfo.Parser), 74U);

		// Token: 0x040040CD RID: 16589
		private readonly MapField<int, SceneFishPointInfo> sceneFishPoints_ = new MapField<int, SceneFishPointInfo>();

		// Token: 0x040040CE RID: 16590
		public const int NoticeIdsFieldNumber = 10;

		// Token: 0x040040CF RID: 16591
		private static readonly FieldCodec<int> _repeated_noticeIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040040D0 RID: 16592
		private readonly RepeatedField<int> noticeIds_ = new RepeatedField<int>();

		// Token: 0x040040D1 RID: 16593
		public const int HandInInfoFieldNumber = 11;

		// Token: 0x040040D2 RID: 16594
		private static readonly FieldCodec<HandInInfo> _repeated_handInInfo_codec = FieldCodec.ForMessage<HandInInfo>(90U, Aki.Protocol.HandInInfo.Parser);

		// Token: 0x040040D3 RID: 16595
		private readonly RepeatedField<HandInInfo> handInInfo_ = new RepeatedField<HandInInfo>();

		// Token: 0x040040D4 RID: 16596
		public const int UnlockPortIdFieldNumber = 12;

		// Token: 0x040040D5 RID: 16597
		private static readonly FieldCodec<int> _repeated_unlockPortId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040040D6 RID: 16598
		private readonly RepeatedField<int> unlockPortId_ = new RepeatedField<int>();

		// Token: 0x040040D7 RID: 16599
		public const int UnlockSkinsFieldNumber = 13;

		// Token: 0x040040D8 RID: 16600
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040040D9 RID: 16601
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();

		// Token: 0x040040DA RID: 16602
		public const int EntrustRefreshRatioFieldNumber = 14;

		// Token: 0x040040DB RID: 16603
		private int entrustRefreshRatio_;
	}
}
