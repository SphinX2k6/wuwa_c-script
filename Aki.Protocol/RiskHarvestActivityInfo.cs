using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F43 RID: 3907
	public sealed class RiskHarvestActivityInfo : IMessage<RiskHarvestActivityInfo>, IMessage, IEquatable<RiskHarvestActivityInfo>, IDeepCloneable<RiskHarvestActivityInfo>, IBufferMessage
	{
		// Token: 0x06014EE3 RID: 85731 RVA: 0x00309F3D File Offset: 0x0030813D
		[NullableContext(1)]
		public static RiskHarvestActivityInfo Create()
		{
			return new RiskHarvestActivityInfo();
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x06014EE4 RID: 85732 RVA: 0x00309F44 File Offset: 0x00308144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x06014EE5 RID: 85733 RVA: 0x00309F47 File Offset: 0x00308147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestActivityInfo.Descriptor;
			}
		}

		// Token: 0x06014EE6 RID: 85734 RVA: 0x00309F4E File Offset: 0x0030814E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo()
		{
		}

		// Token: 0x06014EE7 RID: 85735 RVA: 0x00309F90 File Offset: 0x00308190
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

		// Token: 0x06014EE8 RID: 85736 RVA: 0x0030A009 File Offset: 0x00308209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestActivityInfo Clone()
		{
			return new RiskHarvestActivityInfo(this);
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x06014EE9 RID: 85737 RVA: 0x0030A011 File Offset: 0x00308211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RiskHarvestInstInfo> InstInfos
		{
			get
			{
				return this.instInfos_;
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x06014EEA RID: 85738 RVA: 0x0030A019 File Offset: 0x00308219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedScores
		{
			get
			{
				return this.rewardedScores_;
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x06014EEB RID: 85739 RVA: 0x0030A021 File Offset: 0x00308221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBuffGroups
		{
			get
			{
				return this.rewardedBuffGroups_;
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x06014EEC RID: 85740 RVA: 0x0030A029 File Offset: 0x00308229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBuffGroups
		{
			get
			{
				return this.unlockBuffGroups_;
			}
		}

		// Token: 0x170045AA RID: 17834
		// (get) Token: 0x06014EED RID: 85741 RVA: 0x0030A031 File Offset: 0x00308231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedBuffTypeIds
		{
			get
			{
				return this.rewardedBuffTypeIds_;
			}
		}

		// Token: 0x06014EEE RID: 85742 RVA: 0x0030A039 File Offset: 0x00308239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestActivityInfo);
		}

		// Token: 0x06014EEF RID: 85743 RVA: 0x0030A048 File Offset: 0x00308248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestActivityInfo other)
		{
			return other != null && (other == this || (this.instInfos_.Equals(other.instInfos_) && this.rewardedScores_.Equals(other.rewardedScores_) && this.rewardedBuffGroups_.Equals(other.rewardedBuffGroups_) && this.unlockBuffGroups_.Equals(other.unlockBuffGroups_) && this.rewardedBuffTypeIds_.Equals(other.rewardedBuffTypeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x0030A0DC File Offset: 0x003082DC
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

		// Token: 0x06014EF1 RID: 85745 RVA: 0x0030A148 File Offset: 0x00308348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x0030A155 File Offset: 0x00308355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EF3 RID: 85747 RVA: 0x0030A160 File Offset: 0x00308360
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

		// Token: 0x06014EF4 RID: 85748 RVA: 0x0030A1D8 File Offset: 0x003083D8
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

		// Token: 0x06014EF5 RID: 85749 RVA: 0x0030A260 File Offset: 0x00308460
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

		// Token: 0x06014EF6 RID: 85750 RVA: 0x0030A2DD File Offset: 0x003084DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EF7 RID: 85751 RVA: 0x0030A2E8 File Offset: 0x003084E8
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

		// Token: 0x04007EA7 RID: 32423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007EA8 RID: 32424
		public const int InstInfosFieldNumber = 1;

		// Token: 0x04007EA9 RID: 32425
		private static readonly FieldCodec<RiskHarvestInstInfo> _repeated_instInfos_codec = FieldCodec.ForMessage<RiskHarvestInstInfo>(10U, RiskHarvestInstInfo.Parser);

		// Token: 0x04007EAA RID: 32426
		private readonly RepeatedField<RiskHarvestInstInfo> instInfos_ = new RepeatedField<RiskHarvestInstInfo>();

		// Token: 0x04007EAB RID: 32427
		public const int RewardedScoresFieldNumber = 2;

		// Token: 0x04007EAC RID: 32428
		private static readonly FieldCodec<int> _repeated_rewardedScores_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007EAD RID: 32429
		private readonly RepeatedField<int> rewardedScores_ = new RepeatedField<int>();

		// Token: 0x04007EAE RID: 32430
		public const int RewardedBuffGroupsFieldNumber = 3;

		// Token: 0x04007EAF RID: 32431
		private static readonly FieldCodec<int> _repeated_rewardedBuffGroups_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007EB0 RID: 32432
		private readonly RepeatedField<int> rewardedBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007EB1 RID: 32433
		public const int UnlockBuffGroupsFieldNumber = 4;

		// Token: 0x04007EB2 RID: 32434
		private static readonly FieldCodec<int> _repeated_unlockBuffGroups_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007EB3 RID: 32435
		private readonly RepeatedField<int> unlockBuffGroups_ = new RepeatedField<int>();

		// Token: 0x04007EB4 RID: 32436
		public const int RewardedBuffTypeIdsFieldNumber = 5;

		// Token: 0x04007EB5 RID: 32437
		private static readonly FieldCodec<int> _repeated_rewardedBuffTypeIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007EB6 RID: 32438
		private readonly RepeatedField<int> rewardedBuffTypeIds_ = new RepeatedField<int>();
	}
}
