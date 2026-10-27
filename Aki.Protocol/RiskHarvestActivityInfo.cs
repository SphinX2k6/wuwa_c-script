using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F53 RID: 3923
	public sealed class RiskHarvestActivityInfo : IMessage<RiskHarvestActivityInfo>, IMessage, IEquatable<RiskHarvestActivityInfo>, IDeepCloneable<RiskHarvestActivityInfo>, IBufferMessage
	{
		// Token: 0x06014FC8 RID: 85960 RVA: 0x0030B5F9 File Offset: 0x003097F9
		[NullableContext(1)]
		public static RiskHarvestActivityInfo Create()
		{
			return new RiskHarvestActivityInfo();
		}

		// Token: 0x170045CE RID: 17870
		// (get) Token: 0x06014FC9 RID: 85961 RVA: 0x0030B600 File Offset: 0x00309800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045CF RID: 17871
		// (get) Token: 0x06014FCA RID: 85962 RVA: 0x0030B603 File Offset: 0x00309803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestActivityInfo.Descriptor;
			}
		}

		// Token: 0x06014FCB RID: 85963 RVA: 0x0030B60A File Offset: 0x0030980A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo()
		{
		}

		// Token: 0x06014FCC RID: 85964 RVA: 0x0030B64C File Offset: 0x0030984C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo(RiskHarvestActivityInfo other) : this()
		{
			this.instInfos_ = other.instInfos_.Clone();
			this.rewardedScores_ = other.rewardedScores_.Clone();
			this.rewardedBuffGroups_ = other.rewardedBuffGroups_.Clone();
			this.unlockBuffGroups_ = other.unlockBuffGroups_.Clone();
			this.rewardedBuffTypeIds_ = other.rewardedBuffTypeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014FCD RID: 85965 RVA: 0x0030B6C5 File Offset: 0x003098C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo Clone()
		{
			return new RiskHarvestActivityInfo(this);
		}

		// Token: 0x170045D0 RID: 17872
		// (get) Token: 0x06014FCE RID: 85966 RVA: 0x0030B6CD File Offset: 0x003098CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x170045D1 RID: 17873
		// (get) Token: 0x06014FCF RID: 85967 RVA: 0x0030B6D5 File Offset: 0x003098D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedScores
		{
			get
			{
				return this.rewardedScores_;
			}
		}

		// Token: 0x170045D2 RID: 17874
		// (get) Token: 0x06014FD0 RID: 85968 RVA: 0x0030B6DD File Offset: 0x003098DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBuffGroups
		{
			get
			{
				return this.rewardedBuffGroups_;
			}
		}

		// Token: 0x170045D3 RID: 17875
		// (get) Token: 0x06014FD1 RID: 85969 RVA: 0x0030B6E5 File Offset: 0x003098E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuffGroups
		{
			get
			{
				return this.unlockBuffGroups_;
			}
		}

		// Token: 0x170045D4 RID: 17876
		// (get) Token: 0x06014FD2 RID: 85970 RVA: 0x0030B6ED File Offset: 0x003098ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBuffTypeIds
		{
			get
			{
				return this.rewardedBuffTypeIds_;
			}
		}

		// Token: 0x06014FD3 RID: 85971 RVA: 0x0030B6F5 File Offset: 0x003098F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestActivityInfo);
		}

		// Token: 0x06014FD4 RID: 85972 RVA: 0x0030B704 File Offset: 0x00309904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestActivityInfo other)
		{
			return other != null && (other == this || (this.instInfos_.Equals(other.instInfos_) && this.rewardedScores_.Equals(other.rewardedScores_) && this.rewardedBuffGroups_.Equals(other.rewardedBuffGroups_) && this.unlockBuffGroups_.Equals(other.unlockBuffGroups_) && this.rewardedBuffTypeIds_.Equals(other.rewardedBuffTypeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014FD5 RID: 85973 RVA: 0x0030B798 File Offset: 0x00309998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instInfos_.GetHashCode();
			num ^= this.rewardedScores_.GetHashCode();
			num ^= this.rewardedBuffGroups_.GetHashCode();
			num ^= this.unlockBuffGroups_.GetHashCode();
			num ^= this.rewardedBuffTypeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014FD6 RID: 85974 RVA: 0x0030B804 File Offset: 0x00309A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014FD7 RID: 85975 RVA: 0x0030B811 File Offset: 0x00309A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014FD8 RID: 85976 RVA: 0x0030B81C File Offset: 0x00309A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instInfos_.WriteTo(ref output, RiskHarvestActivityInfo._repeated_instInfos_codec);
			this.rewardedScores_.WriteTo(ref output, RiskHarvestActivityInfo._repeated_rewardedScores_codec);
			this.rewardedBuffGroups_.WriteTo(ref output, RiskHarvestActivityInfo._repeated_rewardedBuffGroups_codec);
			this.unlockBuffGroups_.WriteTo(ref output, RiskHarvestActivityInfo._repeated_unlockBuffGroups_codec);
			this.rewardedBuffTypeIds_.WriteTo(ref output, RiskHarvestActivityInfo._repeated_rewardedBuffTypeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014FD9 RID: 85977 RVA: 0x0030B894 File Offset: 0x00309A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instInfos_.CalculateSize(RiskHarvestActivityInfo._repeated_instInfos_codec);
			num += this.rewardedScores_.CalculateSize(RiskHarvestActivityInfo._repeated_rewardedScores_codec);
			num += this.rewardedBuffGroups_.CalculateSize(RiskHarvestActivityInfo._repeated_rewardedBuffGroups_codec);
			num += this.unlockBuffGroups_.CalculateSize(RiskHarvestActivityInfo._repeated_unlockBuffGroups_codec);
			num += this.rewardedBuffTypeIds_.CalculateSize(RiskHarvestActivityInfo._repeated_rewardedBuffTypeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014FDA RID: 85978 RVA: 0x0030B91C File Offset: 0x00309B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.instInfos_.Add(other.instInfos_);
			this.rewardedScores_.Add(other.rewardedScores_);
			this.rewardedBuffGroups_.Add(other.rewardedBuffGroups_);
			this.unlockBuffGroups_.Add(other.unlockBuffGroups_);
			this.rewardedBuffTypeIds_.Add(other.rewardedBuffTypeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014FDB RID: 85979 RVA: 0x0030B999 File Offset: 0x00309B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014FDC RID: 85980 RVA: 0x0030B9A4 File Offset: 0x00309BA4
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
				if (num <= 24U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.instInfos_.AddEntriesFrom(ref input, RiskHarvestActivityInfo._repeated_instInfos_codec);
							continue;
						}
						if (num != 16U)
						{
							goto IL_4E;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U)
						{
							goto IL_4E;
						}
						goto IL_88;
					}
					this.rewardedScores_.AddEntriesFrom(ref input, RiskHarvestActivityInfo._repeated_rewardedScores_codec);
					continue;
				}
				if (num <= 32U)
				{
					if (num == 26U)
					{
						goto IL_88;
					}
					if (num != 32U)
					{
						goto IL_4E;
					}
				}
				else if (num != 34U)
				{
					if (num != 40U && num != 42U)
					{
						goto IL_4E;
					}
					this.rewardedBuffTypeIds_.AddEntriesFrom(ref input, RiskHarvestActivityInfo._repeated_rewardedBuffTypeIds_codec);
					continue;
				}
				this.unlockBuffGroups_.AddEntriesFrom(ref input, RiskHarvestActivityInfo._repeated_unlockBuffGroups_codec);
				continue;
				IL_4E:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_88:
				this.rewardedBuffGroups_.AddEntriesFrom(ref input, RiskHarvestActivityInfo._repeated_rewardedBuffGroups_codec);
			}
		}

		// Token: 0x04007E7D RID: 32381
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E7E RID: 32382
		public const int InstInfosFieldNumber = 1;

		// Token: 0x04007E7F RID: 32383
		private static readonly FieldCodec<RiskHarvestInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<RiskHarvestInstInfo>(10U, RiskHarvestInstInfo.Parser);

		// Token: 0x04007E80 RID: 32384
		private readonly RepeatedField<RiskHarvestInstInfo> instInfos_ = new RepeatedField<RiskHarvestInstInfo>();

		// Token: 0x04007E81 RID: 32385
		public const int RewardedScoresFieldNumber = 2;

		// Token: 0x04007E82 RID: 32386
		private static readonly FieldCodec<int> _repeated_rewardedScores_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007E83 RID: 32387
		private readonly RepeatedField<int> rewardedScores_ = new RepeatedField<int>();

		// Token: 0x04007E84 RID: 32388
		public const int RewardedBuffGroupsFieldNumber = 3;

		// Token: 0x04007E85 RID: 32389
		private static readonly FieldCodec<int> _repeated_rewardedBuffGroups_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007E86 RID: 32390
		private readonly RepeatedField<int> rewardedBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007E87 RID: 32391
		public const int UnlockBuffGroupsFieldNumber = 4;

		// Token: 0x04007E88 RID: 32392
		private static readonly FieldCodec<int> _repeated_unlockBuffGroups_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007E89 RID: 32393
		private readonly RepeatedField<int> unlockBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007E8A RID: 32394
		public const int RewardedBuffTypeIdsFieldNumber = 5;

		// Token: 0x04007E8B RID: 32395
		private static readonly FieldCodec<int> _repeated_rewardedBuffTypeIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007E8C RID: 32396
		private readonly RepeatedField<int> rewardedBuffTypeIds_ = new RepeatedField<int>();
	}
}
