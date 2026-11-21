using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200132E RID: 4910
	public sealed class SurvivorsActivityData : IMessage<SurvivorsActivityData>, IMessage, IEquatable<SurvivorsActivityData>, IDeepCloneable<SurvivorsActivityData>, IBufferMessage
	{
		// Token: 0x0601A2C6 RID: 107206 RVA: 0x003D071A File Offset: 0x003CE91A
		[NullableContext(1)]
		public static SurvivorsActivityData Create()
		{
			return new SurvivorsActivityData();
		}

		// Token: 0x1700589E RID: 22686
		// (get) Token: 0x0601A2C7 RID: 107207 RVA: 0x003D0721 File Offset: 0x003CE921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700589F RID: 22687
		// (get) Token: 0x0601A2C8 RID: 107208 RVA: 0x003D0724 File Offset: 0x003CE924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsActivityData.Descriptor;
			}
		}

		// Token: 0x0601A2C9 RID: 107209 RVA: 0x003D072C File Offset: 0x003CE92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData()
		{
		}

		// Token: 0x0601A2CA RID: 107210 RVA: 0x003D0784 File Offset: 0x003CE984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData(SurvivorsActivityData other) : this()
		{
			this.normalTaskData_ = ((other.normalTaskData_ != null) ? other.normalTaskData_.Clone() : null);
			this.scoreTaskDatas_ = other.scoreTaskDatas_.Clone();
			this.unlockWeaponHandBooks_ = other.unlockWeaponHandBooks_.Clone();
			this.unlockRoleHandBooks_ = other.unlockRoleHandBooks_.Clone();
			this.unlockItemHandBooks_ = other.unlockItemHandBooks_.Clone();
			this.talentSkillDict_ = other.talentSkillDict_.Clone();
			this.survivorsChallengeInfos_ = other.survivorsChallengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A2CB RID: 107211 RVA: 0x003D082A File Offset: 0x003CEA2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsActivityData Clone()
		{
			return new SurvivorsActivityData(this);
		}

		// Token: 0x170058A0 RID: 22688
		// (get) Token: 0x0601A2CC RID: 107212 RVA: 0x003D0832 File Offset: 0x003CEA32
		// (set) Token: 0x0601A2CD RID: 107213 RVA: 0x003D083A File Offset: 0x003CEA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTaskData NormalTaskData
		{
			get
			{
				return this.normalTaskData_;
			}
			set
			{
				this.normalTaskData_ = value;
			}
		}

		// Token: 0x170058A1 RID: 22689
		// (get) Token: 0x0601A2CE RID: 107214 RVA: 0x003D0843 File Offset: 0x003CEA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreTaskDatas
		{
			get
			{
				return this.scoreTaskDatas_;
			}
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x0601A2CF RID: 107215 RVA: 0x003D084B File Offset: 0x003CEA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockWeaponHandBooks
		{
			get
			{
				return this.unlockWeaponHandBooks_;
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x0601A2D0 RID: 107216 RVA: 0x003D0853 File Offset: 0x003CEA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleHandBooks
		{
			get
			{
				return this.unlockRoleHandBooks_;
			}
		}

		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x0601A2D1 RID: 107217 RVA: 0x003D085B File Offset: 0x003CEA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockItemHandBooks
		{
			get
			{
				return this.unlockItemHandBooks_;
			}
		}

		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x0601A2D2 RID: 107218 RVA: 0x003D0863 File Offset: 0x003CEA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x0601A2D3 RID: 107219 RVA: 0x003D086B File Offset: 0x003CEA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SurvivorsChallengeInfo> SurvivorsChallengeInfos
		{
			get
			{
				return this.survivorsChallengeInfos_;
			}
		}

		// Token: 0x0601A2D4 RID: 107220 RVA: 0x003D0873 File Offset: 0x003CEA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsActivityData);
		}

		// Token: 0x0601A2D5 RID: 107221 RVA: 0x003D0884 File Offset: 0x003CEA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsActivityData other)
		{
			return other != null && (other == this || (object.Equals(this.NormalTaskData, other.NormalTaskData) && this.scoreTaskDatas_.Equals(other.scoreTaskDatas_) && this.unlockWeaponHandBooks_.Equals(other.unlockWeaponHandBooks_) && this.unlockRoleHandBooks_.Equals(other.unlockRoleHandBooks_) && this.unlockItemHandBooks_.Equals(other.unlockItemHandBooks_) && this.TalentSkillDict.Equals(other.TalentSkillDict) && this.survivorsChallengeInfos_.Equals(other.survivorsChallengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x003D0940 File Offset: 0x003CEB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.normalTaskData_ != null)
			{
				num ^= this.NormalTaskData.GetHashCode();
			}
			num ^= this.scoreTaskDatas_.GetHashCode();
			num ^= this.unlockWeaponHandBooks_.GetHashCode();
			num ^= this.unlockRoleHandBooks_.GetHashCode();
			num ^= this.unlockItemHandBooks_.GetHashCode();
			num ^= this.TalentSkillDict.GetHashCode();
			num ^= this.survivorsChallengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x003D09D0 File Offset: 0x003CEBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A2D8 RID: 107224 RVA: 0x003D09DD File Offset: 0x003CEBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2D9 RID: 107225 RVA: 0x003D09E8 File Offset: 0x003CEBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.normalTaskData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NormalTaskData);
			}
			this.scoreTaskDatas_.WriteTo(ref output, SurvivorsActivityData._repeated_scoreTaskDatas_codec);
			this.unlockWeaponHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
			this.unlockRoleHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
			this.unlockItemHandBooks_.WriteTo(ref output, SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
			this.talentSkillDict_.WriteTo(ref output, SurvivorsActivityData._map_talentSkillDict_codec);
			this.survivorsChallengeInfos_.WriteTo(ref output, SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2DA RID: 107226 RVA: 0x003D0A8C File Offset: 0x003CEC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.normalTaskData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NormalTaskData);
			}
			num += this.scoreTaskDatas_.CalculateSize(SurvivorsActivityData._repeated_scoreTaskDatas_codec);
			num += this.unlockWeaponHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
			num += this.unlockRoleHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
			num += this.unlockItemHandBooks_.CalculateSize(SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
			num += this.talentSkillDict_.CalculateSize(SurvivorsActivityData._map_talentSkillDict_codec);
			num += this.survivorsChallengeInfos_.CalculateSize(SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2DB RID: 107227 RVA: 0x003D0B3C File Offset: 0x003CED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.normalTaskData_ != null)
			{
				if (this.normalTaskData_ == null)
				{
					this.NormalTaskData = new ActivityTaskData();
				}
				this.NormalTaskData.MergeFrom(other.NormalTaskData);
			}
			this.scoreTaskDatas_.Add(other.scoreTaskDatas_);
			this.unlockWeaponHandBooks_.Add(other.unlockWeaponHandBooks_);
			this.unlockRoleHandBooks_.Add(other.unlockRoleHandBooks_);
			this.unlockItemHandBooks_.Add(other.unlockItemHandBooks_);
			this.talentSkillDict_.MergeFrom(other.talentSkillDict_);
			this.survivorsChallengeInfos_.Add(other.survivorsChallengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2DC RID: 107228 RVA: 0x003D0BF6 File Offset: 0x003CEDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2DD RID: 107229 RVA: 0x003D0C00 File Offset: 0x003CEE00
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
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.normalTaskData_ == null)
							{
								this.NormalTaskData = new ActivityTaskData();
							}
							input.ReadMessage(this.NormalTaskData);
							continue;
						}
						if (num != 16U)
						{
							goto IL_76;
						}
					}
					else if (num != 18U)
					{
						if (num != 24U && num != 26U)
						{
							goto IL_76;
						}
						this.unlockWeaponHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockWeaponHandBooks_codec);
						continue;
					}
					this.scoreTaskDatas_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_scoreTaskDatas_codec);
					continue;
				}
				if (num <= 40U)
				{
					if (num == 32U || num == 34U)
					{
						this.unlockRoleHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockRoleHandBooks_codec);
						continue;
					}
					if (num != 40U)
					{
						goto IL_76;
					}
				}
				else if (num != 42U)
				{
					if (num == 50U)
					{
						this.talentSkillDict_.AddEntriesFrom(ref input, SurvivorsActivityData._map_talentSkillDict_codec);
						continue;
					}
					if (num != 58U)
					{
						goto IL_76;
					}
					this.survivorsChallengeInfos_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_survivorsChallengeInfos_codec);
					continue;
				}
				this.unlockItemHandBooks_.AddEntriesFrom(ref input, SurvivorsActivityData._repeated_unlockItemHandBooks_codec);
				continue;
				IL_76:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099F1 RID: 39409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099F2 RID: 39410
		public const int NormalTaskDataFieldNumber = 1;

		// Token: 0x040099F3 RID: 39411
		private ActivityTaskData normalTaskData_;

		// Token: 0x040099F4 RID: 39412
		public const int ScoreTaskDatasFieldNumber = 2;

		// Token: 0x040099F5 RID: 39413
		private static readonly FieldCodec<int> _repeated_scoreTaskDatas_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040099F6 RID: 39414
		private readonly RepeatedField<int> scoreTaskDatas_ = new RepeatedField<int>();

		// Token: 0x040099F7 RID: 39415
		public const int UnlockWeaponHandBooksFieldNumber = 3;

		// Token: 0x040099F8 RID: 39416
		private static readonly FieldCodec<int> _repeated_unlockWeaponHandBooks_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040099F9 RID: 39417
		private readonly RepeatedField<int> unlockWeaponHandBooks_ = new RepeatedField<int>();

		// Token: 0x040099FA RID: 39418
		public const int UnlockRoleHandBooksFieldNumber = 4;

		// Token: 0x040099FB RID: 39419
		private static readonly FieldCodec<int> _repeated_unlockRoleHandBooks_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040099FC RID: 39420
		private readonly RepeatedField<int> unlockRoleHandBooks_ = new RepeatedField<int>();

		// Token: 0x040099FD RID: 39421
		public const int UnlockItemHandBooksFieldNumber = 5;

		// Token: 0x040099FE RID: 39422
		private static readonly FieldCodec<int> _repeated_unlockItemHandBooks_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040099FF RID: 39423
		private readonly RepeatedField<int> unlockItemHandBooks_ = new RepeatedField<int>();

		// Token: 0x04009A00 RID: 39424
		public const int TalentSkillDictFieldNumber = 6;

		// Token: 0x04009A01 RID: 39425
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x04009A02 RID: 39426
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();

		// Token: 0x04009A03 RID: 39427
		public const int SurvivorsChallengeInfosFieldNumber = 7;

		// Token: 0x04009A04 RID: 39428
		private static readonly FieldCodec<SurvivorsChallengeInfo> _repeated_survivorsChallengeInfos_codec = FieldCodec.ForMessage<SurvivorsChallengeInfo>(58U, SurvivorsChallengeInfo.Parser);

		// Token: 0x04009A05 RID: 39429
		private readonly RepeatedField<SurvivorsChallengeInfo> survivorsChallengeInfos_ = new RepeatedField<SurvivorsChallengeInfo>();
	}
}
