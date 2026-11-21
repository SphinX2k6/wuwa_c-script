using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000551 RID: 1361
	public sealed class FishingInfo : IMessage<FishingInfo>, IMessage, IEquatable<FishingInfo>, IDeepCloneable<FishingInfo>, IBufferMessage
	{
		// Token: 0x06007F5E RID: 32606 RVA: 0x0013430D File Offset: 0x0013250D
		[NullableContext(1)]
		public static FishingInfo Create()
		{
			return new FishingInfo();
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06007F5F RID: 32607 RVA: 0x00134314 File Offset: 0x00132514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06007F60 RID: 32608 RVA: 0x00134317 File Offset: 0x00132517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfo.Descriptor;
			}
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00134320 File Offset: 0x00132520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo()
		{
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x0013438C File Offset: 0x0013258C
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

		// Token: 0x06007F63 RID: 32611 RVA: 0x00134488 File Offset: 0x00132688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfo Clone()
		{
			return new FishingInfo(this);
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06007F64 RID: 32612 RVA: 0x00134490 File Offset: 0x00132690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, FishingEntrustStatus> Entrusts
		{
			get
			{
				return this.entrusts_;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x00134498 File Offset: 0x00132698
		// (set) Token: 0x06007F66 RID: 32614 RVA: 0x001344A0 File Offset: 0x001326A0
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

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06007F67 RID: 32615 RVA: 0x001344A9 File Offset: 0x001326A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingTechInfo> FishingTech
		{
			get
			{
				return this.fishingTech_;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06007F68 RID: 32616 RVA: 0x001344B1 File Offset: 0x001326B1
		// (set) Token: 0x06007F69 RID: 32617 RVA: 0x001344B9 File Offset: 0x001326B9
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

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06007F6A RID: 32618 RVA: 0x001344C2 File Offset: 0x001326C2
		// (set) Token: 0x06007F6B RID: 32619 RVA: 0x001344CA File Offset: 0x001326CA
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

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06007F6C RID: 32620 RVA: 0x001344D3 File Offset: 0x001326D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SceneFishCageInfo> SceneCages
		{
			get
			{
				return this.sceneCages_;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x001344DB File Offset: 0x001326DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, SceneFishPointInfo> SceneFishPoints
		{
			get
			{
				return this.sceneFishPoints_;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x001344E3 File Offset: 0x001326E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NoticeIds
		{
			get
			{
				return this.noticeIds_;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x001344EB File Offset: 0x001326EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HandInInfo> HandInInfo
		{
			get
			{
				return this.handInInfo_;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06007F70 RID: 32624 RVA: 0x001344F3 File Offset: 0x001326F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockPortId
		{
			get
			{
				return this.unlockPortId_;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x001344FB File Offset: 0x001326FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockSkins
		{
			get
			{
				return this.unlockSkins_;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x06007F72 RID: 32626 RVA: 0x00134503 File Offset: 0x00132703
		// (set) Token: 0x06007F73 RID: 32627 RVA: 0x0013450B File Offset: 0x0013270B
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

		// Token: 0x06007F74 RID: 32628 RVA: 0x00134514 File Offset: 0x00132714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfo);
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x00134524 File Offset: 0x00132724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfo other)
		{
			return other != null && (other == this || (this.Entrusts.Equals(other.Entrusts) && this.TraceEntrusts == other.TraceEntrusts && this.fishingTech_.Equals(other.fishingTech_) && object.Equals(this.ShipInfo, other.ShipInfo) && object.Equals(this.IllustratedInfo, other.IllustratedInfo) && this.SceneCages.Equals(other.SceneCages) && this.SceneFishPoints.Equals(other.SceneFishPoints) && this.noticeIds_.Equals(other.noticeIds_) && this.handInInfo_.Equals(other.handInInfo_) && this.unlockPortId_.Equals(other.unlockPortId_) && this.unlockSkins_.Equals(other.unlockSkins_) && this.EntrustRefreshRatio == other.EntrustRefreshRatio && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x00134640 File Offset: 0x00132840
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

		// Token: 0x06007F77 RID: 32631 RVA: 0x00134734 File Offset: 0x00132934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x00134741 File Offset: 0x00132941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x0013474C File Offset: 0x0013294C
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

		// Token: 0x06007F7A RID: 32634 RVA: 0x00134868 File Offset: 0x00132A68
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

		// Token: 0x06007F7B RID: 32635 RVA: 0x00134988 File Offset: 0x00132B88
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

		// Token: 0x06007F7C RID: 32636 RVA: 0x00134AB8 File Offset: 0x00132CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x00134AC4 File Offset: 0x00132CC4
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

		// Token: 0x040040B1 RID: 16561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040B2 RID: 16562
		public const int EntrustsFieldNumber = 3;

		// Token: 0x040040B3 RID: 16563
		private static readonly MapField<int, FishingEntrustStatus>.Codec _map_entrusts_codec = new MapField<int, FishingEntrustStatus>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForEnum<FishingEntrustStatus>(16U, (FishingEntrustStatus x) => (int)x, (int x) => (FishingEntrustStatus)x, FishingEntrustStatus.Created), 26U);

		// Token: 0x040040B4 RID: 16564
		private readonly MapField<int, FishingEntrustStatus> entrusts_ = new MapField<int, FishingEntrustStatus>();

		// Token: 0x040040B5 RID: 16565
		public const int TraceEntrustsFieldNumber = 4;

		// Token: 0x040040B6 RID: 16566
		private int traceEntrusts_;

		// Token: 0x040040B7 RID: 16567
		public const int FishingTechFieldNumber = 5;

		// Token: 0x040040B8 RID: 16568
		private static readonly FieldCodec<FishingTechInfo> _repeated_fishingTech_codec = FieldCodec.ForMessage<FishingTechInfo>(42U, FishingTechInfo.Parser);

		// Token: 0x040040B9 RID: 16569
		private readonly RepeatedField<FishingTechInfo> fishingTech_ = new RepeatedField<FishingTechInfo>();

		// Token: 0x040040BA RID: 16570
		public const int ShipInfoFieldNumber = 6;

		// Token: 0x040040BB RID: 16571
		private FishingShipInfo shipInfo_;

		// Token: 0x040040BC RID: 16572
		public const int IllustratedInfoFieldNumber = 7;

		// Token: 0x040040BD RID: 16573
		private FishingIllustratedInfo illustratedInfo_;

		// Token: 0x040040BE RID: 16574
		public const int SceneCagesFieldNumber = 8;

		// Token: 0x040040BF RID: 16575
		private static readonly MapField<int, SceneFishCageInfo>.Codec _map_sceneCages_codec = new MapField<int, SceneFishCageInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<SceneFishCageInfo>(18U, SceneFishCageInfo.Parser), 66U);

		// Token: 0x040040C0 RID: 16576
		private readonly MapField<int, SceneFishCageInfo> sceneCages_ = new MapField<int, SceneFishCageInfo>();

		// Token: 0x040040C1 RID: 16577
		public const int SceneFishPointsFieldNumber = 9;

		// Token: 0x040040C2 RID: 16578
		private static readonly MapField<int, SceneFishPointInfo>.Codec _map_sceneFishPoints_codec = new MapField<int, SceneFishPointInfo>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForMessage<SceneFishPointInfo>(18U, SceneFishPointInfo.Parser), 74U);

		// Token: 0x040040C3 RID: 16579
		private readonly MapField<int, SceneFishPointInfo> sceneFishPoints_ = new MapField<int, SceneFishPointInfo>();

		// Token: 0x040040C4 RID: 16580
		public const int NoticeIdsFieldNumber = 10;

		// Token: 0x040040C5 RID: 16581
		private static readonly FieldCodec<int> _repeated_noticeIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040040C6 RID: 16582
		private readonly RepeatedField<int> noticeIds_ = new RepeatedField<int>();

		// Token: 0x040040C7 RID: 16583
		public const int HandInInfoFieldNumber = 11;

		// Token: 0x040040C8 RID: 16584
		private static readonly FieldCodec<HandInInfo> _repeated_handInInfo_codec = FieldCodec.ForMessage<HandInInfo>(90U, Aki.Protocol.HandInInfo.Parser);

		// Token: 0x040040C9 RID: 16585
		private readonly RepeatedField<HandInInfo> handInInfo_ = new RepeatedField<HandInInfo>();

		// Token: 0x040040CA RID: 16586
		public const int UnlockPortIdFieldNumber = 12;

		// Token: 0x040040CB RID: 16587
		private static readonly FieldCodec<int> _repeated_unlockPortId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040040CC RID: 16588
		private readonly RepeatedField<int> unlockPortId_ = new RepeatedField<int>();

		// Token: 0x040040CD RID: 16589
		public const int UnlockSkinsFieldNumber = 13;

		// Token: 0x040040CE RID: 16590
		private static readonly FieldCodec<int> _repeated_unlockSkins_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040040CF RID: 16591
		private readonly RepeatedField<int> unlockSkins_ = new RepeatedField<int>();

		// Token: 0x040040D0 RID: 16592
		public const int EntrustRefreshRatioFieldNumber = 14;

		// Token: 0x040040D1 RID: 16593
		private int entrustRefreshRatio_;
	}
}
