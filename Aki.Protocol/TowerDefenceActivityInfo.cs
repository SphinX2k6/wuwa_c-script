using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140C RID: 5132
	public sealed class TowerDefenceActivityInfo : IMessage<TowerDefenceActivityInfo>, IMessage, IEquatable<TowerDefenceActivityInfo>, IDeepCloneable<TowerDefenceActivityInfo>, IBufferMessage
	{
		// Token: 0x0601B478 RID: 111736 RVA: 0x003F7A8D File Offset: 0x003F5C8D
		[NullableContext(1)]
		public static TowerDefenceActivityInfo Create()
		{
			return new TowerDefenceActivityInfo();
		}

		// Token: 0x17005C55 RID: 23637
		// (get) Token: 0x0601B479 RID: 111737 RVA: 0x003F7A94 File Offset: 0x003F5C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x0601B47A RID: 111738 RVA: 0x003F7A97 File Offset: 0x003F5C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601B47B RID: 111739 RVA: 0x003F7A9E File Offset: 0x003F5C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo()
		{
		}

		// Token: 0x0601B47C RID: 111740 RVA: 0x003F7ABC File Offset: 0x003F5CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo(TowerDefenceActivityInfo other) : this()
		{
			this.instanceInfos_ = other.instanceInfos_.Clone();
			this.rewardedScoreIds_ = other.rewardedScoreIds_.Clone();
			this.totalScore_ = other.totalScore_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B47D RID: 111741 RVA: 0x003F7B1A File Offset: 0x003F5D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo Clone()
		{
			return new TowerDefenceActivityInfo(this);
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x0601B47E RID: 111742 RVA: 0x003F7B22 File Offset: 0x003F5D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceInstanceInfo> InstanceInfos
		{
			get
			{
				return this.instanceInfos_;
			}
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x0601B47F RID: 111743 RVA: 0x003F7B2A File Offset: 0x003F5D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedScoreIds
		{
			get
			{
				return this.rewardedScoreIds_;
			}
		}

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x0601B480 RID: 111744 RVA: 0x003F7B32 File Offset: 0x003F5D32
		// (set) Token: 0x0601B481 RID: 111745 RVA: 0x003F7B3A File Offset: 0x003F5D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalScore
		{
			get
			{
				return this.totalScore_;
			}
			set
			{
				this.totalScore_ = value;
			}
		}

		// Token: 0x17005C5A RID: 23642
		// (get) Token: 0x0601B482 RID: 111746 RVA: 0x003F7B43 File Offset: 0x003F5D43
		// (set) Token: 0x0601B483 RID: 111747 RVA: 0x003F7B4B File Offset: 0x003F5D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x0601B484 RID: 111748 RVA: 0x003F7B54 File Offset: 0x003F5D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceActivityInfo);
		}

		// Token: 0x0601B485 RID: 111749 RVA: 0x003F7B64 File Offset: 0x003F5D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceActivityInfo other)
		{
			return other != null && (other == this || (this.instanceInfos_.Equals(other.instanceInfos_) && this.rewardedScoreIds_.Equals(other.rewardedScoreIds_) && this.TotalScore == other.TotalScore && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B486 RID: 111750 RVA: 0x003F7BD8 File Offset: 0x003F5DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instanceInfos_.GetHashCode();
			num ^= this.rewardedScoreIds_.GetHashCode();
			if (this.TotalScore != 0)
			{
				num ^= this.TotalScore.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B487 RID: 111751 RVA: 0x003F7C4C File Offset: 0x003F5E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B488 RID: 111752 RVA: 0x003F7C59 File Offset: 0x003F5E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B489 RID: 111753 RVA: 0x003F7C64 File Offset: 0x003F5E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instanceInfos_.WriteTo(ref output, TowerDefenceActivityInfo._repeated_instanceInfos_codec);
			this.rewardedScoreIds_.WriteTo(ref output, TowerDefenceActivityInfo._repeated_rewardedScoreIds_codec);
			if (this.TotalScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalScore);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B48A RID: 111754 RVA: 0x003F7CE0 File Offset: 0x003F5EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instanceInfos_.CalculateSize(TowerDefenceActivityInfo._repeated_instanceInfos_codec);
			num += this.rewardedScoreIds_.CalculateSize(TowerDefenceActivityInfo._repeated_rewardedScoreIds_codec);
			if (this.TotalScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalScore);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B48B RID: 111755 RVA: 0x003F7D50 File Offset: 0x003F5F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.instanceInfos_.Add(other.instanceInfos_);
			this.rewardedScoreIds_.Add(other.rewardedScoreIds_);
			if (other.TotalScore != 0)
			{
				this.TotalScore = other.TotalScore;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B48C RID: 111756 RVA: 0x003F7DC2 File Offset: 0x003F5FC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B48D RID: 111757 RVA: 0x003F7DCC File Offset: 0x003F5FCC
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
						this.instanceInfos_.AddEntriesFrom(ref input, TowerDefenceActivityInfo._repeated_instanceInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_50;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_50;
					}
					if (num == 24U)
					{
						this.TotalScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_50:
				this.rewardedScoreIds_.AddEntriesFrom(ref input, TowerDefenceActivityInfo._repeated_rewardedScoreIds_codec);
			}
		}

		// Token: 0x04009EF1 RID: 40689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EF2 RID: 40690
		public const int InstanceInfosFieldNumber = 1;

		// Token: 0x04009EF3 RID: 40691
		private static readonly FieldCodec<TowerDefenceInstanceInfo> _repeated_instanceInfos_codec = FieldCodec.ForMessage<TowerDefenceInstanceInfo>(10U, TowerDefenceInstanceInfo.Parser);

		// Token: 0x04009EF4 RID: 40692
		private readonly RepeatedField<TowerDefenceInstanceInfo> instanceInfos_ = new RepeatedField<TowerDefenceInstanceInfo>();

		// Token: 0x04009EF5 RID: 40693
		public const int RewardedScoreIdsFieldNumber = 2;

		// Token: 0x04009EF6 RID: 40694
		private static readonly FieldCodec<int> _repeated_rewardedScoreIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009EF7 RID: 40695
		private readonly RepeatedField<int> rewardedScoreIds_ = new RepeatedField<int>();

		// Token: 0x04009EF8 RID: 40696
		public const int TotalScoreFieldNumber = 3;

		// Token: 0x04009EF9 RID: 40697
		private int totalScore_;

		// Token: 0x04009EFA RID: 40698
		public const int ShowNameFieldNumber = 4;

		// Token: 0x04009EFB RID: 40699
		private bool showName_;
	}
}
