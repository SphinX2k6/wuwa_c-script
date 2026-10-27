using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001399 RID: 5017
	public sealed class TowerDefenceActivityInfo : IMessage<TowerDefenceActivityInfo>, IMessage, IEquatable<TowerDefenceActivityInfo>, IDeepCloneable<TowerDefenceActivityInfo>, IBufferMessage
	{
		// Token: 0x0601A9ED RID: 109037 RVA: 0x003DC7C5 File Offset: 0x003DA9C5
		[NullableContext(1)]
		public static TowerDefenceActivityInfo Create()
		{
			return new TowerDefenceActivityInfo();
		}

		// Token: 0x170059C0 RID: 22976
		// (get) Token: 0x0601A9EE RID: 109038 RVA: 0x003DC7CC File Offset: 0x003DA9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059C1 RID: 22977
		// (get) Token: 0x0601A9EF RID: 109039 RVA: 0x003DC7CF File Offset: 0x003DA9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601A9F0 RID: 109040 RVA: 0x003DC7D6 File Offset: 0x003DA9D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo()
		{
		}

		// Token: 0x0601A9F1 RID: 109041 RVA: 0x003DC7F4 File Offset: 0x003DA9F4
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

		// Token: 0x0601A9F2 RID: 109042 RVA: 0x003DC852 File Offset: 0x003DAA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo Clone()
		{
			return new TowerDefenceActivityInfo(this);
		}

		// Token: 0x170059C2 RID: 22978
		// (get) Token: 0x0601A9F3 RID: 109043 RVA: 0x003DC85A File Offset: 0x003DAA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceInstanceInfo> InstanceInfos
		{
			get
			{
				return this.instanceInfos_;
			}
		}

		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x0601A9F4 RID: 109044 RVA: 0x003DC862 File Offset: 0x003DAA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedScoreIds
		{
			get
			{
				return this.rewardedScoreIds_;
			}
		}

		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x0601A9F5 RID: 109045 RVA: 0x003DC86A File Offset: 0x003DAA6A
		// (set) Token: 0x0601A9F6 RID: 109046 RVA: 0x003DC872 File Offset: 0x003DAA72
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

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x0601A9F7 RID: 109047 RVA: 0x003DC87B File Offset: 0x003DAA7B
		// (set) Token: 0x0601A9F8 RID: 109048 RVA: 0x003DC883 File Offset: 0x003DAA83
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

		// Token: 0x0601A9F9 RID: 109049 RVA: 0x003DC88C File Offset: 0x003DAA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceActivityInfo);
		}

		// Token: 0x0601A9FA RID: 109050 RVA: 0x003DC89C File Offset: 0x003DAA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceActivityInfo other)
		{
			return other != null && (other == this || (this.instanceInfos_.Equals(other.instanceInfos_) && this.rewardedScoreIds_.Equals(other.rewardedScoreIds_) && this.TotalScore == other.TotalScore && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9FB RID: 109051 RVA: 0x003DC910 File Offset: 0x003DAB10
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

		// Token: 0x0601A9FC RID: 109052 RVA: 0x003DC984 File Offset: 0x003DAB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9FD RID: 109053 RVA: 0x003DC991 File Offset: 0x003DAB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9FE RID: 109054 RVA: 0x003DC99C File Offset: 0x003DAB9C
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

		// Token: 0x0601A9FF RID: 109055 RVA: 0x003DCA18 File Offset: 0x003DAC18
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

		// Token: 0x0601AA00 RID: 109056 RVA: 0x003DCA88 File Offset: 0x003DAC88
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

		// Token: 0x0601AA01 RID: 109057 RVA: 0x003DCAFA File Offset: 0x003DACFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA02 RID: 109058 RVA: 0x003DCB04 File Offset: 0x003DAD04
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

		// Token: 0x04009AAA RID: 39594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AAB RID: 39595
		public const int InstanceInfosFieldNumber = 1;

		// Token: 0x04009AAC RID: 39596
		private static readonly FieldCodec<TowerDefenceInstanceInfo> _repeated_instanceInfos_codec = FieldCodec.ForMessage<TowerDefenceInstanceInfo>(10U, TowerDefenceInstanceInfo.Parser);

		// Token: 0x04009AAD RID: 39597
		private readonly RepeatedField<TowerDefenceInstanceInfo> instanceInfos_ = new RepeatedField<TowerDefenceInstanceInfo>();

		// Token: 0x04009AAE RID: 39598
		public const int RewardedScoreIdsFieldNumber = 2;

		// Token: 0x04009AAF RID: 39599
		private static readonly FieldCodec<int> _repeated_rewardedScoreIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04009AB0 RID: 39600
		private readonly RepeatedField<int> rewardedScoreIds_ = new RepeatedField<int>();

		// Token: 0x04009AB1 RID: 39601
		public const int TotalScoreFieldNumber = 3;

		// Token: 0x04009AB2 RID: 39602
		private int totalScore_;

		// Token: 0x04009AB3 RID: 39603
		public const int ShowNameFieldNumber = 4;

		// Token: 0x04009AB4 RID: 39604
		private bool showName_;
	}
}
